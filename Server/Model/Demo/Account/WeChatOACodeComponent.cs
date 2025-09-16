using System.Collections.Generic;

namespace ET
{

    public class WeChatOACodeComponent : Entity, IAwake, IDestroy
    {
        //unitid-code
        public Dictionary<long, int> WeChatOACodeDict = new Dictionary<long, int>();

        public Dictionary<string, int> FromUserNameErrorNum = new Dictionary<string, int>();    
    }
}