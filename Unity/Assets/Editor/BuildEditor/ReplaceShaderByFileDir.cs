using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;


public class ReplaceShaderByFileDir : EditorWindow
{
    Shader shader;
    Shader originShader;
    bool isShowReplaceGo = false;  //是否显示被替换的物体
    string tipMsg = null;
    MessageType tipMsgType = MessageType.Info;
    List<GameObject> replaceGoList = new List<GameObject>();
    int matCount = 0;   //材质的数量
    Vector2 scrollPos = Vector2.zero;
    [MenuItem("Editor/替换场景中的shader")]
    public static void OpenWindow()
    {
        //创建窗口
        ReplaceShaderByFileDir window = GetWindow<ReplaceShaderByFileDir>(false, "替换场景中的shader");
        window.Show();
    }
    void OnGUI()
    {
        GUILayout.Label("原shader：");
        originShader = (Shader)EditorGUILayout.ObjectField(originShader, typeof(Shader), true);
        //ObjectField(string label, Object obj, Type objType, bool allowSceneObjects, GUILayoutOption[] paramsOptions)
        //label字段前面的可选标签   obj字段显示的物体   objType物体的类型    allowSceneObjects允许指定场景物体..
        //返回：Object，用户设置的物体
        GUILayout.Label("替换shader ：");
        shader = (Shader)EditorGUILayout.ObjectField(shader, typeof(Shader), true);
        GUILayout.Space(8);
        //开始一个水平组,所有被渲染的控件，在这个组里一个接着一个被水平放置。该组必须调用EndHorizontal关闭。
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("批量替换", GUILayout.Height(30)))
        {
            Replace();
        }
        if (GUILayout.Button("重置", GUILayout.Height(30)))
        {
            Reset();
        }
        //关闭水平组
        GUILayout.EndHorizontal();
        //提示信息
        if (!string.IsNullOrEmpty(tipMsg))
        {
            //创建一个帮助框，第一个参数是显示的文本，第二个参数是帮助框的提示图标类型
            EditorGUILayout.HelpBox(tipMsg, tipMsgType);
        }
        //创建勾选框
        isShowReplaceGo = GUILayout.Toggle(isShowReplaceGo, "显示被替换的GameObject");
        if (isShowReplaceGo)
        {
            if (replaceGoList.Count > 0)
            {
                //开始滚动视图,scrollPos用于显示的滚动位置
                scrollPos = GUILayout.BeginScrollView(scrollPos, GUILayout.Width(Screen.width), GUILayout.Height(Screen.height - 200));
                foreach (var go in replaceGoList)
                {
                    EditorGUILayout.ObjectField(go, typeof(GameObject), true);
                }
                //结束滚动视图
                GUILayout.EndScrollView();
            }
            else
            {
                EditorGUILayout.LabelField("替换个数为0");
            }
        }
    }
    /// <summary>
    /// 替换Shader
    /// </summary>
    void Replace()
    {
        replaceGoList.Clear();
        if (shader == null)
        {
            tipMsg = "shader为空！";
            tipMsgType = MessageType.Error;
            return;
        }
        if (originShader == null)
        {
            tipMsg = "指定的shader为空！";
            tipMsgType = MessageType.Error;
            return;
        }
        else if (originShader.Equals(shader))
        {
            tipMsg = "替换的shader和指定的shader相同！";
            tipMsgType = MessageType.Error;
            return;
        }
        Dictionary<GameObject, Material[]> matDict = GetAllScenceMaterial();
        List<Material> replaceMatList = new List<Material>();
        foreach (var item in matDict)
        {
            GameObject tempGo = item.Key;
            Material[] mats = item.Value;
            int length = mats.Length;
            for (int i = 0; i < length; i++)
            {
                var mat = mats[i];
                if (mat != null && mat.shader.Equals(originShader))
                {
                    if (!mat.shader.Equals(shader))
                    {
                        replaceGoList.Add(tempGo);
                        if (!replaceMatList.Contains(mat))
                            replaceMatList.Add(mat);
                    }
                }
            }
        }
        //替换Material的数量
        int replaceMatCount = replaceMatList.Count;
        for (int i = 0; i < replaceMatCount; i++)
        {
            UpdateProgress(i, replaceMatCount, "替换中...");
            //替换Shader
            replaceMatList[i].shader = shader;
            //启用GPU Instancing
            replaceMatList[i].enableInstancing = true;
            //设置脏标志，标记目标物体已改变，当资源已改变并需要保存到磁盘，Unity内部使用dirty标识来查找
            EditorUtility.SetDirty(replaceMatList[i]);
        }
        // 刷新编辑器，使刚创建的资源立刻被导入，才能接下来立刻使用上该资源
        AssetDatabase.Refresh();
        // 一般所有资源修改完后调用，调用后Unity会重新导入修改过后的资源
        AssetDatabase.SaveAssets();
        tipMsg = "替换成功！替换了" + replaceMatCount + "个Material," + replaceGoList.Count + "个GameObject";
        tipMsgType = MessageType.Info;
        //关闭进度条
        EditorUtility.ClearProgressBar();
    }
    /// <summary>
    /// 替换shader的可视化进程
    /// </summary>
    void UpdateProgress(int progress, int progressMax, string info)
    {
        string title = "Processing...[" + progress + " / " + progressMax + "]";
        float value = (float)progress / progressMax;
        //显示进度条
        EditorUtility.DisplayProgressBar(title, info, value);
    }
    /// <summary>
    /// 重置
    /// </summary>
    void Reset()
    {
        tipMsg = null;
        shader = null;
        originShader = null;
        matCount = 0;
        replaceGoList.Clear();
        isShowReplaceGo = false;
    }
    /// <summary>
    /// 获取所有场景中的Material
    /// </summary>
    /// <returns></returns>
    Dictionary<GameObject, Material[]> GetAllScenceMaterial()
    {
        Dictionary<GameObject, Material[]> dict = new Dictionary<GameObject, Material[]>();
        List<GameObject> gos = GetAllSceneGameObject();
        foreach (var go in gos)
        {
            Renderer render = go.GetComponent<Renderer>();
            if (render != null)
            {
                Material[] mats = render.sharedMaterials;
                if (mats != null && mats.Length > 0 && !dict.ContainsKey(go))
                {
                    dict.Add(go, mats);
                    matCount += mats.Length;
                }
            }
        }
        return dict;
    }
    /// <summary>
    /// 获取所有场景中的物体
    /// </summary>
    /// <returns></returns>
    List<GameObject> GetAllSceneGameObject()
    {
        List<GameObject> list = new List<GameObject>();
        //获取当前活动的场景
        Scene scene = SceneManager.GetActiveScene();
        //获取场景中所有根游戏对象
        GameObject[] rootGos = scene.GetRootGameObjects();
        foreach (var go in rootGos)
        {
            Transform[] childs = go.transform.GetComponentsInChildren<Transform>(true);
            foreach (var child in childs)
            {
                list.Add(child.gameObject);
            }
        }
        return list;
    }
}