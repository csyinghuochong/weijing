using System;

namespace Douyin.Game
{
    public interface ICommonService
    {

        /// <summary>
        /// Android在Init之前的prepare工作
        /// 一般不需要开发者调用，仅用于适配游戏自身有实现Applicaion类与SDK的GBApplication类冲突的情况：
        ///   Android在Init之前需要先prepare以提前完成耗时工作，SDK实现了将自带的GBApplication设置为游戏的Application类从而自动执行prepare动作。
        ///   如果游戏本身实现了自己的Application类则构建时会报错，此时开发者可屏蔽OSDKCoreProcessBuildAndroid.cs中对AutoConfigManifest()
        ///   的调用，并自行调用Android_Prepare方法以手动执行prepare工作。
        /// </summary>
        void Android_Prepare();
            
        /// <summary>
        /// sdk初始化入口
        /// </summary>
        /// <param name="onSuccess">初始化成功回调</param>
        /// <param name="onFailed">初始化失败回调，参数对应errorCode、errorMessage</param>
        void Init(Action onSuccess, Action<BaseErrorEntity<InitErrorEnum>> onFailed);


        /// <summary>
        /// 是否初始化成功
        /// </summary>
        /// <returns></returns>
        bool IsInited();

        /// <summary>
        /// （已废弃接口）iOS请求IDFA权限
        /// </summary>
        /// <param name="requireCallback"></param>
        [Obsolete]
        void iOS_RequireIDFA(Action<bool, string> requireCallback);

        /// <summary>
        /// 获取包含主播/达人的抖音号的归因信息，格式为一个JsonObject的字符串
        /// 示例：{"uniq_id":"53312341234","video_id":"7103272158612341234"}
        /// </summary>
        /// <returns></returns>
        string GetOpenExtraInfo();

        /// <summary>
        /// 获取完整归因信息
        /// </summary>
        /// <returns></returns>
        string GetApkAttributionEx();

        /// <summary>
        /// 获取巨量渠道名称（分包时写入的channel）
        /// </summary>
        /// <returns></returns>
        string GetHumeChannel();

        /// <summary>
        /// 获取巨量分包SDK版本号
        /// </summary>
        /// <returns></returns>
        string GetHumeSdkVersion();

        /// <summary>
        /// 是否运行在云游戏环境
        /// </summary>
        /// <returns>true: 云游戏环境， false: 手游环境</returns>
        bool IsRunningCloud();
    }
}