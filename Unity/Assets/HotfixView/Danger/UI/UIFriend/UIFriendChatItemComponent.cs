
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFriendChatItemComponent : Entity, IAwake
    {
        public GameObject ImgHeadIcon;
        public GameObject Imagebg;
        public GameObject Text_TMP;
        public GameObject Text_Name;
        public GameObject Text_Speak;
    }

    [ObjectSystem]
    public class UIFriendChatItemComponentAwakeSystem : AwakeSystem<UIFriendChatItemComponent>
    {
        public override void Awake(UIFriendChatItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Text_TMP = rc.Get<GameObject>("Text_TMP");
            self.Imagebg = rc.Get<GameObject>("Imagebg");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_Speak = rc.Get<GameObject>("Text_Speak");
            self.ImgHeadIcon = rc.Get<GameObject>("ImgHeadIcon");

            self.GetParent<UI>().GameObject.GetComponent<TmpClickRichText>().ClickHandler = (string text) => { self.OnClickRickText(text); };
        }
    }

    public static class UIFriendChatItemComponentSystem
    {

        public static void OnClickRickText(this UIFriendChatItemComponent self, string text)
        {
            string[] paramss = text.Split('_');
            self.ZoneScene().GetComponent<TeamComponent>().SendTeamApply(long.Parse(paramss[1]), int.Parse(paramss[2]), int.Parse(paramss[3]), int.Parse(paramss[4])).Coroutine();
        }

        //<link="ID">my link</link>
        //<sprite=0>
        public static void OnUpdateUI(this UIFriendChatItemComponent self, ChatInfo chatInfo)
        {
            UICommonHelper.ShowOccIcon(self.ImgHeadIcon, chatInfo.Occ);
            self.Text_Name.GetComponent<Text>().text = chatInfo.PlayerName;

            TextMeshProUGUI textMeshProUGUI = self.Text_TMP.GetComponent<TextMeshProUGUI>();
            textMeshProUGUI.text = chatInfo.ChatMsg;

            if (self.Text_TMP.GetComponent<TextMeshProUGUI>().preferredHeight > 100)
            {
                self.GetParent<UI>().GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, self.Text_Speak.GetComponent<TextMeshProUGUI>().preferredHeight + 110);
            }
        }
    }
}
