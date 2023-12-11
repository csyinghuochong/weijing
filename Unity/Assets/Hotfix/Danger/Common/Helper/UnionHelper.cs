using System.Collections.Generic;

namespace ET
{
    public static class UnionHelper
    {

#if SERVER
        public static async ETTask NoticeUnionLeader(int zone, long unitid, int leader)
        {
            long gateServerId = DBHelper.GetGateServerId(zone);
            G2T_GateUnitInfoResponse g2M_UpdateUnitResponse_3 = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
              (gateServerId, new T2G_GateUnitInfoRequest()
              {
                  UserID = unitid
              });
            if (g2M_UpdateUnitResponse_3.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse_3.SessionInstanceId > 0)
            {
                MessageHelper.SendToLocationActor(unitid, new M2M_UnionTransferMessage() { UnionLeader = leader });
            }
            else
            {
                NumericComponent numericComponent_3 = await DBHelper.GetComponentCache<NumericComponent>(zone, unitid);
                numericComponent_3.Set(NumericType.UnionLeader, leader, false);
                DBHelper.SaveComponent(zone, unitid, numericComponent_3).Coroutine();
            }

        }

        public static List<MysteryItemInfo> InitMysteryItemInfos(int openserverDay)
        {
            List<MysteryItemInfo> mysteryItemInfos = new List<MysteryItemInfo>();

            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(92);
            string[] itemList = globalValueConfig.Value.Split('@');

            for (int i = 0; i < itemList.Length; i++)
            {
                string[] iteminfo = itemList[i].Split(';');
                mysteryItemInfos.AddRange(MysteryShopHelper.InitMysteryTypeItems(openserverDay, int.Parse(iteminfo[0]), int.Parse(iteminfo[1])));
            }

            return mysteryItemInfos;
        }

        public static async ETTask<int> UpdateUnionToChat(this Unit self)
        {
            long chatServerId = DBHelper.GetChatServerId( self.DomainZone() );
         
            Chat2M_UpdateUnion chat2G_EnterChat = (Chat2M_UpdateUnion)await MessageHelper.CallActor(chatServerId, new M2Chat_UpdateUnion()
            {
                UnitId = self.Id,
                UnionId = self.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0),
            });
            return chat2G_EnterChat.Error;
        }
#endif


        public static Dictionary<int, string> UnionPosition = new Dictionary<int, string>
        {
            { 0, "族员"},
            { 1, "族长"},
            { 2, "副族长"},
            { 3, "长老"},
        };

        public static UnionPlayerInfo GetUnionPlayerInfo(List<UnionPlayerInfo> playerInfos, long unitid)
        {
            for (int i = 0; i < playerInfos.Count; i++)
            {
                if (playerInfos[i].UserID == unitid)
                {
                    return playerInfos[i];
                }
            }
            return null;
        }


        public static int GetXiuLianId(int postion ,int type)
        {
            int numerType = 0;
            switch (type)
            {
                // 角色修炼
                case 0:
                    switch (postion)
                    {
                        case 0:
                            numerType = NumericType.UnionXiuLian_0;
                            break;
                        case 1:
                            numerType = NumericType.UnionXiuLian_1;
                            break;
                        case 2:
                            numerType = NumericType.UnionXiuLian_2;
                            break;
                        case 3:
                            numerType = NumericType.UnionXiuLian_3;
                            break;
                        default:
                            break;
                    }

                    break;
                // 宠物修炼
                case 1:
                    switch (postion)
                    {
                        case 0:
                            numerType = NumericType.UnionPetXiuLian_0;
                            break;
                        case 1:
                            numerType = NumericType.UnionPetXiuLian_1;
                            break;
                        case 2:
                            numerType = NumericType.UnionPetXiuLian_2;
                            break;
                        case 3:
                            numerType = NumericType.UnionPetXiuLian_3;
                            break;
                        default:
                            break;
                    }

                    break;
            }

            return numerType;
        }
    }
}
