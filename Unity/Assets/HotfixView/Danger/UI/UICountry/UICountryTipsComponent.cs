using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICountryTipsComponent : Entity, IAwake
    {
        public GameObject Img_back;
        public GameObject ImageButton;
        public GameObject ItemListNode;
        public GameObject PositionNode;
    }

    [ObjectSystem]
    public class UICountryTipsComponentAwakeSystem : AwakeSystem<UICountryTipsComponent>
    {

        public override void Awake(UICountryTipsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.PositionNode = rc.Get<GameObject>("PositionNode");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.Img_back = rc.Get<GameObject>("Img_back");

            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.DomainScene(), UIType.UICountryTips); });
        }
    }

    public static class UICountryTipsComponentSystem
    {
        public static void OnUpdateUI(this UICountryTipsComponent self, string rewards, Vector3 vector3, int showType = 0)
        {
            UICommonHelper.ShowItemList(rewards, self.ItemListNode, self).Coroutine();
            string[] rewardItems = rewards.Split('@');
            int width = rewardItems.Length * 120 + (rewardItems.Length - 1) * 10;
            float halfwidth = UnityEngine.Screen.width * 0.5f;

            if (width > 600)
            {
                self.Img_back.GetComponent<RectTransform>().sizeDelta = new Vector2(width, 200);
            }
            else
            {
                width = 600;
            }

            //宠物布阵
            if (showType == 1)
            {
                vector3.y += 200;
                self.PositionNode.transform.localPosition = vector3;
                return;
            }
  
            if (vector3.x + width >= halfwidth)
            {
                vector3.x = halfwidth - width;
                self.PositionNode.transform.localPosition = vector3;
            }
            else
            {
                vector3.x += 300f;
                self.PositionNode.transform.localPosition = vector3;
            }

            if (vector3.y < - 340)
            {
                float offsetup = vector3.y * -1f - 260f;
                self.PositionNode.transform.localPosition = vector3 + new Vector3(0, offsetup, 0);
            }
            else
            {
                self.PositionNode.transform.localPosition = vector3;
            }
        }

    }
}
