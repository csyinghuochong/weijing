using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UILingDiComponent : Entity, IAwake
    {

        public GameObject NextNode;
        public GameObject TextChanXu22;
        public GameObject TextChanXu21;
        public GameObject TextChanXu12;
        public GameObject TextChanXu11;
        public GameObject TextLevelNext;
        public GameObject TextLevel;
        public GameObject Btn_CoinUp;
        public GameObject TextExpProgress;
        public GameObject Image_6;
        public GameObject TextCost;
    }

    [ObjectSystem]
    public class UILingDiComponentAwakeSystem : AwakeSystem<UILingDiComponent>
    {
        public override void Awake(UILingDiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_CoinUp = rc.Get<GameObject>("Btn_CoinUp");
            ButtonHelp.AddListenerEx(self.Btn_CoinUp, () => { self.OnButton_Up().Coroutine(); });

            self.TextExpProgress = rc.Get<GameObject>("TextExpProgress");
            self.Image_6 = rc.Get<GameObject>("Image_6");
            self.TextCost = rc.Get<GameObject>("TextCost");
            self.TextLevel = rc.Get<GameObject>("TextLevel");

            self.TextChanXu22 = rc.Get<GameObject>("TextChanXu22");
            self.TextChanXu21 = rc.Get<GameObject>("TextChanXu21");
            self.TextChanXu12 = rc.Get<GameObject>("TextChanXu12");
            self.TextChanXu11 = rc.Get<GameObject>("TextChanXu11");
            self.NextNode = rc.Get<GameObject>("NextNode");

            self.OnUpdateExp();
        }
    }

    public static class UILingDiComponentSystem
    {
        public static async ETTask OnButton_Up(this UILingDiComponent self)
        {
            C2M_LingDiUpRequest c2M_LingDiUpRequest = new C2M_LingDiUpRequest();
            M2C_LingDiUpResponse m2C_LingDiUpResponse = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_LingDiUpRequest) as M2C_LingDiUpResponse;

            self.OnUpdateExp();
        }

        public static void OnUpdateExp(this UILingDiComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int lingdiLv = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Ling_DiLv);
            int lingdiExp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Ling_DiExp);

            LingDiConfig lingDiConfig = LingDiConfigCategory.Instance.Get(lingdiLv);

            self.TextExpProgress.GetComponent<Text>().text = $"繁荣度: {lingdiExp}/{lingDiConfig.UpExp}";
            float progress = Mathf.Min(1f, 1f * lingdiExp / lingDiConfig.UpExp);
            self.Image_6.transform.localScale = new Vector3(progress, 1f, 1f);

            self.TextLevel.GetComponent<Text>().text = $"领地等级:{lingdiLv}";
            self.TextCost.GetComponent<Text>().text = $"消耗: {lingDiConfig.GoldUp}金币";

            self.TextChanXu11.GetComponent<Text>().text = $"经验产出: {lingDiConfig.HoureExp}/小时";
            self.TextChanXu12.GetComponent<Text>().text = $"荣誉产出: {lingDiConfig.HoureHonor}/小时";

            if (!LingDiConfigCategory.Instance.Contain(lingdiLv+1))
            {
                self.NextNode.SetActive(false);
                return;
            }
            self.NextNode.SetActive(true);
            LingDiConfig lingDiConfigNext = LingDiConfigCategory.Instance.Get(lingdiLv+1);
            self.TextChanXu21.GetComponent<Text>().text = $"经验产出: {lingDiConfigNext.HoureExp}/小时";
            self.TextChanXu22.GetComponent<Text>().text = $"荣誉产出: {lingDiConfigNext.HoureHonor}/小时";

        }
    }
}