using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

namespace ET
{
    public class UIPetFormationSetComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject GameObject;
        public GameObject IconItemDrag;

        public Action<long, int, int> DragEndHandler = null;

        public UIPetFormationItemComponent[] FormationItemComponents = new UIPetFormationItemComponent[9];
        
        public List<string> AssetPath = new List<string>();
    }

    public class UIPetFormationSetComponentAwakeSystem : AwakeSystem<UIPetFormationSetComponent, GameObject>
    {
        public override void Awake(UIPetFormationSetComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            self.IconItemDrag = gameObject.transform.Find("IconItemDrag").gameObject;
            self.IconItemDrag.SetActive(false);

            for (int i = 0; i < self.FormationItemComponents.Length; i++)
            {
                self.FormationItemComponents[i] = null;
            }
        }
    }
    public class UIPetFormationSetComponentDestroy : DestroySystem<UIPetFormationSetComponent>
    {
        public override void Destroy(UIPetFormationSetComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UIPetFormationSetComponentSystem
    {

        public static void  OnUpdateFormation(this UIPetFormationSetComponent self, int sceneType, List<long> teamPets, bool drag = false)
        {
            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            
            Transform transform = self.GameObject.transform.Find("FormationNode");
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            for (int i = 0; i < teamPets.Count; i++)
            {
                UIPetFormationItemComponent uIRolePetItemComponent = self.FormationItemComponents[i];
                if (teamPets[i] == 0)
                {
                    if (uIRolePetItemComponent != null)
                    {
                        uIRolePetItemComponent.GameObject.SetActive(false);
                    }
                    continue;
                }
                if (uIRolePetItemComponent == null)
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, transform.Find("FormationSet" + i).gameObject);
                    uIRolePetItemComponent = self.AddChild<UIPetFormationItemComponent, GameObject>(go);
                    self.FormationItemComponents[i] = uIRolePetItemComponent;
                }
                uIRolePetItemComponent.GameObject.SetActive(true);
                RolePetInfo rolePetInfo = petComponent.GetPetInfoByID(teamPets[i]);
                uIRolePetItemComponent.OnInitUI(rolePetInfo);
                uIRolePetItemComponent.SetDragEnable(drag);
                uIRolePetItemComponent.BeginDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.BeginDrag(binfo, pdata); };
                uIRolePetItemComponent.DragingHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.Draging(binfo, pdata); };
                uIRolePetItemComponent.EndDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.EndDrag(binfo, pdata); };
            }
        }

        public static void BeginDrag(this UIPetFormationSetComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            self.IconItemDrag.SetActive(true);
            PetConfig petConfig = PetConfigCategory.Instance.Get(binfo.ConfigId);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            GameObject icon = self.IconItemDrag.transform.Find("ImageIcon").gameObject;
            icon.GetComponent<Image>().sprite = sp;
            UICommonHelper.SetParent(self.IconItemDrag, UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject);
        }

        public static void Draging(this UIPetFormationSetComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            Vector2 localPoint;
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);

            self.IconItemDrag.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
        }

        public static void EndDrag(this UIPetFormationSetComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (name.Contains("UIPetFormationAA"))
                {
                    self.DragEndHandler(binfo.Id, -1, 3);
                    break;
                }
                if (name.Contains("FormationSet"))
                {
                    int index = int.Parse(name.Substring(name.Length - 1, 1));
                    self.DragEndHandler(binfo.Id, index, 2);
                    break;
                }
            }
            UICommonHelper.SetParent(self.IconItemDrag, self.GameObject);
            self.IconItemDrag.SetActive(false);
        }
    }
}
