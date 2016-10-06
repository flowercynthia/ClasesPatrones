using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Warrior
{
    public class MedievalKnight : AbstractWarrior
    {
        public override WarriorType Type
        {
            get
            {
                return WarriorType.MedievalKnight;
            }
        }
        public override void Jump()
        {
            Console.WriteLine("Knight Jumping");
        }

        public override void Kick()
        {
            Console.WriteLine("Knight Kicking");
        }

        public override void Punch()
        {
            Console.WriteLine("Knight Punching");
        }

        public override void Run()
        {
            Console.WriteLine("Knight Running");
        }
    }
}
