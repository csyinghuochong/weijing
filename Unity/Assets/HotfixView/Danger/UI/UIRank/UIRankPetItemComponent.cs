using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRankPetItemComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject Lab_Owner;
        public GameObject Lab_TeamName;
        public GameObject Lab_PaiMing;
        public GameObject[] ImageIconList;
        public GameObject ImageIcon2;
        public GameObject ImageIcon1;
        public GameObject Btn_PVP;
        public GameObject GameObject;

        public RankPetInfo RankPetInfo;

        public List<long> PetIdList = new List<long>(); 
        public List<string> AssetPath = new List<string>();
    }


    public class UIRankPetItemComponentAwakeSystem : AwakeSystem<UIRankPetItemComponent, GameObject>
    {
        public override void Awake(UIRankPetItemComponent self, GameObject gameObject)
        {
            self.GameObject  = gameObject;  
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            
            self.Lab_Owner = rc.Get<GameObject>("Lab_Owner");
            self.Lab_TeamName = rc.Get<GameObject>("Lab_TeamName");
            self.Lab_PaiMing = rc.Get<GameObject>("Lab_PaiMing");

            self.ImageIconList = new GameObject[5];
            self.ImageIconList[4] = rc.Get<GameObject>("ImageIcon5");
            self.ImageIconList[3] = rc.Get<GameObject>("ImageIcon4");
            self.ImageIconList[2] = rc.Get<GameObject>("ImageIcon3");
            self.ImageIconList[1] = rc.Get<GameObject>("ImageIcon2");
            self.ImageIconList[0] = rc.Get<GameObject>("ImageIcon1");
            self.ImageIconList[4].GetComponent<Button>().onClick.AddListener(() => { self.OnImageIconList(4).Coroutine(); });
            self.ImageIconList[3].GetComponent<Button>().onClick.AddListener(() => { self.OnImageIconList(3).Coroutine(); });
            self.ImageIconList[2].GetComponent<Button>().onClick.AddListener(() => { self.OnImageIconList(2).Coroutine(); });
            self.ImageIconList[1].GetComponent<Button>().onClick.AddListener(() => { self.OnImageIconList(1).Coroutine(); });
            self.ImageIconList[0].GetComponent<Button>().onClick.AddListener(() => { self.OnImageIconList(0).Coroutine(); });

            self.Btn_PVP = rc.Get<GameObject>("Btn_PVP");
            ButtonHelp.AddListenerEx(self.Btn_PVP, () => { self.OnClickBtn_PVP(); });
        }
    }
    public class UIRankPetItemComponentDestroy: DestroySystem<UIRankPetItemComponent>
    {
        public override void Destroy(UIRankPetItemComponent self)
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
    public static class UIRankPetItemComponentSystem
    {

        public static async ETTask OnImageIconList(this UIRankPetItemComponent self, int index)
        {
            if (self.RankPetInfo == null)
            {
                return;
            }
            if (self.PetIdList.Count <= index)
            {
                return;
            }
            long petid = self.PetIdList[index];
            if (petid == 0)
            {
                return;
            }
            long instanceid = self.InstanceId;
            long untiid = self.RankPetInfo.UserId;
            C2F_WatchPetRequest request = new C2F_WatchPetRequest() { UnitID = untiid, PetId = petid };
            F2C_WatchPetResponse response = (F2C_WatchPetResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            if (response.RolePetInfos == null)
            {
                return;
            }

            UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIPetInfo);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            uI.GetComponent<UIPetInfoComponent>().OnUpdateUI(response.RolePetInfos, response.PetHeXinList);
        }

        public static void OnInitUI(this UIRankPetItemComponent self, RankPetInfo rankPetInfo)
        {
            self.RankPetInfo = rankPetInfo;
            if (!ComHelp.IfNull(rankPetInfo.TeamName))
            {
                self.Lab_TeamName.GetComponent<Text>().text = rankPetInfo.TeamName;
                self.Lab_Owner.GetComponent<Text>().text = "";
            }
            else
            {
                self.Lab_TeamName.GetComponent<Text>().text = rankPetInfo.PlayerName + "的队伍";
                self.Lab_Owner.GetComponent<Text>().text = rankPetInfo.PlayerName;
            }

            int number = 0;
            self.PetIdList.Clear();
            for (int i = 0; i < rankPetInfo.PetConfigId.Count; i++ )
            {
                if (rankPetInfo.PetConfigId[i] == 0 || number>=3)
                {
                    continue;
                }

                PetConfig petConfig = PetConfigCategory.Instance.Get(rankPetInfo.PetConfigId[i]);
                string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }
                self.ImageIconList[number].SetActive(true);
                self.ImageIconList[number].GetComponent<Image>().sprite = sp;
                self.Lab_PaiMing.GetComponent<Text>().text = rankPetInfo.RankId.ToString();
                self.PetIdList.Add(rankPetInfo.PetUId[i]);
                number++;
            }
            for (int i = number; i < 5; i++)
            {
                self.ImageIconList[i].SetActive(false);
            }
        }

        public static void OnClickBtn_PVP(this UIRankPetItemComponent self)
        {
            int teamNumber = 0;
            List<long> teamList = self.ZoneScene().GetComponent<PetComponent>().TeamPetList;
            for (int i = 0; i < teamList.Count; i++)
            {
                teamNumber += (teamList[i] != 0 ? 1 : 0);
            }
            if (teamNumber < 3)
            {
                FloatTipManager.Instance.ShowFloatTip("上阵宠物不足三只!");
                return;
            }

            EnterFubenHelp.RequestTransfer(self.DomainScene(), (int)SceneTypeEnum.PetTianTi, BattleHelper.GetPetTianTiId(),  0, self.RankPetInfo.UserId.ToString()).Coroutine();
            UIHelper.Remove( self.DomainScene(), UIType.UIRank);
        }

    }
}
