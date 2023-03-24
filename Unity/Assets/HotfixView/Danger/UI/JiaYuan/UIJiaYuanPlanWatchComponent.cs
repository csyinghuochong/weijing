using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPlanWatchComponent : Entity, IAwake, IDestroy
    {
        public GameObject BtnClose;

        public GameObject Text_Desc_3;
        public GameObject Text_Desc_2;
        public GameObject Text_Desc_1;

        public GameObject TextStage;
        public GameObject TextName;

        public GameObject RawImage;
        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;

        public UIItemComponent UIGetItem;
    }

    [ObjectSystem]
    public class UIJiaYuanPlanWatchComponentAwake : AwakeSystem<UIJiaYuanPlanWatchComponent>
    {
        public override void Awake(UIJiaYuanPlanWatchComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BtnClose = rc.Get<GameObject>("BtnClose");
            self.BtnClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIJiaYuanPlanWatch ); });

            self.Text_Desc_3 = rc.Get<GameObject>("Text_Desc_3");
            self.Text_Desc_2 = rc.Get<GameObject>("Text_Desc_2");
            self.Text_Desc_1 = rc.Get<GameObject>("Text_Desc_1");

            self.TextStage = rc.Get<GameObject>("TextStage");
            self.TextName = rc.Get<GameObject>("TextName");

            self.RawImage = rc.Get<GameObject>("RawImage");

            GameObject uIGetItem = rc.Get<GameObject>("UIGetItem");
            self.UIGetItem = self.AddChild<UIItemComponent, GameObject>(uIGetItem);

            self.OnInitUI();
        }
    }

    [ObjectSystem]
    public class UIJiaYuanPlanWatchComponentDestroy : DestroySystem<UIJiaYuanPlanWatchComponent>
    {
        public override void Destroy(UIJiaYuanPlanWatchComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
            //RenderTexture.ReleaseTemporary(self.RenderTexture);
        }
    }

    public static class UIJiaYuanPlanWatchComponentSystem
    {
        public static void OnInitUI(this UIJiaYuanPlanWatchComponent self)
        {
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            JiaYuanPlant jiaYuanPlant = jiaYuanComponent.GetCellPlant(jiaYuanComponent.CellIndex);

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlant.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            int stage = JiaYuanHelper.GetPlanStage(jiaYuanPlant);
           
            self.RenderTexture = null;
            self.RenderTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture.Create();
            self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
            self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
            self.UIModelShowComponent.ShowModel($"JiaYuan/{jiaYuanFarmConfig.ModelID + stage}").Coroutine();
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, -5f, 148f);
            gameObject.transform.localPosition = new Vector2(1000, 0);
            gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);

            self.TextName.GetComponent<Text>().text = jiaYuanFarmConfig.Name;
            self.TextStage.GetComponent<Text>().text = JiaYuanHelper.GetPlanStageName(stage);

            self.Text_Desc_1.GetComponent<Text>().text = $"当前阶段: {JiaYuanHelper.GetPlanStageName(stage)}";

            long nextTime = JiaYuanHelper.GetNextStateTime(jiaYuanPlant);
            self.Text_Desc_2.GetComponent<Text>().text = $"下一阶段: { TimeInfo.Instance.ToDateTime(nextTime)}";

            long shouhuoTime =  JiaYuanHelper.GetNextShouHuoTime(jiaYuanPlant);
            self.Text_Desc_3.GetComponent<Text>().text = $"预计收获: { TimeInfo.Instance.ToDateTime(shouhuoTime)}";
        }
    }
}
