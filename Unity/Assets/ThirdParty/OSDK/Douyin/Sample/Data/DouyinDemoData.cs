using System.Collections.Generic;
using Douyin.Game;
using UnityEngine.Scripting;

namespace Demo.Douyin.Game
{
    [Preserve]
    public class DouyinDemoData : Singeton<DouyinDemoData>
    {
        [Preserve]
        public void InsertDemoUIData(List<SecondLevelFunctionsEntity> list)
        {
            var enties = new List<ThirdLevelFunctionsEntity>();
            if (OSDKIntegration.OSDKType == OSDKTypeEnum.Android_GameId || OSDKIntegration.OSDKType == OSDKTypeEnum.Omnichannel_DataLink || OSDKIntegration.OSDKType == OSDKTypeEnum.Omnichannel_ActivityLink || OSDKIntegration.OSDKType == OSDKTypeEnum.iOS)
            {
                enties.Add(new ThirdLevelFunctionsEntity()
                {
                    NameId = DemoDouyinFunctionScript.ITEM_ID_SDK_DOUYIN_AUTHORIZE,
                    CnContent = "抖音授权"
                });
                enties.Add(new ThirdLevelFunctionsEntity()
                {
                    NameId = DemoDouyinFunctionScript.ITEM_ID_CLEAR_DOUYIN_AUTH_INFO,
                    CnContent = "清理抖音授权信息"
                });
            }
            enties.Add(new ThirdLevelFunctionsEntity()
            {
                NameId = DemoGameRoleFunctionScript.ITEM_ID_SDK_ROLE_MOCK,
                CnContent = "[测试]数据MOCK"
            });
            enties.Add( new ThirdLevelFunctionsEntity()
            {
                NameId = DemoGameRoleFunctionScript.ITEM_ID_SDK_ROLE_REPORTER,
                CnContent = "抖音账号绑定"
            });
            list.Add(new SecondLevelFunctionsEntity()
            {
                CnContent = "抖音账号授权与绑定",
                ThirdLevelFunctionsEntities = enties
            });
        }
    }
}