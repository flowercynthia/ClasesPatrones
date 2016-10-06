using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.AbstractFactory.Armor;
using DesignPatterns.Creational.AbstractFactory.Helmet;
using DesignPatterns.Creational.AbstractFactory.Weapon;

namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IWarriorFactory
    {
        AbstractArmor CreateArmor();
        AbstractHelmet CreateHelmet();
        AbstractWeapon CreateWeapon();
    }
}
