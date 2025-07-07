using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEditor.Build.Reporting;
using System.Reflection;
using libx;
using ET;


//监听Unity启动，一启动就执行
[InitializeOnLoad]
public class rememberKeyStore
{
	// 用于解析 ExternalTools.json 的数据结构
	[System.Serializable]
	private class ExternalToolsPrefs
	{
		public AndroidSettings Android = new AndroidSettings();
	}
    
	[System.Serializable]
	private class AndroidSettings
	{
		public string gradlePath = "";
		// 其他 Android 设置字段...
	}

	
	
	static rememberKeyStore()
	{
        //Google

#if Google
#if UNITY_ANDROID
		//秘钥名称：注意这里要加上.keystore后缀
		PlayerSettings.Android.keystoreName = "google.keystore";

		// 密钥密码
		PlayerSettings.Android.keystorePass = "weijing829475";

		// 密钥别名
		PlayerSettings.Android.keyaliasName = "weijingchinaboy";

		// 密钥别名密码
		PlayerSettings.Android.keyaliasPass = "weijing829475";
		
		PlayerSettings.applicationIdentifier = "com.goinggame.weijing";
		
		// 可选：设置 Gradle 路径为 Unity 内置路径
		//string unityGradlePath = "F:\\soft\\android\\gradle-6.7.1";
		//EditorPrefs.SetString("AndroidGradlePath", unityGradlePath);
#endif
#else

#if UNITY_ANDROID
        //秘钥名称：注意这里要加上.keystore后缀
        PlayerSettings.Android.keystoreName = "user.keystore";

		// 密钥密码
		PlayerSettings.Android.keystorePass = "829475";

		// 密钥别名
		PlayerSettings.Android.keyaliasName = "chinaboy";

		// 密钥别名密码
		PlayerSettings.Android.keyaliasPass = "829475";
		
		PlayerSettings.applicationIdentifier = "com.example.weijinggame";
		
		EditorPrefs.SetString("AndroidGradleUseEmbedded", "true");
#endif
#endif

	}
}

public class MyEditorScript
{
	static string[] SCENES = FindEnabledEditorScenes();

	[MenuItem("Custom/Build IOS【Add AppleSignin】")]
	static void PerformIOSBuild()
	{
		//打包之前先设置一下 预定义标签， 我建议大家最好 做一些  91 同步推 快用 PP助手一类的标签。 这样在代码中可以灵活的开启 或者关闭 一些代码。
		//因为 这里我是承接 上一篇文章， 我就以sharesdk做例子 ，这样方便大家学习 ，
		PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS, "NET452;DISABLE_ILRUNTIME_DEBUG;ILRuntime:UNITY_EDITO");

		//这里就是构建xcode工程的核心方法了，
		//参数1 需要打包的所有场景
		//参数2 需要打包的名子， 这里取到的就是 shell传进来的字符串 91
		//参数3 打包平台
		string[] scenes = new string[] { SCENES[0] };
		BuildPipeline.BuildPlayer(scenes, "ios", BuildTarget.iOS, BuildOptions.None);
	}

    [MenuItem("Custom/Build Android TapTap1")]
    static void PerformAndroidTapTap1Build()
    {
        BulidTarget("TapTap1", "Android");   
    }

    [MenuItem("Custom/Build Android QQ2")]
    static void PerformAndroidQQ2Build()
    {
        BulidTarget("QQ2", "Android");
    }

    [MenuItem("Custom/Build Android Platform3")]
    static void PerformAndroidPlatform3Build()
    {
        BulidTarget("Platform3", "Android");
    }

    [MenuItem("Custom/Build Android TikTok5")]
    static void PerformAndroidTikTok5Build()
    {
        BulidTarget("TikTok5", "Android");
    }

    [MenuItem("Custom/Build Android TikTokMuBao6")]
    static void PerformAndroidTikTokMuBao6Build()
    {
        BulidTarget("TikTokMuBao6", "Android");
    }

    [MenuItem("Custom/Build Android ALL")]
    static void PerformAndroidALLBuild()
    {
        BulidTarget("TapTap1", "Android");
        BulidTarget("QQ2", "Android");
    }

    [MenuItem("Custom/Build Android QuDao")]
	static void PerformAndroidQuDaoBuild()
	{
		BulidTarget("QuDao", "Android");
	}
	
	[MenuItem("Custom/Build Android Google")]
	static void PerformAndroidGoogleBuild()
	{
		BulidTarget("Google", "Android");
	}

	private static string targetPath = Application.dataPath + @"\Plugins\Android\libs_alipay"; //目标路径   ../表示当前项目文件的父路径
	private static string mainfestFile = Application.dataPath + @"\Plugins\Android\AndroidManifest"; //目标路径   ../表示当前项目文件的父路径
	private static bool isNull = false;
	private static void CopyLibs(string path)
	{
		isNull = false;

        //"D:/weijingHot/trunk_2022_0213/Unity/Assets"
        //D:\weijingHot\trunk_2022_0213\Unity\Android
        //string formPath = Application.dataPath;
        //formPath = formPath.Replace("Assets", "Android/");
        string formPath = @"F:\gitcustom\trunk_android\AndroidProject_WeiJing\Android\";
        CopyDirectory(formPath + path, Application.dataPath + @"\Plugins\Android");
		if (!isNull)
		{
			Debug.Log("目录文件导入成功！！");
		}
	}

	/// <summary>
	/// 拷贝文件
	/// </summary>
	/// <param name="srcDir">起始文件夹</param>
	/// <param name="tgtDir">目标文件夹</param>
	public static void CopyDirectory(string srcDir, string tgtDir)
	{
		DirectoryInfo source = new DirectoryInfo(srcDir);
		DirectoryInfo target = new DirectoryInfo(tgtDir);

		if (target.FullName.StartsWith(source.FullName, StringComparison.CurrentCultureIgnoreCase))
		{
			throw new Exception("父目录不能拷贝到子目录！");
		}

		if (!source.Exists)
		{
			return;
		}

		if (!target.Exists)
		{
			target.Create();
		}

		FileInfo[] files = source.GetFiles();
		DirectoryInfo[] dirs = source.GetDirectories();
		if (files.Length == 0 && dirs.Length == 0)
		{
			isNull = true;
			return;
		}
		for (int i = 0; i < files.Length; i++)
		{
			File.Copy(files[i].FullName, Path.Combine(target.FullName, files[i].Name), true);
		}
		for (int j = 0; j < dirs.Length; j++)
		{
			CopyDirectory(dirs[j].FullName, Path.Combine(target.FullName, dirs[j].Name));
		}
	}

	//删除目标文件夹下面所有文件
	public static void CleanDirectory(string dir)
	{
		foreach (string subdir in Directory.GetDirectories(dir))
		{
			Directory.Delete(subdir, true);
		}

		foreach (string subFile in Directory.GetFiles(dir))
		{
			File.Delete(subFile);
		}
	}

    /// <summary>
    /// 删除指定目录下的所有内容，但保留目录本身
    /// </summary>
    /// <param name="directoryPath">要清理的目录路径</param>
    static void DeleteDirectoryContents(string directoryPath)
    {
        // 删除目录下的所有文件
        foreach (string filePath in Directory.GetFiles(directoryPath))
        {
            try
            {
                File.SetAttributes(filePath, FileAttributes.Normal); // 确保文件为普通属性
                File.Delete(filePath);
                Console.WriteLine($"已删除文件: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"无法删除文件 '{filePath}': {ex.Message}");
            }
        }

        // 递归删除所有子目录
        foreach (string subDirectoryPath in Directory.GetDirectories(directoryPath))
        {
            try
            {
                DeleteDirectoryContents(subDirectoryPath); // 先递归删除子目录内容
                Directory.Delete(subDirectoryPath); // 再删除空目录
                Console.WriteLine($"已删除目录: {subDirectoryPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"无法删除目录 '{subDirectoryPath}': {ex.Message}");
            }
        }
    }

    /// <summary>
    /// 递归复制文件夹及其内容
    /// </summary>
    /// <param name="sourceFolder">源文件夹路径</param>
    /// <param name="destinationFolder">目标文件夹路径</param>
    static void CopyFolderContents(string sourceFolder, string destinationFolder)
    {
        // 创建目标文件夹（如果不存在）
        if (!Directory.Exists(destinationFolder))
        {
            Directory.CreateDirectory(destinationFolder);
            Console.WriteLine($"创建文件夹: {destinationFolder}");
        }

        // 复制文件
        string[] files = Directory.GetFiles(sourceFolder);
        foreach (string file in files)
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(destinationFolder, fileName);
            File.Copy(file, destFile, true);
            Console.WriteLine($"复制文件: {file} -> {destFile}");
        }

        // 递归复制子文件夹
        string[] subFolders = Directory.GetDirectories(sourceFolder);
        foreach (string subFolder in subFolders)
        {
            string folderName = Path.GetFileName(subFolder);
            string destSubFolder = Path.Combine(destinationFolder, folderName);
            CopyFolderContents(subFolder, destSubFolder);
        }
    }

    static bool RenameFolderExample(string qudao)
    {
        string oldPath = "Assets/StreamingAssets";
        string newPath = "Assets/StreamingAssetsGoogle";

        // 构建新路径（保持父目录不变，仅修改文件夹名）
        //string parentPath = System.IO.Path.GetDirectoryName(oldPath);
       // string newPath = System.IO.Path.Combine(parentPath, newName);

		// 执行重命名（通过移动实现）
		string success = string.Empty;
		if (qudao == "Google")
		{
            success = AssetDatabase.MoveAsset(oldPath, newPath);
        }
		else
		{
            success = AssetDatabase.MoveAsset(newPath, oldPath);
        }
		
        if (string.IsNullOrEmpty(success))
        {
            AssetDatabase.Refresh(ImportAssetOptions.ForceSynchronousImport); // 刷新项目视图
            Debug.Log($"文件夹已重命名为: {newPath}");
			return true;
        }
        else
        {
			// 重命名失败时获取错误信息
			return false;
        }
    }

    static void BulidTarget(string name, string target)
	{
		if (Directory.Exists(targetPath))
		{
			CleanDirectory(targetPath);
		}
		if (File.Exists(mainfestFile))
		{
			File.Delete(mainfestFile);
		}
		string app_name = "危境";
		int version = EditorRuntimeInitializeOnLoad.GetVersion();
		string target_dir = Application.dataPath + "/TargetAndroid";
		
		if(name == "Google")
		{
			CopyLibs("google");
			app_name = "危境google";
		}
		else if (name == "TikTok5")
		{
            CopyLibs("tiktok");
            app_name = "抖音";
        }
		else if (name == "QuDao")
		{
			CopyLibs("qudao");
			app_name = "危境渠道母包";
        }
		else
		{
            //TikTokMuBao6 也是用的官方的安卓库
            CopyLibs("guanfang"); 
			app_name = "危境";
		}
		
		app_name = app_name + ((VersionMode)version).ToString() + name;

		string target_name = app_name;
		
		BuildTargetGroup targetGroup = BuildTargetGroup.Android;
		BuildTarget buildTarget = BuildTarget.Android;
		string applicationPath = Application.dataPath.Replace("/Assets", "");
		

        if (target == "Android")
		{

            #region
            ///test1-----------------------------------------------------------
            ///string streamPath = Application.streamingAssetsPath;
            //         if (Directory.Exists(streamPath))
            //         {
            //             Console.WriteLine($"开始清理目录: {streamPath}");
            //             DeleteDirectoryContents(streamPath);

            //             AssetDatabase.Refresh(ImportAssetOptions.ForceSynchronousImport);
            //             Console.WriteLine($"目录 {streamPath} 清理完成!");
            //         }
            //if (name != "Google")
            //{
            //             //Application.dataPath: H:/GitWeiJing/Unity/Assets  -》
            //             //Log.ILog.Debug($"Application.dataPath: {Application.dataPath}");
            //             string sourceFolder = Application.dataPath.Replace("Unity/Assets", "Release/DLCBeta/WJ/Android");

            //             CopyFolderContents(sourceFolder, streamPath);
            //             // AssetDatabase.MoveAsset(sourceFolder, streamPath);

            //             AssetDatabase.Refresh(ImportAssetOptions.ForceSynchronousImport);
            //             Console.WriteLine($"目录 {sourceFolder}  {streamPath} 拷贝完成!");
            //         }
            //AssetDatabase.ImportAsset(streamPath);
            //AssetDatabase.importPackageCompleted += OnRefreshComplete;

            ///test1-----------------------------------------------------------
            #endregion test1


            //test2-----------------------------------------------------------
            //bool renamesucess = RenameFolderExample(name);
            //if (!renamesucess)
            //{
            //	return;
            //}
            //test2-----------------------------------------------------------

            if (name == "Google")
            {
				target_name = app_name + ".aab";

                //歌谷要打空包
            }
			else
			{
				target_name = app_name + ".APK";

				//其他要打全包
			}

			target_dir = applicationPath + "/AndroidTarget";
			
			targetGroup = BuildTargetGroup.Android;
		}
		if (target == "IOS")
		{
			target_dir = applicationPath + "/IOSTarget";
			target_name = app_name;
			targetGroup = BuildTargetGroup.iOS;
			buildTarget = BuildTarget.iOS;
		}


		if (Directory.Exists(target_dir))
		{
			if (File.Exists(target_name))
			{
				File.Delete(target_name);
			}
		}
		else
		{
			Directory.CreateDirectory(target_dir);
		}
		
		if(name == "QuDao" )
		{
			PlayerSettings.Android.targetSdkVersion = AndroidSdkVersions.AndroidApiLevel26;
		}
		else if (name == "Google" )
		{
			PlayerSettings.Android.targetSdkVersion = AndroidSdkVersions.AndroidApiLevel30;
		}
		else
		{
			PlayerSettings.Android.targetSdkVersion = AndroidSdkVersions.AndroidApiLevelAuto;
		}
		
        PlayerSettings.SetScriptingDefineSymbolsForGroup(targetGroup, ";" + name);
		PlayerSettings.SetScriptingDefineSymbolsForGroup(targetGroup, "NET452;DISABLE_ILRUNTIME_DEBUG;" + name);

		string[] scenes = new string[] { SCENES[0] };
		PlayerSettings.Android.useCustomKeystore = true;
		if (name == "Google")
		{
			PlayerSettings.Android.keystoreName = "F:\\gitcustom\\trunk_android\\AndroidProject_WeiJing\\google.keystore";
			PlayerSettings.Android.keystorePass = "weijing829475";
			PlayerSettings.Android.keyaliasName = "weijingchinaboy";
			PlayerSettings.Android.keyaliasPass = "weijing829475";
			EditorUserBuildSettings.buildAppBundle = true;
		}
		else
		{
			PlayerSettings.Android.keystoreName = "F:\\gitcustom\\trunk_android\\AndroidProject_WeiJing\\user.keystore";
			PlayerSettings.Android.keystorePass = "829475";
			PlayerSettings.Android.keyaliasName = "chinaboy";
			PlayerSettings.Android.keyaliasPass = "829475";
			EditorUserBuildSettings.buildAppBundle = false;
		}

        if (name == "TikTok5")
		{
            PlayerSettings.applicationIdentifier = "com.example.weijinggame.bytedance.gamecenter";
        }
        if (name == "Google")
        {
            PlayerSettings.applicationIdentifier = "com.goinggame.weijing";
        }
        else
		{
            PlayerSettings.applicationIdentifier = "com.example.weijinggame";
        }
		UnityEngine.Debug.Log(buildTarget);
        GenericBuild(scenes, target_dir + "/" + target_name, buildTarget, targetGroup, BuildOptions.None);
	}

	private static string[] FindEnabledEditorScenes()
	{
		List<string> EditorScenes = new List<string>();
		foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
		{
			if (!scene.enabled) continue;
			EditorScenes.Add(scene.path);
		}
		return EditorScenes.ToArray();
	}

	static void GenericBuild(string[] scenes, string target_dir, BuildTarget build_target, BuildTargetGroup target_grooup, BuildOptions build_options)
	{
		EditorUserBuildSettings.SwitchActiveBuildTarget(target_grooup, build_target);
		BuildReport br = BuildPipeline.BuildPlayer(scenes, target_dir, build_target, build_options);
		if (br.summary.result == BuildResult.Failed)
		{
			throw new Exception("BuildPlayer failure: " + br);
		}
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

			FieldInfo[] allFieldInfo = (ai_1.GetType()).GetFields(BindingFlags.NonPublic | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Static);

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

	[MenuItem("Custom/修改子对象Tag")]
	static void ChangeChildTag()
	{
		if (Selection.gameObjects.Length == 0)
		{
			return;
		}

		for (int i = 0; i < Selection.gameObjects.Length; i++)
		{
			GameObject go = Selection.gameObjects[i];
			SetChildTags(go.transform, go.tag);
		}
	}

	private static void SetChildTags(Transform target, string tag)
	{
		if (target == null)
		{
			return;
		}

		foreach (Transform item in target)
		{
			item.tag = tag;
			SetChildTags(item, tag);
		}
	}


	//[MenuItem("Tools/GetPrefabPath")]
	//public static void testselect()
	//{
	//	UnityEngine.Object selectgo = Selection.activeObject;
	//	UnityEngine.GameObject go = selectgo as UnityEngine.GameObject;
	//	UI_FunctionOpen ttt = go.GetComponent<UI_FunctionOpen>();

	//	//��ȡʵ������������ֶΣ�BindingFlags����ö�٣�
	//	FieldInfo[] allFieldInfo = (ttt.GetType()).GetFields(BindingFlags.NonPublic | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Static);

	//	string prefabPath = "";

	//	for (int i = 0; i < allFieldInfo.Length; i++)
	//	{
	//		if (allFieldInfo[i].FieldType == typeof(UnityEngine.GameObject))
	//		{

	//			UnityEngine.GameObject totoot = allFieldInfo[i].GetValue(ttt) as UnityEngine.GameObject;

	//			if (totoot != null)
	//			{
	//				string path_1 = PrefabUtility.GetPrefabAssetPathOfNearestInstanceRoot(totoot as UnityEngine.Object);

	//				if (path_1 != "")
	//				{
	//					path_1 = path_1.Substring(17, path_1.Length - 17);

	//					prefabPath = prefabPath + allFieldInfo[i].Name + "    " + path_1;
	//					prefabPath = prefabPath + "\n";
	//				}
	//			}
	//		}
	//	}

	//	string txt_path = "F:/1.txt";
	//	StreamWriter sw = new StreamWriter(txt_path);
	//	sw.WriteLine(prefabPath);
	//	sw.Close();

	//	Debug.Log(prefabPath);
	//}
}