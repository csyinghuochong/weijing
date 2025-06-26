using UnityEngine;
using System.Collections;

namespace quicksdk
{
    // QuickSDKListener
    public abstract class QuickSDKListener : MonoBehaviour
    {
        //callback
		public abstract void onInitSuccess();

		public abstract void onInitFailed(ErrorMsg message);

        public abstract void onLoginSuccess(UserInfo userInfo);

		public abstract void onSwitchAccountSuccess(UserInfo userInfo);

		public abstract void onLoginFailed(ErrorMsg errMsg);

        public abstract void onLogoutSuccess();

        public abstract void onSucceed(string infos);
        public abstract void onFailed(string message);



        public abstract void onPaySuccess(PayResult payResult);

        public abstract void onPayFailed(PayResult payResult);

        public abstract void onPayCancel(PayResult payResult);

        public abstract void onExitSuccess();

        public abstract void onPrivaceAgree();
        public abstract void onPrivaceRefuse();

        public abstract void onCallbackSuccess(string msg);
        public abstract void onCallbackFaild(string msg);



        //callback end
        public void onInitSuccess(string msg)
		{
            Debug.Log($"QuickSDKListener.QuickSdkListener  {msg}");
            onInitSuccess();
		}

		public void onInitFailed(string msg)
		{
            Debug.Log($"QuickSDKListener.onInitFailed  {msg}");
            var data = SimpleJSON.JSONNode.Parse(msg);
			ErrorMsg errMsg = new ErrorMsg();
			errMsg.errMsg =  data["msg"].Value;
            onInitFailed(errMsg);
		}

        public void onLoginSuccess(string msg)
        {
            Debug.Log($"QuickSDKListener.onLoginSuccess  {msg}");
            var data = SimpleJSON.JSONNode.Parse(msg);
            UserInfo userInfo = new UserInfo();
            userInfo.uid = data["userId"].Value;
            userInfo.token = data["userToken"].Value;
            userInfo.userName = data["userName"].Value;
            userInfo.errMsg = data["msg"].Value;

            onLoginSuccess(userInfo);
        }

		public void onSwitchAccountSuccess(string msg)
		{
            Debug.Log($"QuickSDKListener.onSwitchAccountSuccess  {msg}");
            var data = SimpleJSON.JSONNode.Parse(msg);
			UserInfo userInfo = new UserInfo();
			userInfo.uid = data["userId"].Value;
			userInfo.token = data["userToken"].Value;
			userInfo.userName = data["userName"].Value;
			userInfo.errMsg = data["msg"].Value;

			onSwitchAccountSuccess(userInfo);
		}

        public void onLoginFailed(string msg)
        {
            Debug.Log($"QuickSDKListener.onLoginFailed  {msg}");
            var data = SimpleJSON.JSONNode.Parse(msg);
			ErrorMsg errMsg = new ErrorMsg();
			errMsg.errMsg = data["msg"].Value;
			
			onLoginFailed(errMsg);
        }

        public void onLogoutSuccess(string msg)
        {
            Debug.Log($"QuickSDKListener.onLogoutSuccess  {msg}");
            onLogoutSuccess();
        }


        public void onPaySuccess(string msg)
        {
            Debug.Log($"QuickSDKListener.onPaySuccess  {msg}");
            var data = SimpleJSON.JSONNode.Parse(msg);
            PayResult result = new PayResult();
            result.cpOrderId = data["cpOrderId"].Value;
            result.orderId = data["orderId"].Value;
            result.extraParam = data["extraParam"].Value;

            onPaySuccess(result);
        }

        public void onPayFailed(string msg)
        {
            Debug.Log($"QuickSDKListener.onPayFailed  {msg}");
            var data = SimpleJSON.JSONNode.Parse(msg);
            PayResult result = new PayResult();
            result.cpOrderId = data["cpOrderId"].Value;
            result.orderId = data["orderId"].Value;
            result.extraParam = data["extraParam"].Value;

            onPayFailed(result);
        }

        public void onPayCancel(string msg)
        {
            Debug.Log($"QuickSDKListener.onPayCancel  {msg}");
            var data = SimpleJSON.JSONNode.Parse(msg);
            PayResult result = new PayResult();
            result.cpOrderId = data["cpOrderId"].Value;
            result.orderId = data["orderId"].Value;
            result.extraParam = data["extraParam"].Value;

            onPayCancel(result);
        }

        public void onExitSuccess(string msg)
        {
            Debug.Log($"QuickSDKListener.onExitSuccess  {msg}");
            onExitSuccess();
        }
		
        public void onSuccess(string infos)
        {
            Debug.Log($"QuickSDKListener.onSuccess  {infos}");
            onSucceed(infos);
        }

        public void onFail(string msg)
        {
            Debug.Log($"QuickSDKListener.onFail  {msg}");
            onFailed(msg);
        }

        public void onPrivaceAgree(string msg)
        {
            Debug.Log($"QuickSDKListener.onPrivaceAgree  {msg}");
            onPrivaceAgree();
        }
        public void onPrivaceRefuse(string msg)
        {
            Debug.Log($"QuickSDKListener.onPrivaceRefuse  {msg}");
            onPrivaceRefuse();
        }


        public void onBaseCallbackSuccess(string msg)
        {
            Debug.Log("onBaseCallbackSuccess "+ msg);
            onCallbackSuccess(msg);
        }
        public void onBaseCallbackFaild(string msg)
        {
            Debug.Log("onBaseCallbackFaild " + msg);
            onCallbackFaild(msg);
        }

    }
}
