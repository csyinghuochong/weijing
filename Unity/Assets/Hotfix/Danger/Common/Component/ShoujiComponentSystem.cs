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
            return proList;
        }

#if !SERVER
        public static async ETTask<int> ReqestShoujiReward(this ShoujiComponent self, int chapterId, int index)
        {
            try
            {
                C2M_ShoujiRewardRequest c2M_ItemHuiShouRequest = new C2M_ShoujiRewardRequest() { ChapterId = chapterId, RewardIndex = index };
                M2C_ShoujiRewardResponse r2c_roleEquip = (M2C_ShoujiRewardResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);

                if (r2c_roleEquip.Error == ErrorCore.ERR_Success)
                {
                    ShouJiChapterInfo shouJiChapterInfo = self.GetShouJiChapterInfo(chapterId);
                    shouJiChapterInfo.RewardInfo |= (1 << index);
                }
                return r2c_roleEquip.Error;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
            return ErrorCore.ERR_NetWorkError;
        }
#endif

    }
}
