using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Weapon
{
    public abstract class AbstractWeapon : IWeapon
    {
        public abstract void Execute(object target);
    }
}
