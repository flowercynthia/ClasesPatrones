using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class HamburgerChef
    {
        public IHamburgerBuilder hamBuilder { private get; set; }

        public Hamburger hamburger { get { return this.hamBuilder.GetHamburger(); } }

        public void BuildHamburger()
        {
            hamBuilder.CreateHamburger();
            hamBuilder.BuildBread();
            hamBuilder.BuildMeat();
            hamBuilder.BuildComplement();
        }
    }
}
