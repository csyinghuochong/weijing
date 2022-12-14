
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChatItemComponent : Entity, IAwake
    {
        public GameObject Text_System_TMP;
        public GameObject Node2;
        public GameObject Node1;
        public GameObject Text_Level;
        public GameObject Imagebg;
        public GameObject Text_TMP;
        public GameObject Text_Name;
        public GameObject Text_Speak;
        public GameObject Obj_ImgHeadIcon;
        public GameObject Obj_ImgHeadIconXiTong;

        public GameObject[] TitleList = new GameObject[3];
    }

    [ObjectSystem]
    public class UIChatItemComponentAwakeSystem : AwakeSystem<UIChatItemComponent>
    {
        public override void Awake(UIChatItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Text_Level = rc.Get<GameObject>("Text_Level");
            self.Text_TMP = rc.Get<GameObject>("Text_TMP");
            self.Imagebg = rc.Get<GameObject>("Imagebg");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
 
            self.Obj_ImgHeadIcon = rc.Get<GameObject>("ImgHeadIcon");
            self.Obj_ImgHeadIconXiTong = rc.Get<GameObject>("ImgHeadIconXiTong");
            self.Text_System_TMP = rc.Get<GameObject>("Text_System_TMP");
            self.Node2 = rc.Get<GameObject>("Node2");
            self.Node1 = rc.Get<GameObject>("Node1");
            self.Node2.SetActive(false);
            self.Node1.SetActive(false);

            self.TitleList[0] = rc.Get<GameObject>("0");
            self.TitleList[1] = rc.Get<GameObject>("1");
            self.TitleList[2] = rc.Get<GameObject>("2");

            self.GetParent<UI>().GameObject.GetComponent<TmpClickRichText>().ClickHandler = (string text) => { self.OnClickRickText(text);  };
        }
    }

    public static class UIChatItemComponentSystem
    {

        public static void OnClickRickText(this UIChatItemComponent self, string text)
        {
            string[] paramss = text.Split('_');
            self.ZoneScene().GetComponent<TeamComponent>().SendTeamApply(long.Parse(paramss[1]), int.Parse(paramss[2]), int.Parse(paramss[3]), int.Parse(paramss[4])).Coroutine();
        }

        //<link="ID">my link</link>
        //<sprite=0>
        public static void OnUpdateUI(this UIChatItemComponent self, ChatInfo chatInfo)
        {
            self.Node1.SetActive(chatInfo.ChannelId != (int)ChannelEnum.System);
            self.Node2.SetActive(chatInfo.ChannelId == (int)ChannelEnum.System);
            if (chatInfo.ChannelId == (int)ChannelEnum.System)
            {
                TextMeshProUGUI textMeshProUGUI = self.Text_System_TMP.GetComponent<TextMeshProUGUI>();
                textMeshProUGUI.text = chatInfo.ChatMsg;

                self.GetParent<UI>().GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, self.Text_System_TMP.GetComponent<TextMeshProUGUI>().preferredHeight + 50);
            }
            else
            {
                self.Text_Name.GetComponent<Text>().text = chatInfo.PlayerName;

                self.Text_Level.GetComponent<Text>().text = chatInfo.PlayerLevel.ToString();

                TextMeshProUGUI textMeshProUGUI = self.Text_TMP.GetComponent<TextMeshProUGUI>();
                textMeshProUGUI.text = chatInfo.ChatMsg;

                if (self.Text_TMP.GetComponent<TextMeshProUGUI>().preferredHeight > 100)
                {
                    self.GetParent<UI>().GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, self.Text_TMP.GetComponent<TextMeshProUGUI>().preferredHeight + 110);
                }

                self.TitleList[0].SetActive(false);
                self.TitleList[1].SetActive(false);
                self.TitleList[2].SetActive(false);
                self.TitleList[chatInfo.ChannelId].SetActive(true);

                if (chatInfo.ChannelId == 1)
                {
                    self.Obj_ImgHeadIcon.SetActive(false);
                    self.Obj_ImgHeadIconXiTong.SetActive(true);
                }
                else
                {
                    self.Obj_ImgHeadIcon.SetActive(true);
                    self.Obj_ImgHeadIconXiTong.SetActive(false);
                    UICommonHelper.ShowOccIcon(self.Obj_ImgHeadIcon, chatInfo.Occ);
                }
            }
        }
    }
}
