using System.Collections.Generic;

namespace Douyin.Game
{
    public class MainListDataManager : Singeton<MainListDataManager>
    {
        // 获取首页列表数据
        public MainListEntity GetMainListEntity()
        {
            var mainListEntity = new MainListEntity();
            var primaryLevelFunctions = new List<PrimaryLevelFunctionsEntity>();


            // 基础功能
            var basicFunctionSecondLevelList = new List<SecondLevelFunctionsEntity>();
            var basicTypeNameList = new List<string>()
            {
                // Core模块提供的功能
                "Demo.Douyin.Game.CoreDemoData",
                // 全官服促活分账
                "Demo.Douyin.Game.DataLinkDemoData",
#if UNITY_ANDROID
                // 抖音账号登录
                "Demo.Douyin.Game.DouYinAccountDemoData",
                // 游戏账号登录
                "Demo.Douyin.Game.GameAccountDemoData",
#endif
                // Cps相关功能
                "Demo.Douyin.Game.CpsDemoData",
                // 抖音授权模块与账号绑定
                "Demo.Douyin.Game.DouyinDemoData",
            };
            foreach (var typeName in basicTypeNameList)
            {
                ReflectionInvoke.Invoke(
                    typeName,
                    "Instance", "InsertDemoUIData", new object[] { basicFunctionSecondLevelList });
            }

            if (basicFunctionSecondLevelList.Count > 0)
            {
                primaryLevelFunctions.Add(new PrimaryLevelFunctionsEntity
                {
                    CnContent = "基础功能",
                    SecondLevelFunctionsEntities = basicFunctionSecondLevelList
                });
            }

            // 变现功能
            var moneyMakingFunctionsEntities = new List<SecondLevelFunctionsEntity>();
            var moneyMakingTypeNameList = new List<string>()
            {
#if UNITY_ANDROID
                // 抖音广告
                // "Demo.Douyin.Game.AdDemoData",
                // 抖音支付
                "Demo.Douyin.Game.DouYinPayDemoData"
#endif
            };
            foreach (var typeName in moneyMakingTypeNameList)
            {
                ReflectionInvoke.Invoke(
                    typeName,
                    "Instance", "InsertDemoUIData", new object[] { moneyMakingFunctionsEntities });
            }

            if (moneyMakingFunctionsEntities.Count > 0)
            {
                primaryLevelFunctions.Add(new PrimaryLevelFunctionsEntity
                {
                    CnContent = "变现功能",
                    SecondLevelFunctionsEntities = moneyMakingFunctionsEntities
                });
            }

            // 其他
            var otherFunctionsEntities = new List<SecondLevelFunctionsEntity>();
            var otherFunctionsTypeNameList = new List<string>()
            {
                // 看播
                "Demo.Douyin.Game.LiveDemoData",
                // 屏幕录制
                "Demo.Douyin.Game.ScreenRecordDemoData",
#if UNITY_ANDROID || UNITY_EDITOR
                // 云游戏
                "Demo.Douyin.Game.CloudGameDemoData",
#endif
                // 分享
                "Demo.Douyin.Game.ShareDemoData"
            };
            foreach (var typeName in otherFunctionsTypeNameList)
            {
                ReflectionInvoke.Invoke(typeName, "Instance", "InsertDemoUIData",
                    new object[] { otherFunctionsEntities });
            }

            if (otherFunctionsEntities.Count > 0)
            {
                primaryLevelFunctions.Add(new PrimaryLevelFunctionsEntity
                {
                    CnContent = "其他功能",
                    SecondLevelFunctionsEntities = otherFunctionsEntities
                });
            }
#if UNITY_ANDROID 
            
            // 接口测试
            var testFunctionSecondLevelList = new List<SecondLevelFunctionsEntity>();
            var testTypeNameList = new List<string>()
            {
                "Demo.Douyin.Game.TestDemoData"
            };
            foreach (var typeName in testTypeNameList)
            {
                ReflectionInvoke.Invoke(
                    typeName,
                    "Instance", "InsertDemoUIData", new object[] { testFunctionSecondLevelList });
            }

            if (testFunctionSecondLevelList.Count > 0)
            {
                primaryLevelFunctions.Add(new PrimaryLevelFunctionsEntity
                {
                    CnContent = "Unity调用安卓测试",
                    SecondLevelFunctionsEntities = testFunctionSecondLevelList
                });
            }
#endif

            mainListEntity.PrimaryLevelFunctionsEntities = primaryLevelFunctions;
            return mainListEntity;
        }
    }
}