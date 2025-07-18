using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GeneralReplaceTool : EditorWindow
{
    private string findText = "";
    private string replaceText = "";
    private Vector2 scrollPosition;
    // 新增：用于结果区域的滚动位置
    private Vector2 resultsScrollPosition;
    private List<Issue> issues = new List<Issue>();
    private bool showUIIssues = true;
    private bool showScriptIssues = true;
    private bool isProcessing = false;
    private bool useRegex = false;
    
    // 可配置的搜索目录
    private string[] searchDirectories = new[]
    {
        "Assets/Bundles/UI",
        "Assets/Hotfix",
        "Assets/HotfixView",
        "Assets/Model",
        "Assets/ModelView"
    };
    
    // 可配置的文件类型
    private string[] fileTypes = new[]
    {
        "*.prefab",
        "*.cs"
    };

    [MenuItem("Tools/通用文本替换工具")]
    public static void ShowWindow()
    {
        GetWindow<GeneralReplaceTool>("通用文本替换工具");
        // 设置窗口默认大小，提供更多显示空间
        GetWindow<GeneralReplaceTool>().minSize = new Vector2(800, 600);
    }

    private void OnGUI()
    {
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUILayout.LabelField("查找和替换设置", EditorStyles.boldLabel);
        
        findText = EditorGUILayout.TextField("查找内容:", findText);
        replaceText = EditorGUILayout.TextField("替换为:", replaceText);
        useRegex = EditorGUILayout.Toggle("使用正则表达式", useRegex);
        
        EditorGUILayout.EndVertical();
        
        EditorGUILayout.Space();
        
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUILayout.LabelField("搜索设置", EditorStyles.boldLabel);
        
        // 使用滚动视图包裹目录设置，防止目录过多时溢出
        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Height(120));
        for (int i = 0; i < searchDirectories.Length; i++)
        {
            EditorGUILayout.BeginHorizontal();
            searchDirectories[i] = EditorGUILayout.TextField($"目录 {i + 1}:", searchDirectories[i]);
            if (GUILayout.Button("浏览", GUILayout.Width(60)))
            {
                string path = EditorUtility.OpenFolderPanel("选择目录", Application.dataPath, "");
                if (!string.IsNullOrEmpty(path) && path.StartsWith(Application.dataPath))
                {
                    searchDirectories[i] = "Assets" + path.Substring(Application.dataPath.Length);
                }
            }
            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.EndScrollView();
        
        if (GUILayout.Button("添加目录"))
        {
            Array.Resize(ref searchDirectories, searchDirectories.Length + 1);
            searchDirectories[searchDirectories.Length - 1] = "Assets/";
        }
        
        EditorGUILayout.Space();
        
        EditorGUILayout.LabelField("文件类型:", EditorStyles.miniBoldLabel);
        string fileTypesStr = string.Join(", ", fileTypes);
        fileTypesStr = EditorGUILayout.TextField(fileTypesStr);
        fileTypes = fileTypesStr.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Trim()).ToArray();
        
        EditorGUILayout.EndVertical();
        
        EditorGUILayout.Space();
        
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("执行查找", GUILayout.Height(30)))
        {
            if (string.IsNullOrEmpty(findText))
            {
                EditorUtility.DisplayDialog("提示", "请输入查找内容", "确定");
                return;
            }
            
            FindAllOccurrences();
        }
        
        GUI.enabled = issues.Any() && !isProcessing;
        if (GUILayout.Button("替换所有", GUILayout.Height(30)))
        {
            if (EditorUtility.DisplayDialog("确认替换", 
                $"确定要将所有 \"{findText}\" 替换为 \"{replaceText}\" 吗？\n\n共找到 {issues.Count} 处匹配项。", 
                "确定", "取消"))
            {
                ReplaceAllOccurrences();
            }
        }
        GUI.enabled = true;
        EditorGUILayout.EndHorizontal();
        
        GUILayout.Space(20);
        
        // 结果显示区域添加滚动视图
        EditorGUILayout.BeginVertical();
        if (isProcessing)
        {
            EditorGUILayout.HelpBox("处理中，请稍候...", MessageType.Info);
        }
        else if (issues.Any())
        {
            EditorGUILayout.LabelField($"共发现 {issues.Count} 个匹配项", EditorStyles.boldLabel);
            
            // 添加滚动视图，使结果可以滚动查看
            resultsScrollPosition = EditorGUILayout.BeginScrollView(resultsScrollPosition);
            
            // 显示UI问题的折叠区域
            showUIIssues = EditorGUILayout.Foldout(showUIIssues, $"预制体 问题 ({issues.Count(i => i.Type == IssueType.Prefab)})");
            if (showUIIssues)
            {
                foreach (var issue in issues.Where(i => i.Type == IssueType.Prefab))
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
            
            EditorGUILayout.EndScrollView();
        }
        else if (!isProcessing && !string.IsNullOrEmpty(findText))
        {
            EditorGUILayout.HelpBox("未发现匹配项。", MessageType.Info);
        }
        EditorGUILayout.EndVertical();
        
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("提示: 预制体中的替换仅影响Text组件的文本内容", EditorStyles.miniLabel);
    }

    private void DrawIssue(Issue issue)
    {
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        
        EditorGUILayout.BeginHorizontal();
        // 使用LabelField并设置最大宽度，防止路径过长导致显示问题
        EditorGUILayout.LabelField(issue.Path, EditorStyles.boldLabel, GUILayout.MaxWidth(500));
        
        if (GUILayout.Button("定位", GUILayout.Width(60)))
        {
            if (issue.Type == IssueType.Prefab)
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
        else if (issue.Type == IssueType.Prefab)
        {
            EditorGUILayout.LabelField($"组件路径: {issue.ComponentPath}");
        }
        
        // 为问题文本添加水平滚动功能
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("问题文本: ", GUILayout.Width(70));
        Vector2 textScroll = Vector2.zero;
        textScroll = EditorGUILayout.BeginScrollView(textScroll, GUILayout.Height(40), GUILayout.ExpandWidth(true));
        EditorGUILayout.LabelField(issue.ProblemText);
        EditorGUILayout.EndScrollView();
        EditorGUILayout.EndHorizontal();
        
        EditorGUILayout.EndVertical();
        GUILayout.Space(5);
    }

    // 以下方法保持不变
    private void FindAllOccurrences()
    {
        isProcessing = true;
        issues.Clear();
        Repaint();
        
        EditorApplication.delayCall += () =>
        {
            try
            {
                int totalFiles = 0;
                int processedFiles = 0;
                
                // 统计总文件数
                foreach (var directory in searchDirectories)
                {
                    if (!Directory.Exists(directory)) continue;
                    
                    foreach (var fileType in fileTypes)
                    {
                        totalFiles += Directory.GetFiles(directory, fileType, SearchOption.AllDirectories).Length;
                    }
                }
                
                // 处理每个目录
                foreach (var directory in searchDirectories)
                {
                    if (!Directory.Exists(directory)) continue;
                    
                    foreach (var fileType in fileTypes)
                    {
                        var files = Directory.GetFiles(directory, fileType, SearchOption.AllDirectories);
                        foreach (var file in files)
                        {
                            try
                            {
                                if (file.EndsWith(".prefab"))
                                {
                                    FindInPrefab(file);
                                }
                                else if (file.EndsWith(".cs"))
                                {
                                    FindScriptMatches(file);
                                }
                                // 可以在这里添加更多文件类型的处理逻辑
                            }
                            catch (Exception e)
                            {
                                Debug.LogWarning($"处理文件 {file} 时出错: {e.Message}");
                            }
                            
                            processedFiles++;
                            if (processedFiles % 10 == 0)
                            {
                                EditorUtility.DisplayProgressBar("查找匹配项", 
                                    $"处理中: {processedFiles}/{totalFiles}", 
                                    (float)processedFiles / totalFiles);
                            }
                        }
                    }
                }
                
                AssetDatabase.Refresh();
                Debug.Log($"共发现 {issues.Count} 个匹配项");
            }
            catch (Exception e)
            {
                Debug.LogError($"查找过程中发生错误: {e.Message}");
            }
            finally
            {
                EditorUtility.ClearProgressBar();
                isProcessing = false;
                Repaint();
            }
        };
    }

    private void FindInPrefab(string path)
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        if (prefab == null) return;
        
        var textComponents = prefab.GetComponentsInChildren<Text>(true);
        foreach (var textComp in textComponents)
        {
            if (CheckAndAddIssue(textComp.text, path, IssueType.Prefab, GetComponentPath(textComp)))
            {
                // 已经添加了问题
            }
        }
    }

    private void FindScriptMatches(string path)
    {
        string[] lines = File.ReadAllLines(path);
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            
            // 使用更精确的正则表达式查找字符串字面量
            // 处理单引号和双引号字符串，忽略转义的引号
            var stringMatches = Regex.Matches(line, @"@?""((?:\\.|[^""\\])*)""|'((?:\\.|[^'\\])*)'");
            foreach (Match stringMatch in stringMatches)
            {
                string content = stringMatch.Groups[0].Value;
                
                // 检查字符串内是否包含查找内容
                if (CheckAndAddIssue(content, path, IssueType.Script, "", i + 1))
                {
                    // 已经添加了问题
                }
            }
        }
    }

    private bool CheckAndAddIssue(string content, string path, IssueType type, string componentPath = "", int lineNumber = 0)
    {
        bool found = false;
        
        if (useRegex)
        {
            try
            {
                if (Regex.IsMatch(content, findText))
                {
                    found = true;
                }
            }
            catch (Exception e)
            {
                Debug.LogWarning($"正则表达式错误: {e.Message}");
                return false;
            }
        }
        else
        {
            if (content.Contains(findText))
            {
                found = true;
            }
        }
        
        if (found)
        {
            issues.Add(new Issue
            {
                Type = type,
                Path = path,
                LineNumber = lineNumber,
                ProblemText = content,
                ComponentPath = componentPath
            });
        }
        
        return found;
    }

    private void ReplaceAllOccurrences()
    {
        if (!issues.Any()) return;
        
        isProcessing = true;
        Repaint();
        
        EditorApplication.delayCall += () =>
        {
            try
            {
                int processed = 0;
                
                foreach (var issue in issues)
                {
                    ReplaceIssue(issue);
                    
                    processed++;
                    if (processed % 10 == 0)
                    {
                        EditorUtility.DisplayProgressBar("替换匹配项", 
                            $"处理中: {processed}/{issues.Count}", 
                            (float)processed / issues.Count);
                    }
                }
                
                issues.Clear();
                AssetDatabase.Refresh();
                Debug.Log("所有匹配项已替换");
            }
            catch (Exception e)
            {
                Debug.LogError($"替换过程中发生错误: {e.Message}");
            }
            finally
            {
                EditorUtility.ClearProgressBar();
                isProcessing = false;
                Repaint();
            }
        };
    }

    private void ReplaceIssue(Issue issue)
    {
        try
        {
            if (issue.Type == IssueType.Prefab)
            {
                // 替换预制体文本
                var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(issue.Path);
                if (prefab == null) return;
                
                var textComponents = prefab.GetComponentsInChildren<Text>(true);
                foreach (var textComp in textComponents)
                {
                    if (useRegex)
                    {
                        try
                        {
                            textComp.text = Regex.Replace(textComp.text, findText, replaceText);
                        }
                        catch (Exception e)
                        {
                            Debug.LogWarning($"正则表达式替换错误: {e.Message}");
                            continue;
                        }
                    }
                    else
                    {
                        textComp.text = textComp.text.Replace(findText, replaceText);
                    }
                }
                
                // 保存预制体
                PrefabUtility.SaveAsPrefabAsset(prefab, issue.Path);
                Debug.Log($"已替换预制体: {issue.Path}");
            }
            else if (issue.Type == IssueType.Script)
            {
                // 替换脚本中的文本
                string[] lines = File.ReadAllLines(issue.Path);
                
                // 使用更精确的正则表达式替换字符串字面量
                lines[issue.LineNumber - 1] = Regex.Replace(lines[issue.LineNumber - 1], 
                    @"(@?""((?:\\.|[^""\\])*)"")|('((?:\\.|[^'\\])*)')", 
                    match =>
                {
                    string content = match.Groups[0].Value;
                    
                    // 只替换字符串内部的内容
                    if (useRegex)
                    {
                        try
                        {
                            // 提取实际的字符串内容（不包括引号）
                            string innerContent = match.Groups[2].Success ? match.Groups[2].Value : match.Groups[4].Value;
                            string replacedContent = Regex.Replace(innerContent, findText, replaceText);
                            
                            // 重新构建带引号的字符串
                            if (match.Groups[1].Success) // 双引号字符串
                            {
                                if (match.Value.StartsWith("@"))
                                    return "@\"" + replacedContent + "\"";
                                else
                                    return "\"" + replacedContent + "\"";
                            }
                            else // 单引号字符串
                            {
                                return "'" + replacedContent + "'";
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.LogWarning($"正则表达式替换错误: {e.Message}");
                            return content;
                        }
                    }
                    else
                    {
                        // 提取实际的字符串内容（不包括引号）
                        string innerContent = match.Groups[2].Success ? match.Groups[2].Value : match.Groups[4].Value;
                        string replacedContent = innerContent.Replace(findText, replaceText);
                        
                        // 重新构建带引号的字符串
                        if (match.Groups[1].Success) // 双引号字符串
                        {
                            if (match.Value.StartsWith("@"))
                                return "@\"" + replacedContent + "\"";
                            else
                                return "\"" + replacedContent + "\"";
                        }
                        else // 单引号字符串
                        {
                            return "'" + replacedContent + "'";
                        }
                    }
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

    private enum IssueType
    {
        Prefab,
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