using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System.IO;

namespace ET
{

    [ObjectSystem]
    public class MapComponentAwakeSystem : AwakeSystem<MapComponent>
    {
		public override void Awake(MapComponent self)
		{
#if SERVER
			self.MoveMessageList.Clear();
			self.InitMapInfo();
#endif
		}
    }

    [ObjectSystem]
    public class MapComponentDestroy : DestroySystem<MapComponent>
    {
        public override void Destroy(MapComponent self)
        {
#if SERVER
            self.StopTimer();
#endif
        }
    }

#if SERVER
    [Timer(TimerType.BroadcastTimer)]
    public class BroadcastTimer : ATimer<MapComponent>
    {
        public override void Run(MapComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }
#endif

    public static class MapComponentSystem
	{

#if SERVER
        public static void BeginTimer(this MapComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(10000, TimerType.BroadcastTimer, self);       //10秒发送同步一次数据
        }

        public static void StopTimer(this MapComponent self)
        {
            TimerComponent.Instance.Remove( ref self.Timer);
        }

        public static async void  OnTimer(this MapComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            var watch = Stopwatch.StartNew();

            ///移动的玩家
            Dictionary<long, M2C_PathfindingResult> MoveMessageList = self.MoveMessageList;
            if (MoveMessageList.Count == 0)
            {
                return;
            }

            //第二最省模式
            int numSheng = Math.Min(1, self.MoveMessageList.Count);
            int numShengInt = 0;

            List<M2C_PathfindingResult> m2C_PathfindingsSheng = new List<M2C_PathfindingResult>();
            /*
            for (int i = 0; i < numSheng; i++) {
                m2C_PathfindingsSheng.Add(MoveMessageList[i]);
            }
            */
            foreach (M2C_PathfindingResult m2cPathfindingResult in MoveMessageList.Values) {
                m2C_PathfindingsSheng.Add(m2cPathfindingResult);
                if (numShengInt >= numSheng) {
                    break;
                }
                numShengInt++;
            }

            //Log.Console(TimeHelper.DateTimeNow().ToString() + "watch111耗时:" + watch.ElapsedMilliseconds + "毫秒");

            M2C_PathfindingListResult messageSheng = new M2C_PathfindingListResult();
            messageSheng.PathList.AddRange(m2C_PathfindingsSheng.GetRange(0, numSheng)); //添加对应序号的包

            (ushort opcode, MemoryStream stream) = MessageSerializeHelper.MessageToStream(messageSheng);

            //Log.Console(TimeHelper.DateTimeNow().ToString() + "watch222耗时:" + watch.ElapsedMilliseconds + "毫秒");

            int AoiNum = 0;
            int AoiNumShiJi = 0;
            //获取当前场景所有的玩家
            List<Unit> allplayers = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            //Log.Console(TimeHelper.DateTimeNow().ToString() + "watch333耗时:" + watch.ElapsedMilliseconds + "毫秒");
            for (int i = allplayers.Count - 1; i >= 0; i--)
            {
                if (allplayers[i].IsDisposed)
                {
                    continue;
                }

                //Log.Console(TimeHelper.DateTimeNow().ToString() + "watch333aaa耗时:" + watch.ElapsedMilliseconds + "毫秒");
                MessageHelper.SendToClientNew(allplayers[i], messageSheng, opcode, stream);
                //MessageHelper.SendToClient(allplayers[i], messageSheng);
                await TimerComponent.Instance.WaitFrameAsync();
                //Log.Console(TimeHelper.DateTimeNow().ToString() + "watch333bbb耗时:" + watch.ElapsedMilliseconds + "毫秒");
                //showMovePlayerNum++;

                //临时计数显示
                self.num++;
                self.messagelenght += MongoHelper.ToBson(messageSheng).Length;
                //Log.Console(TimeHelper.DateTimeNow().ToString() + "watch333ccc耗时:" + watch.ElapsedMilliseconds + "毫秒");
            }

            //Log.Console(TimeHelper.DateTimeNow().ToString() + "watch4444耗时:" + watch.ElapsedMilliseconds + "毫秒");

            /*
            //第一种模式
            int AoiNum = 0;
            int AoiNumShiJi = 0;
            //获取当前场景所有的玩家
            List<Unit> allplayers = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            for (int i = allplayers.Count - 1; i >= 0; i--)
            {
                if (allplayers[i].IsDisposed)
                {
                    continue;
                }

                List<M2C_PathfindingResult> m2C_Pathfindings = new List<M2C_PathfindingResult>();

                //获取当前玩家对应的视野内的玩家
                Dictionary<long, AOIEntity> dict = allplayers[i].GetBeSeePlayers();

                //获取该玩家视野内的移动包,把视野内的移动包都存在一起
                int aoiMaxNum = 0;
                foreach (AOIEntity u in dict.Values)
                {
                    if (u.Unit.Id != allplayers[i].Id && MoveMessageList.ContainsKey(u.Unit.Id))
                    {
                        m2C_Pathfindings.Add(MoveMessageList[u.Unit.Id]);

                        //周围超过30个人直接不显示其他人的移动数据
                        if (aoiMaxNum >= 30) {
                            break;
                        }

                        aoiMaxNum++;
                    }
                }



                AoiNum += dict.Count;
                AoiNumShiJi += aoiMaxNum;

                int showMovePlayerNum = 0;
                //一次N个移动包,发送给对应的玩家
                while (m2C_Pathfindings.Count > 0)
                {
                    M2C_PathfindingListResult message = new M2C_PathfindingListResult();

                    int maxnumber = Math.Min(100, m2C_Pathfindings.Count);

                    message.PathList.AddRange(m2C_Pathfindings.GetRange(0, maxnumber)); //添加对应序号的包
                    m2C_Pathfindings.RemoveRange(0, maxnumber); //移除对应序号的包

                    MessageHelper.SendToClient(allplayers[i], message);

                    //给100个人发送数据直接退
                    if (showMovePlayerNum >= 100) {
                        break;
                    }

                    showMovePlayerNum++;

                    //临时计数显示
                    self.num++;
                    self.messagelenght += MongoHelper.ToBson(message).Length;


                }

                await TimerComponent.Instance.WaitFrameAsync();
            }
            */

            TimeSpan timeS = TimeHelper.DateTimeNow() - dateTime;
            //timeS.Ticks
            watch.Stop();
            Log.Console(TimeHelper.DateTimeNow().ToString() + " 耗时:" + timeS.Milliseconds + "毫秒"+ "watch耗时:" + watch.ElapsedMilliseconds + "毫秒 10秒move数据:" + self.messagelenght + " num:" + self.num + " allplayers:" + allplayers.Count + " AoiNum:" + AoiNum + " AoiNumShiJi:" + AoiNumShiJi + " 对应:" + ((int)(AoiNum/ allplayers.Count)).ToString());
            self.messagelenght = 0;
            self.num = 0;

            MoveMessageList.Clear();
        }


        public static void InitMapInfo(this MapComponent self, StartSceneConfig startSceneConfig=null)
		{
			Scene scene = self.DomainScene();
			if (!scene.Name.Contains("Map"))
			{
				return;
			}
			string map = scene.Name.Substring(3, scene.Name.Length - 3);
			int sceneId = int.Parse(map);
			
			if (sceneId == 101)	//主城
			{
				SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(ComHelp.MainCityID());
				self.SetMapInfo((int)SceneTypeEnum.MainCityScene, sceneConfig.MapID, 0);
				self.NavMeshId = sceneConfig.MapID.ToString();

                self.BeginTimer();
            }
			else
			{
				SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
				self.SetMapInfo(sceneConfig.MapType, sceneConfig.MapID, 0);
				self.NavMeshId = sceneConfig.MapID.ToString();
			}
		}

		public static Vector3 GetCanChongJiPath(this MapComponent self, Vector3 start, Vector3 target)
		{
            //using var list = ListComponent<Vector3>.Create();
            //Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), start, target, list, 2);
            //Vector3 dir = (target - start);
            //float ange_1 = Mathf.Rad2Deg(Mathf.Atan2(dir.x, dir.z));

            //if (list.Count > 2)
            //{
            //    for (int i = 1; i < list.Count; i++)
            //    {
            //        Vector3 dirteamp = (list[i] - start);
            //        float ange_2 = Mathf.Rad2Deg(Mathf.Atan2(dirteamp.x, dirteamp.z));
            //        if (Mathf.Abs(ange_1 - ange_2) >= 10)
            //        {
            //            return list[i];
            //        }
            //    }

            //    return list[list.Count - 1];
            //}
            //else
            //{
            //    return start;
            //}

            //old
            using var list = ListComponent<Vector3>.Create();
            Vector3 dir = (target - start).normalized;
            Vector3 tmm = start;
            while (true)
            {
                tmm = tmm + (1f * dir);
                Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), start, tmm, list, 2);
                if (list.Count == 0 || list.Count == 1)
                {
                    break;
                }
				if (Mathf.Abs(list[list.Count - 1].x - tmm.x) > 0.1f || Mathf.Abs(list[list.Count - 1].z - tmm.z) > 0.1f)
                {
                    break;
                }
                if (Vector3.Distance(tmm, target) <= 1f)
                {
                    break;
                }
            }
            return tmm;
        }

		public static Vector3 GetCanReachPath(this MapComponent self, Vector3 start, Vector3 target)
		{
			using var list = ListComponent<Vector3>.Create();
			Vector3 dir = (start - target).normalized;
            while (true)
            {
                Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), start, target, list, 2);
                if (list.Count >= 2)
                {
                    target = list[list.Count - 1];
                    break;
                }
                if (Vector3.Distance(start, target) < 0.5f)
                {
                    break;
                }
                target = target + (0.5f * dir);
            }
            return target;
		}

		public static void SearchPath(this MapComponent self, Unit unit, Vector3 target, List<Vector3> result)
		{
			if (self.OldNavMesh)
			{
				Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), unit.Position, target, result, unit.Type);
			}
			else
			{
				unit.GetComponent<PathfindingComponent>().Find(unit.Position, target, result);
			}
		}
#endif

		public static void SetMapInfo(this MapComponent self, int sceneTypeEnum, int mapid, int sonMapid)
		{
			self.SceneTypeEnum = sceneTypeEnum;
			self.SceneId = mapid;
			self.SonSceneId = sonMapid;
		}

		public static void SetSubLevel(this MapComponent self, int sonMapid)
		{
			self.SonSceneId = sonMapid;
		}

		public static int GetMapId(this MapComponent self)
		{
			return self.SceneId;
		}

		public static int GetSubLevelId(this MapComponent self)
		{
			return self.SonSceneId;
		}
	}


}
