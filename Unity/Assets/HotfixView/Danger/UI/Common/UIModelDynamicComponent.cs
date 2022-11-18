using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
    public class UIModelDynamicComponent : Entity, IAwake, IAwake<GameObject>, IDestroy
    {
        public GameObject Model;
        public Transform ModelParent;
        public Camera Camera;
        public GameObject GameObject;

        public Vector2 StartPosition;
        public Action ClickHandler;
        public bool draged = false;
    }

    [ObjectSystem]
    public class UIModelDynamicComponentAwake : AwakeSystem<UIModelDynamicComponent, GameObject>
    {
        public override void Awake(UIModelDynamicComponent self, GameObject gameObject)
        {
            self.draged = false;
            self.Model = null;
            self.ClickHandler = null;
            self.GameObject = gameObject;   
            self.ModelParent = gameObject.transform.Find("Model");
            self.Camera = gameObject.transform.Find("Camera").GetComponent<Camera>();
        }
    }

    [ObjectSystem]
    public class xx : DestroySystem<UIModelDynamicComponent>
    {
        public override void Destroy(UIModelDynamicComponent self)
        {
            if (self.Model != null)
            {
                GameObject.Destroy(self.Model);
                self.Model = null;
            }
        }
    }

    public static class UIModelDynamicComponentSystem
    {
        public static void OnInitUI(this UIModelDynamicComponent self, GameObject parentImage, RenderTexture rc)
        {
            UICommonHelper.SetParent(self.GameObject, parentImage);
            ButtonHelp.AddEventTriggers(parentImage, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(parentImage, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(parentImage, (PointerEventData pdata) => { self.PointerUp(pdata); }, EventTriggerType.PointerUp);
            self.Camera.targetTexture = rc;
        }

        public static void ReleaseRenderTexture(this UIModelDynamicComponent self)
        {
            self.Camera.targetTexture = null;
        }

        public static void Draging(this UIModelDynamicComponent self, PointerEventData eventData)
        {
            self.draged = true;
            float eulerY = self.ModelParent.transform.localEulerAngles.y;
            if (eventData.position.x > self.StartPosition.x)
                self.ModelParent.transform.localEulerAngles = new Vector3(0f, eulerY - 10, 0f);
            else
                self.ModelParent.transform.localEulerAngles = new Vector3(0f, eulerY + 10, 0f);

            self.StartPosition = eventData.position;
        }
        public static void PointerUp(this UIModelDynamicComponent self, PointerEventData eventData)
        {
            if (self.draged)
                return;
            self.ClickHandler?.Invoke();
        }

        public static void PointerDown(this UIModelDynamicComponent self, PointerEventData eventData)
        {
            self.draged = false;
            self.StartPosition = eventData.position;
        }

        public static async ETTask ShowModel(this UIModelDynamicComponent self, string assetPath)
        {
            if (self.Model != null)
            {
                GameObject.Destroy(self.Model);
                self.Model = null;
            }
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUnitPath(assetPath);
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            LayerHelp.ChangeLayer(go.transform, LayerEnum.RenderTexture);
            go.transform.SetParent(self.ModelParent);
            go.transform.localScale = Vector3.one;
            go.transform.localPosition = Vector3.zero;
            go.transform.localEulerAngles = Vector3.zero;
            self.Model = go;
        }

        public static void PlayAnimate(this UIModelDynamicComponent self, string animate)
        {
            Animator animator = self.Model.GetComponentInChildren<Animator>();
            if (animator != null)
            {
                animator.Play(animate);
            }
        }
    }

}
