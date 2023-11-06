using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIXuLieZhenComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;
        public XuLieZhen XuLieZhen;
    }

    public class UIXuLieZhenComponentAwake : AwakeSystem<UIXuLieZhenComponent, GameObject>
    {
        public override void Awake(UIXuLieZhenComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
        }
    }

    public static class UIXuLieZhenComponentSystem
    {
        public static async ETTask OnUpdateTitle(this UIXuLieZhenComponent self, int titleId)
        {
            if (titleId <= 0)
            {
                self.GameObject.SetActive(false);
                return;
            }

            self.GameObject.SetActive(true);
            self.XuLieZhen = self.GameObject.GetComponent<XuLieZhen>();
            if (self.XuLieZhen == null)
            {
                self.XuLieZhen = self.GameObject.AddComponent<XuLieZhen>();
            }

            TitleConfig titleConfig = TitleConfigCategory.Instance.Get(titleId);
          
            long instanceId = self.InstanceId;
            List<Sprite> Sprites = new List<Sprite>();
            for (int i = 0; i < titleConfig.AnimatorNumber; i++)
            {
                var path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ChengHaoIcon, $"{titleConfig.AnimatorAsset}/{i + 1}");
                Sprite sprite = await ResourcesComponent.Instance.LoadAssetAsync<Sprite>(path);
                if (instanceId != self.InstanceId)
                {
                    return;
                }

                if (i == 0)
                {
                    self.XuLieZhen.SetSize(sprite, Vector2.one * (float)titleConfig.size, new Vector3((float)titleConfig.MoveX, 75 + (float)titleConfig.MoveY, self.GameObject.transform.localPosition.z));
                    self.XuLieZhen.Index = 0;
                }
                Sprites.Add(sprite);
            }

            self.XuLieZhen.SetSprites(Sprites);
        }

    }
}
