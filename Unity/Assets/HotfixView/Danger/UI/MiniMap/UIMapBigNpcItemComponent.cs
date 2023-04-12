using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UIMapBigNpcItemComponent : Entity, IAwake
    {

        public GameObject TextName;
        public GameObject ImageDi;

        public int NpcId;
        public Action<int> ClickHandler;
    }


    public class AwakeSystem : AwakeSystem<UIMapBigNpcItemComponent>
    {

        public override void Awake(UIMapBigNpcItemComponent self)
        {
          
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.TextName = rc.Get<GameObject>("TextName");
            self.ImageDi = rc.Get<GameObject>("ImageDi");

            self.ImageDi.GetComponent<Button>().onClick.AddListener(() => { self.OnImageDi(); });
        }
    }

    public static class UIMapBigNpcItemComponentSystem
    {

        public static void OnImageDi(this UIMapBigNpcItemComponent self)
        {
            self.ClickHandler( self.NpcId);
        }

        public static void SetClickHandler(this UIMapBigNpcItemComponent self, int npcId, Action<int> action)
        {
            self.NpcId = npcId;
            self.ClickHandler = action;

            self.TextName.GetComponent<Text>().text = NpcConfigCategory.Instance.Get(npcId).Name;
        }

    }
}
