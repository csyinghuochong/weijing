using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiShopTypeItemComponent : Entity, IAwake
    {
        public GameObject Lab_TaskName;
        public GameObject Ima_SelectStatus;
        public GameObject Ima_Di;

        public Action<int> ClickHandler;
        public int SubTypeId;
    }

    [ObjectSystem]
    public class UIPaiMaiShopTypeItemComponentAwakeSystem : AwakeSystem<UIPaiMaiShopTypeItemComponent>
    {

        public override void Awake(UIPaiMaiShopTypeItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Lab_TaskName = rc.Get<GameObject>("Lab_TaskName");
            self.Ima_Di = rc.Get<GameObject>("Ima_Di");
            self.Ima_SelectStatus = rc.Get<GameObject>("Ima_SelectStatus");
            self.Ima_Di.GetComponent<Button>().onClick.AddListener(() => { self.OnClickButtoin(); });
        }
    }

    public static class UIPaiMaiShopTypeItemComponentSystem
    {

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
            self.Lab_TaskName.GetComponent<Text>().text = PaiMaiHelper.Instance.PaiMaiIndexText[subType];
        }

        public static void OnClickButtoin(this UIPaiMaiShopTypeItemComponent self)
        {
            self.ClickHandler(self.SubTypeId);
        }
    }

}
