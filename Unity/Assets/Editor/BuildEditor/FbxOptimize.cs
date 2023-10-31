using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;

public class FbxOptimize
{

    //DefaultMaterial :指定Material
    private static Material defaultMaterial;

    private static Material DefaultMaterial
    {
        get
        {
            if (defaultMaterial == null)
            {
                var path = string.Format("Assets/{0}.mat", "DefaultMaterial");
                Material load = AssetDatabase.LoadAssetAtPath<Material>(path);
                if (load == null)
                {
                    return null;
                }
                defaultMaterial = load;
                Resources.UnloadAsset(load);
            }

            return defaultMaterial;
        }
    }

    //指令：可在fbx文件右齿轮操作
    [MenuItem("Tools/ModelImporter/SetDefaultMaterial(LYM)")]
    private static void SetDefaultMaterial(MenuCommand menuCommand)
    {
        var importer = menuCommand.context as ModelImporter;
        if (importer == null)
        {
            return;
        }
        //所有renderer
        var sources = new List<Renderer>();
        var assets = AssetDatabase.LoadAllAssetsAtPath(importer.assetPath);
        for (var i = 0; i < assets.Length; i++)
        {
            var source = assets[i] as Renderer;
            if (source != null)
            {
                sources.Add(source);
            }
        }

        //所有material
        var keys = new Dictionary<string, bool>();
        foreach (var render in sources)
        {
            foreach (var mat in render.sharedMaterials)
            {
                if (mat != null && !keys.ContainsKey(mat.name) && mat.shader.name.Contains("Standard"))
                    keys.Add(mat.name, true);
            }
        }

        //替换为默认material
        importer.materialImportMode = ModelImporterMaterialImportMode.ImportStandard;
        if (keys.Count > 0 || importer.materialLocation != ModelImporterMaterialLocation.InPrefab)
        {
            var newMaterial = DefaultMaterial;
            var kind = typeof(UnityEngine.Material);
            foreach (var it in keys)
            {
                var id = new AssetImporter.SourceAssetIdentifier();
                id.name = it.Key;
                id.type = kind;
                importer.RemoveRemap(id);
                importer.AddRemap(id, newMaterial);
            }
            importer.materialLocation = ModelImporterMaterialLocation.InPrefab;
            importer.SaveAndReimport();
        }
    }
}