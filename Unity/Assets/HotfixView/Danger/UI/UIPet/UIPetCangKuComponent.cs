using ET;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPetCangKuComponent : Entity, IAwake, IDestroy
{
    public GameObject BuildingList;
    public GameObject PetListNode;
    public GameObject ButtonClose;

    public List<UIPetCangKuDefendComponent> UIDefendList = new List<UIPetCangKuDefendComponent>();
    public List<UIPetCangKuItemComponent> UICangKuItemList = new List<UIPetCangKuItemComponent>();
}

public class UIPetCangKuComponentAwake : AwakeSystem<UIPetCangKuComponent>
{
    public override void Awake(UIPetCangKuComponent self)
    {
        ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
        self.BuildingList = rc.Get<GameObject>("BuildingList");
        self.PetListNode = rc.Get<GameObject>("PetListNode");
        self.ButtonClose = rc.Get<GameObject>("ButtonClose");

        self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => {  UIHelper.Remove( self.ZoneScene(), UIType.UIPetCangKu );  } );
    }
}

public static class UIPetCangKuComponentSystem
{
    public static  void OnInitUI(this UIPetCangKuComponent self)
    {
        self.UpdatePetCangKuDefend().Coroutine();
        self.UpdatePetCangKuItemList().Coroutine();
    }

    public static async ETTask UpdatePetCangKuDefend(this UIPetCangKuComponent self)
    {
        long instanceid = self.InstanceId;
        var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetCangKuDefend");
        var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
        if (instanceid != self.InstanceId)
        {
            return;
        }

        UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
        JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfoComponent.UserInfo.JiaYuanLv);
        int petNum = jiaYuanConfig.PetNum;
    }

    public static async ETTask UpdatePetCangKuItemList(this UIPetCangKuComponent self)
    {
        await ETTask.CompletedTask;
    }
}