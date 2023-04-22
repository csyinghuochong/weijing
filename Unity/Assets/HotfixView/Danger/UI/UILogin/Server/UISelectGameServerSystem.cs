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
        public List<UISelectServerItemComponent> LateServerUIList = new List<UISelectServerItemComponent>();
        public List<UISelectServerItemComponent> AllServerUIList = new List<UISelectServerItemComponent>();
    }

        public class UISelectServerComponentAwakeSystem : AwakeSystem<UISelectServerComponent>
        {
            public override void Awake(UISelectServerComponent self)
            {
                self.LateServerUIList.Clear();
                self.AllServerUIList.Clear();

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
                UI uiJoystick = self.AddChild<UI, string, GameObject>("FunctionBtnSet", BtnItemTypeSet);
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

            List<int> myserverids = new List<int>();
            int myserver = PlayerPrefsHelp.GetInt(PlayerPrefsHelp.MyServerID);
            myserver = ServerHelper.GetNewServerId(GlobalHelp.IsBanHaoMode, myserver);
            myserverids.Add(myserver);

            List<int> myoldserveids = PlayerPrefsHelp.GetOldServerIds();
            for (int i = 0; i < myoldserveids.Count; i++)
            { 
                int newids = ServerHelper.GetNewServerId(GlobalHelp.IsBanHaoMode, myoldserveids[i]);
                if (!myserverids.Contains(newids))
                {
                    myserverids.Add(newids);
                }
            }

            List<ServerItem> myServers = new List<ServerItem>();
            List<int> newmyServer = new List<int>();
            for (int i = 0; i < allserverList.Count; i++)
            {
                if (myserverids.Contains( allserverList[i].ServerId ) )
                {
                    myServers.Add(allserverList[i]);
                    newmyServer.Add(allserverList[i].ServerId);
                }
            }

            //去掉先锋区
            for (int i = allserverList.Count - 1; i >= 0; i--)
            {
                bool xianfenzone = allserverList[i].ServerId == 5 || allserverList[i].ServerId == 9;
                if (!xianfenzone)
                {
                    continue;
                }
                if (!newmyServer.Contains(allserverList[i].ServerId))
                {
                   // allserverList.RemoveAt(i);
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
                UISelectServerItemComponent ui_1;
                if (i < self.LateServerUIList.Count)
                {
                    ui_1 = self.LateServerUIList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.LatelyServerNode);
                    ui_1 = self.AddChild<UISelectServerItemComponent, GameObject>( taskTypeItem);
                    ui_1.SetClickHandler((ServerItem serverId) => { self.OnClickServerItem(serverId); });
                    self.LateServerUIList.Add(ui_1);
                }
                ui_1.OnUpdateData(ids[i], -1);
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
                UISelectServerItemComponent ui_1;
                if (i < self.AllServerUIList.Count)
                {
                    ui_1 = self.AllServerUIList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.ServerListNode);
                    ui_1 = self.AddChild<UISelectServerItemComponent, GameObject>( taskTypeItem);
                    ui_1.SetClickHandler((ServerItem serverId) => { self.OnClickServerItem(serverId); });
                    self.AllServerUIList.Add(ui_1);
                }
                ui_1.OnUpdateData(allserverList[i], i);
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
