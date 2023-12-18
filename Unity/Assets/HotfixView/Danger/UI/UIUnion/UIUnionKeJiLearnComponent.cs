using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionKeJiLearnComponent: Entity, IAwake, IDestroy
    {
        public GameObject UIUnionKeJiLearnItemListNode;
        public GameObject UIUnionKeJiLearnItem;
        public GameObject NameText;
        public GameObject LvText;
        public GameObject LearnCostListNode;
        public GameObject UICommonItem;
        public GameObject StartBtn;
        public GameObject HeadImg;

        public int Position;
        public UnionInfo UnionMyInfo;
        public UserInfo UserInfo;
        public List<UIItemComponent> UIItemComponentList = new List<UIItemComponent>();
        public List<UIUnionKeJiLearnItemComponent> UIUnionKeJiLearnItemComponentList = new List<UIUnionKeJiLearnItemComponent>();
        public List<string> AssetPath = new List<string>();
    }

    public class UIUnionKeJiLearnComponentAwakeSystem: AwakeSystem<UIUnionKeJiLearnComponent>
    {
        public override void Awake(UIUnionKeJiLearnComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIUnionKeJiLearnItemListNode = rc.Get<GameObject>("UIUnionKeJiLearnItemListNode");
            self.UIUnionKeJiLearnItem = rc.Get<GameObject>("UIUnionKeJiLearnItem");
            self.NameText = rc.Get<GameObject>("NameText");
            self.LvText = rc.Get<GameObject>("LvText");
            self.LearnCostListNode = rc.Get<GameObject>("LearnCostListNode");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.StartBtn = rc.Get<GameObject>("StartBtn");
            self.HeadImg = rc.Get<GameObject>("HeadImg");

            self.UIUnionKeJiLearnItem.SetActive(false);
            self.UICommonItem.SetActive(false);
            self.StartBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnStartBtn().Coroutine(); });

            self.InitItemList().Coroutine();
        }
    }

    public class UIUnionKeJiLearnComponentDestroy: DestroySystem<UIUnionKeJiLearnComponent>
    {
        public override void Destroy(UIUnionKeJiLearnComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }

    public static class UIUnionKeJiLearnComponentSystem
    {
        public static async ETTask InitItemList(this UIUnionKeJiLearnComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionId = unit.GetUnionId();
            C2U_UnionMyInfoRequest request = new C2U_UnionMyInfoRequest() { UnionId = unionId };
            U2C_UnionMyInfoResponse respose =
                    (U2C_UnionMyInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);

            self.UnionMyInfo = respose.UnionMyInfo;

            self.UserInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;

            for (int i = 0; i < self.UserInfo.UnionKeJiList.Count; i++)
            {
                UIUnionKeJiLearnItemComponent ui = null;

                GameObject go = UnityEngine.Object.Instantiate(self.UIUnionKeJiLearnItem);
                ui = self.AddChild<UIUnionKeJiLearnItemComponent, GameObject>(go);
                ui.ClickAction = self.UpdateInfo;
                UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(self.UnionMyInfo.UnionKeJiList[i]);
                string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, unionKeJiConfig.Icon);
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }

                ui.IconImg.GetComponent<Image>().sprite = sp;
                ui.UpdateInfo(i, self.UserInfo.UnionKeJiList[i], self.UnionMyInfo.UnionKeJiList[i]);
                self.UIUnionKeJiLearnItemComponentList.Add(ui);
                UICommonHelper.SetParent(go, self.UIUnionKeJiLearnItemListNode);
                go.SetActive(true);
            }

            self.UpdateInfo(0);
        }

        public static void UpdateInfo(this UIUnionKeJiLearnComponent self, int position)
        {
            self.Position = position;

            for (int i = 0; i < self.UIUnionKeJiLearnItemComponentList.Count; i++)
            {
                UIUnionKeJiLearnItemComponent learnItemComponent = self.UIUnionKeJiLearnItemComponentList[i];
                learnItemComponent.UpdateInfo(i, self.UserInfo.UnionKeJiList[i], self.UnionMyInfo.UnionKeJiList[i]);

                GameObject highlightImg = learnItemComponent.HighlightImg;
                highlightImg.SetActive(learnItemComponent.Position == position);
                if (learnItemComponent.Position == position)
                {
                    self.HeadImg.GetComponent<Image>().sprite = learnItemComponent.IconImg.GetComponent<Image>().sprite;
                }
            }

            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(self.UserInfo.UnionKeJiList[position]);

            Match match = Regex.Match(unionKeJiConfig.EquipSpaceName, @"\d");
            self.NameText.GetComponent<Text>().text = unionKeJiConfig.EquipSpaceName.Substring(0, match.Index);
            self.LvText.GetComponent<Text>().text = $"等级：{unionKeJiConfig.QiangHuaLv.ToString()}";

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            string[] items = unionKeJiConfig.LearnCost.Split('@');
            int num = 0;
            foreach (string item in items)
            {
                string[] str = item.Split(';');
                int itemConfigId = int.Parse(str[0]);
                int itemNum = int.Parse(str[1]);
                long havedNum = bagComponent.GetItemNumber(itemConfigId);
                if (num >= self.UIItemComponentList.Count)
                {
                    GameObject go = UnityEngine.Object.Instantiate(self.UICommonItem);
                    UIItemComponent uiItemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                    UICommonHelper.SetParent(go, self.LearnCostListNode);
                    go.SetActive(true);
                    self.UIItemComponentList.Add(uiItemComponent);
                }

                UIItemComponent itemComponent = self.UIItemComponentList[num];
                itemComponent.GameObject.SetActive(true);
                itemComponent.UpdateItem(new BagInfo() { ItemID = itemConfigId }, ItemOperateEnum.None);
                itemComponent.Label_ItemNum.GetComponent<Text>().text = $"{itemNum}/{havedNum}";
                itemComponent.Label_ItemNum.GetComponent<Text>().color =
                        havedNum >= itemNum? new Color(0, 1, 0) : new Color(245f / 255f, 43f / 255f, 96f / 255f);
                num++;
            }

            for (int i = num; i < self.UIItemComponentList.Count; i++)
            {
                self.UIItemComponentList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask OnStartBtn(this UIUnionKeJiLearnComponent self)
        {
            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(self.UserInfo.UnionKeJiList[self.Position]);
            if (unionKeJiConfig.NextID == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已经达到满级！");
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (!bagComponent.CheckNeedItem(unionKeJiConfig.LearnCost))
            {
                FloatTipManager.Instance.ShowFloatTip("道具数量不足！");
                return;
            }

            if (unionKeJiConfig.NextID > self.UnionMyInfo.UnionKeJiList[self.Position])
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }

            C2M_UnionKeJiLearnRequest request = new C2M_UnionKeJiLearnRequest() { Position = self.Position };
            M2C_UnionKeJiLearnResponse response =
                    (M2C_UnionKeJiLearnResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.UserInfo.UnionKeJiList = response.UnionKeJiList;
            self.UpdateInfo(self.Position);
        }
    }
}