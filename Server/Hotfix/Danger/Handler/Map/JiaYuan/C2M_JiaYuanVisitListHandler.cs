using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanVisitListHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanVisitListRequest, M2C_JiaYuanVisitListResponse>
    {

        private async ETTask<JiaYuanVisit> GetJiaYuanVisit(int zone, long id)
        {
            List<JiaYuanComponent> resultJiaYuan = await Game.Scene.GetComponent<DBComponent>().Query<JiaYuanComponent>(zone, _account => _account.Id == id);
            if (resultJiaYuan == null || resultJiaYuan.Count == 0)
            {
                return null;
            }

            List<UserInfoComponent> resultUser = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(zone, _account => _account.Id == id);
            if (resultUser[0].UserInfo.Lv < 10)
            {
                return null;
            }
            JiaYuanVisit jiaYuanVisit = new JiaYuanVisit() ;
            jiaYuanVisit.Occ = resultUser[0].UserInfo.Occ;
            jiaYuanVisit.OccTwo = resultUser[0].UserInfo.OccTwo;
            jiaYuanVisit.PlayerName = resultUser[0].UserInfo.Name;
            jiaYuanVisit.UnitId = resultJiaYuan[0].Id;
            jiaYuanVisit.Rubbish = resultJiaYuan[0].GetRubbishNumber();
            jiaYuanVisit.Gather = resultJiaYuan[0].GetCanGatherNumber();
            return jiaYuanVisit;
        }

        protected override async ETTask Run(Unit unit, C2M_JiaYuanVisitListRequest request, M2C_JiaYuanVisitListResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.JiaYuan, unit.Id))
            {
                long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unit.Id, Component = DBHelper.DBFriendInfo });
                DBFriendInfo dBFriendInfo = d2GGetUnit.Component as DBFriendInfo;

                List<long> friendList = dBFriendInfo.FriendList;
                for (int i = 0; i < friendList.Count; i++)
                {
                    JiaYuanVisit jiaYuanVisit = await GetJiaYuanVisit(unit.DomainZone(), friendList[i]);
                    if (jiaYuanVisit != null)
                    {
                        response.JiaYuanVisit_1.Add(jiaYuanVisit);
                    }
                }

                JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
                List<long> fujinList = jiaYuanComponent.JiaYuanFuJins;
                if (TimeHelper.ServerNow() - jiaYuanComponent.JiaYuanFuJinTime_1 < TimeHelper.Hour * 4)
                {
                    for (int i = 0; i < fujinList.Count; i++)
                    {
                        JiaYuanVisit jiaYuanVisit = await GetJiaYuanVisit(unit.DomainZone(), fujinList[i]);
                        if (jiaYuanVisit != null)
                        {
                            response.JiaYuanVisit_2.Add(jiaYuanVisit);
                        }
                    }
                }
                else
                {
                    jiaYuanComponent.JiaYuanFuJins.Clear();
                    List<JiaYuanComponent> resultJiaYuan = await Game.Scene.GetComponent<DBComponent>().Query<JiaYuanComponent>(unit.DomainZone(), _account => _account.Id > 0);
                    for (int i = resultJiaYuan.Count - 1; i >= 0; i--)
                    {
                        if (friendList.Contains(resultJiaYuan[i].Id))
                        {
                            resultJiaYuan.RemoveAt(i);
                            continue;
                        }
                        List<UserInfoComponent> resultUser = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(unit.DomainZone(), _account => _account.Id == resultJiaYuan[i].Id);
                        if (resultUser[0].UserInfo.Lv < 10)
                        {
                            resultJiaYuan.RemoveAt(i);
                            continue;
                        }

                        jiaYuanComponent.JiaYuanFuJins.Add(resultJiaYuan[i].Id);
                        JiaYuanVisit jiaYuanVisit = new JiaYuanVisit();
                        jiaYuanVisit.Occ = resultUser[0].UserInfo.Occ;
                        jiaYuanVisit.OccTwo = resultUser[0].UserInfo.OccTwo;
                        jiaYuanVisit.PlayerName = resultUser[0].UserInfo.Name;
                        jiaYuanVisit.UnitId = resultJiaYuan[i].Id;
                        jiaYuanVisit.Rubbish = resultJiaYuan[i].GetRubbishNumber();
                        jiaYuanVisit.Gather = resultJiaYuan[i].GetCanGatherNumber();
                        response.JiaYuanVisit_2.Add(jiaYuanVisit);
                    }
                    
                    jiaYuanComponent.JiaYuanFuJinTime_1 = TimeHelper.ServerNow();
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
