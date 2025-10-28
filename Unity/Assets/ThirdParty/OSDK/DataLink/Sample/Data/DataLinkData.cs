using System.Collections.Generic;
using Douyin.Game;
using UnityEngine.Scripting;

namespace Demo.Douyin.Game
{
    [Preserve]
    public class DataLinkDemoData : Singeton<DataLinkDemoData>
    {
        [Preserve]
        public void InsertDemoUIData(List<SecondLevelFunctionsEntity> list)
        {

            if (OSDKIntegration.OSDKType != OSDKTypeEnum.Omnichannel_ActivityLink && OSDKIntegration.OSDKType != OSDKTypeEnum.Omnichannel_DataLink)
            {
                return;
            }

            list.Add(new SecondLevelFunctionsEntity
            {
                CnContent = "全官服促活分账",
                
                ThirdLevelFunctionsEntities = new List<ThirdLevelFunctionsEntity>()
                {
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_MOCK,
                        CnContent = "[测试]数据MOCK"
                    },
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_ACTIVE,
                        CnContent = "游戏激活事件"
                    },
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_ACCOUNT_REGISTER,
                        CnContent = "账号注册事件"
                    },
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_ROLE_REGISTER,
                        CnContent = "角色注册事件"
                    },
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_ACCOUNT_LOGIN,
                        CnContent = "账号登录事件"
                    },
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_ROLE_LOGIN,
                        CnContent = "角色登录事件"
                    },
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_PAY,
                        CnContent = "支付事件"
                    },
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_CUSTOM_EVENT,
                        CnContent = "自定义事件"
                    },
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_SET_EVENT_LISTENER,
                        CnContent = "设置事件监听"
                    },
                    new ThirdLevelFunctionsEntity()
                    {
                        NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_GET_EVENT_LISTENER,
                        CnContent = "获取事件监听"
                    }
                    
// #if UNITY_ANDROID
//                     new ThirdLevelFunctionsEntity()
//                     {
//                         NameId = DemoDataLinkFunctionScript.ITEM_ID_SDK_DATALINK_UPDATE_CLOUD_GAME_INFO,
//                         CnContent = "更新云游戏信息"
//                     }
// #endif
                    
                }
            });
        }
    }
}