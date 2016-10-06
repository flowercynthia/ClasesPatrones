using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public interface IHamburgerBuilder
    {
        void CreateHamburger();
        void BuildBread();
        void BuildMeat();
        void BuildComplement();
        Hamburger GetHamburger();
    }
}
