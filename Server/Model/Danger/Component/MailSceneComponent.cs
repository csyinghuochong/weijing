using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 全服邮件
    /// </summary>
    public class ServerMailItem : Entity, IAwake
    { 
        public int MailType = 0;    //1全服邮件     2充值邮件   3等级邮件   4开启格子
        public int Parasm = 0;      //0             充值金额   等级         /开启第二个仓库并且格子没有开完的 
        public string ItemList = string.Empty;
    }

    public class MailSceneComponent : Entity, IAwake
    {

        public long Timer;

        public DBServerMailInfo dBServerMailInfo = null;    
    }
}
