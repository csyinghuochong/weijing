using UnityEngine;

namespace ET
{

    //全地图随机子弹
    public class Skill_ComTargetMove_RangDamge_4 : SkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();

            string[] paraminfos = this.SkillConf.GameObjectParameter.Split('@');
            using ListComponent<Vector3> vector3s = new ListComponent<Vector3>(); 
            for (int i = 0; i < paraminfos.Length; i++)
            {
                string[] posinfo = paraminfos[i].Split(';');
                vector3s.Add(new Vector3(float.Parse(posinfo[0]), float.Parse(posinfo[1]), float.Parse(posinfo[2])));
            }
            int startindex = RandomHelper.RandomNumber(0, vector3s.Count);
            Vector3 startpos = vector3s[startindex];

            vector3s.RemoveAt(startindex);

            int endindex = RandomHelper.RandomNumber(0, vector3s.Count);
            Vector3 targetpos = vector3s[endindex];

            //创建一个Unit添加子弹组件向目标点移动
            Unit unit = UnitFactory.CreateBullet(this.TheUnitFrom.DomainScene(), this.TheUnitFrom.Id, this.SkillConf.Id, 0, startpos, new CreateMonsterInfo());
            unit.AddComponent<RoleBullet1Componnet>().OnBaseBulletInit(this, this.TheUnitFrom.Id);
            unit.BulletMoveToAsync(targetpos).Coroutine();
        }

        public override void OnUpdate()
        {
            if (TimeHelper.ServerNow() > SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}
