using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningComponent : Entity, IAwake
    {

        public GameObject Text_Chanchu_2;
        public GameObject Text_Chanchu_1;
        public GameObject UIPetOccupyItem;

        public GameObject ButtonReward;
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

            self.UIPetOccupyItem = rc.Get<GameObject>("UIPetOccupyItem");
            self.UIPetOccupyItem.SetActive(false);

            self.ButtonReward_2 = rc.Get<GameObject>("ButtonReward_2");
            self.ButtonReward_2.GetComponent<Button>().onClick.AddListener(self.OnButtonReward_2);

            self.ButtonReward = rc.Get<GameObject>("ButtonReward");
            ButtonHelp.AddListenerEx( self.ButtonReward, ()=> {   }  );

            self.Text_Chanchu_1 = rc.Get<GameObject>("Text_Chanchu_1");
            self.Text_Chanchu_2 = rc.Get<GameObject>("Text_Chanchu_2");

            self.TeamTipList.Clear();
            self.TeamIconList.Clear();  
            for (int i = 0; i < 3; i++)
            {
                GameObject gamego = rc.Get<GameObject>($"Team_tip_{i}");
                self.TeamTipList.Add(gamego.GetComponent<Text>());

                GameObject gameicon = rc.Get<GameObject>($"PetTeam_{i}");
                self.TeamIconList.Add(gameicon.transform.GetChild(0).Find("Icon").GetComponent<Image>());
                self.TeamIconList.Add(gameicon.transform.GetChild(1).Find("Icon").GetComponent<Image>());
                self.TeamIconList.Add(gameicon.transform.GetChild(2).Find("Icon").GetComponent<Image>());
                self.TeamIconList.Add(gameicon.transform.GetChild(3).Find("Icon").GetComponent<Image>());
                self.TeamIconList.Add(gameicon.transform.GetChild(4).Find("Icon").GetComponent<Image>());
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
                self.TeamTipList[i].gameObject.SetActive(openLv > userInfo.Lv);
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

        public static async void OnButtonReward(this UIPetMiningComponent self)
        {
            long instanceid = self.InstanceId;
            C2A_PetMingChanChuRequest   request = new C2A_PetMingChanChuRequest();
            A2C_PetMingChanChuResponse respone = (A2C_PetMingChanChuResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (instanceid != self.InstanceId)
            {
                return;
            }
            self.Text_Chanchu_2.GetComponent<Text>().text = string.Empty;
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
            self.Text_Chanchu_2.GetComponent<Text>().text = response.ChanChu.ToString();
            self.OnUpdateTeam();
            self.UpdateMyMine();
        }

        public static void UpdateMyMine(this UIPetMiningComponent self)
        {
            int chatchun = 0;

            UICommonHelper.DestoryChild( self.UIPetOccupyItem.gameObject );
            List<PetMingPlayerInfo> petMingPlayers = self.GetSelfPetMing();
            for ( int i = 0; i < petMingPlayers.Count; i++ )
            {
                GameObject gameObject = GameObject.Instantiate(self.UIPetOccupyItem);
                gameObject.SetActive(true);
                UICommonHelper.SetParent( gameObject, self.UIPetOccupyItem.transform.gameObject );  
                Image Image_ItemIcon = gameObject.transform.Find("Image_ItemIcon").GetComponent<Image>();

                MineBattleConfig mineBattleConfig = MineBattleConfigCategory.Instance.Get(petMingPlayers[i].MineType);
                Image_ItemIcon.sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, mineBattleConfig.Icon);

                chatchun += mineBattleConfig.GoldOutPut;
            }

            self.Text_Chanchu_1.GetComponent<Text>().text = $"{chatchun}/小时";
        }

        public static List<PetMingPlayerInfo> GetSelfPetMing(this UIPetMiningComponent self)
        {
            long unitid = UnitHelper.GetMyUnitId(self.ZoneScene());
            List<PetMingPlayerInfo> petMingPlayers = new List<PetMingPlayerInfo>();

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIPetSet);
            List<PetMingPlayerInfo> allMingList = self.PetMingPlayers;
            for (int i = 0; i < allMingList.Count; i++)
            {
                if (allMingList[i].UnitId == unitid)
                {
                    petMingPlayers.Add(allMingList[i]);
                }
            }
            return petMingPlayers;
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
            int mineType = page + 10001;
            List<PetMiningItem> miningItems = ConfigHelper.PetMiningList[mineType];

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
                uIPetMiningItem.OnInitUI(mineType, i);
                uIPetMiningItem.OnUpdateUI( self.GetPetMingPlayerInfos(mineType, i));
            }
            for ( int i= miningItems.Count; i < self.PetMiningItemList.Count; i++ )
            {
                self.PetMiningItemList[i].GameObject.SetActive(false);
            }


            self.PetMiningNode.GetComponent<RectTransform>().sizeDelta = new Vector2(maxWidth, self.PetMiningNode.GetComponent<RectTransform>().sizeDelta.y);
        }
    }
}