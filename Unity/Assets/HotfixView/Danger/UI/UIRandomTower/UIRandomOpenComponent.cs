using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
    public class UIRandomOpenComponent : Entity, IAwake
    {
        public GameObject Text_Layer;
    }

    [ObjectSystem]
    public class UIRandomOpenComponentAwakeSystem : AwakeSystem<UIRandomOpenComponent>
    {
        public override void Awake(UIRandomOpenComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Layer = rc.Get<GameObject>("Text_Layer");
            self.Text_Layer.GetComponent<Text>().text = "";

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIRandomOpenComponentSystem
    {


        public static async ETTask OnInitUI(this UIRandomOpenComponent self)
        {
            int maxNumber = 0;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int randowTowerId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RandomTowerId);
            if (randowTowerId == 0)
            {
                maxNumber = 1;
            }
            else
            {
                maxNumber = TowerHelper.GetTowerList(SceneTypeEnum.RandomTower).Count;
            }
            if (maxNumber == 0)
            {
                return;
            }
            int randomNumber = 0;
            maxNumber = Mathf.Min(maxNumber, 7);
            for (int i = 0; i < maxNumber; i++)
            {
                randomNumber = RandomHelper.RandomNumber(1, maxNumber);
                self.Text_Layer.GetComponent<Text>().text = randomNumber.ToString();
                await TimerComponent.Instance.WaitAsync(1000);
            }
            C2M_RandomTowerBeginRequest c2M_RandomTowerBeginRequest = new C2M_RandomTowerBeginRequest() {  RandomNumber = randomNumber};
            M2C_RandomTowerBeginResponse m2C_RandomTowerBeginResponse =(M2C_RandomTowerBeginResponse) await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RandomTowerBeginRequest);
            UIHelper.Remove(self.ZoneScene(), UIType.UIRandomOpen);
        }
    }
}