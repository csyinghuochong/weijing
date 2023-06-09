using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{

#if SERVER
    [ConsoleHandler(ConsoleMode.ServerRank)]
    public class ServerRankConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.ServerRank:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have serverRank zone username");
                    break;

                default:
                    //chaxun 1 ""
                    string[] chaxunInfo = content.Split(" ");
                    if (chaxunInfo[0] != "serverrank")
                    {
                        return;
                    }

                    int zone = int.Parse(chaxunInfo[1]);
                    int pyzone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;
                    long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                    Dictionary<long, int> dic = new Dictionary<long, int>();
                    int lowCombat = 0;

                    //查询全部玩家
                    List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);
                    for (int i = 0; i < userinfoComponentList.Count; i++)
                    {
                        UserInfoComponent userInfoComponent = userinfoComponentList[i];
                        if (userInfoComponent.UserInfo.RobotId != 0)
                        {
                            //continue;
                        }


                        if (userInfoComponent.UserInfo.Lv < 1) {
                            continue;
                        }

                        int combatFight = userInfoComponent.UserInfo.Combat;
                        if (combatFight < lowCombat) {
                            continue;
                        }

                        dic.Add(userInfoComponent.UserInfo.UserId,combatFight);
                            
                        if (dic.Count >= 100) {

                            //开始筛查
                            dic = ShaiCha(dic,10, out lowCombat);
                                
                        }
                    }

                    //开始筛查
                    dic = ShaiCha(dic, 10, out lowCombat);

                    Log.Debug($"服务器注册人数: {userinfoComponentList.Count}");

                    foreach (long unitID in dic.Keys)
                    {
                        List<UserInfoComponent> userinfoComponentSing = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0 && d.UserInfo.UserId == unitID);
                        if (userinfoComponentSing.Count > 0) {

                            //获取充值的数值组件
                            List<NumericComponent> numericComponent = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(pyzone, d => d.Id > 0 && d.Id == unitID);
                            string showStr = $"{userinfoComponentSing[0].UserInfo.Name} 战力:{userinfoComponentSing[0].UserInfo.Combat}金币:{userinfoComponentSing[0].UserInfo.Gold} 钻石:{userinfoComponentSing[0].UserInfo.Diamond} 职业{userinfoComponentSing[0].UserInfo.Occ}-{userinfoComponentSing[0].UserInfo.OccTwo} 充值:{numericComponent[0].GetAsInt(NumericType.RechargeNumber)}";
                            Log.Debug($"{showStr}");
                        }
                    }
                    

                    break;
            }

            await ETTask.CompletedTask;
        }



        public static Dictionary<long, int> ShaiCha(Dictionary<long, int> dic, int showNum,out int minValue) {

            //排序
            dic = dic.OrderByDescending(o => o.Value).ToDictionary(p => p.Key, o => o.Value);
            int num = 0;
            int minValueNum = 0;
            foreach (long unitID in dic.Keys)
            {
                num++;

                if (num == dic.Count || num == showNum) {
                    minValueNum = dic[unitID];
                }

                if (num > showNum) {
                    dic.Remove(unitID);
                }
            }
            minValue = minValueNum;
            return dic;
        
        }
    }
#endif
}
