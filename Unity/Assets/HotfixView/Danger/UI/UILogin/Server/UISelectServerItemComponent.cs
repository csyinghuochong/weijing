using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISelectServerItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageNew;
        public GameObject Text_ServerName;
        public GameObject ImageButton;

        public GameObject GameObject;
        public Action<ServerItem> ClickHandler;
        public ServerItem ServerInfo;
    }


    public class UISelectServerItemComponentAwakeSystem : AwakeSystem<UISelectServerItemComponent, GameObject>
    {

        public override void Awake(UISelectServerItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_ServerName = rc.Get<GameObject>("Text_ServerName");
            self.ImageNew = rc.Get<GameObject>("ImageNew");
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

        public static void OnUpdateData(this UISelectServerItemComponent self, ServerItem serverId, int index)
        {
            self.ServerInfo = serverId;
            self.Text_ServerName.GetComponent<Text>().text = serverId.ServerName;
            self.ImageNew.SetActive(index == 0) ;
        }

        public static void SetClickHandler(this UISelectServerItemComponent self, Action<ServerItem> action)
        {
            self.ClickHandler = action;
        }
    }
}
