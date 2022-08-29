using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITaskFubenItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;
        public GameObject TextFubenName;
        public GameObject ImageButton;
        public Action<int> ClickHandler;
        public int FubenId;
    }

    [ObjectSystem]
    public class UITaskFubenItemComponentAwakeSystem : AwakeSystem<UITaskFubenItemComponent, GameObject>
    {
        public override void Awake(UITaskFubenItemComponent self, GameObject go)
        {
            self.FubenId = 0;
            self.GameObject = go;

            self.TextFubenName = go.Get<GameObject>("TextFubenName");
            self.ImageButton = go.Get<GameObject>("ImageButton");
            ButtonHelp.AddListenerEx(self.ImageButton, () => { self.ClickHandler(self.FubenId);  });
        }
    }

    public static class UITaskFubenItemComponentSystem
    { 
        public static void OnInitData(this UITaskFubenItemComponent self,Action<int> action, int fubenId)
        {
            self.TextFubenName.GetComponent<Text>().text = SceneConfigCategory.Instance.Get(fubenId).Name;
            self.ClickHandler = action;
            self.FubenId = fubenId;
        }


    }
}
