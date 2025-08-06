using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class QueryAllPackagesChecker : EditorWindow
{
    private List<string> manifestFiles = new List<string>();
    private List<string> codeFilesWithPermission = new List<string>();
    private Vector2 scrollPosition;
    private bool hasQueryAllPackages = false;
    private const string PERMISSION_STRING = "android.permission.QUERY_ALL_PACKAGES";

    [MenuItem("Window/Android Tools/QUERY_ALL_PACKAGES Checker")]
    public static void ShowWindow()
    {
        GetWindow<QueryAllPackagesChecker>("QUERY_ALL_PACKAGES Checker");
    }

    private void OnEnable()
    {
        CheckForPermission();
    }

    private void CheckForPermission()
    {
        manifestFiles.Clear();
        codeFilesWithPermission.Clear();
        hasQueryAllPackages = false;

        // 查找所有AndroidManifest.xml文件
        FindManifestFiles();

        // 检查Manifest文件中的权限声明
        CheckManifestFiles();

        // 检查代码中是否有引用该权限
        CheckCodeFiles();
    }

    private void FindManifestFiles()
    {
        // 标准位置
        string[] standardPaths = new string[]
        {
            "Assets/Plugins/Android/AndroidManifest.xml",
            "Assets/Plugins/Android/Manifest.xml"
        };

        foreach (string path in standardPaths)
        {
            if (File.Exists(path))
            {
                manifestFiles.Add(path);
            }
        }

        // 搜索所有可能的Manifest文件
        string[] allManifestFiles = Directory.GetFiles(Application.dataPath, "AndroidManifest.xml", SearchOption.AllDirectories);
        foreach (string file in allManifestFiles)
        {
            string relativePath = file.Replace(Application.dataPath, "Assets");
            if (!manifestFiles.Contains(relativePath))
            {
                manifestFiles.Add(relativePath);
            }
        }
    }

    private void CheckManifestFiles()
    {
        foreach (string manifestPath in manifestFiles)
        {
            string content = File.ReadAllText(manifestPath);
            if (content.Contains(PERMISSION_STRING))
            {
                hasQueryAllPackages = true;
                break;
            }
        }
    }

    private void CheckCodeFiles()
    {
        // 搜索C#脚本中是否有引用该权限
        string[] csFiles = Directory.GetFiles(Application.dataPath, "*.cs", SearchOption.AllDirectories);
        foreach (string file in csFiles)
        {
            string content = File.ReadAllText(file);
            if (content.Contains(PERMISSION_STRING) ||
                content.Contains("QUERY_ALL_PACKAGES") &&
                (content.Contains("Permission") || content.Contains("Android")))
            {
                string relativePath = file.Replace(Application.dataPath, "Assets");
                codeFilesWithPermission.Add(relativePath);
            }
        }

        // 搜索Android插件代码
        string[] javaFiles = Directory.GetFiles(Application.dataPath, "*.java", SearchOption.AllDirectories);
        foreach (string file in javaFiles)
        {
            string content = File.ReadAllText(file);
            if (content.Contains(PERMISSION_STRING) ||
                content.Contains("QUERY_ALL_PACKAGES") && content.Contains("permission"))
            {
                string relativePath = file.Replace(Application.dataPath, "Assets");
                codeFilesWithPermission.Add(relativePath);
            }
        }
    }

    private void OnGUI()
    {
        GUILayout.Label("QUERY_ALL_PACKAGES 权限检查工具", EditorStyles.boldLabel);
        GUILayout.Space(10);

        if (GUILayout.Button("重新检查"))
        {
            CheckForPermission();
        }

        GUILayout.Space(10);
        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);

        // 显示Manifest检查结果
        GUILayout.Label("AndroidManifest.xml 检查结果:", EditorStyles.label);

        if (manifestFiles.Count == 0)
        {
            EditorGUILayout.HelpBox("未找到AndroidManifest.xml文件", MessageType.Warning);
        }
        else
        {
            if (hasQueryAllPackages)
            {
                EditorGUILayout.HelpBox("检测到项目中声明了 QUERY_ALL_PACKAGES 权限", MessageType.Warning);

                foreach (string manifestPath in manifestFiles)
                {
                    string content = File.ReadAllText(manifestPath);
                    if (content.Contains(PERMISSION_STRING))
                    {
                        EditorGUILayout.LabelField("包含权限的文件:");
                        if (GUILayout.Button(manifestPath))
                        {
                            AssetDatabase.OpenAsset(AssetDatabase.LoadAssetAtPath<Object>(manifestPath));
                        }
                    }
                }

                EditorGUILayout.HelpBox("根据Google Play政策，使用此权限需要完整填写'广泛的软件包可见性'声明，否则应移除该权限。", MessageType.Info);
            }
            else
            {
                EditorGUILayout.HelpBox("未在Manifest文件中检测到 QUERY_ALL_PACKAGES 权限", MessageType.Info);
            }
        }

        GUILayout.Space(20);

        // 显示代码检查结果
        GUILayout.Label("代码中引用检查结果:", EditorStyles.label);

        if (codeFilesWithPermission.Count > 0)
        {
            EditorGUILayout.HelpBox($"在 {codeFilesWithPermission.Count} 个文件中检测到可能引用了该权限", MessageType.Info);

            foreach (string filePath in codeFilesWithPermission)
            {
                if (GUILayout.Button(filePath))
                {
                    AssetDatabase.OpenAsset(AssetDatabase.LoadAssetAtPath<Object>(filePath));
                }
            }
        }
        else
        {
            EditorGUILayout.HelpBox("未在代码中检测到 QUERY_ALL_PACKAGES 权限的引用", MessageType.Info);
        }

        GUILayout.Space(20);

        // 显示处理建议
        GUILayout.Label("处理建议:", EditorStyles.label);

        if (hasQueryAllPackages)
        {
            EditorGUILayout.HelpBox(
                "1. 确认您的应用确实需要使用QUERY_ALL_PACKAGES权限\n" +
                "2. 如果不需要，请从所有Manifest文件中移除该权限声明\n" +
                "3. 如果确实需要，请确保在Google Play Console中完整填写'广泛的软件包可见性'声明\n" +
                "4. 检查是否有替代方案可以避免使用此权限",
                MessageType.Warning);
        }
        else
        {
            EditorGUILayout.HelpBox(
                "您的应用未使用QUERY_ALL_PACKAGES权限，符合Google Play的默认要求。\n" +
                "如果需要查询其他应用，请考虑使用更具体的包可见性声明。",
                MessageType.Info);
        }

        EditorGUILayout.EndScrollView();
    }
}
