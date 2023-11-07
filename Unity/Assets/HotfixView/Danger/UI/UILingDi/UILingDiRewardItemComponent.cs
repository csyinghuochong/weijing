using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UILingDiRewardItemComponent: Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject Label_ItemNeed;
        public GameObject ButtonDuihuan;
        public GameObject Label_ItemName;
        public GameObject Image_EventTrigger;
        public GameObject Image_ItemButton;
        public GameObject Label_ItemNum;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;

        public int LingDiLevel;
        public LingDiRewardConfig LingDiRewardConfig;
        
        public List<string> AssetPath = new List<string>();
    }



    public class UILingDiRewardItemComponentAwakeSystem : AwakeSystem<UILingDiRewardItemComponent, GameObject>
    {
        public override void Awake(UILingDiRewardItemComponent self, GameObject go)
        {
            self.Label_ItemNeed = go.Get<GameObject>("Label_ItemNeed");
            self.Label_ItemName = go.Get<GameObject>("Label_ItemName");
            self.Image_EventTrigger = go.Get<GameObject>("Image_EventTrigger");

            self.Image_ItemButton = go.Get<GameObject>("Image_ItemButton");
            ButtonHelp.AddListenerEx(self.Image_ItemButton, () => { self.OnImage_ItemButton(); });

            self.ButtonDuihuan = go.Get<GameObject>("ButtonDuihuan");
            ButtonHelp.AddListenerEx(self.ButtonDuihuan, () => { self.OnButtonDuihuan().Coroutine(); });

            self.Label_ItemNum = go.Get<GameObject>("Label_ItemNum");
            self.Image_ItemIcon = go.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = go.Get<GameObject>("Image_ItemQuality");
        }
    }
    public class UILingDiRewardItemComponentDestroy : DestroySystem<UILingDiRewardItemComponent>
    {
        public override void Destroy(UILingDiRewardItemComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UILingDiRewardItemComponentSystem
    {

        public static void OnImage_ItemButton(this UILingDiRewardItemComponent self)
        {
            //弹出Tips
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo = new BagInfo() { ItemID = self.LingDiRewardConfig.ItemID };
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static async ETTask OnButtonDuihuan(this UILingDiRewardItemComponent self)
        {
            if (self.LingDiLevel < self.LingDiRewardConfig.CountryLvlimit)
            {
                FloatTipManager.Instance.ShowFloatTip("领地等级不足！");
                return;
            }

            C2M_LingDiRewardRequest c2M_LingDiRewardRequest = new C2M_LingDiRewardRequest() { RewardId = self.LingDiRewardConfig.Id };
            M2C_LingDiRewardResponse m2C_LingDiRewardResponse = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_LingDiRewardRequest) as M2C_LingDiRewardResponse;
        }

        public static void  OnUpdateUI(this UILingDiRewardItemComponent self, LingDiRewardConfig shouJiItemConfig, int lingdiLv)
        {
            self.LingDiLevel = lingdiLv;
            self.LingDiRewardConfig = shouJiItemConfig;

            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(shouJiItemConfig.ItemID);
            long instanceid = self.InstanceId;
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            if (instanceid != self.InstanceId)
            {
                return;
            }
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig.ItemQuality);
            string path2 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
            Sprite sp2 = ResourcesComponent.Instance.LoadAsset<Sprite>(path2);
            if (!self.AssetPath.Contains(path2))
            {
                self.AssetPath.Add(path2);
            }
            self.Image_ItemQuality.GetComponent<Image>().sprite = sp2;

            self.Label_ItemName.GetComponent<Text>().text = itemconfig.ItemName;
            self.Label_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconfig.ItemQuality);

            ItemConfig itemConfigneed = ItemConfigCategory.Instance.Get(shouJiItemConfig.BuyItemID);
            self.Label_ItemNeed.GetComponent<Text>().text = $"{shouJiItemConfig.BuyPrice}{itemConfigneed.ItemName}";

            UICommonHelper.SetImageGray(self.Image_ItemIcon, lingdiLv < shouJiItemConfig.CountryLvlimit);
        }
    }
}
