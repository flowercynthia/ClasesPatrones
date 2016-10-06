using DesignPatterns.Creational.AbstractFactory.Armor;
using DesignPatterns.Creational.AbstractFactory.Helmet;
using DesignPatterns.Creational.AbstractFactory.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Warrior
{
    public abstract class AbstractWarrior : IWarrior
    {
        public AbstractArmor Armor { get; set; }
        public AbstractHelmet Helmet { get; set; }
        public AbstractWeapon Weapon { get; set; }

        public virtual WarriorType Type { get; }
        public virtual void Fire(object target) {
            this.Weapon.Execute(target);
        }
        public abstract void Jump();
        public abstract void Kick();
        public abstract void Punch();
        public abstract void Run();

        public enum WarriorType { RomanSoldier, MedievalKnight, Babarian, Samurai }

    }
}
