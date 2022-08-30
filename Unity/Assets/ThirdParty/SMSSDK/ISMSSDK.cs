using System;


namespace cn.SMSSDK.Unity
{
    public abstract class ISMSSDK
    {
        
        ///<summary>
        /// SDK版本号
        ///</summary>
        ///
        ///<returns>void</returns>
        public abstract void getVersion ();
    
        ///<summary>
        /// 获取区号
        ///</summary>
        ///
        ///<returns>void</returns>
        public abstract void getSupportedCountryCode ();
    
        ///<summary>
        /// 请求本机号码认证Token
        ///</summary>
        ///
        ///<returns>void</returns>
        public abstract void getMobileAuthToken ();
    
        ///<summary>
        /// 验证手机号
        ///</summary>
        ///<param name=phoneNUmber>待验证手机号</param>
		///<param name=model>号码认证Token</param>
        ///<returns>void</returns>
        public abstract void verifyMobileWithPhone (string phoneNumber);
    
        ///<summary>
        /// 获取验证码
        ///</summary>
        ///<param name=method>获取验证码的方法</param>
		///<param name=phoneNumber>电话号码</param>
		///<param name=zone>区域号</param>
		///<param name=tmpCode>模板id</param>
        ///<returns>void</returns>
        public abstract void getCode (CodeType method, string phoneNumber, string zone, string tmpCode);
    
        ///<summary>
        /// 提交验证码
        ///</summary>
        ///<param name=code>验证码</param>
		///<param name=phoneNumber>电话号码</param>
		///<param name=zone>区域号</param>
        ///<returns>void</returns>
        public abstract void commitCode (string phoneNumber, string zone, string code);
    
        ///<summary>
        /// 上传隐私协议状态
        ///</summary>
        ///<param name=isAgree>是否同意隐私协议 布尔类型</param>
        ///<returns>void</returns>
        public abstract void submitPolicyGrantResult (bool isAgree);
    
    }
}
    