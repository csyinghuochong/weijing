using UnityEditor;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class CheckReferences : EditorWindow
    {
        private const string KBuildAssetBundles = "XAsset/Bundles/Check Atlas References";
        private static string sCheckPath = "Assets/Bundles/UI";

        [MenuItem(KBuildAssetBundles)]
        public static void CheckAtlasReferences()
        {
            UnityEngine.Debug.LogError("CheckAtlasReferences: Begin");

            List<string> fileList = new List<string>();
            fileList =  GetFile(sCheckPath, fileList);

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
