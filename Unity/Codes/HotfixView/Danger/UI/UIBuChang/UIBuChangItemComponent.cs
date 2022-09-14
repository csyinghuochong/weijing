using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIBuChangItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public long UserId;
    }

    [ObjectSystem]
    public class UIBuChangItemComponentAwakeSystem : AwakeSystem<UIBuChangItemComponent, GameObject>
    {
        public override void Awake(UIBuChangItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            self.GameObject.GetComponent<Button>().onClick.AddListener(() => { self.OnClickHandler().Coroutine(); });
        }
    }

    public static class UIBuChangItemComponentSystem
    {
        public static void OnInitUI(this UIBuChangItemComponent self, KeyValuePair keyValuePair)
        {
            self.UserId = long.Parse(keyValuePair.Value);
            self.GameObject.transform.Find("TextRoleName").GetComponent<Text>().text = keyValuePair.Value2;
        }

        public static async ETTask OnClickHandler(this UIBuChangItemComponent self)
        {
            C2M_BuChangeRequest     request     = new C2M_BuChangeRequest() { BuChangId = self.UserId };
            M2C_BuChangeResponse response = (M2C_BuChangeResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            accountInfoComponent.PlayerInfo.RechargeInfos = response.RechargeInfos;

            UIHelper.Remove(self.ZoneScene(), UIType.UIBuChang).Coroutine();
        }
    }
}
