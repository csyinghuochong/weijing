using UnityEngine;

namespace ET
{

    public class UISingingComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject Img_Progress;
        public GameObject Img_Di2;
    }

    [ObjectSystem]
    public class UISingingComponentAwakeSystem : AwakeSystem<UISingingComponent, GameObject>
    {
        public override void Awake(UISingingComponent self, GameObject go)
        {
            self.GameObject = go;
            self.Img_Progress = go.Get<GameObject>("Img_Progress");
            self.Img_Di2 = go.Get<GameObject>("Img_Di2");
            self.GameObject.SetActive(false);
        }
    }

    public static class UISingingComponentSystem
    {
        public static void OnTimer(this UISingingComponent self, EventType.SingingUpdate args)
        {
            if (args.Type == 1)
            {
                self.Img_Progress.transform.localScale = new Vector3((1f * args.PassTime / args.TotalTime), 1f, 1f);
            }
            else
            {
                self.Img_Progress.transform.localScale = new Vector3((1f - 1f * args.PassTime / args.TotalTime), 1f, 1f);
            }
            if (args.PassTime <= 100)
            {
                self.GameObject.SetActive(true);
            }
            if (args.PassTime >= args.TotalTime || args.PassTime <= -1)
            {
                self.GameObject.SetActive(false);
            }
        }
    }
}
