using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningComponent : Entity, IAwake
    {
        public GameObject ButtonReward_2;

        public GameObject UIPetMiningItem;
        public GameObject PetMiningNode;
        public UIPageButtonComponent UIPageButton;
        public GameObject PetMiningTeamButton;

        public List<PetMingPlayerInfo> PetMingPlayers = new List<PetMingPlayerInfo>();  

        public List<UIPetMiningItemComponent> PetMiningItemList = new List<UIPetMiningItemComponent>();

        public List<Image> TeamIconList = new List<Image>();    
        public List<Text> TeamTipList = new List<Text>();
    }

    public class UIPetMiningComponentAwake : AwakeSystem<UIPetMiningComponent>
    {
        public override void Awake(UIPetMiningComponent self)
        {
            self.PetMiningItemList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIPetMiningItem = rc.Get<GameObject>("UIPetMiningItem");
            self.UIPetMiningItem.SetActive(false);

            self.PetMiningTeamButton = rc.Get<GameObject>("PetMiningTeamButton");
            self.PetMiningTeamButton.GetComponent<Button>().onClick.AddListener(() => { self.OnPetMiningTeamButton().Coroutine();  } );


            self.PetMiningNode = rc.Get<GameObject>("PetMiningNode");

            self.ButtonReward_2 = rc.Get<GameObject>("ButtonReward_2");
            self.ButtonReward_2.GetComponent<Button>().onClick.AddListener(self.OnButtonReward_2);

            self.TeamTipList.Clear();
            self.TeamIconList.Clear();  
            for (int i = 0; i < 3; i++)
            {
                GameObject gamego = rc.Get<GameObject>($"Team_tip_{0}");
                self.TeamTipList.Add(gamego.GetComponent<Text>());

                GameObject gameicon = rc.Get<GameObject>($"PetTeam_{0}");
                self.TeamIconList.Add(gameicon.transform.GetChild(0).gameObject.GetComponent<Image>());
                self.TeamIconList.Add(gameicon.transform.GetChild(1).gameObject.GetComponent<Image>());
                self.TeamIconList.Add(gameicon.transform.GetChild(2).gameObject.GetComponent<Image>());
                self.TeamIconList.Add(gameicon.transform.GetChild(3).gameObject.GetComponent<Image>());
                self.TeamIconList.Add(gameicon.transform.GetChild(4).gameObject.GetComponent<Image>());
            }

           //单选组件
           GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton = uIPageViewComponent;
            self.UIPageButton.ClickEnabled = false;

            self.GetParent<UI>().OnUpdateUI = () => { self.RequestMingList().Coroutine(); };
        }
    }

    public static class UIPetMiningComponentSystem
    {

        public static async ETTask OnPetMiningTeamButton(this UIPetMiningComponent self)
        {
             UI uI =  await UIHelper.Create(self.ZoneScene(), UIType.UIPetMiningTeam);
            uI.GetComponent<UIPetMiningTeamComponent>().UpdateTeam = self.OnUpdateTeam;
        }

        public static void OnUpdateTeam(this UIPetMiningComponent self)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            List<long> teamlist = petComponent.PetMingList;

            for (int i = 0; i < self.TeamTipList.Count; i++)
            {
                int openLv = ConfigHelper.PetMiningTeamOpenLevel[i];
                self.TeamTipList[i].text = $"{openLv}级开启";
                self.TeamTipList[i].gameObject.SetActive(userInfo.Lv <= openLv);
            }
            for (int i = 0; i < self.TeamIconList.Count; i++)
            {
                if (teamlist[i] != 0)
                {
                    RolePetInfo  rolePetInfo = petComponent.GetPetInfoByID(teamlist[i]);
                    self.TeamIconList[i].gameObject.SetActive(true);
                    PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
                    self.TeamIconList[i].sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                }
                else
                {
                    self.TeamIconList[i].gameObject.SetActive(false);
                }
            }
        }

        public static void OnButtonReward_2(this UIPetMiningComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIPetMiningReward).Coroutine();
        }

        public static async ETTask RequestMingList(this UIPetMiningComponent self)
        {
            long intanceid = self.InstanceId;
            C2A_PetMingListRequest request = new C2A_PetMingListRequest() { };
            A2C_PetMingListResponse response = (A2C_PetMingListResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (intanceid != self.InstanceId || response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.PetMingPlayers = response.PetMingPlayerInfos;
            if (self.UIPageButton.CurrentIndex == -1)
            {
                self.UIPageButton.ClickEnabled = true;
                self.UIPageButton.OnSelectIndex(0);
            }
            else
            {
                self.OnClickPageButton(self.UIPageButton.CurrentIndex);
            }
            self.OnUpdateTeam();
        }

        public static PetMingPlayerInfo GetPetMingPlayerInfos(this UIPetMiningComponent self, int mineType, int position)
        {
            for (int i = 0; i < self.PetMingPlayers.Count; i++)
            {
                if (self.PetMingPlayers[i].MineType == mineType && self.PetMingPlayers[i].Postion == position)
                {
                    return self.PetMingPlayers[i];
                }
            }
            return null;
        }

        public static void OnClickPageButton(this UIPetMiningComponent self, int page)
        {
            float maxWidth = 0;
            List<PetMiningItem> miningItems = ConfigHelper.PetMiningList[page + 10001];

            for (int i = 0; i < miningItems.Count; i++)
            {
                UIPetMiningItemComponent uIPetMiningItem = null;
                if ( i < self.PetMiningItemList.Count)
                {
                    uIPetMiningItem = self.PetMiningItemList[i];
                    uIPetMiningItem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject gameObject = GameObject.Instantiate( self.UIPetMiningItem );
                    gameObject.SetActive(true);
                    uIPetMiningItem = self.AddChild<UIPetMiningItemComponent, GameObject>(gameObject);
                    UICommonHelper.SetParent(gameObject, self.PetMiningNode);
                    self.PetMiningItemList.Add(uIPetMiningItem);
                    gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(miningItems[i].X, miningItems[i].Y, 0f);
                }

                maxWidth = miningItems[i].X + 300;
                uIPetMiningItem.OnInitUI(page + 10001, i);
                uIPetMiningItem.OnUpdateUI( self.GetPetMingPlayerInfos(page + 1, i));
            }
            for ( int i= miningItems.Count; i < self.PetMiningItemList.Count; i++ )
            {
                self.PetMiningItemList[i].GameObject.SetActive(false);
            }


            self.PetMiningNode.GetComponent<RectTransform>().sizeDelta = new Vector2(maxWidth, self.PetMiningNode.GetComponent<RectTransform>().sizeDelta.y);
        }
    }
}