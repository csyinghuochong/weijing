using System.Collections.Generic;
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

            rc.Get<GameObject>("Signin").GetComponent<Button>().onClick.AddListener(() => { self.OnSignIn(); });
            rc.Get<GameObject>("Signin_Games").GetComponent<Button>().onClick.AddListener(() => { self.OnGamesSignIn(); });
            rc.Get<GameObject>("Signout").GetComponent<Button>().onClick.AddListener(() => { self.OnSignOut(); });
            rc.Get<GameObject>("Signin_Silently").GetComponent<Button>().onClick.AddListener(() => { self.OnSignInSilently(); });
            rc.Get<GameObject>("Disconnect").GetComponent<Button>().onClick.AddListener(() => { self.OnDisconnect(); });
            
            self.loginBtn = rc.Get<GameObject>("LoginBtn");

            self.loginBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnLogin(); });
            self.account = rc.Get<GameObject>("Account");
            self.password = rc.Get<GameObject>("Password");
            rc.Get<GameObject>("PurchaseBtn").GetComponent<Button>().onClick.AddListener(() => { self.OnGoogleReCharge(); });
        }

        public static void OnSignIn(this UILoginComponent self)
        {
            GameObject.Find("/Global").GetComponent<Init>().OnSignIn();
        }

        public static void OnSignOut(this UILoginComponent self)
        {
            GameObject.Find("/Global").GetComponent<Init>().OnSignOut();
        }

        public static void OnDisconnect(this UILoginComponent self)
        {
            GameObject.Find("/Global").GetComponent<Init>().OnDisconnect();
        }

        public static void OnSignInSilently(this UILoginComponent self)
        {
            GameObject.Find("/Global").GetComponent<Init>().OnSignInSilently();
        }

        public static void OnGamesSignIn(this UILoginComponent self)
        {
            GameObject.Find("/Global").GetComponent<Init>().OnGamesSignIn();
        }
        
        public static void OnLogin(this UILoginComponent self)
        {
            GameObject.Find("/Global").GetComponent<Init>().GooglePlayGamesSignin();
            //
            // if (PlayGamesPlatform.Instance.GetUserId() == "0")
            // {
            //     return;
            // }
            //
            // LoginHelper.Login(self.Root(), PlayGamesPlatform.Instance.GetUserId(), "123").Coroutine();
        }
        
        public static void OnGoogleReCharge(this UILoginComponent self)
        {
            string product = $"pay_{1}";
            GameObject.Find("Global").GetComponent<IAPManager>().BuyProduct_WJ(product);
        }
    }
}