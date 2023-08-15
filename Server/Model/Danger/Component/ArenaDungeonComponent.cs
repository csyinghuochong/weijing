namespace ET
{

    public class ArenaDungeonComponent : Entity, IAwake, IDestroy
    {

        public bool ArenaClose = false;
        public M2C_AreneInfoResult M2C_AreneInfoResult = new M2C_AreneInfoResult();
    }
}
