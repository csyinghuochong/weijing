using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPetFormationComponent : Entity, IAwake
    {
        public GameObject CloseButton;
        public GameObject ButtonChallenge;
        public GameObject TextNumber;
        public GameObject FormationNode;
        public GameObject ButtonConfirm;
        public GameObject PetListNode;

        public GameObject IconItemDrag;
        public UIPetFormationSetComponent UIPetFormationSet;
        public List<UIPetFormationItemComponent> uIPetFormations = new List<UIPetFormationItemComponent>();
    }

    [ObjectSystem]
    public class UIPetFormationComponentAwakeSystem : AwakeSystem<UIPetFormationComponent>
    {
        public override void Awake(UIPetFormationComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.uIPetFormations.Clear();
            self.ButtonChallenge = rc.Get<GameObject>("ButtonChallenge");
            self.TextNumber = rc.Get<GameObject>("TextNumber");
            self.FormationNode = rc.Get<GameObject>("FormationNode");
            self.ButtonConfirm = rc.Get<GameObject>("ButtonConfirm");
            self.PetListNode = rc.Get<GameObject>("PetListNode");
            self.IconItemDrag = rc.Get<GameObject>("IconItemDrag");
            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.IconItemDrag.SetActive(false);

            ButtonHelp.AddListenerEx( self.ButtonConfirm, () => {   } );
            ButtonHelp.AddListenerEx(self.ButtonChallenge, () => { self.OnButtonChallenge(); });
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPetFormation); });

            self.InitSubView();
            self.OnInitPetList().Coroutine();
        }
    }

    public static class UIPetFormationComponentSystem
    {
        public static void OnUpdateNumber(this UIPetFormationComponent self)
        {
            int number = 0;
            PetComponent petComponent  = self.ZoneScene().GetComponent<PetComponent>();
            for (int i = 0; i < petComponent.PetFormations.Count; i++)
            {
                number += (petComponent.PetFormations[i] != 0 ? 1 : 0);
            }
            self.TextNumber.GetComponent<Text>().text = $"阵容限制：{number}/5";
        }

        public static void UpdateFighting(this UIPetFormationComponent self)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            for (int i = 0; i < self.uIPetFormations.Count; i++)
            {
                long petId = self.uIPetFormations[i].RolePetInfo.Id;
                self.uIPetFormations[i].SetFighting(petComponent.PetFormations.Contains(petId));
            }
        }

        public static void OnButtonChallenge(this UIPetFormationComponent self)
        {
            Scene scene = self.ZoneScene();
            UIHelper.Remove(scene, UIType.UIPetFormation);
            UIHelper.Create(scene, UIType.UIPetChallenge).Coroutine();
        }

        public static  void InitSubView(this UIPetFormationComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationSet");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = GameObject.Instantiate(bundleGameObject);
            self.UIPetFormationSet = self.AddChild<UIPetFormationSetComponent, GameObject>(go);
            self.UIPetFormationSet.OnUpdateFormation(true).Coroutine();
            UICommonHelper.SetParent(go, self.FormationNode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="rolePetInfoId"></param>
        /// <param name="index">下阵</param>
        /// <returns></returns>
        public static async ETTask RequestFormationSet(this UIPetFormationComponent self, long rolePetInfoId, int index, int operaType)
        {
            int number = 0;
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            for (int i = 0; i < petComponent.PetFormations.Count; i++)
            {
                number += (petComponent.PetFormations[i] != 0 ? 1 : 0);
            }
            if (index != -1 && number >= 5 && petComponent.PetFormations[index] == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已达到上阵最大数量！");
                return;
            }

            C2M_RolePetFormationSet c2M_RolePetFormationSet = new C2M_RolePetFormationSet()
            {
                Index = index,
                PetId = rolePetInfoId,
                OperateType = operaType
            };
            M2C_RolePetFormationSet m2C_RolePetFormationSet = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetFormationSet) as M2C_RolePetFormationSet;
            if (m2C_RolePetFormationSet.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            petComponent.OnFormationSet(rolePetInfoId, index, operaType);
            self.UIPetFormationSet.OnUpdateFormation(true).Coroutine();
            self.OnUpdateNumber();
            self.UpdateFighting();
        }

        public static async ETTask OnInitPetList(this UIPetFormationComponent self)
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
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.PetListNode);
                UIPetFormationItemComponent uIRolePetItemComponent = self.AddChild<UIPetFormationItemComponent, GameObject>(go);
                uIRolePetItemComponent.OnInitUI(rolePetInfos[i], petComponent.PetFormations.Contains(rolePetInfos[i].Id));
                uIRolePetItemComponent.BeginDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.BeginDrag(binfo, pdata); };
                uIRolePetItemComponent.DragingHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.Draging(binfo, pdata); };
                uIRolePetItemComponent.EndDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.EndDrag(binfo, pdata); };
                self.uIPetFormations.Add(uIRolePetItemComponent);
            }
            self.OnUpdateNumber();
        }

        public static void BeginDrag(this UIPetFormationComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            self.IconItemDrag.SetActive(true);
            PetConfig petConfig = PetConfigCategory.Instance.Get(binfo.ConfigId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            GameObject icon = self.IconItemDrag.transform.Find("ImageIcon").gameObject;
            icon.GetComponent<Image>().sprite = sp;
            UICommonHelper.SetParent(self.IconItemDrag, UIEventComponent.Instance.UILayers[(int)UILayer.Low].gameObject);
        }

        public static void Draging(this UIPetFormationComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            Vector2 localPoint;
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);

            self.IconItemDrag.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
        }

        public static void EndDrag(this UIPetFormationComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (!name.Contains("FormationSet"))
                {
                    continue;
                }
                int index = int.Parse(name.Substring(name.Length - 1, 1));
                self.RequestFormationSet(binfo.Id, index, 1).Coroutine();
                break;
            }
            UICommonHelper.SetParent(self.IconItemDrag, self.GetParent<UI>().GameObject);
            self.IconItemDrag.SetActive(false);
        }
    }
}
