using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIArenaMainComponent : Entity, IAwake
    {
        public GameObject TextVS;
    }


    public class UIArenaMainComponentAwake : AwakeSystem<UIArenaMainComponent>
    {
        public override void Awake(UIArenaMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>(); 

            self.TextVS = rc.Get<GameObject>("TextVS");

            self.OnInitUI();
        }
    }

    public static class UIArenaMainComponentSystem
    {
        public static void OnUpdateUI(this UIArenaMainComponent self, M2C_AreneInfoResult message)
        {
            self.TextVS.GetComponent<Text>().text = $"剩余人数： {message.LeftPlayer}";
        }

        public static void OnInitUI(this UIArenaMainComponent self)
        { 
            BattleMessageComponent battleMessageComponent = self.ZoneScene().GetComponent<BattleMessageComponent>();
            if (battleMessageComponent.M2C_AreneInfoResult != null)
            {
                self.OnUpdateUI(battleMessageComponent.M2C_AreneInfoResult);
            }
        }
    }
}
