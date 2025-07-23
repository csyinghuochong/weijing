namespace Douyin.Game
{
    public class OSDKLauncherTemplateGradle : OSDKTemplateGradle
    {
        private static readonly string TargetMainTemplateGradleFilePath =
            $"{OSDKAndroidResourceUtils.PluginsAndroidDir}/launcherTemplate.gradle";
        
        private static OSDKLauncherTemplateGradle _instance;

        public static OSDKLauncherTemplateGradle Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new OSDKLauncherTemplateGradle();
                return _instance;
            }
        }
        private OSDKLauncherTemplateGradle() : base(TargetMainTemplateGradleFilePath)
        {
        }

        
        internal void SetDefaultLauncherTemplateGradleIfNotExist()
        {
            SetDefault(OSDKProjectPathUtils.LauncherTemplateGradleFilePath);
        }
    }
}