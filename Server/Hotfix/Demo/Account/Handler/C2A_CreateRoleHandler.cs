using System;
using System.Collections.Generic;

namespace ET
{
    [MessageHandler]
	public class C2A_CreateRoleHandler : AMRpcHandler<C2A_CreateRoleData, A2C_CreateRoleData>
	{
		protected override async ETTask Run(Session session, C2A_CreateRoleData request, A2C_CreateRoleData response, Action reply)
		{
			try
			{
				//判断名字是否符合要求
				if (request.CreateName.Length >= 8)
				{
					response.Error = ErrorCore.ERR_CreateRoleName;
					response.Message = "角色名字过长!";
					reply();
					return;
				}
				if (session.DomainZone() == 0)
				{
					Log.Error("session.DomainZone() == 0");
					response.Error = ErrorCore.ERR_Error;
					reply();
					return;
				}

				using (session.AddComponent<SessionLockingComponent>())
				{
					using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginAccount, request.AccountId.GetHashCode()))
					{
						List<UserInfoComponent> result = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(session.DomainZone(), _account => _account.UserName == request.CreateName);
						if (result.Count > 0)
						{
							response.Error = ErrorCore.ERR_CreateRoleName;
							reply();
							return;
						}

						int zone = session.DomainZone();
						long userId = IdGenerater.Instance.GenerateUnitId(session.DomainZone()); /// (request.ServerId)
						long dbCacheId = DBHelper.GetDbCacheId(zone);

						//通过账号ID获取列表  //获取UserID,默认使用第一个角色
						D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.AccountId, Component = DBHelper.DBAccountInfo });
						DBAccountInfo newAccount = d2GGetUnit.Component as DBAccountInfo;

						UserInfoComponent userInfoComponent = session.AddChildWithId<UserInfoComponent>(userId);
						userInfoComponent.Account = newAccount.Account;
						UserInfo userInfo = userInfoComponent.UserInfo;
						userInfo.HuoYue = 0;
						userInfo.UserId = userId;
						userInfo.AccInfoID = newAccount.Id;
						userInfo.Name = request.CreateName;
						userInfo.PiLao = int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value);        //初始化疲劳
						userInfo.Vitality = int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value);
						userInfo.MakeList.AddRange(ComHelp.StringArrToIntList(GlobalValueConfigCategory.Instance.Get(18).Value.Split(';')));

						if (newAccount.Password == ComHelp.RobotPassWord)
						{
							int robotId = int.Parse(newAccount.Account.Split('_')[0]);
							RobotConfig robotConfig = RobotConfigCategory.Instance.Get(robotId);
							userInfo.Lv = robotConfig.Level;
							userInfo.Gold = 10000000;
							userInfo.Occ = robotConfig.Occ;
							userInfo.OccTwo = robotConfig.OccTwo;
							userInfo.RobotId = robotId;
						}
						else
						{
							userInfo.Lv = 1;
							userInfo.Gold = 0;
							userInfo.Occ = request.CreateOcc;
						}
						D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = userId, Component = userInfoComponent, ComponentType = DBHelper.UserInfoComponent });
						userInfoComponent.Dispose();

						//创建角色组件
						await DBHelper.AddDataComponent<NumericComponent>(zone, userId, DBHelper.NumericComponent);
						await DBHelper.AddDataComponent<DBFriendInfo>(zone, userId, DBHelper.DBFriendInfo);
						await DBHelper.AddDataComponent<DBMailInfo>(zone, userId, DBHelper.DBMailInfo);

						//存储账号信息
						newAccount.UserList.Add(userId);
						d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = newAccount.Id, Component = newAccount, ComponentType = DBHelper.DBAccountInfo });

						//返回角色信息
						CreateRoleListInfo roleList = Function_Role.GetInstance().GetRoleListInfo(userInfo, newAccount.UserList.Count - 1, userId);
						response.createRoleInfo = roleList;
						reply();
					}
				}
			}
			catch (Exception ex)
			{ 
				Log.Info(ex.ToString());
			}
			
		}
	}
}