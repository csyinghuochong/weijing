using System;
using System.Collections;


namespace cn.SMSSDK.Unity
{
    public class SMSSDKResponse 
    {
        
        public int status;
        public int action;
        public object res;

        ///<summary>
        /// 该方法对输入的参数进行转换,生成统一的返回值类型
        ///</summary>
        public SMSSDKResponse(Hashtable dict) {
            if (dict != null || dict.Count != 0)
            {
                
                this.status = Convert.ToInt32(dict["status"]);
                this.action = Convert.ToInt32(dict["action"]);
                this.res = dict["res"];
            }
        }
    }
}
    