using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIOccTwoItemComponent : Entity, IAwake
    {
        public GameObject cellContainer;
        public GameObject descContainer;
        public GameObject ButtonOcc;
        public GameObject TextName;
        public GameObject occDescItem;

        public int occTwoId;
    }

    [ObjectSystem]
    public class UIOccTwoItemComponentAwakeSystem : AwakeSystem<UIOccTwoItemComponent>
    {

        public override void Awake(UIOccTwoItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.cellContainer = rc.Get<GameObject>("cellContainer");
            self.descContainer = rc.Get<GameObject>("descContainer");
            self.TextName = rc.Get<GameObject>("TextName");
            self.occDescItem = rc.Get<GameObject>("occDescItem");
            self.occDescItem.SetActive(false);

            self.ButtonOcc = rc.Get<GameObject>("ButtonOcc");
            self.ButtonOcc.GetComponent<Button>().onClick.AddListener(() => { self.OnClickOccTwo(); });
        }
    }

    public static class UIOccTwoItemComponentSystem
    {
        public static void OnClickOccTwo(this UIOccTwoItemComponent self)
        {
            OccupationTwoConfig occupationTwoConfig = OccupationTwoConfigCategory.Instance.Get(self.occTwoId);
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "转职", $"是否转职为：{occupationTwoConfig.OccupationName}", () =>
            {
                self.RequestChangeOcc().Coroutine();
            }).Coroutine();
        }

        public static async ETTask RequestChangeOcc(this UIOccTwoItemComponent self)
        {
            bool ifChange = await self.ZoneScene().GetComponent<SkillSetComponent>().ChangeOccTwoRequest(self.occTwoId);
            if (ifChange)
            {
                UIHelper.Remove(self.DomainScene(), UIType.UIOccTwo).Coroutine();
            }
        }

        public static async ETTask SetOccTwoId(this UIOccTwoItemComponent self, int twoid)
        {
            self.occTwoId = twoid;

            OccupationTwoConfig occupationTwoConfig = OccupationTwoConfigCategory.Instance.Get(twoid);
            self.TextName.GetComponent<Text>().text = "转职:" + occupationTwoConfig.OccupationName;

            int[] skills = occupationTwoConfig.ShowTalentSkill;
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetSkillItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < skills.Length; i++)
            {
                GameObject skillItem = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(skillItem, self.cellContainer);
                skillItem.SetActive(true);
                skillItem.transform.localScale = Vector3.one * 0.8f;

                UICommonSkillItemComponent ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>( skillItem);
                ui_item.OnUpdateUI(skills[i]);
            }

            string[] OccDess = occupationTwoConfig.OccDes.Split(',');
            float totalHeight = 0;
            for (int i = 0; i < OccDess.Length; i++)
            {
                GameObject skillItem = GameObject.Instantiate(self.occDescItem);
                skillItem.SetActive(true);
                UICommonHelper.SetParent(skillItem, self.descContainer);
                skillItem.transform.localPosition = new Vector3(0f, (totalHeight + 10) * -1f, 0f);
                skillItem.transform.Find("TextDesc").GetComponent<Text>().text = OccDess[i];

                totalHeight += skillItem.transform.Find("TextDesc").GetComponent<Text>().preferredHeight + 20;
            }
        }
    }
}
