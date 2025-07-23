using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Douyin.Game
{
    [InitializeOnLoad]
    [CustomEditor(typeof(OSDKIntegrationSettings))]
    public class OSDKIntegrationEditor : Editor
    {
        private static OSDKIntegrationSettings _settings;
        private const string IntegrationResDir = "Assets/ThirdParty/OSDKData/Resources/";
        private const string IntegrationParamsFile = IntegrationResDir + "OSDKIntegrationSettings.asset";
        private const bool IsCreateDemoSample = false;
        
        private const string DemoAppIdAndroidMode1 = "583192";
        private const string DemoAppIdAndroidMode2 = "583291";
        private const string DemoAppIdAndroidMode3 = "583501";
        private const string DemoAppIdDataLink = "640348";
        private const string DemoAppIdIOS = DemoAppIdAndroidMode3;
        public static bool CanCreateSample => IsCreateDemoSample || 
                                              (!string.IsNullOrEmpty(OSDKIntegrationConfig.AppID(Instance.IsAndroidTab ? OSDKPlatform.Android : OSDKPlatform.iOS)) &&
                                              !IsDemoAppId(OSDKIntegrationConfig.AppID(Instance.IsAndroidTab ? OSDKPlatform.Android : OSDKPlatform.iOS)));

        public static OSDKIntegrationSettings Instance
        {
            get
            {
                if (_settings) return _settings;
                if (!System.IO.Directory.Exists(IntegrationResDir))
                {
                    System.IO.Directory.CreateDirectory(IntegrationResDir);
                }
                _settings = (OSDKIntegrationSettings)AssetDatabase.LoadAssetAtPath(IntegrationParamsFile, typeof(OSDKIntegrationSettings));
                if (_settings) return _settings;
                _settings = CreateInstance<OSDKIntegrationSettings>();
                AssetDatabase.CreateAsset(_settings, IntegrationParamsFile);
                return _settings;
            }
        }

        static OSDKIntegrationEditor()
        {
            // .unitypackage 导入成功
            AssetDatabase.importPackageCompleted += packageName =>
            {
                if (!packageName.Contains("OSDK")) return;
                if ((packageName.Contains("OSDKUnion") || packageName.Contains("OSDKCps")) && OSDKIntegrationPathUtils.DataLinkModuleImported )
                {
                    if (OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.DouyinChannel)
                    {
                        EditorUtility.DisplayDialog("组件导入错误","已存在OSDKDataLink，当前业务模式为流水分账，请删除OSDKDataLink", "ok");
                    }
                    if (OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.OmniChannel)
                    {
                        EditorUtility.DisplayDialog("组件导入错误","已存在OSDKDataLink，当前业务模式全渠促活，无需导入当前组件", "ok");
                    }
                }
                if (packageName.Contains("OSDKDataLink") && (OSDKIntegrationPathUtils.UnionModuleImported || OSDKIntegrationPathUtils.CpsModuleImported) )
                {
                    if (OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.DouyinChannel)
                    {
                        EditorUtility.DisplayDialog("组件导入错误","已存在OSDKUnion/OSDKCps，当前业务模式为流水分账，无需导入当前组件", "ok");
                    }
                    if (OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.OmniChannel)
                    {
                        EditorUtility.DisplayDialog("组件导入错误","已存在OSDKUnion/OSDKCps，当前业务模式为全渠促活，请删除OSDKUnion/OSDKCps", "ok");
                    }
                }
                OSDKIntegrationRecord.SdkImport();
                SelectSettings();
            };
        }
        
        [MenuItem("OSDK/Integration",priority = 1)]
        private static void SelectSettings()
        {
            Selection.activeObject = Instance;
            OSDKIntegrationRecord.BoardShow();
        }

        private void OnEnable()
        {
            if (target != null)
            {
                _settings = (OSDKIntegrationSettings)target;
            }
            
            //FetchVersionUpdate();
        }
        
        // 面板消失回调
        private void OnDisable()
        {
            OSDKIntegrationSampleHandler.SyncAllAdInfosToTargetFileIfNeed();
        }

        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            // 竖版布局
            EditorGUILayout.BeginVertical();
            
            // ------ 标题 ------
            EditorGUILayout.LabelField(new GUIContent("OSDK自助接入"), OSDKIntegrationStyles.getTitleStyle());
            GUILayout.Space(20);
            
            // ------ Section B:环境配置 ------
            EnvironmentSection();

            // ------ Section C:自助化接入 ------
            IntegrationSection();
            
            // ------ Section D：构建 ------
            ArchiveSection();
            
            // ------ Section E：展示demo场景 ------
            SampleSection();

            // ------ Section F：版本更新 ------
            VersionSection();
            
            // ------ Section A:帮助中心 ------
            // HelpCenterSection(); 
            // 本期先隐藏错误码查询入口, 待unity错误码整理完成后再露出
            
            EditorGUILayout.EndVertical();
            if (EditorGUI.EndChangeCheck())
            {
                EditorUtility.SetDirty(Instance);
            }
        }

        private static void SampleSection()
        {
            var samplePath = Path.Combine(OSDKProjectPathUtils.CoreModuleDir, "Sample/OSDKDemo.unity");
            if (!File.Exists(samplePath))
            {
                return;
            }
            Instance.showSectionSampleCenter = EditorGUILayout.Foldout(Instance.showSectionSampleCenter,
                OSDKIntegrationString.KTitleSample, OSDKIntegrationStyles.getSectionStyle());
            if (Instance.showSectionSampleCenter)
            {
                GUILayout.Space(12);
                EditorGUILayout.HelpBox("打开并运行Demo场景，查看Demo效果展示。", MessageType.Info);
                GUILayout.Space(12);
                var click = OSDKIntegrationLayout.Button("打开Demo场景", OSDKMargin.TextTab);
                if (click)
                {
                    var open = EditorUtility.DisplayDialog(
                        "打开OSDK Demo场景",
                        "请确保当前游戏场景已保存",
                        "打开", "关闭");
                    if (open)
                    {
                        EditorSceneManager.OpenScene(samplePath);
                    }
                    GUIUtility.ExitGUI();
                }
            }
            GUILayout.Space(12);
        }

        // Section A - 帮助中心 
        // ReSharper disable Unity.PerformanceAnalysis
        private static void HelpCenterSection()
        {
            Instance.showSectionHelpCenter = EditorGUILayout.Foldout(Instance.showSectionHelpCenter,
                OSDKIntegrationString.KTitleHelpCenter, OSDKIntegrationStyles.getSectionStyle());
            if (Instance.showSectionHelpCenter)
            {
                GUILayout.Space(12);
                var clicked =
                    OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleHelpCenterText, "查询", null,
                        OSDKMargin.TextTab);
                if (clicked)
                {
                    OSDKIntegrationRouter.OpenHelpCenterWeb();
                    OSDKIntegrationRecord.ErrorCodeClick();
                    GUIUtility.ExitGUI();
                }
            }
            GUILayout.Space(12);
        }
        
        // Section B -环境配置 
        private static void EnvironmentSection()
        {
            OSDKIntegrationEnvironmentUI.EnvironmentSection();
        }
        
        // Section C - 自助化接入
        private static void IntegrationSection()
        {
            OSDKIntegrationAutomationUI.IntegrationSection();
        }
        
        // Section D - 构建
        private static void ArchiveSection()
        {
            OSDKIntegrationArchiveUI.ArchiveSection();
        }
        
        // Section F - 版本
        private static void VersionSection()
        {
            OSDKIntegrationVersionUI.VersionSection();
        }

        private static void FetchVersionUpdate()
        {
            OSDKIntegrationVersionHandler.UpdateSDKVersion(false);
        }

        private static bool IsDemoAppId(string appId)
        {
            return appId == DemoAppIdAndroidMode1 ||
                   appId == DemoAppIdAndroidMode2 ||
                   appId == DemoAppIdAndroidMode3 ||
                   appId == DemoAppIdIOS ||
                   appId == DemoAppIdDataLink;
        }
        
    }
}