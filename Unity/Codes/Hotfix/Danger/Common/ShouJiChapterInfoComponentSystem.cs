using System;
using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class ShouJiChapterInfoComponentAwakeSystem : AwakeSystem<ShouJiChapterInfoComponent>
    {
        public override void Awake(ShouJiChapterInfoComponent self)
        {
            ShouJiChapterInfoComponent.Instance = self;
            self.Load();
        }
    }

    [ObjectSystem]
    public class ShouJiChapterInfoComponentLoadSystem : LoadSystem<ShouJiChapterInfoComponent>
    {
        public override void Load(ShouJiChapterInfoComponent self)
        {
            self.Load();
        }
    }

    [ObjectSystem]
    public class ShouJiChapterInfoComponentDestroySystem : DestroySystem<ShouJiChapterInfoComponent>
    {
        public override void Destroy(ShouJiChapterInfoComponent self)
        {
            ShouJiChapterInfoComponent.Instance = null;
        }
    }

    public static class ShouJiChapterInfoComponentSystem
    {
        public static void Load(this ShouJiChapterInfoComponent self)
        { 
            foreach (var item in ShouJiConfigCategory.Instance.GetAll().Values)
            {
                int itemId = item.ItemListID;
                while (itemId != 0)
                { 
                    ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(itemId);
                    itemId = shouJiItemConfig.NextID;
                    ItemStarInfo itemStarInfo = new ItemStarInfo();
                    itemStarInfo.ItemId = shouJiItemConfig.ItemID;
                    itemStarInfo.Star = shouJiItemConfig.StartNum;
                    itemStarInfo.Chapter = item.Id;
                    self.ItemStarInfos.Add(itemStarInfo);
                }
            }
        }
    }
}
