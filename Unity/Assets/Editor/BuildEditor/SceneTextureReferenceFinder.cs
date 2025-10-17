using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace ET
{
    public class SceneTextureReferenceFinder : MonoBehaviour
    {
        private static readonly string scenesPath = "Assets/Scenes";
        private static readonly string outputPath = "Assets/场景中引用的贴图.txt";


        [MenuItem("Tools/检测场景顶点数")]
        static void CalculateVertices()
        {
            int totalVertices = 0;
            var renderers = FindObjectsOfType<Renderer>(true); // 包含隐藏对象

            List<(int KeyId, string Value, string Value2)> bigname = new List<(int KeyId, string Value, string Value2)>();

            int vertextdebug = 100;

            foreach (var renderer in renderers)
            {
                if (renderer is MeshRenderer meshRenderer)
                {
                    var meshFilter = meshRenderer.GetComponent<MeshFilter>();
                    if (meshFilter != null && meshFilter.sharedMesh != null)
                    {
                        if (meshFilter.sharedMesh.vertexCount > vertextdebug)
                        {
                            //Log.Debug($"统计场景顶点数:  vertexCount: {meshFilter.sharedMesh.vertexCount}   {renderer.gameObject.name}");


                            var keyValuePair = bigname.FirstOrDefault(p => p.Value.Equals(renderer.gameObject.name));
                            if ( keyValuePair.Value2 == String.Empty)
                            {
                                bigname.Add(( 1,  meshFilter.sharedMesh.vertexCount.ToString(),  renderer.gameObject.name ));
                            }
                            else
                            {
                                keyValuePair.KeyId++;
                            }
                        }

                        totalVertices += meshFilter.sharedMesh.vertexCount;
                    }
                }
                else if (renderer is SkinnedMeshRenderer skinnedMeshRenderer)
                {
                    if (skinnedMeshRenderer.sharedMesh != null)
                    {
                        if (skinnedMeshRenderer.sharedMesh.vertexCount > vertextdebug)
                        {
                            //Log.Debug($"统计场景顶点数:  vertexCount: {skinnedMeshRenderer.sharedMesh.vertexCount}  {renderer.gameObject.name}");
                            var keyValuePair = bigname.FirstOrDefault(p => p.Value2.Equals(renderer.gameObject.name));
                            if ( keyValuePair.Value2 == String.Empty)
                            {
                                bigname.Add((  1,  skinnedMeshRenderer.sharedMesh.vertexCount.ToString(), renderer.gameObject.name ));
                            }
                            else
                            {
                                keyValuePair.KeyId++;
                            }
                        }

                        totalVertices += skinnedMeshRenderer.sharedMesh.vertexCount;
                    }
                }
            }

            var biglist = bigname.OrderByDescending(p => p.KeyId);
            foreach (var VARIABLE in biglist)
            {
                if ((int.Parse(VARIABLE.Value) > 100 && VARIABLE.KeyId >= 200)
                    || (int.Parse(VARIABLE.Value) > 1000 && VARIABLE.KeyId >= 30)
                    || (int.Parse(VARIABLE.Value) > 2000 && VARIABLE.KeyId >= 15)
                    || (int.Parse(VARIABLE.Value) > 5000 && VARIABLE.KeyId >= 5)
                    || (int.Parse(VARIABLE.Value) > 10000 && VARIABLE.KeyId >= 2))
                {
                    Log.Error($"统计场景顶点数>5000:  {VARIABLE.Value2}  数量:{VARIABLE.KeyId}  顶点：{VARIABLE.Value}   总顶点数：{VARIABLE.KeyId * int.Parse(VARIABLE.Value)}");
                }
            }

            EditorUtility.DisplayDialog("顶点统计",
                $"场景顶点总数: {totalVertices}", "确定");
        }


        [MenuItem("Tools/检测场景中引用的贴图")]
        public static void FindTextureReferences()
        {
            Debug.Log("查找开始！");

            List<string> result = new List<string>();

            // 查找场景文件
            string[] sceneGuids = AssetDatabase.FindAssets("t:Scene", new[] { scenesPath });
            foreach (string sceneGuid in sceneGuids)
            {
                string scenePath = AssetDatabase.GUIDToAssetPath(sceneGuid);
                string sceneName = Path.GetFileNameWithoutExtension(scenePath);

                // 打开场景
                EditorSceneManager.OpenScene(scenePath);

                // 查找场景中的所有贴图引用及大小
                List<(Texture texture, long size)> texturesInScene = new List<(Texture, long)>();
                var renderers = GameObject.FindObjectsOfType<Renderer>();

                foreach (var renderer in renderers)
                {
                    var materials = renderer.sharedMaterials;
                    foreach (var material in materials)
                    {
                        if (material == null) continue;
                        foreach (var textureName in material.GetTexturePropertyNames())
                        {
                            Texture texture = material.GetTexture(textureName);
                            if (texture != null && texturesInScene.All(t => t.texture != texture))
                            {
                                long textureSize = GetTextureFileSize(texture);
                                if (textureSize > 0)
                                {
                                    texturesInScene.Add((texture, textureSize));
                                }
                            }
                        }
                    }
                }

                // 按大小从大到小排序
                texturesInScene = texturesInScene.OrderByDescending(t => t.size).ToList();

                // 收集输出信息
                result.Add($"{sceneName}:");
                foreach (var (texture, size) in texturesInScene)
                {
                    result.Add($"  {AssetDatabase.GetAssetPath(texture)} - 大小：{FormatBytes(size)} - 尺寸：{texture.width}x{texture.height}");
                }

                result.Add(""); // 空行分隔场景
            }

            // 写入到文件
            File.WriteAllLines(outputPath, result);
            AssetDatabase.Refresh();

            Debug.Log($"查找结束！ 文件保存在 {outputPath}");
        }

        // 获取Texture的存储内存大小
        private static long GetTextureFileSize(Texture texture)
        {
            long fileSize = 0;

            Type textureUtilType = typeof(TextureImporter).Assembly.GetType("UnityEditor.TextureUtil");
            MethodInfo getStorageMemorySizeLongMethod =
                    textureUtilType.GetMethod("GetStorageMemorySizeLong", BindingFlags.Static | BindingFlags.Public);
            fileSize = (long)getStorageMemorySizeLongMethod.Invoke(null, new object[] { texture });

            return fileSize;
        }

        // 获取Texture的运行时内存大小
        private static long GetTextureRuntimeMemorySize(Texture texture)
        {
            long memorySize = 0;

            Type textureUtilType = typeof(TextureImporter).Assembly.GetType("UnityEditor.TextureUtil");
            MethodInfo getRuntimeMemorySizeLongMethod =
                    textureUtilType.GetMethod("GetRuntimeMemorySizeLong", BindingFlags.Static | BindingFlags.Public);
            memorySize = (long)getRuntimeMemorySizeLongMethod.Invoke(null, new object[] { texture });

            return memorySize;
        }

        private static string FormatBytes(long bytes)
        {
            if (bytes >= 1073741824)
                return $"{bytes / 1073741824f:0.00} GB";
            if (bytes >= 1048576)
                return $"{bytes / 1048576f:0.00} MB";
            if (bytes >= 1024)
            {
                float sizeInMB = bytes / 1048576f;
                float sizeInKB = bytes / 1024f;
                return $"{sizeInKB:0.00} KB / {sizeInMB:0.00} MB ";
            }

            return $"{bytes} B";
        }
    }
}