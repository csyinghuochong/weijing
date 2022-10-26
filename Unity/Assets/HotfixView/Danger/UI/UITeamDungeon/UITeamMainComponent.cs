using System;
using UnityEngine;

namespace ET
{
    public class UITeamMainComponent : Entity, IAwake
    {
        public GameObject BottomNode;
        public GameObject Label_LeftTime;
        public GameObject Btn_Close;
        public GameObject Btn_Need;

        public UIItemComponent UIItem;
    }

    [ObjectSystem]
    public class UITeamMainComponentAwakeSystem : AwakeSystem<UITeamMainComponent>
    {
        public override void Awake(UITeamMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Label_LeftTime = rc.Get<GameObject>("Label_LeftTime");

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            ButtonHelp.AddListenerEx( self.Btn_Close, () => { } );

            self.Btn_Need = rc.Get<GameObject>("Btn_Need");
            ButtonHelp.AddListenerEx(self.Btn_Need, () => { });

            self.BottomNode = rc.Get<GameObject>("BottomNode");
            self.BottomNode.SetActive(false);

            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UIItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem);
        }
    }

    public static class UITeamMainComponentSystem
    { 

    }
}
