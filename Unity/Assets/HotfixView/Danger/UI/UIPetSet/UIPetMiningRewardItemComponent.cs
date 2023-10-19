using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningRewardItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageReceived;
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
            self.ImageReceived = a.transform.Find("ImageReceived").gameObject;

            ButtonHelp.AddListenerEx( self.ButtonReward, () => { self.OnButtonReward().Coroutine();  }  );
        }
    }

    public static class UIPetMiningRewardItemComponentSystem
    {

        public static async ETTask OnButtonReward(this UIPetMiningRewardItemComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.PetMingRewards.Contains( self.Number ))
            {
                FloatTipManager.Instance.ShowFloatTip("已领取！");
                return;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int petNumber = unit.GetComponent<NumericComponent>().GetAsInt( NumericType.PetMineNumber );
            if (petNumber < self.Number)
            {
                FloatTipManager.Instance.ShowFloatTip("条件不足！");
                return;
            }

            long instanceid = self.InstanceId;
            int errorcode = await NetHelper.RequestPetMingReward(self.ZoneScene(), self.Number);
            if (instanceid!= self.InstanceId)
            {
                return;
            }

            self.ImageReceived.SetActive(true);
            self.ButtonReward.SetActive(false);  
        }

        public static void OnInitUI(this UIPetMiningRewardItemComponent self, int number, string reward)
        {
            self.Number = number;
            UICommonHelper.ShowItemList(reward, self.ItemListNode, self, 0.6f);

            self.Text_tip.GetComponent<Text>().text = $"挑战次数达到{number}次";

            bool received = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.PetMingRewards.Contains((self.Number));
            self.ImageReceived.SetActive(received);
            self.ButtonReward.SetActive(!received);
        }
    }

}