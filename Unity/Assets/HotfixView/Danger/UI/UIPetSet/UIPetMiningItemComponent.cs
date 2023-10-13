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

            for (int i = 0; i < self.PetIconList.Length; i++)
            {
                self.PetIconList[i] = rc.Get<GameObject>($"Pet_{i}").GetComponent<Image>();
            }
        }
    }

    public static class UIPetMiningItemComponentSystem
    {
        public static void OnInitUI(this UIPetMiningItemComponent self, int mingType, int index)
        { 
            self.MineType = mingType;   
            self.Position = index;

            MineBattleConfig mineBattleConfig = MineBattleConfigCategory.Instance.Get(mingType);   
            ABAtlasHelp.GetIconSprite( ABAtlasTypes.OtherIcon, mineBattleConfig.Icon);
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
            if (petMingPlayerInfo == null)
            {
                self.TextPlayer.GetComponent<Text>().text = "占领者:无";
            }
        }
    }

}