using System;
using UnityEngine;
using System.Collections;

namespace cn.SMSSDK.Unity
{
    public class SMSSDK : MonoBehaviour
    {   
        /// Properties
        private ISMSSDK smssdkImpl;
        private SMSSDKHandler handler;

        void Awake()
        {
#if UNITY_ANDROID
            smssdkImpl = new SMSSDKAndroidImpl(gameObject);
#elif UNITY_IPHONE
			smssdkImpl = new SMSSDKIOSImpl(gameObject);
#endif
        }

        /// <summary>
        /// Calls the back.
        /// </summary>
        /// <param name="callBackData">Call back data.</param>
        private void _callBack(string callBackData)
        {
            if (callBackData == null)
            {
                Debug.Log("[SMSSDK]SMSSDK  ===>>>  callBackData is null");
                return;
            }

            Hashtable res = (Hashtable)MiniJSON.jsonDecode(callBackData);
            SMSSDKResponse response = new SMSSDKResponse(res);
            switch (response.status)
            {
                case 1:
                    {
                        if (handler != null)
                            handler.onComplete(response.action, response.res);
                        break;
                    }
                case 2:
                    {
                        if (handler != null)
                            handler.onError(response.action, response.res);
                        break;
                    }
            }
        }

        /// <summary>
        /// Sets the handler.
        /// </summary>
        /// <param name="handler">Handler.</param>
        public void setHandler(SMSSDKHandler handler)
        {
            this.handler = handler;
        }

        
        ///<summary>
        /// SDK版本号
        ///</summary>
        ///
        ///<returns>void</returns>
        public void getVersion () {
            
            if (smssdkImpl != null)
            {
                smssdkImpl.getVersion();
            }
    
        }
    
        ///<summary>
        /// 获取区号
        ///</summary>
        ///
        ///<returns>void</returns>
        public void getSupportedCountryCode () {
            
            if (smssdkImpl != null)
            {
                smssdkImpl.getSupportedCountryCode();
            }
    
        }
    
        ///<summary>
        /// 请求本机号码认证Token
        ///</summary>
        ///
        ///<returns>void</returns>
        public void getMobileAuthToken () {
            
            if (smssdkImpl != null)
            {
                smssdkImpl.getMobileAuthToken();
            }
    
        }
    
        ///<summary>
        /// 验证手机号
        ///</summary>
        ///<param name=phoneNUmber>待验证手机号</param>
		///<param name=model>号码认证Token</param>
        ///<returns>void</returns>
        public void verifyMobileWithPhone (string phoneNumber) {
            
            if (smssdkImpl != null)
            {
                smssdkImpl.verifyMobileWithPhone(phoneNumber);
            }
    
        }
    
        ///<summary>
        /// 获取验证码
        ///</summary>
        ///<param name=method>获取验证码的方法</param>
		///<param name=phoneNumber>电话号码</param>
		///<param name=zone>区域号</param>
		///<param name=tmpCode>模板id</param>
        ///<returns>void</returns>
        public void getCode (CodeType method, string phoneNumber, string zone, string tmpCode) {
            
            if (smssdkImpl != null)
            {
                smssdkImpl.getCode(method, phoneNumber, zone, tmpCode);
            }
    
        }
    
        ///<summary>
        /// 提交验证码
        ///</summary>
        ///<param name=code>验证码</param>
		///<param name=phoneNumber>电话号码</param>
		///<param name=zone>区域号</param>
        ///<returns>void</returns>
        public void commitCode (string phoneNumber, string zone, string code) {
            
            if (smssdkImpl != null)
            {
                smssdkImpl.commitCode(phoneNumber, zone, code);
            }
    
        }
    
        ///<summary>
        /// 上传隐私协议状态
        ///</summary>
        ///<param name=isAgree>是否同意隐私协议 布尔类型</param>
        ///<returns>void</returns>
        public void submitPolicyGrantResult (bool isAgree) {
            
            if (smssdkImpl != null)
            {
                smssdkImpl.submitPolicyGrantResult(isAgree);
            }
    
        }
    
    }
}
    