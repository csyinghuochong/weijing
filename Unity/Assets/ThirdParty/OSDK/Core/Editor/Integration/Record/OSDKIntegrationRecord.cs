using System.Collections.Generic;

namespace Douyin.Game
{
    public static class OSDKIntegrationRecord
    {
        private const string IntegrationEventTypeValue = "osdk_unity_editor_integration";
        
        internal static void BoardShow()
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "board_show"}
            });
        }
        
        internal static void SdkImport()
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "import_sdk"}
            });
        }
        
        internal static void ErrorCodeClick()
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "error_code_click"}
            });
        }
        
        internal static void SampleClick(string type, string value)
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "create_sample_click"},
                {"type", type ?? ""},
                {"value", value ?? ""}
            });
        }
        
        internal static void MockSwitch(string type)
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "mock_switch"},
                {"type", type ?? ""},
            });
        }
        
        internal static void FetchSDKConfigInfo(long errorCode)
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "fetch_sdk_config_info"},
                {"result", errorCode == 0 ? "success" : "fail"},
                {"error_code", errorCode},
            });
        }

        internal static void FetchVersion(long errorCode)
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "fetch_version"},
                {"result", errorCode == 0 ? "success" : "fail"},
                {"error_code", errorCode},
            });
        }

        internal static void FetchVersionClick()
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "fetch_version_click"}
            });
        }

        internal static void AdDisplayClick()
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "ad_display_click"},
            });
        }
        
        internal static void AdDeleteClick()
        {
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "ad_delete_click"},
            });
        }
        
        internal static void ArchiveApkClick()
        {
            var debugMode = OSDKIntegrationConfig.DebugMode();
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "archive_apk_btn_click"},
                {"debug_mode", debugMode},
            });
        }
        
        internal static void ArchiveIpaClick()
        {
            var debugMode = OSDKIntegrationConfig.DebugMode();
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "archive_ipa_btn_click"},
                {"debug_mode", debugMode},
            });
        }
        
        internal static void ExportXcodeClick()
        {
            var debugMode = OSDKIntegrationConfig.DebugMode();
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "export_xcode_click"},
                {"debug_mode", debugMode},
            });
        }

        internal static void ExportIpa(bool success)
        {
            var debugMode = OSDKIntegrationConfig.DebugMode();
            RecordUpload(IntegrationEventTypeValue, new Dictionary<string, object>
            {
                {"action", "export_api"},
                {"result", success ? "success" : "fail"},
                {"debug_mode", debugMode},
            });
        }
        
        internal static void ArchiveApkSystem(bool success, string platform, string reason, string stacktrace)
        {
            var debugMode = OSDKIntegrationConfig.DebugMode();
            var r = new Dictionary<string, object>
            {
                {"action", "archive_package"},
                {"result", success ? "success" : "fail"},
                {"platform", platform},
                {"debug_mode", debugMode},
            };
            if (!string.IsNullOrEmpty(reason))
            {
                r.Add("reason", reason);    
            }
            if (!string.IsNullOrEmpty(stacktrace))
            {
                r.Add("stacktrace", stacktrace);
            }
            RecordUpload(IntegrationEventTypeValue, r);
        }

        private static void RecordUpload(string eventTypeValue, Dictionary<string, object> eventValueMap)
        {
            OSDKIntegrationHttp.UploadRecord(eventTypeValue, eventValueMap);
        }
    }
}