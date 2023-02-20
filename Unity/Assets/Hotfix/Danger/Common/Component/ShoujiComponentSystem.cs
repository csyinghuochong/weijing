using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ObjectSystem]
    public class ShoujiComponentAwakeSystem : AwakeSystem<ShoujiComponent>
    {
        public override void Awake(ShoujiComponent self)
        {
            self.ShouJiChapterInfos.Clear();
        }
    }

    public static class ShoujiComponentSystem
    {

        public static ShouJiChapterInfo GetShouJiChapterInfo(this ShoujiComponent self, int chapterId)
        {
            for (int i = 0; i < self.ShouJiChapterInfos.Count; i++)
            {
                if (self.ShouJiChapterInfos[i].ChapterId == chapterId)
                { 
                    return self.ShouJiChapterInfos[i];
                }
            }
            return null;
        }

        public static bool HaveShouJiItem(this ShoujiComponent self, int chapterId, int itemId)
        {
            ShouJiChapterInfo shouJiChapterInfo = self.GetShouJiChapterInfo(chapterId);
            if (shouJiChapterInfo == null)
            {
                return false;
            }
            return shouJiChapterInfo.ShouJiItemList.Contains(itemId);
        }

        public static void OnGetItem(this ShoujiComponent self, int itemId)
        {
            ItemStarInfo itemStarInfo = null;
            List<ItemStarInfo> itemStars = Game.Scene.GetComponent<ShouJiChapterInfoComponent>().ItemStarInfos;
            for (int i = 0; i < itemStars.Count; i++)
            {
                if (itemStars[i].ItemId == itemId)
                {
                    itemStarInfo = itemStars[i];
                }
            }
            if (itemStarInfo == null)
            {
                return;
            }
            ShouJiChapterInfo shouJiChapterInfo = self.GetShouJiChapterInfo(itemStarInfo.Chapter);
            if (shouJiChapterInfo == null)
            {
                shouJiChapterInfo = new ShouJiChapterInfo();
                shouJiChapterInfo.RewardInfo = 0;
                shouJiChapterInfo.ChapterId = itemStarInfo.Chapter;
                self.ShouJiChapterInfos.Add(shouJiChapterInfo);
            }
            if (!shouJiChapterInfo.ShouJiItemList.Contains(itemStarInfo.ItemId))
            {
                shouJiChapterInfo.ShouJiItemList.Add(itemStarInfo.ItemId);
                shouJiChapterInfo.StarNum += itemStarInfo.Star;
            }
        }

        public static int GetShoujiIdByItemId(this ShoujiComponent self, int itemId)
        {
            int shoujiId = 0;   
            Dictionary<int, ShouJiItemConfig> keyValuePairs = ShouJiItemConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.ItemID == itemId && item.Value.StartType == 1)
                {
                    return item.Key;
                }
            }

            return shoujiId;
        }

        public static void UpdateShouJIStar(this ShoujiComponent self)
        {
            for (int i = 0; i < self.ShouJiChapterInfos.Count; i++)
            {
                self.ShouJiChapterInfos[i].StarNum = 0;

                for (int k = 0; k < self.ShouJiChapterInfos[i].ShouJiItemList.Count; k++)
                {
                    int shoujiId = self.GetShoujiIdByItemId(self.ShouJiChapterInfos[i].ShouJiItemList[k]);
                    if (!ShouJiItemConfigCategory.Instance.Contain(shoujiId))
                    {
                        continue;
                    }
                    self.ShouJiChapterInfos[i].StarNum += ShouJiItemConfigCategory.Instance.Get(shoujiId).StartNum;
                }
            }
        }

        public static void OnShouJiTreasure(this ShoujiComponent self, int shoujiId, int itemNum)
        {
            KeyValuePairInt keyValuePairInt = null;
            for (int i = 0; i < self.TreasureInfo.Count; i++)
            {
                if (self.TreasureInfo[i].KeyId == shoujiId)
                {
                    keyValuePairInt = self.TreasureInfo[i];
                    keyValuePairInt.Value = itemNum;
                }
            }
            if (keyValuePairInt == null)
            {
                keyValuePairInt = new KeyValuePairInt() { KeyId = shoujiId, Value = itemNum };
                self.TreasureInfo.Add(keyValuePairInt); 
            }
        }

        public static KeyValuePairInt GetTreasureInfo(this ShoujiComponent self, int shoujiId)
        {
            KeyValuePairInt keyValuePairInt = null;
            for (int i = 0; i < self.TreasureInfo.Count; i++)
            {
                if (self.TreasureInfo[i].KeyId == shoujiId)
                {
                    keyValuePairInt = self.TreasureInfo[i];
                }
            }
            return keyValuePairInt;
        }

        public static List<HideProList> GetTreasurePro(this ShoujiComponent self)
        {
            List<HideProList> proList = new List<HideProList>();

            for (int i = 0; i < self.TreasureInfo.Count; i++)
            {
                ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(self.TreasureInfo[i].KeyId);
                if (self.TreasureInfo[i].Value < shouJiItemConfig.AcitveNum)
                {
                    continue;
                }

                string[] attributeInfoList = shouJiItemConfig.AddPropreListStr.Split('@');
                for (int a = 0; a < attributeInfoList.Length; a++)
                {
                    string[] attributeInfo = attributeInfoList[a].Split(',');
                    int numericType = int.Parse(attributeInfo[0]);

                    if (NumericHelp.GetNumericValueType(numericType) == 2)
                    {
                        float fvalue = float.Parse(attributeInfo[1]);
                        proList.Add(new HideProList() { HideID = numericType, HideValue = (long)(fvalue * 10000) });
                    }
                    else
                    {
                        proList.Add(new HideProList() { HideID = numericType, HideValue = long.Parse(attributeInfo[1]) });
                    }
                }
            }

            return proList;
        }

        public static int GetChapterStar(this ShoujiComponent self, int chapterid)
        {
            ShouJiChapterInfo shouJiChapterInfo = self.GetShouJiChapterInfo((int)chapterid);
            return shouJiChapterInfo != null ? shouJiChapterInfo.StarNum : 0;
        }

        public static bool GetChapterStarLevel(this ShoujiComponent self, int chapterid, int level)
        {
            int star = self.GetChapterStar(chapterid);
            ShouJiConfig shouJiConfig = ShouJiConfigCategory.Instance.Get(chapterid);
            if (level == 1)
            {
                return star >= shouJiConfig.ProList1_StartNum;
            }
            if (level == 2)
            {
                return star >= shouJiConfig.ProList2_StartNum;
            }
            if (level == 3)
            {
                return star >= shouJiConfig.ProList3_StartNum;
            }
            return false;
        }

        public static List<HideProList> GetChapterPro(this ShoujiComponent self, int chapterid, int level)
        {
            List<HideProList> proList = new List<HideProList>();
            int star = self.GetChapterStar(chapterid);
            ShouJiConfig shouJiConfig = ShouJiConfigCategory.Instance.Get(chapterid);
            if (level == 1 && star >= shouJiConfig.ProList1_StartNum)
            {
                for (int i = 0; i < shouJiConfig.ProList1_Type.Length; i++)
                {
                    proList.Add(new HideProList() { HideID= shouJiConfig.ProList1_Type[i],HideValue = shouJiConfig.ProList1_Value[i] });
                }
            }
            if (level == 2 && star >= shouJiConfig.ProList2_StartNum)
            {
                for (int i = 0; i < shouJiConfig.ProList2_Type.Length; i++)
                {
                    proList.Add(new HideProList() { HideID = shouJiConfig.ProList2_Type[i], HideValue = shouJiConfig.ProList2_Value[i] });
                }
            }
            if (level == 3 && star >= shouJiConfig.ProList3_StartNum)
            {
                for (int i = 0; i < shouJiConfig.ProList3_Type.Length; i++)
                {
                    proList.Add(new HideProList() { HideID = shouJiConfig.ProList3_Type[i], HideValue = shouJiConfig.ProList3_Value[i] });
                }
            }
            return proList;
        }

        public static List<HideProList> GetProList(this ShoujiComponent self)
        {
            List<HideProList> proList = new List<HideProList>();
            foreach (var item in self.ShouJiChapterInfos)
            {
                proList.AddRange(self.GetChapterPro(item.ChapterId, 1) );
                proList.AddRange(self.GetChapterPro(item.ChapterId, 2));
                proList.AddRange(self.GetChapterPro(item.ChapterId, 3));
            }

            proList.AddRange(self.GetTreasurePro());
            return proList;
        }
    }
}
