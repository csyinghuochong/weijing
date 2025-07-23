using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIBattleEnterComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonEnter;
        public GameObject ItemListNode;
        public List<Vector2> UIOldPositionList = new List<Vector2>();
    }


    public class UIBattleEnterComponentAwakeSystem : AwakeSystem<UIBattleEnterComponent>
    {
        public override void Awake(UIBattleEnterComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonEnter = rc.Get<GameObject>("ButtonEnter");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            GlobalValueConfig globalValue = GlobalValueConfigCategory.Instance.Get(56);
            UICommonHelper.ShowItemList(globalValue.Value, self.ItemListNode, self, 1f);
            ButtonHelp.AddListenerEx(self.ButtonEnter, () => { self.OnButtonEnter().Coroutine(); } );
            
            self.StoreUIdData();
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UIBattleEnterComponentDestroy : DestroySystem<UIBattleEnterComponent>
    {
        public override void Destroy(UIBattleEnterComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UIBattleEnterComponentSystem
    {
        public static void StoreUIdData(this UIBattleEnterComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.UIOldPositionList.Add(rc.Get<GameObject>("TextDesc1").GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(rc.Get<GameObject>("TextDesc2").GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(rc.Get<GameObject>("TextDesc3").GetComponent<RectTransform>().localPosition);
        }

        public static void OnLanguageUpdate(this UIBattleEnterComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            rc.Get<GameObject>("TextDesc1").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[0] : new Vector2(78f, 175f);
            rc.Get<GameObject>("TextDesc2").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[1] : new Vector2(78f, 80f);
            rc.Get<GameObject>("TextDesc3").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[2] : new Vector2(78f, -6f);

            rc.Get<GameObject>("TextDesc1").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 32;
            rc.Get<GameObject>("TextDesc2").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 32;
            rc.Get<GameObject>("TextDesc3").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 32;
            
            rc.Get<GameObject>("TextDesc4_1").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 46 : 34;
            rc.Get<GameObject>("TextDesc4_2").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 46 : 34;
            self.ButtonEnter.GetComponentInChildren<Text>().fontSize = GameSettingLanguge.Language == 0? 46 : 34;
        }
        
        public static async ETTask OnButtonEnter(this UIBattleEnterComponent self)
        {
            int errorCode = await NetHelper.RequstBattleEnter(self.ZoneScene());
            if (errorCode == ErrorCode.ERR_Success)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UIBattle);
                return;
            }
            if (ErrorHelp.Instance.ErrorHintList.ContainsKey(errorCode))
            {
                FloatTipManager.Instance.ShowFloatTipDi(ErrorHelp.Instance.ErrorHintList[errorCode]);
            }
        }
    }
}