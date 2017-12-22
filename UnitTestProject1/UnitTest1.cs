using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("i want to order a pizza with black olives"), "Your pizza with black olives is on the way");
        }

        //order with 2 addons
        [TestMethod]
        public void WithTwoAddons()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("i want to order a pizza with black olives and mushrooms"), "Your pizza with black olives, mushrooms is on the way");
        }

        //order without addons
        [TestMethod]
        public void WithoutAddons()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("i want to order a pizza without addons"), "Your pizza is on the way");
        }


        //order without maindish
        [TestMethod]
        public void WithoutMaindish()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("i want to order a black olives"), "Please try again");
        }

        //empty order
        [TestMethod]
        public void EmptyOrder()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput(""), "Please try again");
        }

        //null input order
        [TestMethod]
        public void NullOrder()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput(null), "Please try again");
        }

        //order with 2 maindish without addons
        [TestMethod]
        public void TwoMainDish()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("i want to order a pizza and toast"), "Please try again");
        }

        //order with 2 maindish with addons
        [TestMethod]
        public void TwoMainDishWithAddons()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("i want to order a pizza and toast with black olives"), "Please try again");
        }

        //repeat of maindish
        [TestMethod]
        public void RepeatMainDish()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("i want to order a pizza and pizza "), "Please try again");
        }

        //repeat of addons
        public void RepeatAddons()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("i want to order a pizza with black olives and black olives"), "Please try again");
        }

        //incorrect input without maindish and addons
        [TestMethod]
        public void IncorrectInput()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("jahkfja dsjfhljsdafl sdfkj"), "Please try again");
        }
    }


}
