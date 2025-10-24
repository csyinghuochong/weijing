using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

namespace ET
{
    public class UIMainChatItemComponent : Entity, IAwake<GameObject>
    {
        public bool UpdateHeight;
        public TMP_Text Lab_ChatText;
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
            self.Lab_ChatText = rc.Get<GameObject>("Lab_ChatText").GetComponent<TMP_Text>();
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

        public static void OnLanguageUpdate(this UIMainChatItemComponent self)
        {
            Text[] text = self.GameObject.GetComponentsInChildren<Text>();
            if (text!=null && text.Length > 0)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!text[i].name.Equals("Text"))
                    {
                        continue;
                    }

                    text[i].fontSize = GameSettingLanguge.Language == 0 ? 20 : 16;
                }
            }
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
                self.RectTransform.sizeDelta = new Vector2(400, preferredHeight + 14f);
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
                if (chatInfo == self.m2C_SyncChatInfo)
                {
                    return;
                }

                self.m2C_SyncChatInfo = chatInfo;
                TMP_Text textMeshProUGUI = self.Lab_ChatText;
                string showValue = string.Empty;
                if (!string.IsNullOrEmpty(chatInfo.ChatMsg))
                {
                    int startindex = chatInfo.ChatMsg.IndexOf("<link=");
                    int endindex = chatInfo.ChatMsg.IndexOf("></link>");

                    chatInfo.ChatMsg_EN = !string.IsNullOrEmpty(chatInfo.ChatMsg_EN) ? chatInfo.ChatMsg_EN : chatInfo.ChatMsg;
                    string chatmsginfo = GameSettingLanguge.Language == 0 ? chatInfo.ChatMsg : chatInfo.ChatMsg_EN;

                    if (startindex != -1)
                    {
                        showValue = chatmsginfo.Substring(0, startindex);
                    }
                    else
                    {
                        showValue = chatmsginfo;
                    }

                    // 使用不换行空格的文本
                    showValue = showValue.Replace(" ", "\u00A0");

                    if (chatInfo.ChannelId == (int)ChannelEnum.System)
                    {
                        textMeshProUGUI.text = showValue;
                    }
                    else
                    {
                        //textMeshProUGUI.text = $"{chatInfo.PlayerName}:{showValue}";
                        textMeshProUGUI.text = StringBuilderHelper.GetChatText(chatInfo.PlayerName, showValue);
                    }
                    // textMeshProUGUI.horizontalOverflow = HorizontalWrapMode.Wrap;

                    float preferredHeight = self.Lab_ChatText.preferredHeight;
                    if (preferredHeight > 40f)
                    {
                        self.RectTransform.sizeDelta = new Vector2(400, preferredHeight + 14f);
                    }
                    else
                    {
                        self.RectTransform.sizeDelta = new Vector2(400, 40f);
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
