using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
    public class UITeamDungeonCreateComponent : Entity, IAwake
    {
        public GameObject ShenYuanButton;
        public GameObject ShenYuanMode;
        public GameObject Button_XieZhu;
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
    }

    [ObjectSystem]
    public class UITeamDungeonCreateComponentAwakeSystem : AwakeSystem<UITeamDungeonCreateComponent>
    {

        public override void Awake(UITeamDungeonCreateComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

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
            for (int i = 0; i < sceneConfig.Count; i++)
            {
                if (sceneConfig[i].MapType != (int)SceneTypeEnum.TeamDungeon)
                {
                    continue;
                }
                self.FubenIdList.Add(sceneConfig[i].Id);
                GameObject item = GameObject.Instantiate(TeamdungeonItem);
                UICommonHelper.SetParent(item, TeamdungeonList);
                item.SetActive(false);
                self.ButtonList.Add(item.transform);

                //更新显示
                ReferenceCollector rcSon = item.GetComponent<ReferenceCollector>();
                //rcSon.Get<GameObject>("Img_Show");
                rcSon.Get<GameObject>("Lab_Lv").GetComponent<Text>().text = "进入等级:" + sceneConfig[i].EnterLv.ToString() + "级";
                rcSon.Get<GameObject>("Lab_Name").GetComponent<Text>().text = sceneConfig[i].Name;

                Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.TiTleIcon, sceneConfig[i].Icon);
                rcSon.Get<GameObject>("Img_Show").GetComponent<Image>().sprite = sp;


                item.GetComponent<Button>().onClick.AddListener(() =>
                {
                    self.OnClickButton(item.transform);
                });
            }

            self.OnClickButton(self.ButtonList[0]);

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            self.Button_XieZhu.SetActive(true);
            //self.Button_XieZhu.SetActive(GMHelp.GmAccount.Contains(accountInfoComponent.Account));
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UITeamDungeonCreate); });
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
            SceneConfig teamDungeonConfig = SceneConfigCategory.Instance.Get(fubenId);
            UICommonHelper.DestoryChild(self.ItemNodeList);

            int bossId = teamDungeonConfig.BossId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(bossId);
            List<RewardItem> allRewardItems = new List<RewardItem>();
            for (int i = 0; i < monsterConfig.DropID.Length; i++)
            {
                if (monsterConfig.DropID[i]!= 0)
                {
                    allRewardItems.AddRange(DropHelper.DropIDToShowItem(monsterConfig.DropID[i], 4));
                }
            }
            allRewardItems.AddRange(ItemHelper.GetRewardItems(teamDungeonConfig.RewardShow));

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
            self.TextLevelLimit.GetComponent<Text>().text = teamDungeonConfig.EnterLv.ToString();
            self.TextPlayerLimit.GetComponent<Text>().text = $"{teamDungeonConfig.PlayerLimit}-3人";
            self.TextFubenDesc.GetComponent<Text>().text = teamDungeonConfig.ChapterDes;
            self.TextFubenName2.GetComponent<Text>().text = teamDungeonConfig.Name;
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
                    FloatTipManager.Instance.ShowFloatTip("道具不足！");
                    return;
                }
                dungeonType = TeamFubenType.ShenYuan;
            }

            int errorCode = await self.ZoneScene().GetComponent<TeamComponent>().RequestTeamDungeonCreate(self.FubenId, dungeonType);
            if (errorCode != ErrorCore.ERR_Success)
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