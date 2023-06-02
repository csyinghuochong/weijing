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
        await ETTask.CompletedTask;
    }

    public static async ETTask UpdatePetCangKuItemList(this UIPetCangKuComponent self)
    {
        await ETTask.CompletedTask;
    }
}