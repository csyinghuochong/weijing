using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

namespace ET
{

    public class UIRoleQiangHuaTipComponent : Entity, IAwake
    {
        public GameObject ScaleNode;
        public GameObject ImageButton;
        public GameObject Text_Tip;
    }

    public class UIRoleQiangHuaTipComponentAwake : AwakeSystem<UIRoleQiangHuaTipComponent>
    {
        public override void Awake(UIRoleQiangHuaTipComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ScaleNode = rc.Get<GameObject>("ScaleNode");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Remove( self.ZoneScene(), UIType.UIRoleQiangHuaTip );
            });
            self.ScaleNode.GetComponent<RectTransform>().sizeDelta = new Vector2 ( 0, 0 );
            self.ScaleNode.transform.localScale = Vector2.zero;
            self.Text_Tip = rc.Get<GameObject>("Text_Tip");
        }
    }

    public static class UIRoleQiangHuaTipComponentSystem
    {

        public static void OnUpdateUI(this UIRoleQiangHuaTipComponent self, int subType, int qianghuaLv)
        {

            string tip = $"当前部位强化至{qianghuaLv}级";
            self.Text_Tip.GetComponent<Text>().text = tip ;
            UICommonHelper.DOScale(self.ScaleNode.transform, Vector3.one, 0.5f);
        }

    }
}