using System.Collections.Generic;
using Douyin.Game;
using UnityEngine.Scripting;

namespace Demo.Douyin.Game
{
    [Preserve]
    public class CoreDemoData : Singeton<CoreDemoData>
    {
        [Preserve]
        public void InsertDemoUIData(List<SecondLevelFunctionsEntity> list)
        {
            list.Add(new SecondLevelFunctionsEntity()
            {
                CnContent = "基础信息",
                ThirdLevelFunctionsEntities = new List<ThirdLevelFunctionsEntity>()
                {
                    new ThirdLevelFunctionsEntity
                    {
                        NameId = DemoCoreFunctionScript.ITEM_ID_SDK_INIT,
                        CnContent = "初始化"
                    },
                    new ThirdLevelFunctionsEntity
                    {
                        NameId = DemoCoreFunctionScript.ITEM_ID_IS_INIT,
                        CnContent = "是否初始化"
                    },
#if UNITY_ANDROID
                    new ThirdLevelFunctionsEntity
                    {
                        NameId = DemoCoreFunctionScript.ITEM_ID_GET_OPEN_EXTRA_INFO,
                        CnContent = "获取主播/达人归因信息(提审后的包生效)",
                    },
                    new ThirdLevelFunctionsEntity
                    {
                        NameId = DemoCoreFunctionScript.ITEM_ID_GET_APK_ATTRIBUTION_EXTRA,
                        CnContent = "获取完整归因信息(提审后的包生效)",
                    },
                    new ThirdLevelFunctionsEntity
                    {
                        NameId = DemoCoreFunctionScript.ITEM_ID_GET_HUME_CHANNEL,
                        CnContent = "获取巨量渠道包名(提审后的包生效)",
                    },
                    new ThirdLevelFunctionsEntity
                    {
                        NameId = DemoCoreFunctionScript.ITEM_ID_GET_HUME_SDK_VERSION,
                        CnContent = "获取巨量分包SDK版本号(提审后的包生效)",
                    },
                    new ThirdLevelFunctionsEntity
                    {
                        NameId = DemoCoreFunctionScript.ITEM_ID_RUNNING_CLOUD,
                        CnContent = "是否运行在云游戏环境",
                    },
#endif
                }
            });
        }
    }
}