using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionKeJiLearnItemComponent: Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;
        public GameObject NameText;
        public GameObject LvText;
        public GameObject HighlightImg;
        public GameObject ClickBtn;
        public GameObject IconImg;

        public int Position;
        public Action<int> ClickAction;
    }

    public class UIUnionKeJiLearnItemComponentAwakeSystem: AwakeSystem<UIUnionKeJiLearnItemComponent, GameObject>
    {
        public override void Awake(UIUnionKeJiLearnItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.NameText = rc.Get<GameObject>("NameText");
            self.LvText = rc.Get<GameObject>("LvText");
            self.HighlightImg = rc.Get<GameObject>("HighlightImg");
            self.ClickBtn = rc.Get<GameObject>("ClickBtn");
            self.IconImg = rc.Get<GameObject>("IconImg");

            self.ClickBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn(); });
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UIUnionKeJiLearnItemComponentComponentDestroySystem: DestroySystem<UIUnionKeJiLearnItemComponent>
    {
        public override void Destroy(UIUnionKeJiLearnItemComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UIUnionKeJiLearnItemComponentSystem
    {
        public static void OnLanguageUpdate(this UIUnionKeJiLearnItemComponent self)
        {
            self.NameText.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 30;
        }
        
        public static void UpdateInfo(this UIUnionKeJiLearnItemComponent self, int position, int configId, int maxConfigId)
        {
            self.Position = position;

            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(configId);
            self.NameText.GetComponent<Text>().text = unionKeJiConfig.GetEquipSpaceName();
            self.LvText.GetComponent<Text>().text =
                    string.Format(GameSettingLanguge.LoadLocalization("等级：{0}/{1}"), unionKeJiConfig.QiangHuaLv.ToString(), UnionKeJiConfigCategory.Instance.Get(maxConfigId).QiangHuaLv);

            UICommonHelper.SetImageGray(self.IconImg, unionKeJiConfig.QiangHuaLv == 0);
        }

        public static void OnClickBtn(this UIUnionKeJiLearnItemComponent self)
        {
            self.ClickAction?.Invoke(self.Position);
        }
    }
}