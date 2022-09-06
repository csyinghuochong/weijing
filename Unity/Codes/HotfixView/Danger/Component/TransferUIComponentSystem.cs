using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{

    [ObjectSystem]
    public class TransferUIComponentDestroySystem : DestroySystem<TransferUIComponent>
    {
        public override void Destroy(TransferUIComponent self)
        {
            if (self.HeadBar != null)
            {
                GameObject.Destroy(self.HeadBar);
                self.HeadBar = null;
            }
        }
    }

    [ObjectSystem]
    public class TransferUIComponentAwakeSystem : AwakeSystem<TransferUIComponent>
    {
        public override void Awake(TransferUIComponent self)
        {
            self.HeadBar = null;
            self.UICamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
        }
    }

    public static class TransferUIComponentSystem
    {
        public static async ETTask OnInitUI(this TransferUIComponent self, int transferId)
        {
            DungeonTransferConfig monsterConfig = DungeonTransferConfigCategory.Instance.Get(transferId);
            string path = ABPathHelper.GetUGUIPath("Battle/UITransfer");
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            self.HeadBar = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            self.HeadBar.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.Low]);
            self.HeadBar.transform.localScale = Vector3.one;

            self.UIPosition = self.GetParent<Unit>().GetComponent<GameObjectComponent>().GameObject.transform.Find("UIPosition");
            self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<Text>().text = monsterConfig.Name;

            if (self.HeadBar.GetComponent<HeadBarUI>() == null)
            {
                self.HeadBar.AddComponent<HeadBarUI>();
            }
            self.HeadBarUI = self.HeadBar.GetComponent<HeadBarUI>();
            self.HeadBarUI.HeadPos = self.UIPosition;
            self.HeadBarUI.HeadBar = self.HeadBar;
        }

        public static void LateUpdate(this TransferUIComponent self)
        {
            if (self.HeadBar == null)
            {
                return;
            }
            Transform UIPosition = self.UIPosition;
            Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(UIPosition.position, self.HeadBar, self.UICamera, self.MainCamera);

            Vector3 NewPosition = Vector3.zero;
            NewPosition.x = OldPosition.x;
            NewPosition.y = OldPosition.y;
            self.HeadBar.transform.localPosition = NewPosition;
        }
    }
}
