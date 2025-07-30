using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKTemplateGradle
    {
        private static readonly string AndroidGradleTemplateDir =
            $"{OSDKProjectPathUtils.SdkDir}/Core/Plugins/Android/Gradle";

        private static readonly string AllProjectsTemplatePath =
            AndroidGradleTemplateDir + "/OSDK_AllProjects_Config_LauncherTemplate.gradle";

        private static readonly string BuildscriptTemplatePath =
            AndroidGradleTemplateDir + "/OSDK_BuildScript_Config_LauncherTemplate.gradle";

        private static readonly string MavenConfigTemplatePath =
            AndroidGradleTemplateDir + "/OSDK_Maven_Config_Template.gradle";

        private const string GradleAllProjectsTag = "allprojects {";
        private const string GradleBuildScriptTag = "buildscript {";
        private const string GradleRepositoriesTag = "repositories {";
        public const string GradleAndroidTag = "android {";
        private const string GradleMinSdkVersionTag = "minSdkVersion";
        private const string GradleTargetSdkVersionTag = "targetSdkVersion";
        private const string CompileSdkVersionTag = "compileSdkVersion";
        private const string GradleDefaultConfigTag = "defaultConfig {";
        private const string GradleMultiDexEnableTag = "multiDexEnabled";

        public const string GradleApplicationPluginTag = "apply plugin";
        private const string GradleDepsTag = "**DEPS**}";

        private const string ToolsBuildGradleTAG = "com.android.tools.build:gradle:";

        // 2440前：配置最小适配的AndroidSDK版本为19
        // 2440: 已适配target33、34
        // private const int ConfigMinSdkVersion = 21;
        // private const int TargetSdkVersion = 30;
        // private const int CompileSdkVersion = 30;

        // tools build gradle
        private const string ConfigToolsBuildGralde = "        classpath 'com.android.tools.build:gradle:3.4.3'";

        // gradle路径
        private readonly string _path;

        protected OSDKTemplateGradle(string path)
        {
            _path = path;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultTemplatePath">gradle 模板路径</param>
        protected void SetDefault(string defaultTemplatePath)
        {
#if TikTokGuanFu8
            CheckTargetTemplateGradle(defaultTemplatePath);
            PrepareAllProjectsScopeIfNotExist();
            PrepareBuildScriptTagScopeIfNotExist();
            SetupMavenRepositories();
            // SetupMinAndroidSdkVersion();
            // SetupTargetSdkVersion();
            // SetupCompileSdkVersion();
            SetupMultiDexEnable();
            SetupToolsBuildVersion();
#endif

        }

        /// <summary>
        /// 检查目标文件是否存在，不存在就把默认的拷贝过去.
        /// </summary>
        /// <param name="defaultTemplatePath">默认文件路径</param>
        protected void CheckTargetTemplateGradle(string defaultTemplatePath)
        {
            if (!File.Exists(_path))
            {
                var dir = Path.GetDirectoryName(_path);
                if (!Directory.Exists(dir))
                {
                    if (dir != null) Directory.CreateDirectory(dir);
                }

                if (File.Exists(defaultTemplatePath))
                {
                    File.Copy(defaultTemplatePath, _path);
                }
            }
        }

        /// <summary>
        /// 移除gradle相关配置
        /// </summary>
        /// <param name="removePath"></param>
        public void RemoveGradleConfig(string removePath)
        {
            if (!File.Exists(removePath)) return;

            var removeLines = File.ReadAllLines(removePath, Encoding.UTF8);
            if (removeLines.Length < 2)
            {
                Debug.Log("Please write comments at the beginning and end...");
                return;
            }

            var startTag = removeLines[0];
            var endTag = removeLines[removeLines.Length - 1];
            RemoveLines(startTag, endTag);
        }

        /// <summary>
        /// 返回移除的行数
        /// </summary>
        public void RemoveLines(string startTag, string endTag)
        {
            if (!File.Exists(_path))
            {
                return;
            }
            if (string.IsNullOrEmpty(startTag) || string.IsNullOrEmpty(endTag))
            {
                Debug.Log("startTag is empty or endTag is empty!");
                return;
            }

            var allLines = File.ReadAllLines(_path, Encoding.UTF8);
            var newLines = new List<string>(allLines.Length);
            
            var isIgnoreLine = false;
            foreach (var lineText in allLines)
            {
                if (lineText.Contains(startTag))
                {
                    isIgnoreLine = true;
                    continue;
                }

                if (lineText.Contains(endTag))
                {
                    isIgnoreLine = false;
                    continue;
                }

                if (!isIgnoreLine)
                {
                    newLines.Add(lineText);
                }
            }
            Debug.Log($"File.WriteAllLines:  {_path}");
            File.WriteAllLines(_path, newLines, Encoding.UTF8);
            AssetDatabase.Refresh();
        }

        /// <summary>
        /// 更新或插入到Android模块tag中.
        /// </summary>
        /// <param name="insertFilePath"></param>
        public void UpdateOrInsertToAndroidTag(string insertFilePath)
        {
            UpdateOrInsertLines(GradleAndroidTag, insertFilePath, false);
        }

        /// <summary>
        /// 更新依赖,没有则添加
        /// </summary>
        /// <param name="insertFilePath"></param>
        public void UpdateOrInsertDependencies(string insertFilePath, bool remove = false)
        {
            //insertFilePath 中的文本插入到 GradleDEPSTag 标签的前面
            UpdateOrInsertLines(GradleDepsTag, insertFilePath, true, remove);
        }

        protected void SetupMavenRepositories()
        {
            //将MavenConfigTemplatePath 中的文本插入到 GradleRepositoriesTag 标签的下一行 
            UpdateOrInsertLines(GradleRepositoriesTag, MavenConfigTemplatePath, false);
        }

        /// <summary>
        /// 将 [insertPath] 中的文本插入到 [tag] 标签的 上一行/下一行,取决于 [isInsertBefore] == true/false
        /// </summary>
        /// <param name="tag">插入文本锚定的标签</param>
        /// <param name="insertPath">需要插入文本文件路径</param>
        /// <param name="isInsertBefore">是否插入到标签前面</param>
        public void UpdateOrInsertLines(string tag, string insertPath, bool isInsertBefore, bool remove = false)
        {
            if (!File.Exists(_path)) return;
            if (!File.Exists(insertPath)) return;
            var insertLines = File.ReadAllLines(insertPath, Encoding.UTF8);
            if (insertLines.Length < 2)
            {
                Debug.Log("Please write comments at the beginning and end...");
                return;
            }

            var allLines = File.ReadAllLines(_path, Encoding.UTF8);
            var newLines = new List<string>(allLines.Length + insertLines.Length);
            var startTag = insertLines[0];
            var endTag = insertLines[insertLines.Length - 1];
            var isIgnoreLine = false;
            foreach (var lineText in allLines)
            {
                if (lineText.Contains(tag))
                {
                    if (!remove)
                    {
                        if (isInsertBefore)
                        {
                            newLines.AddRange(insertLines);
                            newLines.Add(lineText);
                        }
                        else
                        {
                            newLines.Add(lineText);
                            newLines.AddRange(insertLines);
                        }
                    }
                    else
                    {
                        // 移除对应模块，即忽略从start到end的文本行，不添加insertPath中的内容，只add回tag对应的行
                        newLines.Add(lineText);
                    }
                    continue;
                }

                if (lineText.Contains(startTag))
                {
                    isIgnoreLine = true;
                    continue;
                }

                if (lineText.Contains(endTag))
                {
                    isIgnoreLine = false;
                    continue;
                }

                if (!isIgnoreLine)
                {
                    newLines.Add(lineText);
                }
            }

            File.WriteAllLines(_path, newLines, Encoding.UTF8);
            AssetDatabase.Refresh();
        }


        // private void SetupMinAndroidSdkVersion()
        // {
        //     if (!File.Exists(_path)) return;
        //     var allLines = File.ReadAllLines(_path, Encoding.UTF8);
        //     var newLines = new List<string>(allLines.Length + 10);
        //     var minSdkVersionLine = $"        minSdkVersion {ConfigMinSdkVersion}";
        //     var defaultConfigLineNumber = -1;
        //     var isMinSDKVersionTagExists = false;
        //     for (var i = 0; i < allLines.Length; i++)
        //     {
        //         var line = allLines[i];
        //         if (line.Contains(GradleDefaultConfigTag))
        //         {
        //             defaultConfigLineNumber = i;
        //         }
        //
        //         if (line.Contains(GradleMinSdkVersionTag))
        //         {
        //             isMinSDKVersionTagExists = true;
        //             //minSdkVersion < Config_MinSdkVersion 就换成 Config_MinSdkVersion
        //             var textArray = line.Split(' ');
        //             if (textArray.Length > 0)
        //             {
        //                 var text = textArray[textArray.Length - 1];
        //                 try
        //                 {
        //                     var value = int.Parse(text);
        //                     if (value < ConfigMinSdkVersion)
        //                     {
        //                         line = minSdkVersionLine;
        //                     }
        //                 }
        //                 catch (Exception)
        //                 {
        //                     line = minSdkVersionLine;
        //                 }
        //             }
        //         }
        //
        //         newLines.Add(line);
        //     }
        //
        //     if (!isMinSDKVersionTagExists && defaultConfigLineNumber != -1)
        //     {
        //         //default config 的下一行插入
        //         newLines.Insert(defaultConfigLineNumber + 1, minSdkVersionLine);
        //     }
        //
        //     File.WriteAllLines(_path, newLines, Encoding.UTF8);
        //     AssetDatabase.Refresh();
        // }
        //
        // private void SetupTargetSdkVersion()
        // {
        //     if (!File.Exists(_path)) return;
        //     var allLines = File.ReadAllLines(_path, Encoding.UTF8);
        //     var newLines = new List<string>(allLines.Length + 10);
        //     var targetSdkVersionLine = $"        targetSdkVersion {TargetSdkVersion}";
        //     var defaultConfigLineNumber = -1;
        //     var isTargetSdkVersionTagExists = false;
        //     for (var i = 0; i < allLines.Length; i++)
        //     {
        //         var line = allLines[i];
        //         if (line.Contains(GradleDefaultConfigTag))
        //         {
        //             defaultConfigLineNumber = i;
        //         }
        //
        //         if (line.Contains(GradleTargetSdkVersionTag))
        //         {
        //             isTargetSdkVersionTagExists = true;
        //             var textArray = line.Split(' ');
        //             if (textArray.Length > 0)
        //             {
        //                 var text = textArray[textArray.Length - 1];
        //                 try
        //                 {
        //                     var value = int.Parse(text);
        //                     if (value > TargetSdkVersion)
        //                     {
        //                         line = targetSdkVersionLine;
        //                     }
        //                 }
        //                 catch (Exception)
        //                 {
        //                     line = targetSdkVersionLine;
        //                 }
        //             }
        //         }
        //
        //         newLines.Add(line);
        //     }
        //
        //     if (!isTargetSdkVersionTagExists && defaultConfigLineNumber != -1)
        //     {
        //         //default config 的下一行插入
        //         newLines.Insert(defaultConfigLineNumber + 1, targetSdkVersionLine);
        //     }
        //
        //     File.WriteAllLines(_path, newLines, Encoding.UTF8);
        //     AssetDatabase.Refresh();
        // }
        //
        // private void SetupCompileSdkVersion()
        // {
        //     if (!File.Exists(_path)) return;
        //     var allLines = File.ReadAllLines(_path, Encoding.UTF8);
        //     var newLines = new List<string>(allLines.Length + 10);
        //     var compileSdkVersionLine = $"    compileSdkVersion {CompileSdkVersion}";
        //     foreach (var t in allLines)
        //     {
        //         var line = t;
        //         
        //         if (line.Contains(CompileSdkVersionTag))
        //         {
        //             var textArray = line.Split(' ');
        //             if (textArray.Length > 0)
        //             {
        //                 var text = textArray[textArray.Length - 1];
        //                 try
        //                 {
        //                     var value = int.Parse(text);
        //                     if (value > CompileSdkVersion)
        //                     {
        //                         line = compileSdkVersionLine;
        //                     }
        //                 }
        //                 catch (Exception)
        //                 {
        //                     line = compileSdkVersionLine;
        //                 }
        //             }
        //         }
        //         newLines.Add(line);
        //     }
        //
        //     File.WriteAllLines(_path, newLines, Encoding.UTF8);
        //     AssetDatabase.Refresh();
        // }

        private void SetupMultiDexEnable()
        {
            if (!File.Exists(_path)) return;
            var allLines = File.ReadAllLines(_path);
            var newLines = new List<string>(allLines.Length + 1);
            var defaultConfigLineNumber = -1;
            var isMultiDexEnableTagExists = false;
            var multiDexLine = "        multiDexEnabled true";

            for (var i = 0; i < allLines.Length; i++)
            {
                var lineText = allLines[i];
                if (lineText.Contains(GradleDefaultConfigTag))
                {
                    defaultConfigLineNumber = i;
                }

                if (lineText.Contains(GradleMultiDexEnableTag))
                {
                    //如果有 multiDexEnabled 就设置成true
                    isMultiDexEnableTagExists = true;
                    newLines.Add(multiDexLine);
                    continue;
                }

                newLines.Add(lineText);
            }

            if (!isMultiDexEnableTagExists && defaultConfigLineNumber != -1)
            {
                //default config 的下一行插入
                newLines.Insert(defaultConfigLineNumber + 1, multiDexLine);
            }

            File.WriteAllLines(_path, newLines, Encoding.UTF8);
            AssetDatabase.Refresh();
        }

        private void SetupToolsBuildVersion()
        {
            ReplaceLine(ToolsBuildGradleTAG, ConfigToolsBuildGralde);
        }

        private void ReplaceLine(string originLine, string resultLine)
        {
            if (!File.Exists(_path)) return;
            var allLines = File.ReadAllLines(_path);

            for (var i = 0; i < allLines.Length; i++)
            {
                var lineText = allLines[i];
                if (lineText.Contains(originLine))
                {
                    allLines[i] = resultLine;
                    break;
                }
            }

            File.WriteAllLines(_path, allLines, Encoding.UTF8);
            AssetDatabase.Refresh();
        }

        private void PrepareAllProjectsScopeIfNotExist()
        {
            PrepareScope(_path, GradleAllProjectsTag, AllProjectsTemplatePath);
        }

        private void PrepareBuildScriptTagScopeIfNotExist()
        {
            PrepareScope(_path, GradleBuildScriptTag, BuildscriptTemplatePath);
        }

        private static void PrepareScope(string gradlePath, string scopeName, string templatePath)
        {
            if (!File.Exists(gradlePath)) return;
            var allLines = File.ReadAllLines(gradlePath, Encoding.UTF8);
            var isTagExists = allLines.Any(lineText => lineText.Contains(scopeName));
            if (!isTagExists)
            {
                if (File.Exists(templatePath))
                {
                    var insertLines = File.ReadAllLines(templatePath);
                    var newLines = new List<string>();
                    foreach (var lineText in allLines)
                    {
                        //insert template before line - "apply plugin: 'com.android.application'"
                        if (lineText.Contains(GradleApplicationPluginTag))
                        {
                            newLines.AddRange(insertLines);
                        }

                        newLines.Add(lineText);
                    }

                    File.WriteAllLines(gradlePath, newLines, Encoding.UTF8);
                    AssetDatabase.Refresh();
                }
                else
                {
                    Debug.Log("templatePath does not exist... templatePath : " + templatePath);
                }
            }
        }
    }
}