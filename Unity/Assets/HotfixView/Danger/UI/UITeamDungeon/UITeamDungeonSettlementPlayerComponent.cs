using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITeamDungeonSettlementPlayerComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_Name;
        public GameObject Text_Level;
        public GameObject Text_Damage;
        public GameObject ItemNode;
        public GameObject GameObject;
    }

    [ObjectSystem]
    public class UITeamDungeonSettlementPlayerComponentAwakeSystem : AwakeSystem<UITeamDungeonSettlementPlayerComponent, GameObject>
    {
        public override void Awake(UITeamDungeonSettlementPlayerComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            self.Text_Name = gameObject.transform.Find("Text_Name").gameObject;
            self.Text_Level = gameObject.transform.Find("Text_Level").gameObject;
            self.Text_Damage = gameObject.transform.Find("Text_Damage").gameObject;
            self.ItemNode = gameObject.transform.Find("ItemNode").gameObject;

            self.ItemNode.SetActive(false);
        }
    }

    public static class UITeamDungeonSettlementPlayerComponentSystem
    {

        public static void OnUpdateUI(this UITeamDungeonSettlementPlayerComponent self, TeamPlayerInfo teamPlayerInfo, List<RewardItem> rewardItems)
        {
            self.Text_Name.GetComponent<Text>().text = teamPlayerInfo.PlayerName;
            self.Text_Level.GetComponent<Text>().text = $"等级：{teamPlayerInfo.PlayerLv}";
            self.Text_Damage.GetComponent<Text>().text = $"伤害：{teamPlayerInfo.Damage}";

            self.ItemNode.SetActive(rewardItems!=null);
            if (rewardItems != null)
            {
                string itemList = $"{rewardItems[0].ItemID};{rewardItems[0].ItemNum}";
                UICommonHelper.ShowItemList(itemList, self.ItemNode, self, 0.6f );
            }
        }

    }
}