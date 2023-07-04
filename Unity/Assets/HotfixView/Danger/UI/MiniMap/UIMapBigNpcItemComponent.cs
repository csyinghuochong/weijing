using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UIMapBigNpcItemComponent : Entity, IAwake
    {
        public GameObject TextName;
        public GameObject ImageDi;

        public Action<int, int> ClickHandler;
        public int ConfigId;
        public int UnitType;
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
            self.ClickHandler(self.UnitType, self.ConfigId);
        }

        public static void SetClickHandler(this UIMapBigNpcItemComponent self, int unittype, int npcId, Action<int, int> action)
        {
            self.ConfigId = npcId;
            self.ClickHandler = action;

            if (unittype == UnitType.Npc)
            {
                self.TextName.GetComponent<Text>().text = NpcConfigCategory.Instance.Get(npcId).Name;
            }
            else
            {
                self.TextName.GetComponent<Text>().text = MonsterConfigCategory.Instance.Get(npcId).MonsterName;
            }
        }

    }
}
