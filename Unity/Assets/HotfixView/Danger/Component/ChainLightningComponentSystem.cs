using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.ChainLightningTimer)]
    public class ChainLightningTimer : ATimer<ChainLightningComponent>
    {
        public override void Run(ChainLightningComponent self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class ChainLightningComponentAwakeSystem : AwakeSystem<ChainLightningComponent, GameObject>
    {
        public override void Awake(ChainLightningComponent self, GameObject go)
        {
            self._lineRender = go.GetComponent<LineRenderer>();
            self._linePosList = new List<Vector3>();

            self.Start = go.transform;
            self.End = go.transform;

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(100, TimerType.ChainLightningTimer, self);
        }
    }

    public class ChainLightningComponentDestroySystem : DestroySystem<ChainLightningComponent>
    {
        public override void Destroy(ChainLightningComponent self)
        {
            self.Start = null;
            self.End = null;
            self.UsePosition = false;   
            TimerComponent.Instance?.Remove( ref self.Timer );
        }
    }

    public static class ChainLightningComponentSystem
    {
        public static void OnUpdate(this ChainLightningComponent self)
        {
            //判断是否暂停，未暂停则进入分支
            if (self.Start == null)
            {
                return;
            }
            if (!self.UsePosition && self.End == null)
            {
                return;
            }

            if (Time.timeScale != 0)
            {
                self._linePosList.Clear();

                Vector3 startPos = self.Start.position + Vector3.up * self.yOffset;
                Vector3 endPos = Vector3.zero;
                if (self.UsePosition)
                {
                    endPos = self.EndPosition + Vector3.up * self.yOffset;
                }
                else
                {
                    endPos = self.End.position + Vector3.up * self.yOffset;
                }

                //获得开始点与结束点之间的随机生成点
                self.CollectLinPos(startPos, endPos, self.displacement);

                self._linePosList.Add(endPos);
                //把点集合赋给LineRenderer

                self._lineRender.positionCount = (self._linePosList.Count);
                for (int i = 0, n = self._linePosList.Count; i < n; i++)
                {
                    self._lineRender.SetPosition(i, self._linePosList[i]);
                }
            }
        }

        //收集顶点，中点分形法插值抖动  
        public static void CollectLinPos(this ChainLightningComponent self, Vector3 startPos, Vector3 destPos, float displace)
        {
            //递归结束的条件
            if (displace < self.detail)
            {
                self._linePosList.Add(startPos);
            }
            else
            {
                float midX = (startPos.x + destPos.x) / 2;
                float midY = (startPos.y + destPos.y) / 2;
                float midZ = (startPos.z + destPos.z) / 2;

                midX += (float)(UnityEngine.Random.value - 0.5) * displace;

                midY += (float)(UnityEngine.Random.value - 0.5) * displace;

                midZ += (float)(UnityEngine.Random.value - 0.5) * displace;

                Vector3 midPos = new Vector3(midX, midY, midZ);

                //递归获得点

                self.CollectLinPos(startPos, midPos, displace / 2);

                self.CollectLinPos(midPos, destPos, displace / 2);
            }
        }
    }
}
