using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEggChouKaRewardComponent: Entity, IAwake
    {
        public GameObject TextTitle;
        public GameObject Btn_Close;
        public GameObject RewardListNode;
        public GameObject UIChouKaRewardItem;
    }

    public class UIPetEggChouKaRewardComponentAwakeSystem: AwakeSystem<UIPetEggChouKaRewardComponent>
    {
        public override void Awake(UIPetEggChouKaRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextTitle = rc.Get<GameObject>("TextTitle");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPetEggChouKaReward); });

            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.UIChouKaRewardItem = rc.Get<GameObject>("UIChouKaRewardItem");
            self.UIChouKaRewardItem.SetActive(false);

            self.OnInitUI();
        }
    }

    public static class UIPetEggChouKaRewardComponentSystem
    {
        public static void OnInitUI(this UIPetEggChouKaRewardComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.TextTitle.GetComponent<Text>().text = $"今日探索次数:{unit.GetComponent<NumericComponent>().GetAsInt(NumericType.PetExploreNumber)}";

            foreach (KeyValuePair<int, string> keyValuePair in ConfigHelper.PetExploreReward)
            {
                GameObject gameObject = UnityEngine.Object.Instantiate(self.UIChouKaRewardItem);
                gameObject.SetActive(true);
                UICommonHelper.SetParent(gameObject, self.RewardListNode);
                UIPetEggChouKaRewardItemComponent itemComponent = self.AddChild<UIPetEggChouKaRewardItemComponent, GameObject>(gameObject);
                itemComponent.OnUpdateUI(keyValuePair.Key);
            }
        }
    }
}