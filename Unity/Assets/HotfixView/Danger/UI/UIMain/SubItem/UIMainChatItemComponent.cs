using UnityEngine;
using System;
using UnityEngine.UI;

namespace ET
{
    public class UIMainChatItemComponent : Entity, IAwake<GameObject>
    {
        public bool UpdateHeight;
        public Text Lab_ChatText;
        public GameObject ImageButton;
        public GameObject[] TitleList = new GameObject[ChannelEnum.Number];

        public ChatInfo m2C_SyncChatInfo;
        public Action ClickHanlder;
        public GameObject GameObject;
        public RectTransform RectTransform;
    }

    public class UIMainChatItemComponentAwakeSystem : AwakeSystem<UIMainChatItemComponent, GameObject>
    {
        public override void Awake(UIMainChatItemComponent self, GameObject gameObject)
        {
            self.UpdateHeight = false;
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Lab_ChatText = rc.Get<GameObject>("Lab_ChatText").GetComponent<Text>();
            self.RectTransform = gameObject.GetComponent<RectTransform>();

            //-157.6  -15.9
            for (int i = 0; i < ChannelEnum.Number; i++)
            {
                self.TitleList[i] = rc.Get<GameObject>(i.ToString());
                self.TitleList[i].transform.localPosition = new Vector3(- 300f, -15.9f, 0);
            }

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.ClickHanlder(); });
        }
    }

    public static class UIMainChatItemComponentSystem
    {

        public static void SetClickHandler(this UIMainChatItemComponent self, Action action)
        {
            self.ClickHanlder = action;
        }

        public static  void UpdateHeight(this UIMainChatItemComponent self)
        {
            if (!self.UpdateHeight)
            {
                return;
            }
            self.UpdateHeight = false;
            float preferredHeight = self.Lab_ChatText.preferredHeight;
            if (preferredHeight > 40f)
            {
                self.RectTransform.sizeDelta = new Vector2(400, preferredHeight + 50);
                self.GameObject.SetActive(false);
                self.GameObject.SetActive(true);
            }
            else
            {
                self.RectTransform.sizeDelta = new Vector2(400, 40);
            }
        }

        //<link="ID">my link</link>
        //<sprite=0>
        public static  void OnUpdateUI(this UIMainChatItemComponent self, ChatInfo chatInfo)
        {
            try
            {
                self.UpdateHeight = true;
                self.m2C_SyncChatInfo = chatInfo;
                Text textMeshProUGUI = self.Lab_ChatText.GetComponent<Text>();

                string showValue = string.Empty;
                if (!string.IsNullOrEmpty(chatInfo.ChatMsg))
                {
                    int startindex = chatInfo.ChatMsg.IndexOf("<link=");
                    int endindex = chatInfo.ChatMsg.IndexOf("></link>");
                    if (startindex != -1)
                    {
                        showValue = chatInfo.ChatMsg.Substring(0, startindex);
                    }
                    else
                    {
                        showValue = chatInfo.ChatMsg;
                    }

                    if (chatInfo.ChannelId == (int)ChannelEnum.System)
                    {
                        textMeshProUGUI.text = showValue;
                    }
                    else
                    {
                        textMeshProUGUI.text = StringBuilderHelper.GetChatText(chatInfo.PlayerName, showValue);
                    }
                    float preferredHeight = self.Lab_ChatText.preferredHeight;
                    if (preferredHeight > 40f)
                    {
                        self.RectTransform.sizeDelta = new Vector2(400, preferredHeight + 50);
                    }
                    else
                    {
                        self.RectTransform.sizeDelta = new Vector2(400, 40);
                    }
                    if (chatInfo.ChannelId >= 0 && chatInfo.ChannelId < self.TitleList.Length)
                    {
                        for(int i = 0; i < self.TitleList.Length; i++)
                        {
                            self.TitleList[i].transform.localPosition = i == chatInfo.ChannelId ? new Vector3(-157.6f, -15.9f, 0) : new Vector3(-300f, -15.9f, 0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.ILog.Error(ex.ToString());
            }
        }
    }

}
