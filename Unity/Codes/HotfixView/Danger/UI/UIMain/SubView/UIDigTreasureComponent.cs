using System;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.UIDigTreasureTimer)]
    public class UIDigTreasureTimer : ATimer<UIDigTreasureComponent>
    {
        public override void Run(UIDigTreasureComponent self)
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

    public class UIDigTreasureComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Img_Pos;
        public GameObject GameObject;
        public GameObject ButtonDig;
        public GameObject Img_ChanZi;
        public GameObject Img_Node;

        public BagInfo BagInfo;
        public float PassTime = 0f;
        public float MoveSpeed = 50f;
        public long Timer;
    }

    [ObjectSystem]
    public class UIDigTreasureComponentAwakeSystem : AwakeSystem<UIDigTreasureComponent, GameObject>
    {
        public override void Awake(UIDigTreasureComponent self, GameObject go)
        {
            self.GameObject = go;

            self.Img_Pos = go.Get<GameObject>("Img_Pos");
            self.ButtonDig = go.Get<GameObject>("ButtonDig");
            ButtonHelp.AddListenerEx(self.ButtonDig, () => { self.OnButtonDig(); });

            self.Img_ChanZi = go.Get<GameObject>("Img_ChanZi");
            self.Img_Node = go.Get<GameObject>("Img_Node");
        }
    }

    [ObjectSystem]
    public class UIDigTreasureComponentDestroySystem : DestroySystem<UIDigTreasureComponent>
    {
        public override void Destroy(UIDigTreasureComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIDigTreasureComponentSystem
    {

        public static void OnInitUI(this UIDigTreasureComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            self.GameObject.SetActive(true);
            float size = RandomHelper.RandFloat01();
            self.Img_Pos.transform.localPosition = new Vector3(size * 300f, 0f, 0f);
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.UIDigTreasureTimer, self);
        }

        public static void  OnButtonDig(this UIDigTreasureComponent self)
        {
            float distance = Vector3.Distance(self.Img_ChanZi.transform.localPosition, self.Img_Pos.transform.localPosition);
            self.GameObject.SetActive(false);
            TimerComponent.Instance?.Remove(ref self.Timer);
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            bagComponent.SendUseItem(self.BagInfo, distance <= 10f ? "2" : "1").Coroutine();
        }

        public static void OnTimer(this UIDigTreasureComponent self)
        {
            self.PassTime += Time.deltaTime;
            float posX = self.PassTime * self.MoveSpeed;
            if (posX > 300f)
            {
                posX = 0;
                self.PassTime = 0;
            }
            self.Img_ChanZi.transform.localPosition = new Vector3(posX, 0f, 0f);
        }
    }
}
