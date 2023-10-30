using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace ET
{
    public class UIShouJiTreasureTypeComponent : Entity, IAwake<GameObject>
    {

        public GameObject Lab_TaskName;
        public GameObject Ima_SelectStatus;
        public GameObject Ima_Di;
        public GameObject RedDot;

        public int Chapter;
        public Action<int> ClickChapHandler;
    }


    public class UIShouJiTreasureTypeComponentAwake : AwakeSystem<UIShouJiTreasureTypeComponent, GameObject>
    {
        public override void Awake(UIShouJiTreasureTypeComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Lab_TaskName = rc.Get<GameObject>("Lab_TaskName");
            self.Ima_SelectStatus = rc.Get<GameObject>("Ima_SelectStatus");
            self.Ima_Di = rc.Get<GameObject>("Ima_Di");
            self.RedDot = rc.Get<GameObject>("RedDot");

            self.RedDot.SetActive(false);
            self.Ima_Di.GetComponent<Button>().onClick.AddListener(self.OnClick);
        }
    }

    public static class UIShouJiTreasureTypeComponentSystem
    {

        public static void SetClickHandler(this UIShouJiTreasureTypeComponent self, Action<int> action)
        {
            self.ClickChapHandler = action;
        }

        public static void OnClick(this UIShouJiTreasureTypeComponent self)
        {
            self.ClickChapHandler(self.Chapter);
        }

        public static void OnSelected(this UIShouJiTreasureTypeComponent self, int chapter)
        {
            self.Ima_SelectStatus.SetActive(self.Chapter == chapter);
        }

        public static void OnInitData(this UIShouJiTreasureTypeComponent self, int chapter)
        {
            self.Chapter = chapter;

            self.Lab_TaskName.GetComponent<Text>().text = $"第{chapter}章";
            self.UpdateRedDot();
        }

        public static void UpdateRedDot(this UIShouJiTreasureTypeComponent self)
        {
            ShoujiComponent shoujiComponent = self.ZoneScene().GetComponent<ShoujiComponent>();
            List<int> shouList = ShouJiItemConfigCategory.Instance.TreasureList[self.Chapter];
            bool flag = false;
            for (int i = 0; i < shouList.Count; i++)
            {
                ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(shouList[i]);
                BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                KeyValuePairInt keyValuePairInt = shoujiComponent.GetTreasureInfo(shouList[i]);
                int haveNumber = keyValuePairInt != null? (int)keyValuePairInt.Value : 0;
                bool actived = haveNumber >= shouJiItemConfig.AcitveNum;

                if (bagComponent.GetItemNumber(shouJiItemConfig.ItemID) > 0 && !actived)
                {
                    flag = true;
                    break;
                }
            }
            
            self.RedDot.SetActive(flag);
        }
    }
}
