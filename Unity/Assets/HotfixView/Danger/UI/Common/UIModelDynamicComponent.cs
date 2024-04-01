using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
    public class UIModelDynamicComponent : Entity, IAwake, IAwake<GameObject>, IDestroy
    {
        public List<GameObject> Model = null;
        public Transform ModelParent;
        public Camera Camera;
        public GameObject GameObject;

        public Vector2 StartPosition;
        public Action ClickHandler;
        public bool draged = false;

        public bool OnInit = false;
    }


    public class UIModelDynamicComponentAwake : AwakeSystem<UIModelDynamicComponent, GameObject>
    {
        public override void Awake(UIModelDynamicComponent self, GameObject gameObject)
        {
            self.OnInit = false;
            self.draged = false;
            self.Model = new List<GameObject>();
            self.ClickHandler = null;
            self.GameObject = gameObject;   
            self.ModelParent = gameObject.transform.Find("Model");
            self.Camera = gameObject.transform.Find("Camera").GetComponent<Camera>();
        }
    }


    public class UIModelDynamicComponentDestroy : DestroySystem<UIModelDynamicComponent>
    {
        public override void Destroy(UIModelDynamicComponent self)
        {
            if (self.Model != null)
            {
                for (int i = 0; i < self.Model.Count; i++)
                {
                    GameObject.Destroy(self.Model[i]);
                }
            }
            self.Model = null;
        }
    }

    public static class UIModelDynamicComponentSystem
    {
        public static void OnInitUI(this UIModelDynamicComponent self, GameObject parentImage, RenderTexture rc)
        {
            UICommonHelper.SetParent(self.GameObject, parentImage);
            ButtonHelp.RemoveEventTriggers(  parentImage );
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

        public static void RemoveModel(this UIModelDynamicComponent self)
        {
            if (self.Model != null)
            {
                for (int i = 0; i < self.Model.Count; i++)
                {
                    GameObject.Destroy(self.Model[i]);
                }
            }
            self.Model.Clear();
        }

        public static async ETTask ShowModel(this UIModelDynamicComponent self, string assetPath)
        {
            self.RemoveModel();
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUnitPath(assetPath);
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            LayerHelp.ChangeLayerAll(go.transform, LayerEnum.RenderTexture);
            go.transform.SetParent(self.ModelParent);
            go.transform.localScale = Vector3.one;
            go.transform.localPosition = Vector3.zero;
            go.transform.localEulerAngles = Vector3.zero;
            self.Model.Add(go);
        }

        public static async ETTask ShowModelList(this UIModelDynamicComponent self, string initpath, List<string> assetPath)
        {
            self.RemoveModel();
            long instanceId = self.InstanceId;

            for (int i = 0; i < assetPath.Count; i++)
            {
                var path = ABPathHelper.GetUnitPath(initpath +  assetPath[i]);
                GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
                if (instanceId != self.InstanceId)
                {
                    return;
                }
                GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
                LayerHelp.ChangeLayerAll(go.transform, LayerEnum.RenderTexture);
                go.transform.SetParent(self.ModelParent);
                go.transform.localScale = Vector3.one;
                go.transform.localPosition = Vector3.zero;
                go.transform.localEulerAngles = Vector3.zero;

                self.Model.Add(go);
            }
        }

        public static void PlayAnimate(this UIModelDynamicComponent self, string animate)
        {
            if (self.Model.Count == 0)
            {
                return;
            }

            Animator animator = self.Model[0].GetComponentInChildren<Animator>();
            if (animator != null)
            {
                animator.Play(animate);
            }
        }
    }

}
