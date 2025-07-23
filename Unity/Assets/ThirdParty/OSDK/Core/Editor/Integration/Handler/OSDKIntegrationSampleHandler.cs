using System;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;

namespace Douyin.Game
{
    public static class OSDKIntegrationSampleHandler
    {
        private static bool _adidEdited; 
        // 根据类型和别名，获取广告信息模型
        private static OSDKAdInfo GetAdInfo(OSDKSampleType type, string alias)
        {
            var adids = OSDKIntegrationEditor.Instance.GetAdids(type);
            if (adids == null) return null;
            foreach (var adinfo in adids)
            {
                if (adinfo.name != alias) continue;
                return adinfo;
            }
            return null;
        }
        
        // 获取替换广告位id后的字符串
        private static string GetReplaceAdidCodeString(string ss, string adid, string holder)
        {
            // 不包含标志位，不做替换
            if (!ss.Contains(holder)) return ss;
            var chars = new char[] {'='};
            var strings = ss.Split(chars);
            var preHolder = (strings.Length > 0 && strings[0].Contains(holder)) ? strings[0] : holder;
            preHolder = preHolder.Replace(";", "");
            preHolder = preHolder.TrimEnd();
            if (strings.Length == 2)
            {
                var curAdid = strings[1];
                curAdid = curAdid.Replace(";", "");
                curAdid = curAdid.Replace("\"", "");
                curAdid = curAdid.Trim();
                if (curAdid != adid)
                {
                    _adidEdited = true;
                }
            }
            else
            {
                _adidEdited = true;
            }

            return string.IsNullOrWhiteSpace(adid) ? 
                $"{preHolder};" : 
                $"{preHolder} = \"{adid}\";";
        }
        
        // 自动检测同步所有广告模型数据到目标文件
        internal static void SyncAllAdInfosToTargetFileIfNeed()
        {
            _adidEdited = false;
            // 遍历所有广告类型
            foreach (OSDKSampleType type in Enum.GetValues(typeof(OSDKSampleType)))
            {
                var adids = OSDKIntegrationEditor.Instance.GetAdids(type);
                if (adids == null) 
                    continue;
                foreach (var adInfo in adids)
                {
                    // 未创建文件不做处理
                    if (!adInfo.created) continue;
                    // 更新操作
                    SyncAdInfoToTargetFile(adInfo, type);
                }
            }
            if (_adidEdited)
            {
                // 刷新数据
                EditorUtility.SetDirty(OSDKIntegrationEditor.Instance);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }
        
        // 同步广告模型信息到目标文件
        private static void SyncAdInfoToTargetFile(OSDKAdInfo adinfo, OSDKSampleType type)
        {
            if (adinfo == null) return;
            // 文件不存在，不做处理
            if (!OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(type, adinfo.name)) return;
            var targetFilePath = OSDKIntegrationPathUtils.StandardSampleTargetFilePath(type, adinfo.name);
            var result = new StringBuilder();
            // 读取文件内容
            foreach (var line in File.ReadAllLines(targetFilePath))
            {
                var ss = line;
                // 修改安卓广告位ID
                ss = GetReplaceAdidCodeString(ss, adinfo.androidAdid, OSDKIntegrationPathUtils.StandardAndroidAdidHolder);
                ss = GetReplaceAdidCodeString(ss, adinfo.androidBizid, OSDKIntegrationPathUtils.StandardAndroidBizidHolder);
                // 修改iOS广告位ID(预留)
                // ss = GetReplaceAdidCodeString(ss, adinfo.iosAdid, OSDKIntegrationPathUtils.StandardIOSAdidHolder);
                
                result.AppendLine(ss);
            }
            // 写文件
            var fs = new FileStream(targetFilePath, FileMode.Create);
            var bytes = new UTF8Encoding().GetBytes(result.ToString());
            fs.Write(bytes, 0, bytes.Length);
            //每次读取文件后都要记得关闭文件
            fs.Close();
        }

        // 创建Target目标模板文件
        private static void CreateSampleTargetFile(OSDKSampleType type, string alias = null)
        {
            var originFilePath = OSDKIntegrationPathUtils.StandardSampleOriginFilePath(type);
            var targetFilePath = OSDKIntegrationPathUtils.StandardSampleTargetFilePath(type, alias);
            var originClassName = OSDKIntegrationPathUtils.StandardSampleOriginClassName(type);
            var targetClassName = OSDKIntegrationPathUtils.StandardSampleTargetClassName(type, alias);
            var curInfo = GetAdInfo(type, alias);
            // 复制文件
            File.Copy(originFilePath, targetFilePath);
            if (curInfo != null)
            {
                curInfo.created = true;
            }
            var result = new StringBuilder();
            // 读取文件内容
            foreach (var line in File.ReadAllLines(targetFilePath))
            {
                var ss = line;
                // 修改类名
                if (ss.Contains(originClassName))
                {
                    ss = ss.Replace(originClassName, targetClassName);
                }
                if (curInfo != null)
                {
                    // 修改安卓广告位ID
                    ss = GetReplaceAdidCodeString(ss, curInfo.androidAdid, OSDKIntegrationPathUtils.StandardAndroidAdidHolder);
                    ss = GetReplaceAdidCodeString(ss, curInfo.androidBizid, OSDKIntegrationPathUtils.StandardAndroidBizidHolder);
                    // 修改iOS广告位ID(预留)
                    // ss = GetReplaceAdidCodeString(ss, curInfo.iosAdid, OSDKIntegrationPathUtils.StandardIOSAdidHolder);
                }
                result.AppendLine(ss);
            }
            // 写文件
            var fs = new FileStream(targetFilePath, FileMode.Create);
            var bytes = new UTF8Encoding().GetBytes(result.ToString());
            fs.Write(bytes, 0, bytes.Length);
            //每次读取文件后都要记得关闭文件
            fs.Close();
            EditorUtility.SetDirty(OSDKIntegrationEditor.Instance);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
        
        // 打开文件
        private static void OpenSampleTargetFile(OSDKSampleType type, string alias = null)
        {
            var targetFilePath = OSDKIntegrationPathUtils.StandardSampleTargetFilePath(type, alias);
            var obj = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(targetFilePath);
            AssetDatabase.OpenAsset(obj, 10);
        }

        // 处理创建/打开按钮点击事件
        // ReSharper disable Unity.PerformanceAnalysis
        private static void HandleSampleClickAction(OSDKSampleType type, string alias = null)
        {
            // 创建目录
            CreateDirIfNotExist(OSDKIntegrationPathUtils.StandardSampleTargetDir(type));
            // Target文件不存在，创建Target文件
            if (!OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(type, alias))
            {
                try
                {
                    OSDKIntegrationRecord.SampleClick(GetTypeString(type), "create");
                    EditorUtility.DisplayProgressBar("创建模板代码", "正在创建模板代码，请稍等", (float) 0.5);
                    // 创建
                    CreateSampleTargetFile(type, alias);
                    EditorUtility.ClearProgressBar();
                    // 打开
                    OpenSampleTargetFile(type, alias);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    EditorUtility.ClearProgressBar();
                    EditorUtility.DisplayDialog("创建模板代码失败", e.Message, "确定");
                }
            }
            // Target文件存在，直接打开Target文件
            else
            {
                OSDKIntegrationRecord.SampleClick(GetTypeString(type), "open");
                // 打开Target文件
                OpenSampleTargetFile(type, alias);
            }
        }

        // 【初始化】模板代码点击事件
        internal static void InitSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.Init);
        }
        
        // 【账号绑定】模板代码点击事件
        internal static void GameRoleSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.GameRole);
        }
        
        // 【抖音授权】模板代码点击事件
        internal static void AuthorizeSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.Authorize);
        }
        
        // 【抖音账号登录】模板代码点击事件
        internal static void AccountSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.DouYinAccount);
        }
        
        // 【游戏账号登录】模板代码点击事件
        internal static void AccountGameSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.GameAccount);
        }
        
        // 【支付】模板代码点击事件
        internal static void PaySampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.DouYinPay);
        }
        
        // 【Cps】模板代码点击事件
        internal static void CpsSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.Cps);
        }
        
        // 【DataLink】模板代码点击事件
        internal static void DataLinkSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.DataLink);
        }

        // 【分享】模板代码点击事件
        internal static void ShareSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.Share);
        }
        
        // 【录制】模板代码点击事件
        internal static void RecordSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.Record);
        }

        // 【看播】模板代码点击事件
        internal static void LiveSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.Live);
        }
        
        // 【云游戏】模板代码点击事件
        internal static void CloudGameSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.CloudGame);
        }
        
        // 【一键上车】模板代码点击事件
        internal static void TeamPlaySampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.TeamPlay);
        }
        
        // 【广告配置】模板代码点击事件
        internal static void AdBasicSampleClickAction()
        {
            HandleSampleClickAction(OSDKSampleType.AdBasic);
        }

        // 【广告】模板代码创建/打开点击事件
        internal static void AdSampleCreateOpenClickAction(OSDKSampleType type, OSDKAdInfo adInfo)
        {
            if (string.IsNullOrWhiteSpace(adInfo.name))
            {
                EditorUtility.DisplayDialog("创建模板代码失败", "广告模板代码文件名称不可为空，请填写模板名称，建议英文", "知道了");
                return;
            }
            if (OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(type, adInfo.name) && !adInfo.created)
            {
                var open = EditorUtility.DisplayDialog("创建模板代码失败", "聚合广告模板代码名称重复，本地已存在同名模板代码，请修改广告位名称后重试。", "打开已存在模板",
                    "知道了");
                if (!open) return;
            }
            HandleSampleClickAction(type, adInfo.name);
        }
        
        
        private static string GetTypeString(OSDKSampleType type)
        {
            switch (type)
            {
                case OSDKSampleType.Init:
                    return "init";
                case OSDKSampleType.AdBasic:
                    return "ad_basic";
                case OSDKSampleType.AdReward:
                    return "ad_reward";
                case OSDKSampleType.AdBanner:
                    return "ad_banner";
                case OSDKSampleType.AdNewInteraction:
                    return "ad_interstitial";
                case OSDKSampleType.AdSplash:
                    return "ad_splash";
                case OSDKSampleType.DouYinAccount:
                    return "douyin_account";
                case OSDKSampleType.DouYinPay:
                    return "douyin_pay";
                case OSDKSampleType.GameRole:
                    return "game_role";
                case OSDKSampleType.Authorize:
                    return "authorize";
                case OSDKSampleType.Cps:
                    return "cps";
                case OSDKSampleType.GameAccount:
                    return "game_account";
                case OSDKSampleType.Share:
                    return "share";
                case OSDKSampleType.Record:
                    return "screen_record";
                case OSDKSampleType.Live:
                    return "live";
                case OSDKSampleType.CloudGame:
                    return "cld_game";
                case OSDKSampleType.TeamPlay:
                    return "team_play";
                case OSDKSampleType.DataLink:
                    return "datalink";
                default:
                    return "";
            }
        }
        
        internal static void RewriteOSDKFileContent()
        {
            var targetFilePath = Path.Combine(OSDKProjectPathUtils.CoreModuleDir, "Scripts/Unify/OSDK.cs");
            var result = new StringBuilder();
            foreach (var line in File.ReadAllLines(targetFilePath))
            {
                result.AppendLine(line);
                if (line == "}") break;
            }
            result.AppendLine("/*");
            result.AppendLine(" 组件服务泛型 T 包括：");
            result.AppendLine(" ICommonService：核心Core模块");
            if (OSDKIntegrationPathUtils.AdModuleImported)
            {
                result.AppendLine(" IAdService: 广告模块");
            }
            if (OSDKIntegrationPathUtils.DouyinModuleImported)
            {
                result.AppendLine(" IDouyinService: 抖音授权模块");
            }
            if (OSDKIntegrationPathUtils.CloudGameModuleImported)
            {
                result.AppendLine(" CloudGameService:云游戏模块");
            }
            if (OSDKIntegrationPathUtils.CpsModuleImported)
            {
                result.AppendLine(" CpsService: Cps归因模块");
            }
            if (OSDKIntegrationPathUtils.LiveModuleImported)
            {
                result.AppendLine(" ILiveSdkService: 看播模块");
            }
            if (OSDKIntegrationPathUtils.ScreenRecordModuleImported)
            {
                result.AppendLine(" IScreenRecordService: 录屏模块");
            }
            if (OSDKIntegrationPathUtils.ShareModuleImported)
            {
                result.AppendLine(" IShareService：分享模块");
            }
            if (OSDKIntegrationPathUtils.TeamPlayModuleImported)
            {
                result.AppendLine(" ITeamPlayService: 一键上车模块");
            }
            if (OSDKIntegrationPathUtils.UnionModuleImported)
            {
                result.AppendLine(" IUnionService：联运模块");
            }
            result.AppendLine("*/");
            // 写文件
            var fs = new FileStream(targetFilePath, FileMode.Create);
            var bytes = new UTF8Encoding().GetBytes(result.ToString());
            fs.Write(bytes, 0, bytes.Length);
            //每次读取文件后都要记得关闭文件
            fs.Close();
        }

        #region 辅助代码

        private static void CreateDirIfNotExist(string dirPath)
        {
            if (Directory.Exists(dirPath) == false)
            {
                Directory.CreateDirectory(dirPath);
            }
        }
        #endregion
    }
}