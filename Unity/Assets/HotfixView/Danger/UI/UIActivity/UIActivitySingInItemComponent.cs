using System;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIActivitySingInItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Image_ItemButton;
        public GameObject Image_XuanZhong;
        public GameObject Label_ItemName;
        public GameObject Image_ItemIcon2;
        public GameObject Image_ItemIcon1;

        public GameObject CurrentImage_ItemIcon;
        public GameObject[] Image_ItemIconList = new GameObject[2];

        public Action<int> ClickHandler;
        public ActivityConfig ActivityConfig;
        public int CurrDay;
        public bool IsSign;
    }


    [ObjectSystem]
    public class UIActivitySingInItemComponentAwakeSystem : AwakeSystem<UIActivitySingInItemComponent, GameObject>
    {
        public override void Awake(UIActivitySingInItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Image_ItemButton = rc.Get<GameObject>("Image_ItemButton");
            ButtonHelp.AddListenerEx( self.Image_ItemButton, ()=> { self.OnImage_ItemButton();  } );

            self.Image_XuanZhong = rc.Get<GameObject>("Image_XuanZhong");
            self.Image_XuanZhong.SetActive(false);

            self.Label_ItemName = rc.Get<GameObject>("Label_ItemName");
            self.Image_ItemIcon2 = rc.Get<GameObject>("Image_ItemIcon2");
            self.Image_ItemIcon1 = rc.Get<GameObject>("Image_ItemIcon1");

            self.Image_ItemIconList[0] = self.Image_ItemIcon1;
            self.Image_ItemIconList[1] = self.Image_ItemIcon2;
            for (int i = 0; i < self.Image_ItemIconList.Length; i++)
            {
                self.Image_ItemIconList[i].SetActive(false);
            }
        }
    }

    public static class UIActivitySingInItemComponentSystem
    {

        public static void OnImage_ItemButton(this UIActivitySingInItemComponent self)
        {
            if (self.CurrDay < int.Parse(self.ActivityConfig.Par_1))
            {
                FloatTipManager.Instance.ShowFloatTip("到当前指定天数才可以查看奖励哦");
                return;
            }
            self.ClickHandler(self.ActivityConfig.Id);
        }

        public static void OnUpdateUI(this UIActivitySingInItemComponent self, ActivityConfig activityConfig, Action<int> action)
        {
            int index = int.Parse(activityConfig.Par_1);
            self.ActivityConfig = activityConfig;

            self.Label_ItemName.GetComponent<Text>().text = $"第{index}天";

            int current = index % 2;
            self.Image_ItemIconList[current].SetActive(true);
            self.CurrentImage_ItemIcon = self.Image_ItemIconList[current];

            self.ClickHandler = action;
        }

        public static void SetSignState(this UIActivitySingInItemComponent self, int curDay, bool isSign)
        {
            self.IsSign = isSign;
            self.CurrDay = curDay;

            UICommonHelper.SetImageGray(self.CurrentImage_ItemIcon, int.Parse(self.ActivityConfig.Par_1) > curDay);
        }

        public static void SetSelected(this UIActivitySingInItemComponent self, int activityId)
        {
            self.Image_XuanZhong.SetActive(self.ActivityConfig.Id == activityId);
        }
    }

}