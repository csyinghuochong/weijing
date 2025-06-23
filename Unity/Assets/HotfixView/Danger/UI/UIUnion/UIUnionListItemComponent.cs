using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionListItemComponent : Entity, IAwake<GameObject>, IDestroy
    {

        public GameObject Text_Level;
        public GameObject ButtonApply;
        public GameObject Text_Request;
        public GameObject Text_Number;
        public GameObject Text_Name;
        public GameObject GameObject;
        public GameObject Text_Leader;

        public UnionListItem UnionListItem;
    }


    public class UIUnionListItemComponentAwakeSystem : AwakeSystem<UIUnionListItemComponent, GameObject>
    {
        public override void Awake(UIUnionListItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ButtonApply = rc.Get<GameObject>("ButtonApply");
            ButtonHelp.AddListenerEx( self.ButtonApply, () => { self.OnButtonApply().Coroutine(); } );

            self.Text_Level = rc.Get<GameObject>("Text_Level");
            self.Text_Request = rc.Get<GameObject>("Text_Request");
            self.Text_Number = rc.Get<GameObject>("Text_Number");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_Leader = rc.Get<GameObject>("Text_Leader");
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UIUnionListItemComponentDestroySystem : DestroySystem<UIUnionListItemComponent>
    {
        public override void Destroy(UIUnionListItemComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UIUnionListItemComponentSystem
    {
        public static void OnLanguageUpdate(this UIUnionListItemComponent self)
        {
            self.Text_Name.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 28;
            self.Text_Level.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 28;
            self.Text_Number.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 28;
            self.Text_Leader.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 28;
            self.Text_Request.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 28;
        }

        public static async ETTask OnButtonApply(this UIUnionListItemComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long unionId = numericComponent.GetAsLong(NumericType.UnionId_0);
            if (unionId != 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请先退出公会"));
                return;
            }
            long leaveTime = numericComponent.GetAsLong(NumericType.UnionIdLeaveTime);
            if (TimeHelper.ServerNow()- leaveTime < TimeHelper.Hour * 8)
            {
                string tip = UICommonHelper.ShowLeftTime(TimeHelper.Hour * 8 - (TimeHelper.ServerNow() - leaveTime), GameSettingLanguge.Language);
                FloatTipManager.Instance.ShowFloatTip(string.Format(GameSettingLanguge.LoadLocalization("{0} 后才能加入家族！"), tip));
                return;
            }

            C2U_UnionApplyRequest c2M_ItemHuiShouRequest = new C2U_UnionApplyRequest()
            {
                UnionId = self.UnionListItem.UnionId,
                UserId = unit.Id
            };
            U2C_UnionApplyResponse r2c_roleEquip = (U2C_UnionApplyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            if (self.IsDisposed)
            {
                return; 
            }
            FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("已申请加入"));
        }

        public static void OnUpdateUI(this UIUnionListItemComponent self, UnionListItem unionListItem)
        {
            self.UnionListItem = unionListItem;
            unionListItem.UnionLevel =  Math.Max(unionListItem.UnionLevel, 1);
            int peopleMax = UnionConfigCategory.Instance.Get(unionListItem.UnionLevel).PeopleNum;
            self.Text_Request.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("等级达到1级");
            self.Text_Number.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("人数 {0}/{1}"), unionListItem.PlayerNumber, peopleMax);
            self.Text_Name.GetComponent<Text>().text = unionListItem.UnionName;
            self.Text_Leader.GetComponent<Text>().text = unionListItem.UnionLeader;
            self.Text_Level.GetComponent<Text>().text = unionListItem.UnionLevel.ToString();
        }
    }
}
