using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiShopTypeItemComponent : Entity, IAwake, IDestroy
    {
        public GameObject GameObject;
        public GameObject Lab_TaskName;
        public GameObject Ima_SelectStatus;
        public GameObject Ima_Di;

        public Action<int> ClickHandler;
        public int SubTypeId;
    }


    public class UIPaiMaiShopTypeItemComponentAwakeSystem : AwakeSystem<UIPaiMaiShopTypeItemComponent>
    {

        public override void Awake(UIPaiMaiShopTypeItemComponent self)
        {
            self.GameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Lab_TaskName = rc.Get<GameObject>("Lab_TaskName");
            self.Ima_Di = rc.Get<GameObject>("Ima_Di");
            self.Ima_SelectStatus = rc.Get<GameObject>("Ima_SelectStatus");
            self.Ima_Di.GetComponent<Button>().onClick.AddListener(() => { self.OnClickButtoin(); });
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIPaiMaiShopTypeItemComponentDestroy: DestroySystem<UIPaiMaiShopTypeItemComponent>
    {
        public override void Destroy(UIPaiMaiShopTypeItemComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIPaiMaiShopTypeItemComponentSystem
    {
        public static void OnLanguageUpdate(this UIPaiMaiShopTypeItemComponent self)
        {
            if (self.GameObject == null)
            {
                return;
            }

            self.Lab_TaskName.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
        }

        public static void SetSelected(this UIPaiMaiShopTypeItemComponent self, int subTypeid)
        {
            self.Ima_SelectStatus.SetActive(subTypeid == self.SubTypeId);
        }

        public static void SetClickSubTypeHandler(this UIPaiMaiShopTypeItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnUpdateData(this UIPaiMaiShopTypeItemComponent self, int typeid, int subType)
        {
            self.SubTypeId = subType;
            self.Lab_TaskName.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization(PaiMaiHelper.Instance.PaiMaiIndexText[subType]);
        }

        public static void OnClickButtoin(this UIPaiMaiShopTypeItemComponent self)
        {
            self.ClickHandler(self.SubTypeId);
        }
    }

}
