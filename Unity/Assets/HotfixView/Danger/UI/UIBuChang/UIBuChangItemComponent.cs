using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIBuChangItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject TextFubenName;
        public GameObject ImageButton;
        public Action<long> ClickHandler;

        public long UserId;
    }

    [ObjectSystem]
    public class UIBuChangItemComponentAwakeSystem : AwakeSystem<UIBuChangItemComponent, GameObject>
    {
        public override void Awake(UIBuChangItemComponent self, GameObject go)
        {
            self.GameObject = go;
            self.TextFubenName = go.Get<GameObject>("TextFubenName");
            self.ImageButton = go.Get<GameObject>("ImageButton");


            ButtonHelp.AddListenerEx(self.ImageButton, () => { self.ClickHandler(self.UserId); });
        }
    }

    public static class UIBuChangItemComponentSystem
    {
        public static void OnInitUI(this UIBuChangItemComponent self, Action<long> action, KeyValuePair keyValuePair)
        {
            self.ClickHandler = action;
            self.UserId = long.Parse(keyValuePair.Value);
            self.TextFubenName.GetComponent<Text>().text = keyValuePair.Value2;
        }

        public static void OnInitUI_2(this UIBuChangItemComponent self, Action<long> action, int number)
        {
            self.ClickHandler = action;
            self.UserId = 0;
            self.TextFubenName.GetComponent<Text>().text =  $"补偿金额:{number}";
        }
    }
}
