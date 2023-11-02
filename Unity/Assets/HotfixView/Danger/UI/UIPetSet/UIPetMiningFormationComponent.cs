using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace ET
{

    public class UIPetMiningFormationComponent : Entity, IAwake
    {
        public GameObject CloseButton;
        public GameObject ButtonChallenge;
        public GameObject TextNumber;
        public GameObject FormationNode;
        public GameObject ButtonConfirm;

        public GameObject IconItemDrag;
        public UIPetFormationSetComponent UIPetFormationSet;
        public List<UIPetFormationItemComponent> uIPetFormations = new List<UIPetFormationItemComponent>();
        public List<long> PetTeamList = new List<long>() { };

        public Action SetHandler = null;
        public int SceneTypeEnum;
    }

    public class UIPetMiningFormationComponentAwake : AwakeSystem<UIPetMiningFormationComponent>
    {
        public override void Awake(UIPetMiningFormationComponent self)
        {
            self.SetHandler = null;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.uIPetFormations.Clear();
            self.ButtonChallenge = rc.Get<GameObject>("ButtonChallenge");
            self.TextNumber = rc.Get<GameObject>("TextNumber");
            self.FormationNode = rc.Get<GameObject>("FormationNode");
            self.ButtonConfirm = rc.Get<GameObject>("ButtonConfirm");
            self.IconItemDrag = rc.Get<GameObject>("IconItemDrag");
            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.IconItemDrag.SetActive(false);
            self.PetTeamList.Clear();

            ButtonHelp.AddListenerEx(self.ButtonConfirm, () => { self.OnButtonConfirm().Coroutine(); });
            ButtonHelp.AddListenerEx(self.ButtonChallenge, () => { self.OnButtonChallenge(); });
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UIPetMiningFormation);
            });
        }
    }

    public static class UIPetMiningFormationComponentSystem
    {

        public static async ETTask OnButtonConfirm(this UIPetMiningFormationComponent self)
        {
            await ETTask.CompletedTask;
        }

        public static void OnButtonChallenge(this UIPetMiningFormationComponent self)
        { 
            
        }

        public static void OnInitUI(this UIPetMiningFormationComponent self, int sceneType, int teamid, Action action)
        {
            self.SetHandler = action;
            self.SceneTypeEnum = sceneType;

            List<long> petids = self.ZoneScene().GetComponent<PetComponent>().GetPetFormatList(sceneType);
            self.PetTeamList.AddRange( petids.GetRange(teamid * 5, 5) );
            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationSet");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = GameObject.Instantiate(bundleGameObject);
            self.UIPetFormationSet = self.AddChild<UIPetFormationSetComponent, GameObject>(go);
            self.UIPetFormationSet.OnUpdateFormation(self.SceneTypeEnum, self.PetTeamList, true);
            self.UIPetFormationSet.DragEndHandler = self.RequestFormationSet;
            UICommonHelper.SetParent(go, self.FormationNode);
        }

        public static void RequestFormationSet(this UIPetMiningFormationComponent self, long rolePetInfoId, int index, int operateType)
        {
            Log.Debug($"RequestFormationSet: {rolePetInfoId} {index} {operateType}");

        }
    }

}