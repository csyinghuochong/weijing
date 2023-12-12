using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionKeJiLearnItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject NameText;
        public GameObject LvText;
        public GameObject HighlightImg;
        public GameObject ClickBtn;

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

            self.ClickBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn(); });
        }
    }

    public static class UIUnionKeJiLearnItemComponentSystem
    {
        public static void UpdateInfo(this UIUnionKeJiLearnItemComponent self, int position, int configId)
        {
            self.Position = position;

            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(configId);
            Match match = Regex.Match(unionKeJiConfig.EquipSpaceName, @"\d");
            self.NameText.GetComponent<Text>().text = unionKeJiConfig.EquipSpaceName.Substring(0,match.Index);
            self.LvText.GetComponent<Text>().text =
                    $"等级：{unionKeJiConfig.QiangHuaLv.ToString()}/{UnionKeJiConfigCategory.Instance.UnionQiangHuaList[position].Count}";
        }

        public static void OnClickBtn(this UIUnionKeJiLearnItemComponent self)
        {
            self.ClickAction?.Invoke(self.Position);
        }
    }
}