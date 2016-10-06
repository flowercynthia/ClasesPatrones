using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class ChickenHamburgerBuilder : AbstractHamburgerBuilder
    {
        public override void BuildBread()
        {
            this.hamburger.Bread = "White Bread";
        }

        public override void BuildComplement()
        {
            this.hamburger.Complement = "Ranch Sauce";
        }

        public override void BuildMeat()
        {
            this.hamburger.Meat = "Chicken Meat";
        }
    }
}
