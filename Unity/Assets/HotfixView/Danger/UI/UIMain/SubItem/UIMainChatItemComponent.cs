using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

namespace ET
{
    public class UIMainChatItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Lab_ChatText;
        public GameObject ImageButton;
        public GameObject[] TitleList = new GameObject[3];

        public ChatInfo m2C_SyncChatInfo;
        public Action ClickHanlder;
        public GameObject GameObject;
    }

    [ObjectSystem]
    public class UIMainChatItemComponentAwakeSystem : AwakeSystem<UIMainChatItemComponent, GameObject>
    {
        public override void Awake(UIMainChatItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Lab_ChatText = rc.Get<GameObject>("Lab_ChatText");

            self.TitleList[0] = rc.Get<GameObject>("0");
            self.TitleList[1] = rc.Get<GameObject>("1");
            self.TitleList[2] = rc.Get<GameObject>("2");
            self.TitleList[0].SetActive(false);
            self.TitleList[1].SetActive(false);
            self.TitleList[2].SetActive(false);

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
            if (!self.GameObject.activeSelf)
            {
                return;
            }
            TextMeshProUGUI textMeshProUGUI = self.Lab_ChatText.GetComponent<TextMeshProUGUI>();
            if (textMeshProUGUI.GetComponent<TextMeshProUGUI>().preferredHeight > 40)
            {
                self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(400, textMeshProUGUI.GetComponent<TextMeshProUGUI>().preferredHeight);
            }
        }

        //<link="ID">my link</link>
        //<sprite=0>
        public static  void OnUpdateUI(this UIMainChatItemComponent self, ChatInfo chatInfo)
        {
            self.m2C_SyncChatInfo = chatInfo;
            TextMeshProUGUI textMeshProUGUI = self.Lab_ChatText.GetComponent<TextMeshProUGUI>();

            if (chatInfo.ChannelId == (int)ChannelEnum.System)
            {
                textMeshProUGUI.text = chatInfo.ChatMsg;
            }
            else
            {
                //<color=#FFFF00>白泪伊1</color>: 12112
                //textMeshProUGUI.text = $"<color=#FFFF00>{chatInfo.PlayerName}</color>: {chatInfo.ChatMsg}";
                textMeshProUGUI.text = $"{chatInfo.PlayerName} : {chatInfo.ChatMsg}";
            }
            self.TitleList[chatInfo.ChannelId].SetActive(true);
        }
    }

}
