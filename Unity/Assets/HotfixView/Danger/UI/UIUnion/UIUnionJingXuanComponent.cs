using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIUnionJingXuanComponent : Entity, IAwake
    {
        public GameObject ImageButton;
        public GameObject ItemNodeList;
    }

    public class UIUnionJingXuanComponentAwake : AwakeSystem<UIUnionJingXuanComponent>
    {
        public override void Awake(UIUnionJingXuanComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIUnionJingXuan );  });

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
        }
    }

    public static class UIUnionJingXuanComponentSystem
    {
        public static async ETTask  OnUpdateUI(this UIUnionJingXuanComponent self)
        {
            await ETTask.CompletedTask;

        }
    }
}