using System.IO;
using UnityEditor;
using UnityEngine;

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

            postionList += $"{vector3.x.ToString("F2")},{vector3.y.ToString("F2")},{vector3.z.ToString("F2")}";
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
        fs.SetLength(0);//首先把文件清空了。
        sw.Write(postionList);//写你的字符串。
        sw.Close();

        UnityEngine.Debug.Log("导出坐标点成功！");
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

        UnityEngine.Debug.Log("导出坐标点成功！");
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
        if (string.IsNullOrEmpty(result))//如果不是资源则在场景中查找
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

}