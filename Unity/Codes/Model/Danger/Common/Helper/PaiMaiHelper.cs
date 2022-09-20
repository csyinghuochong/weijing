using System.Linq;
using System.Collections.Generic;

namespace ET
{

    public enum PaiMaiTypeEnum : int
    { 
        None = 0,
        CaiLiao = 1,
        CostItem = 2,
        petItem = 3,
        Number = 4,
    }

    //成就类型数据
    public class PaiMaiTypeData
    {
        //每个章节对应的拍卖道具
        public Dictionary<int, List<int>> PaiMaiIDItemList = new Dictionary<int, List<int>>();
    }

    public class PaiMaiHelper : Singleton<PaiMaiHelper>
    {

        public List<PaiMaiTypeData> PaiMaiTypeData = new List<PaiMaiTypeData>();

        public List<string> PaiMaiTypeText = new List<string>() { "", "材料", "消耗品","宠物" };

        public Dictionary<int, string> PaiMaiIndexText = new Dictionary<int, string>()
        {
            {1,  "第一章" },
            {2,  "第二章" },
            {3,  "第三章" },
            {4,  "第四章" },
            {5,  "第五章" },
            {21,  "通用" },
            {31,  "技能" },
            {32,  "消耗" },
            /*
            {31,  "红色插槽" },
            {32,  "紫色插槽" },
            {33,  "蓝色插槽" },
            {34,  "绿色插槽" },
            {35,  "白色插槽" },
            {36,  "抗性宝石" },
            */
        };

        protected override void InternalInit()
        {
            base.InternalInit();

            InitPaiMaiData();
        }

        public List<int> GetChaptersByType(PaiMaiTypeEnum pype)
        {
            return PaiMaiTypeData[(int)pype].PaiMaiIDItemList.Keys.ToList();
        }

        public List<int> GetItemsByChapter(int typeid, int chapterId)
        {
            return PaiMaiTypeData[typeid].PaiMaiIDItemList[chapterId];
        }

        public void InitPaiMaiData()
        {
            for (int i = 0; i < (int)PaiMaiTypeEnum.Number+1; i++)
            {
                PaiMaiTypeData.Add(new PaiMaiTypeData());
            }

            Dictionary<int, PaiMaiSellConfig> allPaiMaiData = PaiMaiSellConfigCategory.Instance.GetAll();
            foreach (var item in allPaiMaiData)
            {
                PaiMaiSellConfig paiMaiSellConfig = item.Value;
                int paiMaiType = paiMaiSellConfig.PaiMaiType;
                int chapterId = paiMaiSellConfig.ChapterId;
                PaiMaiTypeData paiMaiTypeDatas = PaiMaiTypeData[paiMaiType];
                if (!paiMaiTypeDatas.PaiMaiIDItemList.ContainsKey(chapterId))
                {
                    paiMaiTypeDatas.PaiMaiIDItemList.Add(chapterId, new List<int>());
                }
                paiMaiTypeDatas.PaiMaiIDItemList[chapterId].Add(item.Key);
            }
        }

        //初始化拍卖行快捷购买数据
        public List<PaiMaiShopItemInfo> InitPaiMaiShopItemList(List<PaiMaiShopItemInfo> shopItemList = null) {

            Dictionary<int, PaiMaiSellConfig> allPaiMaiData = PaiMaiSellConfigCategory.Instance.GetAll();

            List<PaiMaiShopItemInfo> shopListInfos = new List<PaiMaiShopItemInfo>();

            //写入缓存
            Dictionary<long, PaiMaiShopItemInfo> dicInfos = new Dictionary<long, PaiMaiShopItemInfo>();
            if (shopItemList != null)
            {
                if (allPaiMaiData.Count == shopItemList.Count)
                {
                    return shopItemList;
                }

                foreach (PaiMaiShopItemInfo info in shopItemList)
                {
                    if (dicInfos.ContainsKey(info.Id) == false)
                    {
                        dicInfos.Add(info.Id, info);
                    }
                }
            }

            foreach (var item in allPaiMaiData)
            {
                PaiMaiShopItemInfo shopList = new PaiMaiShopItemInfo();

                if (dicInfos.ContainsKey(item.Value.ItemID) == false) {
                    shopList.ItemNumber = 999;
                    shopList.Id = item.Value.ItemID;
                    shopList.PriceType = item.Value.Price[0];
                    shopList.Price = item.Value.Price[1];
                    shopList.PricePro = 1;
                    shopListInfos.Add(shopList);
                }
            }

            return shopListInfos;
        }


        //每天更新道具物品价格
        public void UpdatePaiMaiShopItemList(List<PaiMaiShopItemInfo> shopItemList)
        {
            foreach (PaiMaiShopItemInfo info in shopItemList) {

                float upPrice = RandomHelper.RandFloat() * 0.05f;
                info.PricePro = 1 + upPrice;
                info.Price = (int)(info.Price * info.PricePro);

            }
        }

        //根据道具ID获取对应快捷购买的列表
        public PaiMaiShopItemInfo GetPaiMaiShopInfo(List<PaiMaiShopItemInfo> paiMaiItemInfos, long needItemID) 
        {

            //获取当前的数据
            foreach (PaiMaiShopItemInfo info in paiMaiItemInfos)
            {
                if (info.Id == needItemID)
                {
                    return info;
                }
            }

            return null;
        }

        //根据道具ID获取对应快捷购买的列表
        public void PaiMaiShopInfoAddBuyNum(List<PaiMaiShopItemInfo> paiMaiItemInfos, long needItemID,int buyNum)
        {

            //获取当前的数据
            foreach (PaiMaiShopItemInfo info in paiMaiItemInfos)
            {
                if (info.Id == needItemID)
                {
                    info.BuyNum += buyNum;
                }
            }
        }

    }
}
