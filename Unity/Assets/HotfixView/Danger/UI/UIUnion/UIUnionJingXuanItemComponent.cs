using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
    public class UIUnionJingXuanItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Lab_Index;
        public GameObject Lab_Name;

        public GameObject GameObject;
    }

    public class UIUnionJingXuanItemComponentAwake : AwakeSystem<UIUnionJingXuanItemComponent, GameObject>
    {
        public override void Awake(UIUnionJingXuanItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Lab_Index = rc.Get<GameObject>("Lab_Index");
            self.Lab_Name = rc.Get<GameObject>("Lab_Name");
        }
    }

    public static class UIUnionJingXuanItemComponentSystem
    {
        public static void OnUpdateUI(this UIUnionJingXuanItemComponent self, int index, UnionPlayerInfo unionPlayerInfo)
        {
            self.Lab_Index.GetComponent<Text>().text = (index + 1).ToString();
            self.Lab_Name.GetComponent<Text>().text = unionPlayerInfo.PlayerName;
        }
    }
}