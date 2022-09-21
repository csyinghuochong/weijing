using UnityEditor;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using libx;

namespace ET
{
    public class CheckReferences : EditorWindow
    {
        private const string KBuildAssetBundles = "XAsset/Bundles/Check Atlas References";
        private static string sUICheckPath = "Assets/Bundles/UI";
        private static string sSceneCheckPath = "Assets/Scenes";


        // [MenuItem("Asset / ), false, 1]
        [MenuItem("Assets/Custom/Check  Dependencies", false, 1)]//路径
        public static void CheckDependencies()
        {
            string fontPath = AssetDatabase.GetAssetPath(Selection.activeInstanceID);
            UnityEngine.Debug.Log("KCheckDependencies: Begin");

            string[] dependPathList = AssetDatabase.GetDependencies(new string[] { fontPath });
            foreach (string path in dependPathList)
            {
                using (var stream = File.OpenRead(path))
                {
                    long fileSize = stream.Length;
                    string strNum = BuildScript.GetSizeNum(fileSize);
                    UnityEngine.Debug.Log(strNum + "   " + path);
                }
            }

            UnityEngine.Debug.Log("KCheckDependencies: End");
        }

        // [MenuItem("Asset / ), false, 1]
        [MenuItem("Assets/Custom/Check References UI", false, 1)]//路径
        public static void KCheckUIReferences()
        {
            string fontPath = AssetDatabase.GetAssetPath(Selection.activeInstanceID);

            string[] assetPath = fontPath.Split('/');
            string fontAssetName = assetPath[assetPath.Length - 1];
            if (fontAssetName.Contains("."))
            {
                fontAssetName = fontAssetName.Split('.')[0];
            }

            UnityEngine.Debug.Log("KCheckFontReferences: Begin");

            List<string> fileList = new List<string>();
            fileList.AddRange( GetFile(sUICheckPath, fileList) );

            string dataPath = Application.dataPath;
            int pathLength = dataPath.Length - 6;
            for (int i = 0; i < fileList.Count; i++)
            {
                string itemPath = fileList[i];
                if (itemPath.Contains(".meta"))
                {
                    continue;
                }

                itemPath = itemPath.Remove(0, pathLength);
                string[] dependPathList = AssetDatabase.GetDependencies(new string[] { itemPath });
                foreach (string path in dependPathList)
                {
                    // string[] assetPath = path.Split('/');
                    //if (assetPath[assetPath.Length-1] == fongPath)
                    if (path == fontPath)
                    {
                        UnityEngine.Debug.Log($"以下文件有引用： {itemPath} ");

                        GameObject tmpObj = AssetDatabase.LoadAssetAtPath(itemPath, typeof(GameObject)) as GameObject;
                        //tmpObj = GameObject.Instantiate(tmpObj) as GameObject;
                        Text[] tmpAr = tmpObj.GetComponentsInChildren<Text>();
                        for (int t = 0; t < tmpAr.Length; t++)
                        {
                            Text textTemp = tmpAr[t];
                            Font fontTemp = textTemp.font;
                            if (fontTemp == null)
                            {
                                continue;
                            }
                            string assetName = fontTemp.name;
                            if (fontAssetName == assetName)
                            {
                                UnityEngine.Debug.Log($" {textTemp.name}");
                            }
                        }

                        TextMeshPro[] tmpProAr = tmpObj.GetComponentsInChildren<TextMeshPro>();
                        for (int t = 0; t < tmpProAr.Length; t++)
                        {
                            TextMeshPro textTemp = tmpProAr[t];
                            TMP_FontAsset fontTemp = textTemp.font;
                            if (fontTemp == null)
                            {
                                continue;
                            }
                            string assetName = fontTemp.name;
                            if (fontAssetName == assetName)
                            {
                                UnityEngine.Debug.Log($" {textTemp.name}");
                            }
                        }
                    }
                }
            }

            UnityEngine.Debug.Log("KCheckFontReferences: End");
        }

        // [MenuItem("Asset / ), false, 1]
        [MenuItem("Assets/Custom/Check References Scene", false, 1)]//路径
        public static void KCheckSceneReferences()
        {
            string fontPath = AssetDatabase.GetAssetPath(Selection.activeInstanceID);

            string[] assetPath = fontPath.Split('/');
            string fontAssetName = assetPath[assetPath.Length - 1];
            if (fontAssetName.Contains("."))
            {
                fontAssetName = fontAssetName.Split('.')[0];
            }

            UnityEngine.Debug.Log("KCheckFontReferences: Begin");

            List<string> fileList = new List<string>();
            fileList.AddRange(GetFile(sSceneCheckPath, fileList));

            string dataPath = Application.dataPath;
            int pathLength = dataPath.Length - 6;
            for (int i = 0; i < fileList.Count; i++)
            {
                string itemPath = fileList[i];
                if (itemPath.Contains(".meta"))
                {
                    continue;
                }

                itemPath = itemPath.Remove(0, pathLength);
                string[] dependPathList = AssetDatabase.GetDependencies(new string[] { itemPath });
                foreach (string path in dependPathList)
                {
                    if (path == fontPath)
                    {
                        UnityEngine.Debug.Log($"以下文件有引用： {itemPath} ");
                    }
                }
            }

            UnityEngine.Debug.Log("KCheckFontReferences: End");
        }

        [MenuItem(KBuildAssetBundles)]
        public static void CheckAtlasReferences()
        {
            UnityEngine.Debug.LogError("CheckAtlasReferences: Begin");

            List<string> fileList = new List<string>();
            fileList =  GetFile(sUICheckPath, fileList);

            string dataPath = Application.dataPath;
            int pathLength = dataPath.Length - 6;
            for (int i = 0; i < fileList.Count; i++)
            {
                string itemPath = fileList[i];
                if (itemPath.Contains(".meta"))
                {
                    continue;
                }

                itemPath = itemPath.Remove( 0, pathLength);
                string[] dependPathList = AssetDatabase.GetDependencies(new string[] { itemPath });
                foreach (string path in dependPathList)
                {
                    if (path.Contains("UI/Icon"))
                    {
                        UnityEngine.Debug.LogError(string.Format("以下文件有引用{0}：{1}:  ", itemPath, path));
                        continue;
                    }
                }
            }
            UnityEngine.Debug.LogError("CheckAtlasReferences: End");
        }

        /// <summary>
        /// 获取路径下所有文件以及子文件夹中文件
        /// </summary>
        /// <param name="path">全路径根目录</param>
        /// <param name="FileList">存放所有文件的全路径</param>
        /// <returns></returns>
        public static List<string> GetFile(string path, List<string> FileList)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fil = dir.GetFiles();
            DirectoryInfo[] dii = dir.GetDirectories();
            foreach (FileInfo f in fil)
            {
                //int size = Convert.ToInt32(f.Length);
                long size = f.Length;
                FileList.Add(f.FullName);//添加文件路径到列表中
            }
            //获取子文件夹内的文件列表，递归遍历
            foreach (DirectoryInfo d in dii)
            {
                GetFile(d.FullName, FileList);
            }
            return FileList;
        }

    }

}
