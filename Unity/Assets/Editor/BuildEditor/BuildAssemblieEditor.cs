using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEditor;
using UnityEditor.Compilation;
using HybridCLR.Editor.Commands;
using HybridCLR.Editor;

namespace ET
{
    public static class BuildAssemblieEditor
    {
        private const string CodeDir = "Assets/Bundles/Code/";

        [MenuItem("Tools/Build/BuildWoLongCodeForBundle")]
        public static void BuildCodeForBundle()
        {
            CompileDllCommand.CompileDll(BuildTarget.Android);
            AfterCompiling_wolong(Define.HybridCLRBuildHotFixOutputDir);
        }

        [MenuItem("Tools/Build/EnableAutoBuildCodeDebug _F1")]
        public static void SetAutoBuildCode()
        {
            PlayerPrefs.SetInt("AutoBuild", 1);
            ShowNotification("AutoBuildCode Enabled");
        }
        
        [MenuItem("Tools/Build/DisableAutoBuildCodeDebug _F2")]
        public static void CancelAutoBuildCode()
        {
            PlayerPrefs.DeleteKey("AutoBuild");
            ShowNotification("AutoBuildCode Disabled");
        }

        //[MenuItem("Tools/Build/BuildCodeDebug _F5")]
        public static void BuildCodeDebug()
        {
            BuildAssemblieEditor.BuildMuteAssembly("Code", new []
            {
                "Assets/Model/",
                "Assets/ModelView/",
                "Assets/Hotfix/",
                "Assets/HotfixView/"
            }, Array.Empty<string>(), CodeOptimization.Debug);

            AfterCompiling();
            
            AssetDatabase.Refresh();
        }
        
        [MenuItem("Tools/Build/BuildCodeRelease _F6")]
        public static void BuildCodeRelease()
        {
            BuildAssemblieEditor.BuildMuteAssembly("Code", new []
            {
                "Assets/Model/",
                "Assets/ModelView/",
                "Assets/Hotfix/",
                "Assets/HotfixView/"
            }, Array.Empty<string>(), CodeOptimization.Release);

            AfterCompiling();

            AssetDatabase.Refresh();
        }
        
        [MenuItem("Tools/Build/BuildData _F7")]
        public static void BuildData()
        {
            BuildAssemblieEditor.BuildMuteAssembly("Data", new []
            {
                "Assets/Model/",
                "Assets/ModelView/",
            }, Array.Empty<string>(), CodeOptimization.Debug);
        }
        
        
        [MenuItem("Tools/Build/BuildLogic _F8")]
        public static void BuildLogic()
        {
            string[] logicFiles = Directory.GetFiles(Define.BuildOutputDir, "Logic_*");
            foreach (string file in logicFiles)
            {
                File.Delete(file);
            }
            
            int random = RandomHelper.RandomNumber(100000000, 999999999);
            string logicFile = $"Logic_{random}";
            
            BuildAssemblieEditor.BuildMuteAssembly(logicFile, new []
            {
                "Assets/Hotfix/",
                "Assets/HotfixView/",
            }, new[]{Path.Combine(Define.BuildOutputDir, "Data.dll")}, CodeOptimization.Debug);
        }

        private static void BuildMuteAssembly(string assemblyName, string[] CodeDirectorys, string[] additionalReferences, CodeOptimization codeOptimization)
        {
            List<string> scripts = new List<string>();
            for (int i = 0; i < CodeDirectorys.Length; i++)
            {
                DirectoryInfo dti = new DirectoryInfo(CodeDirectorys[i]);
                FileInfo[] fileInfos = dti.GetFiles("*.cs", System.IO.SearchOption.AllDirectories);
                for (int j = 0; j < fileInfos.Length; j++)
                {
                    scripts.Add(fileInfos[j].FullName);
                }
            }

            if (!Directory.Exists(Define.BuildOutputDir))
                Directory.CreateDirectory(Define.BuildOutputDir);

            string dllPath = Path.Combine(Define.BuildOutputDir, $"{assemblyName}.dll");
            string pdbPath = Path.Combine(Define.BuildOutputDir, $"{assemblyName}.pdb");
            File.Delete(dllPath);
            File.Delete(pdbPath);

            AssemblyBuilder assemblyBuilder = new AssemblyBuilder(dllPath, scripts.ToArray());
            
            //启用UnSafe
            //assemblyBuilder.compilerOptions.AllowUnsafeCode = true;

            BuildTargetGroup buildTargetGroup = BuildPipeline.GetBuildTargetGroup(EditorUserBuildSettings.activeBuildTarget);

            assemblyBuilder.compilerOptions.CodeOptimization = codeOptimization;
            assemblyBuilder.compilerOptions.ApiCompatibilityLevel = PlayerSettings.GetApiCompatibilityLevel(buildTargetGroup);
            // assemblyBuilder.compilerOptions.ApiCompatibilityLevel = ApiCompatibilityLevel.NET_4_6;
            assemblyBuilder.compilerOptions.AllowUnsafeCode = true;
            assemblyBuilder.additionalReferences = additionalReferences;
            
            assemblyBuilder.flags = AssemblyBuilderFlags.None;
            //AssemblyBuilderFlags.None                 正常发布
            //AssemblyBuilderFlags.DevelopmentBuild     开发模式打包
            //AssemblyBuilderFlags.EditorAssembly       编辑器状态
            assemblyBuilder.referencesOptions = ReferencesOptions.UseEngineModules;

            assemblyBuilder.buildTarget = EditorUserBuildSettings.activeBuildTarget;

            assemblyBuilder.buildTargetGroup = buildTargetGroup;

            assemblyBuilder.buildStarted += delegate(string assemblyPath) { Debug.LogFormat("build start：" + assemblyPath); };

            assemblyBuilder.buildFinished += delegate(string assemblyPath, CompilerMessage[] compilerMessages)
            {
                int errorCount = compilerMessages.Count(m => m.type == CompilerMessageType.Error);
                int warningCount = compilerMessages.Count(m => m.type == CompilerMessageType.Warning);

                Debug.LogFormat("Warnings: {0} - Errors: {1}", warningCount, errorCount);

                if (warningCount > 0)
                {
                    Debug.LogFormat("有{0}个Warning!!!", warningCount);
                }

                if (errorCount > 0)
                {
					if (PlayerPrefs.GetInt("AutoBuild") == 1)//如果开启了自动编译要Cancel掉，否则会死循环
						CancelAutoBuildCode();
                    for (int i = 0; i < compilerMessages.Length; i++)
                    {
                        if (compilerMessages[i].type == CompilerMessageType.Error)
                        {
                            Debug.LogError(compilerMessages[i].message);
                        }
                    }
                }
            };
            
            //开始构建
            if (!assemblyBuilder.Build())
            {
                Debug.LogErrorFormat("build fail：" + assemblyBuilder.assemblyPath);
                return;
            }
        }

        private static void AfterCompiling()
        {
            while (EditorApplication.isCompiling)
            {
                Debug.Log("Compiling wait1");
                // 主线程sleep并不影响编译线程
                Thread.Sleep(1000);
                Debug.Log("Compiling wait2");
            }

            Debug.Log("Compiling finish");

            Directory.CreateDirectory(CodeDir);
            File.Copy(Path.Combine(Define.BuildOutputDir, "Code.dll"), Path.Combine(CodeDir, "Code.dll.bytes"), true);
            File.Copy(Path.Combine(Define.BuildOutputDir, "Code.pdb"), Path.Combine(CodeDir, "Code.pdb.bytes"), true);

            AssetDatabase.Refresh();
            Debug.Log("copy Code.dll to Bundles/Code success!");

            // 设置ab包
            AssetImporter assetImporter1 = AssetImporter.GetAtPath("Assets/Bundles/Code/Code.dll.bytes");
            assetImporter1.assetBundleName = "Code.unity3d";
            AssetImporter assetImporter2 = AssetImporter.GetAtPath("Assets/Bundles/Code/Code.pdb.bytes");
            assetImporter2.assetBundleName = "Code.unity3d";
            AssetDatabase.Refresh();
            Debug.Log("set assetbundle success!");

            Debug.Log("build success!");
            //反射获取当前Game视图，提示编译完成
            ShowNotification("Build Code Success");
        }

        private static void AfterCompiling_wolong(string hotDllPath)
        {
            while (EditorApplication.isCompiling)
            {
                Debug.Log("Compiling wait1");
                // 主线程sleep并不影响编译线程
                Thread.Sleep(1000);
                Debug.Log("Compiling wait2");
            }
            
            Debug.Log("Compiling finish");

            Directory.CreateDirectory(CodeDir);
            //File.Copy(Path.Combine(Define.BuildOutputDir, "Code.dll"), Path.Combine(CodeDir, "Code.dll.bytes"), true);
            //File.Copy(Path.Combine(Define.BuildOutputDir, "Code.pdb"), Path.Combine(CodeDir, "Code.pdb.bytes"), true);
            //File.Copy(Path.Combine(Define.HybridCLRBuildOutputDir, "Unity.Mono.dll"), Path.Combine(CodeDir, "Unity.Mono.dll.bytes"), true);
            //File.Copy(Path.Combine(Define.HybridCLRBuildOutputDir, "Unity.ThirdParty.dll"), Path.Combine(CodeDir, "Unity.ThirdParty.dll.bytes"), true);
            //File.Copy(Path.Combine(Define.HybridCLRBuildOutputDir, "mscorlib.dll"), Path.Combine(CodeDir, "mscorlib.dll.bytes"), true);
            //File.Copy(Path.Combine(Define.HybridCLRBuildOutputDir, "System.Core.dll"), Path.Combine(CodeDir, "System.Core.dll.bytes"), true);
            //File.Copy(Path.Combine(Define.HybridCLRBuildOutputDir, "System.dll"), Path.Combine(CodeDir, "System.dll.bytes"), true);

            //AssetDatabase.Refresh();
            //Debug.Log("copy Code.dll to Bundles/Code success!");

            //// 设置ab包
            //AssetImporter assetImporter1 = AssetImporter.GetAtPath("Assets/Bundles/Code/Code.dll.bytes");
            //assetImporter1.assetBundleName = "Code.unity3d";
            //AssetImporter assetImporter2 = AssetImporter.GetAtPath("Assets/Bundles/Code/Code.pdb.bytes");
            //assetImporter2.assetBundleName = "Code.unity3d";

            List<string> allHotUpdateDllFiles = SettingsUtil.HotUpdateAssemblyFiles;
            foreach (var dll in allHotUpdateDllFiles)
            {
                string file = Path.Combine(hotDllPath, dll);
                if (!File.Exists(file))
                {
                    Debug.LogError($"不存在dll:{file}, 无法跑huatuo模式");
                    continue;
                }
                File.Copy(file, Path.Combine(CodeDir, $"{dll}.bytes"), true);
                AssetDatabase.Refresh();

                AssetImporter assetImporter1 = AssetImporter.GetAtPath($"Assets/Bundles/Code/{dll}.bytes");
                assetImporter1.assetBundleName = "Code.unity3d";
            }


            List<string> aotDllFiles = new List<string>()
            {
                "mscorlib.dll",
                "System.dll",
                "System.Core.dll",
                "Unity.Mono.dll",
                "Unity.ThirdParty.dll",
            };
            foreach (var dll in aotDllFiles)
            {
                string file = Path.Combine(Define.HybridCLRCutOutputDir, dll);
                if (!File.Exists(file))
                {
                    Debug.LogError($"不存在dll:{file}, 无法跑huatuo模式");
                    continue;
                }
                File.Copy(file, Path.Combine(CodeDir, $"{dll}.bytes"), true);
                AssetDatabase.Refresh();

                AssetImporter assetImporter1 = AssetImporter.GetAtPath($"Assets/Bundles/Code/{dll}.bytes");
                assetImporter1.assetBundleName = "Code.unity3d";
            }

            AssetDatabase.Refresh();
            Debug.Log("set assetbundle success!");
            
            Debug.Log("build success!");
            //反射获取当前Game视图，提示编译完成
            ShowNotification("Build Code Success");
        }

        public static void ShowNotification(string tips)
        {
            var game = EditorWindow.GetWindow(typeof(EditorWindow).Assembly.GetType("UnityEditor.GameView"));
            game?.ShowNotification(new GUIContent($"{tips}"));
        }
    }
    
}