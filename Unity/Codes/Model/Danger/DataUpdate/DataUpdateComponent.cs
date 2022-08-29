namespace ET
{
    public class DataUpdateComponent : Entity, IAwake
    {
        public MultiDictionary<int, long, Entity> DataUpdateComponents = new MultiDictionary<int, long, Entity>();

        public static DataUpdateComponent Instance { get; set; }
    }
}