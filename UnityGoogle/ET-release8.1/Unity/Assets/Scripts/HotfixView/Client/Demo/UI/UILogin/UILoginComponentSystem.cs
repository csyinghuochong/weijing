using GooglePlayGames;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
    [EntitySystemOf(typeof(UILoginComponent))]
    [FriendOf(typeof(UILoginComponent))]
    public static partial class UILoginComponentSystem
    {
        [EntitySystem]
        private static void Awake(this UILoginComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.loginBtn = rc.Get<GameObject>("LoginBtn");

            self.loginBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnLogin(); });
            self.account = rc.Get<GameObject>("Account");
            self.password = rc.Get<GameObject>("Password");

            GameObject.Find("/Global").GetComponent<Init>().GooglePlayGamesSignin();
        }

        public static void OnLogin(this UILoginComponent self)
        {
            if (PlayGamesPlatform.Instance.GetUserId() == "0")
            {
                return;
            }

            LoginHelper.Login(self.Root(), PlayGamesPlatform.Instance.GetUserId(), "123").Coroutine();
        }
    }
}