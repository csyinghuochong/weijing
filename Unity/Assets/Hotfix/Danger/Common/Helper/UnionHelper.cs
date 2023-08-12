using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class UnionHelper
    {


#if SERVER

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


        public static int GetXiuLianId(int postion)
        {
            int numerType = 0;
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
            return numerType;
        }
    }
}
