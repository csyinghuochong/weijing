using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleXiLianLevelComponent : Entity, IAwake
    {
        public GameObject LevelListNode;
        public GameObject Button_Right;
        public GameObject Button_Left;
    }

    [ObjectSystem]
    public class UIRoleXiLianLevelComponentAwakeSystem : AwakeSystem<UIRoleXiLianLevelComponent>
    {
        public override void Awake(UIRoleXiLianLevelComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.LevelListNode = rc.Get<GameObject>("LevelListNode");

            self.Button_Right = rc.Get<GameObject>("Button_Right");
            self.Button_Right.GetComponent<Button>().onClick.AddListener(self.OnButton_Right);
            self.Button_Left = rc.Get<GameObject>("Button_Left");
            self.Button_Left.GetComponent<Button>().onClick.AddListener(self.OnButton_Left);
        }
    }

    public static class UIRoleXiLianLevelComponentSystem
    {

        public static void OnButton_Right(this UIRoleXiLianLevelComponent self)
        { 
            
        }

        public static void OnUpdateUI(this UIRoleXiLianLevelComponent self, int xilianLevel)
        { 
            
        }

        public static void OnButton_Left(this UIRoleXiLianLevelComponent self)
        {

        }

    }
}
