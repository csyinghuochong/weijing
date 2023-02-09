using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    
    public class UISelectServerComponent : Entity, IAwake
    {
        public GameObject ScrollView1;
        public GameObject LatelyServerNode;
        public GameObject ButtonClose;
        public GameObject ServerListNode;
        public GameObject ImageButton;
        public GameObject FunctionSetBtn;

        public UI uIPageView;
        public List<UI> LateServerUIList;
        public List<UI> AllServerUIList;
    }

    [ObjectSystem]
    public class UISelectServerComponentAwakeSystem : AwakeSystem<UISelectServerComponent>
    {
        public override void Awake(UISelectServerComponent self)
        {
            self.LateServerUIList = new List<UI>();
            self.AllServerUIList = new List<UI>();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ScrollView1 = rc.Get<GameObject>("ScrollView1");
            self.LatelyServerNode = rc.Get<GameObject>("LatelyServerNode");
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ServerListNode = rc.Get<GameObject>("ServerListNode");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
  
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.CloseUI(); });
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.CloseUI(); });

            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiJoystick = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", BtnItemTypeSet);
            self.uIPageView = uiJoystick;
            UIPageButtonComponent uIPageViewComponent = uiJoystick.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });


            uIPageViewComponent.OnSelectIndex(0);
        }
    }

    public static class UISelectServerComponentSystem
    {
        public static void OnUpdateServerList(this UISelectServerComponent self, int page)
        {
            AccountInfoComponent PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();

            List<ServerItem> allserverList = PlayerComponent.AllServerList;
            List<int> myserverList = PlayerComponent.MyServerList;

            List<ServerItem> myServers = new List<ServerItem>();
            for (int i = 0; i < myserverList.Count; i++)
            {
                for (int k = 0; k < allserverList.Count; k++ )
                {
                    if (myserverList[i] == allserverList[k].ServerId)
                    {
                        myServers.Add(allserverList[k]) ;
                        break;
                    }
                }
            }

            switch (page)
            {
                case 0: //服务器列表
                    self.UpdateLatelyServer(myServers).Coroutine();
                    self.UpdateAllServerList(allserverList).Coroutine();
                    break;
                case 1://我的服务器
                    self.UpdateLatelyServer(myServers).Coroutine();
                    self.UpdateAllServerList(myServers).Coroutine();
                    break;
            }
        }

        public static async ETTask UpdateLatelyServer(this UISelectServerComponent self, List<ServerItem> ids)
        {
            long instanceId = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Login/UISelectServerItem");
            GameObject bundleObj =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }

            for (int i = 0; i < ids.Count; i++)
            {
                UI ui_1;
                if (i < self.LateServerUIList.Count)
                {
                    ui_1 = self.LateServerUIList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.LatelyServerNode);
                    ui_1 = self.AddChild<UI, string, GameObject>( "UISelectServerItem_" + i.ToString(), taskTypeItem);
                    UISelectServerItemComponent uIItemComponent = ui_1.AddComponent<UISelectServerItemComponent>();
                    uIItemComponent.SetClickHandler((ServerItem serverId) => { self.OnClickServerItem(serverId); });
                    self.LateServerUIList.Add(ui_1);
                }
                ui_1.GetComponent<UISelectServerItemComponent>().OnUpdateData(ids[i], -1);
            }
            for (int i = ids.Count; i < self.LateServerUIList.Count; i++)
            {
                self.LateServerUIList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask UpdateAllServerList(this UISelectServerComponent self, List<ServerItem> allserverList)
        {
            long instanceId = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Login/UISelectServerItem");
            GameObject bundleObj =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            allserverList.Sort(delegate (ServerItem a, ServerItem b)
            {
                return b.ServerId - a.ServerId;
            });
            for (int i = 0; i < allserverList.Count; i++)
            {
                UI ui_1;
                if (i < self.AllServerUIList.Count)
                {
                    ui_1 = self.AllServerUIList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.ServerListNode);
                    ui_1 = self.AddChild<UI, string, GameObject>( "UISelectServerItem_" + i.ToString(), taskTypeItem);
                    UISelectServerItemComponent uIItemComponent = ui_1.AddComponent<UISelectServerItemComponent>();
                    uIItemComponent.SetClickHandler((ServerItem serverId) => { self.OnClickServerItem(serverId); });
                    self.AllServerUIList.Add(ui_1);
                }
                ui_1.GetComponent<UISelectServerItemComponent>().OnUpdateData(allserverList[i], i);
            }
            for (int i = allserverList.Count; i < self.AllServerUIList.Count; i++)
            {
                self.AllServerUIList[i].GameObject.SetActive(false);
            }
            //await TimerComponent.Instance.WaitAsync(100);
            //if (instanceId != self.InstanceId)
            //{
            //    return;
            //}
            //self.ScrollView1.GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
        }

        public static void OnClickServerItem(this UISelectServerComponent self, ServerItem serverId)
        {
            UI uI = UIHelper.GetUI(self.DomainScene(), UIType.UILogin);
            uI.GetComponent<UILoginComponent>().OnSelectServer(serverId);

            UIHelper.Remove(self.DomainScene(), UIType.UISelectServer);
        }

        public static void OnClickPageButton(this UISelectServerComponent self, int page)
        {
            self.OnUpdateServerList(page);
        }

        public static void CloseUI(this UISelectServerComponent self)
        {
            UIHelper.Remove(self.DomainScene(),UIType.UISelectServer);
        }

    }
}
