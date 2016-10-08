﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.Builder;

namespace DesignPatterns.Test
{
    /// <summary>
    /// Descripción resumida de BuilderPatternTest
    /// </summary>
    [TestClass]
    public class BuilderPatternTest
    {
        public BuilderPatternTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestBuilder()
        {
            HamburgerChef chef = new HamburgerChef();

            chef.hamBuilder = new ChickenHamburgerBuilder();

            chef.BuildHamburger();

            Hamburger ham = chef.hamburger;

            Assert.AreEqual(ham.Bread, "White Bread");
            Assert.AreEqual(ham.Meat, "Chicken Meat");
            Assert.AreEqual(ham.Complement, "Ranch Sauce");
        }

        public void testTraditionalHamburger()
        {
            HamburgerChef chef = new HamburgerChef();

            chef.hamBuilder = new TradicionalHamburguerBuilder();

            chef.BuildHamburger();

            Hamburger h = chef.hamburger;

            Assert.AreEqual(h.Bread, "Ajonjoli Bread");

            Assert.AreEqual(h.Complement, "Barcoa Sauce");

            Assert.AreEqual(h.Meat, "Cow Meat");
        }
    }
}