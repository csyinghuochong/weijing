using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionCreateComponent : Entity, IAwake<GameObject>
    {
        public GameObject InputFieldName;
        public GameObject Text_Contion2;
        public GameObject Text_Contion1;
        public GameObject Btn_Create;
        public GameObject InputFieldPurpose;
        public GameObject GameObject;
    }


    public class UIUnionCreateComponentAwakeSystem : AwakeSystem<UIUnionCreateComponent, GameObject>
    {
        public override void Awake(UIUnionCreateComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.InputFieldName = rc.Get<GameObject>("InputFieldName");
            self.InputFieldName.GetComponent<InputField>().onValueChanged.AddListener((string text) => { self.CheckSensitiveWords(self.InputFieldName); });

            self.Text_Contion2 = rc.Get<GameObject>("Text_Contion2");
            self.Text_Contion1 = rc.Get<GameObject>("Text_Contion1");

            self.Btn_Create = rc.Get<GameObject>("Btn_Create");
            ButtonHelp.AddListenerEx( self.Btn_Create, () => { self.RequestCreateUnion().Coroutine(); } );

            self.InputFieldPurpose = rc.Get<GameObject>("InputFieldPurpose");
            self.InputFieldPurpose.GetComponent<InputField>().onValueChanged.AddListener((string text) => { self.CheckSensitiveWords(self.InputFieldPurpose); });

            self.OnInitUI();
        }
    }

    public static class UIUnionCreateComponentSystem
    {
        public static void CheckSensitiveWords(this UIUnionCreateComponent self, GameObject InputField)
        {
            string text_new = "";
            string text_old = InputField.GetComponent<InputField>().text;
            MaskWordHelper.Instance.IsContainSensitiveWords(ref text_old, out text_new);
            InputField.GetComponent<InputField>().text = text_old;
        }

        public static void OnInitUI(this UIUnionCreateComponent self)
        {
            self.Text_Contion1.GetComponent<Text>().text = $"1. 角色等级达到{GlobalValueConfigCategory.Instance.Get(21).Value}级";
            self.Text_Contion2.GetComponent<Text>().text = $"2. 消耗{GlobalValueConfigCategory.Instance.Get(22).Value}钻石";
        }

        public static async ETTask RequestCreateUnion(this UIUnionCreateComponent self)
        {
            string unionName = self.InputFieldName.GetComponent<InputField>().text;
            bool mask = MaskWordHelper.Instance.IsContainSensitiveWords(unionName);
            if (mask || !StringHelper.IsSpecialChar(unionName))
            {
                FloatTipManager.Instance.ShowFloatTip("请重新输入！");
                return;
            }
            string purpose = self.InputFieldPurpose.GetComponent<InputField>().text;
            mask = MaskWordHelper.Instance.IsContainSensitiveWords(purpose);
            if (mask || !StringHelper.IsSpecialChar(purpose))
            {
                FloatTipManager.Instance.ShowFloatTip("请重新输入！");
                return;
            }

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.UnionId != 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请先退出公会！");
                return;
            }

            int needLevel = int.Parse(GlobalValueConfigCategory.Instance.Get(21).Value);
            int needDiamond = int.Parse(GlobalValueConfigCategory.Instance.Get(22).Value);
            if (userInfo.Lv < needLevel )
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }
            if (userInfo.Diamond < needDiamond)
            {
                FloatTipManager.Instance.ShowFloatTip("钻石不足！");
                return;
            }

            C2M_UnionCreateRequest c2M_ItemHuiShouRequest = new C2M_UnionCreateRequest()
            {
                 UnionName = unionName,
                 UnionPurpose = purpose
            };
            M2C_UnionCreateResponse r2c_roleEquip = (M2C_UnionCreateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            if (r2c_roleEquip.Error != ErrorCore.ERR_Success)
            {
                return;
            }
        }

    }
}
