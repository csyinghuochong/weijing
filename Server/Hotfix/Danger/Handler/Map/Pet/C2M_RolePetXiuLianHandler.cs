using System;
using System.Collections.Generic;
using System.Net;
using ET;

namespace ET
{
    //玩家宠物
    [ActorMessageHandler]
    public class C2M_RolePetXiuLianHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetXiuLian, M2C_RolePetXiuLian>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetXiuLian request, M2C_RolePetXiuLian response, Action reply)
        {
            RolePetInfo petinfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);
            if (petinfo == null)
            {
                reply();
                return;
            }

            int xiuLianId = request.XiuLianId;
            PetXiuLianConfig xiulianconf = PetXiuLianConfigCategory.Instance.Get(xiuLianId);
            int costGoldNum = xiulianconf.CostMoney;
            string costItemNum = xiulianconf.CostItem;
            string xiulianGaiLv = xiulianconf.SuccessPro;

            //判定宠物洗炼消耗
            int nextID = xiulianconf.NextID;
            if (nextID == 0)
            {
                //string nowlangStr = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalization("hint_444");
                //Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(nowlangStr);
                //错误码。。
            }

            //List<ComponentWithId> resultuserinfo = await dbProxy.Query<UserInfo>(_userInfo => _userInfo.Id == player.UserId);
            UserInfo userinfo = unit.GetComponent<UserInfoComponent>().GetUserInfo();

            //判定消耗
            string[] costItemList = costItemNum.Split(',');
            int itemnumber = 10; // Function_Role.GetInstance().ReturnBagItemNum(costItemList[0])
            if (userinfo.Diamond >= costGoldNum && itemnumber >= int.Parse(costItemList[1]))
            {
                //扣除消耗
                //Game_PublicClassVar.Get_function_Rose.CostReward("1", costGoldNum);
                //Game_PublicClassVar.Get_function_Rose.CostBagItem(costItemList[0], int.Parse(costItemList[1]));
            }
            else
            {
                //string nowlangStr = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalization("hint_446");
                //Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(nowlangStr);
                //return;错误码
            }

            //判定宠物洗炼成功概率
            if (RandomHelper.RandomNumber(1, 10) * 0.1f > float.Parse(xiulianGaiLv))
            {
                //string nowlangStr = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalization("hint_445");
                //Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(nowlangStr);
                //刷新界面ShowPetXiuLian(NowSeletID);
                //return;错误码
            }

            //写入洗练值
            string xiuLianStr = "10013;20012;30011;40012";// Game_PublicClassVar.Get_function_DataSet.DataSet_ReadData("PetXiuLian", "ID", Game_PublicClassVar.Get_wwwSet.RoseID, "RoseData");
            string[] XiuLianLvList = xiuLianStr.Split(';');

            int writeLv = nextID;
            if (writeLv == 0)
            {
                //return;错误码
            }
            int NowSeletID = 0;
            XiuLianLvList[NowSeletID] = writeLv.ToString();
            string writeStr = "";
            for (int i = 0; i < XiuLianLvList.Length; i++)
            {
                writeStr = writeStr + XiuLianLvList[i] + ";";
            }
            writeStr = writeStr.Substring(0, writeStr.Length - 1);
            //写入useinfo
            //Game_PublicClassVar.Get_function_DataSet.DataSet_WriteData("PetXiuLian", writeStr, "ID", Game_PublicClassVar.Get_wwwSet.RoseID, "RoseData");
            //Game_PublicClassVar.Get_function_DataSet.DataSet_SetXml("RoseData");
            //string langStr = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalization("hint_447");
            //Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(langStr);
            reply();
            await ETTask.CompletedTask;
        }
    }
}