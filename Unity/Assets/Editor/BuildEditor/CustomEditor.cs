using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 剪切板
/// </summary>
public class ClipBoard
{
    /// <summary>
    /// 将信息复制到剪切板当中
    /// </summary>
    public static void Copy(string format, params object[] args)
    {
        string result = string.Format(format, args);
        TextEditor editor = new TextEditor();
        editor.text = result; // new GUIContent(result);
        editor.OnFocus();
        editor.Copy();
    }
}

public class CustomEditorScript
{
    [MenuItem("Custom/生成坐标点")]
    static void ExportPositions()
    {
        string postionList = "";

        if (Selection.gameObjects.Length == 0)
            return;

        GameObject gameObject = Selection.gameObjects[0];
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            Vector3 vector3 = gameObject.transform.GetChild(i).transform.position;
            //int x = Mathf.RoundToInt(vector3.x * 100);
            //int y = Mathf.RoundToInt(vector3.y * 100);
            //int z = Mathf.RoundToInt(vector3.z * 100);

            postionList += $"{vector3.x.ToString("F2")},1.00f,{vector3.z.ToString("F2")}";
            postionList += "\r\n";
        }

        string dataPath = Application.dataPath;
        dataPath = dataPath.Substring(0, dataPath.Length - 6);
        dataPath = dataPath.Substring(0, dataPath.Length - 6);
        string filePath = dataPath + "/Release/MonsterPosition.txt";

        if (!File.Exists(filePath))
            File.Create(filePath);

        FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
        StreamWriter sw = new StreamWriter(fs);
        fs.SetLength(0); //首先把文件清空了。
        sw.Write(postionList); //写你的字符串。
        sw.Close();

        UnityEngine.Debug.Log("生成坐标点成功！生成:" + gameObject.transform.childCount + "个");
    }

    [MenuItem("Custom/生成怪物ID和坐标")]
    static void ExportMonsterIdAndPositions()
    {
        string postionList = "";

        if (Selection.gameObjects.Length == 0)
            return;

        GameObject gameObject = Selection.gameObjects[0];
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            string gamename = gameObject.transform.GetChild(i).gameObject.name;
            int index = -1;
            //空字符 或者 （
            index = gamename.IndexOf(" ");
            if (index == -1)
            {
                index = gamename.IndexOf("(");
            }

            if (index != -1)
            {
                gamename = gamename.Substring(0, index);
            }

            int monsterId = int.Parse(gamename);

            Vector3 vector3 = gameObject.transform.GetChild(i).position;

            postionList += $"1;{vector3.x.ToString("F2")},{vector3.y.ToString("F2")},{vector3.z.ToString("F2")};{monsterId};1";
            if (i != gameObject.transform.childCount - 1)
            {
                //postionList += "@";
                postionList += "\r\n";
            }
            //postionList += "\r\n";
        }

        ClipBoard.Copy(postionList);
        //string dataPath = Application.dataPath;
        //dataPath = dataPath.Substring(0, dataPath.Length - 6);
        //dataPath = dataPath.Substring(0, dataPath.Length - 6);
        //string filePath = dataPath + "/Release/MonsterIDAndPosition.txt";

        //if (!File.Exists(filePath))
        //	File.Create(filePath);

        //FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
        //StreamWriter sw = new StreamWriter(fs);
        //fs.SetLength(0);//首先把文件清空了。
        //sw.Write(postionList);//写你的字符串。
        //sw.Close();

        UnityEngine.Debug.Log("导出坐标点成功！生成:" + gameObject.transform.childCount + "个");
    }

    [MenuItem("Custom/获取坐标点")]
    static void GetPositions()
    {
        string postionList = "";

        if (Selection.gameObjects.Length != 1)
            return;

        GameObject gameObject = Selection.gameObjects[0];
        Vector3 vector3 = gameObject.transform.position;

        postionList = vector3.x.ToString("F2") + "," + vector3.y.ToString("F2") + "," + vector3.z.ToString("F2");
        ClipBoard.Copy(postionList);
        UnityEngine.Debug.Log("导出坐标点成功！");
    }

    [MenuItem("Custom/拷贝GameObjectPath")]
    private static void CopyGameObjectPath()
    {
        UnityEngine.Object obj = Selection.activeObject;
        if (obj == null)
        {
            Debug.LogError("You must select Obj first!");
            return;
        }

        string result = AssetDatabase.GetAssetPath(obj);
        if (string.IsNullOrEmpty(result)) //如果不是资源则在场景中查找
        {
            Transform selectChild = Selection.activeTransform;
            if (selectChild != null)
            {
                result = selectChild.name;
                while (selectChild.parent != null)
                {
                    selectChild = selectChild.parent;
                    result = string.Format("{0}/{1}", selectChild.name, result);
                }
            }
        }

        ClipBoard.Copy(result);
        Debug.Log(string.Format("The gameobject:{0}'s path has been copied to the clipboard!", obj.name));
    }

    [MenuItem("Custom/生成怪物配置")]
    static void ExportMonsters()
    {
        string postionList = "";
        if (Selection.gameObjects.Length == 0)
        {
            return;
        }

        for (int i = 0; i < Selection.gameObjects.Length; i++)
        {
            GameObject go = Selection.gameObjects[i];
            AI_1 ai_1 = go.GetComponent<AI_1>();

            FieldInfo[] allFieldInfo = (ai_1.GetType()).GetFields(BindingFlags.NonPublic | BindingFlags.NonPublic | BindingFlags.Instance |
                BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Static);

            int monsterId = -1;
            for (int f = 0; f < allFieldInfo.Length; f++)
            {
                if (allFieldInfo[f].Name == "AI_ID")
                {
                    monsterId = Convert.ToInt32(allFieldInfo[f].GetValue(ai_1));
                }
            }

            if (monsterId == -1)
            {
                continue;
            }

            Vector3 vector3 = go.transform.position;
            postionList += $"1;{vector3.x.ToString("F2")},{vector3.y.ToString("F2")},{vector3.z.ToString("F2")};{monsterId};1";
            postionList += "@";
        }

        postionList = postionList.TrimEnd('@');
        ClipBoard.Copy(postionList);
        UnityEngine.Debug.Log("导出坐标点成功！");
    }

    [MenuItem("Custom/获取所有格子的坐标点")]
    static void GetAllBoxPositions()
    {
        var objs = Resources.FindObjectsOfTypeAll(typeof (GameObject)) as GameObject[];
        string postionList = "";
        foreach (GameObject obj in objs)
        {
            if (obj.name.StartsWith("Box"))
            {
                Vector3 vector3 = obj.transform.position;
                postionList += "new Vector3(" + vector3.x.ToString("F2") + "f," + vector3.y.ToString("F2") + "f," + vector3.z.ToString("F2") +
                        "f),\n";
            }
        }

        ClipBoard.Copy(postionList.Remove(postionList.Length - 1));
        UnityEngine.Debug.Log("导出坐标点成功！");
    }

    [MenuItem("Custom/获取Shader路径")]
    static void FindAllShaders()
    {
        string shaderPaths = "";

        string projectPath = Application.dataPath.Replace("/Assets", "");

        string[] allFiles = Directory.GetFiles(projectPath, "*.*", SearchOption.AllDirectories);

        foreach (string file in allFiles)
        {
            if (file.EndsWith(".shader"))
            {
                shaderPaths += file + "\n";
            }
        }

        ClipBoard.Copy(shaderPaths);
    }

    // 修改选择的文件夹中Prefab引用的模型的fbx设置
    [MenuItem("Custom/Modify Prefab FBX Settings")]
    public static void ModifyPrefabFBXSettings()
    {
        string folderPath = EditorUtility.OpenFolderPanel("选中文件夹", "", "");
        if (string.IsNullOrEmpty(folderPath))
        {
            Debug.Log("选择文件夹操作无效");
            return;
        }

        string[] prefabPaths = Directory.GetFiles(folderPath, "*.prefab", SearchOption.AllDirectories);

        foreach (string prefabPath in prefabPaths)
        {
            string fullString = prefabPath;
            string prefix = "Assets";
            string subString = string.Empty;
            int startIndex = fullString.IndexOf(prefix);
            if (startIndex != -1)
            {
                subString = fullString.Substring(startIndex);
            }
            else
            {
                continue;
            }
            
            string[] dependencies = AssetDatabase.GetDependencies(new string[] { subString });
            foreach (string dependency in dependencies)
            {
                if (dependency.EndsWith(".fbx", System.StringComparison.OrdinalIgnoreCase))
                {
                    ModelImporter modelImporter = AssetImporter.GetAtPath(dependency) as ModelImporter;

                    if (modelImporter != null)
                    {
                        // 修改设置
                        modelImporter.bakeAxisConversion = false;
                        modelImporter.importBlendShapes = false;
                        modelImporter.importVisibility = false;
                        modelImporter.importCameras = false;
                        modelImporter.importLights = false;
                        modelImporter.preserveHierarchy = false;
                        // .....

                        
                        EditorUtility.SetDirty(modelImporter);
                        AssetDatabase.ImportAsset(dependency); // 保存设置
                    }
                }
            }
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}