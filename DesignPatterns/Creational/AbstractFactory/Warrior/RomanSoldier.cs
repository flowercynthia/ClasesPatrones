using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Warrior
{
    public class RomanSoldier : AbstractWarrior
    {
        public override WarriorType Type
        {
            get
            {
                return WarriorType.RomanSoldier;
            }
        }
        public override void Jump()
        {
            Console.WriteLine("Roman Jumping");
        }

        public override void Kick()
        {
            Console.WriteLine("Roman Kicking");
        }

        public override void Punch()
        {
            Console.WriteLine("Roman Punching");
        }

        public override void Run()
        {
            Console.WriteLine("Roman Running");
        }
    }
}
