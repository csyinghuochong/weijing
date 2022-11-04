using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetChallengeItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageIcon;
        public GameObject ImageDi;
        public GameObject StartNode;

        public GameObject ImageSelect;
        public GameObject Start_2;
        public GameObject Start_1;
        public GameObject Start_0;

        public GameObject TextCombat;
        public GameObject TextLevel;
        public GameObject Node_1;
        public GameObject Node_2;
        public GameObject ImageLine_1;
        public GameObject ImageLine_2;

        public Action<int> ClickHandler;
        public int PetFubenId;
    }

    [ObjectSystem]
    public class UIPetChallengeItemComponentAwakeSystem : AwakeSystem<UIPetChallengeItemComponent, GameObject>
    {
        public override void Awake(UIPetChallengeItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ImageDi = rc.Get<GameObject>("ImageDi");
            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.StartNode = rc.Get<GameObject>("StartNode");

            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.ImageSelect.SetActive(false);
            self.Start_2 = rc.Get<GameObject>("Start_2");
            self.Start_1 = rc.Get<GameObject>("Start_1");
            self.Start_0 = rc.Get<GameObject>("Start_0");

            self.TextCombat = rc.Get<GameObject>("TextCombat");
            self.TextLevel = rc.Get<GameObject>("TextLevel");
            self.Node_1 = rc.Get<GameObject>("Node_1");
            self.Node_2 = rc.Get<GameObject>("Node_2");
            self.ImageLine_1 = rc.Get<GameObject>("ImageLine_1");
            self.ImageLine_2 = rc.Get<GameObject>("ImageLine_2");

            gameObject.GetComponent<Button>().onClick.AddListener(self.OnClickChallengeItem);
        }
    }

    public static class UIPetChallengeItemComponentSystem
    {
        public static void OnClickChallengeItem(this UIPetChallengeItemComponent self)
        {
            self.ClickHandler(self.PetFubenId );
        }

        public static void SetSelected(this UIPetChallengeItemComponent self, int petfubenId)
        { 
            self.ImageSelect.SetActive(self.PetFubenId == petfubenId);
        }

        public static void SetClickHandler(this UIPetChallengeItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void HideLines(this UIPetChallengeItemComponent self)
        {
            self.ImageLine_1.SetActive(false);
            self.ImageLine_2.SetActive(false);
        }

        public static void OnUpdateUI(this UIPetChallengeItemComponent self, PetFubenConfig petfubenConf, int index, int star, bool locked)
        {
            self.PetFubenId = petfubenConf.Id;
            self.Node_1.transform.localPosition = new Vector3( index % 2 == 0 ? -105f : -280f, 30f, 0f );
            self.ImageLine_1.SetActive(index % 2 == 0);
            self.ImageLine_2.SetActive(index % 2 != 0);
            self.TextLevel.GetComponent<Text>().text = petfubenConf.Name;
            //self.TextCombat.GetComponent<Text>().text = $"推荐战力： {petfubenConf.Combat}";
            self.TextCombat.GetComponent<Text>().text = $"建议最低队伍等级： {petfubenConf.Lv}级";
            self.Node_2.SetActive(locked);
            self.StartNode.SetActive(!locked);
            self.Start_2.SetActive(star >= 3);
            self.Start_1.SetActive(star >= 2);
            self.Start_0.SetActive(star >= 1);

            UICommonHelper.SetImageGray(self.ImageDi, locked);
            UICommonHelper.SetImageGray(self.ImageIcon, locked);
        }
    }
}
