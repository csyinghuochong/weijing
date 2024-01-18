using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
    public class UITeamDungeonCreateComponent : Entity, IAwake,IDestroy
    {
        public GameObject DungeonImg;
        public GameObject ShenYuanButton;
        public GameObject ShenYuanMode;
        public GameObject Button_XieZhu;
        public GameObject ShenYuan;
        public GameObject CloseButton;
        public GameObject ItemNodeList;
        public GameObject TextLevelLimit;
        public GameObject TextPlayerLimit;
        public GameObject TextFubenDesc;
        public GameObject TextFubenName2;
        public GameObject Button_Create;

        public int FubenId;
        public List<int> FubenIdList = new List<int>() { };
        public List<Transform> ButtonList = new List<Transform>();
        public List<string> AssetPath = new List<string>();
    }


    public class UITeamDungeonCreateComponentAwakeSystem : AwakeSystem<UITeamDungeonCreateComponent>
    {

        public override void Awake(UITeamDungeonCreateComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.DungeonImg = rc.Get<GameObject>("DungeonImg");
            self.ShenYuan = rc.Get<GameObject>("ShenYuan");
            self.Button_XieZhu = rc.Get<GameObject>("Button_XieZhu");
            ButtonHelp.AddListenerEx(self.Button_XieZhu, () => { self.OnButton_Create(TeamFubenType.XieZhu).Coroutine(); });
            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
            self.TextLevelLimit = rc.Get<GameObject>("TextLevelLimit");
            self.TextPlayerLimit = rc.Get<GameObject>("TextPlayerLimit");
            self.TextFubenDesc = rc.Get<GameObject>("TextFubenDesc");
            self.TextFubenName2 = rc.Get<GameObject>("TextFubenName2");
            self.Button_Create = rc.Get<GameObject>("Button_Create");
            self.CloseButton = rc.Get<GameObject>("CloseButton");
            ButtonHelp.AddListenerEx(self.Button_Create, () => { self.OnButton_Create(TeamFubenType.Normal).Coroutine(); });

            self.ShenYuanButton = rc.Get<GameObject>("ShenYuanButton");
            self.ShenYuanMode = rc.Get<GameObject>("ShenYuanMode");
            ButtonHelp.AddListenerEx(self.ShenYuanButton, () => { self.OnShenYuanMode(); });

            self.FubenIdList.Clear();
            self.ButtonList.Clear();

            GameObject TeamdungeonItem = rc.Get<GameObject>("TeamdungeonItem");
            GameObject TeamdungeonList = rc.Get<GameObject>("TeamdungeonList");
            TeamdungeonItem.SetActive(false);
            List<SceneConfig> sceneConfig = SceneConfigCategory.Instance.GetAll().Values.ToList();
            AccountInfoComponent accountInfoComponent1 = self.ZoneScene().GetComponent<AccountInfoComponent>();
            bool isGmaccount = GMHelp.GmAccount.Contains(accountInfoComponent1.Account);
            for (int i = 0; i < sceneConfig.Count; i++)
            {
                if (sceneConfig[i].MapType != (int)SceneTypeEnum.TeamDungeon)
                {
                    continue;
                }

                if (!isGmaccount && sceneConfig[i].Id >= ConfigHelper.GmTeamdungeonId)
                {
                    continue;
                }

                self.FubenIdList.Add(sceneConfig[i].Id);
                GameObject item = GameObject.Instantiate(TeamdungeonItem);
                UICommonHelper.SetParent(item, TeamdungeonList);
                item.SetActive(true);
                self.ButtonList.Add(item.transform);

                //更新显示
                ReferenceCollector rcSon = item.GetComponent<ReferenceCollector>();
                //rcSon.Get<GameObject>("Img_Show");
                rcSon.Get<GameObject>("Lab_Lv").GetComponent<Text>().text = "进入等级:" + sceneConfig[i].EnterLv.ToString() + "级";
                rcSon.Get<GameObject>("Lab_Name").GetComponent<Text>().text = sceneConfig[i].Name;

                string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.TiTleIcon, sceneConfig[i].Icon);
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }
                rcSon.Get<GameObject>("Img_Show").GetComponent<Image>().sprite = sp;


                item.GetComponent<Button>().onClick.AddListener(() =>
                {
                    self.OnClickButton(item.transform);
                });
            }

            self.OnClickButton(self.ButtonList[0]);

            self.Button_XieZhu.SetActive(true);
            self.ShenYuan.SetActive(true);
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UITeamDungeonCreate); });
        }
    }
    public class UITeamDungeonCreateComponentDestroy: DestroySystem<UITeamDungeonCreateComponent>
    {
        public override void Destroy(UITeamDungeonCreateComponent self)
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
    public static class UITeamDungeonCreateComponentSystem
    {
        public static void OnClickButton(this UITeamDungeonCreateComponent self, Transform transform)
        {
            int index = self.ButtonList.IndexOf(transform);
            for (int i = 0; i < self.ButtonList.Count; i++)
            {
                self.ButtonList[i].Find("ImageSelect").gameObject.SetActive(i == index);
            }
            self.OnUpdatUI(self.FubenIdList[index]);
        }

        public static void OnUpdatUI(this UITeamDungeonCreateComponent self, int fubenId)
        {
            self.FubenId = fubenId;
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(fubenId);
            UICommonHelper.DestoryChild(self.ItemNodeList);

            int bossId = sceneConfig.BossId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(bossId);
            List<RewardItem> allRewardItems = new List<RewardItem>();
            for (int i = 0; i < monsterConfig.DropID.Length; i++)
            {
                if (monsterConfig.DropID[i]!= 0)
                {
                    allRewardItems.AddRange(DropHelper.DropIDToShowItem(monsterConfig.DropID[i], 4));
                }
            }
            allRewardItems.AddRange(ItemHelper.GetRewardItems(sceneConfig.RewardShow));

            List<RewardItem> rewardItems = new List<RewardItem>();
            for (int i = allRewardItems.Count - 1; i >= 0; i--)
            {
                bool have = false;
                RewardItem rewardItem = allRewardItems[i];
                for (int k = 0; k< rewardItems.Count; k++  )
                {
                    if (rewardItems[k].ItemID == rewardItem.ItemID)
                    {
                        have = true;
                        break;
                    }
                }
                if (have)
                {
                    continue;
                }
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(allRewardItems[i].ItemID);
                if (itemConfig.ItemQuality < 4)
                {
                    continue;
                }
                rewardItems.Add(rewardItem);
            }

            UICommonHelper.ShowItemList(rewardItems, self.ItemNodeList, self, 1f);
            self.TextLevelLimit.GetComponent<Text>().text = sceneConfig.EnterLv.ToString();
            self.TextPlayerLimit.GetComponent<Text>().text = $"{sceneConfig.PlayerLimit}-3人";
            self.TextFubenDesc.GetComponent<Text>().text = sceneConfig.ChapterDes;
            self.TextFubenName2.GetComponent<Text>().text = sceneConfig.Name;
            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.TiTleIcon, sceneConfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.DungeonImg.GetComponent<Image>().sprite = sp;
        }

        public static void OnButton_Close(this UITeamDungeonCreateComponent self)
        {
            UIHelper.Remove( self.DomainScene(), UIType.UITeamDungeonCreate );
        }

        public static void OnShenYuanMode(this UITeamDungeonCreateComponent self)
        {
            self.ShenYuanMode.SetActive(!self.ShenYuanMode.activeSelf);
        }

        public static async ETTask OnButton_Create(this UITeamDungeonCreateComponent self, int dungeonType)
        {
            bool shenyuan = self.ShenYuanMode.activeSelf;
            if (dungeonType == TeamFubenType.Normal && shenyuan)
            {
                BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                if (bagComponent.GetItemNumber(ComHelp.ShenYuanCostId) < 1)
                {
                    FloatTipManager.Instance.ShowFloatTip($"需要道具{ItemConfigCategory.Instance.Get(ComHelp.ShenYuanCostId).ItemName}！");
                    return;
                }
                dungeonType = TeamFubenType.ShenYuan;
            }

            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(self.FubenId);
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (dungeonType == TeamFubenType.XieZhu && sceneConfig.EnterLv <= userInfo.Lv - 10)
            {
                int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
                int times = unit.GetTeamDungeonTimes();

                int totalTimes_2 = int.Parse(GlobalValueConfigCategory.Instance.Get(74).Value);
                int times_2 = unit.GetTeamDungeonXieZhu();

                if (totalTimes - times > 0 && totalTimes_2 - times_2 <= 0)
                {
                    PopupTipHelp.OpenPopupTip(self.ZoneScene(), "系统提示", $"帮助副本次数已尽，开启副本会消耗正常次数", async () =>
                    {
                        int errorCode = await self.ZoneScene().GetComponent<TeamComponent>().RequestTeamDungeonCreate(self.FubenId, dungeonType);
                        if (errorCode != ErrorCode.ERR_Success)
                        {
                            ErrorHelp.Instance.ErrorHint(errorCode);
                            return;
                        }

                        UI ui = UIHelper.GetUI(self.DomainScene(), UIType.UITeamDungeon);
                        ui.GetComponent<UITeamDungeonComponent>().UIPageButtonComponent_1.OnSelectIndex(1);
                        UIHelper.Remove(self.DomainScene(), UIType.UITeamDungeonCreate);
                    }, null).Coroutine();
                    return;
                }
            }

            int errorCode = await self.ZoneScene().GetComponent<TeamComponent>().RequestTeamDungeonCreate(self.FubenId, dungeonType);
            if (errorCode != ErrorCode.ERR_Success)
            {
                ErrorHelp.Instance.ErrorHint(errorCode);
                return;
            }

            UI ui = UIHelper.GetUI( self.DomainScene(), UIType.UITeamDungeon );
            ui.GetComponent<UITeamDungeonComponent>().UIPageButtonComponent_1.OnSelectIndex(1);
            UIHelper.Remove( self.DomainScene(), UIType.UITeamDungeonCreate );
        }

    }
}