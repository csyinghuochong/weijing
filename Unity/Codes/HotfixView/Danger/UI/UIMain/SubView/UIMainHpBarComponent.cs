using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMainHpBarComponent : Entity, IAwake
    {

        public GameObject Lab_MonsterLv;
        public GameObject Lab_MonsterName;
        public GameObject Img_MonsterHp;
        public GameObject Img_BossIcon;
        public GameObject Lab_BossLv;
        public GameObject Lab_BossName;
        public GameObject Img_BossHp;
        public GameObject MonsterNode;
        public GameObject BossNode;

        public long LockMonsterId;
        public long LockBossId;
        public Vector3 Vector3;
        public UIModelShowComponent uIModelShowComponent;
    }


    [ObjectSystem]
    public class UIMainHpBarComponentAwakeSystem : AwakeSystem<UIMainHpBarComponent>
    {

        public override void Awake(UIMainHpBarComponent self)
        {
            self.Vector3 = new Vector3(1, 1, 1);
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Lab_MonsterLv = rc.Get<GameObject>("Lab_MonsterLv");
            self.Lab_MonsterName = rc.Get<GameObject>("Lab_MonsterName");
            self.Img_MonsterHp = rc.Get<GameObject>("Img_MonsterHp");
            self.Img_BossIcon = rc.Get<GameObject>("Img_BossIcon");
            self.Lab_BossLv = rc.Get<GameObject>("Lab_BossLv");
            self.Lab_BossName = rc.Get<GameObject>("Lab_BossName");
            self.Img_BossHp = rc.Get<GameObject>("Img_BossHp");
            self.MonsterNode = rc.Get<GameObject>("MonsterNode");
            self.BossNode = rc.Get<GameObject>("BossNode");

            self.MonsterNode.SetActive(false);
            self.BossNode.SetActive(false);
        }
    }

    public static class UIMainHpBarComponentSystem
    {

        public static void OnChangeSonScene(this UIMainHpBarComponent self)
        {
            self.MonsterNode.SetActive(false);
            self.BossNode.SetActive(false);
         }

        public static void OnLockUnit(this UIMainHpBarComponent self, Unit unit)
        {
            self.LockMonsterId = unit.Id;

            int configid = unit.GetComponent<UnitInfoComponent>().UnitCondigID;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(configid);
            if (monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss)
            {
                return;
            }

            self.MonsterNode.SetActive(true);
            self.Lab_MonsterName.GetComponent<Text>().text = monsterConfig.MonsterName;
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.Tower)
            {
                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                self.Lab_MonsterLv.GetComponent<Text>().text = userInfoComponent.UserInfo.Lv.ToString();
            }
            else
            {
                self.Lab_MonsterLv.GetComponent<Text>().text = monsterConfig.Lv.ToString();
            }
            self.OnChangeHp(unit);
        }

        public static void OnChangeHp(this UIMainHpBarComponent self, Unit unit)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            float curhp = numericComponent.GetAsLong(NumericType.Now_Hp);
            float blood = curhp / numericComponent.GetAsLong(NumericType.Now_MaxHp);
            if (blood < 0) {
                blood = 0;
            }

            self.Vector3.x = blood;
            if (self.LockMonsterId == unit.Id)
            {
                //更新怪物血条
                self.Img_MonsterHp.transform.localScale = self.Vector3;
            }
            if (self.LockBossId == unit.Id)
            {
                //更新Boss血条
                self.Img_BossHp.transform.localScale = self.Vector3;
            }
        }

        public static void OnUnitDead(this UIMainHpBarComponent self, long unitid)
        {
            if (self.LockMonsterId == unitid)
            {
                self.MonsterNode.SetActive(false);
            }
            if (self.LockBossId == unitid)
            {
                self.MonsterNode.SetActive(false);
            }
        }

        public static void OnCancelLock(this UIMainHpBarComponent self)
        {
            self.MonsterNode.SetActive(false);
        }

        public static async ETTask InitModelShowView(this UIMainHpBarComponent self, int monsterId)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelBossIconShow");
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.Img_BossIcon);
            UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.Img_BossIcon);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 200, 378f);
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterId);
            self.uIModelShowComponent.ShowOtherModel("Monster/" + monsterConfig.MonsterModelID.ToString()).Coroutine();
        }

        public static void ShowBossHPBar(this UIMainHpBarComponent self, Unit unit)
        {
            if (self.BossNode.activeSelf && unit != null)
            {
                return;
            }
            if (!self.BossNode.activeSelf && unit == null)
            {
                return;
            }
            if (unit == null)
            {
                self.LockBossId = 0;
                self.BossNode.SetActive(false);
                UICommonHelper.DestoryChild(self.Img_BossIcon);
                self.uIModelShowComponent?.Dispose();
                self.uIModelShowComponent = null;
            }
            else
            {
                int configid = unit.GetComponent<UnitInfoComponent>().UnitCondigID;
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(configid);
                self.LockBossId = unit.Id;
                self.BossNode.SetActive(true);
                self.Lab_BossLv.GetComponent<Text>().text = monsterConfig.Lv.ToString();
                self.Lab_BossName.GetComponent<Text>().text = monsterConfig.MonsterName;
                //self.Img_BossIcon.GetComponent<Image>().sprite = sp;
                self.InitModelShowView(configid).Coroutine();
                self.OnChangeHp(unit);
            }
        }

    }

}
