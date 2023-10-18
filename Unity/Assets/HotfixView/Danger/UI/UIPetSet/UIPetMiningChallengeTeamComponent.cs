using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

namespace ET
{


    public class UIPetMiningChallengeTeamComponent : Entity, IAwake<GameObject>
    {

        public int TeamId = 0;   //0 1 2
        public GameObject GameObject;

        public GameObject TextTip11;
        public GameObject TextTip12;
        public GameObject TextTip13;

        public PetComponent PetComponent;

        public Image[] PetIcon_List = new Image[5];

        public GameObject ButtonSelect;
        public GameObject ImageSelect;

        public Action<int> SelectHandler;
    }

    public class UIPetMiningChallengeTeamComponentAwake : AwakeSystem<UIPetMiningChallengeTeamComponent, GameObject>
    {
        public override void Awake(UIPetMiningChallengeTeamComponent self, GameObject gameObject)
        {

            self.GameObject = gameObject;

            self.TextTip11 = gameObject.transform.Find("TextTip11").gameObject;
            self.TextTip12 = gameObject.transform.Find("TextTip12").gameObject;
            self.TextTip13 = gameObject.transform.Find("TextTip13").gameObject;

            for (int i = 0; i < self.PetIcon_List.Length; i++)
            {
                GameObject iconitem = gameObject.transform.Find($"PetIcon_{i}").gameObject;
                self.PetIcon_List[i] = iconitem.GetComponent<Image>();
            }

            self.ButtonSelect = gameObject.transform.Find("ButtonSelect").gameObject;
            self.ButtonSelect.GetComponent<Button>().onClick.AddListener(() => { self.SelectHandler.Invoke(self.TeamId); }); 

            self.ImageSelect = gameObject.transform.Find("ImageSelect").gameObject;
        }
    }

    public static class UIPetMiningChallengeTeamComponentSystem
    {
        public static void OnUpdateUI(this UIPetMiningChallengeTeamComponent self)
        { 
            
        }
    }
}