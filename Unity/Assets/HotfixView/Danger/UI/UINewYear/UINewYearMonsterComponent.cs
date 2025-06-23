using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public  class UINewYearMonsterComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_1;
        public GameObject Text_2;
        public GameObject Text_3;
        public GameObject Text_4;
        public GameObject Text_5;
        public GameObject Text_6;
    }

    public class UINewYearMonsterComponentAwakeSystem: AwakeSystem<UINewYearMonsterComponent>
    {
        public override void Awake(UINewYearMonsterComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.Text_1 = rc.Get<GameObject>("Text_1");
            self.Text_2 = rc.Get<GameObject>("Text_2");
            self.Text_3 = rc.Get<GameObject>("Text_3");
            self.Text_4 = rc.Get<GameObject>("Text_4");
            self.Text_5 = rc.Get<GameObject>("Text_5");
            self.Text_6 = rc.Get<GameObject>("Text_6");
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UINewYearMonsterComponentDestroySystem : DestroySystem<UINewYearMonsterComponent>
    {
        public override void Destroy(UINewYearMonsterComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UINewYearMonsterComponentSystem
    {
        public static void OnLanguageUpdate(this UINewYearMonsterComponent self)
        {
            self.Text_1.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Text_2.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Text_3.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Text_4.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Text_5.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Text_6.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
        }
    }
}
