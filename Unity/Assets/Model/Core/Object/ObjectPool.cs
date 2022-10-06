using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ObjectPool: IDisposable
    {
        private readonly Dictionary<Type, Queue<Entity>> pool = new Dictionary<Type, Queue<Entity>>();
        
        public static ObjectPool Instance = new ObjectPool();
        
        private ObjectPool()
        {
        }

        public Entity Fetch(Type type)
        {
            Queue<Entity> queue = null;
            if (!pool.TryGetValue(type, out queue))
            {
                return Activator.CreateInstance(type) as Entity;
            }

            if (queue.Count == 0)
            {
                return Activator.CreateInstance(type) as Entity;
            }
            return queue.Dequeue();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in pool)
            {
                sb.AppendLine($"\t{item.Key.Name}: {item.Value.Count}");
            }
            return sb.ToString();
        }

        public void Recycle(Entity obj)
        {
            Type type = obj.GetType();
            Queue<Entity> queue = null;
            if (!pool.TryGetValue(type, out queue))
            {
                queue = new Queue<Entity>();
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