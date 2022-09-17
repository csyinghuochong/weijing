using System;
using System.Collections.Generic;
using System.Linq;

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

				int zone = session.DomainZone();
				long userId = IdGenerater.Instance.GenerateUnitId(session.DomainZone()); /// (request.ServerId)
				long dbCacheId = DBHelper.GetDbCacheId(zone);

				//通过账号ID获取列表  //获取UserID,默认使用第一个角色
				D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.AccountId, Component = DBHelper.DBAccountInfo });
				DBAccountInfo newAccount = d2GGetUnit.Component as DBAccountInfo;

				//创建角色组件
				await DBHelper.AddDataComponent<UserInfoComponent>(zone, userId, DBHelper.UserInfoComponent);
				await DBHelper.AddDataComponent<DBFriendInfo>(zone, userId, DBHelper.DBFriendInfo);
				await DBHelper.AddDataComponent<DBMailInfo>(zone, userId, DBHelper.DBMailInfo);

				d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = userId, Component = DBHelper.UserInfoComponent });
				UserInfoComponent userInfoComponent = d2GGetUnit.Component as UserInfoComponent;
				UserInfo userInfo = userInfoComponent.UserInfo;
				userInfo.AccInfoID = newAccount.Id;
				userInfo.UserId = userId;
				userInfo.Name = request.CreateName;
				userInfo.Occ = request.CreateOcc;           //职业暂时默认为1
				userInfo.HuoYue = 0;
				userInfo.Lv = newAccount.Password == ComHelp.RobotPassWord ? 20 : 1;
				userInfo.Gold = newAccount.Password == ComHelp.RobotPassWord ? 1000000 : 0;
				//userInfo.Diamond = 10000;    //测试默认创建给5000
				userInfo.PiLao = int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value);        //初始化疲劳
				userInfo.Vitality = int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value);
				userInfo.MakeList.AddRange(ComHelp.StringArrToIntList(GlobalValueConfigCategory.Instance.Get(18).Value.Split(';')));
				userInfoComponent.Id = userInfo.UserId;
				D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = userId, Component = userInfoComponent, ComponentType = DBHelper.UserInfoComponent });

				//存储账号信息
				newAccount.UserList.Add(userInfoComponent.Id);
				d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = newAccount.Id, Component = newAccount, ComponentType = DBHelper.DBAccountInfo });

				CreateRoleListInfo roleList = new CreateRoleListInfo();
				roleList = Function_Role.GetInstance().GetRoleListInfo(userInfo, newAccount.UserList.Count - 1, userInfoComponent.Id);
				response.createRoleInfo = roleList;

				reply();
			}
			catch (Exception ex)
			{ 
				Log.Info(ex.ToString());
			}
			
		}
	}
}