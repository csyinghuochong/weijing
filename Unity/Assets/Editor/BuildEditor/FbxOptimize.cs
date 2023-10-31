using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ModifyMoidel : Editor
{
    [MenuItem("Tools/FBX_修改模型")]
    public static void ModifyMoidelScale()
    {
        //List<string> paths = new List<string>();
        //foreach (Object o in Selection.GetFiltered(typeof(Object), SelectionMode.Assets))
        //{
        //    Debug.Log(o.name);

        //    if (!(o is GameObject))
        //        continue; GameObject mod = o as GameObject;
        //    string path = AssetDatabase.GetAssetPath(mod);
        //    ModelImporter modelimporter = ModelImporter.GetAtPath(path) as ModelImporter;
        //    if (!modelimporter)
        //    {
        //        UnityEngine.Debug.LogError(string.Format("path-->{0}<---不是ModelImporter", path)); continue;
        //    }

        //    //修改Model 下的Scale Factor
        //    //modelimporter.globalScale = 10;
        //    modelimporter.materialImportMode = ModelImporterMaterialImportMode.None;

        //    paths.Add(path);
        //    AssetDatabase.ImportAsset(path);
        //}
        //AssetDatabase.Refresh();

        ;
        CreatNewAnimations(Selection.activeGameObject);
    }

    private static void CreatNewAnimations(GameObject gameObject)
    {
        if (gameObject == null)
        {
            return;
        }

        AssetDatabase.Refresh();
    }


    private static string GetAniName(int count)
    {
        switch (count)
        {
            case 1:
                return "Idle";
            case 2: return "2-1";
            case 3: return "2-2";
            case 4: return "2-3";
            case 5: return "2-4";
            default: return "";
        }
    }
}