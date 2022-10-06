using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
    public class UIModelShowComponent : Entity, IAwake, IAwake<GameObject>
    {
        public GameObject UnitModel;
        public Transform ModelParent;
        public GameObject ParentImage;
        public Vector2 StartPosition;

        public bool draged = false;
        public Action ClickHandler;
    }

    [ObjectSystem]
    public class UIModelShowComponentAwakeSystem : AwakeSystem<UIModelShowComponent, GameObject>
    {
        public override void Awake(UIModelShowComponent self, GameObject parentImage)
        {
            self.draged = false;
            self.UnitModel = null;
            self.ClickHandler = null;
            self.ModelParent = self.GetParent<UI>().GameObject.transform.Find("Model");
            self.ParentImage = parentImage;
            self.AddComponent<ChangeEquipHelper>();

            ButtonHelp.AddEventTriggers(self.ParentImage, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.ParentImage, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.ParentImage, (PointerEventData pdata) => { self.PointerUp(pdata); }, EventTriggerType.PointerUp);
        }
    }

    public static class UIModelShowComponentSystem
    {
        public static void Draging(this UIModelShowComponent self, PointerEventData eventData)
        {
            self.draged = true;
            float eulerY = self.ModelParent.transform.localEulerAngles.y;
            if (eventData.position.x > self.StartPosition.x)
                self.ModelParent.transform.localEulerAngles = new Vector3(0f, eulerY - 10, 0f);
            else
                self.ModelParent.transform.localEulerAngles = new Vector3(0f, eulerY + 10, 0f);

            self.StartPosition = eventData.position;
        }
        public static void PointerUp(this UIModelShowComponent self, PointerEventData eventData)
        {
            if (self.draged)
                return;
            self.ClickHandler?.Invoke();
        }

        public static void PointerDown(this UIModelShowComponent self, PointerEventData eventData)
        {
            self.draged = false;
            self.StartPosition = eventData.position;
        }

        public static async ETTask ShowOtherModel(this UIModelShowComponent self, string assetPath, bool isPet =false)
        {
            if (self.UnitModel != null)
            {
                GameObject.Destroy(self.UnitModel);
                self.UnitModel = null;
            }
            var path = ABPathHelper.GetUnitPath(assetPath);
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            LayerHelp.ChangeLayer(go.transform, LayerEnum.RenderTexture);
            go.transform.SetParent(self.ModelParent);
            go.transform.localScale = Vector3.one;
            go.transform.localPosition = Vector3.zero;
            go.transform.localEulerAngles = Vector3.zero;
            self.UnitModel = go;

            if (isPet)
            {
                Animator animator = go.GetComponentInChildren<Animator>();
                animator.Play(RandomHelper.RandFloat01() >= 0.5 ? "Skill_1": "Skill_2") ;
            }
        }

        public static void PlayShowIdelAnimate(this UIModelShowComponent self)
        {
            if (self.UnitModel == null)
                return;
            Animator animator = self.UnitModel.GetComponentInChildren<Animator>();
            if (animator != null)
            {
                animator.Play("ShowIdel");
            }
        }

        public static void ChangeWeapon(this UIModelShowComponent self, BagInfo bagInfo, int occ)
        {
            int weaponId = 0;
            if (bagInfo != null && bagInfo.ItemID != 0)
            {
                weaponId = bagInfo.ItemID;
            }
            UICommonHelper.ShowWeapon(self.UnitModel, occ, weaponId);
            LayerHelp.ChangeLayer(self.UnitModel.transform, LayerEnum.RenderTexture);
        }

        public static async ETTask ShowPlayerModel(this UIModelShowComponent self, BagInfo bagInfo, int occ)
        {
            long instanceid = self.InstanceId;
            if (self.InstanceId != instanceid)
                return;
            if (self.UnitModel != null)
            {
                GameObject.Destroy(self.UnitModel);
                self.UnitModel = null;
            }

            var path = ABPathHelper.GetUnitPath($"Player/{OccupationConfigCategory.Instance.Get(occ).ModelAsset}");
            await ETTask.CompletedTask;
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            if (OccupationConfigCategory.Instance.Get(occ).ChangeEquip == 1)
            {
                self.GetComponent<ChangeEquipHelper>().LoadEquipment(go);
            }
            self.UnitModel = go;
            Animator animator = self.UnitModel.GetComponentInChildren<Animator>();
            if ( animator != null)
            {
                animator.Play("ShowIdel");
            }

            LayerHelp.ChangeLayer(go.transform, LayerEnum.RenderTexture);
            go.transform.SetParent( self.ModelParent );
            go.transform.localScale = Vector3.one;
            go.transform.localPosition = Vector3.zero;
            go.transform.localEulerAngles = Vector3.zero;

            self.ChangeWeapon(bagInfo, occ);
        }

    }

}