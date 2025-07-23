using System;
using System.Collections.Generic;
using UnityEngine;

namespace Douyin.Game
{
    public static class ItemClickDelegate
    {
        // 监听进入详情页的点击事件
        public static Action<
            SecondLevelFunctionsEntity,
            ThirdLevelFunctionsEntity,
            List<FourLevelFunctionsEntity>> toDetailOnClickListener;

        // item 点击事件
        public static void OnItemClick(SecondLevelFunctionsEntity secondLevelFunctionsEntity, BaseListData baseList)
        {
            if (baseList == null)
            {
                Debug.LogError("ItemClickDelegate OnItemClick baseList is null...");
                return;
            }

            // 检查是否有四级列表，如果有四级列表说明，需要进入到详情页去展示对应的功能
            if (typeof(ThirdLevelFunctionsEntity) == baseList.GetType())
            {
                var thirdLevelFunctionsEntity = (ThirdLevelFunctionsEntity) baseList;

                // 三级列表点击事件
                if (thirdLevelFunctionsEntity.HasFourFunctions())
                {
                    // 处理3级列表的功能事件
                    if (secondLevelFunctionsEntity != null)
                    {
                        FunctionDispatcher.HandleItemClick(
                            secondLevelFunctionsEntity.NameId,
                            thirdLevelFunctionsEntity.NameId);
                    }
                    
                    // 需要进入详情页面
                    if (toDetailOnClickListener != null)
                    {
                        toDetailOnClickListener.Invoke(
                            secondLevelFunctionsEntity,
                            thirdLevelFunctionsEntity,
                            thirdLevelFunctionsEntity.FourLevelFunctionsEntities);
                    }
                }
                else
                {
                    // 处理3级列表的功能事件
                    if (secondLevelFunctionsEntity != null)
                    {
                        FunctionDispatcher.HandleItemClick(
                            secondLevelFunctionsEntity.NameId,
                            thirdLevelFunctionsEntity.NameId);
                    }
                }
            }
            else if (typeof(FourLevelFunctionsEntity) == baseList.GetType())
            {
                // 详情页面点击事件
                if (secondLevelFunctionsEntity != null)
                {
                    var fourLevelFunctionsEntity = (FourLevelFunctionsEntity) baseList;
                    if (fourLevelFunctionsEntity.GetItemType() == ItemTypeEnum.Select) {
                        string Id = baseList.NameId + "," + fourLevelFunctionsEntity.CurrentOptionIndex;
                        FunctionDispatcher.HandleItemClick(secondLevelFunctionsEntity.NameId, Id);
                    } else {
                        FunctionDispatcher.HandleItemClick(secondLevelFunctionsEntity.NameId, baseList.NameId);
                    }
                }
            }
            else if (typeof(SecondLevelFunctionsEntity) == baseList.GetType())
            {
                // 处理2级列表的点击事件
                if (secondLevelFunctionsEntity != null)
                {
                    FunctionDispatcher.HandleItemClick(
                        secondLevelFunctionsEntity.NameId,
                        secondLevelFunctionsEntity.NameId);
                }
            }
        }
    }
}