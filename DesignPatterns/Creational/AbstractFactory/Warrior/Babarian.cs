using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Warrior
{
    public class Babarian : AbstractWarrior
    {
        public override WarriorType Type
        {
            get
            {
                return WarriorType.Babarian;
            }
        }
        public override void Jump()
        {
            Console.WriteLine("Babarian Jumping");
        }

        public override void Kick()
        {
            Console.WriteLine("Babarian Kicking");
        }

        public override void Punch()
        {
            Console.WriteLine("Babarian Punching");
        }

        public override void Run()
        {
            Console.WriteLine("Babarian Running");
        }
    }
}
