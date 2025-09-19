using System.Collections.Generic;

namespace ET
{

    public class WeChatOACodeComponent : Entity, IAwake, IDestroy
    {
        //unitid-code
        public Dictionary<long, string> WeChatOACodeDict = new Dictionary<long, string>();

        public Dictionary<string, int> FromUserNameErrorNum = new Dictionary<string, int>();    
    }
}