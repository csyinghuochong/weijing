using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChengJiuRewardComponent : Entity, IAwake
    {
        public GameObject Text_RewardDesc;
        public GameObject Text_RewardPoint;
        public GameObject Text_TotalPoint;
        public GameObject Image_RewardIcon;
        public GameObject Image_RewardJiuDi;
        public GameObject Btn_LingQu;
        public GameObject ItemListNode;
        public GameObject RewardListNode;

        public int RewardId;
        public List<UI> RewardUIList;
        public List<UI> ItemUIList;

        public ChengJiuComponent ChengJiuComponent;
    }

    [ObjectSystem]
    public class UIChengJiuRewardComponentAwakeSystem : AwakeSystem<UIChengJiuRewardComponent>
    {
        public override void Awake(UIChengJiuRewardComponent self)
        {
            self.RewardUIList = new List<UI>();
            self.ItemUIList = new List<UI>();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.Text_RewardDesc = rc.Get<GameObject>("Text_RewardDesc");
            self.Text_RewardPoint = rc.Get<GameObject>("Text_RewardPoint");
            self.Text_TotalPoint = rc.Get<GameObject>("Text_TotalPoint");
            self.Image_RewardIcon = rc.Get<GameObject>("Image_RewardIcon");
            self.Image_RewardJiuDi = rc.Get<GameObject>("Image_RewardJiuDi");

            self.Btn_LingQu = rc.Get<GameObject>("Btn_LingQu");
            self.Btn_LingQu.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_LingQu(); });

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");

            self.ChengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.InitRewardUIList().Coroutine();
        }
    }
    

    public static class UIChengJiuRewardComponentSystem
    {
        public static void OnUpdateUI(this UIChengJiuRewardComponent self)
        {
            self.Text_TotalPoint.GetComponent<Text>().text = self.ChengJiuComponent.TotalChengJiuPoint.ToString();
        }

        public static async ETTask InitRewardUIList(this UIChengJiuRewardComponent self)
        {
            List<ChengJiuRewardConfig> rewardConfigs  = ChengJiuRewardConfigCategory.Instance.GetAll().Values.ToList();
            string path = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuRewardItem");
            await ETTask.CompletedTask;
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < rewardConfigs.Count; i++)
            {
                GameObject skillItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(skillItem, self.RewardListNode);
                UI uI = self.AddChild<UI, string, GameObject>( "UIChengJiuRewardItem_" + i, skillItem);
                UIChengJiuRewardItemComponent uc = uI.AddComponent<UIChengJiuRewardItemComponent>();
                uc.OnInitData(rewardConfigs[i]);
                uc.SetClickHanlder((int rewardId) => { self.OnClickRewardItem(rewardId); });
                self.RewardUIList.Add(uI);
            }
            self.RewardUIList[0].GetComponent<UIChengJiuRewardItemComponent>().OnClick_DiButton();
        }

        public static void OnClickRewardItem(this UIChengJiuRewardComponent self, int rewardId)
        {
            self.RewardId = rewardId;

            for (int i = 0; i < self.RewardUIList.Count; i++)
            {
                self.RewardUIList[i].GetComponent<UIChengJiuRewardItemComponent>().SetSelected(rewardId);
            }
            self.OnUpdateSlectInfo(rewardId);
            self.OnUdapteItemList(rewardId).Coroutine();
        }

        public static void OnBtn_LingQu(this UIChengJiuRewardComponent self)
        {
            ChengJiuRewardConfig chengJiuConfig = ChengJiuRewardConfigCategory.Instance.Get(self.RewardId);
            if (self.ChengJiuComponent.TotalChengJiuPoint < chengJiuConfig.NeedPoint)
            {
                FloatTipManager.Instance.ShowFloatTip("成就点不足！");
                return;
            }
            if (self.ChengJiuComponent.AlreadReceivedId.Contains(self.RewardId))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过该奖励！");
                return;
            }
            self.ChengJiuComponent.ReceivedReward(self.RewardId).Coroutine();
        }

        public static async ETTask OnUdapteItemList(this UIChengJiuRewardComponent self, int rewardId)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            await ETTask.CompletedTask;
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            ChengJiuRewardConfig chengJiuConfig = ChengJiuRewardConfigCategory.Instance.Get(self.RewardId);
            string[] itemList = chengJiuConfig.RewardItems.Split('@');

            for (int i = 0; i < itemList.Length; i++)
            {
                string[] itemInfo = itemList[i].Split(';');
                int itemID = int.Parse(itemInfo[0]);
                int itemNum= int.Parse(itemInfo[1]);
               
                UI ui_item = null;
                if (i < self.ItemUIList.Count)
                {
                    ui_item = self.ItemUIList[i];
                    ui_item.GameObject.SetActive(true);
                }
                else
                {
                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.ItemListNode);
                    ui_item = self.AddChild<UI, string, GameObject>("UIItem_" + i.ToString(), bagSpace);
                    UIItemComponent uIItemComponent = ui_item.AddComponent<UIItemComponent>();
                    uIItemComponent.Label_ItemName.SetActive(true);
                    self.ItemUIList.Add(ui_item);
                }
                ui_item.GetComponent<UIItemComponent>().UpdateItem(new BagInfo() {  ItemID = itemID, ItemNum = itemNum }, ItemOperateEnum.None);
            }

            for (int i = itemList.Length; i < self.ItemUIList.Count; i++)
            {
                self.ItemUIList[i].GameObject.SetActive(false);
            }
        }

        public static void OnUpdateSlectInfo(this UIChengJiuRewardComponent self, int rewardId)
        {
            ChengJiuRewardConfig chengJiuConfig = ChengJiuRewardConfigCategory.Instance.Get(rewardId);

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ChengJiuIcon, chengJiuConfig.Icon.ToString());
            self.Image_RewardIcon.GetComponent<Image>().sprite = sp;

            self.Text_RewardPoint.GetComponent<Text>().text = string.Format("{0}成就奖励", chengJiuConfig.NeedPoint);
            self.Text_RewardDesc.GetComponent<Text>().text = chengJiuConfig.Desc;

            self.Text_TotalPoint.GetComponent<Text>().text = self.ChengJiuComponent.TotalChengJiuPoint.ToString();
        }
    }
}
