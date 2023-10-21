using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
    public class UIPetMiningRecordComponent : Entity, IAwake
    {
        public GameObject ImageClose;
        public GameObject BuildingList2;
        public GameObject UIPetMiningRecordItem;

    }

    public class UIPetMiningRecordComponentAwake : AwakeSystem<UIPetMiningRecordComponent>
    {
        public override void Awake(UIPetMiningRecordComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageClose = rc.Get<GameObject>("ImageClose");
            self.ImageClose.GetComponent<Button>().onClick.AddListener(self.OnImageClose);

            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");

            self.UIPetMiningRecordItem = rc.Get<GameObject>("UIPetMiningRecordItem");
            self.UIPetMiningRecordItem.SetActive(false);

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIPetMiningRecordComponentSystem
    {
        public static void OnImageClose(this UIPetMiningRecordComponent self)
        {
            UIHelper.Remove( self.ZoneScene(), UIType.UIPetMiningRecord );
        }

        public static async ETTask  OnInitUI(this UIPetMiningRecordComponent self)
        {
            long instanceid = self.InstanceId;
            C2M_PetMingRecordRequest    request     = new C2M_PetMingRecordRequest();
            M2C_PetMingRecordResponse response = (M2C_PetMingRecordResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            for (int i = 0; i < response.PetMingRecords.Count; i++)
            {
                PetMingRecord petMingRecord = response.PetMingRecords[i];
                GameObject gameObject = GameObject.Instantiate( self.UIPetMiningRecordItem );
                gameObject.SetActive(true);

                MineBattleConfig mineBattleConfig = MineBattleConfigCategory.Instance.Get(petMingRecord.MineType );
                string content = $"玩家 {response.PetMingRecords[i].WinPlayer} {TimeInfo.Instance.ToDateTime(petMingRecord.Time)} 占领了你的{mineBattleConfig.Name}";
                gameObject.transform.Find("Text").GetComponent<Text>().text = content;
                UICommonHelper.SetParent( gameObject, self.BuildingList2 );
            }
        }
    }

}