//
// AssetsMenuItem.cs
//
// Author:
//       fjy <jiyuan.feng@live.com>
//
// Copyright (c) 2020 fjy
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;
using ET;
using System.Collections.Generic;
using System.Linq;

namespace libx
{
    public static class MenuItems
    {
        private const string KBuildAssetBundles = "XAsset/Bundles/Build Bundles %#&B";
        private const string KBuildAssetBundlesNoHash = "XAsset/Bundles/Build Bundles NOHash";
        private const string KBundleResourceList = "XAsset/Bundles/Bundle Resource List";
        private const string KCopyAssetBundles = "XAsset/Bundles/Copy Bundles to Streaming Assets (Suggest for iOS review)";
        private const string KViewCachePath = "XAsset/View/Caches";
        private const string KViewDataPath = "XAsset/View/Built Bundles";
        private const string KCleanData = "XAsset/Bundles/Clean Built Bundles";
        private const string KModifyFileExtension = "XAsset/Bundles/KModifyFileExtension";

        //[MenuItem("ET/build")]

        //static void Ax()
        //{
        //    BuildScript.BuildAssetBundles();
        //}

        [MenuItem(KBuildAssetBundles)]
        public static void BuildAssetBundles()
        {
            var watch = new Stopwatch();
            watch.Start();
            BuildScript.ApplyBuildRules();
            watch.Stop();
            UnityEngine.Debug.LogError("ApplyBuildRules in: " + watch.ElapsedMilliseconds + " ms.");

            watch = new Stopwatch();
            watch.Start();

            //BuildScript.BuildAssetBundles();
            BuildAssetBundles_1();

            watch.Stop();
            UnityEngine.Debug.LogError("BuildAssetBundles in: " + watch.ElapsedMilliseconds + " ms.");
        }

        //[MenuItem(KBuildAssetBundlesNoHash)]
        public static void BuildAssetListNoHash()
        {
            var watch = new Stopwatch();
            watch.Start();
            BuildScript.ApplyBuildRules(false);
            watch.Stop();
            UnityEngine.Debug.LogError("BundleResourceList in: " + watch.ElapsedMilliseconds + " ms.");

            watch = new Stopwatch();
            watch.Start();

            //BuildScript.BuildAssetBundles();
            BuildAssetBundles_1();

            watch.Stop();
            UnityEngine.Debug.LogError("BundleResourceList in: " + watch.ElapsedMilliseconds + " ms.");
        }

        public static void BuildAssetBundles_1()
        {
            //set aes key
            //    BuildPipeline.SetAssetBundleEncryptKey(ET.BundleHelper.AES_Pass);

            // Choose the output path according to the build target.
            var outputPath = BuildScript.CreateAssetBundleDirectory();
            const BuildAssetBundleOptions options = BuildAssetBundleOptions.ChunkBasedCompression;
            var targetPlatform = BuildScript.Current_BuildTarget;
            var rules = BuildScript.GetBuildRules();
            var builds = rules.GetBuilds();
            var assetBundleManifest = BuildPipeline.BuildAssetBundles(outputPath, builds, options, targetPlatform);
            if (assetBundleManifest == null)
            {
                return;
            }

            Dictionary<string, AssetBundleBuild> assetBundleBuilds = new Dictionary<string, AssetBundleBuild>();
            for (int i = 0; i < builds.Length; i++)
            {
                assetBundleBuilds.Add(builds[i].assetBundleName, builds[i]);
            }
            //assetBundleName 加密 assetNames 资源名字  addresname 和  var一般为空
            //assetBundleBuilds[0].assetBundleName + assetBundleBuilds[0].assetNames[0];

            var manifest = BuildScript.GetManifest();
            var dirs = new List<string>();
            var assets = new List<AssetRef>();
            var bundles = assetBundleManifest.GetAllAssetBundles();
            var bundle2Ids = new Dictionary<string, int>();

            for (var index = 0; index < bundles.Length; index++)
            {
                var bundle = bundles[index];
                bundle2Ids[bundle] = index;

                AssetBundleBuild assetBundleBuild = assetBundleBuilds[bundle];
            }

            var bundleRefs = new List<BundleRef>();
            for (var index = 0; index < bundles.Length; index++)
            {
                var bundle = bundles[index];
                var deps = assetBundleManifest.GetAllDependencies(bundle);
                var path = string.Format("{0}/{1}", outputPath, bundle);
                if (File.Exists(path))
                {
                    using (var stream = File.OpenRead(path))
                    {
                        bundleRefs.Add(new BundleRef
                        {
                            name = bundle,
                            id = index,
                            deps = Array.ConvertAll(deps, input => bundle2Ids[input]),
                            len = stream.Length,
                            hash = assetBundleManifest.GetAssetBundleHash(bundle).ToString(),
                        });
                    }
                }
                else
                {
                    UnityEngine.Debug.LogError(path + " file not exsit.");
                }
            }

            for (var i = 0; i < rules.ruleAssets.Length; i++)
            {
                var item = rules.ruleAssets[i];
                var path = item.path;
                var dir = Path.GetDirectoryName(path).Replace("\\", "/");
                var index = dirs.FindIndex(o => o.Equals(dir));
                if (index == -1)
                {
                    index = dirs.Count;
                    dirs.Add(dir);
                }

                if (!bundle2Ids.ContainsKey(item.bundle))
                {
                    UnityEngine.Debug.Log("!bundle2Ids.ContainsKey");
                    Log.Debug(item.bundle);
                    Log.Debug(path);
                }
                try
                {
                    var asset = new AssetRef { bundle = bundle2Ids[item.bundle], dir = index, name = Path.GetFileName(path) };
                    assets.Add(asset);
                }
                catch
                {
                    Log.Debug(path);
                }

            }

            manifest.dirs = dirs.ToArray();
            manifest.assets = assets.ToArray();
            manifest.bundles = bundleRefs.ToArray();

            EditorUtility.SetDirty(manifest);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            var manifestBundleName = "manifest.unity3d";
            builds = new[] {
                new AssetBundleBuild {
                    assetNames = new[] { AssetDatabase.GetAssetPath (manifest), },
                    assetBundleName = manifestBundleName
                }
            };

            BuildPipeline.BuildAssetBundles(outputPath, builds, options, targetPlatform);
            ArrayUtility.Add(ref bundles, manifestBundleName);

            Versions.BuildVersions(outputPath, bundles, BuildScript.GetBuildRules().AddVersion());

            List<ResourceInfo> resourceInfos_2 = new List<ResourceInfo>();
            foreach (var file in bundles)
            {
                using (var fs = File.OpenRead(outputPath + "/" + file))
                {
                    if (assetBundleBuilds.ContainsKey(file))
                    {
                        string assetname = assetBundleBuilds[file].assetNames[0];
                        resourceInfos_2.Add(new ResourceInfo() { Size = fs.Length, Path = assetname, Hash = file });
                    }
                }
            }
            resourceInfos_2.Sort(delegate (ResourceInfo a, ResourceInfo b)
            {
                return (int)b.Size - (int)a.Size;
            });
            BuildScript.SaveResourceList_1(resourceInfos_2, "/Release/HotRes_4.txt");
        }

        [MenuItem(KBundleResourceList)]
        public static void BuildAssetList()
        {
            var watch = new Stopwatch();
            watch.Start();
            BuildScript.ApplyBuildRules();
            watch.Stop();
            //ET.Log.Error("BundleResourceList in: " + watch.ElapsedMilliseconds + " ms.");

            watch = new Stopwatch();
            watch.Start();
            BuildScript.BundleResourceList();
            watch.Stop();
            //ET.Log.Error("BundleResourceList in: " + watch.ElapsedMilliseconds + " ms.");
        }

        [MenuItem(KCleanData)]
        private static void CleanBundles()
        {
            var watch = new Stopwatch();
            watch.Start();

            string path = "DLC";
            int version = EditorRuntimeInitializeOnLoad.GetVersion();
            switch ((VersionMode)version)
            {
                case VersionMode.Alpha:
                    path = "DLCAlpha";
                    break;
                case VersionMode.Beta:
                case VersionMode.BanHao:
                    path = "DLCBeta";
                    break;
            }
            ET.FileHelper.CleanDirectory(Directory.GetParent(Application.dataPath) + $"/../Release/{path}");
            //  DLLMgr.Delete(Directory.GetParent(Application.dataPath) + "/DLC");
            watch.Stop();
            ET.Log.Debug("Clean bundles in: " + watch.ElapsedMilliseconds + " ms.");
        }


        [MenuItem(KViewDataPath)]
        private static void ViewDataPath()
        {
            if (Directory.Exists(Directory.GetParent(Application.dataPath).FullName + "/../Release/DLC"))
            {
                EditorUtility.OpenWithDefaultApp(Directory.GetParent(Application.dataPath).FullName + "/../Release/DLC");
            }
            else
            {
                ET.Log.Error("Unable to View Bundles: Please Build Bundles First");
            }
        }

        [MenuItem(KViewCachePath)]
        private static void ViewCachePath()
        {
            EditorUtility.OpenWithDefaultApp(Application.persistentDataPath);
        }

        [MenuItem(KCopyAssetBundles)]
        private static void CopyAssetBundles()
        {
            BuildScript.CopyAssetBundlesTo(Application.streamingAssetsPath);
        }

        [MenuItem(KModifyFileExtension)]
        private static void ModifyFileModify()
        {
            List<string> fileList = new List<string> { };
            CheckReferences.GetFile(Application.dataPath + "/Bundles/Icon", fileList);
            for (var index = 0; index < fileList.Count; index++)
            {
                string path = fileList[index];

                if (path.Contains(".meta"))
                {
                    continue;
                }

                string kzm = Path.GetExtension(path);
                if (kzm != ".png")
                {
                    UnityEngine.Debug.Log(path);
                    FileInfo file = new FileInfo(path);
                    file.MoveTo(Path.ChangeExtension(file.FullName, ".png"));
                }
            }
        }

        [MenuItem("Tools/修改寻路数据为.bytes[客户端]")]
        static void RenamePathFilesInFolder1()
        {
            string folderPath = Application.dataPath + "/Bundles/Recast";
            if (string.IsNullOrEmpty(folderPath))
            {
                UnityEngine.Debug.Log("Folder selection canceled.");
                return;
            }

            UnityEngine.Debug.Log("检测开始");

            string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
                    .Where(file => file.EndsWith(".bin", System.StringComparison.OrdinalIgnoreCase)
                            && !file.EndsWith(string.Empty))
                    .ToArray();

            foreach (string file in files)
            {
                string newFilePath = Path.Combine(Path.GetDirectoryName(file) ?? string.Empty, Path.GetFileNameWithoutExtension(file));
                File.Move(file, newFilePath);
                UnityEngine.Debug.Log($"Renamed: {file} -> {newFilePath}");
            }

            AssetDatabase.Refresh();
            UnityEngine.Debug.Log("检测结束");
        }

        [MenuItem("Tools/修改寻路数据为无后缀[服务器]")]
        static void RenamePathFilesInFolder2()
        {
            string dataPath = Application.dataPath; //"H:/GitWeiJing/Unity/Assets"
            string folderPath = dataPath.Remove(dataPath.Length - 12, 12) + $"Config/Recast";
            if (string.IsNullOrEmpty(folderPath))
            {
                UnityEngine.Debug.Log("Folder selection canceled.");
                return;
            }

            UnityEngine.Debug.Log("检测开始");

            string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
                    .Where(file => file.EndsWith(".bin", System.StringComparison.OrdinalIgnoreCase)
                            )
                    .ToArray();

            foreach (string file in files)
            {
                string newFilePath = Path.Combine(Path.GetDirectoryName(file) ?? string.Empty, Path.GetFileNameWithoutExtension(file));
                File.Move(file, newFilePath);
                UnityEngine.Debug.Log($"Renamed: {file} -> {newFilePath}");
            }

            AssetDatabase.Refresh();
            UnityEngine.Debug.Log("检测结束");
        }



        #region Tools 
        [MenuItem("XAsset/Tools/View CRC")]
        private static void GetCRC()
        {
            var path = EditorUtility.OpenFilePanel("OpenFile", Environment.CurrentDirectory, "");
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            using (var fs = File.OpenRead(path))
            {
                var crc = Utility.GetCRC32Hash(fs);
                ET.Log.Debug(crc);
            }
        }

        [MenuItem("XAsset/Tools/View MD5")]
        private static void GetMD5()
        {
            var path = EditorUtility.OpenFilePanel("OpenFile", Environment.CurrentDirectory, "");
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            using (var fs = File.OpenRead(path))
            {
                var crc = Utility.GetMD5Hash(fs);
                ET.Log.Debug(crc);
            }
        }
        #endregion 
    }
}