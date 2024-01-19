
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFriendChatItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImgHeadIcon;
        public GameObject Imagebg;
        public GameObject Text_TMP;
        public GameObject Text_Name;
        public GameObject Text_Speak;

        public GameObject GameObject;
    }


    public class UIFriendChatItemComponentAwakeSystem : AwakeSystem<UIFriendChatItemComponent, GameObject>
    {
        public override void Awake(UIFriendChatItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Text_TMP = rc.Get<GameObject>("Text_TMP");
            self.Imagebg = rc.Get<GameObject>("Imagebg");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_Speak = rc.Get<GameObject>("Text_Speak");
            self.ImgHeadIcon = rc.Get<GameObject>("ImgHeadIcon");

            //gameObject.GetComponent<TmpClickRichText>().ClickHandler = (string text) => { self.OnClickRickText(text); };
        }
    }

    public static class UIFriendChatItemComponentSystem
    {

        public static void OnClickRickText(this UIFriendChatItemComponent self, string text)
        {
            string[] paramss = text.Split('_');
            self.ZoneScene().GetComponent<TeamComponent>().SendTeamApply(long.Parse(paramss[1]), int.Parse(paramss[2]), int.Parse(paramss[3]), int.Parse(paramss[4]), true).Coroutine();
        }

        //<link="ID">my link</link>
        //<sprite=0>
        public static void OnUpdateUI(this UIFriendChatItemComponent self, ChatInfo chatInfo)
        {
            UICommonHelper.ShowOccIcon(self.ImgHeadIcon, chatInfo.Occ);
            self.Text_Name.GetComponent<Text>().text = chatInfo.PlayerName;

            Text textMeshProUGUI = self.Text_TMP.GetComponent<Text>();
            textMeshProUGUI.text = chatInfo.ChatMsg;

            if (self.Text_TMP.GetComponent<Text>().preferredHeight > 100)
            {
                self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, self.Text_Speak.GetComponent<Text>().preferredHeight + 110);
            }
        }
    }
}
