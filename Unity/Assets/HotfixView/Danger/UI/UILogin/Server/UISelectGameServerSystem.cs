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
        public GameObject UISelectServerItem;
        public GameObject ImageButton;
        public GameObject FunctionSetBtn;
        public GameObject FunctionSelectServerBtn;

        public bool TestMulServer = false;

        public UIPageButtonComponent uIPageView;
        public List<UISelectServerItemComponent> LateServerUIList = new List<UISelectServerItemComponent>();
        public List<UISelectServerItemComponent> AllServerUIList = new List<UISelectServerItemComponent>();
       }

        public class UISelectServerComponentAwakeSystem : AwakeSystem<UISelectServerComponent>
        {
            public override void Awake(UISelectServerComponent self)
            {
                if (GlobalHelp.IsOutNetMode)
                {
                    //self.TestMulServer = true;
                    //self.TestMulServer = GlobalHelp.GetPlatform() == 20001;
                }

                self.LateServerUIList.Clear();
                self.AllServerUIList.Clear();

                ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

                self.ScrollView1 = rc.Get<GameObject>("ScrollView1");
                self.LatelyServerNode = rc.Get<GameObject>("LatelyServerNode");
                self.ButtonClose = rc.Get<GameObject>("ButtonClose");
                self.ServerListNode = rc.Get<GameObject>("ServerListNode");
                self.UISelectServerItem = rc.Get<GameObject>("UISelectServerItem");
                self.UISelectServerItem.SetActive(false);
                self.ImageButton = rc.Get<GameObject>("ImageButton");
                self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");

                self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.CloseUI(); });
                self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.CloseUI(); });

                GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
                UI uiJoystick = self.AddChild<UI, string, GameObject>("FunctionBtnSet", BtnItemTypeSet);
                UIPageButtonComponent uIPageViewComponent = uiJoystick.AddComponent<UIPageButtonComponent>();
                self.uIPageView = uIPageViewComponent;
                uIPageViewComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
                uIPageViewComponent.OnSelectIndex(0);

                GameObject FunctionSelectServerBtn = rc.Get<GameObject>("FunctionSelectServerBtn");
                UI functionSelectServerUI = self.AddChild<UI, string, GameObject>("FunctionSelectServerBtn", FunctionSelectServerBtn);
          
                UIPageButtonComponent uIPageViewComponent2 = functionSelectServerUI.AddComponent<UIPageButtonComponent>();
                uIPageViewComponent2.SetClickHandler((int page) => { self.OnClickPageButton_2(page); });
                uIPageViewComponent2.OnSelectIndex(0);
                FunctionSelectServerBtn.SetActive(false);
                FunctionSelectServerBtn.transform.Find("Btn_SelectServer3").gameObject.SetActive(false);

                FunctionSelectServerBtn.SetActive(self.TestMulServer);
            }
        }

     public static class UISelectServerComponentSystem

    {
        public static void OnUpdateServerList(this UISelectServerComponent self, int page)
        {
            AccountInfoComponent PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();

            List<ServerItem> allserverList = PlayerComponent.AllServerList;
            int platform = GlobalHelp.GetPlatform();
           
            string lastAccount = string.Empty;
            string lastloginType = PlayerPrefsHelp.GetString(PlayerPrefsHelp.LastLoginType);
            if (!string.IsNullOrEmpty(lastloginType))
            {
                lastAccount = PlayerPrefsHelp.GetString(PlayerPrefsHelp.LastAccount(lastloginType));
            }

            for (int i = allserverList.Count - 1; i >= 0; i--)
            {
                if (self.TestMulServer)
                {
                    continue;
                }

                if (!allserverList[i].PlatformList.Contains(platform) && platform!= 8)
                {
                    allserverList.RemoveAt(i);
                    continue;
                }
            }

            List<int> myserverids = new List<int>();
            int myserver = PlayerPrefsHelp.GetInt(PlayerPrefsHelp.MyServerID);
            myserver = ServerHelper.GetNewServerId( myserver);
            myserverids.Add(myserver);

            List<int> myoldserveids = PlayerPrefsHelp.GetOldServerIds();
            for (int i = 0; i < myoldserveids.Count; i++)
            { 
                int newids = ServerHelper.GetNewServerId( myoldserveids[i]);
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

            switch (page)
            {
                case 0: //服务器列表
                    self.UpdateLatelyServer(myServers);
                    self.UpdateAllServerList(allserverList);
                    break;
                case 1://我的服务器
                    self.UpdateLatelyServer(myServers);
                    self.UpdateAllServerList(myServers);
                    break;
            }
        }

        public static  void UpdateLatelyServer(this UISelectServerComponent self, List<ServerItem> ids)
        {
            long instanceId = self.InstanceId;
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
                    GameObject taskTypeItem = GameObject.Instantiate(self.UISelectServerItem);
                    taskTypeItem.SetActive(true);
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

        public static  void UpdateAllServerList(this UISelectServerComponent self, List<ServerItem> allserverList)
        {
            long instanceId = self.InstanceId;
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
                    GameObject taskTypeItem = GameObject.Instantiate(self.UISelectServerItem);
                    taskTypeItem.SetActive(true);
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

        public static void OnClickPageButton_2(this UISelectServerComponent self, int page)
        {
            Log.ILog.Debug($"OnClickPageButton_2:{page}");

            if (self.TestMulServer)
            {

                AccountInfoComponent PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();
                if (page == 0)
                {
                    ServerHelper.InitServerList("StartConfig/Beta");
                }
                else if (page == 1)
                {
                    ServerHelper.InitServerList("StartConfig/Google");
                }
                else
                {
                    return;
                }


                List<ServerItem> serverItems = ServerHelper.GetServerList();
            
                LoginHelper.CheckServerList(serverItems, VersionMode.Beta);


                long serverTime = TimeHelper.ServerNow();
                List<ServerItem> validServerList = new List<ServerItem>();  
                for (int i = 0; i < serverItems.Count; i++)
                {
                    //128服只有主播账号才显示。。
                    if (ComHelp.IsZhuBoZone(serverItems[i].ServerId))
                    {
                        continue;
                    }
                    if (serverItems[i].Show != 0 && serverItems[i].ServerOpenTime <= serverTime)
                    {
                        validServerList.Add(serverItems[i]);
                    }
                }

                PlayerComponent.AllServerList.Clear();
                PlayerComponent.AllServerList = validServerList;    
                self.OnUpdateServerList(self.uIPageView.GetCurrentIndex());
            }

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
