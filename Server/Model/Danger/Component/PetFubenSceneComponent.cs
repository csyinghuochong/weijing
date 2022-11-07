using System;


namespace ET
{
    public class PetFubenSceneComponent : Entity, IAwake, IDestroy
    {
        public Unit MainUnit;
        public long Timer;
    }
}
