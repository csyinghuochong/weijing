using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.XuLieZhenTimer)]
    public class XuLieZhenTimer : ATimer<UIXuLieZhenComponent>
    {
        public override void Run(UIXuLieZhenComponent self)
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

    public class UIXuLieZhenComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public Image Image;
        public long Timer;
        public int Index = -1;
        public List<Sprite> Sprites = new List<Sprite>();   
    }

    public class UIXuLieZhenComponentAwake : AwakeSystem<UIXuLieZhenComponent, GameObject>
    {
        public override void Awake(UIXuLieZhenComponent self, GameObject gameObject)
        {
            self.Index = -1;
            self.Sprites.Clear();   
            self.Image = gameObject.GetComponent<Image>();
        }
    }

    public class UIXuLieZhenComponentDestroy : DestroySystem<UIXuLieZhenComponent>
    {
        public override void Destroy(UIXuLieZhenComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIXuLieZhenComponentSystem
    {
        public static async ETTask OnUpdateTitle(this UIXuLieZhenComponent self, int titleId)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
            if (titleId <= 0)
            { 
                self.Image.gameObject.SetActive(false);
                return;
            }

            self.Sprites.Clear();
            self.Image.gameObject.SetActive(true);
            
            TitleConfig titleConfig = TitleConfigCategory.Instance.Get(titleId);
          
            long instanceId = self.InstanceId;
            for (int i = 0; i < titleConfig.AnimatorNumber; i++)
            {
                Sprite sprite = await ABAtlasHelp.GetIconSpriteAsync(ABAtlasTypes.ChengHaoIcon, $"{titleConfig.AnimatorAsset}/{i+1}");
                if (instanceId != self.InstanceId)
                {
                    return;
                }
                self.Sprites.Add(sprite);

                if (i == 0)
                {
                    self.Image.sprite = self.Sprites[0];
                    await TimerComponent.Instance.WaitFrameAsync();

                    self.Image.SetNativeSize();
                    self.Image.transform.localScale = Vector2.one * (float)titleConfig.size;
                    self.Image.transform.localPosition = new Vector3((float)titleConfig.MoveX, 75 + (float)titleConfig.MoveY, self.Image.transform.localPosition.z);
                }
            }

            self.Index = 0;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(250, TimerType.XuLieZhenTimer, self );
        }

        public static void OnTimer(this UIXuLieZhenComponent self)
        {
            if (self.Index >= self.Sprites.Count)
            {
                self.Index = 0;
            }
            self.Image.sprite = self.Sprites[self.Index];
            self.Index++;
        }
    }
}
