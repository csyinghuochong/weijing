using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    [Timer(TimerType.PetEggListItemTimer)]
    public class PetEggListItemTimer : ATimer<UIPetEggListItemComponent>
    {
        public override void Run(UIPetEggListItemComponent self)
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

    public class UIPetEggListItemComponent : Entity, IAwake<GameObject>, IDestroy
    {

        public GameObject ButtonFuHua;
        public GameObject Node1;
        public GameObject Node0;
        public GameObject ButtonGet;
        public GameObject Text_Time;
        public GameObject Text_Name;
        public GameObject ButtonOpen;
        public GameObject PetEggIcon;

        public RolePetEgg RolePetEgg;

        public Action<int, PointerEventData> BeginDragHandler;
        public Action<int, PointerEventData> DragingHandler;
        public Action<int, PointerEventData> EndDragHandler;

        public long Timer;
        public int Index;
    }

    public class UIPetEggListItemComponentAwakeSystem : AwakeSystem<UIPetEggListItemComponent, GameObject>
    {
        public override void Awake(UIPetEggListItemComponent self, GameObject go)
        {
            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();

            self.Node1 = rc.Get<GameObject>("Node1");
            self.Node0 = rc.Get<GameObject>("Node0");
            self.ButtonFuHua = rc.Get<GameObject>("ButtonFuHua");
            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            self.Text_Time = rc.Get<GameObject>("Text_Time");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.ButtonOpen = rc.Get<GameObject>("ButtonOpen");
            self.PetEggIcon = rc.Get<GameObject>("PetEggIcon");
            self.Text_Time.GetComponent<Text>().text = "";
            self.ButtonOpen.SetActive(false);
            self.ButtonGet.SetActive(false);
            self.ButtonFuHua.SetActive(false);

            ButtonHelp.AddEventTriggers(self.PetEggIcon, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.PetEggIcon, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.PetEggIcon, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);

            ButtonHelp.AddListenerEx(self.ButtonOpen, () => { self.OnButtonOpen(); });
            ButtonHelp.AddListenerEx(self.ButtonGet, () => { self.OnButtonGet().Coroutine();  });
            ButtonHelp.AddListenerEx(self.ButtonFuHua, () => { self.OnButtonFuHua().Coroutine(); });
        }
    }

    public class UIPetEggListItemComponentDestroySystem : DestroySystem<UIPetEggListItemComponent>
    {
        public override void Destroy(UIPetEggListItemComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }


    public static class UIPetEggListItemComponentSystem
    {
        public static void BeginDrag(this UIPetEggListItemComponent self, PointerEventData pdata)
        {
            self.BeginDragHandler?.Invoke(self.Index, pdata);
        }

        public static void Draging(this UIPetEggListItemComponent self, PointerEventData pdata)
        {
            self.DragingHandler?.Invoke(self.Index, pdata);
        }

        public static void EndDrag(this UIPetEggListItemComponent self, PointerEventData pdata)
        {
            self.EndDragHandler?.Invoke(self.Index, pdata);
        }

        public static void  OnButtonOpen(this UIPetEggListItemComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            int maxNum = ComHelp.GetPetMaxNumber(userInfo.Lv);
            if (maxNum <= petComponent.RolePetInfos.Count)
            {
                FloatTipManager.Instance.ShowFloatTip("已达到最大宠物数量");
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.RolePetEgg.ItemId);
            string[] itemUseinfo = itemConfig.ItemUsePar.Split('@');

            //int needCost = int.Parse(GlobalValueConfigCategory.Instance.Get(31).Value);
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "开启宠物蛋",
                $"开启需要花费 {itemUseinfo[1]}钻石",
                () => 
                {
                    self.OnButtonGet().Coroutine();
                }
                ).Coroutine();
        }

        public static async ETTask OnButtonFuHua(this UIPetEggListItemComponent self)
        {
            C2M_RolePetEggHatch c2M_RolePetEggHatch = new C2M_RolePetEggHatch()
            {
                Index = self.Index,
            };
            M2C_RolePetEggHatch m2C_RolePetChouKaResponse = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetEggHatch) as M2C_RolePetEggHatch;
            if (m2C_RolePetChouKaResponse.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            petComponent.RolePetEggs[self.Index] = m2C_RolePetChouKaResponse.RolePetEgg;

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIPetEgg);
            uI.GetComponent<UIPetEggComponent>().OnRolePetEggOpen();
        }

        public static async ETTask OnButtonGet(this UIPetEggListItemComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int maxNum = ComHelp.GetPetMaxNumber(userInfo.Lv);
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            if (maxNum <= petComponent.RolePetInfos.Count)
            {
                FloatTipManager.Instance.ShowFloatTip("已达到最大宠物数量");
                return;
            }

            C2M_RolePetEggOpen c2M_RolePetEggHatch = new C2M_RolePetEggOpen()
            {
                Index = self.Index,
            };
            M2C_RolePetEggOpen m2C_RolePetChouKaResponse = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetEggHatch) as M2C_RolePetEggOpen;
            if (m2C_RolePetChouKaResponse.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            petComponent.RolePetEggs[self.Index].ItemId = 0;
            petComponent.RolePetEggs[self.Index].EndTime = 0;
            UI uI = UIHelper.GetUI( self.ZoneScene(), UIType.UIPetEgg );
            uI.GetComponent<UIPetEggComponent>().OnRolePetEggOpen();

            UI petchouka = await UIHelper.Create(self.ZoneScene(), UIType.UIPetChouKaGet);
            petchouka.GetComponent<UIPetChouKaGetComponent>().OnInitUI(m2C_RolePetChouKaResponse.PetInfo);
        }

        public static void OnTimer(this UIPetEggListItemComponent self)
        {
            long timeNow = self.RolePetEgg.EndTime - TimeHelper.ServerNow();
            self.Text_Time.GetComponent<Text>().text = "剩余时间:" + TimeHelper.ShowLeftTime(timeNow);
            if (timeNow <= 0)
            {
                self.SetFuHuaEnd();
                TimerComponent.Instance.Remove(ref self.Timer);
                return;
            }
        }

        /// <summary>
        /// 还没开始孵化
        /// </summary>
        /// <param name="self"></param>
        public static void SetEggNoFuhua(this UIPetEggListItemComponent self)
        {
            self.ButtonFuHua.SetActive(true);
            //self.Text_Time.SetActive(false);

            string[] useparams = ItemConfigCategory.Instance.Get(self.RolePetEgg.ItemId).ItemUsePar.Split('@');
            long timeNow = long.Parse(useparams[0]);
            self.Text_Time.GetComponent<Text>().text = "孵化时间:" + TimeHelper.ShowLeftTime(timeNow*1000);
            self.ButtonOpen.SetActive(false);
            self.ButtonGet.SetActive(false);
        }

        /// <summary>
        /// 正在孵化
        /// </summary>
        /// <param name="self"></param>
        public static void SetFuhua(this UIPetEggListItemComponent self)
        {
            self.ButtonFuHua.SetActive(false);
            self.Text_Time.SetActive(true);
            self.ButtonOpen.SetActive(true);
            self.ButtonGet.SetActive(false);
        }

       /// <summary>
       /// 孵化完成 可领取
       /// </summary>
       /// <param name="self"></param>
        public static void SetFuHuaEnd(this UIPetEggListItemComponent self)
        {
            self.ButtonFuHua.SetActive(false);
            self.Text_Time.SetActive(false);
            self.ButtonOpen.SetActive(false);
            self.ButtonGet.SetActive(true);
        }

        public static void OnUpdateUI(this UIPetEggListItemComponent self, RolePetEgg rolePetEgg,int index)
        {
            self.Index = index;
            self.RolePetEgg = rolePetEgg;
            self.Node1.SetActive(rolePetEgg != null && rolePetEgg.ItemId > 0);
            self.Node0.SetActive(!self.Node1.activeSelf);
            TimerComponent.Instance.Remove(ref self.Timer);
            if (self.Node0.activeSelf)
            {
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(rolePetEgg.ItemId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            self.PetEggIcon.GetComponent<Image>().sprite = sp;
            if (rolePetEgg.EndTime == 0)
            {
                self.SetEggNoFuhua();
                return;
            }

            //可领取
            long timeNow = rolePetEgg.EndTime - TimeHelper.ServerNow();
            if (timeNow < 0)
            {
                self.SetFuHuaEnd();
                return;
            }

            self.SetFuhua();
            self.OnTimer();
            //在孵化
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.PetEggListItemTimer, self);
        }
    }
}
