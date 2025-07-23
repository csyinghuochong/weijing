using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public enum UpdateXmlAttributeState
    {
        // 还没有此属性，插入此属性
        Insert,

        // 有不同的值
        DifferentValue,

        // 已经有了相同的值
        HaveSameValue,

        // 修改失败
        Fail,
    }

    public enum ActivityLaunchMode
    {
        singleTop,
        singleTask,
        standard,
        singleInstance
    }

    public class OSDKAndroidManifest
    {
        private static OSDKAndroidManifest _instance;
        private static readonly string TargetAndroidPluginDir = OSDKAndroidResourceUtils.PluginsAndroidDir;

        private static readonly string TargetManifestFilePath =
            $"{TargetAndroidPluginDir}/{OSDKProjectPathUtils.AndroidManifestXmlFileName}";

        private static readonly string DefaultManifestFilePath = Path.Combine(OSDKProjectPathUtils.SdkDir,
            "Core/Plugins/Android/Manifest/DefaultAndroidManifest.xml");

        // xml中命名空间类型.
        public const string NameSpaceUriAndroid = "http://schemas.android.com/apk/res/android";
        public const string NameSpaceUriTools = "http://schemas.android.com/tools";

        #region AndroidManifest.xml文件中节点名

        private const string XmlNodeManifest = "manifest";
        private const string XmlNodeApplication = "application";
        private const string XmlNodeIntentFilter = "intent-filter";
        private const string XmlNodeAction = "action";
        private const string XmlNodeCategory = "category";

        private const string XmlActionNodeAttrValue = "android.intent.action.MAIN";
        private const string XmlCategoryNodeAttrValue = "android.intent.category.LAUNCHER";

        #endregion

        public OSDKAndroidManifest()
        {
            // 做Manifest的安全检查与基础配置
            SetDefaultIfNotExists();
        }
        
        public static OSDKAndroidManifest Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                _instance = new OSDKAndroidManifest();
                return _instance;
            }
        }

        /// <summary>
        /// Manifest的安全检查与基础配置.
        /// </summary>
        private void SetDefaultIfNotExists()
        {
            // 检查目标目录如果不存在，则创建
            if (!Directory.Exists(TargetAndroidPluginDir))
            {
                Directory.CreateDirectory(TargetAndroidPluginDir);
            }

            if (!File.Exists(TargetManifestFilePath))
            {
                // 文件不存在，将默认的Manifest copy过去
                File.Copy(DefaultManifestFilePath, TargetManifestFilePath);
            }

            // // 插入allowBackup标签.
            // UpdateXmlSingleNodeAttr(
            //     "application",
            //     "android:allowBackup",
            //     "false",
            //     (state, element) =>
            //     {
            //         if (UpdateXmlAttributeState.Insert == state)
            //         {
            //             element.SetAttribute("allowBackup", NameSpaceUriAndroid, "false");
            //         }
            //     });
            //
            // // 添加allowBackup replace 标签
            // UpdateXmlSingleNodeAttr(
            //     "application",
            //     "tools:replace",
            //     "android:allowBackup",
            //     (state, element) =>
            //     {
            //         switch (state)
            //         {
            //             case UpdateXmlAttributeState.Insert:
            //                 element.SetAttribute("replace", NameSpaceUriTools, "android:allowBackup");
            //                 break;
            //             case UpdateXmlAttributeState.DifferentValue:
            //                 var originAttrValue = element.GetAttribute("replace", NameSpaceUriTools);
            //                 var value = originAttrValue.Split(',');
            //                 var hasValue = value.Any(s => s == "android:allowBackup");
            //                 if (!hasValue)
            //                 {
            //                     element.SetAttribute("replace", NameSpaceUriTools,
            //                         originAttrValue + ",android:allowBackup");
            //                 }
            //
            //                 break;
            //         }
            //     });
            AssetDatabase.Refresh();
        }

        /// <summary>
        /// 插入xml文件到manifest节点中.
        /// </summary>
        /// <param name="configFilePath">需要插入的文件名.</param>
        public void InsertOrUpdateXml_ToManifestChildNode(string configFilePath)
        {
            if (!File.Exists(configFilePath))
            {
                Debug.Log("configFilePath is null..");
                return;
            }

            // 需要配置的manifest 节点
            var configManifestNode = GetManifestNode(configFilePath);
            // 先移除已有配置在进行插入
            RemoveManifestNode(configFilePath);

            // 目标文档中
            var targetXmlDocument = GetXmlDocument(TargetManifestFilePath);
            var targetManifestNode = GetManifestNode(targetXmlDocument);
            InsertXmlToTargetNode(configManifestNode, targetManifestNode, targetXmlDocument);
        }

        /// <summary>
        /// 插入xml到application子节点
        /// </summary>
        /// <param name="configFilePath"></param>
        public void InsertOrUpdateXml_ToApplicationChildNode(string configFilePath)
        {
            if (!File.Exists(configFilePath))
            {
                Debug.Log("configFilePath is null..");
                return;
            }

            // 需要配置的application 节点
            var configApplicationNode = GetApplicationNode(configFilePath);
            // 先移除已有配置在进行插入
            RemoveApplicationNode(configFilePath);

            var targetXmlDocument = GetXmlDocument(TargetManifestFilePath);
            var targetApplicationNode = GetApplicationNode(targetXmlDocument);
            InsertXmlToTargetNode(configApplicationNode, targetApplicationNode, targetXmlDocument);
        }

        /// <summary>
        /// 插入xml文件内容到目标节点.
        /// </summary>
        /// <param name="configNode">需要插入的配置文件节点.</param>
        /// <param name="targetNode">目标节点</param>
        /// <param name="targetXmlDocument">目标文档</param>
        private static void InsertXmlToTargetNode(
            XmlNode configNode,
            XmlNode targetNode,
            XmlDocument targetXmlDocument)
        {
            if (targetNode != null)
            {
                if (configNode != null)
                {
                    var xmlNodeList = configNode.ChildNodes;
                    // 添加新配置
                    for (var i = 0; i < xmlNodeList.Count; i++)
                    {
                        var xmlNode = xmlNodeList[i];
                        var importNode = targetXmlDocument.ImportNode(xmlNode, true);
                        targetNode.AppendChild(importNode);
                    }
                }
            }

            XmlWriteToFile(targetXmlDocument, TargetManifestFilePath);
        }

        /// <summary>
        /// 移除Application中的节点.
        /// </summary>
        /// <param name="configFilePath">配置文件路径.</param>
        public void RemoveApplicationNode(string configFilePath)
        {
            if (!File.Exists(TargetManifestFilePath))
            {
                // 文件不存在，就不做移除操作.
                return;
            }

            // 目标文件内容
            var targetXmlDocument = GetXmlDocument(TargetManifestFilePath);
            var targetApplicationNode = GetApplicationNode(targetXmlDocument);

            // 配置文件内容
            var configNode = GetApplicationNode(configFilePath);

            RemoveTargetNode(configNode, targetApplicationNode, targetXmlDocument);
        }

        /// <summary>
        /// 移除Manifest节点.
        /// </summary>
        /// <param name="configFilePath">配置文件路径.</param>
        public void RemoveManifestNode(string configFilePath)
        {
            if (!File.Exists(TargetManifestFilePath))
            {
                // 文件不存在，就不做移除操作.
                return;
            }

            // 目标文件内容
            var targetXmlDocument = GetXmlDocument(TargetManifestFilePath);
            var targetManifestNode = GetManifestNode(targetXmlDocument);

            // 配置文件内容
            var configNode = GetManifestNode(configFilePath);

            RemoveTargetNode(configNode, targetManifestNode, targetXmlDocument);
        }

        /// <summary>
        /// 移除目标节点.
        /// </summary>
        /// <param name="configNode">配置文件节点.</param>
        /// <param name="targetNode">目标节点.</param>
        /// <param name="targetXmlDocument">根节点.</param>
        private static void RemoveTargetNode(
            XmlNode configNode,
            XmlNode targetNode,
            XmlNode targetXmlDocument)
        {
            var xmlNodeList = configNode.ChildNodes;
            if (xmlNodeList.Count < 2)
            {
                Debug.Log("Please write comments at the beginning and end...");
                return;
            }

            var startTag = xmlNodeList[0].Value;
            var endTag = xmlNodeList[xmlNodeList.Count - 1].Value;

            var hasUpdate = false;
            if (targetNode != null)
            {
                // 是否开始移除子xml
                var startRemoveChild = false;
                // 是否结束移除子xml
                var endRemoveChild = false;

                var childNodes = targetNode.ChildNodes;

                var needRemoveXmlNode = new List<XmlNode>();

                for (var i = 0; i < childNodes.Count; i++)
                {
                    var childNode = childNodes[i];
                    if (childNode.GetType() == typeof(XmlComment))
                    {
                        var currentAdComment = (XmlComment)childNode;
                        if (currentAdComment.Value.Contains(startTag))
                        {
                            // 注释的开始
                            startRemoveChild = true;
                        }
                        else if (currentAdComment.Value.Contains(endTag))
                        {
                            // 注释的结尾
                            endRemoveChild = true;
                        }
                    }

                    if (startRemoveChild)
                    {
                        if (endRemoveChild)
                        {
                            needRemoveXmlNode.Add(childNode);
                            break;
                        }

                        needRemoveXmlNode.Add(childNode);
                    }
                }

                // 处理需要移除的child node
                foreach (var xmlNode in needRemoveXmlNode)
                {
                    hasUpdate = true;
                    targetNode.RemoveChild(xmlNode);
                }
            }

            if (hasUpdate)
            {
                XmlWriteToFile(targetXmlDocument, TargetManifestFilePath);
            }
        }

        /// <summary>
        /// 获取Manifest所在节点.
        /// </summary>
        /// <param name="filePath">manifest文件路径.</param>
        /// <returns>Manifest所在节点</returns>
        private static XmlNode GetManifestNode(string filePath)
        {
            var xmlDocument = GetXmlDocument(filePath);
            return GetManifestNode(xmlDocument);
        }

        /// <summary>
        /// 获取manifest节点
        /// </summary>
        /// <param name="xmlDocument"></param>
        /// <returns>目标xmlNode</returns>
        private static XmlNode GetManifestNode(XmlNode xmlDocument)
        {
            if (xmlDocument != null)
            {
                var manifestNode = xmlDocument.SelectSingleNode(XmlNodeManifest);
                return manifestNode;
            }

            return null;
        }

        /// <summary>
        /// 获取application节点
        /// </summary>
        /// <param name="filePath">文件路径.</param>
        /// <returns></returns>
        private static XmlNode GetApplicationNode(string filePath)
        {
            var xmlDocument = GetXmlDocument(filePath);
            return GetApplicationNode(xmlDocument);
        }

        /// <summary>
        /// 获取Application节点.
        /// </summary>
        /// <param name="xmlNode">xmlNode</param>
        /// <returns>xmlNode</returns>
        private static XmlNode GetApplicationNode(XmlNode xmlNode)
        {
            var manifestNode = GetManifestNode(xmlNode);
            if (manifestNode != null)
            {
                var selectSingleNode = manifestNode.SelectSingleNode(XmlNodeApplication);
                return selectSingleNode;
            }

            return null;
        }

        /// <summary>
        /// 获取XmlDocument.
        /// </summary>
        /// <param name="filePath">文件路径.</param>
        /// <returns></returns>
        private static XmlDocument GetXmlDocument(string filePath)
        {
            var xmlDocument = new XmlDocument();
            var xmlReaderSettings = new XmlReaderSettings();
            using (var xmlReader = XmlReader.Create(filePath, xmlReaderSettings))
            {
                xmlDocument.Load(xmlReader);
                xmlReader.Close();
            }

            return xmlDocument;
        }

        /// <summary>
        /// xml写入到目标文件目录
        /// </summary>
        /// <param name="xmlDocument">XmlNode.</param>
        /// <param name="filePath">文件路径.</param>
        private static void XmlWriteToFile(XmlNode xmlDocument, string filePath)
        {
            // 内存中保存的流
            var memoryStream = new MemoryStream();

            // 文本写入对象 
            var xmlWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            xmlWriter.Indentation = 4;
            xmlWriter.Formatting = Formatting.Indented;

            // 文档内容写入到写入对象中
            xmlDocument.WriteContentTo(xmlWriter);
            xmlWriter.Close();

            File.WriteAllBytes(filePath, memoryStream.ToArray());
            memoryStream.Dispose();
            AssetDatabase.Refresh();
        }

        /// <summary>
        /// 修改xml节点中的属性值.
        /// </summary>
        /// <param name="label">标签名称.</param>
        /// <param name="attrName">属性名称.</param>
        /// <param name="attrValue">属性值.</param>
        /// <param name="updateCallback">修改后的回调.</param>
        public void UpdateXmlSingleNodeAttr(
            string label,
            string attrName,
            string attrValue,
            Action<UpdateXmlAttributeState, XmlElement> updateCallback)
        {
            if (!File.Exists(TargetManifestFilePath))
            {
                SDKInternalLog.E($"TargetManifestFile not exists : {TargetManifestFilePath}");
                return;
            }

            var xmlDocument = GetXmlDocument(TargetManifestFilePath);

            XmlNode selectSingleNode;
            if (xmlDocument.FirstChild.Name != label)
            {
                // 根结点不是manifest，则需要单独处理.
                selectSingleNode = xmlDocument.SelectSingleNode(XmlNodeManifest);
                if (selectSingleNode != null)
                {
                    var xmlNodeList = selectSingleNode.ChildNodes;
                    for (var i = xmlNodeList.Count - 1; i >= 0; i--)
                    {
                        var xmlNode = xmlNodeList[i];
                        if (xmlNode.Name == label)
                        {
                            selectSingleNode = selectSingleNode.SelectSingleNode(label);
                            break;
                        }
                    }
                }
            }
            else
            {
                selectSingleNode = xmlDocument.SelectSingleNode(label);
            }

            UpdateSelectSingleNodeAttr(attrName, attrValue, updateCallback, selectSingleNode, xmlDocument,
                TargetManifestFilePath);
        }

        public void UpdateLauncherActivityAttr(
            string attrName,
            string attrValue,
            string targetFilePath,
            Action<UpdateXmlAttributeState, XmlElement> updateCallback)
        {
            var xmlDocument = GetXmlDocument(TargetManifestFilePath);
            // 根结点不是manifest，则需要单独处理.
            var selectSingleNode = xmlDocument.SelectSingleNode(XmlNodeManifest);

            if (selectSingleNode != null)
            {
                // application节点
                selectSingleNode = selectSingleNode.SelectSingleNode(XmlNodeApplication);
                if (selectSingleNode != null)
                {
                    var applicationChildNodes = selectSingleNode.ChildNodes;
                    for (var i = 0; i < applicationChildNodes.Count; i++)
                    {
                        var applicationChildNode = applicationChildNodes[i];
                        if (applicationChildNode != null)
                        {
                            var intentFilterNode = applicationChildNode.SelectSingleNode(XmlNodeIntentFilter);
                            if (intentFilterNode != null)
                            {
                                var actionNode = intentFilterNode.SelectSingleNode(XmlNodeAction);
                                var categoryNode = intentFilterNode.SelectSingleNode(XmlNodeCategory);
                                if (actionNode != null && categoryNode != null)
                                {
                                    var hasTargetAction = false;
                                    var actionNodeAttributes = actionNode.Attributes;
                                    if (actionNodeAttributes != null)
                                    {
                                        var count = actionNodeAttributes.Count;
                                        for (var j = 0; j < count; j++)
                                        {
                                            var actionNodeAttribute = actionNodeAttributes[j];
                                            if (actionNodeAttribute.Value == XmlActionNodeAttrValue)
                                            {
                                                hasTargetAction = true;
                                                break;
                                            }
                                        }
                                    }

                                    var categoryNodeAttributes = categoryNode.Attributes;
                                    if (categoryNodeAttributes != null && hasTargetAction)
                                    {
                                        var count = categoryNodeAttributes.Count;
                                        for (var k = 0; k < count; k++)
                                        {
                                            var categoryNodeAttribute = categoryNodeAttributes[k];
                                            if (categoryNodeAttribute.Value == XmlCategoryNodeAttrValue)
                                            {
                                                selectSingleNode = applicationChildNode;
                                                goto endLoop;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    endLoop: ;
                    UpdateSelectSingleNodeAttr(attrName, attrValue, updateCallback, selectSingleNode, xmlDocument,
                        targetFilePath);
                }
            }
        }

        // 修改选中的单节点属性
        private static void UpdateSelectSingleNodeAttr(string attrName, string attrValue,
            Action<UpdateXmlAttributeState, XmlElement> updateCallback, XmlNode selectSingleNode,
            XmlNode xmlDocument, string targetFilePath)
        {
            var hasUpdate = false;
            if (selectSingleNode != null && typeof(XmlElement) == selectSingleNode.GetType())
            {
                var xmlElement = (XmlElement)selectSingleNode;
                var nameAttrValue = xmlElement.GetAttribute(attrName);
                if (string.IsNullOrEmpty(nameAttrValue))
                {
                    hasUpdate = true;
                    // 插入标签
                    updateCallback.Invoke(UpdateXmlAttributeState.Insert, xmlElement);
                }
                else
                {
                    if (nameAttrValue == attrValue)
                    {
                        // 有此属性，值也相同
                        hasUpdate = true;
                        updateCallback.Invoke(UpdateXmlAttributeState.HaveSameValue, xmlElement);
                    }
                    else
                    {
                        hasUpdate = true;
                        // 有此属性，但是值不同
                        updateCallback.Invoke(UpdateXmlAttributeState.DifferentValue, xmlElement);
                    }
                }
            }
            else
            {
                Debug.LogError("selectSingleNode is null...");
                updateCallback.Invoke(UpdateXmlAttributeState.Fail, null);
            }

            if (hasUpdate)
            {
                XmlWriteToFile(xmlDocument, targetFilePath);
            }

            AssetDatabase.Refresh();
        }

        public void InsertHandleUrlActivity()
        {
            if (!File.Exists(TargetManifestFilePath))
            {
                SDKInternalLog.E($"TargetManifestFile not exists : {TargetManifestFilePath}");
                return;
            }

            var xmlDoc = GetXmlDocument(TargetManifestFilePath);
            // 获取根节点
            XmlElement root = xmlDoc.DocumentElement;

            // 查找 application 节点
            XmlNode applicationNode = root.SelectSingleNode(XmlNodeApplication);
            if (applicationNode == null)
            {
                SDKInternalLog.E($"Application node not found in {TargetManifestFilePath}");
                return;
            }

            // 检查是否已经存在指定名称的 activity
            string targetActivityName = "com.unity3d.player.HandleUrlActivity";
            bool activityExists = false;
            string currentScheme = $"dygame{OSDKIntegrationConfig.AppID(OSDKPlatform.Android)}";
            foreach (XmlNode activityNode in applicationNode.SelectNodes("activity"))
            {
                XmlAttribute nameAttribute = activityNode.Attributes["name", NameSpaceUriAndroid];
                if (nameAttribute != null && nameAttribute.Value == targetActivityName)
                {
                    activityExists = true;
                    // 遍历所有intent-filter
                    foreach (XmlNode intentFilterNode in activityNode.SelectNodes("intent-filter"))
                    {
                        // 查找data节点
                        XmlNode dataNode = intentFilterNode.SelectSingleNode("data");
                        if (dataNode == null) continue;
            
                        // 检查scheme属性
                        XmlAttribute schemeAttr = dataNode.Attributes["scheme", NameSpaceUriAndroid];
                        if (schemeAttr != null && schemeAttr.Value != currentScheme)
                        {
                            // 更新scheme值
                            schemeAttr.Value = currentScheme;
                            Debug.Log($"Updated scheme to {currentScheme}");
                            xmlDoc.Save(TargetManifestFilePath);
                        }
                    }
                    break;
                }
            }

            if (!activityExists)
            {
                // 创建新的 activity 节点
                XmlElement newActivity = xmlDoc.CreateElement("activity");
                
                newActivity.SetAttribute("name", NameSpaceUriAndroid, targetActivityName);
                newActivity.SetAttribute("exported", NameSpaceUriAndroid, "true");
                newActivity.SetAttribute("launchMode", NameSpaceUriAndroid, "singleTask");
                newActivity.SetAttribute("taskAffinity", NameSpaceUriAndroid, "${applicationId}");
                newActivity.SetAttribute("theme", NameSpaceUriAndroid, "@android:style/Theme.Black.NoTitleBar.Fullscreen");
                newActivity.SetAttribute("label", NameSpaceUriAndroid, "@string/app_name");
                newActivity.SetAttribute("configChanges", NameSpaceUriAndroid, "fontScale|keyboard|keyboardHidden|locale|mnc|mcc|navigation|orientation|screenLayout|screenSize|smallestScreenSize|uiMode|touchscreen");

                // 创建 intent-filter 节点
                XmlElement intentFilter = xmlDoc.CreateElement("intent-filter");

                // 创建 action 节点
                XmlElement actionView = xmlDoc.CreateElement("action");
                actionView.SetAttribute("name", NameSpaceUriAndroid, "android.intent.action.VIEW");
                intentFilter.AppendChild(actionView);

                // 创建第一个 category 节点
                XmlElement categoryDefault = xmlDoc.CreateElement("category");
                categoryDefault.SetAttribute("name", NameSpaceUriAndroid, "android.intent.category.DEFAULT");
                intentFilter.AppendChild(categoryDefault);

                // 创建第二个 category 节点
                XmlElement categoryBrowsable = xmlDoc.CreateElement("category");
                categoryBrowsable.SetAttribute("name", NameSpaceUriAndroid, "android.intent.category.BROWSABLE");
                intentFilter.AppendChild(categoryBrowsable);

                // 创建 data 节点
                XmlElement dataNode = xmlDoc.CreateElement("data");
                string appId = OSDKIntegrationConfig.AppID(OSDKPlatform.Android);
                dataNode.SetAttribute("scheme", NameSpaceUriAndroid, currentScheme);
                dataNode.SetAttribute("host", NameSpaceUriAndroid, "${applicationId}");
                dataNode.SetAttribute("path", NameSpaceUriAndroid, "/jump_to_game");
                intentFilter.AppendChild(dataNode);

                // 将 intent-filter 节点添加到 activity 节点中
                newActivity.AppendChild(intentFilter);

                // 将新的 activity 节点添加到 application 节点中
                applicationNode.AppendChild(newActivity);

                // 保存修改后的 XML 文档
                xmlDoc.Save(TargetManifestFilePath);
                Debug.Log("AndroidManifest.xml modified successfully.");
            }
            else
            {
                Debug.Log($"Activity {targetActivityName} already exists in AndroidManifest.xml.");
            }
        }
    }
}