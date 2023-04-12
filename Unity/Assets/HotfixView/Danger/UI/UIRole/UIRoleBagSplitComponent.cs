using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleBagSplitComponent : Entity, IAwake
    {
        public GameObject ButtonClose;
        public InputField InputField;
        public GameObject Btn_CostNum;
        public GameObject Btn_AddNum;
        public GameObject Btn_Split;

        public UIItemComponent UICommonItem;

        public BagInfo BagInfo;
    }


    public class UIRoleBagSplitComponentAwake : AwakeSystem<UIRoleBagSplitComponent>
    {
        public override void Awake(UIRoleBagSplitComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.InputField = rc.Get<GameObject>("InputField").GetComponent<InputField>();

            self.Btn_CostNum = rc.Get<GameObject>("Btn_CostNum");
            self.Btn_CostNum.GetComponent<Button>().onClick.AddListener(self.OnBtn_CostNum);

            self.Btn_AddNum = rc.Get<GameObject>("Btn_AddNum");
            self.Btn_AddNum.GetComponent<Button>().onClick.AddListener(self.OnBtn_AddNum);

            self.Btn_Split = rc.Get<GameObject>("Btn_Split");
            self.Btn_Split.GetComponent<Button>().onClick.AddListener(self.OnBtn_Split);

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIRoleBagSplit); });

            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(rc.Get<GameObject>("UICommonItem"));
            self.UICommonItem.Label_ItemNum.SetActive(false);
        }
    }

    public static class UIRoleBagSplitComponentSystem
    {
        public static void OnInitUI(this UIRoleBagSplitComponent self, BagInfo bagInfo)
        { 
            self.BagInfo = bagInfo;

            self.UICommonItem.UpdateItem(bagInfo, ItemOperateEnum.None);
            self.InputField.text = "1";
        }

        public static void OnBtn_CostNum(this UIRoleBagSplitComponent self)
        {
            int number =0;
            try
            {
                number = int.Parse(self.InputField.text);
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return;
            }
            if (number <= 1)
            {
                return;
            }
            number -= 1;
            self.InputField.text = number.ToString();
        }

        public static void OnBtn_AddNum(this UIRoleBagSplitComponent self)
        {
            int number = 0;
            try
            {
                number = int.Parse(self.InputField.text);
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return;
            }
            if (number >= self.BagInfo.ItemNum - 1)
            {
                return;
            }
            number += 1;
            self.InputField.text = number.ToString();
        }

        public static void OnBtn_Split(this UIRoleBagSplitComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetLeftSpace() <= 1)
            {
                HintHelp.GetInstance().ShowHintError(ErrorCore.ERR_BagIsFull);
                return;
            }
            int number = 0;
            try
            {
                number = int.Parse(self.InputField.text);
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return;
            }

            bagComponent.SendSplitItem(self.BagInfo, number).Coroutine();
            UIHelper.Remove(self.ZoneScene(), UIType.UIRoleBagSplit);
        }
    }
}
