using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Douyin.Game;
using UnityEngine;
using UnityEngine.Scripting;

namespace Demo.Douyin.Game
{
    [Preserve]
    public class DemoDouyinFunctionScript : Singeton<DemoDouyinFunctionScript>
    {
        public const string ITEM_ID_SDK_DOUYIN_AUTHORIZE = "sdk_douyin_authorize";
        public const string ITEM_ID_CLEAR_DOUYIN_AUTH_INFO = "clear_douyin_auth_info";
        
        private const string AuthCode = "user_info"; 
        
        [Preserve]
        public void FunctionDispatcher(string ItemID)
        {
            switch (ItemID)
            {
                case ITEM_ID_SDK_DOUYIN_AUTHORIZE:
                    DemoLog.D("调用抖音授权登录方法");
                    DemoStandardDouyin.Instance.Authorize(AuthCode);
                    break;
                case ITEM_ID_CLEAR_DOUYIN_AUTH_INFO:
                    DemoStandardDouyin.Instance.ClearDouYinAuthInfo();
                    DemoStandardDouyin.ShowToastAndPrint("抖音授权信息清理完成");
                    break;
            }
        }
    }
}