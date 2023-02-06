using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetHeChengComponent : Entity, IAwake
    {
        public GameObject PetInfo2;
        public GameObject PetInfo1;
        public GameObject Btn_HeCheng;

        public RolePetInfo HeChengPet_Left;
        public RolePetInfo HeChengPet_Right;

        public UIPetInfoShowComponent UIPetInfoShowComponent_1;
        public UIPetInfoShowComponent UIPetInfoShowComponent_2;
    }

    [ObjectSystem]
    public class UIPetHeChengComponentAwakeSystem : AwakeSystem<UIPetHeChengComponent>
    {
        public override void Awake(UIPetHeChengComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.PetInfo2 = rc.Get<GameObject>("PetInfo2");
            self.PetInfo1 = rc.Get<GameObject>("PetInfo1");

            self.Btn_HeCheng = rc.Get<GameObject>("Btn_HeCheng");
            self.Btn_HeCheng.GetComponent<Button>().onClick.AddListener(() => { self.OnClickHeCheng(); });

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.OnInitSubView();
        }
    }

    public static class UIPetHeChengComponentSystem
    {

        public static List<long> GetSelectedPet(this UIPetHeChengComponent self)
        {
            List<long> selected = new List<long>();
            if (self.HeChengPet_Left != null)
                selected.Add(self.HeChengPet_Left.Id);
            if (self.HeChengPet_Right != null)
                selected.Add(self.HeChengPet_Right.Id);
            return selected;
        }

        public static void OnUpdateUI(this UIPetHeChengComponent self)
        {
            self.HeChengPet_Left = null;
            self.HeChengPet_Right = null;
            self.UIPetInfoShowComponent_1.OnInitData(null);
            self.UIPetInfoShowComponent_2.OnInitData(null);
        }

        public static  void OnClickHeCheng(this UIPetHeChengComponent self)
        {
            if (self.HeChengPet_Left == null || self.HeChengPet_Right == null)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择要合成的宠物！");
                return;
            }
            bool havepetHexin = false;
            for (int i = 0; i < self.HeChengPet_Left.PetHeXinList.Count; i++)
            {
                if (self.HeChengPet_Left.PetHeXinList[i]!= 0)
                {
                    havepetHexin = true;
                    break;
                }
            }
            for (int i = 0; i < self.HeChengPet_Right.PetHeXinList.Count; i++)
            {
                if (self.HeChengPet_Right.PetHeXinList[i] != 0)
                {
                    havepetHexin = true;
                    break;
                }
            }
            string addStr = havepetHexin ? "当前宠物身上穿戴的宠物之核将消失," : "";

            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "宠物合成",
                $"合成后将随机保留一个宠物，另外一个宠物会销毁,{addStr} 请确认是否执行合成",
                () => {
                    self.ReqestHeCheng().Coroutine();
                }).Coroutine();
        }

        public static async ETTask ReqestHeCheng(this UIPetHeChengComponent self)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            List<KeyValuePair> oldPetSkin = petComponent.GetPetSkinCopy();
            C2M_RolePetHeCheng c2M_RolePetHeCheng = new C2M_RolePetHeCheng() { PetInfoId1 = self.HeChengPet_Left.Id, PetInfoId2 = self.HeChengPet_Right.Id };
            M2C_RolePetHeCheng m2C_RolePetHeCheng = (M2C_RolePetHeCheng)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetHeCheng);
            if (m2C_RolePetHeCheng.Error != 0 || m2C_RolePetHeCheng.rolePetInfo == null)
            {
                return;
            }

            long instanceId = self.InstanceId;
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIPetChouKaGet);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            uI.GetComponent<UIPetChouKaGetComponent>().OnInitUI(m2C_RolePetHeCheng.rolePetInfo, oldPetSkin, false);
            self.ZoneScene().GetComponent<PetComponent>().OnRecvHeCheng(m2C_RolePetHeCheng);
        }

        public static void OnHeChengReturn(this UIPetHeChengComponent self)
        {
            self.UIPetInfoShowComponent_1.OnInitData(null);
            self.UIPetInfoShowComponent_2.OnInitData(null);
        }

        public static void OnHeChengSelect(this UIPetHeChengComponent self, RolePetInfo rolePetInfo)
        {
            UI uIpet = UIHelper.GetUI( self.ZoneScene(), UIType.UIPet );
            if (uIpet.GetComponent<UIPetComponent>().PetItemWeizhi == -1)
            {
                self.HeChengPet_Left = rolePetInfo;
                self.UIPetInfoShowComponent_1.OnInitData(self.HeChengPet_Left);
            }
            else
            {
                self.HeChengPet_Right = rolePetInfo;
                self.UIPetInfoShowComponent_2.OnInitData(self.HeChengPet_Right);
            }
        }

        public static  void OnInitSubView(this UIPetHeChengComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetInfoShow");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            self.UIPetInfoShowComponent_1 = self.AddChild<UIPetInfoShowComponent, GameObject>(UnityEngine.Object.Instantiate(bundleGameObject));
            self.UIPetInfoShowComponent_1.Weizhi = -1;
            self.UIPetInfoShowComponent_1.BagOperationType = PetOperationType.HeCheng;

            self.UIPetInfoShowComponent_2 = self.AddChild<UIPetInfoShowComponent, GameObject>(UnityEngine.Object.Instantiate(bundleGameObject));
            self.UIPetInfoShowComponent_2.Weizhi = 1;
            self.UIPetInfoShowComponent_2.BagOperationType = PetOperationType.HeCheng;

            UICommonHelper.SetParent(self.UIPetInfoShowComponent_1.GameObject, self.PetInfo1);
            UICommonHelper.SetParent(self.UIPetInfoShowComponent_2.GameObject, self.PetInfo2);

            self.UIPetInfoShowComponent_1.OnInitData(null);
            self.UIPetInfoShowComponent_2.OnInitData(null);
        }

    }

}
