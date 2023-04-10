using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanVisitItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextTimes_2;
        public GameObject TextTimes_1;
        public GameObject TextName;
        public GameObject ButtonVisit;
        public GameObject ImageIcon;

        public GameObject GameObject;

        public JiaYuanVisit JiaYuanVisit;
    }

    public class UIJiaYuanVisitItemComponentAwake : AwakeSystem<UIJiaYuanVisitItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanVisitItemComponent self, GameObject a)
        {
            self.GameObject = a;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.TextTimes_2 = rc.Get<GameObject>("TextTimes_2");
            self.TextTimes_1 = rc.Get<GameObject>("TextTimes_1");

            self.TextName = rc.Get<GameObject>("TextName");

            self.ButtonVisit = rc.Get<GameObject>("ButtonVisit");
            ButtonHelp.AddListenerEx( self.ButtonVisit, () => { self.OnButtonVisit();  } );

            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
        }
    }

    public static class UIJiaYuanVisitItemComponentSystem
    {

        public static void OnUpdateUI(this UIJiaYuanVisitItemComponent self, JiaYuanVisit jiaYuanVisit)
        {
            self.JiaYuanVisit = jiaYuanVisit;

            self.TextTimes_2.GetComponent<Text>().text = $"X{jiaYuanVisit.Rubbish}";
            self.TextTimes_1.GetComponent<Text>().text = $"X{jiaYuanVisit.Gather}";
            self.TextName.GetComponent<Text>().text = jiaYuanVisit.PlayerName;
            UICommonHelper.ShowOccIcon( self.ImageIcon, jiaYuanVisit.Occ );
        }

        public static void OnButtonVisit(this UIJiaYuanVisitItemComponent self)
        {
            self.ZoneScene().GetComponent<JiaYuanComponent>().MasterId = self.JiaYuanVisit.UnitId;
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.JiaYuan, 102, 1, self.JiaYuanVisit.UnitId.ToString()).Coroutine();
            UIHelper.Remove(self.ZoneScene(), UIType.UIJiaYuanMain);
        }
    }
}
