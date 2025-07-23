namespace Douyin.Game
{
    public class OSDKSettingsTemplateGradle : OSDKTemplateGradle
    {
        private static readonly string TargetSettingsTemplateGradleFilePath =
            $"{OSDKAndroidResourceUtils.PluginsAndroidDir}/settingsTemplate.gradle";
        
        private static OSDKSettingsTemplateGradle _instance;

        public static OSDKSettingsTemplateGradle Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                _instance = new OSDKSettingsTemplateGradle();
                return _instance;
            }
        }
        private OSDKSettingsTemplateGradle() : base(TargetSettingsTemplateGradleFilePath)
        {
        }

        internal void SetDefaultSettingsTemplateGradleIfNotExist()
        {
            CheckTargetTemplateGradle(OSDKProjectPathUtils.SettingsTemplateGradleFilePath);
            SetupMavenRepositories();
        }
    }
}