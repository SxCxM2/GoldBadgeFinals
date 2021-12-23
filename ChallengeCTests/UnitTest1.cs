using ChallengeCRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeCTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //arrange

            PocosAndRepos repo = new PocosAndRepos();

            //act

            repo.PopcornBags++;
            repo.IceCream++;
            repo.HotDogs++;
            repo.VeggieBurgers++;
            repo.Hamburgers++;

            //assert

            Assert.AreEqual(repo.PopcornBags, 1);
            Assert.AreEqual(repo.IceCream, 1);
            Assert.AreEqual(repo.HotDogs, 1);
            Assert.AreEqual(repo.VeggieBurgers, 1);
            Assert.AreEqual(repo.Hamburgers, 1);

        }
    }
}
