using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class SpicyHamburgerBuilder : AbstractHamburgerBuilder
    {
        public override void BuildBread()
        {
            this.hamburger.Bread = "Integral Bread";
        }

        public override void BuildComplement()
        {
            this.hamburger.Complement = "Spicy Sauce";
        }

        public override void BuildMeat()
        {
            this.hamburger.Meat = "Cow Meat";
        }
    }
}
