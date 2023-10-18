using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
    public class UIPetMiningItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;

        public GameObject ImageIcon;
        public GameObject TextPlayer;
        public Image[] PetIconList = new Image[5];
        public GameObject[] PetDiList = new GameObject[5];

        public PetMingPlayerInfo PetMingPlayerInfo;

        public int MineType;
        public int Position;
    }

    public class UIPetMiningItemComponentAwake : AwakeSystem<UIPetMiningItemComponent, GameObject>
    {
        public override void Awake(UIPetMiningItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.TextPlayer = rc.Get<GameObject>("TextPlayer");

            self.ImageIcon.GetComponent<Button>().onClick.AddListener(() => { self.OnImageIcon().Coroutine(); });

            for (int i = 0; i < self.PetIconList.Length; i++)
            {
                self.PetIconList[i] = rc.Get<GameObject>($"Pet_{i}").transform.Find("Icon").GetComponent<Image>();
            }
        }
    }

    public static class UIPetMiningItemComponentSystem
    {

        public static async ETTask OnImageIcon(this UIPetMiningItemComponent self)
        {
            UI uI = await UIHelper.Create( self.ZoneScene(), UIType.UIPetMiningChallenge );
            uI.GetComponent<UIPetMiningChallengeComponent>().OnInitUI( self.MineType, self.Position, self.PetMingPlayerInfo );
        }

        public static void OnInitUI(this UIPetMiningItemComponent self, int mingType, int index)
        { 
            self.MineType = mingType;   
            self.Position = index;

            MineBattleConfig mineBattleConfig = MineBattleConfigCategory.Instance.Get(mingType);   
            self.ImageIcon.GetComponent<Image>().sprite =  ABAtlasHelp.GetIconSprite( ABAtlasTypes.OtherIcon, mineBattleConfig.Icon);
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
            }
            else
            {
                playerName = "占领者：无";
            }

            self.TextPlayer.GetComponent<Text>().text = playerName;
            for (int i = 0; i < self.PetIconList.Length; i++)
            {
                if ( i >= confids.Count || confids[i] == 0)
                {
                    self.PetIconList[i].gameObject.SetActive(false);
                }
                else
                {
                    self.PetIconList[i].gameObject.SetActive(true);
                    PetConfig petConfig = PetConfigCategory.Instance.Get(confids[i]);
                    self.PetIconList[i].sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                }
            }
        }
    }

}