using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationBuildProcessor : IPreprocessBuildWithReport, IPostprocessBuildWithReport
    {
        private static string _platform;
        public int callbackOrder { get; }
        public void OnPreprocessBuild(BuildReport report)
        {
            Application.logMessageReceived += OnBuildError;
            if (report.summary.platform == BuildTarget.Android)
                _platform = "android";
            else if (report.summary.platform == BuildTarget.iOS)
                _platform = "ios";
            else
                _platform = "unknown";
        }
        
        // CALLED DURING BUILD TO CHECK FOR ERRORS
        private void OnBuildError(string condition, string stacktrace, LogType type)
        {
            if (type == LogType.Error || type == LogType.Exception)
            {
                // FAILED TO BUILD, STOP LISTENING FOR ERRORS
                Application.logMessageReceived -= OnBuildError;
                OSDKIntegrationRecord.ArchiveApkSystem(false, _platform, condition, stacktrace);
            }
        }

        public void OnPostprocessBuild(BuildReport report)
        {
            // IF BUILD FINISHED AND SUCCEEDED, STOP LOOKING FOR ERRORS
            Application.logMessageReceived -= OnBuildError;
            OSDKIntegrationRecord.ArchiveApkSystem(true, _platform, null, null);
        }
    }
}