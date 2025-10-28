using System;
using System.Collections.Generic;

namespace Douyin.Game
{
    public interface IDataLinkService
    {
        /// <summary>
        /// 游戏激活事件
        /// </summary>
        /// <returns>接口调用是否成功</returns>
        bool OnGameActive();

        /// <summary>
        /// 账号注册事件
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <returns>接口调用是否成功</returns>
        bool OnAccountRegister(string gameUserID);

        /// <summary>
        /// 角色注册事件
        /// 可选调用，没有角色概念的游戏可以不调用；账号注册事件和角色注册事件可以同时调用;
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <param name="gameRoleID">游戏角色ID，需保障游戏内唯一</param>
        /// <returns>接口调用是否成功</returns>
        bool OnRoleRegister(string gameUserID, string gameRoleID);

        /// <summary>
        /// 账号登录事件
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <param name="lastLoginTime">上次登录时间戳，单位秒</param>
        /// <returns>接口调用是否成功</returns>
        bool OnAccountLogin(string gameUserID, long lastLoginTime);

        /// <summary>
        /// 角色登录事件
        /// 可选调用，没有角色概念的游戏可以不调用；账号登录事件和角色登录事件可以同时调用;
        /// </summary>
        /// <param name="gameUserID">游戏用户ID，需保障游戏内唯一</param>
        /// <param name="gameRoleID">游戏角色ID，需保障游戏内唯一</param>
        /// <param name="lastRoleLoginTime">上次角色登录时间戳，单位秒</param>
        /// <returns>接口调用是否成功</returns>
        bool OnRoleLogin(string gameUserID, string gameRoleID, long lastRoleLoginTime);

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
        bool OnPay(string gameUserID, string gameRoleID, string gameOrderID, long totalAmount, string productID, string productName, string productDesc);

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
        bool OnPaySpecial(string gameUserID, string gameRoleID, string gameOrderID, string payType, long payRangeMin, long payRangeMax, string productID, string productName, string productDesc);

        /// <summary>
        /// 自定义事件
        /// 请在技术支持协助下使用，无需主动调用该方法
        /// </summary>
        /// <param name="eventName">事件名</param>
        /// <param name="jsonParams"></param>
        /// <returns>接口调用是否成功</returns>
        bool CustomEvent(string eventName, string jsonParams);

        /// <summary>
        /// 更新云游戏设备信息【仅Android，仅Android，iOS调用会直接返回ture】
        /// 一般不用，用于兜底：如果部分设备信息在初始化SDK时获取不到，可通过更新接口设置，SDK内部进行覆盖
        /// </summary>
        /// <param name="cloudGameInfo"></param>
        /// <returns></returns>
        bool UpdateCloudGameInfo(CloudGameInfo cloudGameInfo);
        
        /// <summary>
        /// 设置数据上报结果监听事件
        /// </summary>
        /// <param name="eventListenerAction"></param>
        void SetDataLinkEventListener(Action<EventListenerResult> eventListenerAction);
        
        /// <summary>
        /// 获取数据上报结果监听事件
        /// </summary>
        /// <returns></returns>
        Action<EventListenerResult> GetDataLinkEventListener();
    }
}