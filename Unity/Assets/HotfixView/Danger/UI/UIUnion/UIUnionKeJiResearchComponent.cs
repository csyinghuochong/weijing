using System.Collections.Generic;
using System.Text.RegularExpressions;
using ILRuntime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionKeJiResearchComponent: Entity, IAwake, IDestroy
    {
        public GameObject UIUnionKeJiResearchItemListNode;
        public GameObject UIUnionKeJiResearchItem;
        public Image ProgressBarImg;
        public GameObject ProgressBarText;
        public GameObject QuickBtn;
        public GameObject NameText;
        public GameObject LvText;
        public GameObject NeedUnionLvText;
        public GameObject UICommonItem;
        public GameObject CostUnionGoldText;
        public GameObject NeedTimeText;
        public GameObject StartBtn;
        public GameObject UnderwayText;
        public GameObject HeadImg;

        public long NeedTime;
        public int Position;
        public UnionInfo UnionMyInfo;
        public UIItemComponent UIItemComponent;
        public List<UIUnionKeJiResearchItemComponent> UIUnionKeJiResearchItemComponentList = new List<UIUnionKeJiResearchItemComponent>();
        public List<string> AssetPath = new List<string>();
    }

    public class UIUnionKeJiResearchComponentAwakeSystem: AwakeSystem<UIUnionKeJiResearchComponent>
    {
        public override void Awake(UIUnionKeJiResearchComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIUnionKeJiResearchItemListNode = rc.Get<GameObject>("UIUnionKeJiResearchItemListNode");
            self.UIUnionKeJiResearchItem = rc.Get<GameObject>("UIUnionKeJiResearchItem");
            self.ProgressBarImg = rc.Get<GameObject>("ProgressBarImg").GetComponent<Image>();
            self.ProgressBarText = rc.Get<GameObject>("ProgressBarText");
            self.QuickBtn = rc.Get<GameObject>("QuickBtn");
            self.NameText = rc.Get<GameObject>("NameText");
            self.LvText = rc.Get<GameObject>("LvText");
            self.NeedUnionLvText = rc.Get<GameObject>("NeedUnionLvText");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.CostUnionGoldText = rc.Get<GameObject>("CostUnionGoldText");
            self.NeedTimeText = rc.Get<GameObject>("NeedTimeText");
            self.StartBtn = rc.Get<GameObject>("StartBtn");
            self.UnderwayText = rc.Get<GameObject>("UnderwayText");
            self.HeadImg = rc.Get<GameObject>("HeadImg");

            self.ProgressBarImg.fillAmount = 0;
            self.UnderwayText.SetActive(false);
            self.UIUnionKeJiResearchItem.SetActive(false);
            self.UIItemComponent = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);
            self.QuickBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnQuickBtn().Coroutine(); });
            self.StartBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnStartBtn().Coroutine(); });

            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, "Img_476");
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }

            self.HeadImg.GetComponent<Image>().sprite = sp;

            self.InitItemList().Coroutine();
        }
    }

    public class UIUnionKeJiResearchComponentDestroy: DestroySystem<UIUnionKeJiResearchComponent>
    {
        public override void Destroy(UIUnionKeJiResearchComponent self)
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

    public static class UIUnionKeJiResearchComponentSystem
    {
        public static async ETTask InitItemList(this UIUnionKeJiResearchComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionId = unit.GetUnionId();
            C2U_UnionMyInfoRequest request = new C2U_UnionMyInfoRequest() { UnionId = unionId };
            U2C_UnionMyInfoResponse respose =
                    (U2C_UnionMyInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);

            self.UnionMyInfo = respose.UnionMyInfo;

            for (int i = 0; i < self.UnionMyInfo.UnionKeJiList.Count; i++)
            {
                UIUnionKeJiResearchItemComponent ui = null;

                GameObject go = UnityEngine.Object.Instantiate(self.UIUnionKeJiResearchItem);
                ui = self.AddChild<UIUnionKeJiResearchItemComponent, GameObject>(go);
                ui.ClickAction = self.UpdateInfo;
                UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(self.UnionMyInfo.UnionKeJiList[i]);
                string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, unionKeJiConfig.Icon);
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }

                ui.IconImg.GetComponent<Image>().sprite = sp;
                ui.UpdateInfo(i, self.UnionMyInfo.UnionKeJiList[i]);
                self.UIUnionKeJiResearchItemComponentList.Add(ui);
                UICommonHelper.SetParent(go, self.UIUnionKeJiResearchItemListNode);
                go.SetActive(true);
            }

            self.UpdateInfo(0);
            self.UpdataProgressBar().Coroutine();
        }

        public static void UpdateInfo(this UIUnionKeJiResearchComponent self, int position)
        {
            self.Position = position;

            for (int i = 0; i < self.UIUnionKeJiResearchItemComponentList.Count; i++)
            {
                UIUnionKeJiResearchItemComponent researchItemComponent = self.UIUnionKeJiResearchItemComponentList[i];
                researchItemComponent.UpdateInfo(i, self.UnionMyInfo.UnionKeJiList[i]);

                GameObject highlightImg = researchItemComponent.HighlightImg;
                highlightImg.SetActive(researchItemComponent.Position == position);
                if (researchItemComponent.Position == position)
                {
                    self.HeadImg.GetComponent<Image>().sprite = researchItemComponent.IconImg.GetComponent<Image>().sprite;
                }
            }

            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(self.UnionMyInfo.UnionKeJiList[position]);

            self.NeedTime = self.UnionMyInfo.KeJiActitePos == -1? 0
                    : UnionKeJiConfigCategory.Instance.Get(self.UnionMyInfo.UnionKeJiList[self.UnionMyInfo.KeJiActitePos]).NeedTime;

            Match match = Regex.Match(unionKeJiConfig.EquipSpaceName, @"\d");
            self.NameText.GetComponent<Text>().text = unionKeJiConfig.EquipSpaceName.Substring(0, match.Index);
            self.LvText.GetComponent<Text>().text = $"等级：{unionKeJiConfig.QiangHuaLv.ToString()}";
            self.NeedUnionLvText.GetComponent<Text>().text = $"需要家族等级达到{unionKeJiConfig.NeedUnionLv}级";
            self.UIItemComponent.UpdateItem(new BagInfo() { ItemID = 35, ItemNum = unionKeJiConfig.CostUnionGold }, ItemOperateEnum.None);
            self.UIItemComponent.Label_ItemNum.SetActive(false);
            self.CostUnionGoldText.GetComponent<Text>().text = $"消耗家族金币：{unionKeJiConfig.CostUnionGold}";
            self.NeedTimeText.GetComponent<Text>().text = $"研究消耗时间：{unionKeJiConfig.NeedTime / 3600f:0.##}小时";
        }

        public static async ETTask UpdataProgressBar(this UIUnionKeJiResearchComponent self)
        {
            while (!self.IsDisposed)
            {
                if (self.NeedTime == 0)
                {
                    self.ProgressBarImg.fillAmount = 0;
                    self.UnderwayText.SetActive(false);
                }
                else
                {
                    long timeNow = TimeHelper.ServerNow();
                    long passTime = (timeNow - self.UnionMyInfo.KeJiActiteTime) / 1000;
                    if (passTime < self.NeedTime)
                    {
                        self.ProgressBarImg.fillAmount = passTime * 1f / self.NeedTime;
                        self.UnderwayText.SetActive(true);
                    }
                    else
                    {
                        self.ProgressBarImg.fillAmount = 0;
                        self.UnderwayText.SetActive(false);
                    }
                }

                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }

        public static async ETTask OnQuickBtn(this UIUnionKeJiResearchComponent self)
        {
            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(self.UnionMyInfo.UnionKeJiList[self.Position]);
            if (self.UnionMyInfo.KeJiActiteTime == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("没有正在研究的科技！");
                return;
            }

            if (unionKeJiConfig.NextID == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已经达到满级！");
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (!bagComponent.CheckNeedItem("3;200"))
            {
                FloatTipManager.Instance.ShowFloatTip("钻石数量不足！");
                return;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionId = unit.GetUnionId();
            C2U_UnionKeJiQuickRequest request = new C2U_UnionKeJiQuickRequest() { UnionId = unionId, Position = self.Position };
            U2C_UnionKeJiQuickResponse response =
                    (U2C_UnionKeJiQuickResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.UnionMyInfo = response.UnionInfo;
            self.UpdateInfo(self.Position);
        }

        public static async ETTask OnStartBtn(this UIUnionKeJiResearchComponent self)
        {
            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(self.UnionMyInfo.UnionKeJiList[self.Position]);

            long timeNow = TimeHelper.ServerNow();
            long passTime = (timeNow - self.UnionMyInfo.KeJiActiteTime) / 1000;
            if (passTime < unionKeJiConfig.NeedTime)
            {
                FloatTipManager.Instance.ShowFloatTip("有科技正在研究中！");
                return;
            }

            if (unionKeJiConfig.NextID == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已经达到满级！");
                return;
            }

            if (self.UnionMyInfo.UnionGold < unionKeJiConfig.CostUnionGold)
            {
                FloatTipManager.Instance.ShowFloatTip("家族金币不足！");
                return;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionId = unit.GetUnionId();
            C2U_UnionKeJiActiteRequest request = new C2U_UnionKeJiActiteRequest() { UnionId = unionId, Position = self.Position };
            U2C_UnionKeJiActiteResponse response =
                    (U2C_UnionKeJiActiteResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.UnionMyInfo = response.UnionInfo;
            self.UpdateInfo(self.Position);
        }
    }
}