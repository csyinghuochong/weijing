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
	static rememberKeyStore()
	{
		//秘钥名称：注意这里要加上.keystore后缀
		//PlayerSettings.Android.keystoreName = "文件名.keystore";

		// 密钥密码
		PlayerSettings.Android.keystorePass = "829475";

		// 密钥别名
		//PlayerSettings.Android.keyaliasName = "自己取的别名";

		// 密钥别名密码
		PlayerSettings.Android.keyaliasPass = "829475";
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
       

        if (name == "TikTok5")
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

        int version = EditorRuntimeInitializeOnLoad.GetVersion();
		app_name = app_name + ((VersionMode)version).ToString() + name;

		string target_dir = Application.dataPath + "/TargetAndroid";
		string target_name = app_name + ".APK";
		BuildTargetGroup targetGroup = BuildTargetGroup.Android;
		BuildTarget buildTarget = BuildTarget.Android;
		string applicationPath = Application.dataPath.Replace("/Assets", "");

		if (target == "Android")
		{
			target_dir = applicationPath + "/AndroidTarget";
			target_name = app_name + ".APK";
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

        PlayerSettings.Android.targetSdkVersion = name == "QuDao" ? AndroidSdkVersions.AndroidApiLevel26 : AndroidSdkVersions.AndroidApiLevelAuto;
        PlayerSettings.SetScriptingDefineSymbolsForGroup(targetGroup, ";" + name);
		PlayerSettings.SetScriptingDefineSymbolsForGroup(targetGroup, "NET452;DISABLE_ILRUNTIME_DEBUG;" + name);

		string[] scenes = new string[] { SCENES[0] };
		PlayerSettings.Android.keystorePass = "829475";
		PlayerSettings.Android.keyaliasPass = "829475";

        //PlayerSettings.bundleVersion = "v0.0.1";
        if (name == "TikTok5")
		{
            PlayerSettings.applicationIdentifier = "com.example.weijinggame.bytedance.gamecenter";
        }
		else
		{
            PlayerSettings.applicationIdentifier = "com.example.weijinggame";
        }
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