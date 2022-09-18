using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRandomTowerResultComponent : Entity, IAwake
    {
        public GameObject TextResult;
        public GameObject Button_exit;
    }

    [ObjectSystem]
    public class UIRandomTowerResultComponentAwakeSystem : AwakeSystem<UIRandomTowerResultComponent>
    {
        public override void Awake(UIRandomTowerResultComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextResult = rc.Get<GameObject>("TextResult");

            self.Button_exit = rc.Get<GameObject>("Button_exit");
            self.Button_exit.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_exit(); });

        }
    }


    public static class UIRandomTowerResultComponentSystem
    {

        public static void OnUpdateUI(this UIRandomTowerResultComponent self, M2C_FubenSettlement message)
        {
            // 0失败 1胜利
            self.TextResult.GetComponent<Text>().text = message.BattleResult == 0 ? "0失败" : "胜利";
        }

        public static void OnButton_exit(this UIRandomTowerResultComponent self)
        {
            EnterFubenHelp.RequestQuitFuben(self.ZoneScene());
            UIHelper.Remove(self.ZoneScene(), UIType.UIRandomTowerResult);
        }
    }
}
