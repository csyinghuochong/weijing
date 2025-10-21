using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class FindUIImageUsage : EditorWindow
{
    private Sprite targetSprite;
    private Vector2 scrollPos;
    private List<(GameObject root, Image image)> foundSceneImages = new List<(GameObject root, Image image)>();
    private List<(GameObject prefab, string path, string hierarchy)> foundPrefabImages = new List<(GameObject prefab, string path, string hierarchy)>();

    [MenuItem("Tools/查找图片被那些UI使用")]
    public static void ShowWindow()
    {
        GetWindow<FindUIImageUsage>("查找图片被那些UI使用");
    }

    private void OnGUI()
    {
        GUILayout.Label("选择一张图片 (Sprite)：", EditorStyles.boldLabel);
        targetSprite = (Sprite)EditorGUILayout.ObjectField("Sprite", targetSprite, typeof(Sprite), false);

        if (GUILayout.Button("搜索使用该图片的 UI"))
        {
            FindInScene();
            FindInPrefabs();
        }

        if (targetSprite != null)
        {
            GUILayout.Space(10);
            scrollPos = GUILayout.BeginScrollView(scrollPos);

            // 场景对象
            if (foundSceneImages.Count > 0)
            {
                GUILayout.Label($"【场景中】找到 {foundSceneImages.Count} 个使用该图片的对象：", EditorStyles.boldLabel);
                foreach (var (root, img) in foundSceneImages)
                {
                    if (img == null) continue;

                    EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.ObjectField(img.gameObject.name, img.gameObject, typeof(GameObject), true);
                    if (GUILayout.Button("选中", GUILayout.Width(60)))
                    {
                        Selection.activeGameObject = img.gameObject;
                        EditorGUIUtility.PingObject(img.gameObject);
                    }
                    EditorGUILayout.EndHorizontal();
                }
            }

            GUILayout.Space(10);

            // 预制体对象
            if (foundPrefabImages.Count > 0)
            {
                GUILayout.Label($"【预制体中】找到 {foundPrefabImages.Count} 个使用该图片的对象：", EditorStyles.boldLabel);
                foreach (var (prefab, path, hierarchy) in foundPrefabImages)
                {
                    EditorGUILayout.BeginHorizontal();
                    GUILayout.Label(hierarchy, GUILayout.Width(300));
                    if (GUILayout.Button("定位子物体", GUILayout.Width(100)))
                    {
                        OpenPrefabAndSelectChild(path, hierarchy);
                    }
                    EditorGUILayout.EndHorizontal();
                }
            }

            if (foundSceneImages.Count == 0 && foundPrefabImages.Count == 0)
            {
                GUILayout.Label("未找到使用该图片的 UI。", EditorStyles.helpBox);
            }

            GUILayout.EndScrollView();
        }
    }

    private void FindInScene()
    {
        foundSceneImages.Clear();

        if (targetSprite == null) return;

        var images = GameObject.FindObjectsOfType<Image>(true);
        foreach (var img in images)
        {
            if (img.sprite == targetSprite)
            {
                foundSceneImages.Add((img.gameObject, img));
            }
        }
    }

    private void FindInPrefabs()
    {
        foundPrefabImages.Clear();

        string[] guids = AssetDatabase.FindAssets("t:Prefab", new[] { "Assets/Bundles/UI" });

        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if (prefab == null) continue;

            var images = prefab.GetComponentsInChildren<Image>(true);
            foreach (var img in images)
            {
                if (img.sprite == targetSprite)
                {
                    string hierarchy = GetHierarchyPath(img.transform);
                    foundPrefabImages.Add((prefab, path, hierarchy));
                }
            }
        }
    }

    // 不包含根节点名，只从子物体开始拼接路径
    private string GetHierarchyPath(Transform transform)
    {
        List<string> names = new List<string>();
        Transform current = transform;
        while (current.parent != null)
        {
            names.Insert(0, current.name);
            current = current.parent;
        }
        return string.Join("/", names);
    }

    // 递归逐级查找子物体
    private Transform FindInChildrenByPath(Transform root, string path)
    {
        string[] parts = path.Split('/');
        Transform current = root;
        foreach (var part in parts)
        {
            if (current == null) return null;
            current = current.Find(part);
        }
        return current;
    }

    // 反射调用 PrefabStageUtility.OpenPrefab 打开 prefab 编辑模式并定位
    private void OpenPrefabAndSelectChild(string prefabPath, string hierarchy)
    {

#if UNITY_2022_1_OR_NEWER
        var type = typeof(PrefabStageUtility);

        MethodInfo targetMethod = null;
        var methods = type.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
        foreach (var method in methods)
        {
            if (method.Name == "OpenPrefab")
            {
                var parameters = method.GetParameters();
                if (parameters.Length == 1 && parameters[0].ParameterType == typeof(string))
                {
                    targetMethod = method;
                    break;
                }
            }
        }

        if (targetMethod != null)
        {
            var stage = targetMethod.Invoke(null, new object[] { prefabPath }) as PrefabStage;
            if (stage != null)
            {
                Transform prefabRoot = stage.prefabContentsRoot.transform;
                Transform targetTransform = FindInChildrenByPath(prefabRoot, hierarchy);
                if (targetTransform != null)
                {
                    Selection.activeGameObject = targetTransform.gameObject;
                    EditorGUIUtility.PingObject(targetTransform.gameObject);
                }
                else
                {
                    Debug.LogWarning($"未能定位到子物体: {hierarchy}，选中预制体根节点。");
                    Selection.activeGameObject = prefabRoot.gameObject;
                    EditorGUIUtility.PingObject(prefabRoot.gameObject);
                }
                return;
            }
        }

        // 打不开 prefab 编辑模式，选中预制体资源
        Debug.LogWarning($"打开 prefab 编辑模式失败: {prefabPath}，选中预制体资源。");
        GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        Selection.activeObject = prefab;
        EditorGUIUtility.PingObject(prefab);

#endif
    }
}
