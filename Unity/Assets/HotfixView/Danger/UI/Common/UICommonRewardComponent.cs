using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UICommonRewardComponent : Entity, IAwake, IDestroy
    {
        public GameObject ChouKaItemSet;
        public GameObject ImageButton;
    }


    public class UICommonRewardComponentAwakeSystem : AwakeSystem<UICommonRewardComponent>
    {
        public override void Awake(UICommonRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ChouKaItemSet = rc.Get<GameObject>("ChouKaItemSet");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
        
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnImageButton(); });
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UICommonRewardComponentDestroySystem : DestroySystem<UICommonRewardComponent>
    {

        public override void Destroy(UICommonRewardComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UICommonRewardComponentSystem
    {
        public static void OnLanguageUpdate(this UICommonRewardComponent self)
        {
            self.ChouKaItemSet.GetComponent<GridLayoutGroup>().cellSize = GameSettingLanguge.Language == 0? new Vector2(180, 170) : new Vector2(180, 190);
        }

        public static void OnImageButton(this UICommonRewardComponent self)
        {
            UIHelper.Remove( self.DomainScene(), UIType.UICommonReward );
        }

        public static void  OnUpdateUI(this UICommonRewardComponent self, List<RewardItem> rewardItems)
        {
            UICommonHelper.ShowItemList(rewardItems, self.ChouKaItemSet, self , 1f, true, true);
        }
    }
}
