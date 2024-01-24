using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
	[MessageHandler]
	public class C2G_ReloadHandler: AMRpcHandler<C2G_Reload, G2C_Reload>
	{
		protected override async ETTask Run(Session session, C2G_Reload request, G2C_Reload response, Action reply)
		{
			Log.Warning("C2M_ReloadHandler");
            Log.Console("C2M_ReloadHandler");
            if (!AdminHelper.AdminAccount.Contains(request.Account))
			{
				Log.Error($"error reload account and password: {MongoHelper.ToJson(request)}");
				return;
			}

			response.Error = await ConsoleHelper.ReloadDllConsoleHandler(request.LoadValue);
            reply();
			await ETTask.CompletedTask;
		}
	}
}