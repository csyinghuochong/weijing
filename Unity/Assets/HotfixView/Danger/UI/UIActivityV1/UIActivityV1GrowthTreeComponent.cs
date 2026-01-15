using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1GrowthTreeComponent : Entity, IAwake
    {
        public Text Text_Growth;
        public Image ImageGrowthValue;

        public GameObject UIRewardDescListItem;
        public GameObject UIRewardDescList;
        public GameObject RewardButtonClose;
        public GameObject UIRewardDesc;

        public GameObject UIStageDesc;
        public GameObject StageButtonClose;
        public GameObject UIStageDescList;
        public GameObject UIStageDescItem;

        public Text Text_AddNum;
        public GameObject UIActivityV1GrowthTreeCostItem;
        public GameObject GiveItemList;
        public List<UIActivityV1GrowthTreeCostItemComponent> UIGiveItemList = new List<UIActivityV1GrowthTreeCostItemComponent>();

        public GameObject UICommonItem;
        public GameObject ShowItemList;
        public List<UIItemComponent> UIShowItemList = new List<UIItemComponent>();

        public GameObject ButtonStageDesc;
        public GameObject ButtonRewardDesc;
        public GameObject ButtonGive;
        public Text TextGrowNumber;
        public Text TextTreeName;
        public Image Tree_Icon;
    }

    public class UIActivityV1GrowthTreeComponentAwake : AwakeSystem<UIActivityV1GrowthTreeComponent>
    {
        public override void Awake(UIActivityV1GrowthTreeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIRewardDescListItem = rc.Get<GameObject>("UIRewardDescListItem");
            self.UIRewardDescListItem.SetActive(false);
            self.UIRewardDescList = rc.Get<GameObject>("UIRewardDescList");
            self.RewardButtonClose = rc.Get<GameObject>("RewardButtonClose");
            self.RewardButtonClose.GetComponent<Button>().onClick.AddListener(() => 
            {
                self.UIRewardDesc.SetActive(false);
            });
            self.UIRewardDesc = rc.Get<GameObject>("UIRewardDesc");
            self.UIRewardDesc.SetActive(false);

            self.UIStageDesc = rc.Get<GameObject>("UIStageDesc");
            self.StageButtonClose = rc.Get<GameObject>("StageButtonClose");
            self.StageButtonClose.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIStageDesc.SetActive(false);
            });
            self.UIStageDescList = rc.Get<GameObject>("UIStageDescList");
            self.UIStageDescItem = rc.Get<GameObject>("UIStageDescItem");
             self.UIStageDescItem.SetActive(false);
            self.UIStageDesc.SetActive(false);

            self.Text_AddNum = rc.Get<GameObject>("Text_AddNum").GetComponent<Text>();

            self.UIActivityV1GrowthTreeCostItem = rc.Get<GameObject>("UIActivityV1GrowthTreeCostItem");
            self.UIActivityV1GrowthTreeCostItem.SetActive(false);

            self.GiveItemList = rc.Get<GameObject>("GiveItemList");

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);

            self.ShowItemList = rc.Get<GameObject>("ShowItemList");

            self.ButtonStageDesc = rc.Get<GameObject>("ButtonStageDesc");
            self.ButtonStageDesc.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIStageDesc.SetActive(true);
            });

            self.ButtonRewardDesc = rc.Get<GameObject>("ButtonRewardDesc");
            self.ButtonRewardDesc.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIRewardDesc.SetActive(true);
            });

            self.ButtonGive = rc.Get<GameObject>("ButtonGive");
            self.ButtonGive.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonGive().Coroutine();  });

            self.Tree_Icon = rc.Get<GameObject>("Tree_Icon").GetComponent<Image>();
            self.TextGrowNumber = rc.Get<GameObject>("TextGrowNumber").GetComponent<Text>();
            self.TextTreeName = rc.Get<GameObject>("TextTreeName").GetComponent<Text>();
            self.Text_Growth = rc.Get<GameObject>("Text_Growth").GetComponent<Text>();
            self.ImageGrowthValue = rc.Get<GameObject>("ImageGrowthValue").GetComponent<Image>();

            self.InitUIShowItemList();
            self.InitUIGiveItemList();
            self.InitUIStageDescList();
            self.InitUIRewardDescList();
            self.UpdateInfo();
            self.UpdateTextGrowNumber();
            self.UpdateText_AddNum();
        }
    }

    public static class UIActivityV1GrowthTreeComponentSystem
    {

        public static void InitUIStageDescList(this UIActivityV1GrowthTreeComponent self)
        {
            foreach (var costitem in ActivityConfigHelper.ActivityTreeStageDesc)
            {
                GameObject itemSpace = GameObject.Instantiate(self.UIStageDescItem);

                Text text = itemSpace.transform.Find("TextGrowValue").GetComponent<Text>();
                string costname = GameSettingLanguge.LoadLocalization(costitem.Name);
                text.text = $"{costname} {costitem.GrowthValue}";

                GameObject ItemRewardList = itemSpace.transform.Find("ItemRewardList").gameObject;
                UICommonHelper.ShowItemList(costitem.Reward, ItemRewardList, self);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.UIStageDescList);
            }
        }

        public static void InitUIRewardDescList(this UIActivityV1GrowthTreeComponent self)
        {
            foreach (var treeTendItem in ActivityConfigHelper.ActivityTreeTendRewardItem)
            {
                
                GameObject itemSpace = GameObject.Instantiate(self.UIRewardDescListItem);

                Text TextGrowValue = itemSpace.transform.Find("TextGrowValue").GetComponent<Text>();
                string str = GameSettingLanguge.LoadLocalization("成长值");
                TextGrowValue.text = $"{treeTendItem.GrowthValueLower}-{treeTendItem.GrowthValueUpper}{str}";

                GameObject ItemRewardList = itemSpace.transform.Find("ItemRewardList").gameObject;

                List<RewardItem> droplist = new List<RewardItem>();
                DropHelper.DropIDToDropItem_2(treeTendItem.Reward, droplist);

                UICommonHelper.ShowItemList(droplist, ItemRewardList, self);

                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.UIRewardDescList);
            }
        }

        public static void InitUIShowItemList(this UIActivityV1GrowthTreeComponent self)
        {

            string showstr_2 = GameSettingLanguge.LoadLocalization("点");

            foreach ( var costitem in ActivityConfigHelper.ActivityTreeCostItem)
            {
                int itemid = costitem.Key;

                int lower = costitem.Value.Item1;
                int upper = costitem.Value.Item2;

                GameObject itemSpace = GameObject.Instantiate(self.UICommonItem);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.ShowItemList);
                UIItemComponent  uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                
                itemSpace.transform.localScale = Vector3.one * 1f;
               
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = itemid }, ItemOperateEnum.None);

                uIItemComponent.Label_ItemNum.SetActive(false);
                uIItemComponent.Label_ItemName.SetActive(true);
                uIItemComponent.Label_ItemName.GetComponent<Text>().text = $"{lower}-{upper}{showstr_2}";

                self.UIShowItemList.Add(uIItemComponent);
            }
            
        }

        public static void InitUIGiveItemList(this UIActivityV1GrowthTreeComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            foreach (var costitem in ActivityConfigHelper.ActivityTreeCostItem)
            {
                int itemid = costitem.Key;

                long havenum = bagComponent.GetItemNumber(itemid);

                GameObject itemSpace = GameObject.Instantiate(self.UIActivityV1GrowthTreeCostItem);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.GiveItemList);

                UIActivityV1GrowthTreeCostItemComponent costitemcomponent = self.AddChild<UIActivityV1GrowthTreeCostItemComponent, GameObject>(itemSpace);

                costitemcomponent.OnInitData(itemid, havenum);

                self.UIGiveItemList.Add(costitemcomponent);
            }
        }

        public static async ETTask OnButtonGive(this UIActivityV1GrowthTreeComponent self)
        {
            List<RewardItem> costitems = new List<RewardItem>();

            for (int i = 0; i < self.UIGiveItemList.Count; i++)
            {
                int itemid = self.UIGiveItemList[i].ItemId;
                int usenum = (int)self.UIGiveItemList[i].UseNum;

                if (itemid == 0 || usenum == 0)
                {
                    continue;
                }
                ActivityConfigHelper.ActivityTreeCostItem.TryGetValue(itemid, out var costitemcomponent);
                if (costitemcomponent == default)
                {
                    continue;
                }
                costitems.Add( new RewardItem() { ItemID = itemid,ItemNum = usenum } );
            }
            if (costitems.Count == 0)
            {
                return;
            }

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            C2M_ActivityTreeTendRequest c2E_GetAllMailRequest = new C2M_ActivityTreeTendRequest()
            {
               CostList = costitems
            };
            M2C_ActivityTreeTendResponse sendChatResponse = (M2C_ActivityTreeTendResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest);

            if (sendChatResponse == null || sendChatResponse.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            activityComponent.ActivityV1Info = sendChatResponse.ActivityV1Info;

            if (self.IsDisposed)
            {
                return;
            }
            self.UpdateUIGiveItemList();
            self.UpdateTextGrowNumber();
            await ETTask.CompletedTask;
        }

        public static void UpdateTextGrowNumber(this UIActivityV1GrowthTreeComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            int newstate = ActivityConfigHelper.GetActivityTreeStageItem(activityComponent.ActivityV1Info.GrowthTreeValue);
            if (newstate >= ActivityConfigHelper.ActivityTreeStageDesc.Count)
            {
                newstate = ActivityConfigHelper.ActivityTreeStageDesc.Count - 1;
            }
            ActivityTreeStageItem activityTreeStageItem = ActivityConfigHelper.ActivityTreeStageDesc[newstate];

            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, $"ImgBig_10{newstate+1}");
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
           
            self.Tree_Icon.sprite = sp;

            self.TextGrowNumber.text = activityComponent.ActivityV1Info.GrowthTreeValue.ToString();
            self.TextTreeName.text = GameSettingLanguge.LoadLocalization(activityTreeStageItem.Name) ;


            float progress = activityComponent.ActivityV1Info.GrowthTreeValue * 1f / activityTreeStageItem.GrowthValue;
            self.Text_Growth.text = $"{activityComponent.ActivityV1Info.GrowthTreeValue}/{activityTreeStageItem.GrowthValue}";
            self.ImageGrowthValue.fillAmount = progress;
        }

        public static void UpdateText_AddNum(this UIActivityV1GrowthTreeComponent self)
        {
            int lower = 0;
            int upper = 0;
            for (int i = 0; i < self.UIGiveItemList.Count; i++)
            {
                int itemid = self.UIGiveItemList[i].ItemId;
                int usenum = (int)self.UIGiveItemList[i].UseNum;

                ActivityConfigHelper.ActivityTreeCostItem.TryGetValue(itemid, out var costitemcomponent);
                if (costitemcomponent == default)
                {
                    continue;
                }

                lower += usenum * costitemcomponent.Item1;
                upper += usenum * costitemcomponent.Item2;
            }
            string str1 = GameSettingLanguge.LoadLocalization("预计增加{0}点成长值");
            string str2 = $"{lower}-{upper}";
            self.Text_AddNum.text = string.Format(str1, str2);
        }

        public static void UpdateUIGiveItemList(this UIActivityV1GrowthTreeComponent self)
        {
            for (int i = 0; i < self.UIGiveItemList.Count; i++)
            {
                self.UIGiveItemList[i].OnUpdateUI();
            }
        }

        public static void UpdateInfo(this UIActivityV1GrowthTreeComponent self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;


        }

       
    }
}