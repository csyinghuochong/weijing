using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class MulLanguageEditor : Editor
{
	private static string UIPrefabPath = Application.dataPath + "/Bundles/UI";
	private static string OutPath = Application.dataPath + "/out.txt";

	private static HashSet<string> LocalizationSet = null;
	private static Dictionary<string, List<string>> ResultMap = null;

	[MenuItem("Tools/导出多语言")]
	static void ExportChinese()
	{
		LocalizationSet = new HashSet<string>();
		ResultMap = new Dictionary<string, List<string>>();

		StringBuilder sb = new StringBuilder();
		sb.AppendLine("=========== 多语言提取报告 ===========");
		sb.AppendLine($"导出时间: {System.DateTime.Now}");
		sb.AppendLine("---------------------------------------\n");

		// 提取 Prefab 中文
		sb.AppendLine("【Prefab 中的中文】");
		LoadDirectoryPrefab(new DirectoryInfo(UIPrefabPath));

		// 提取脚本中的中文
		sb.AppendLine("\n【Script 中的中文】");
		LoadDirectoryCS(new DirectoryInfo(Application.dataPath + "/Hotfix"));
		LoadDirectoryCS(new DirectoryInfo(Application.dataPath + "/HotfixView"));
		LoadDirectoryCS(new DirectoryInfo(Application.dataPath + "/Model"));
		LoadDirectoryCS(new DirectoryInfo(Application.dataPath + "/ModelView"));

		// 整理输出
		int count = 0;
		foreach (var entry in ResultMap)
		{
			sb.AppendLine($"[{entry.Key}]");
			foreach (var line in entry.Value)
			{
				sb.AppendLine($"\t\"{line}\"");
				count++;
			}
		}

		sb.AppendLine($"\n---------------------------------------");
		sb.AppendLine($"共提取中文条目：{count} 条");

		// 写入文件
		if (File.Exists(OutPath)) File.Delete(OutPath);
		File.WriteAllText(OutPath, sb.ToString(), Encoding.UTF8);
		AssetDatabase.Refresh();
		Debug.Log("多语言导出完成！");
	}

	static void LoadDirectoryPrefab(DirectoryInfo directoryInfo)
	{
		if (!directoryInfo.Exists) return;

		FileInfo[] fileInfos = directoryInfo.GetFiles("*.prefab", SearchOption.AllDirectories);
		foreach (FileInfo file in fileInfos)
		{
			string fullPath = file.FullName;
			string relativePath = fullPath.Substring(Application.dataPath.Length + 1).Replace("\\", "/");
			string assetPath = "Assets" + fullPath.Substring(Application.dataPath.Length).Replace("\\", "/");
			GameObject prefab = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)) as GameObject;
			GameObject instance = GameObject.Instantiate(prefab) as GameObject;

			SearchPrefabString(relativePath, instance.transform);
			GameObject.DestroyImmediate(instance);
		}
	}

	static void SearchPrefabString(string path, Transform root)
	{
		foreach (Transform child in root)
		{
			Text label = child.GetComponent<Text>();
			if (label != null)
			{
				string text = label.text?.Replace("\n", @"\n");
				if (!string.IsNullOrEmpty(text) && ContainsChinese(text) && LocalizationSet.Add(text))
				{
					if (!ResultMap.ContainsKey(path))
						ResultMap[path] = new List<string>();
					ResultMap[path].Add(text);
				}
			}

			if (child.childCount > 0)
			{
				SearchPrefabString(path, child);
			}
		}
	}

	static void LoadDirectoryCS(DirectoryInfo directoryInfo)
	{
		if (!directoryInfo.Exists) return;

		FileInfo[] fileInfos = directoryInfo.GetFiles("*.cs", SearchOption.AllDirectories);
		Regex stringRegex = new Regex("\"(.*?)\"", RegexOptions.Compiled);

		foreach (FileInfo file in fileInfos)
		{
			string fullPath = file.FullName;
			string relativePath = fullPath.Substring(Application.dataPath.Length + 1).Replace("\\", "/");
			string content = File.ReadAllText(fullPath);
			MatchCollection matches = stringRegex.Matches(content);

			foreach (Match match in matches)
			{
				string str = match.Groups[1].Value;
				if (!string.IsNullOrEmpty(str) && ContainsChinese(str) && LocalizationSet.Add(str))
				{
					if (!ResultMap.ContainsKey(relativePath))
						ResultMap[relativePath] = new List<string>();
					ResultMap[relativePath].Add(str);
				}
			}
		}
	}

	static bool ContainsChinese(string input)
	{
		return Regex.IsMatch(input, "[\u4e00-\u9fa5]");
	}
}
