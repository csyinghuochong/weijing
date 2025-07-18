using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ChineseCommaFixer : EditorWindow
{
    private string UIDirectory = "Assets/Bundles/UI";
    private string[] ScriptDirectories = new[]
    {
        "Assets/Hotfix",
        "Assets/HotfixView",
        "Assets/Model",
        "Assets/ModelView"
    };

    private Vector2 scrollPosition;
    private List<Issue> issues = new List<Issue>();
    private bool showUIIssues = true;
    private bool showScriptIssues = true;
    private bool isProcessing = false;

    [MenuItem("Tools/全角逗号检查工具")]
    public static void ShowWindow()
    {
        GetWindow<ChineseCommaFixer>("全角逗号检查工具");
    }

    private void OnGUI()
    {
        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
        
        GUILayout.Space(10);
        
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("检查全角逗号", GUILayout.Height(30)))
        {
            FindAllFullWidthCommas();
        }
        
        GUI.enabled = issues.Any() && !isProcessing;
        if (GUILayout.Button("替换所有全角逗号", GUILayout.Height(30)))
        {
            ReplaceAllFullWidthCommas();
        }
        GUI.enabled = true;
        EditorGUILayout.EndHorizontal();
        
        GUILayout.Space(20);
        
        if (isProcessing)
        {
            EditorGUILayout.HelpBox("处理中，请稍候...", MessageType.Info);
        }
        else if (issues.Any())
        {
            EditorGUILayout.LabelField($"共发现 {issues.Count} 个全角逗号问题", EditorStyles.boldLabel);
            
            // 显示UI问题的折叠区域
            showUIIssues = EditorGUILayout.Foldout(showUIIssues, $"UI 问题 ({issues.Count(i => i.Type == IssueType.UI)})");
            if (showUIIssues)
            {
                foreach (var issue in issues.Where(i => i.Type == IssueType.UI))
                {
                    DrawIssue(issue);
                }
            }
            
            // 显示脚本问题的折叠区域
            showScriptIssues = EditorGUILayout.Foldout(showScriptIssues, $"脚本 问题 ({issues.Count(i => i.Type == IssueType.Script)})");
            if (showScriptIssues)
            {
                foreach (var issue in issues.Where(i => i.Type == IssueType.Script))
                {
                    DrawIssue(issue);
                }
            }
        }
        else if (!isProcessing)
        {
            EditorGUILayout.HelpBox("未发现全角逗号问题。", MessageType.Info);
        }
        
        EditorGUILayout.EndScrollView();
    }

    private void DrawIssue(Issue issue)
    {
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField(issue.Path, EditorStyles.boldLabel);
        
        if (GUILayout.Button("定位", GUILayout.Width(60)))
        {
            if (issue.Type == IssueType.UI)
            {
                var obj = AssetDatabase.LoadAssetAtPath<GameObject>(issue.Path);
                if (obj)
                {
                    Selection.activeObject = obj;
                    EditorGUIUtility.PingObject(obj);
                }
            }
            else
            {
                var asset = AssetDatabase.LoadAssetAtPath<MonoScript>(issue.Path);
                if (asset)
                {
                    AssetDatabase.OpenAsset(asset, issue.LineNumber);
                }
            }
        }
        
        if (GUILayout.Button("替换", GUILayout.Width(60)))
        {
            ReplaceIssue(issue);
        }
        EditorGUILayout.EndHorizontal();
        
        if (issue.Type == IssueType.Script)
        {
            EditorGUILayout.LabelField($"行号: {issue.LineNumber}");
        }
        
        EditorGUILayout.LabelField($"问题文本: {issue.ProblemText}");
        
        EditorGUILayout.EndVertical();
        GUILayout.Space(5);
    }

    private void FindAllFullWidthCommas()
    {
        isProcessing = true;
        issues.Clear();
        Repaint();
        
        EditorApplication.delayCall += () =>
        {
            try
            {
                // 检查UI中的Text组件
                FindUIFullWidthCommas();
                
                // 检查脚本中的字符串
                FindScriptFullWidthCommas();
                
                AssetDatabase.Refresh();
                Debug.Log($"共发现 {issues.Count} 个全角逗号问题");
            }
            catch (Exception e)
            {
                Debug.LogError($"检查过程中发生错误: {e.Message}");
            }
            finally
            {
                isProcessing = false;
                Repaint();
            }
        };
    }

    private void FindUIFullWidthCommas()
    {
        var guids = AssetDatabase.FindAssets("t:Prefab", new[] { UIDirectory });
        int processed = 0;
        
        foreach (var guid in guids)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            
            if (prefab == null) continue;
            
            var textComponents = prefab.GetComponentsInChildren<Text>(true);
            foreach (var textComp in textComponents)
            {
                if (textComp.text.Contains('，'))
                {
                    issues.Add(new Issue
                    {
                        Type = IssueType.UI,
                        Path = path,
                        ProblemText = textComp.text,
                        ComponentPath = GetComponentPath(textComp)
                    });
                }
            }
            
            processed++;
            if (processed % 10 == 0)
            {
                EditorUtility.DisplayProgressBar("检查UI文本", $"处理中: {processed}/{guids.Length}", (float)processed / guids.Length);
            }
        }
        
        EditorUtility.ClearProgressBar();
    }

    private string GetComponentPath(Component component)
    {
        string path = component.name;
        Transform parent = component.transform.parent;
        
        while (parent != null)
        {
            path = parent.name + "/" + path;
            parent = parent.parent;
        }
        
        return path;
    }

    private void FindScriptFullWidthCommas()
    {
        int totalFiles = 0;
        int processedFiles = 0;
        
        // 统计总文件数
        foreach (var directory in ScriptDirectories)
        {
            if (Directory.Exists(directory))
            {
                totalFiles += Directory.GetFiles(directory, "*.cs", SearchOption.AllDirectories).Length;
            }
        }
        
        // 处理每个目录
        foreach (var directory in ScriptDirectories)
        {
            if (!Directory.Exists(directory)) continue;
            
            var files = Directory.GetFiles(directory, "*.cs", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                try
                {
                    string[] lines = File.ReadAllLines(file);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        
                        // 使用正则表达式查找双引号内的全角逗号
                        var matches = Regex.Matches(line, "\"([^\"]*)\"");
                        foreach (Match match in matches)
                        {
                            string content = match.Groups[1].Value;
                            if (content.Contains('，'))
                            {
                                issues.Add(new Issue
                                {
                                    Type = IssueType.Script,
                                    Path = file,
                                    LineNumber = i + 1,
                                    ProblemText = line.Trim()
                                });
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.LogWarning($"处理文件 {file} 时出错: {e.Message}");
                }
                
                processedFiles++;
                if (processedFiles % 10 == 0)
                {
                    EditorUtility.DisplayProgressBar("检查脚本", $"处理中: {processedFiles}/{totalFiles}", (float)processedFiles / totalFiles);
                }
            }
        }
        
        EditorUtility.ClearProgressBar();
    }

    private void ReplaceAllFullWidthCommas()
    {
        if (!issues.Any()) return;
        
        isProcessing = true;
        Repaint();
        
        EditorApplication.delayCall += () =>
        {
            try
            {
                // 替换所有问题
                foreach (var issue in issues)
                {
                    ReplaceIssue(issue);
                }
                
                issues.Clear();
                AssetDatabase.Refresh();
                Debug.Log("所有全角逗号已替换为半角逗号");
            }
            catch (Exception e)
            {
                Debug.LogError($"替换过程中发生错误: {e.Message}");
            }
            finally
            {
                isProcessing = false;
                Repaint();
            }
        };
    }

    private void ReplaceIssue(Issue issue)
    {
        try
        {
            if (issue.Type == IssueType.UI)
            {
                // 替换UI文本
                var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(issue.Path);
                if (prefab == null) return;
                
                var textComponents = prefab.GetComponentsInChildren<Text>(true);
                foreach (var textComp in textComponents)
                {
                    if (textComp.text.Contains('，'))
                    {
                        string original = textComp.text;
                        textComp.text = original.Replace('，', ',');
                        
                        // 保存预制体
                        PrefabUtility.SaveAsPrefabAsset(prefab, issue.Path);
                        Debug.Log($"已替换UI文本: {issue.Path} - {GetComponentPath(textComp)}");
                    }
                }
            }
            else
            {
                // 替换脚本中的文本
                string[] lines = File.ReadAllLines(issue.Path);
                
                // 使用正则表达式替换双引号内的全角逗号
                lines[issue.LineNumber - 1] = Regex.Replace(lines[issue.LineNumber - 1], "\"([^\"]*)\"", match =>
                {
                    string content = match.Groups[1].Value;
                    return "\"" + content.Replace('，', ',') + "\"";
                });
                
                File.WriteAllLines(issue.Path, lines);
                Debug.Log($"已替换脚本: {issue.Path} 第 {issue.LineNumber} 行");
            }
        }
        catch (Exception e)
        {
            Debug.LogError($"替换 {issue.Path} 时出错: {e.Message}");
        }
    }

    private enum IssueType
    {
        UI,
        Script
    }

    private class Issue
    {
        public IssueType Type;
        public string Path;
        public int LineNumber;
        public string ProblemText;
        public string ComponentPath;
    }
}    