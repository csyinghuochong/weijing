using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class MonoPool: IDisposable
    {
        private readonly Dictionary<Type, Queue<object>> pool = new Dictionary<Type, Queue<object>>();
        
        public static MonoPool Instance = new MonoPool();
        
        private MonoPool()
        {
        }

        public object Fetch(Type type)
        {
            Queue<object> queue = null;
            if (!pool.TryGetValue(type, out queue))
            {
                return Activator.CreateInstance(type);
            }

            if (queue.Count == 0)
            {
                return Activator.CreateInstance(type);
            }
            return queue.Dequeue();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in pool)
            {
                sb.AppendLine($"\t    {item.Key.Name}:      \t{item.Value.Count}");
            }
            return sb.ToString();
        }

        public void Recycle(object obj)
        {
            Type type = obj.GetType();
            Queue<object> queue = null;
            if (!pool.TryGetValue(type, out queue))
            {
                queue = new Queue<object>();
                pool.Add(type, queue);
            }
            queue.Enqueue(obj);
        }

        public void Dispose()
        {
            this.pool.Clear();
        }
    }
}