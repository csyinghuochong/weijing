namespace ET
{
    public class Singleton<T> where T : new()
    {
        protected static T sInstance;

        static void CreateInstance()
        {
            sInstance = (default(T) == null) ? new T() : default(T);
        }

        public static T Instance
        {
            get
            {
                if (sInstance == null)
                {
                    CreateInstance();
                }

                return sInstance;
            }
        }

        protected Singleton()
        {
            InternalInit();
        }

        protected virtual void InternalInit()
        {

        }

        protected virtual void Recreate()
        {
            CreateInstance();
        }
    }
}
