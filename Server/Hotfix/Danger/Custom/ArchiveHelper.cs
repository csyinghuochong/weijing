using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ET
{
    public static  class ArchiveHelper
    {

        public static async ETTask OnArchiveHandler(int zone, long unitid, int day) //archive 5 2631939174340558848 1
        {
            await ETTask.CompletedTask;
            Console.WriteLine($"OnArchiveHandler  Begin===   {zone} {unitid}");

            ActivityComponent old_activityComponent = GetDBComponent<ActivityComponent>(zone, unitid, day, DBHelper.ActivityComponent);
            if (old_activityComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  activityComponent==null:   {zone} {unitid}");
                return;
            }

            BagComponent old_bagComponent = GetDBComponent<BagComponent>(zone, unitid, day, DBHelper.BagComponent);
            if (old_bagComponent==null)
            {
                Console.WriteLine($"OnArchiveHandler  bagComponent==null:   {zone} {unitid}");
                return;
            }

            ChengJiuComponent old_chengJiuComponent = GetDBComponent<ChengJiuComponent>(zone, unitid, day, DBHelper.ChengJiuComponent);
            if (old_chengJiuComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  chengJiuComponent==null:   {zone} {unitid}");
                return;
            }

            DBFriendInfo old_dBFriendInfo = GetDBComponent<DBFriendInfo>(zone, unitid, day, DBHelper.DBFriendInfo);
            if (old_dBFriendInfo == null)
            {
                Console.WriteLine($"OnArchiveHandler  dBFriendInfo==null:   {zone} {unitid}");
                //return;
            }

            DBMailInfo old_dBMailInfo = GetDBComponent<DBMailInfo>(zone, unitid, day, DBHelper.DBMailInfo);
            if (old_dBMailInfo == null)
            {
                Console.WriteLine($"OnArchiveHandler  dBMailInfo==null:   {zone} {unitid}");
                //return;
            }

            // 会通知拍卖服移除玩家上架的道具。
            ////PaiMaiHelper.Instance.GetPaiMaiId(1) 
            //DBPaiMainInfo dBPaiMainInfo = GetDBComponent<DBPaiMainInfo>(zone, unitid, DBHelper.DBPaiMainInfo);
            //if (dBPaiMainInfo == null)
            //{
            //    Console.WriteLine($"OnArchiveHandler  dBPaiMainInfo==null:   {zone} {unitid}");
            //    return;
            //}

            //被推广人可能会领取两次推广奖励
            //推广组件不用判断， 也不用移除
            //DBPopularizeInfo old_dBPopularizeInfo = GetDBComponent<DBPopularizeInfo>(zone, unitid, day, DBHelper.DBPopularizeInfo);
            

            //宠物天梯可能没有及时刷新
            //DBRankInfo 

            //全服公用数据，兑换比例。。。
            //DBServerInfo

            //全服邮件
            //DBServerMailInfo

            //帮会这个太多情况了，回档会导致自己丢失帮会。。。。。
            //目前只处理一种。前后帮会id一致的情况下不处理，否则退出帮会
            //DBUnionInfo dBUnionInfo;

            //DBUnionManager dBUnionManager;

            DataCollationComponent old_dataCollationComponent = GetDBComponent<DataCollationComponent>(zone, unitid, day, DBHelper.DataCollationComponent);
            if (old_dataCollationComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  DataCollationComponent==null:   {zone} {unitid}");
                return;
            }

            EnergyComponent old_energyComponent = GetDBComponent<EnergyComponent>(zone, unitid, day, DBHelper.EnergyComponent);
            if (old_energyComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  energyComponent==null:   {zone} {unitid}");
                return;
            }

            JiaYuanComponent old_jiaYuanComponent = GetDBComponent<JiaYuanComponent>(zone, unitid, day, DBHelper.JiaYuanComponent);
            if (old_jiaYuanComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  jiaYuanComponent==null:   {zone} {unitid}");
                return;
            }

            NumericComponent old_numericComponent = GetDBComponent<NumericComponent>(zone, unitid, day, DBHelper.NumericComponent);
            if (old_numericComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  jiaYuanComponent==null:   {zone} {unitid}");
                return;
            }

            PetComponent old_petComponent = GetDBComponent<PetComponent>(zone, unitid, day, DBHelper.PetComponent);
            if (old_petComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  petComponent==null:   {zone} {unitid}");
                return;
            }

            RechargeComponent old_rechargeComponent = GetDBComponent<RechargeComponent>(zone, unitid, day, DBHelper.RechargeComponent);
            if (old_rechargeComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  rechargeComponent==null:   {zone} {unitid}");
                return;
            }

            ReddotComponent old_reddotComponent = GetDBComponent<ReddotComponent>(zone, unitid, day, DBHelper.ReddotComponent);
            if (old_reddotComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  reddotComponent==null:   {zone} {unitid}");
                return;
            }

            ShoujiComponent old_shoujiComponent = GetDBComponent<ShoujiComponent>(zone, unitid, day, DBHelper.ShoujiComponent);
            if (old_shoujiComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  shoujiComponent==null:   {zone} {unitid}");
                return;
            }

            SkillSetComponent old_skillSetComponent = GetDBComponent<SkillSetComponent>(zone, unitid, day, DBHelper.SkillSetComponent);
            if (old_skillSetComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  skillSetComponent==null:   {zone} {unitid}");
                return;
            }

            TaskComponent old_taskComponent = GetDBComponent<TaskComponent>(zone, unitid, day, DBHelper.TaskComponent);
            if (old_taskComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  taskComponent==null:   {zone} {unitid}");
                return;
            }

            TitleComponent old_titleComponent = GetDBComponent<TitleComponent>(zone, unitid, day, DBHelper.TitleComponent);
            if (old_taskComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  titleComponent==null:   {zone} {unitid}");
                return;
            }

            UserInfoComponent old_userInfoComponent = GetDBComponent<UserInfoComponent>(zone, unitid, day, DBHelper.UserInfoComponent);
            if (old_userInfoComponent == null)
            {
                Console.WriteLine($"OnArchiveHandler  userInfoComponent==null:   {zone} {unitid}");
                return;
            }


            Console.WriteLine($"正确获取到玩家全部数据！！！");

            string account = old_userInfoComponent.Account;
            //通知gate服该玩家在回档中，禁止登陆。。。。

            Console.WriteLine("准备回档 ，通知玩家可以下线！！");
            await NoticeAccountServerArchive(zone, account, unitid, 1);

            //踢玩家下线并存库。。
            Console.WriteLine($"通知游戏服玩家下线操作！！！");
            //ConsoleHelper.KickOutConsoleHandler($"kickout {zone} {unitid}");
            await DisconnectHelper.ArchiveKickOutPlayer(zone, unitid);


            await TimerComponent.Instance.WaitAsync(TimeHelper.Second * 10);

            Console.WriteLine($"移除该玩家在缓存服数据！！！");
            //移除缓存...  并存库。。
            DBHelper.DeleteUnitCache(zone, unitid).Coroutine();


            //移除拍卖行自己的所有装备。。。。。
            long paimaiInstanceid = DBHelper.GetPaiMaiServerId(zone);
            P2A_DeleteRoleData deleteResponse2 = (P2A_DeleteRoleData)await ActorMessageSenderComponent.Instance.Call
           (paimaiInstanceid, new A2P_DeleteRoleData()
           {
               DeleUserID = unitid,
               AccountId = old_userInfoComponent.UserInfo.AccInfoID, //没用到
               DeleteType = 1,
           });

            //已经被拍卖的装备不找回。。。
            string soldbaginfoidstr = string.Empty;
            List <DataCollationComponent> new_dataCollationComponents = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(zone, d => d.Id == unitid);
            if (new_dataCollationComponents != null && new_dataCollationComponents.Count > 0)
            {
                soldbaginfoidstr = new_dataCollationComponents[0].SoldBagInfoID;  
            }

            List<long> soldbaginfoids = new List<long>();
            if (!string.IsNullOrEmpty(soldbaginfoidstr))
            {
                string[] idddss = soldbaginfoidstr.Split('&');
                for (int i = 0; i < idddss.Length; i++)
                {
                    soldbaginfoids.Add(long.Parse(idddss[i]));
                }
            }

            List<DBAccountInfo> new_dbAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(zone, d => d.Id == old_userInfoComponent.UserInfo.AccInfoID);
            if (new_dbAccountInfos == null || new_dbAccountInfos.Count == 0)
            {
                Console.WriteLine($"OnArchiveHandler  new_dbAccountInfos==null:   {zone} {unitid}");
                return;
            }
            for (int i = 0; i < new_dbAccountInfos[0].BagInfoList.Count; i++)
            {
                soldbaginfoids.Add(new_dbAccountInfos[0].BagInfoList[i].BagInfoID);
            }
            //排除在账号仓库的道具。。。

            int occ = old_userInfoComponent.UserInfo.Occ;
            int occTwo = old_userInfoComponent.UserInfo.OccTwo;
            List<BagInfo> bagInfos = old_bagComponent.GetAllItems(occ, occTwo );
            for (int i = 0; i < bagInfos.Count; i++)
            {
                if (soldbaginfoids.Contains(bagInfos[i].BagInfoID))
                {
                    bagInfos[i].ItemID = 0;   //登陆时候会移除。
                }
            }

            long oldunionid = old_numericComponent.GetAsLong(NumericType.UnionId_0);
            long newunionid = 0;
            List<NumericComponent> new_numericComponents = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(zone, d => d.Id == unitid);
            if (new_numericComponents != null && new_numericComponents.Count > 0)
            {
                newunionid = new_numericComponents[0].GetAsLong(NumericType.UnionId_0);
            }

            //处理家族数据, 家族id相等不处理。
            if (oldunionid == newunionid)
            {
                ////
            }
            else
            {
                ///把该玩家从家族中移除。。。
                if (newunionid > 0)
                {
                    long dbCacheId = DBHelper.GetUnionServerId(zone);
                    U2M_UnionLeaveResponse d2GGetUnit = (U2M_UnionLeaveResponse)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2U_UnionLeaveRequest()
                    {
                        UnionId = newunionid,
                        UserId = unitid,
                    });
                }

                ///清空该玩家的家族id 
                old_numericComponent.ApplyValue(NumericType.UnionLeader, 0);
                old_numericComponent.ApplyValue(NumericType.UnionId_0, 0);
                old_userInfoComponent.UpdateRoleData(UserDataType.UnionName, "", false);
            }


            //删除DB数据
            ////推广组件不用判断， 也不用移除
            List<string> allComponets = DBHelper.GetAllUnitComponent();
            for (int i = 0; i < allComponets.Count; i++)
            {
                Console.WriteLine($"AllUnitComponent:  {allComponets[i]}！！！");
                //个人数据组件
                //
                //ActivityComponent    BagComponent     ChengJiuComponent    DBFriendInfo 
                //DBMailInfo    DBPopularizeInfo     DataCollationComponent  EnergyComponent 
                //JiaYuanComponent    NumericComponent     PetComponent     RechargeComponent 
                //ReddotComponent     ShoujiComponent     SkillSetComponent    TaskComponent 
                //TitleComponent      UserInfoComponent 
                //Game.Scene.GetComponent<DBComponent>().Remove<Entity>(zone, unitid, allComponets[i]).Coroutine();
            }

            //除了DBFriendInfo  DBMailInfo   DBPopularizeInfo几个组件，其他的都是进入游戏的已经加载到缓存服，这三个组件需要的时候才加载。

            //导入DB数据
            await SaveDBComponent(zone, old_activityComponent);
            await SaveDBComponent(zone, old_bagComponent);
            await SaveDBComponent(zone, old_chengJiuComponent);
            await SaveDBComponent(zone, old_dBFriendInfo);
            await SaveDBComponent(zone, old_dBMailInfo);

            await SaveDBComponent(zone, old_dataCollationComponent);
            await SaveDBComponent(zone, old_energyComponent);
            await SaveDBComponent(zone, old_jiaYuanComponent);
            await SaveDBComponent(zone, old_numericComponent);
            await SaveDBComponent(zone, old_petComponent);
            await SaveDBComponent(zone, old_rechargeComponent);
            await SaveDBComponent(zone, old_reddotComponent);
            await SaveDBComponent(zone, old_shoujiComponent);
            await SaveDBComponent(zone, old_skillSetComponent);
            await SaveDBComponent(zone, old_taskComponent);
            await SaveDBComponent(zone, old_titleComponent);
            await SaveDBComponent(zone, old_userInfoComponent);

            Console.WriteLine("回档完成 ，通知玩家可以上线！！");
            await NoticeAccountServerArchive(zone, account, unitid, 0);
            //archive 5 2631939174340558848 1
        }

        public static async ETTask SaveDBComponent<T>(int zone,T entity) where T : Entity
        {
            if (entity!=null)
            {
                await Game.Scene.GetComponent<DBComponent>().Save(zone, entity);
            }
        }

        public static async ETTask NoticeAccountServerArchive(int zone, string acccout, long unitid, int archive)
        {
            long gateinstanceid = StartSceneConfigCategory.Instance.GetBySceneName(zone, "Account").InstanceId;
            A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
              (gateinstanceid, new A2A_ServerMessageRequest()
              {
                  MessageType = NoticeType.Archive,
                  MessageValue = $"{acccout} {unitid} {archive}",
              });
        }



        public static async ETTask ExecuteBatchFileNew()
        {
            await ETTask.CompletedTask;

            string filepath = "C:/WJ/{0}/";
            RenameFolderName(string.Format(filepath, 6), string.Format(filepath, 7));
            RenameFolderName(string.Format(filepath, 5), string.Format(filepath, 6));
            RenameFolderName(string.Format(filepath, 4), string.Format(filepath, 5));
            RenameFolderName(string.Format(filepath, 3), string.Format(filepath, 4));
            RenameFolderName(string.Format(filepath, 2), string.Format(filepath, 3));
            RenameFolderName(string.Format(filepath, 1), string.Format(filepath, 2));

            await TimerComponent.Instance.WaitAsync(TimeHelper.Second * 10);

            ///只导出七天以内登陆的玩家数据
            long serverTime = TimeHelper.ServerNow();
            List<ServerItem> serverItems = ServerHelper.GetServerList();
            for (int i = 0; i < serverItems.Count; i++)
            {
                if (serverItems[i].Show != 0 && serverItems[i].ServerOpenTime <= serverTime)
                {
                    await ExecuteBatchAllComponent(serverItems[i].ServerId);
                }
            }

            Console.WriteLine("ExecuteBatchFileNew End");
        }

        public static async ETTask ExecuteBatchAllComponent(int zone)
        {
            await ETTask.CompletedTask;
            long serverTime = TimeHelper.ServerNow();

            List<long> saveuserids = new List<long>();  
            List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(zone, d => d.Id > 0);
            for (int i = 0; i < userinfoComponentList.Count; i++)
            {
                UserInfoComponent userInfoComponent = userinfoComponentList[i];
                if (userInfoComponent.UserInfo.RobotId != 0)
                {
                    continue;
                }

                //只记录七天内登陆的玩家
                if (serverTime - userInfoComponent.LastLoginTime > TimeHelper.OneDay * 3)
                {
                    continue;
                }

                saveuserids.Add(userInfoComponent.Id);    
            }

            //foreach (Type type in Game.EventSystem.GetTypes().Values)
            //{
            //    if (type != typeof(IUnitCache) && typeof(IUnitCache).IsAssignableFrom(type))
            //    {

            //    }
            //}
            Console.WriteLine($"ExecuteBatchAllComponent:  zone: {zone}   number: {saveuserids.Count}");
            await ExecuteBatchSingleComponent<ActivityComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<BagComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<ChengJiuComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<DBFriendInfo>(zone, saveuserids);
            await ExecuteBatchSingleComponent<DBMailInfo>(zone, saveuserids);
            await ExecuteBatchSingleComponent<DataCollationComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<EnergyComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<JiaYuanComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<NumericComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<PetComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<RechargeComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<ReddotComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<ShoujiComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<SkillSetComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<TaskComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<TitleComponent>(zone, saveuserids);
            await ExecuteBatchSingleComponent<UserInfoComponent>(zone, saveuserids);
        }

        public static async ETTask ExecuteBatchSingleComponent<K>(int zone,  List<long> saveuserids) where K : Entity, new()
        {
            await ETTask.CompletedTask;

            List<byte[]> allComponents = new List<byte[]>();
            for (int i = 0; i < saveuserids.Count; i++)
            {
                long userid = saveuserids[i];       
                List<K> componentList = await Game.Scene.GetComponent<DBComponent>().Query<K>(zone, d => d.Id == userid);

                if (componentList.Count == 0)
                {
                    Console.WriteLine($"ExecuteBatchSingleComponent==null: {zone} {userid}  {typeof(K).Name}");
                    Log.Error($"ExecuteBatchSingleComponent==null: {zone} {userid}  {typeof(K).Name}");
                    continue;
                }

                allComponents.Add(MongoHelper.ToBson(componentList[0]));
            }
            string filepath = $"C:/WJ/1/WJBeta{zone}/";
            string fileName = $"{typeof(K).Name}.bin";

            SaveListToJson(allComponents, filepath, filepath + fileName);

            //UserInfoComponent userInfoComponent = GetUserComponent<UserInfoComponent>(134, 2694759532839632896);
            //Console.WriteLine(" MongoHelper.Deserialize");
        }


        public static K GetDBComponent<K>(int zone, long unitid,int day, string key) where K : Entity, new()
        {
            string filepath = $"C:/WJ/{day}/WJBeta{zone}/";
            string fileName = $"{typeof(K).Name}.bin";

            List<byte[]> deserializedBytes = LoadListFromJson(filepath + fileName);

            for (int i = 0; i < deserializedBytes.Count; i++)
            {
                K entity = MongoHelper.Deserialize<K>(deserializedBytes[i]);
                if (entity.Id == unitid)
                {
                    return entity;
                }
            }
            return null;    
        }

        // 序列化 List<byte[]> 并保存到 JSON 文件
        static void SaveListToJson(List<byte[]> list, string filePath,  string fileName)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            // 序列化 List<byte[]> 为 JSON 字符串
            string json = JsonSerializer.Serialize(list);
            // 将 JSON 字符串写入文件
            File.WriteAllText(fileName, json);
        }

        // 从 JSON 文件读取并反序列化 List<byte[]>
        static List<byte[]> LoadListFromJson(string filePath)
        {
            // 读取 JSON 文件内容
            string json = File.ReadAllText(filePath);
            // 反序列化 JSON 字符串为 List<byte[]>
            return JsonSerializer.Deserialize<List<byte[]>>(json);
        }


        private static void RenameFolderName(string originalFolderPath , string newFolderPath)
        {
            try
            {
                // 确保新的文件夹名称不存在
                if (!Directory.Exists(originalFolderPath))
                {
                    return;
                }

                if (Directory.Exists(newFolderPath))
                {
                    Directory.Delete(newFolderPath, true);
                }

                var fileInfo = new FileInfo(originalFolderPath);
                if ((fileInfo.Attributes & FileAttributes.ReadOnly) > 0)
                {
                    fileInfo.Attributes ^= FileAttributes.ReadOnly;
                }

                // 重命名文件夹
                Directory.Move(originalFolderPath, newFolderPath);
                Console.WriteLine($"文件夹名称已修改:{originalFolderPath}  {newFolderPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误: " + ex.Message);
            }
        }
    }
}
