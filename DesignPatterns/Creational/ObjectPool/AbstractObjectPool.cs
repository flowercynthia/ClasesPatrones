using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool
{
    public abstract class AbstractObjectPool<T> : IObjectPool<T> where T : class, new()
    {
        public long ExpirationTime { get; protected set; }
        protected Dictionary<T, long> Locked { get; set; }
        protected Dictionary<T, long> Unlocked { get; set; }

        public AbstractObjectPool()
        {
            this.ExpirationTime = 30000;
            this.Locked = new Dictionary<T, long>();
            this.Unlocked = new Dictionary<T, long>();
        }
        public void CheckIn(T obj)
        {
            Locked.Remove(obj);
            Unlocked.Add(obj, DateTime.Now.Ticks);
        }
        public T CheckOut() {
            long now = DateTime.Now.Ticks;
            T obj = null;
            if(Unlocked.Count > 0)
            {
                foreach (var keyval in Unlocked)
                {
                    obj = keyval.Key;
                    if (now - keyval.Value > ExpirationTime)
                    {
                        Unlocked.Remove(obj);
                        Expire(obj);
                        obj = null;
                    }
                    else
                    {
                        if (Validate(obj))
                        {
                            Unlocked.Remove(obj);
                            Locked.Add(obj, now);
                            return obj;
                        }
                        else
                        {
                            Unlocked.Remove(obj);
                            Expire(obj);
                            obj = null;
                        }
                    }
                }
            }
            obj = Create();
            Locked.Add(obj, now);
            return obj;
        }
        public abstract T Create();
        public abstract void Expire(T obj);
        public abstract bool Validate(T obj);
    }
}
