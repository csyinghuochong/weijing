#if UNITY_EDITOR

using System;

namespace Douyin.Game
{
    public class EditorCommonServiceImpl : ICommonService
    {
        public void Android_Prepare()
        {
            // do nothing
        }
        
        public void Init(Action onSuccess, Action<BaseErrorEntity<InitErrorEnum>> onFailed)
        {
            if (OSDKIntegration.InitMock == OSDKMockStatus.Success)
            {
                onSuccess?.Invoke();    
            }
            else
            {
                var entity = new BaseErrorEntity<InitErrorEnum>()
                {
                    ErrorEnum = InitErrorEnum.UNKNOW,
                    Message = "模拟验证 - 初始化失败"
                };
                onFailed?.Invoke(entity);
            }
        }

        public bool IsInited()
        {
            return true;
        }

        public void iOS_RequireIDFA(Action<bool, string> requireCallback)
        {
            requireCallback.Invoke(true, "0");
        }

        public string GetOpenExtraInfo()
        {
            return string.Empty;
        }

        public string GetApkAttributionEx()
        {
            return string.Empty;
        }

        public string GetHumeChannel()
        {
            return string.Empty;
        }

        public string GetHumeSdkVersion()
        {
            return string.Empty;
        }

        public bool IsRunningCloud()
        {
            return false;
        }
    }
}

#endif