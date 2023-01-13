using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum PetPageEnum : int
    {
        PetList = 0,
        PetHeCheng = 1,
        PetXiLian = 2,
        PetUpStar = 3,
        Number = 4,
    }

    public class UIPetComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;
        public GameObject Btn_Close;

        public UIPageButtonComponent UIPageButton;
        public UIPageViewComponent UIPageView;

        public int PetItemWeizhi;  //-1左 1 右边
    }

    [ObjectSystem]
    public class UIRolePetComponentAwakeSystem : AwakeSystem<UIPetComponent>
    {
        public override void Awake(UIPetComponent self)
        {
            self.PetItemWeizhi = 0;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)PetPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)PetPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)PetPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)PetPageEnum.PetList] = ABPathHelper.GetUGUIPath("Main/Pet/UIPetList");
            pageViewComponent.UISubViewPath[(int)PetPageEnum.PetHeCheng] = ABPathHelper.GetUGUIPath("Main/Pet/UIPetHeCheng");
            pageViewComponent.UISubViewPath[(int)PetPageEnum.PetXiLian] = ABPathHelper.GetUGUIPath("Main/Pet/UIPetXiLian");
            pageViewComponent.UISubViewPath[(int)PetPageEnum.PetUpStar] = ABPathHelper.GetUGUIPath("Main/Pet/UIPetUpStar");
            pageViewComponent.UISubViewType[(int)PetPageEnum.PetList] = typeof(UIPetListComponent);
            pageViewComponent.UISubViewType[(int)PetPageEnum.PetHeCheng] = typeof(UIPetHeChengComponent);
            pageViewComponent.UISubViewType[(int)PetPageEnum.PetXiLian] = typeof(UIPetXiLianComponent);
            pageViewComponent.UISubViewType[(int)PetPageEnum.PetUpStar] = typeof(UIPetUpStarComponent);
            self.UIPageView = pageViewComponent;

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI pageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            self.UIPageButton = pageButton.AddComponent<UIPageButtonComponent>();
            self.UIPageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton.OnSelectIndex(0);

            DataUpdateComponent.Instance.AddListener(DataType.PetHeChengUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.PetItemSelect, self);
            DataUpdateComponent.Instance.AddListener(DataType.PetXiLianUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.OnPetFightSet, self);
            DataUpdateComponent.Instance.AddListener(DataType.PetUpStarUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.PetFenJieUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
        }
    }

    [ObjectSystem]
    public class UIRolePetComponentDestroySystem : DestroySystem<UIPetComponent>
    {
        public override void Destroy(UIPetComponent self)
        {
            self.UIPageButton = null;

            DataUpdateComponent.Instance.RemoveListener(DataType.PetHeChengUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.PetItemSelect, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.PetXiLianUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.OnPetFightSet, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.PetUpStarUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.PetFenJieUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
        }
    }

    public static class UIRolePetComponentSystem
    {
        public static void OnBtn_Close(this UIPetComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIPet);
        }

        public static void OnPetFenJieUpdate(this UIPetComponent self)
        {
            self.UIPageView.UISubViewList[(int)PetPageEnum.PetList].GetComponent<UIPetListComponent>().OnPetFenJieUpdate();
        }

        public static void OnHeChengReturn(this UIPetComponent self)
        {
            self.UIPageView.UISubViewList[(int)PetPageEnum.PetHeCheng].GetComponent<UIPetHeChengComponent>().OnHeChengReturn();
        }

        public static void OnPetUpStarUpdate(this UIPetComponent self, string dataparams)
        {
            self.UIPageView.UISubViewList[(int)PetPageEnum.PetUpStar].GetComponent<UIPetUpStarComponent>().OnPetUpStarUpdate(dataparams);
        }

        public static void PetItemSelect(this UIPetComponent self, string dataParams)
        {
            string[] paramsList = dataParams.Split('@');
            long petId = long.Parse(paramsList[1]);
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(petId);
            if (paramsList[0] == PetOperationType.XiLian.ToString())
            {
                self.UIPageView.UISubViewList[(int)PetPageEnum.PetXiLian].GetComponent<UIPetXiLianComponent>().OnXiLianSelect(rolePetInfo);
            }
            else if (paramsList[0] == PetOperationType.HeCheng.ToString())
            {
                self.UIPageView.UISubViewList[(int)PetPageEnum.PetHeCheng].GetComponent<UIPetHeChengComponent>().OnHeChengSelect(rolePetInfo);
            }
            else if (paramsList[0] == PetOperationType.UpStar_Main.ToString())
            {
                self.UIPageView.UISubViewList[(int)PetPageEnum.PetUpStar].GetComponent<UIPetUpStarComponent>().PetMainSelect(rolePetInfo);
            }
            else if (paramsList[0] == PetOperationType.UpStar_FuZh.ToString())
            {
                self.UIPageView.UISubViewList[(int)PetPageEnum.PetUpStar].GetComponent<UIPetUpStarComponent>().PetItemSelect(rolePetInfo);
            }
        }

        public static void OnXiLianUpdate(this UIPetComponent self)
        {
            UI uI = self.UIPageView.UISubViewList[(int)PetPageEnum.PetXiLian];
            uI?.GetComponent<UIPetXiLianComponent>().OnXiLianUpdate();
        }

        public static void OnPetFightSet(this UIPetComponent self)
        {
            UI ui = self.UIPageView.UISubViewList[(int)PetPageEnum.PetList];
            ui?.GetComponent<UIPetListComponent>().OnPetFightingSet();
        }

        public static async ETTask<int> RequestPetHeXinSelect(this UIPetComponent self)
        {
            return await self.UIPageView.UISubViewList[(int)PetPageEnum.PetList].GetComponent<UIPetListComponent>().PetHeXinSetComponent.OnButtonEquipHeXin();
        }

        public static void  OnClickPageButton(this UIPetComponent self, int page)
        {
             self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void OnBagItemUpdate(this UIPetComponent self)
        {
            UI uI = self.UIPageView.UISubViewList[(int)PetPageEnum.PetList];
            uI.GetComponent<UIPetListComponent>().OnBagItemUpdate();
        }

        public static void OnEquipPetHeXin(this UIPetComponent self)
        {
            UI uI = self.UIPageView.UISubViewList[(int)PetPageEnum.PetList];
            uI.GetComponent<UIPetListComponent>().OnEquipPetHeXin();
        }
    }
}