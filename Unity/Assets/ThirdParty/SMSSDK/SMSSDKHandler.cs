using System;
using System.Collections;


namespace cn.SMSSDK.Unity
{
    public interface SMSSDKHandler
    {
        
        ///<summary>
        /// The success callback method.
        ///</summary>
        ///<param name=response>统一的返回值信息</param>
        ///<returns>void</returns>
        void onComplete (int code, object result);
    
        ///<summary>
        /// The failure callback method.
        ///</summary>
        ///<param name=response>统一的返回值信息</param>
        ///<returns>void</returns>
        void onError (int code, object result);
    
    }
}
    