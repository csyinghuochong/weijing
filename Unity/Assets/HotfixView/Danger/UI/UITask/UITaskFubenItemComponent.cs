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
        public Action<int, int> ClickHandler;

        public int NpcType;
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
            ButtonHelp.AddListenerEx(self.ImageButton, () => { self.ClickHandler(self.NpcType ,self.FubenId);  });
        }
    }

    public static class UITaskFubenItemComponentSystem
    { 
        public static void OnInitData(this UITaskFubenItemComponent self,Action<int, int> action, int npcType, int fubenId)
        {
            switch (npcType)
            {
                case 1:
                    self.TextFubenName.GetComponent<Text>().text = UIItemHelp.ShowDuiHuanPet(fubenId);
                    break;
                case 2:
                    self.TextFubenName.GetComponent<Text>().text = SceneConfigCategory.Instance.Get(fubenId).Name;
                    break;
                default:
                    break;
            }

            self.ClickHandler = action;
            self.NpcType = npcType;
            self.FubenId = fubenId;
        }


    }
}
