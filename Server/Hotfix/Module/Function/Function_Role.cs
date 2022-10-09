using ET;
using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{

    public class Function_Role
    {

        //实例化自身
        private static Function_Role _instance;
        public static Function_Role GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Function_Role();
            }
            return _instance;
        }

        //传入随机范围,生成一个随机数(平均概率)
        public int ReturnRamdomValue_Int(int randomMinValue, int randomMaxValue)
        {

            int randomChaValue = randomMaxValue - randomMinValue;
            float randomRangeValue_Now = RandomHelper.RandomNumber(0, 10) * 0.1f;
            //System.Math.Round
            //计算最终值
            int retunrnValue = (int)(System.Math.Round(randomMinValue + randomChaValue * randomRangeValue_Now));
            return retunrnValue;
        }

        //传入随机范围,生成一个随机数(平均概率)
        public float ReturnRamdomValue_Float(float randomMinValue, float randomMaxValue)
        {

            float randomChaValue = randomMaxValue - randomMinValue;
            float randomRangeValue_Now = RandomHelper.RandomNumber(0, 10) * 0.1f;

            //计算最终值
            float retunrnValue = randomMinValue + randomChaValue * randomRangeValue_Now;
            return retunrnValue;
        }

        //拷贝道具数据(将数据库内的道具数据转换成客户端能接受的消息数据)
        /*
        public BagInfo GetItemData(UserBagInfo src)
        {
            BagInfo dst = new BagInfo();
            dst.BagInfoID = src.Id;
            dst.GemID = "0";/// src.GemID;
            dst.GemHole = ""; /// src.GemHole;
            dst.HideID = src.HideID;
            dst.ItemID = src.ItemID;
            dst.ItemNum = src.ItemNum;
            dst.ItemPar = ""; //// src.ItemPar;
            dst.Loc = src.Loc;
            dst.IfJianDing = src.IfJianDing;
            dst.HideProLists = src.HideProLists;
            dst.XiLianHideProLists = src.XiLianHideProLists;
            dst.HideSkillLists = src.HideSkillLists;
            return dst;
        }
        */

        //获取角色创建列表信息
        public CreateRoleListInfo GetRoleListInfo(UserInfo userInfo,int xuhaoID,long userID) 
        {
            CreateRoleListInfo roleList = new CreateRoleListInfo();

            roleList.XuHaoID = userInfo.OccTwo;
            roleList.UserID = userID;
            roleList.PlayerName = userInfo.Name;
            roleList.PlayerLv = userInfo.Lv;
            roleList.PlayerOcc = userInfo.Occ;

            return roleList;
        }

    }
}
