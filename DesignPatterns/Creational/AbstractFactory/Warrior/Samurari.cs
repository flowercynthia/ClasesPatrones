using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Warrior
{
    public class Samurari : AbstractWarrior
    {
        public override WarriorType Type
        {
            get
            {
                return WarriorType.Samurai;
            }
        }
        public override void Jump()
        {
            Console.WriteLine("Samurai Jumping");
        }

        public override void Kick()
        {
            Console.WriteLine("Samurai Kicking");
        }

        public override void Punch()
        {
            Console.WriteLine("Samurai Punching");
        }

        public override void Run()
        {
            Console.WriteLine("Samurai Running");
        }
    }
}
