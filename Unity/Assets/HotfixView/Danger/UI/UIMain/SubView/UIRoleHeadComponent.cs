using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleHeadComponent : Entity, IAwake<GameObject>
    {
        public GameObject Img_RoleHuoLi;
        public GameObject Img_RolePiLao;
        public GameObject Lab_ServerName;
        public GameObject Lab_RoleHuoLi;
        public GameObject GameObject;
        public GameObject Lab_Combat;
        public GameObject Lab_PetName;
        public GameObject PetIconSet;
        public GameObject ButtonSet;
        public GameObject Obj_Lab_RoleLv;
        public GameObject Obj_Lab_RoleName;
        public GameObject Obj_Lab_PetName;
        public GameObject Obj_Img_PetHp;
        public GameObject Obj_Lab_RolePiLao;
        public GameObject Obj_Img_RolePiLao;
        public GameObject Obj_ImagePetHeadIcon;

        public UserInfoComponent UserInfoComponent;

        public int MaxPiLao;
    }

    [ObjectSystem]
    public class UIRoleHeadComponentAwakeSystem : AwakeSystem<UIRoleHeadComponent, GameObject>
    {

        public override void Awake(UIRoleHeadComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            //获取相关组件
            self.Lab_RoleHuoLi = rc.Get<GameObject>("Lab_RoleHuoLi");
            self.Lab_Combat= rc.Get<GameObject>("Lab_Combat");
            self.PetIconSet = rc.Get<GameObject>("PetIconSet");
            self.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            self.Obj_Lab_RoleLv = rc.Get<GameObject>("Lab_RoleLv");
            self.Obj_Lab_RoleName = rc.Get<GameObject>("Lab_RoleName");
            self.Obj_Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            self.Obj_Img_PetHp = rc.Get<GameObject>("Img_PetHp");
            self.Obj_Lab_RolePiLao = rc.Get<GameObject>("Lab_RolePiLao");
            self.Obj_ImagePetHeadIcon = rc.Get<GameObject>("ImagePetHeadIcon");
            self.Lab_ServerName = rc.Get<GameObject>("Lab_ServerName");
            self.Img_RoleHuoLi = rc.Get<GameObject>("Img_RoleHuoLi");
            self.Img_RolePiLao = rc.Get<GameObject>("Img_RolePiLao");

            self.ButtonSet = rc.Get<GameObject>("ButtonSet");
            self.ButtonSet.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenSettingUI(); });

            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            UICommonHelper.ShowOccIcon(self.ButtonSet, self.UserInfoComponent.UserInfo.Occ);
            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();

            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            self.Lab_ServerName.GetComponent<Text>().text = ServerHelper.GetGetServerItem(!GlobalHelp.IsOutNetMode, accountInfoComponent.ServerId).ServerName;

            self.InitShow();
        }
    }

    public static class UIRoleHeadComponentSystem
    {

        public static void OnUpdateCombat(this UIRoleHeadComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long combat = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Combat;
            self.Lab_Combat.GetComponent<Text>().text = $"战力: {combat}";
        }

        public static void OnOpenSettingUI(this UIRoleHeadComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UISetting).Coroutine() ;
        }

        public static void InitShow(this UIRoleHeadComponent self)
        {
            self.UpdateShowRoleName();
            self.UpdateShowRoleExp();
            self.UpdateShowRolePiLao();
            self.UpdateShowRolePetName();
            self.OnPetFightSet();
            self.OnUpdateCombat();
            self.UpdateShowRoleHuoLi();
        }

        public static void OnPetFightSet(this UIRoleHeadComponent self)
        {
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetFightPet();
            self.PetIconSet.SetActive(!GlobalHelp.IsBanHaoMode &&rolePetInfo != null);
            if (rolePetInfo == null)
            {
                return; 
            }

            //宠物头像显示
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            self.Obj_ImagePetHeadIcon.GetComponent<Image>().sprite = sp;
            self.Lab_PetName.GetComponent<Text>().text = rolePetInfo.PetName;
            Unit pet = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(rolePetInfo.Id);
            self.OnUpdatePetHP(pet);
        }

        //角色名称更新
        public static void UpdateShowRoleName(this UIRoleHeadComponent self)
        {
            self.Obj_Lab_RoleName.GetComponent<Text>().text = self.UserInfoComponent.UserInfo.Name;
        }

        //角色经验更新
        public static void UpdateShowRoleExp(this UIRoleHeadComponent self)
        {
            self.Obj_Lab_RoleLv.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("等级") + ":" + self.UserInfoComponent.UserInfo.Lv;
        }

        //角色疲劳更新
        public static void UpdateShowRolePiLao(this UIRoleHeadComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int maxPiLao = unit.GetMaxPiLao();
            self.Obj_Lab_RolePiLao.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("体力:") + self.UserInfoComponent.UserInfo.PiLao + "/" + maxPiLao;
            self.Img_RolePiLao.GetComponent<Image>().fillAmount = 1f * self.UserInfoComponent.UserInfo.PiLao / maxPiLao;
        }

        //更新活力
        public static void UpdateShowRoleHuoLi(this UIRoleHeadComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int maxPiLao = unit.GetMaxHuoLi();
            self.Lab_RoleHuoLi.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("活力:") + self.UserInfoComponent.UserInfo.Vitality + "/" + maxPiLao;
            self.Img_RoleHuoLi.GetComponent<Image>().fillAmount = 1f* self.UserInfoComponent.UserInfo.Vitality / maxPiLao;
        }

        //初始化界面基础信息
        public static void UpdateShowRolePetName(this UIRoleHeadComponent self)
        {

        }

        //初始化界面基础信息
        public static void OnUpdatePetHP(this UIRoleHeadComponent self, Unit pet)
        {
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetFightPet();
            if (rolePetInfo == null || pet.Id != rolePetInfo.Id)
            {
                return;
            }
            float curhp = pet.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Hp); 
            float blood = curhp / pet.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_MaxHp);
            blood = Mathf.Max(blood, 0f);
            self.Obj_Img_PetHp.GetComponent<Image>().fillAmount = blood;
        }
    }
}
