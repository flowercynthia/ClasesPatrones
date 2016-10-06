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
    public class RomanWarriorFactory : AbstractWarriorFactory
    {
        public override AbstractArmor CreateArmor()
        {
            return new RomanArmor();
        }

        public override AbstractHelmet CreateHelmet()
        {
            return new RomanHelmet();
        }

        public override AbstractWeapon CreateWeapon()
        {
            return new Gladius();
        }
    }
}
