using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Warrior
{
    public interface IWarrior
    {
        void Kick();
        void Punch();
        void Jump();
        void Run();
        void Fire(object target);
    }
}
