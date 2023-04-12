using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UICommandComponent : Entity, IAwake
    {
        public GameObject Button_Close;
        public GameObject Button_KillMonster;
        public GameObject Button_Gaoji;
        public GameObject Button_Zhongji;
        public GameObject Button_Chuji;
        public GameObject Button_WuDi;
        public GameObject Button_CompleteTask;
        public GameObject Button_AddLevel;
        public GameObject Button_AddDiamond;
        public GameObject Button_AddCoin;
    }


    public class UICommandComponentAwakeSystem : AwakeSystem<UICommandComponent>
    {
        public override void Awake(UICommandComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Button_Close = rc.Get<GameObject>("Button_Close");
            self.Button_KillMonster = rc.Get<GameObject>("Button_KillMonster");
            self.Button_Gaoji = rc.Get<GameObject>("Button_Gaoji");
            self.Button_Zhongji = rc.Get<GameObject>("Button_Zhongji");
            self.Button_Chuji = rc.Get<GameObject>("Button_Chuji");
            self.Button_WuDi = rc.Get<GameObject>("Button_WuDi");
            self.Button_CompleteTask = rc.Get<GameObject>("Button_CompleteTask"); 
            self.Button_AddLevel = rc.Get<GameObject>("Button_AddLevel");
            self.Button_AddDiamond = rc.Get<GameObject>("Button_AddDiamond");
            self.Button_AddCoin = rc.Get<GameObject>("Button_AddCoin");

            self.Button_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Close(); });
            self.Button_KillMonster.GetComponent<Button>().onClick.AddListener(() => { self.SendCommon("#killmonster"); });
            self.Button_Gaoji.GetComponent<Button>().onClick.AddListener(() => { GMHelp.SendGmCommands(self.ZoneScene(), "#chuji"); });
            self.Button_Zhongji.GetComponent<Button>().onClick.AddListener(() => { GMHelp.SendGmCommands(self.ZoneScene(), "#zhongji"); });
            self.Button_Chuji.GetComponent<Button>().onClick.AddListener(() => { GMHelp.SendGmCommands(self.ZoneScene(), "#gaoji"); });
            self.Button_WuDi.GetComponent<Button>().onClick.AddListener(() => { self.SendCommon("#wudi"); });
            self.Button_CompleteTask.GetComponent<Button>().onClick.AddListener(() => { self.SendCommon("#completetask"); });
            self.Button_AddLevel.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_AddLevel(); });
            self.Button_AddDiamond.GetComponent<Button>().onClick.AddListener(() => { self.SendCommon("1#3#1000"); }); 
            self.Button_AddCoin.GetComponent<Button>().onClick.AddListener(() => { self.SendCommon("1#1#100000"); });
        }
    }

    public static class UICommandComponentSystem
    {
        public static void OnButton_Close(this UICommandComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UICommand);
        }

        public static void OnButton_AddLevel(this UICommandComponent self)
        {
            int curlevel = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            int targetLevel = curlevel + 1;
            self.SendCommon($"6#{targetLevel}");
        }

        public static void SendCommon(this UICommandComponent self, string text)
        {
            GMHelp.SendGmCommand(self.ZoneScene(), text);
        }
    }
}
