using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// 流水分账模块，附加
    /// </summary>
    public class OSDKIntegrationUnionModule
    {
        // ReSharper disable Unity.PerformanceAnalysis
        private static void UnionLoginLayout()
        {
            if (!OSDKIntegrationPathUtils.UnionModuleImported) return;
            // 1.登录
            GUILayout.Space(20);
            OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitleUnionAccount, null, OSDKMargin.Tab1);
            GUILayout.Space(8);
            // 1.1 标准化代码
            const string tips = OSDKIntegrationString.KTipsStandardCodeGuide;
            var buttonTitle = string.Empty;
            switch (OSDKIntegrationEditor.Instance.pAndroidSdkType)
            {
                // 模式1
                case "Android_Merge":
                    buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.DouYinAccount)
                        ? OSDKIntegrationString.KTitleOpenButton
                        : OSDKIntegrationString.KTitleCreateButton;
                    break;
                // 模式2
                case "Android_GameId":
                    buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.GameAccount)
                        ? OSDKIntegrationString.KTitleOpenButton
                        : OSDKIntegrationString.KTitleCreateButton;
                    break;
            }
            var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                buttonTitle, tips, OSDKMargin.Tab2, OSDKIntegrationEditor.CanCreateSample, disableWarningText: OSDKIntegrationString.KWarningSecretKey);
            if (clicked)
            {
                switch (OSDKIntegrationEditor.Instance.pAndroidSdkType)
                {
                    // 模式1
                    case "Android_Merge":
                        OSDKIntegrationSampleHandler.AccountSampleClickAction();
                        break;
                    // 模式2
                    case "Android_GameId":
                        OSDKIntegrationSampleHandler.AccountGameSampleClickAction();
                        break;
                }
                GUIUtility.ExitGUI();
            }
            
            // 1.2 账号登录模拟验证
            GUILayout.Space(8);
            OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitleAccountLoginPCMock, null, OSDKMargin.Tab2);
            GUILayout.Space(8);
            var pcEnvAccountLoginState =
                OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvAccountLoginState,
                    new string[] { "登录成功", "登录失败" }, OSDKMargin.Tab1);
            if (pcEnvAccountLoginState != OSDKIntegrationEditor.Instance.pcEnvAccountLoginState)
            {
                OSDKIntegrationRecord.MockSwitch("mock_account_login");
                OSDKIntegrationEditor.Instance.pcEnvAccountLoginState = pcEnvAccountLoginState;
            }
            // 1.3 账号切换模拟验证
            GUILayout.Space(8);
            OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitleAccountSwitchPCMock, null, OSDKMargin.Tab2);
            GUILayout.Space(8);
            var pcEnvAccountSwitchState =
                OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvAccountSwitchState,
                    new string[] { "切换成功", "切换失败" }, OSDKMargin.Tab1);
            if (pcEnvAccountSwitchState != OSDKIntegrationEditor.Instance.pcEnvAccountSwitchState)
            {
                OSDKIntegrationRecord.MockSwitch("mock_account_switch");
                OSDKIntegrationEditor.Instance.pcEnvAccountSwitchState = pcEnvAccountSwitchState;
            }
            // 1.4 账号退出模拟验证
            GUILayout.Space(8);
            OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitleAccountLogoutPCMock, null, OSDKMargin.Tab2);
            GUILayout.Space(8);
            var pcEnvAccountLogoutState =
                OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvAccountLogoutState,
                    new string[] { "退出成功", "退出失败" }, OSDKMargin.Tab1);
            if (pcEnvAccountLogoutState != OSDKIntegrationEditor.Instance.pcEnvAccountLogoutState)
            {
                OSDKIntegrationRecord.MockSwitch("mock_account_logout");
                OSDKIntegrationEditor.Instance.pcEnvAccountLogoutState = pcEnvAccountLogoutState;
            }
            GUILayout.Space(8);
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private static void UnionPayLayout()
        {
            if (!OSDKIntegrationPathUtils.UnionModuleImported) return;
            // 2.支付
            GUILayout.Space(20);
            OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitleUnionPay, null, OSDKMargin.Tab1);
            GUILayout.Space(8);
            // 2.1 标准化代码
            const string tips = OSDKIntegrationString.KTipsStandardCodeGuide;
            var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.DouYinPay)
                ? OSDKIntegrationString.KTitleOpenButton
                : OSDKIntegrationString.KTitleCreateButton;
            var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                buttonTitle, tips, OSDKMargin.Tab2, OSDKIntegrationEditor.CanCreateSample, disableWarningText: OSDKIntegrationString.KWarningSecretKey);
            if (clicked)
            {
                OSDKIntegrationSampleHandler.PaySampleClickAction();
                GUIUtility.ExitGUI();
            }
            // 2.2 支付结果模拟验证
            GUILayout.Space(8);
            OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePayPCMock, null, OSDKMargin.Tab2);
            GUILayout.Space(8);
            var pcEnvPayResultState =
                OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvPayResultState,
                    new string[] { "支付成功", "支付失败" }, OSDKMargin.Tab1);
            if (pcEnvPayResultState != OSDKIntegrationEditor.Instance.pcEnvPayResultState)
            {
                OSDKIntegrationRecord.MockSwitch("mock_pay");
                OSDKIntegrationEditor.Instance.pcEnvPayResultState = pcEnvPayResultState;
            }
        }

        private static void UnionCpsLayout()
        {
            if (!OSDKIntegrationPathUtils.CpsModuleImported) return;
            // CPS
            var cpsTitle = "3.登录支付信息上报（iOS）";
            if (!OSDKIntegrationPathUtils.UnionModuleImported || OSDKIntegrationEditor.Instance.pAndroidSdkType == "Android_Official")
            {
                cpsTitle = "1.登录支付信息上报";
            }
            GUILayout.Space(20);
            OSDKIntegrationLayout.LabelTipsLayout(cpsTitle, null, OSDKMargin.Tab1);
            GUILayout.Space(8);
            // 1.1 标准化代码
            var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.Cps)
                ? OSDKIntegrationString.KTitleOpenButton
                : OSDKIntegrationString.KTitleCreateButton;
            var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                buttonTitle, OSDKIntegrationString.KTipsStandardCodeGuide, OSDKMargin.Tab2, OSDKIntegrationEditor.CanCreateSample, 
                disableWarningText: OSDKIntegrationString.KWarningSecretKey);
            if (clicked)
            {
                OSDKIntegrationSampleHandler.CpsSampleClickAction();
                GUIUtility.ExitGUI();
            }
            
        }

        public static void UnionLayout()
        {
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            OSDKIntegrationEditor.Instance.showUnion = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showUnion,
                OSDKIntegrationString.KTitleUnion, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showUnion)
            {
                if (OSDKIntegrationEditor.Instance.pAndroidSdkType != "Android_Official")
                {
                    UnionLoginLayout();
                    UnionPayLayout();
                }
                UnionCpsLayout();
            }
            EditorGUI.indentLevel--;
        }
    }
}