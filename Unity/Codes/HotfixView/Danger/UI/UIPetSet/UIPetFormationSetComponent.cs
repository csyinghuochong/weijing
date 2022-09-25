using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPetFormationSetComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject IconItemDrag;
        public UIPetFormationItemComponent[] FormationItemComponents = new UIPetFormationItemComponent[9];
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

    public static class UIPetFormationSetComponentSystem
    {

        public static async ETTask OnUpdateFormation(this UIPetFormationSetComponent self, int sceneType, List<long> teamPets, bool drag = false)
        {
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }

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
                    UICommonHelper.SetParent(go, transform.GetChild(i).gameObject);
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
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
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

        public static void RequestFormationSet(this UIPetFormationSetComponent self, long rolePetInfoId, int index, int operateType)
        {
            UI ui = UIHelper.GetUI( self.ZoneScene(), UIType.UIPetFormation);
            ui.GetComponent<UIPetFormationComponent>().OnDragFormationSet(rolePetInfoId, index, operateType);
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
                    self.RequestFormationSet(binfo.Id, -1, 3);
                    Log.ILog.Debug(name);
                    break;
                }
                if (name.Contains("FormationSet"))
                {
                    int index = int.Parse(name.Substring(name.Length - 1, 1));
                    self.RequestFormationSet(binfo.Id, index, 2);
                    break;
                }
            }
            UICommonHelper.SetParent(self.IconItemDrag, self.GameObject);
            self.IconItemDrag.SetActive(false);
        }
    }
}
