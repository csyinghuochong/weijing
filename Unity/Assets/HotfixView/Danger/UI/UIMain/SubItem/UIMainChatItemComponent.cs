using UnityEngine;
using System;
using UnityEngine.UI;

namespace ET
{
    public class UIMainChatItemComponent : Entity, IAwake<GameObject>
    {
        public bool UpdateHeight;
        public GameObject Lab_ChatText;
        public GameObject ImageButton;
        public GameObject[] TitleList = new GameObject[ChannelEnum.Number];

        public ChatInfo m2C_SyncChatInfo;
        public Action ClickHanlder;
        public GameObject GameObject;
    }

    public class UIMainChatItemComponentAwakeSystem : AwakeSystem<UIMainChatItemComponent, GameObject>
    {
        public override void Awake(UIMainChatItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Lab_ChatText = rc.Get<GameObject>("Lab_ChatText");

            for (int i = 0; i < ChannelEnum.Number; i++)
            {
                self.TitleList[i] = rc.Get<GameObject>(i.ToString());
                self.TitleList[i].SetActive(false);
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
            if (!self.GameObject.activeSelf || !self.UpdateHeight)
            {
                return;
            }
            self.UpdateHeight = false;
            Text textMeshProUGUI = self.Lab_ChatText.GetComponent<Text>();
            if (textMeshProUGUI.GetComponent<Text>().preferredHeight > 40)
            {
                self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(400, textMeshProUGUI.GetComponent<Text>().preferredHeight);
            }
            else
            {
                self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(400, 40);
            }
            self.GameObject.SetActive(false);
            self.GameObject.SetActive(true);
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
                }

                else
                {
                    //<color=#FFFF00>白泪伊1</color>: 12112
                    //textMeshProUGUI.text = $"<color=#FFFF00>{chatInfo.PlayerName}</color>: {chatInfo.ChatMsg}";
                    textMeshProUGUI.text = $"{chatInfo.PlayerName}:{showValue}";
                }

                if (textMeshProUGUI.preferredHeight > 40)
                {
                    self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(400, textMeshProUGUI.preferredHeight + 50);
                }
                else
                {
                    self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(400, 40);
                }
                if (chatInfo.ChannelId >= 0 && chatInfo.ChannelId < self.TitleList.Length)
                {
                    self.TitleList[chatInfo.ChannelId].SetActive(true);
                }
            }
            catch (Exception ex)
            {
                Log.ILog.Error(ex.ToString());
            }
        }
    }

}
