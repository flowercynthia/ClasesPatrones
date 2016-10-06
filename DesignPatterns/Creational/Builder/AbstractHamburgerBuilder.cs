using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public abstract class AbstractHamburgerBuilder : IHamburgerBuilder
    {
        protected Hamburger hamburger { get; set; }

        public abstract void BuildBread();
        public abstract void BuildComplement();
        public abstract void BuildMeat();
        public void CreateHamburger() {
            hamburger = new Hamburger();
        }
        public Hamburger GetHamburger()
        {
            return hamburger;
        }
    }
}
