using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UICommonRewardComponent : Entity, IAwake
    {
        public GameObject ChouKaItemSet;
        public GameObject ImageButton;
    }

    [ObjectSystem]
    public class UICommonRewardComponentAwakeSystem : AwakeSystem<UICommonRewardComponent>
    {
        public override void Awake(UICommonRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ChouKaItemSet = rc.Get<GameObject>("ChouKaItemSet");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
        
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnImageButton(); });
        }
    }

    public static class UICommonRewardComponentSystem
    {
        public static void OnImageButton(this UICommonRewardComponent self)
        {
            UIHelper.Remove( self.DomainScene(), UIType.UICommonReward );
        }

        public static void  OnUpdateUI(this UICommonRewardComponent self, List<RewardItem> rewardItems)
        {
            UICommonHelper.ShowItemList(rewardItems, self.ChouKaItemSet, self , 1f);
        }
    }

}
