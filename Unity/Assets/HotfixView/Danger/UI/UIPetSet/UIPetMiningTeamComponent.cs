using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningTeamComponent : Entity, IAwake
    {
        public GameObject PetListNode;
        public GameObject ButtonClose;

        public GameObject IconItemDrag;
        public List<UIPetFormationItemComponent> uIPetFormations = new List<UIPetFormationItemComponent>();

        public List<long> PetMingList = new List<long>();        
    }

    public class UIPetMiningTeamComponentAwake : AwakeSystem<UIPetMiningTeamComponent>
    {
        public override void Awake(UIPetMiningTeamComponent self)
        {
            self.uIPetFormations.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetMiningTeam ); });
        
            self.PetListNode = rc.Get<GameObject>("PetListNode");

            self.IconItemDrag = rc.Get<GameObject>("IconItemDrag");
            self.IconItemDrag.SetActive(false);

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            self.PetMingList.Clear();
            self.PetMingList.AddRange( petComponent.PetMingList );

            self.OnUpdatePetList().Coroutine();
        }
    }

    public static class UIPetMiningTeamComponentSystem
    {

        public static void BeginDrag(this UIPetMiningTeamComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            self.IconItemDrag.SetActive(true);
            PetConfig petConfig = PetConfigCategory.Instance.Get(binfo.ConfigId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            GameObject icon = self.IconItemDrag.transform.Find("ImageIcon").gameObject;
            icon.GetComponent<Image>().sprite = sp;
            UICommonHelper.SetParent(self.IconItemDrag, UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject);
        }

        public static void Draging(this UIPetMiningTeamComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            Vector2 localPoint;
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);

            self.IconItemDrag.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
        }

        public static void EndDrag(this UIPetMiningTeamComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (!name.Contains("PetIcon_di_"))
                {
                    continue;
                }
                Transform parent = results[i].gameObject.transform.parent;
                int index = int.Parse(name.Substring(name.Length - 1, 1));

                Log.ILog.Debug($"index:   {index} {parent.name} ");
                //self.OnDragFormationSet(binfo.Id, index, 1);
                break;
            }
            UICommonHelper.SetParent(self.IconItemDrag, self.GetParent<UI>().GameObject);
            self.IconItemDrag.SetActive(false);
        }

        public static async ETTask OnUpdatePetList(this UIPetMiningTeamComponent self)
        {
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            List<RolePetInfo> rolePetInfos = petComponent.RolePetInfos;

            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                UIPetFormationItemComponent uIRolePetItemComponent = null;
                if (i < self.uIPetFormations.Count)
                {
                    uIRolePetItemComponent = self.uIPetFormations[i];
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.PetListNode);
                    uIRolePetItemComponent = self.AddChild<UIPetFormationItemComponent, GameObject>(go);
                    uIRolePetItemComponent.BeginDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.BeginDrag(binfo, pdata); };
                    uIRolePetItemComponent.DragingHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.Draging(binfo, pdata); };
                    uIRolePetItemComponent.EndDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.EndDrag(binfo, pdata); };
                    self.uIPetFormations.Add(uIRolePetItemComponent);
                }
                uIRolePetItemComponent.OnInitUI(rolePetInfos[i], self.PetMingList.Contains(rolePetInfos[i].Id));
            }
        }


    }
}