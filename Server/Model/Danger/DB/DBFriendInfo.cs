using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBFriendInfo : Entity
    {

        /// <summary>
        /// 好友列表
        /// </summary>
        public List<long> FriendList = new List<long>();

        /// <summary>
        /// 申请列表
        /// </summary>
        public List<long> ApplyList = new List<long>();

        /// <summary>
        /// 黑名单
        /// </summary>
        public List<long> Blacklist = new List<long>();

        /// <summary>
        /// 好友私聊
        /// </summary>
        public List<ChatInfo> FriendChats = new List<ChatInfo>();   
    }
}
