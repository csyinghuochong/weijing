using System;
using UnityEngine;
using System.Collections.Generic;


namespace ET
{

    public class UIPageViewComponent : Entity, IAwake, IDestroy
    {
        public int LastIndex;
        public UI[] UISubViewList;
        public string[] UISubViewPath;
        public Type[] UISubViewType;

        public List<string> AssetList = new List<string>(); 
    }


    public class UIPageViewComponentAwake : AwakeSystem<UIPageViewComponent>
    {

        public override void Awake(UIPageViewComponent self)
        {
            self.LastIndex = -1;
            self.AssetList.Clear();
        }
    }

    public class UIPageViewComponentDestroy : DestroySystem<UIPageViewComponent>
    {

        public override void Destroy(UIPageViewComponent self)
        {
            for (int i = 0; i < self.AssetList.Count; i++)
            {
                ResourcesComponent.Instance.UnLoadAsset(self.AssetList[i]); 
            }
        }
    }

    public static class UIPageViewComponentSystem
    {

        public static async ETTask<UI> OnSelectIndex(this UIPageViewComponent self, int page)
        {
            if (self.UISubViewList[page] == null && self.UISubViewPath[page].Length > 0)
            {
                long instanceid = self.InstanceId;
                string path = self.UISubViewPath[page];
                self.UISubViewPath[page] = "";
                GameObject bundleObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
                if (instanceid != self.InstanceId)
                {
                    return null;
                }
                self.AssetList.Add(path);
                GameObject go = GameObject.Instantiate(bundleObject);
                UI ui = self.AddChild<UI, string, GameObject>(self.UISubViewType[page].ToString(), go);
                ui.AddComponent(self.UISubViewType[page]);
                self.UISubViewList[page] = ui;
                UICommonHelper.SetParent(self.UISubViewList[page].GameObject, self.GetParent<UI>().GameObject);

                self.UISubViewList[page].GameObject.GetComponent<RectTransform>().offsetMax = Vector2.zero;
                self.UISubViewList[page].GameObject.GetComponent<RectTransform>().offsetMin = Vector2.zero;
                GameSettingLanguge.TransformText(self.UISubViewList[page].GameObject.transform);
                GameSettingLanguge.TransformImage(self.UISubViewList[page].GameObject.transform);
            }

            if (self.LastIndex != -1 && self.UISubViewList[self.LastIndex]!=null)
            {
                self.UISubViewList[self.LastIndex].GameObject.SetActive(false);
            }
            if (self.UISubViewList[page] != null && self.UISubViewList[page].GameObject != null)
            {
                self.UISubViewList[page].GameObject.SetActive(true);
                self.UISubViewList[page].OnUpdateUI?.Invoke();
            }
            self.LastIndex = page;

            //播放音效
            UIHelper.PlayUIMusic("10007");
            return self.UISubViewList[page];
        }

    }
}
