
using System.Collections.Generic;

namespace ET
{

    public class FriendComponent : Entity, IAwake
    {

        public long FriendChatId;

        public List<FriendInfo> FriendList = new List<FriendInfo>();

        public List<FriendInfo> ApplyList = new List<FriendInfo>();

        public List<FriendInfo> Blacklist = new List<FriendInfo>();

        public Dictionary<long, List<ChatInfo>> ChatMsgList = new Dictionary<long, List<ChatInfo>>();
    }
}
