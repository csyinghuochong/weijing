using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
    public class UIAttackGridComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Btn_SkillStart;
        public SkillConfig SkillConfig;
        public GameObject FightEffect;

        public bool InitEffect;
        public long MoveAttackId;

        public GameObject GameObject;
        public AttackComponent AttackComponent;
    }


    public class UIAttackGridComponentAwakeSystem : AwakeSystem<UIAttackGridComponent, GameObject>
    {
        public override void Awake(UIAttackGridComponent self, GameObject gameObject)
        {
            self.Awake(gameObject);
        }
    }


    public class UIAttackGridComponentDestroySystem : DestroySystem<UIAttackGridComponent>
    {
        public override void Destroy(UIAttackGridComponent self)
        {

        }
    }

    public static class UIAttackGridComponentSystem
    {

        public static void Awake(this UIAttackGridComponent self, GameObject gameObject)
        {
            self.InitEffect = false;
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Btn_SkillStart = rc.Get<GameObject>("Btn_SkillStart");
            self.FightEffect = rc.Get<GameObject>("FightEffect");
           
            ButtonHelp.AddEventTriggers(self.Btn_SkillStart, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_SkillStart, (PointerEventData pdata) => { self.OnEndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.Btn_SkillStart, (PointerEventData pdata) => { self.PointerUp(pdata); }, EventTriggerType.PointerUp);

            self.AttackComponent = self.ZoneScene().GetComponent<AttackComponent>();
        }

        public static void OnEndDrag(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.FightEffect.SetActive(false);

            self.ZoneScene().GetComponent<SkillIndicatorComponent>().RecoveryEffect();
        }

        public static void PointerUp(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.OnMoveStart();
            self.FightEffect.SetActive(false);
            Scene zoneScene = self.ZoneScene();
            zoneScene.GetComponent<SkillIndicatorComponent>().RecoveryEffect();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit == null)
            {
                return;
            }
            LockTargetComponent lockTargetComponent = zoneScene.GetComponent<LockTargetComponent>();
            long targetId = lockTargetComponent.LockTargetUnit(true);
            Unit targetUnit = unit.GetParent<UnitComponent>().Get(targetId);
            if (targetUnit == null)
            {
                zoneScene.GetComponent<AttackComponent>().MoveAttackId = 0;
                zoneScene.GetComponent<AttackComponent>().AutoAttack_1(unit, null);
            }
            else
            {
                zoneScene.GetComponent<AttackComponent>().BeginAutoAttack(targetUnit.Id);
            }
        }

        public static async ETTask ShowFightEffect(this UIAttackGridComponent self)
        {
            self.FightEffect.SetActive(true);
            if (!self.InitEffect)
            {
                self.InitEffect = true;
                GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(ABPathHelper.GetEffetPath("UIFightHintEffect"));
                GameObject effect = UnityEngine.Object.Instantiate(prefab);
                effect.GetComponent<UISizeFangDa>().Obj_Img = self.Btn_SkillStart;
                UICommonHelper.SetParent(effect, self.FightEffect);
            }
            else
            {
                if (self.FightEffect.transform.childCount > 0)
                {
                    GameObject effect = self.FightEffect.transform.GetChild(0).gameObject;
                    effect.SetActive(false);
                    effect.SetActive(true);
                }
             }
        }

        public static void PointerDown(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.ShowFightEffect().Coroutine();
            self.ZoneScene().GetComponent<SkillIndicatorComponent>().ShowCommonAttackZhishi();
        }
        
        public static void OnMoveStart(this UIAttackGridComponent self)
        {
            self.ZoneScene().GetComponent<AttackComponent>().RemoveTimer();
        }
    }
}
