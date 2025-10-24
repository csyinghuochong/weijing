using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChatItemComponent : Entity, IAwake<GameObject>
    {
        public ChatInfo mChatInfo;
        public TMP_Text Text_System_TMP;
        public GameObject Node2;
        public GameObject Node1;
        public GameObject Text_Level;
        public GameObject Imagebg;
        public TMP_Text Text_TMP;
        public GameObject Text_Name;
        public GameObject Text_Speak;
        public GameObject Obj_ImgHeadIcon;
        public GameObject Obj_ImgHeadIconXiTong;
        public GameObject GameObject;

        public GameObject[] TitleList = new GameObject[ChannelEnum.Number];
    }


    public class UIChatItemComponentAwakeSystem : AwakeSystem<UIChatItemComponent, GameObject>
    {
        public override void Awake(UIChatItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Text_Level = rc.Get<GameObject>("Text_Level");
            self.Text_TMP = rc.Get<GameObject>("Text_TMP").GetComponent<TMP_Text>();
            self.Imagebg = rc.Get<GameObject>("Imagebg");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
 
            self.Obj_ImgHeadIcon = rc.Get<GameObject>("ImgHeadIcon");
            self.Obj_ImgHeadIconXiTong = rc.Get<GameObject>("ImgHeadIconXiTong");
            self.Text_System_TMP = rc.Get<GameObject>("Text_System_TMP").GetComponent<TMP_Text>();
            self.Node2 = rc.Get<GameObject>("Node2");
            self.Node1 = rc.Get<GameObject>("Node1");
            self.Node2.SetActive(false);
            self.Node1.SetActive(false);

            for (int i = 0; i < ChannelEnum.Number; i++)
            {
                self.TitleList[i] = rc.Get<GameObject>(i.ToString());
                self.TitleList[i].SetActive(false);
            }

            //self.GameObject.GetComponent<TmpClickRichText>().ClickHandler = (string text) => { self.OnClickRickText(text);  };
            self.Obj_ImgHeadIcon.GetComponent<Button>().onClick.AddListener(() => { self.OnWatchNemu().Coroutine(); });
            self.Text_Name.GetComponent<Button>().onClick.AddListener(() => { self.OnWatchNemu().Coroutine(); });
            self.Text_TMP.GetComponent<Button>().onClick.AddListener(self.OnText_TMP);
        }
    }

    public static class UIChatItemComponentSystem
    {
        public static async ETTask OnWatchNemu(this UIChatItemComponent self)
        {
            if (self.mChatInfo.UserId == UnitHelper.GetMyUnitId(self.ZoneScene()))
            {
                return;
            }

            //bool jinyan = !self.mChatInfo.ChatMsg.Contains("<link=team_");
            UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIWatchMenu);
            uI.GetComponent<UIWatchMenuComponent>().OnUpdateUI_1(MenuEnumType.Chat, self.mChatInfo.UserId, self.mChatInfo.PlayerName, true).Coroutine();
        }

        public static async ETTask OnClickRickText(this UIChatItemComponent self, string text)
        {
            string[] paramss = text.Split('_');
            if (paramss[0] == "team" && paramss.Length >= 5 )
            {
                self.ZoneScene().GetComponent<TeamComponent>().SendTeamApply(long.Parse(paramss[1]), int.Parse(paramss[2]), int.Parse(paramss[3]), int.Parse(paramss[4]), true).Coroutine();
            }

            if (paramss[0] == "paimai")
            {
                UI uI = await UIHelper.Create( self.ZoneScene(), UIType.UIPaiMai );
                uI.GetComponent<UIPaiMaiComponent>().OnClickGoToPaiMai(int.Parse(paramss[1]), long.Parse(paramss[2])).Coroutine();
            }
        }

        public static void OnText_TMP(this UIChatItemComponent self)
        {
            ChatInfo chatInfo = self.mChatInfo;

            int startindex = chatInfo.ChatMsg.IndexOf("<link=");
            int endindex = chatInfo.ChatMsg.IndexOf("></link>");

            if (startindex == -1 || endindex == -1)
            {
                return;
            }

            startindex += 6;
            int lenght = endindex - startindex;
            if (lenght <= 0)
            {
                return;
            }

            string showValue = string.Empty;
            showValue = chatInfo.ChatMsg.Substring(startindex, lenght);
            // < link = team_{ teamInfo.TeamId}
            //_{ teamInfo.SceneId}
            //_{ teamInfo.FubenType}
            //_{ teamInfo.PlayerList[0].PlayerLv}>< color =#B5FF28><u>点击申请加入</u></color></link>";

           
            self.OnClickRickText(showValue).Coroutine();
        }

        //<link="ID">my link</link>
        //<sprite=0>
        public static void OnUpdateUI(this UIChatItemComponent self, ChatInfo chatInfo)
        {
            GameSettingLanguge.TransformText(self.GameObject.transform);
            
            self.mChatInfo = chatInfo;

            int startindex = chatInfo.ChatMsg.IndexOf("<link=");
            int endindex = chatInfo.ChatMsg.IndexOf("></link>");

            string showValue = string.Empty;

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

            if (chatInfo.ChannelId == (int)ChannelEnum.System || chatInfo.ChannelId == ChannelEnum.Pick)
            {
                self.Node1.SetActive(false);
                self.Node2.SetActive(true);

                self.Text_System_TMP.text = showValue;

                self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, self.Text_System_TMP.preferredHeight + 50);
            }
            else
            {
                self.Node1.SetActive(true);
                self.Node2.SetActive(false);

                self.Text_Name.GetComponent<Text>().text = chatInfo.PlayerName;

                self.Text_Level.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("等级：{0}"), chatInfo.PlayerLevel.ToString());

                self.Text_TMP.text = showValue;

                if (self.Text_TMP.preferredHeight > 100)
                {
                    self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, self.Text_TMP.preferredHeight + 110);
                }
                else
                {
                    self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, 200);
                }

                for (int i = 0; i < ChannelEnum.Number; i++)
                {
                    self.TitleList[i].SetActive(false);
                }
                self.TitleList[chatInfo.ChannelId].SetActive(true);

                //if (chatInfo.ChannelId == ChannelEnum.Word)
                //{
                //    self.Obj_ImgHeadIcon.SetActive(false);
                //    self.Obj_ImgHeadIconXiTong.SetActive(true);
                //}
                //else
                {
                    self.Obj_ImgHeadIcon.SetActive(true);
                    self.Obj_ImgHeadIconXiTong.SetActive(false);
                    UICommonHelper.ShowOccIcon(self.Obj_ImgHeadIcon, chatInfo.Occ);
                }

                self.GameObject.SetActive(false);
                self.GameObject.SetActive(true);
            }
        }
    }
}
