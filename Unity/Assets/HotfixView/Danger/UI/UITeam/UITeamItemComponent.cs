using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITeamItemComponent : Entity, IAwake, IAwake<int>
    {

        public GameObject RawImage;
        public GameObject TextLevel;
        public GameObject TextName;
        public GameObject Text_Wait_2;
        public GameObject TextCombat;
        public GameObject TextOcc;

        public TeamPlayerInfo TeamPlayerInfo;
        public UIModelShowComponent UIModelShowComponent;
    }

    [ObjectSystem]
    public class UITeamItemComponentAwakeSystem : AwakeSystem<UITeamItemComponent, int>
    {
        public override void Awake(UITeamItemComponent self, int index)
        {
            GameObject goParent = self.GetParent<UI>().GameObject;

            self.RawImage = goParent.transform.Find("RawImage").gameObject;
            self.TextLevel = goParent.transform.Find("TextLevel").gameObject;
            self.TextName = goParent.transform.Find("TextName").gameObject;
            self.Text_Wait_2 = goParent.transform.Find("Text_Wait_2").gameObject;
            self.TextCombat = goParent.transform.Find("TextCombat").gameObject;
            self.TextOcc = goParent.transform.Find("TextOcc").gameObject;

            self.UIModelShowComponent = null;
            self.OnInitUI(index).Coroutine();
        }
    }

    public static class UITeamItemComponentSystem
    {
        public static async ETTask OnInitUI(this UITeamItemComponent self, int index)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow" + (index + 1).ToString());
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            gameObject.transform.localPosition = new Vector3(index * 1000, 0, 0);
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 55f, 115f);

            UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
            self.UIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);
            self.UIModelShowComponent.ClickHandler = () => { self.OnClickTeamItem().Coroutine(); };
            if (self.TeamPlayerInfo != null)
            {
                self.UIModelShowComponent.ShowPlayerModel(new BagInfo() { ItemID = self.TeamPlayerInfo.WeaponId }, self.TeamPlayerInfo.Occ);
            }
        }

        public static async ETTask OnClickTeamItem(this UITeamItemComponent self)
        {
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIWatchMenu);
            uI.GetComponent<UIWatchMenuComponent>().OnUpdateUI(MenuEnumType.Team, self.TeamPlayerInfo.UserID).Coroutine();
        }

        public static void OnUpdateItem(this UITeamItemComponent self, TeamPlayerInfo teamPlayerInfo)
        {
            self.TeamPlayerInfo = teamPlayerInfo;

            if (teamPlayerInfo == null)
            {
                self.RawImage.SetActive(false);
                self.TextLevel.SetActive(false);
                self.TextName.SetActive(false);
                self.TextCombat.SetActive(false);
                self.Text_Wait_2.SetActive(true);
            }
            else
            {
                self.RawImage.SetActive(true);
                self.TextLevel.SetActive(true);
                self.TextName.SetActive(true);
                self.TextCombat.SetActive(true);
                self.Text_Wait_2.SetActive(false);
                self.TextLevel.GetComponent<Text>().text = $"{teamPlayerInfo.PlayerLv} 级";
                self.TextName.GetComponent<Text>().text = teamPlayerInfo.PlayerName;
                self.TextCombat.GetComponent<Text>().text = $"战力: {teamPlayerInfo.Combat}";

                self.TextOcc.SetActive(teamPlayerInfo.Occ!=0 || teamPlayerInfo.OccTwo!=0);
                if (teamPlayerInfo.Occ != 0)
                {
                    self.TextOcc.GetComponent<Text>().text = OccupationConfigCategory.Instance.Get(teamPlayerInfo.Occ).OccupationName;
                }
                if (teamPlayerInfo.OccTwo != 0)
                {
                    self.TextOcc.GetComponent<Text>().text = OccupationTwoConfigCategory.Instance.Get(teamPlayerInfo.OccTwo).OccupationName;
                }
            }

            if (teamPlayerInfo != null && self.UIModelShowComponent != null)
            {
                self.UIModelShowComponent.ShowPlayerModel(new BagInfo() { ItemID = teamPlayerInfo.WeaponId}, self.TeamPlayerInfo.Occ);
            }
        }
    }
}
