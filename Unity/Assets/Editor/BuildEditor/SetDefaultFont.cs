using UnityEngine;
using UnityEditor;
using System;
using UnityEngine.UI;
using UnityEngine.Windows;

public class SetDefaultFont : EditorWindow
{
    private static Font m_font;
    private static EditorWindow window;

    public static Font Font
    {
        get
        {
            return m_font;
        }
    }

    [MenuItem("Tools/设置默认字体")]
    public static void OpenWindow()
    {
        window = GetWindow(typeof(SetDefaultFont));
        window.minSize = new Vector2(500, 300);
        m_font = ToolCacheManager.GetFont();
    }

    private void OnGUI()
    {
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("选择默认字体");
        EditorGUILayout.Space();
        m_font = (Font)EditorGUILayout.ObjectField(m_font, typeof(Font), true);
        EditorGUILayout.Space();
        if (GUILayout.Button("确定"))
        {
            ToolCacheManager.SaveFont(m_font);
            window.Close();
        }
    }
}
public class ToolCacheManager
{
    private static readonly string cachePath =
        Application.dataPath.Substring(0, Application.dataPath.Length - 6) + "Library/BlueToolkitCache/";

    private static void Init()
    {
        if (!Directory.Exists(cachePath))
        {
            Directory.CreateDirectory(cachePath);
        }
    }

    public static void SaveFont(Font font)
    {
        FontData data = ScriptableObject.CreateInstance<FontData>();
        data.defaultFont = font;
        AssetDatabase.CreateAsset(data, "Assets/front/FontData.asset");
    }

    public static Font GetFont()
    {
        FontData data = AssetDatabase.LoadAssetAtPath<FontData>("Assets/front/FontData.asset");
        return data.defaultFont;
    }
}
[System.Serializable]
public class FontData : ScriptableObject
{
    [SerializeField]
    public Font defaultFont;
}

public class UnityUIEvent
{
    [InitializeOnLoadMethod]
    private static void Init()
    {
        Action OnEvent = delegate
        {
            //ChangeDefaultFont();
        };

        EditorApplication.hierarchyChanged += delegate ()
        {
            OnEvent();
        };
    }

    private static void ChangeDefaultFont()
    {
        if (Selection.activeGameObject != null)
        {
            Text text = Selection.activeGameObject.GetComponent<Text>();

            if (text != null)
            {
                text.font = ToolCacheManager.GetFont();
            }

            Text[] text_arr = Selection.activeGameObject.transform.GetComponentsInChildren<Text>();
            if (text_arr != null)
            {
                for (int i = 0; i < text_arr.Length; i++)
                {
                    text_arr[i].font = ToolCacheManager.GetFont();
                }
            }
        }

    }
}
