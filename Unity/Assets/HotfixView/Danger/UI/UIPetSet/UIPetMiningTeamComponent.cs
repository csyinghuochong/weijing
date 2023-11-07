using System;
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
        public GameObject TeamListNode;

        public GameObject IconItemDrag;
        public List<UIPetFormationItemComponent> UIPetFormations = new List<UIPetFormationItemComponent>();
        public List<UIPetMiningTeamItemComponent> MiningTeamList = new List<UIPetMiningTeamItemComponent>();

        public List<long> PetTeamList = new List<long>();
        public List<long> PetMingPosition = new List<long>();

        public Action UpdateTeam;
    }

    public class UIPetMiningTeamComponentAwake : AwakeSystem<UIPetMiningTeamComponent>
    {
        public override void Awake(UIPetMiningTeamComponent self)
        {
            self.UIPetFormations.Clear();
            self.MiningTeamList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonClose().Coroutine();  });
        
            self.PetListNode = rc.Get<GameObject>("PetListNode");

            self.TeamListNode = rc.Get<GameObject>("TeamListNode");

            self.IconItemDrag = rc.Get<GameObject>("IconItemDrag");
            self.IconItemDrag.SetActive(false);

            for(int i = 0; i < 3; i++)
            {
                GameObject gameObject = self.TeamListNode.transform.GetChild(i).gameObject;
                UIPetMiningTeamItemComponent TeamItem = self.AddChild<UIPetMiningTeamItemComponent, GameObject>(gameObject);
                TeamItem.OnInitUI(i);
                TeamItem.IconItemDrag = self.IconItemDrag;
                self.MiningTeamList.Add(TeamItem);
            }

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            self.PetTeamList.Clear();
            self.PetTeamList.AddRange( petComponent.PetMingList );

            self.PetMingPosition.Clear();
            self.PetMingPosition.AddRange(petComponent.PetMingPosition);

            self.OnUpdatePetList();
            self.UpdateTeamList();
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
            int playerLv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
          
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
                int team = int.Parse(parent.name);
                int openLv = ConfigHelper.PetMiningTeamOpenLevel[team];
                if (playerLv < openLv)
                {
                    break;
                }

                int index = int.Parse(name.Substring(name.Length - 1, 1));
                Log.ILog.Debug($"index:   {index} {parent.name} ");
                self.OnDragFormationSet(binfo.Id, team * 5 + index, 1, team);
                break;
            }
            UICommonHelper.SetParent(self.IconItemDrag, self.GetParent<UI>().GameObject);
            self.IconItemDrag.SetActive(false);
        }

        /// <summary>
        /// 1 上阵  3 下阵
        /// </summary>
        /// <param name="self"></param>
        /// <param name="rolePetInfoId"></param>
        /// <param name="index"></param>
        /// <param name="operateType"></param>
        public static void OnDragFormationSet(this UIPetMiningTeamComponent self, long rolePetInfoId, int index, int operateType, int team)
        {

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIPetSet);
            UIPetMiningComponent petmingComponent = uI.GetComponent<UIPetSetComponent>().UIPageView.UISubViewList[(int)PetSetEnum.PetMining].GetComponent<UIPetMiningComponent>();
            List<int> defendteamids = petmingComponent.GetSelfPetMingTeam();
            if (defendteamids.Contains(team))
            {
                FloatTipManager.Instance.ShowFloatTip("占领矿场中，无法更换");
                return;
            }


            //上阵
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
            
            //下阵
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

            self.OnUpdatePetList();
            self.UpdateTeamList();

            PetHelper.CheckPetPosition( self.PetTeamList, self.PetMingPosition );
        }

        public static async ETTask OnButtonClose(this UIPetMiningTeamComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            long instanceid = self.InstanceId;
            int errorCode = await petComponent.RequestPetFormationSet(SceneTypeEnum.PetMing, self.PetTeamList, self.PetMingPosition) ;
            if (errorCode != ErrorCode.ERR_Success || instanceid != self.InstanceId)
            {
                return;
            }
            self.UpdateTeam?.Invoke();
            UIHelper.Remove(zoneScene, UIType.UIPetMiningTeam);
        }

        public static void UpdateTeamList(this UIPetMiningTeamComponent self)
        {
            self.MiningTeamList[0].UpdatePetTeam(self.PetTeamList);
            self.MiningTeamList[1].UpdatePetTeam(self.PetTeamList);
            self.MiningTeamList[2].UpdatePetTeam(self.PetTeamList);
        }

        public static void  OnUpdatePetList(this UIPetMiningTeamComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            List<RolePetInfo> rolePetInfos = petComponent.RolePetInfos;

            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                UIPetFormationItemComponent uIRolePetItemComponent = null;
                if (i < self.UIPetFormations.Count)
                {
                    uIRolePetItemComponent = self.UIPetFormations[i];
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.PetListNode);
                    uIRolePetItemComponent = self.AddChild<UIPetFormationItemComponent, GameObject>(go);
                    uIRolePetItemComponent.BeginDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.BeginDrag(binfo, pdata); };
                    uIRolePetItemComponent.DragingHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.Draging(binfo, pdata); };
                    uIRolePetItemComponent.EndDragHandler = (RolePetInfo binfo, PointerEventData pdata) => { self.EndDrag(binfo, pdata); };
                    self.UIPetFormations.Add(uIRolePetItemComponent);
                }
                uIRolePetItemComponent.OnInitUI(rolePetInfos[i], self.PetTeamList.Contains(rolePetInfos[i].Id));
            }
        }


    }
}