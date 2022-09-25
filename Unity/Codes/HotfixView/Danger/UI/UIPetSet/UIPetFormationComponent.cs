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
        public List<long> PetTeamList = new List<long>() { };
        public int SceneTypeEnum;
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
            self.PetTeamList.Clear();

            ButtonHelp.AddListenerEx( self.ButtonConfirm, () => { self.OnButtonConfirm().Coroutine(); } );
            ButtonHelp.AddListenerEx(self.ButtonChallenge, () => { self.OnButtonChallenge(); });
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPetFormation); });
        }
    }

    public static class UIPetFormationComponentSystem
    {

        public static void OnUpdateNumber(this UIPetFormationComponent self,int sceneType)
        {
            int number = 0;
            List<long> pets = self.PetTeamList;
            for (int i = 0; i < pets.Count; i++)
            {
                number += (pets[i] != 0 ? 1 : 0);
            }
            self.TextNumber.GetComponent<Text>().text = $"阵容限制：{number}/5";
        }

        public static void UpdateFighting(this UIPetFormationComponent self, int sceneType)
        {
            List<long> pets = self.PetTeamList;
            for (int i = 0; i < self.uIPetFormations.Count; i++)
            {
                long petId = self.uIPetFormations[i].RolePetInfo.Id;
                self.uIPetFormations[i].SetFighting(pets.Contains(petId));
            }
        }

        public static async ETTask OnButtonConfirm(this UIPetFormationComponent self)
        {
            C2M_RolePetFormationSet c2M_RolePetFormationSet = new C2M_RolePetFormationSet()
            {
                SceneType = self.SceneTypeEnum,
                PetFormat = self.PetTeamList
            };
            M2C_RolePetFormationSet m2C_RolePetFormationSet = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetFormationSet) as M2C_RolePetFormationSet;
            if (m2C_RolePetFormationSet.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            if (self.SceneTypeEnum == SceneTypeEnum.PetDungeon)
            {
                petComponent.PetFormations = self.PetTeamList;
            }
            if (self.SceneTypeEnum == SceneTypeEnum.PetDungeon)
            {
                petComponent.TeamPetList = self.PetTeamList;
            }

            self.OnUpdateNumber(self.SceneTypeEnum);
            self.UpdateFighting(self.SceneTypeEnum);
        }

        public static void OnButtonChallenge(this UIPetFormationComponent self)
        {
            Scene scene = self.ZoneScene();
            UIHelper.Remove(scene, UIType.UIPetFormation);
            if (self.SceneTypeEnum == SceneTypeEnum.PetDungeon)
            {
                UIHelper.Create(scene, UIType.UIPetChallenge).Coroutine();
                return;
            }
            if (self.SceneTypeEnum == SceneTypeEnum.PetTianTi)
            {
                return;
            }
        }

        public static  void OnInitUI(this UIPetFormationComponent self, int sceneType)
        {
            self.SceneTypeEnum = sceneType;
            self.PetTeamList.AddRange(self.ZoneScene().GetComponent<PetComponent>().GetPetFormatList(sceneType));
            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationSet");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = GameObject.Instantiate(bundleGameObject);
            self.UIPetFormationSet = self.AddChild<UIPetFormationSetComponent, GameObject>(go);
            self.UIPetFormationSet.OnUpdateFormation(self.SceneTypeEnum, self.PetTeamList, true).Coroutine();
            UICommonHelper.SetParent(go, self.FormationNode);

            self.OnUpdateNumber(sceneType);
            self.UpdateFighting(sceneType);
            self.OnInitPetList(sceneType).Coroutine();
        }

        public static void OnDragFormationSet(this UIPetFormationComponent self, long rolePetInfoId, int index, int operateType)
        {
            int number = 0;
            for (int i = 0; i < self.PetTeamList.Count; i++)
            {
                number += (self.PetTeamList[i] != 0 ? 1 : 0);
            }
            if (index != -1 && number >= 5 && self.PetTeamList[index] == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已达到上阵最大数量！");
                return;
            }

            //index == -1 下阵
            if (operateType == 1)
            {
                for (int i = 0; i < self.PetTeamList.Count; i++)
                {
                    if (self.PetTeamList[i] == rolePetInfoId && i != index)
                    {
                        self.PetTeamList[i] = 0;
                    }
                }
                self.PetTeamList[index] = rolePetInfoId;
            }
            if (operateType == 2)
            {
                int oldIndex = -1;
                for (int i = 0; i < self.PetTeamList.Count; i++)
                {
                    if (self.PetTeamList[i] == rolePetInfoId)
                    {
                        oldIndex = i;
                    }
                }
                self.PetTeamList[oldIndex] = self.PetTeamList[index];
                self.PetTeamList[index] = rolePetInfoId;
            }
            if (operateType == 3)
            {
                for (int i = 0; i < self.PetTeamList.Count; i++)
                {
                    if (self.PetTeamList[i] == rolePetInfoId)
                    {
                        self.PetTeamList[i] = 0;
                    }
                }
            }
            self.UIPetFormationSet.OnUpdateFormation(self.SceneTypeEnum, self.PetTeamList, true).Coroutine();

            self.OnUpdateNumber(self.SceneTypeEnum);
            self.UpdateFighting(self.SceneTypeEnum);
            self.OnInitPetList(self.SceneTypeEnum).Coroutine();
        }

        public static async ETTask OnInitPetList(this UIPetFormationComponent self, int sceneType)
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
            List<long> pets = self.PetTeamList;
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
                uIRolePetItemComponent.OnInitUI(rolePetInfos[i], pets.Contains(rolePetInfos[i].Id));
            }
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
                self.OnDragFormationSet(binfo.Id, index, 1);
                break;
            }
            UICommonHelper.SetParent(self.IconItemDrag, self.GetParent<UI>().GameObject);
            self.IconItemDrag.SetActive(false);
        }
    }
}
