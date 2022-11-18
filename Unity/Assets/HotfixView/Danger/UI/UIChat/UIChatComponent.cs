using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public class UIChatComponent : Entity, IAwake, IDestroy
    {

        public GameObject ChatSendNode;
        public GameObject UIChatEmoji;
        public GameObject ButtonEmoji;
        public GameObject InputFieldTMP;
        public GameObject Btn_Close;
        public GameObject FunctionSetBtn;
        public GameObject ChatContent;
        public GameObject ButtonSend;
        public ScrollRect ScrollRect;

        public UI UIPageComponent;
        public List<UI> ChatUIList = new List<UI>();
    }

    [ObjectSystem]
    public class UIChatComponentAwakeSystem : AwakeSystem<UIChatComponent>
    {
        public override void Awake(UIChatComponent self)
        {
            self.ChatUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChat(); });

            self.InputFieldTMP = rc.Get<GameObject>("InputFieldTMP");
            self.InputFieldTMP.GetComponent<TMP_InputField>().onValueChanged.AddListener((string text) => { self.CheckSensitiveWords(); });

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            self.ChatContent = rc.Get<GameObject>("ChatContent");
           
            self.ButtonEmoji = rc.Get<GameObject>("ButtonEmoji");
            self.ButtonEmoji.GetComponent<Button>().onClick.AddListener(() => { self.OnShowEmoji(); });

            self.ButtonSend = rc.Get<GameObject>("ButtonSend");
            self.ButtonSend.GetComponent<Button>().onClick.AddListener(() => { self.OnSendChat(); });
            self.ChatSendNode = rc.Get<GameObject>("ChatSendNode");
            self.ScrollRect = rc.Get<GameObject>("ScrollView").GetComponent<ScrollRect>();

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>( "FunctionSetBtn", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageComponent = uiPage;
            uIPageViewComponent.OnSelectIndex(0);

            self.UIChatEmoji = rc.Get<GameObject>("UIChatEmoji");
            self.UIChatEmoji.SetActive(false);
            UI uiEmoji = self.AddChild<UI, string, GameObject>( "UIChatEmoji", self.UIChatEmoji);
            UIChatEmojiComponent uIChatEmojiComponent = uiEmoji.AddComponent<UIChatEmojiComponent>();
            uIChatEmojiComponent.SetClickHandler((string button)=> { self.OnClckEmojiItem(button); });

            DataUpdateComponent.Instance.AddListener(DataType.OnRecvChat, self);
        }
    }

    [ObjectSystem]
    public class UIChatComponentDestroySystem : DestroySystem<UIChatComponent>
    {

        public override void Destroy(UIChatComponent self)
        {
            self.ChatContent = null;
            DataUpdateComponent.Instance.RemoveListener(DataType.OnRecvChat, self);
        }
    }

    public static class UIChatComponentSystem
    {

        public static void OnShowEmoji(this UIChatComponent self)
        {
            self.UIChatEmoji.SetActive(!self.UIChatEmoji.activeSelf);
        }

        public static void OnClckEmojiItem(this UIChatComponent self, string emoji)
        {
            string text = self.InputFieldTMP.GetComponent<TMP_InputField>().text;
            text = text + $"<sprite={emoji}>";
            self.InputFieldTMP.GetComponent<TMP_InputField>().text = text;
        }

        public static void OnClickPageButton(this UIChatComponent self, int type)
        {
            self.OnChatRecv().Coroutine();
        }

        public static void OnCloseChat(this UIChatComponent self)
        {
            UIHelper.Remove( self.DomainScene(), UIType.UIChat );
        }

        public static async ETTask OnChatRecv(this UIChatComponent self)
        {
            int itemType = self.UIPageComponent.GetComponent<UIPageButtonComponent>().GetCurrentIndex();
            List<ChatInfo> chatlist = self.ZoneScene().GetComponent<ChatComponent>().GetChatListByType((ChannelEnum)itemType);
            self.ChatSendNode.SetActive(itemType != (int)ChannelEnum.System);
            GameObject chatItem = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(ABPathHelper.GetUGUIPath("Main/Chat/UIChatItem"));
            for (int i = 0; i < chatlist.Count; i++)
            {
                UI ui_2 = null;
                if (i < self.ChatUIList.Count)
                {
                    ui_2 = self.ChatUIList[i];
                    ui_2.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(chatItem);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.ChatContent);
                    ui_2 = self.AddChild<UI, string, GameObject>("chatItem_" + i.ToString(), itemSpace);
                    ui_2.AddComponent<UIChatItemComponent>();
                    self.ChatUIList.Add(ui_2);
                }

                ui_2.GetComponent<UIChatItemComponent>().OnUpdateUI(chatlist[i]);
            }
            for (int i = chatlist.Count; i < self.ChatUIList.Count; i++)
            {
                self.ChatUIList[i].GameObject.SetActive(false);
            }

            self.UpdatePosition().Coroutine();
        }

        public static async ETTask UpdatePosition(this UIChatComponent self)
        {
            await TimerComponent.Instance.WaitAsync(10);
            if (self.ChatContent == null)
                return;

            self.ScrollRect.GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
            //RectTransform rectTransform = self.ChatContent.GetComponent<RectTransform>();
            //if (rectTransform.sizeDelta.y > 600)
            //{
            //    rectTransform.anchoredPosition = new Vector2(0, rectTransform.sizeDelta.y - 600);
            //}
        }

        public static void CheckSensitiveWords(this UIChatComponent self)
        {
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            bool gm = GMHelp.GmAccount.Contains(accountInfoComponent.Account);
            if (gm)
            {
                return;
            }
            string text_new = "";
            string text_old = self.InputFieldTMP.GetComponent<TMP_InputField>().text;
            if (text_old.Equals("#etgm"))
                return;
            MaskWordHelper.Instance.IsContainSensitiveWords(ref text_old,out text_new);
            self.InputFieldTMP.GetComponent<TMP_InputField>().text = text_old;
        }

        public static void OnSendChat(this UIChatComponent self)
        {
            string text = self.InputFieldTMP.GetComponent<TMP_InputField>().text;
            if (string.IsNullOrEmpty(text) || text.Length == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请输入聊天内容！");
                return;
            }

            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            bool gm = GMHelp.GmAccount.Contains(accountInfoComponent.Account);
            bool mask = false;
            if (!gm)
            {
                mask = MaskWordHelper.Instance.IsContainSensitiveWords(text);
            }
            if (text.Equals("#etgm"))
            {
                UIHelper.Create(self.DomainScene(), UIType.UIGM).Coroutine();
                return;
            }
            if (mask)
            {
                FloatTipManager.Instance.ShowFloatTip("请重新输入！");
                return;
            }

            int itemType = self.UIPageComponent.GetComponent<UIPageButtonComponent>().GetCurrentIndex();
            if (itemType == (int)ChannelEnum.Team && !self.ZoneScene().GetComponent<TeamComponent>().IsHaveTeam())
            {
                FloatTipManager.Instance.ShowFloatTip("没有队伍！");
                return;
            }
            
            if (text.Contains("#"))
            {
                string[] commands = text.Split('#');
                if (commands[0] == "3")
                {
                    EnterFubenHelp.EnterFubenRequest(self.DomainScene(), FubenDifficulty.Normal, int.Parse(commands[1])).Coroutine();
                    return;
                }
                if (commands[1].Contains("pg"))
                {
                    UI uimain = UIHelper.GetUI(self.DomainScene(), UIType.UIMain);
                    uimain.GetComponent<UIMainComponent>().ShowPing().Coroutine();
                    return;
                }
                if (commands[1].Contains("alltask"))
                {
                    List<TaskConfig> tasks = TaskConfigCategory.Instance.GetAll().Values.ToList();
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        if (tasks[i].TaskType != (int)TaskTargetType.ItemID_Number_2)
                        {
                            continue;
                        }
                        int monster = tasks[i].Target[0];
                        if (!MonsterConfigCategory.Instance.Contain(monster))
                        {
                            Log.Error($"任务ID: {tasks[i].Id} 错误怪物ID: {monster}");
                        }
                    }
                    return;
                }
                if (commands[1].Contains("chuji")
                    || commands[1].Contains("zhongji")
                     || commands[1].Contains("zhongji")
                    )
                {
                    GMHelp.SendGmCommands(self.ZoneScene(), text);
                    return;
                }
                GMHelp.SendGmCommand( self.ZoneScene(), text);
            }
            else
            {
                UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
                if (GMHelp.BanChatPlayer.Contains(userInfo.UserId))
                {
                    FloatTipManager.Instance.ShowFloatTip("被禁言中！");
                    return;
                }
                self.ZoneScene().GetComponent<ChatComponent>().SendChat((ChannelEnum)itemType, text).Coroutine();
            }

            self.InputFieldTMP.GetComponent<TMP_InputField>().text = "";
        }

    }

}