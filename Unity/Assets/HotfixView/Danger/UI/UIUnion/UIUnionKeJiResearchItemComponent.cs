using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionKeJiResearchItemComponent: Entity, IAwake<GameObject>, IDestroy
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

    public class UIUnionKeJiResearchItemComponentAwakeSystem: AwakeSystem<UIUnionKeJiResearchItemComponent, GameObject>
    {
        public override void Awake(UIUnionKeJiResearchItemComponent self, GameObject gameObject)
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

    public class UIUnionKeJiResearchItemComponentDestroySystem: DestroySystem<UIUnionKeJiResearchItemComponent>
    {
        public override void Destroy(UIUnionKeJiResearchItemComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIUnionKeJiResearchItemComponentSystem
    {
        public static void OnLanguageUpdate(this UIUnionKeJiResearchItemComponent self)
        {
            self.NameText.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 30;
        }

        public static void UpdateInfo(this UIUnionKeJiResearchItemComponent self, int position, int configId)
        {
            self.Position = position;

            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(configId);
            self.NameText.GetComponent<Text>().text = unionKeJiConfig.GetEquipSpaceName();
            self.LvText.GetComponent<Text>().text = unionKeJiConfig.QiangHuaLv == 0? GameSettingLanguge.LoadLocalization("未研究") : string.Format(GameSettingLanguge.LoadLocalization("等级：{0}"), unionKeJiConfig.QiangHuaLv.ToString());

            UICommonHelper.SetImageGray(self.IconImg, unionKeJiConfig.QiangHuaLv == 0);
        }

        public static void OnClickBtn(this UIUnionKeJiResearchItemComponent self)
        {
            self.ClickAction?.Invoke(self.Position);
        }
    }
}