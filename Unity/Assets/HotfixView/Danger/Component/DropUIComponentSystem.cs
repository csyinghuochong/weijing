using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ET
{
    [Timer(TimerType.DropUITimer)]
    public class DropUITimer : ATimer<DropUIComponent>
    {
        public override void Run(DropUIComponent self)
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


    [ObjectSystem]
    public class DropUIComponentAwakeSystem : AwakeSystem<DropUIComponent>
    {
        public override void Awake(DropUIComponent self)
        {
            self.PositionIndex = 0;
            self.HeadBar = null;
            self.MyUnit = self.GetParent<Unit>();
            self.UICamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
        }
    }

    [ObjectSystem]
    public class DropUIComponentDestroySystem : DestroySystem<DropUIComponent>
    {
        public override void Destroy(DropUIComponent self)
        {
            self.Destroy();
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class DropUIComponentSystem
    {
        public static void OnLoadGameObject(this DropUIComponent self, GameObject go, long formId)
        {
            if (self.IsDisposed)
            {
                self.Destroy();
                return;
            }
            self.HeadBar = go;
            self.HeadBar.SetActive(true);
            self.HeadBar.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.Blood]);
            self.HeadBar.transform.localScale = Vector3.one;
            if (self.HeadBar.GetComponent<HeadBarUI>() == null)
            {
                self.HeadBar.AddComponent<HeadBarUI>();
            }
            self.HeadBarUI = self.HeadBar.GetComponent<HeadBarUI>();
            self.HeadBarUI.HeadPos = self.UIPosition;
            self.HeadBarUI.HeadBar = self.HeadBar;
            Unit parent = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(self.DropInfo.UnitId);
            if (parent == null)
            {
                self.MyUnit.Position = new Vector3(self.DropInfo.X, self.DropInfo.Y, self.DropInfo.Z);
            }
            else
            {
                self.MyUnit.Position = parent.Position;
                self.StartPoint = parent.Position;
                self.EndPoint = new Vector3(self.DropInfo.X, parent.Position.y, self.DropInfo.Z);
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.DropUITimer, self);
                self.GeneratePositions();
            }
            self.ShowDropInfo(self.DropInfo);

            //创建特效(排除基础货币)
            if (self.DropInfo.ItemID >= 100)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.DropInfo.ItemID);
                if (itemConfig.ItemQuality == 4)
                {
                    FunctionEffect.GetInstance().PlaySelfEffect(self.MyUnit, 91000104);
                }
                if (itemConfig.ItemQuality == 5)
                {
                    FunctionEffect.GetInstance().PlaySelfEffect(self.MyUnit, 91000105);
                }
            }

            self.LateUpdate();
        }

        public static void  InitData(this DropUIComponent self, DropInfo dropinfo)
        {
            self.DropInfo = dropinfo;
            GameObjectComponent gameObjectComponent = self.MyUnit.GetComponent<GameObjectComponent>();
            self.UIPosition = gameObjectComponent.GameObject.transform.Find("UIPosition");
            self.ModelMesh = gameObjectComponent.GameObject.transform.Find("DropModel").GetComponent<MeshRenderer>();

            var path = ABPathHelper.GetUGUIPath("Battle/UIDropItem");
            GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
        }

        public static  void ShowDropInfo(this DropUIComponent self, DropInfo dropinfo )
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(dropinfo.ItemID);
            TextMeshProUGUI textMeshProUGUI = self.HeadBar.transform.Find("Lab_DropName").gameObject.GetComponent<TextMeshProUGUI>();
            //显示名称
            if (dropinfo.ItemNum == 1)
            {
                textMeshProUGUI.text = itemConfig.ItemName;
            }
            else 
            {
                textMeshProUGUI.text = $"{dropinfo.ItemNum}{itemConfig.ItemName}";
            }

            //显示品质
            textMeshProUGUI.color = FunctionUI.GetInstance().QualityReturnColor(itemConfig.ItemQuality);
            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(dropinfo.ItemID);
            //显示UI
            self.HeadBar.SetActive(true);

            Sprite sprite = null;
            long instanceid = self.InstanceId;
            if (dropinfo.ItemID != 1)
            {
                sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            }
            if (sprite ==null || instanceid != self.InstanceId)
            {
                return;
            }
            try
            {
                Texture2D targetTex = new Texture2D((int)sprite.textureRect.width, (int)sprite.textureRect.height);
                var pixels = sprite.texture.GetPixels(
                    (int)sprite.textureRect.x,
                    (int)sprite.textureRect.y,
                    (int)sprite.textureRect.width,
                    (int)sprite.textureRect.height);
                targetTex.SetPixels(pixels);
                targetTex.Apply();

                self.ModelMesh.material.mainTexture = targetTex;
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
        }

        public static void GeneratePositions(this DropUIComponent self)
        {
            //height为高度
            float height = 8f;
            Vector3 bezierControlPoint = (self.StartPoint + self.EndPoint) * 0.5f + (Vector3.up * height);

            //resolution为int类型，表示要取得路径点数量，值越大，取得的路径点越多，曲线最后越平滑
            self.Resolution = 20;
            self.LinepointList = new Vector3[self.Resolution];
            for (int i = 0; i < self.Resolution; i++)
            {
                var t = (i + 1) / (float)self.Resolution;//归化到0~1范围
                self.LinepointList[i] = self.GetBezierPoint(t, self.StartPoint, bezierControlPoint, self.EndPoint);//使用贝塞尔曲线的公式取得t时的路径点
            }
        }

        /// <param name="t">0到1的值，0获取曲线的起点，1获得曲线的终点</param>
        /// <param name="start">曲线的起始位置</param>
        /// <param name="center">决定曲线形状的控制点</param>
        /// <param name="end">曲线的终点</param>
        public static Vector3 GetBezierPoint(this DropUIComponent self, float t, Vector3 start, Vector3 center, Vector3 end)
        {
            return (1 - t) * (1 - t) * start + 2 * t * (1 - t) * center + t * t * end;
        }

        public static  void OnUpdate(this DropUIComponent self)
        {
            self.PositionIndex++;
            //快速下落处理
            if (self.PositionIndex >= (int)(self.Resolution * 0.4f))
            {
                self.PositionIndex++;
            }
            //快速下落处理
            if (self.PositionIndex >= (int)(self.Resolution * 0.6f))
            {
                self.PositionIndex++;
            }
            if (self.PositionIndex >= self.Resolution)
            {
                self.MyUnit.Position = self.LinepointList[self.Resolution - 1];
                TimerComponent.Instance.Remove(ref self.Timer);
                return;
            }
            self.MyUnit.Position = self.LinepointList[self.PositionIndex];
        }

        public static void LateUpdate(this DropUIComponent self)
        {
            if (self.HeadBar == null)
            {
                return;
            }
            if (self.LastTime == Time.time)
            {
                return;
            }
            self.LastTime = Time.time;
            self.LastTime = Time.time;
            Transform UIPosition = self.UIPosition;
            Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(UIPosition.position, self.HeadBar, self.UICamera, self.MainCamera);

            Vector3 NewPosition = Vector3.zero;
            NewPosition.x = OldPosition.x;
            NewPosition.y = OldPosition.y;
            self.HeadBar.transform.localPosition = NewPosition;
        }

        public static void Destroy(this DropUIComponent self)
        {
            if (self.HeadBar != null)
            {
                self.HeadBar.SetActive(false);
                GameObjectPoolComponent.Instance.RecoverGameObject(ABPathHelper.GetUGUIPath("Battle/UIDropItem"), self.HeadBar);
                self.HeadBar = null;
            }
            self.PositionIndex = 0;
        }
    }
}
