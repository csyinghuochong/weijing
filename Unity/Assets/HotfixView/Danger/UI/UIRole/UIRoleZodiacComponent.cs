using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleZodiacComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonColse;
        public GameObject ZodiacList;
        public GameObject BtnItemTypeSet;
    }

    [ObjectSystem]
    public class UIRoleZodiacComponentAwake : AwakeSystem<UIRoleZodiacComponent>
    {
        public override void Awake(UIRoleZodiacComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ZodiacList = rc.Get<GameObject>("ZodiacList");
            self.BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");

            self.ButtonColse = rc.Get<GameObject>("ButtonColse");
            self.ButtonColse.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIRoleZodiac); });
        }
    }

    [ObjectSystem]
    public class UIRoleZodiacComponentDestroy : DestroySystem<UIRoleZodiacComponent>
    {
        public override void Destroy(UIRoleZodiacComponent self)
        {
            
        }
    }
}