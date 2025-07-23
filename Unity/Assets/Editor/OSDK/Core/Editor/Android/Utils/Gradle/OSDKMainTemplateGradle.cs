namespace Douyin.Game
{
    public class OSDKMainTemplateGradle : OSDKTemplateGradle
    {
        private static readonly string TargetMainTemplateGradleFilePath =
            $"{OSDKAndroidResourceUtils.PluginsAndroidDir}/mainTemplate.gradle";
        
        private static OSDKMainTemplateGradle _instance;

        public static OSDKMainTemplateGradle Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                _instance = new OSDKMainTemplateGradle();
                return _instance;
            }
        }
        private OSDKMainTemplateGradle() : base(TargetMainTemplateGradleFilePath)
        {
        }

        internal void SetDefaultMainTemplateGradleIfNotExist()
        {
            // 准备必要的配置.
            SetDefault(OSDKProjectPathUtils.MainTemplateGradleFilePath);
        }
    }
}