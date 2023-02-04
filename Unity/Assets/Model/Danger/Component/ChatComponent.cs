using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 聊天组件
    /// </summary>
    public class ChatComponent : Entity, IAwake
    {

        public Dictionary<int, List<ChatInfo>> ChatTypeList = new Dictionary<int, List<ChatInfo>>();

        public long LastSendWord;

        public ChatInfo LastChatInfo;

        public M2C_HorseNoticeInfo HorseNoticeInfo;

    }
}
