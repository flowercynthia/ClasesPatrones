using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class TradicionalHamburguerBuilder : AbstractHamburgerBuilder
    {
        public override void BuildBread()
        {
            this.hamburger.Bread = "Ajonjoli Bread";
        }

        public override void BuildComplement()
        {
            this.hamburger.Complement = "Barcoa Sauce";
        }

        public override void BuildMeat()
        {
            this.hamburger.Meat = "Cow Meat";
        }
    }
}
