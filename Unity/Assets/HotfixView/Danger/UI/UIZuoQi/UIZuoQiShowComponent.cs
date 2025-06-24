using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{
    public class UIZuoQiShowComponent: Entity, IAwake, IDestroy
    {
        public GameObject Text_Tip;
        public GameObject ZuoQiListNode;
        public GameObject UIZuoQiShowItem;
    }


    public class UIZuoQiShowComponentAwake : AwakeSystem<UIZuoQiShowComponent>
    {
        public override void Awake(UIZuoQiShowComponent self)
        {
            ReferenceCollector rc   = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Text_Tip           = rc.Get<GameObject>("Text_Tip");
            self.ZuoQiListNode      = rc.Get<GameObject>("ZuoQiListNode");
            self.UIZuoQiShowItem = rc.Get<GameObject>("UIZuoQiShowItem");
            self.UIZuoQiShowItem.SetActive(false);

            self.OnInitUI();
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UIZuoQiShowComponentDestroySystem : DestroySystem<UIZuoQiShowComponent>
    {
        public override void Destroy(UIZuoQiShowComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UIZuoQiShowSystem
    {
        public static void OnLanguageUpdate(this UIZuoQiShowComponent self)
        {
            self.Text_Tip.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 30 : 26;
        }

        public static  void OnInitUI(this UIZuoQiShowComponent self)
        {
            List<ZuoQiShowConfig> zuoQiConfigs = new List<ZuoQiShowConfig>();
            zuoQiConfigs.AddRange(ZuoQiShowConfigCategory.Instance.GetAll().Values.ToList());
            zuoQiConfigs.Sort((a, b) => a.Quality - b.Quality);
            for (int i = 0; i < zuoQiConfigs.Count; i++)
            {
                GameObject zuoqiItem = GameObject.Instantiate(self.UIZuoQiShowItem);
                zuoqiItem.SetActive(true);
                UICommonHelper.SetParent(zuoqiItem, self.ZuoQiListNode);
                self.AddChild<UIZuoQiShowItemComponent, GameObject>(zuoqiItem).OnInitUI(zuoQiConfigs[i]);
            }
        }
    }
}
