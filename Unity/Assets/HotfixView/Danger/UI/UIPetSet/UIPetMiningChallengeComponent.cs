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
            for (int i = 0; i < 5; i++)
            {
                GameObject gameObject = self.DefendTeam.transform.Find($"PetIcon_{i}").gameObject;
                self.PetIconList.Add(gameObject.GetComponent<Image>());
            }

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

        public static void OnSelectTeam(this UIPetMiningChallengeComponent self, int teamid)
        {
            self.TeamId = teamid;
            for (int i = 0; i < self.ChallengeTeamList.Count; i++)
            {
                self.ChallengeTeamList[i].ImageSelect.SetActive( teamid == i );
            }
        }

        public static List<PetMingPlayerInfo> GetSelfPetMing(this UIPetMiningChallengeComponent self)
        {
            long unitid = UnitHelper.GetMyUnitId(self.ZoneScene());
            List<PetMingPlayerInfo> petMingPlayers = new List<PetMingPlayerInfo>();

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIPetSet);
            List<PetMingPlayerInfo> allMingList = uI.GetComponent<UIPetSetComponent>().UIPageView.UISubViewList[(int)PetSetEnum.PetMining].GetComponent<UIPetMiningComponent>().PetMingPlayers;
            for (int i = 0; i < allMingList.Count; i++)
            {
                if (allMingList[i].UnitId == unitid)
                {
                    petMingPlayers.Add(allMingList[i]);
                }
            }
            return petMingPlayers;
        }

        public static List<int> GetSelfPetMingTeam(this UIPetMiningChallengeComponent self)
        {
            List<int> teamids = new List<int>();    
            List<PetMingPlayerInfo> petMingPlayers = self.GetSelfPetMing();
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
            self.Text_chanchu.GetComponent<Text>().text = $"产出:{mineBattleConfig.GoldOutPut}小时";

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