using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningTeamItemComponent : Entity, IAwake<GameObject>
    {

        public int TeamId = 0;   //0 1 2
        public GameObject GameObject;

        public GameObject TextTip11;
        public GameObject TextTip12;

        public PetComponent PetComponent;

        public GameObject[] PetIcon_di_List = new GameObject[5];    
        public UIPetFormationItemComponent[] FormationItemComponents = new UIPetFormationItemComponent[5];

        public GameObject IconItemDrag;
    }

    public class UIPetMiningTeamItemComponentAwake : AwakeSystem<UIPetMiningTeamItemComponent, GameObject>
    {
        public override void Awake(UIPetMiningTeamItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;

            self.TextTip11 = gameObject.transform.Find("TextTip11").gameObject;
            self.TextTip12 = gameObject.transform.Find("TextTip12").gameObject;

            for (int i = 0; i < self.FormationItemComponents.Length; i++)
            {
                self.PetIcon_di_List[i] = gameObject.transform.Find($"PetIcon_di_{i}").gameObject;
                self.FormationItemComponents[i] = null;
            }

            self.PetComponent = self.ZoneScene().GetComponent<PetComponent>();
        }
    }

    public static class UIPetMiningTeamItemComponentSystem
    {
        public static void OnInitUI(this UIPetMiningTeamItemComponent self,  int position)
        { 
            self.TeamId = position;
            
            int playerLv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            int openLv = ConfigHelper.PetMiningTeamOpenLevel[position];
            if (playerLv < openLv)
            {
                self.TextTip11.GetComponent<Text>().text = $"{position + 1}队";
            }
            else
            {
                self.TextTip11.GetComponent<Text>().text = string.Empty;
            }
        }

        public static void UpdatePetTeam(this UIPetMiningTeamItemComponent self, List<long> petlist)
        {
            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < self.FormationItemComponents.Length; i++)
            {
                long petId = petlist[i + self.TeamId * 5];
                RolePetInfo rolePetInfo = self.PetComponent.GetPetInfoByID(petId);
              
                if (rolePetInfo != null && self.FormationItemComponents[i] == null)
                {
                    GameObject goItem = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(goItem, self.PetIcon_di_List[i]);
                    goItem.transform.localScale = Vector3.one * 0.6f;  
                    UIPetFormationItemComponent FormationItem = self.AddChild<UIPetFormationItemComponent, GameObject>(goItem);
                    self.FormationItemComponents[i] = FormationItem;
                    FormationItem.BeginDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.BeginDrag(binfo, pdata); };
                    FormationItem.DragingHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.Draging(binfo, pdata); };
                    FormationItem.EndDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.EndDrag(binfo, pdata); };
                    FormationItem.SetDragEnable(true);
                }
                if (rolePetInfo == null && self.FormationItemComponents[i] != null)
                {
                    self.FormationItemComponents[i].GameObject.SetActive(false);    
                }

                if (rolePetInfo != null)
                {
                    PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
                    Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                    self.FormationItemComponents[i].OnInitUI(rolePetInfo);
                    self.FormationItemComponents[i].GameObject.SetActive(true);
                }
            }

        }

        public static void BeginDrag(this UIPetMiningTeamItemComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            self.IconItemDrag.SetActive(true);
            PetConfig petConfig = PetConfigCategory.Instance.Get(binfo.ConfigId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            GameObject icon = self.IconItemDrag.transform.Find("ImageIcon").gameObject;
            icon.GetComponent<Image>().sprite = sp;
            UICommonHelper.SetParent(self.IconItemDrag, UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject);
        }

        public static void Draging(this UIPetMiningTeamItemComponent self, RolePetInfo binfo, PointerEventData pdata)
        {
            Vector2 localPoint;
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);

            self.IconItemDrag.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
        }

        public static void RequestFormationSet(this UIPetMiningTeamItemComponent self, long rolePetInfoId, int index, int operateType)
        {
            UI ui = UIHelper.GetUI(self.ZoneScene(), UIType.UIPetMiningTeam);
            ui.GetComponent<UIPetMiningTeamComponent>().OnDragFormationSet(rolePetInfoId, index, operateType);
        }

        public static void EndDrag(this UIPetMiningTeamItemComponent self, RolePetInfo binfo, PointerEventData pdata)
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
                    break;
                }
            }
            UICommonHelper.SetParent(self.IconItemDrag, self.GameObject);
            self.IconItemDrag.SetActive(false);
        }
    }

}