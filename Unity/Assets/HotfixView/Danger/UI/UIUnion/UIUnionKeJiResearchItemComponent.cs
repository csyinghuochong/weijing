using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionKeJiResearchItemComponent: Entity, IAwake<GameObject>
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
        }
    }

    public static class UIUnionKeJiResearchItemComponentSystem
    {
        public static void UpdateInfo(this UIUnionKeJiResearchItemComponent self, int position, int configId)
        {
            self.Position = position;

            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(configId);
            Match match = Regex.Match(unionKeJiConfig.EquipSpaceName, @"\d");
            self.NameText.GetComponent<Text>().text = unionKeJiConfig.EquipSpaceName.Substring(0, match.Index);
            self.LvText.GetComponent<Text>().text = unionKeJiConfig.QiangHuaLv == 0? "未研究" : $"等级：{unionKeJiConfig.QiangHuaLv.ToString()}";

            UICommonHelper.SetImageGray(self.IconImg, unionKeJiConfig.QiangHuaLv == 0);
        }

        public static void OnClickBtn(this UIUnionKeJiResearchItemComponent self)
        {
            self.ClickAction?.Invoke(self.Position);
        }
    }
}