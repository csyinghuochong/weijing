using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetMiningItemComponent : Entity, IAwake<GameObject>,IDestroy
    {

        public GameObject TextChanChu;
        public GameObject ImHeXinShow;
        public GameObject PetList;
        public GameObject GameObject;
        public GameObject TextMine;

        public GameObject ImageIcon;
        public GameObject TextPlayer;
        public Image[] PetIconList = new Image[5];
        public GameObject[] PetDiList = new GameObject[5];

        public PetMingPlayerInfo PetMingPlayerInfo;

        public int MineType;
        public int Position;
        
        public List<string> AssetPath = new List<string>();
    }

    public class UIPetMiningItemComponentAwake : AwakeSystem<UIPetMiningItemComponent, GameObject>
    {
        public override void Awake(UIPetMiningItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.TextPlayer = rc.Get<GameObject>("TextPlayer");

            self.PetList = rc.Get<GameObject>("PetList");

            self.TextMine = rc.Get<GameObject>("TextMine");

            self.ImHeXinShow = rc.Get<GameObject>("ImHeXinShow");

            self.ImageIcon.GetComponent<Button>().onClick.AddListener(() => { self.OnImageIcon().Coroutine(); });

            self.TextChanChu = rc.Get<GameObject>("TextChanChu");

            for (int i = 0; i < self.PetIconList.Length; i++)
            {
                self.PetIconList[i] = self.PetList.transform.GetChild(i).Find("Icon").GetComponent<Image>();
            }
        }
    }
    public class UIPetMiningItemComponentDestroy : DestroySystem<UIPetMiningItemComponent>
    {
        public override void Destroy(UIPetMiningItemComponent self)
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
    public static class UIPetMiningItemComponentSystem
    {

        public static async ETTask OnImageIcon(this UIPetMiningItemComponent self)
        {
            UI uI = await UIHelper.Create( self.ZoneScene(), UIType.UIPetMiningChallenge );
            uI.GetComponent<UIPetMiningChallengeComponent>().OnInitUI( self.MineType, self.Position, self.PetMingPlayerInfo );
        }

        public static void OnInitUI(this UIPetMiningItemComponent self, int mingType, int index,  bool hexin, List<KeyValuePairInt> petMineExtend)
        { 
            self.MineType = mingType;   
            self.Position = index;
            self.ImHeXinShow.SetActive( hexin);
            MineBattleConfig mineBattleConfig = MineBattleConfigCategory.Instance.Get(mingType);   
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, mineBattleConfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ImageIcon.GetComponent<Image>().sprite = sp;

            self.TextMine.GetComponent<Text>().text = mineBattleConfig.Name + (hexin ? "(核心矿)": string.Empty);

            int zone = self.ZoneScene().GetComponent<AccountInfoComponent>().ServerId;
            int openDay = ServerHelper.GetOpenServerDay(false, zone);
            float coffi = ComHelp.GetMineCoefficient(openDay, mingType, index, petMineExtend);
            int chanchu = (int)(mineBattleConfig.GoldOutPut * coffi);
            self.TextChanChu.GetComponent<Text>().text = $"{chanchu}/小时";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="mingType">矿场类型</param>
        /// <param name="index">矿场序号</param>
        /// <param name="petMingPlayerInfo">占领者</param>
        public static void OnUpdateUI(this UIPetMiningItemComponent self,  PetMingPlayerInfo petMingPlayerInfo)
        {
            self.PetMingPlayerInfo = petMingPlayerInfo;     

            string playerName = string.Empty;
            List<int> confids = new List<int>();

            if (petMingPlayerInfo != null)
            {
                playerName = "占领者：" + petMingPlayerInfo.PlayerName;
                confids = petMingPlayerInfo.PetConfig;

                for (int i = 0; i < self.PetIconList.Length; i++)
                {
                    if (confids[i] == 0)
                    {
                        self.PetIconList[i].gameObject.SetActive(false);
                    }
                    else
                    {
                        self.PetIconList[i].gameObject.SetActive(true);
                        PetConfig petConfig = PetConfigCategory.Instance.Get(confids[i]);
                        string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                        Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                        if (!self.AssetPath.Contains(path))
                        {
                            self.AssetPath.Add(path);
                        }
                        self.PetIconList[i].sprite = sp;
                    }
                }
            }
            else
            {
                playerName = "占领者：无";
                for (int i = 0; i < self.PetIconList.Length; i++)
                {
                    self.PetIconList[i].gameObject.SetActive(false);
                }
            }

            self.TextPlayer.GetComponent<Text>().text = playerName;
        }
    }

}