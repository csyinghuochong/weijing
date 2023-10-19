using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningRewardItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject ItemListNode;
        public GameObject ButtonReward;
        public GameObject Text_tip;

        public int Number;
    }

    public class UIPetMiningRewardItemComponentAwake : AwakeSystem<UIPetMiningRewardItemComponent, GameObject>
    {
        public override void Awake(UIPetMiningRewardItemComponent self, GameObject a)
        {
            self.GameObject = a;

            self.ItemListNode = a.transform.Find("ItemListNode").gameObject;
            self.ButtonReward = a.transform.Find("ButtonReward").gameObject;
            self.Text_tip = a.transform.Find("Text_tip").gameObject;

            ButtonHelp.AddListenerEx( self.ButtonReward, () => { self.OnButtonReward().Coroutine();  }  );
        }
    }

    public static class UIPetMiningRewardItemComponentSystem
    {

        public static async ETTask OnButtonReward(this UIPetMiningRewardItemComponent self)
        {


            await ETTask.CompletedTask;
        }

        public static void OnInitUI(this UIPetMiningRewardItemComponent self, int number, string reward)
        {
            UICommonHelper.ShowItemList(reward, self.ItemListNode, self, 0.6f);

            self.Text_tip.GetComponent<Text>().text = $"挑战次数达到{number}次";
        }


    }

}