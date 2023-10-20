using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{

    public class UIPetMiningChallengeComponent : Entity, IAwake
    {

        public GameObject RawImage;
        public GameObject ButtonClose;
        public GameObject ButtonConfirm;

        public GameObject Text_ming;
        public GameObject Text_player;
        public GameObject Text_chanchu;

        public GameObject TeamListNode;
        public GameObject DefendTeam;

        public PetMingPlayerInfo PetMingPlayerInfo;

        public List<Image> PetIconList = new List<Image>();
        public List<UIPetMiningChallengeTeamComponent> ChallengeTeamList = new List<UIPetMiningChallengeTeamComponent>();   

        public int MineTpe;
        public int Position;
        public int TeamId;
    }

    public class UIPetMiningChallengeComponentAwake : AwakeSystem<UIPetMiningChallengeComponent>
    {
        public override void Awake(UIPetMiningChallengeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPetMiningChallenge); });

            self.ButtonConfirm = rc.Get<GameObject>("ButtonConfirm");
            ButtonHelp.AddListenerEx(self.ButtonConfirm, () => { self.OnButtonConfirm(); });

            self.RawImage = rc.Get<GameObject>("RawImage");
            self.Text_ming = rc.Get<GameObject>("Text_ming");
            self.Text_player = rc.Get<GameObject>("Text_player");
            self.Text_chanchu = rc.Get<GameObject>("Text_chanchu");
            self.ChallengeTeamList.Clear();

            self.DefendTeam = rc.Get<GameObject>("DefendTeam");
            self.PetIconList.Clear();

            GameObject gameObject_0 = self.DefendTeam.transform.Find($"PetIcon_{0}").gameObject;
            gameObject_0.GetComponent<Button>().onClick.AddListener(() =>{  self.RequestPetInfo(0).Coroutine();  });
            self.PetIconList.Add(gameObject_0.GetComponent<Image>());

            GameObject gameObject_1= self.DefendTeam.transform.Find($"PetIcon_{1}").gameObject;
            gameObject_1.GetComponent<Button>().onClick.AddListener(() => { self.RequestPetInfo(1).Coroutine(); });
            self.PetIconList.Add(gameObject_1.GetComponent<Image>());

            GameObject gameObject_2 = self.DefendTeam.transform.Find($"PetIcon_{2}").gameObject;
            gameObject_2.GetComponent<Button>().onClick.AddListener(() => { self.RequestPetInfo(2).Coroutine(); });
            self.PetIconList.Add(gameObject_2.GetComponent<Image>());

            GameObject gameObject_3 = self.DefendTeam.transform.Find($"PetIcon_{3}").gameObject;
            gameObject_3.GetComponent<Button>().onClick.AddListener(() => { self.RequestPetInfo(3).Coroutine(); });
            self.PetIconList.Add(gameObject_3.GetComponent<Image>());

            GameObject gameObject_4 = self.DefendTeam.transform.Find($"PetIcon_{4}").gameObject;
            gameObject_4.GetComponent<Button>().onClick.AddListener(() => { self.RequestPetInfo(4).Coroutine(); });
            self.PetIconList.Add(gameObject_4.GetComponent<Image>());

            self.TeamId = -1;
            self.TeamListNode = rc.Get<GameObject>("TeamListNode");
            self.ChallengeTeamList.Clear();
            List<int> defendteamids = self.GetSelfPetMingTeam();
            for (int i = 0; i < 3; i++)
            {
                GameObject gameObject = self.TeamListNode.transform.GetChild(i).gameObject;
                UIPetMiningChallengeTeamComponent uIPetMining = self.AddChild<UIPetMiningChallengeTeamComponent, GameObject>(gameObject);
                uIPetMining.SelectHandler = self.OnSelectTeam;
                uIPetMining.TeamId = i;
                uIPetMining.OnUpdateUI(defendteamids.Contains(i));
                self.ChallengeTeamList.Add(uIPetMining);
            }
        }
    }

    public static class UIPetMiningChallengeComponentSystem
    {

        public static async ETTask RequestPetInfo(this UIPetMiningChallengeComponent self, int index)
        {
            if (self.PetMingPlayerInfo == null)
            {
                return;
            }

            long instanceid = self.InstanceId;
            long untiid = self.PetMingPlayerInfo.UnitId;
            long petid = self.PetMingPlayerInfo.PetIdList[index];
            C2F_WatchPetRequest     request     = new C2F_WatchPetRequest() { UnitID = untiid, PetId = petid };
            F2C_WatchPetResponse response = (F2C_WatchPetResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call( request );
            if (instanceid != self.InstanceId)
            {
                return;
            }

            if (response.RolePetInfos == null)
            {
                FloatTipManager.Instance.ShowFloatTip("查看宠物信息出错！");
                return;
            }

            UI uI = await UIHelper.Create( self.ZoneScene(), UIType.UIPetInfo );
            if (instanceid != self.InstanceId)
            {
                return;
            }

            uI.GetComponent<UIPetInfoComponent>().OnUpdateUI(response.RolePetInfos, response.PetHeXinList);
        }

        public static void OnSelectTeam(this UIPetMiningChallengeComponent self, int teamid)
        {
            self.TeamId = teamid;
            for (int i = 0; i < self.ChallengeTeamList.Count; i++)
            {
                self.ChallengeTeamList[i].ImageSelect.SetActive( teamid == i );
            }
        }

        public static List<int> GetSelfPetMingTeam(this UIPetMiningChallengeComponent self)
        {
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIPetSet);
            UIPetMiningComponent petmingComponent = uI.GetComponent<UIPetSetComponent>().UIPageView.UISubViewList[(int)PetSetEnum.PetMining].GetComponent<UIPetMiningComponent>();

            List<int> teamids = new List<int>();    
            List<PetMingPlayerInfo> petMingPlayers = petmingComponent.GetSelfPetMing();
            for (int i = 0; i < petMingPlayers.Count; i++)
            {
                teamids.Add(petMingPlayers[i].TeamId );
            }
            return teamids;
        }

        public static void OnInitUI(this UIPetMiningChallengeComponent self, int mineType, int position, PetMingPlayerInfo petMingPlayerInfo)
        {
          
            self.MineTpe = mineType;
            self.Position = position;   
            MineBattleConfig mineBattleConfig = MineBattleConfigCategory.Instance.Get(mineType);
            self.RawImage.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, mineBattleConfig.Icon);
            self.Text_ming.GetComponent<Text>().text = mineBattleConfig.Name;

            int openDay = ServerHelper.GetOpenServerDay(false, self.DomainZone());
            float coffi = ComHelp.GetMineCoefficient(openDay);
            int chanchu = (int)(mineBattleConfig.GoldOutPut * coffi);


            self.Text_chanchu.GetComponent<Text>().text = $"产出:{chanchu}小时";

            self.PetMingPlayerInfo = petMingPlayerInfo;
            string playerName = string.Empty;  
            List<int> confids = new List<int>();
            if (petMingPlayerInfo != null)
            {
                playerName = $"占领者:{petMingPlayerInfo.PlayerName}";
                confids = petMingPlayerInfo.PetConfig;
            }
            else
            {
                playerName = "占领者:无";
            }
            self.Text_player.GetComponent<Text>().text = playerName;
            for (int i = 0; i< self.PetIconList.Count; i++)
            {
                if (i >= confids.Count || confids[i] == 0)
                {
                    self.PetIconList[i].gameObject.SetActive(false);
                }
                else
                {
                    self.PetIconList[i].gameObject.SetActive(true);
                    PetConfig petConfig = PetConfigCategory.Instance.Get(confids[i]);
                    self.PetIconList[i].sprite = ABAtlasHelp.GetIconSprite(  ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                }
            }
        }

        public static   void OnButtonConfirm(this UIPetMiningChallengeComponent self)
        {
            if (self.TeamId == -1)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择一个队伍！");
                return;
            }

            Scene zoneScene = self.ZoneScene();
            int sceneid = BattleHelper.GetSceneIdByType( SceneTypeEnum.PetMing );
            
            EnterFubenHelp.RequestTransfer(zoneScene, SceneTypeEnum.PetMing, sceneid, self.MineTpe, $"{self.Position}_{self.TeamId}").Coroutine();
            UIHelper.Remove( zoneScene, UIType.UIPetMiningChallenge );
            UIHelper.Remove(zoneScene, UIType.UIPetSet);
        }

    }
}