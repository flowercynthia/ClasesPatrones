using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.AbstractFactory.Armor;
using DesignPatterns.Creational.AbstractFactory.Helmet;
using DesignPatterns.Creational.AbstractFactory.Weapon;
using DesignPatterns.Creational.AbstractFactory.Warrior;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class AbstractWarriorFactory : IWarriorFactory
    {
        public abstract AbstractArmor CreateArmor();
        public abstract AbstractHelmet CreateHelmet();
        public abstract AbstractWeapon CreateWeapon();

        public static AbstractWarriorFactory GetFactory(AbstractWarrior warrior)
        {
            switch (warrior.Type) {
                case AbstractWarrior.WarriorType.Babarian:
                    return new BabarianWarriorFactory();
                case AbstractWarrior.WarriorType.MedievalKnight:
                    return new MedievalKnightWarriorFactory();
                case AbstractWarrior.WarriorType.RomanSoldier:
                    return new RomanWarriorFactory();
                case AbstractWarrior.WarriorType.Samurai:
                    return new SamuraiWarriorFactory();
                default:
                    return null;
            }
        }
    }
}
