using System;
using UnityEngine;
using Douyin.Game;

namespace Douyin.Game
{
    // 注意：此脚本请挂载到游戏物体上，顺序位于SDK初始化脚本之后

    /// <summary>
    /// 全官服促活分账
    /// </summary>
    public class OSDKDataLink : MonoBehaviour
    {
        //【以下代码，外部方法】------------------------------------------------------------------

        /// <summary>
        /// 游戏激活事件
        /// </summary>
        /// <returns>接口调用是否成功</returns>     
        public bool OnGameActive()
        {
            return OSDK.GetService<IDataLinkService>().OnGameActive();
        }

        /// <summary>
        /// 账号注册事件
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <returns>接口调用是否成功</returns>
        public bool OnAccountRegister(string gameUserID)
        {
            return OSDK.GetService<IDataLinkService>().OnAccountRegister(gameUserID);
        }

        /// <summary>
        /// 角色注册事件
        /// 可选调用，没有角色概念的游戏可以不调用；账号注册事件和角色注册事件可以同时调用;
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <param name="gameRoleID">游戏角色ID，需保障游戏内唯一</param>
        /// <returns>接口调用是否成功</returns>
        public bool OnRoleRegister(string gameUserID, string gameRoleID)
        {
            return OSDK.GetService<IDataLinkService>().OnRoleRegister(gameUserID, gameRoleID);
        }

        /// <summary>
        /// 账号登录事件
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <param name="lastLoginTime">上次登录时间戳，单位秒</param>
        /// <returns>接口调用是否成功</returns>
        public bool OnAccountLogin(string gameUserID, long lastLoginTime)
        {
            return OSDK.GetService<IDataLinkService>().OnAccountLogin(gameUserID, lastLoginTime);
        }

        /// <summary>
        /// 角色登录事件
        /// 可选调用，没有角色概念的游戏可以不调用；账号登录事件和角色登录事件可以同时调用;
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <param name="gameRoleID">游戏角色ID，需保障游戏内唯一</param>
        /// <param name="lastRoleLoginTime">上次角色登录时间戳，单位秒</param>
        /// <returns>接口调用是否成功</returns>
        public bool OnRoleLogin(string gameUserID, string gameRoleID, long lastRoleLoginTime)
        {
            return OSDK.GetService<IDataLinkService>().OnRoleLogin(gameUserID, gameRoleID, lastRoleLoginTime);
        }

        /// <summary>
        /// 用户付费事件
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <param name="gameRoleID">游戏角色ID，需保障游戏内唯一，游戏没有角色概念的传空字符串</param>
        /// <param name="gameOrderID">订单ID</param>
        /// <param name="totalAmount">订单金额，单位分</param>
        /// <param name="productID">商品ID</param>
        /// <param name="productName">商品名称</param>
        /// <param name="productDesc">商品描述</param>
        /// <returns>接口调用是否成功</returns>
        public bool OnPay(string gameUserID, string gameRoleID, string gameOrderID, long totalAmount, string productID, string productName, string productDesc)
        {
            return OSDK.GetService<IDataLinkService>().OnPay(gameUserID, gameRoleID, gameOrderID, totalAmount, productID, productName, productDesc);
        }

        /// <summary>
        /// 用户特殊付费事件
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <param name="gameRoleID">游戏角色ID，需保障游戏内唯一，游戏没有角色概念的传空字符串</param>
        /// <param name="gameOrderID">订单ID</param>
        /// <param name="payType">付费类型，用于区分本次付费金额的大小，字段取值 high / medium / low，允许传入空字符串，付费范围由接入方自行定义</param>
        /// <param name="payRangeMin">本次付费所属的付费范围最小值，单位分</param>
        /// <param name="payRangeMax">本次付费所属的付费范围最大值，单位分</param>
        /// <param name="productID">商品ID</param>
        /// <param name="productName">商品名称</param>
        /// <param name="productDesc">商品描述</param>
        /// <returns>接口调用是否成功</returns>
        public bool OnPaySpecial(string gameUserID, string gameRoleID, string gameOrderID, string payType, long payRangeMin, long payRangeMax, string productID, string productName, string productDesc)
        {
            return OSDK.GetService<IDataLinkService>().OnPaySpecial(gameUserID, gameRoleID, gameOrderID, payType, payRangeMin, payRangeMax, productID, productName, productDesc);
        }

        /// <summary>
        /// 自定义事件
        /// 请在技术支持协助下使用，无需主动调用该方法
        /// </summary>
        /// <param name="eventName">事件名</param>
        /// <param name="jsonParams">事件入参 注意：Json格式</param>
        /// <returns>接口调用是否成功</returns>
        public bool CustomEvent(string eventName, string jsonParams)
        {
            return OSDK.GetService<IDataLinkService>().CustomEvent(eventName, jsonParams);
        }
        
        public void SetDataLinkEventListener()
        {
            OSDK.GetService<IDataLinkService>().SetDataLinkEventListener(OnEventListener);
        }

        public Action<EventListenerResult> GetDataLinkEventListener()
        {
            return OSDK.GetService<IDataLinkService>().GetDataLinkEventListener();
        }
        
        //【以下代码，需要开发者完善】------------------------------------------------------------------
        private void OnEventListener(EventListenerResult eventListenerResult)
        {
            // TODO 处理数据上报结果
            Debug.Log("OnEventListener: eventName: " + eventListenerResult.EventName + 
                      ", eventStatus: " + eventListenerResult.EventStatus + 
                      ", eventMsg: " + eventListenerResult.Message);
        }
    }
}
