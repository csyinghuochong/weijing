using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UnitGuaJiComponentSystemAwake : AwakeSystem<UnitGuaJiComponen>
    {
        public override void Awake(UnitGuaJiComponen self)
        { 
            
            //显示主界面显示
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().UGuaJiSet.SetActive(true);
            self.UIMain = uimain;

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            string acttype = userInfoComponent.GetGameSettingValue(GameSettingEnum.GuaJiSell);
            self.IfSellStatus = acttype == "1";

            acttype = userInfoComponent.GetGameSettingValue(GameSettingEnum.GuaJiRang);
            self.IfGuaJiRange = acttype == "1";

            acttype = userInfoComponent.GetGameSettingValue(GameSettingEnum.GuaJiAutoUseItem);
            self.IfGuaJiAutoUseItem = acttype == "1";
            
            //触发挂机
            self.ActTarget();

            //触发时间间隔
            self.TimeTriggerActTarget().Coroutine();

            //初始化序列号列表
            self.InitXuHaoID();
        }
    }

    public class UnitGuaJiComponentSystemDestroy : DestroySystem<UnitGuaJiComponen>
    {
        public override void Destroy(UnitGuaJiComponen self)
        {
            
        }
    }

    public static class UnitGuaJiComponentSystem
    {
        //初始化ID
        public static void InitXuHaoID(this UnitGuaJiComponen self)
        {

            self.skillXuHaoList = new List<int>();
            //获取对应ID
            for (int i = 0; i <= 7; i++)
            {
                int skillid = self.UIMain.GetComponent<UIMainComponent>().UIMainSkillComponent.UISkillGirdList[i].GetSkillId();
                if (skillid != 0)
                {
                    self.skillXuHaoList.Add(i);
                }
            }
        }

        //触发挂机目标
        public static bool ActTarget(this UnitGuaJiComponen self)
        {
            //获取场景,如果当前在主城自动取消
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneId == 101)
            {
                FloatTipManager.Instance.ShowFloatTip("主城禁止挂机喔,已为你自动移除挂机!");
                self.ZoneScene().RemoveComponent<UnitGuaJiComponen>();      //移除体力组件
                return false;
            }
            //判断是否有体力,没体力不能挂机,减少服务器开销
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.PiLao <= 0)
            {
                FloatTipManager.Instance.ShowFloatTip("体力已经消耗完毕,请确保体力充足喔!");
                self.ZoneScene().RemoveComponent<UnitGuaJiComponen>();      //移除体力组件
                return false;
            };

            //判定攻击目标是否有攻击目标
            //self.ZoneScene().GetComponent<SkillIndicatorComponent>().ShowCommonAttackZhishi();        //展示攻击范围
            self.UIMain.GetComponent<UIMainComponent>().UIMainSkillComponent.UIAttackGrid.PointerUp(null);

            //获取当前攻击目标
            //Log.ILog.Debug("LastLockId = " + self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId);
            //Log.ILog.Debug("LastLockIndex = " + self.ZoneScene().GetComponent<LockTargetComponent>().LastLockIndex);

            self.forNum = 0;

            if (self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId == 0)
            {
                //表示附近没有玩家,给服务器发送消息
                self.MoveStatus = true;
                self.MovePosition(1000).Coroutine();        //1秒后执行,防止普通攻击有冷却时间延迟
                return false;
            }
            else
            {
                //进入攻击状态
                self.FightStatus = true;
            }

            self.MoveStatus = false;        //关闭自动移动状态
            return true;
        }

        public static void OnCreateUnit(this UnitGuaJiComponen self, Unit unit)
        { 
            if (unit.Id != self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId)
            {
                return;
            }

            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
            self.ZoneScene().GetComponent<AttackComponent>().BeginAutoAttack(unit.Id);
        }

        public static async ETTask KillMonster(this UnitGuaJiComponen self)
        {
            self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId = 0;
            self.FightStatus = false;

            //原地等待0.5秒拾取道具
            long instanceid = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(500);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            self.ShiQu();
            //执行下次攻击
            self.ActTarget();
            
        }

        public static bool ifBaseHpSkill(this UnitGuaJiComponen self, int useSkillID)
        {

            if (useSkillID == 60000001 || useSkillID == 60000002 || useSkillID == 60000003 || useSkillID == 60000004 || useSkillID == 60000005 || useSkillID == 60000031 || useSkillID == 60000032 || useSkillID == 60000033 || useSkillID == 60000034 || useSkillID == 60000035 || useSkillID == 65001001 || useSkillID == 65002001 || useSkillID == 65003001 || useSkillID == 65004001 || useSkillID == 60000035 || useSkillID == 65005001 || useSkillID == 65006001)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool UseItem(this UnitGuaJiComponen self, int itemID)
        {

            BagComponent bagCompont = self.ZoneScene().GetComponent<BagComponent>();
            BagInfo baginfo = bagCompont.GetBagInfo(itemID);
            if (baginfo != null)
            {
                bagCompont.SendUseItem(baginfo).Coroutine();
                return true;
            }
            else
            {
                return false;
            }
        }


        //触发挂机持续执行间隔
        public static async ETTask TimeTriggerActTarget(this UnitGuaJiComponen self)
        {

            int goNum = 0;
            long instanceid = self.InstanceId;
            for (self.forNum = 0; self.forNum < 100; self.forNum++)
            {

                //每10秒执行一次
                await TimerComponent.Instance.WaitAsync(3000);
                if (instanceid != self.InstanceId)
                {
                    break;
                }

                goNum++;
                if (goNum >= 10)
                {
                    goNum = 0;
                    bool ifAct = self.ActTarget();
                    //如果当前没有攻击,就返回false
                    if (ifAct == false)
                    {
                        if (self.MoveStatus == false && self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId == 0)
                        {
                            //如果当前不是移动状态,且目标ID为0
                            self.MovePosition().Coroutine();
                        }
                    }
                }

                //每秒使用一次技能
                self.UseSkill().Coroutine();

            }


            await ETTask.CompletedTask;
            return;
        }


        public static async ETTask MovePosition(this UnitGuaJiComponen self, int yanchiTime = 0)
        {

            //原地挂机不向服务器请求
            if (self.IfGuaJiRange)
            {
                return;
            }

            if (yanchiTime > 0)
            {
                await TimerComponent.Instance.WaitAsync(yanchiTime);
            }

            if (self.IsDisposed)
            {
                return;
            }

            C2M_FindNearMonsterRequest c2M_FindNearMonsterRequest = new C2M_FindNearMonsterRequest();
            M2C_FindNearMonsterResponse m2C_FindNearMonsterResponse = (M2C_FindNearMonsterResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_FindNearMonsterRequest);

            if (self.IsDisposed)
            {
                return;
            }
            if (m2C_FindNearMonsterResponse.IfFindStatus == true)
            {
                self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId = m2C_FindNearMonsterResponse.MonsterID;
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                int ifSucc = await unit.MoveToAsync2(new Vector3(m2C_FindNearMonsterResponse.x, m2C_FindNearMonsterResponse.y, m2C_FindNearMonsterResponse.z));
                if (self.IsDisposed)
                {
                    return;
                }
                if (ifSucc == 0)
                {
                    self.ActTarget();
                }
            }
            else
            {
                FloatTipManager.Instance.ShowFloatTip("附近未发现怪物");
            }

            return;
        }

        public static void ShiQu(this UnitGuaJiComponen self)
        {

            //点一下拾取按钮
            self.UIMain.GetComponent<UIMainComponent>().UIMainSkillComponent.OnShiquItem();

            //判断背包是否满了
            if (self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace() <= 0)
            {

                //如果满了就一键出售(此处看玩家是否勾选)
                if (self.IfSellStatus)
                {
                    //一键出售
                    self.ZoneScene().GetComponent<BagComponent>().RequestOneSell(ItemLocType.ItemLocBag).Coroutine();
                    HintHelp.GetInstance().ShowHint("背包已满，已自动一键出售道具!");
                }
            }
        }

        //使用技能
        public async static ETTask UseSkill(this UnitGuaJiComponen self)
        {
            //获取当前血量低于60%,使用药剂
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            float nowHp = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Hp);
            float maxHp = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_MaxHp);
            if (self.IfGuaJiAutoUseItem && nowHp / maxHp <= 0.6f)
            {

                UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
                bool ifUse = false;

                //使用第8格
                int useSkillID = uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.UISkillGirdList[8].GetSkillId();
                if (self.ifBaseHpSkill(useSkillID))
                {
                    UISkillGridComponent uiSkillGridComponent = uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.UISkillGirdList[8];
                    uiSkillGridComponent.OnPointDown(null);
                    uiSkillGridComponent.PointerUp(null);
                    ifUse = true;
                }

                //使用第9格
                useSkillID = uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.UISkillGirdList[9].GetSkillId();
                if (ifUse == false && self.ifBaseHpSkill(useSkillID))
                {
                    UISkillGridComponent uiSkillGridComponent = uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.UISkillGirdList[9];
                    uiSkillGridComponent.OnPointDown(null);
                    uiSkillGridComponent.PointerUp(null);
                }
            }

            if (self.FightStatus)
            {
                int grid = self.skillXuHaoList[self.XuHaoNum];
                UIMainSkillComponent uIMainSkillComponent = self.UIMain.GetComponent<UIMainComponent>().UIMainSkillComponent;

                int useSkillID = uIMainSkillComponent.UISkillGirdList[grid].GetSkillId();
                if (useSkillID != 0)
                {
                    //Debug.Log("useSkillID = " + useSkillID);
                    uIMainSkillComponent.UISkillGirdList[grid].OnPointDown(null);
                    await TimerComponent.Instance.WaitAsync(100);
                    uIMainSkillComponent.UISkillGirdList[grid].PointerUp(null);
                }

                self.XuHaoNum++;
                if (self.XuHaoNum > self.skillXuHaoList.Count)
                {
                    self.XuHaoNum = 0;
                }
            }
        }

    }
}
