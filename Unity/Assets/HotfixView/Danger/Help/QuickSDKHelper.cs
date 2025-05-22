using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using quicksdk;
using System;

namespace ET
{

    public static class QuickSDKHelper
    {

        static  void  showLog(string title, string message)
        {
            Debug.Log("title: " + title + ", message: " + message);
        }

        /// <summary>
        /// 定额支付（必接）, 调用渠道SDK的支付接口
        /// goodsID			产品ID，用来识别购买的产品
        /// goodsName		产品名称
        /// amount			支付总额（元）
        /// count			购买数量
        /// cpOrderID		产品订单号（游戏方的订单号）
        /// extrasParams	透传参数
        /// price			价格(可跟amount传一样的值)
        /// quantifier		购买商品单位，如：个
        /// goodsDesc		商品描述
        /// 接入要求：为了兼容各个渠道商品名称能够统一显示，订单应以如下案例的形式传值：
        /// amount:6.0 amount:10.0
        ///count:60 count:1
        ///goodsName:元宝 goodsName:月卡
        ///goodsName产品名称以“月卡”、“钻石”、“元宝”的形式传入，不带数量；
        /// </summary>
        public static void onPay(string info)
        {
            //model.amount + "," + dingDanID;
            showLog("onPay", info);
            string[] infolist = info.Split('_');

            OrderInfo orderInfo = new OrderInfo();
            GameRoleInfo gameRoleInfo = new GameRoleInfo();

            orderInfo.goodsID = "1";       //产品ID，用来识别购买的产品
            orderInfo.goodsName = "钻石";  //产品名称
            orderInfo.goodsDesc = "钻石";
            orderInfo.quantifier = "个";
            orderInfo.extrasParams = "extparma";   //透传参数  服务器发送异步通知时原样回传(需要传纯字符串，不能传json格式)
            orderInfo.count = 1;            //购买数量
            orderInfo.amount = double.Parse(infolist[0]);            //支付总额（元）
            orderInfo.price = double.Parse(infolist[0]);            //价格(可跟amount传一样的值)
            orderInfo.callbackUrl = "";     //游戏支付回调地址，如后台也有配置，则优先通知后台设置的地址
            orderInfo.cpOrderID = infolist[6];  //产品订单号（游戏方的订单号）

            gameRoleInfo.gameRoleBalance = "0";
            gameRoleInfo.gameRoleID = infolist[1];
            gameRoleInfo.gameRoleLevel = infolist[2];
            gameRoleInfo.gameRoleName = infolist[3];
            gameRoleInfo.partyName = "0";
            gameRoleInfo.serverID = infolist[4];
            gameRoleInfo.serverName = infolist[5];
            gameRoleInfo.vipLevel = "1";
            gameRoleInfo.roleCreateTime = TimeHelper.ServerNow().ToString();
            QuickSDK.getInstance().pay(orderInfo, gameRoleInfo);
        }

    }
}