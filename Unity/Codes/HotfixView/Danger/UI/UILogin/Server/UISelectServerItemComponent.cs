using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISelectServerItemComponent : Entity, IAwake
    { 
        public GameObject Text_ServerName;
        public GameObject ImageButton;

        public Action<ServerItem> ClickHandler;
        public ServerItem ServerInfo;
    }

    [ObjectSystem]
    public class UISelectServerItemComponentAwakeSystem : AwakeSystem<UISelectServerItemComponent>
    {

        public override void Awake(UISelectServerItemComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_ServerName = rc.Get<GameObject>("Text_ServerName");

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickImageButton(); });
        }
    }

    public static class UISelectServerItemComponentSystem
    {
        public static void OnClickImageButton(this UISelectServerItemComponent self)
        {
            self.ClickHandler(self.ServerInfo);
        }

        public static void OnUpdateData(this UISelectServerItemComponent self, ServerItem serverId)
        {
            self.ServerInfo = serverId;
            self.Text_ServerName.GetComponent<Text>().text = serverId.ServerName;
        }

        public static void SetClickHandler(this UISelectServerItemComponent self, Action<ServerItem> action)
        {
            self.ClickHandler = action;
        }
    }
}
