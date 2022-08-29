using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;
using TMPro;

namespace ET
{
    [Timer(TimerType.PetMainTimer)]
    public class PetMainTimer : ATimer<UIPetMainComponent>
    {
        public override void Run(UIPetMainComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }


    public class UIPetMainComponent : Entity, IAwake, IDestroy
    {
        public GameObject MonsterHpNode;
        public GameObject PetHpNode;
        public GameObject UIMonsterHp;
        public GameObject UIPetHp;

        public GameObject Di;

        public GameObject Image_3;
        public GameObject Image_2;
        public GameObject Image_1;

        public GameObject PetFubenFinger;
        public GameObject Btn_RerurnBuilding;

        //手指第一次触摸点的位置
        public Vector2 m_scenePos = new Vector2();
        //摄像机
        public Transform CameraTarget;

        public long Timer;
        public float BeginTime;

        public Dictionary<long, GameObject> HpList= new Dictionary<long, GameObject>();
    }

    [ObjectSystem]
    public class UIPetMainComponentDestroySystem : DestroySystem<UIPetMainComponent>
    {
        public override void Destroy(UIPetMainComponent self)
        {
            //DataUpdateComponent.Instance.RemoveListener(DataType.SkillSetting, self);
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

   [ObjectSystem]
    public class UIPetMainComponentAwakeSystem : AwakeSystem<UIPetMainComponent>
    {
        public override void Awake(UIPetMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.CameraTarget = UIComponent.Instance.MainCamera.transform;

            self.Btn_RerurnBuilding = rc.Get<GameObject>("Btn_RerurnBuilding");
            self.Btn_RerurnBuilding.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_RerurnBuilding(); });
            self.PetFubenFinger = rc.Get<GameObject>("PetFubenFinger");
            self.PetFubenFinger.GetComponent<Image>().color = new Color(255, 255, 255, 0);
            ButtonHelp.AddEventTriggers(self.PetFubenFinger, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.PetFubenFinger, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.PetFubenFinger, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);

            self.HpList.Clear();
            self.UIMonsterHp = rc.Get<GameObject>("UIMonsterHp");
            self.UIMonsterHp.SetActive(false);
            self.UIPetHp = rc.Get<GameObject>("UIPetHp");
            self.UIPetHp.SetActive(false);
            self.MonsterHpNode = rc.Get<GameObject>("MonsterHpNode");
            self.PetHpNode = rc.Get<GameObject>("PetHpNode");

            self.Di = rc.Get<GameObject>("Di");
            self.Image_3 = rc.Get<GameObject>("Image_3");
            self.Image_2 = rc.Get<GameObject>("Image_2");
            self.Image_1 = rc.Get<GameObject>("Image_1");
            self.Image_3.SetActive(false);
            self.Image_2.SetActive(false);
            self.Image_1.SetActive(false);

            //DataUpdateComponent.Instance.RemoveListener(DataType.UnitHpUpdate, self);
            self.OnPlayAnimation().Coroutine();
            self.InitHpList();
        }
    }

    public static class UIPetMainComponentSystem
    {

        public static void OnUnitHpUpdate(this UIPetMainComponent self, Unit unit)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            float curhp = numericComponent.GetAsLong(NumericType.Now_Hp);
            float blood = curhp / numericComponent.GetAsLong(NumericType.Now_MaxHp);
            blood = Mathf.Max(blood, 0f);
            GameObject gameObject = self.HpList[unit.Id];
            gameObject.transform.Find("Img_HpValue").GetComponent<Image>().fillAmount = blood;
        }

        public static void InitHpList(this UIPetMainComponent self)
        {
            Entity[] entities = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < entities.Length; i++)
            { 
                UnitInfoComponent unitInfo = entities[i].GetComponent<UnitInfoComponent>();
                if (unitInfo.Type == UnitType.Monster)
                {
                    GameObject gameObject = GameObject.Instantiate(self.UIMonsterHp);
                    UICommonHelper.SetParent(gameObject, self.MonsterHpNode);
                    gameObject.SetActive(true);

                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(unitInfo.UnitCondigID);
                    gameObject.transform.Find("Lal_Name").GetComponent<TMPro.TextMeshProUGUI>().text = monsterCof.MonsterName;
                    gameObject.transform.Find("Lal_Lv").GetComponent<TextMeshProUGUI>().text = monsterCof.Lv.ToString();
                    self.HpList.Add(entities[i].Id, gameObject);
                    continue;
                }
                if (unitInfo.Type == UnitType.Pet)
                {
                    GameObject gameObject = GameObject.Instantiate(self.UIPetHp);
                    UICommonHelper.SetParent(gameObject, self.PetHpNode);
                    gameObject.SetActive(true);

                    gameObject.transform.Find("Lal_Name").GetComponent<TextMeshProUGUI>().text = PetConfigCategory.Instance.Get(unitInfo.UnitCondigID).PetName;
                    self.HpList.Add(entities[i].Id, gameObject);
                    continue;
                }
            }
        }

        public static void  OnTimer(this UIPetMainComponent self)
        {
            Camera camera = UIComponent.Instance.MainCamera;
            float passTime = Time.time - self.BeginTime;
            float fieldOfView = 50f - (passTime / 10f) * 20;
            fieldOfView = Math.Max(fieldOfView, 30);
            camera.GetComponent<Camera>().fieldOfView = fieldOfView;
        }

        public static async ETTask OnPlayAnimation(this UIPetMainComponent self)
        {
            long instanceId = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(500);
            self.Image_3.SetActive(true);
            self.BeginTime = Time.time;
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.PetMainTimer, self);
            DoTweenHelp.DOScale(self.Image_3.transform, Vector3.zero, 1f);
            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            self.Image_3.SetActive(false);
            self.Image_2.SetActive(true);
            DoTweenHelp.DOScale(self.Image_2.transform, Vector3.zero, 1f);
            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            self.Image_2.SetActive(false);
            self.Image_1.SetActive(true);
            DoTweenHelp.DOScale(self.Image_1.transform, Vector3.zero, 1f);
            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            self.Image_1.SetActive(false);
            self.Di.SetActive(false);
            C2M_PetFubenBeginRequest c2M_PetFubenBeginRequest = new C2M_PetFubenBeginRequest();
            await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_PetFubenBeginRequest);
        }

        public static void BeginDrag(this UIPetMainComponent self, PointerEventData pdata)
        {
            self.m_scenePos = Input.mousePosition;
        }

        public static void Draging(this UIPetMainComponent self, PointerEventData pdata)
        {
            Vector3 move = new Vector3(pdata.delta.x * -0.01f, 0f, pdata.delta.y * -0.01f);
            Quaternion rotaion = Quaternion.Euler(0, -90,0);
            Vector3 targ = self.CameraTarget.localPosition + rotaion * move;
            targ.x = Mathf.Clamp(targ.x, AIHelp.FuBenCameraPositionMin_X, AIHelp.FuBenCameraPositionMax_X);
            targ.z = Mathf.Clamp(targ.z, AIHelp.FuBenCameraPositionMin_Z, AIHelp.FuBenCameraPositionMax_Z);
            self.CameraTarget.localPosition = targ;
        }

        public static void EndDrag(this UIPetMainComponent self, PointerEventData pdata)
        {
        }

        public static void OnBtn_RerurnBuilding(this UIPetMainComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.DomainScene(), "", GameSettingLanguge.LoadLocalization("确定返回主城？"),
               () =>
               {
                   EnterFubenHelp.RequestQuitFuben(self.ZoneScene());
                   UIHelper.Remove(self.ZoneScene(), UIType.UIPetMain).Coroutine();
               },
               null).Coroutine();
        }
    }
}
