using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool
{
    public interface IObjectPool<T> where T : class, new()
    {
        T Create();
        bool Validate(T obj);
        void Expire(T obj);
        T CheckOut();
        void CheckIn(T obj);
    }
}
