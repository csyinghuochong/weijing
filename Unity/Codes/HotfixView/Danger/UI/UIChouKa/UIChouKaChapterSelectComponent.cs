using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIChouKaChapterSelectComponent : Entity, IAwake
    {
        public GameObject Btn_Close;
        public GameObject Btn_ZhangJie5;
        public GameObject Btn_ZhangJie4;
        public GameObject Btn_ZhangJie3;
        public GameObject Btn_ZhangJie2;
        public GameObject Btn_ZhangJie1;

        public Action<int> ClickHandler;
    }

    [ObjectSystem]
    public class UIChouKaChapterSelectAwakeSystem : AwakeSystem<UIChouKaChapterSelectComponent>
    {

        public override void Awake(UIChouKaChapterSelectComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });

            self.Btn_ZhangJie5 = rc.Get<GameObject>("Btn_ZhangJie5");
            self.Btn_ZhangJie5.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhangJie5(1005); });
            self.Btn_ZhangJie4 = rc.Get<GameObject>("Btn_ZhangJie4");
            self.Btn_ZhangJie4.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhangJie5(1004); });
            self.Btn_ZhangJie3 = rc.Get<GameObject>("Btn_ZhangJie3");
            self.Btn_ZhangJie3.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhangJie5(1003); });
            self.Btn_ZhangJie2 = rc.Get<GameObject>("Btn_ZhangJie2");
            self.Btn_ZhangJie2.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhangJie5(1002); });
            self.Btn_ZhangJie1 = rc.Get<GameObject>("Btn_ZhangJie1");
            self.Btn_ZhangJie1.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhangJie5(1001); });
        }
    }

    public static class UIChouKaChapterSelectComponentSystem
    {

        public static void SetClickHandler(this UIChouKaChapterSelectComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnBtn_ZhangJie5(this UIChouKaChapterSelectComponent self, int chapterid)
        {
            int level = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            TakeCardConfig takeCardConfig = TakeCardConfigCategory.Instance.Get(chapterid);
            if (level < takeCardConfig.RoseLvLimit)
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }
            self.ClickHandler(chapterid);
            self.GetParent<UI>().GameObject.SetActive(false);
        }

        public static void OnBtn_Close(this UIChouKaChapterSelectComponent self)
        {
            self.GetParent<UI>().GameObject.SetActive(false);
        }

    }

}
