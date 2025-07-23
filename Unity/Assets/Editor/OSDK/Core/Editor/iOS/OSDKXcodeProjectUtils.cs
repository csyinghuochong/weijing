#if UNITY_EDITOR && UNITY_IOS
using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS.Xcode;
using System.IO;
using UnityEditor.iOS.Xcode.Extensions;

namespace Douyin.Game
{
    public enum PostProcessBuildCallBackOrder : int
    {
        Core = 100,
        DataLink = 150,
        Cps = 175,
        Douyin = 200,
        Share = 300,
        Record = 400,
        TeamPlay = 500,
        Live = 600,
        DevTools = 700
    }

    public enum PreProcessBuildCallBackOrderiOS : int
    {
        Core = 100,
        DataLink = 150,
        Cps = 175,
        Douyin = 200,
        Share = 300,
        Record = 400,
        TeamPlay = 500,
        Live = 600,
        DevTools = 700
    }
    
    public class OSDKXcodeProjectUtils
    {
        public static string GetPBXProjectTargetName(PBXProject project)
        {
#if UNITY_2019_3_OR_NEWER
            return "Unity-iPhone";
#else
            return PBXProject.GetUnityTargetName();
#endif
        }

        public static string GetMainTargetGuid(PBXProject project)
        { 
#if UNITY_2019_3_OR_NEWER
            return project.GetUnityMainTargetGuid();
#else
            return project.TargetGuidByName(PBXProject.GetUnityTargetName());
#endif
        }

        public static string GetUnityFrameworkGuid(PBXProject project)
        {
#if UNITY_2019_3_OR_NEWER
            return project.GetUnityFrameworkTargetGuid();
#else
            return GetMainTargetGuid(project);
#endif
        }

        /// <summary>
        /// 保存Project
        /// </summary>
        /// <param name="project"></param>
        /// <param name="projPath"></param>
        public static void SaveProject(PBXProject project,string projPath)
        {
            File.WriteAllText(projPath, project.WriteToString());
        }

        /// <summary>
        /// 添加系统动态库
        /// </summary>
        /// <param name="project"></param>
        /// <param name="frameworks"></param>
        /// <param name="targetGuid"></param>
        /// <param name="weak"></param>
        public static void AddFrameworks(PBXProject project,string[] frameworks,string targetGuid = null,bool weak = false)
        {
            if (string.IsNullOrWhiteSpace(targetGuid)) 
                targetGuid = GetUnityFrameworkGuid(project);

            foreach (var i in frameworks) {
                //false 对应 Xcode Require
                //true 对应 Xcode Optional
                project.AddFrameworkToProject(targetGuid, i, weak);
            }
        }

        /// <summary>
        /// 添加系统静态库
        /// </summary>
        /// <param name="project"></param>
        /// <param name="libs"></param>
        /// <param name="targetGuid"></param>
        public static void AddLibs(PBXProject project,string[] libs,string targetGuid = null)
        {
            if (string.IsNullOrWhiteSpace(targetGuid)) 
                targetGuid = GetUnityFrameworkGuid(project);
            foreach (string lib in libs) {
                var fileGuid = project.AddFile("usr/lib/" + lib, "Frameworks/" + lib, PBXSourceTree.Sdk);
                project.AddFileToBuild(targetGuid, fileGuid);
            }
        }
        /// <summary>
        /// 添加自定义的动态库
        /// </summary>
        /// <param name="project"></param>
        /// <param name="frameworkDirectory">framework存放的目录</param>
        /// <param name="frameworks"></param>
        /// <param name="targetGuid"></param>
        public static void AddEmbedFrameworks(PBXProject project, string frameworkDirectory, string[] frameworks, string targetGuid = null)
        {
            if (string.IsNullOrWhiteSpace(targetGuid))
            {
                targetGuid = GetUnityFrameworkGuid(project);    
            }
            foreach (var framework in frameworks)
            {
                var frameworkPath = Path.Combine(frameworkDirectory, framework);
                var fileGuid = project.AddFile(frameworkPath, frameworkPath, PBXSourceTree.Sdk);
                PBXProjectExtensions.AddFileToEmbedFrameworks(project, targetGuid, fileGuid);
            }
            project.SetBuildProperty(targetGuid, "LD_RUNPATH_SEARCH_PATHS", "$(inherited) @executable_path/Frameworks");
        }

        /// <summary>
        /// 移除文件引用
        /// </summary>
        /// <param name="project"></param>
        /// <param name="filePath"></param>
        /// <param name="targetGuid"></param>
        public static void RemoveStaticFramework(PBXProject project, string filePath, string targetGuid = null)
        {
            if (string.IsNullOrWhiteSpace(targetGuid))
            {
                targetGuid = GetUnityFrameworkGuid(project);    
            }
            // project.RemoveFileFromBuild(filePath, targetGuid);
            var guid = project.FindFileGuidByRealPath(filePath);
            project.RemoveFile(guid);
        }

        /// <summary>
        /// 添加iOS资源库
        /// </summary>
        /// <param name="project"></param>
        /// <param name="resourcePaths"></param>
        /// <param name="targetGuid"></param>
        public static void AddBundleResource(PBXProject project, string[] resourcePaths, string targetGuid = null)
        {
            if (string.IsNullOrWhiteSpace(targetGuid))
            {
                targetGuid = GetUnityFrameworkGuid(project);    
            }
            foreach (var resourcePath in resourcePaths)
            {
                var fileGuid = project.AddFile(resourcePath, resourcePath, PBXSourceTree.Source);
                project.AddFileToBuild(targetGuid, fileGuid);
            }
        }

        /// <summary>
        /// 设置编译属性,例如 "ENABLE_BITCODE" = "NO"
        /// </summary>
        /// <param name="project"></param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        /// <param name="targetGuid"></param>
        public static void SetBuildProperty(PBXProject project,string propertyName,string value,string targetGuid = null)
        {
            if (string.IsNullOrWhiteSpace(targetGuid)) 
                targetGuid = GetUnityFrameworkGuid(project);
            project.SetBuildProperty(targetGuid, propertyName, value);
        }
        
        /// <summary>
        /// 设置编译属性,例如 "ENABLE_BITCODE" = "NO"
        /// </summary>
        /// <param name="project"></param>
        /// <param name="properties"></param>
        /// <param name="targetGuid"></param>
        public static void SetBuildProperties(PBXProject project,Hashtable properties,string targetGuid = null)
        {
            if (string.IsNullOrWhiteSpace(targetGuid)) 
                targetGuid = GetUnityFrameworkGuid(project);

            foreach (DictionaryEntry i in properties) {
                project.SetBuildProperty(targetGuid, i.Key.ToString(), i.Value.ToString());
            }
        }
        
        /// <summary>
        /// 添加编译属性,"OTHER_LDFLAGS":["-ObjC"]
        /// </summary>
        /// <param name="project"></param>
        /// <param name="propertyName"></param>
        /// <param name="values"></param>
        /// <param name="targetGuid"></param>
        public static void AddBuildProperty(PBXProject project,string propertyName,List<string> values,string targetGuid = null)
        {
            if (string.IsNullOrWhiteSpace(targetGuid)) 
                targetGuid = GetUnityFrameworkGuid(project);
            project.UpdateBuildProperty(targetGuid, propertyName, values, null);
        }
        
        /// <summary>
        /// 添加编译属性,"OTHER_LDFLAGS":["-ObjC"]
        /// </summary>
        /// <param name="project"></param>
        /// <param name="properties"></param>
        /// <param name="targetGuid"></param>
        public static void AddBuildProperties(PBXProject project,Dictionary<string,List<string>> properties,string targetGuid = null)
        {
            if (string.IsNullOrWhiteSpace(targetGuid)) 
                targetGuid = GetUnityFrameworkGuid(project);
            
            foreach (KeyValuePair<string, List<string>> i in properties) {
                project.UpdateBuildProperty(targetGuid, i.Key, i.Value, null);
            }
        }
        
        /// <summary>
        /// 往Info.plist追加属性
        /// </summary>
        /// <param name="buildPath"></param>
        /// <param name="arg"></param>
        public static void AddInfoPlistProperties(string buildPath,Hashtable arg)
        {
            string plistPath = buildPath + "/Info.plist";
            PlistDocument plist = new PlistDocument();
            plist.ReadFromString(File.ReadAllText(plistPath));
            PlistElementDict rootDict = plist.root;
            
            SetPlist(rootDict, arg);
            //写入
            plist.WriteToFile(plistPath);
        }
        
        /// <summary>
        /// 设置文件编译符号,例如 -fno-objc-arc
        /// </summary>
        /// <param name="project"></param>
        /// <param name="arg"></param>
        /// <param name="targetGuid"></param>
        public static void SetFilesCompileFlag(PBXProject project,Hashtable arg,string targetGuid = null) {
            if (string.IsNullOrWhiteSpace(targetGuid)) 
                targetGuid = GetUnityFrameworkGuid(project);
            
            foreach (DictionaryEntry i in arg) {
                string fileProjPath = i.Key.ToString();
                string fguid = project.FindFileGuidByProjectPath(fileProjPath);
                ArrayList des = i.Value as ArrayList;
                List<string> list = new List<string>();
                foreach (var flag in des) {
                    list.Add(flag.ToString());
                }
                project.SetCompileFlagsForFile(targetGuid, fguid, list);
            }
        }

        public static void SetPlist(PlistElementDict node, Hashtable arg) {
            if (arg != null && arg.Count > 0) {
                foreach (DictionaryEntry i in arg) {
                    string key = i.Key.ToString();
                    object val = i.Value;
                    if (val == null)
                    {
                        if (node.values.ContainsKey(key))
                        {
                            node.values.Remove(key);
                        }
                        continue;
                    }
                    var vType = i.Value.GetType();
                    if (vType == typeof(string)) {
                        node.SetString(key, (string)val);
                    }
                    else if (vType == typeof(bool)) {
                        node.SetBoolean(key, (bool)val);
                    }
                    else if (vType == typeof(float)) {
                        node.SetReal(key, (float)val);
                    }
                    else if (vType == typeof(int)) {
                        node.SetInteger(key, (int)val);
                    }
                    else if (vType == typeof(ArrayList))
                    {
                        PlistElementArray arr;
                        if (node[key] != null && node[key] is PlistElementArray)
                        {
                            arr = (PlistElementArray)node[key];
                        }
                        else
                        {
                            arr = node.CreateArray(key);
                        }
                        var array = val as ArrayList;
                        SetPlist(arr, array);
                    }
                    else if (vType == typeof(Hashtable)) {
                        PlistElementDict dic;
                        if (node[key] != null && node[key] is PlistElementDict)
                        {
                            dic = (PlistElementDict)node[key];
                        }
                        else
                        {
                            dic = node.CreateDict(key);
                        }
                        var table = val as Hashtable;
                        SetPlist(dic, table);
                    }
                }
            }
        }
        private static void SetPlist(PlistElementArray node, ArrayList arg) {
            if (arg != null) {
                foreach (object i in arg) {
                    object val = i;
                    if (val == null)
                    {
                        continue;
                    }
                    var vType = i.GetType();
                    if (vType == typeof(string)) {
                        node.AddString((string)val);
                    }
                    else if (vType == typeof(bool)) {
                        node.AddBoolean((bool)val);
                    }
                    else if (vType == typeof(double)) {
                        int v = int.Parse(val.ToString());
                        node.AddInteger(v);
                    }
                    else if (vType == typeof(ArrayList)) {
                        var t = node.AddArray();
                        var array = val as ArrayList;
                        SetPlist(t, array);
                    }
                    else if (vType == typeof(Hashtable)) {
                        var t = node.AddDict();
                        var table = val as Hashtable;
                        SetPlist(t, table);
                    }
                }
            }
        }
    }
}
#endif