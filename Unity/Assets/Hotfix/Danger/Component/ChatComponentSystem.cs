using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class ChatComponentAwakeSystem : AwakeSystem<ChatComponent>
    {
        public override void Awake(ChatComponent self)
        {
            self.ChatTypeList.Clear();
            self.ChatTypeList.Add(ChannelEnum.Word, new List<ChatInfo>() );
            self.ChatTypeList.Add(ChannelEnum.Team, new List<ChatInfo>());
            self.ChatTypeList.Add(ChannelEnum.System, new List<ChatInfo>());
            self.ChatTypeList.Add(ChannelEnum.Union, new List<ChatInfo>());
            self.ChatTypeList.Add(ChannelEnum.Friend, new List<ChatInfo>());
            self.ChatTypeList.Add(ChannelEnum.Pick, new List<ChatInfo>());
        }
    }

    public static class ChatComponentSystem
    {

        public async static ETTask SendChat(this ChatComponent self, int channelEnum, string content, long paramId = 0)
        {
            if (channelEnum == ChannelEnum.Word && TimeHelper.ClientNow() - self.LastSendWord < 6000)
            {
                EventType.CommonHintError.Instance.errorValue = ErrorCore.ERR_WordChat;
                EventSystem.Instance.PublishClass(EventType.CommonHintError.Instance);
                return;
            }
           
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            C2C_SendChatRequest c2S_SendChatRequest = new C2C_SendChatRequest() {  };
            c2S_SendChatRequest.ChatInfo = new ChatInfo();
            c2S_SendChatRequest.ChatInfo.PlayerLevel = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            c2S_SendChatRequest.ChatInfo.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            switch (channelEnum)
            {
                case ChannelEnum.Word:
                    self.LastSendWord = TimeHelper.ClientNow();
                    break;
                case ChannelEnum.Friend:
                    c2S_SendChatRequest.ChatInfo.ParamId = paramId;
                    break;
                case ChannelEnum.Union:
                    Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                    NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                    c2S_SendChatRequest.ChatInfo.ParamId = numericComponent.GetAsLong(NumericType.UnionId);
                    break;
                case ChannelEnum.Team:
                    unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                    numericComponent = unit.GetComponent<NumericComponent>();
                    c2S_SendChatRequest.ChatInfo.ParamId = numericComponent.GetAsLong(NumericType.TeamId);
                    break;
            }

            c2S_SendChatRequest.ChatInfo.UserId = userInfo.UserId;
            c2S_SendChatRequest.ChatInfo.ChannelId = (int)channelEnum;
            c2S_SendChatRequest.ChatInfo.ChatMsg = content;
            c2S_SendChatRequest.ChatInfo.PlayerName = userInfo.Name;
            C2C_SendChatResponse sendChatResponse = (C2C_SendChatResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2S_SendChatRequest);

            if (sendChatResponse.Error != ErrorCore.ERR_Success)
            {
                ;
            }
        }

        public static List<ChatInfo> GetChatListByType(this ChatComponent self, int channelEnum)
        {
            if (channelEnum == ChannelEnum.Word)
            {
                List<ChatInfo> chatInfos = new List<ChatInfo>();
                chatInfos.AddRange(self.ChatTypeList[ChannelEnum.Word]);
                chatInfos.AddRange(self.ChatTypeList[ChannelEnum.System]);
                chatInfos.AddRange(self.ChatTypeList[ChannelEnum.Union]);
                chatInfos.Sort(delegate (ChatInfo a, ChatInfo b)
                {
                    return (int)(a.Time - b.Time);
                });

                return chatInfos;
            }
            if (channelEnum == ChannelEnum.System)
            {
                List<ChatInfo> chatInfos = new List<ChatInfo>();
                chatInfos.AddRange(self.ChatTypeList[ChannelEnum.System]);
                chatInfos.AddRange(self.ChatTypeList[ChannelEnum.Pick]);
                chatInfos.Sort(delegate (ChatInfo a, ChatInfo b)
                {
                    return (int)(a.Time - b.Time);
                });

                return chatInfos;
            }
            return self.ChatTypeList[channelEnum];
        }

        public static  void OnRecvChat(this ChatComponent self, ChatInfo chatInfo)
        {
            chatInfo.Time = TimeHelper.ClientNow();
            self.LastChatInfo = chatInfo;
            List<ChatInfo> chatInfos = self.ChatTypeList[chatInfo.ChannelId];
            if (chatInfos.Count >= 20)
            {
                chatInfos.RemoveAt(0);
            }
            chatInfos.Add(chatInfo);

            HintHelp.GetInstance().DataUpdate(DataType.OnRecvChat);
        }
    }
}
