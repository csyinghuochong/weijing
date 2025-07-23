using UnityEngine;

namespace Douyin.Game
{
    // 注意：此脚本需挂载到游戏首个场景中的物体，且尽量保证优先调用InitSDK函数，建议在Awake时机调用
    public class OSDKStandardInit : MonoBehaviour
    {
        //【以下代码，外部方法】------------------------------------------------------------------
        
        // 初始化方法需要保证尽早调用，例如游戏首个场景的Awake时机
        public void InitSDK()
        {
            OSDK.GetService<ICommonService>().Init(InitSuccess, InitFail);
        }
        
        /// <summary>
        /// 是否初始化成功
        /// </summary>
        /// <returns></returns>
        public bool IsInited()
        {
            return OSDK.GetService<ICommonService>().IsInited();
        }

        /// <summary>
        /// 获取包含主播/达人的抖音号的归因信息，格式为一个JsonObject的字符串
        /// 示例：{"uniq_id":"53312341234","video_id":"7103272158612341234"}
        /// </summary>
        /// <returns></returns>
        public string GetOpenExtraInfo()
        {
            return OSDK.GetService<ICommonService>().GetOpenExtraInfo();
        }

        /// <summary>
        /// 获取完整归因信息
        /// </summary>
        /// <returns></returns>
        public string GetApkAttributionEx()
        {
            return OSDK.GetService<ICommonService>().GetApkAttributionEx();
        }

        /// <summary>
        /// 获取巨量渠道名称（分包时写入的channel）
        /// </summary>
        /// <returns></returns>
        public string GetHumeChannel()
        {
            return OSDK.GetService<ICommonService>().GetHumeChannel();
        }

        /// <summary>
        /// 获取巨量分包SDK版本号
        /// </summary>
        /// <returns></returns>
        public string GetHumeSdkVersion()
        {
            return OSDK.GetService<ICommonService>().GetHumeSdkVersion();
        }

        /// <summary>
        /// 是否运行在云游戏环境
        /// </summary>
        /// <returns>true: 云游戏环境， false: 手游环境</returns>
        public bool IsRunningCloud()
        {
            return OSDK.GetService<ICommonService>().IsRunningCloud();
        }

        //【以下代码，需要开发者完善】------------------------------------------------------------------
        
        /// <summary>
        /// 初始化成功回调.
        /// 所有SDK功能都需要在初始化成功之后调用
        /// </summary>
        private void InitSuccess()
        {
            // TODO 请处理SDK初始化成功后的游戏逻辑
        }
        
        /// <summary>
        /// 初始化失败回调
        /// </summary>
        /// <param name="entity"></param>
        private void InitFail(BaseErrorEntity<InitErrorEnum> entity)
        {
            // TODO 请处理SDK初始化失败后的游戏逻辑
        }
    }
}