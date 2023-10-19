using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningRewardComponent : Entity, IAwake
    {
        public GameObject ImageClose;

        public GameObject BuildingList2;
        public GameObject UIPetMiningRewardItem;

        public List<UIPetMiningRewardItemComponent> RewardItemList = new List<UIPetMiningRewardItemComponent>();
    }

    public class UIPetMiningRewardComponentAwake : AwakeSystem<UIPetMiningRewardComponent>
    {
        public override void Awake(UIPetMiningRewardComponent self)
        {
            self.RewardItemList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ImageClose = rc.Get<GameObject>("ImageClose");
            self.ImageClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetMiningReward );  });

            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");
            self.UIPetMiningRewardItem = rc.Get<GameObject>("UIPetMiningRewardItem");
            self.UIPetMiningRewardItem.SetActive(false);

            self.OnInitUI();
        }
    }

    public static class UIPetMiningRewardComponentSystem
    {
        public static void OnInitUI(this UIPetMiningRewardComponent self)
        {
            Dictionary<int, string> keyValuePairs = ConfigHelper.PetMiningReward;
            foreach (var item in keyValuePairs)
            {
                GameObject gameObject = GameObject.Instantiate( self.UIPetMiningRewardItem);
                gameObject.SetActive(true);
                UICommonHelper.SetParent(gameObject, self.BuildingList2);

                UIPetMiningRewardItemComponent uIPetMining = self.AddChild<UIPetMiningRewardItemComponent, GameObject>(gameObject);
                uIPetMining.OnInitUI( item.Key, item.Value );
                self.RewardItemList.Add(uIPetMining);   
            }
        }
    }
}