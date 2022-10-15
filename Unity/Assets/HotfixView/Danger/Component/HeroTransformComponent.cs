using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ObjectSystem]
    public class HeroTransformComponentAwakeSystem : AwakeSystem<HeroTransformComponent>
    {
        public override void Awake(HeroTransformComponent self)
        {
            self.Awake();
        }
    }

    /// <summary>
    /// 英雄的位置组件，主要用于让外部取得想要的位置，从而做一些操作
    /// 例如特效的插拔
    /// </summary>
    public class HeroTransformComponent: Entity, IAwake
    {
        private Unit MyHero;
        private Transform namePos;
        private Transform pos_di;
        private Transform pos_center;
        private Transform pos_Head;
        private Transform middleBuffPos;
        public GameObject RunEffect;
        public Transform pos_Hand;

        public void Awake()
        {
            this.MyHero = this.GetParent<Unit>();
            Transform transform = this.MyHero.GetComponent<GameObjectComponent>().GameObject.transform;
            Transform roleBoneSetTra = transform.Find("RoleBoneSet");
            this.middleBuffPos = transform;
            if (roleBoneSetTra != null)
            {
                this.namePos = transform.Find("NamePoint");
                this.pos_di = roleBoneSetTra.Find("Di");
                this.pos_center = roleBoneSetTra.Find("Center");
                this.pos_Head = roleBoneSetTra.Find("Head");
                this.pos_Hand = roleBoneSetTra.Find("pos_Hand");
            }
            else
            {
                this.namePos = transform;
                this.pos_di = transform;
                this.pos_center = transform;
                this.pos_Head = transform;
                this.pos_Hand = transform;
            }

            this.RunEffect = null;
            int unitType = this.MyHero.GetComponent<UnitInfoComponent>().Type;
            //获取自身的绑点
            if (unitType == UnitType.Player)
            {
                this.RunEffect = this.MyHero.GetComponent<GameObjectComponent>().GameObject.transform.Find("RoseRunEffect").gameObject;
            }
        }

        public void ShowRunEffect()
        {
            if (this.RunEffect == null)
            {
                return;
            }
            this.RunEffect.SetActive(true);
            this.RunEffect.GetComponent<ParticleSystem>().Play();
        }

        /// <summary>
        /// 获取目标位置
        /// </summary>
        /// <param name="posType"></param>
        /// <returns></returns>
        public Transform GetTranform(PosType posType)
        {
            switch (posType)
            {
                case PosType.Name:
                    return this.namePos;
                case PosType.MiddleBuff:
                    return this.middleBuffPos;

                case PosType.Di:
                    return this.pos_di;
                    //break;

                case PosType.Center:
                    return this.pos_center;
                    //break;

                case PosType.Head:
                    return this.pos_Head;
                    //break;

                case PosType.Hand:
                    return this.pos_Hand;
                //break;

            }
            return null;
        }
    }
}