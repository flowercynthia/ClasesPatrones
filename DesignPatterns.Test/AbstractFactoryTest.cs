using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.AbstractFactory.Warrior;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.Armor;
using DesignPatterns.Creational.AbstractFactory.Helmet;
using DesignPatterns.Creational.AbstractFactory.Weapon;

namespace DesignPatterns.Test
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var barbaro = TestWarrior(new Babarian());
            var samurai = TestWarrior(new Samurari());
            var knight = TestWarrior(new MedievalKnight());
            
            Assert.IsInstanceOfType(barbaro.Armor, typeof(BabarianArmor));
            Assert.IsInstanceOfType(barbaro.Helmet, typeof(HornBabarianHelmet));
            Assert.IsInstanceOfType(barbaro.Weapon, typeof(Ax));
        }

        public AbstractWarrior TestWarrior(AbstractWarrior guerrero)
        {
            IWarriorFactory factory = AbstractWarriorFactory.GetFactory(guerrero);

            guerrero.Armor = factory.CreateArmor();
            guerrero.Helmet = factory.CreateHelmet();
            guerrero.Weapon = factory.CreateWeapon();

            return guerrero;
        }
    }
}
