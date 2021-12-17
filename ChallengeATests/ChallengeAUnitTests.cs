using ChallengeARepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChallengeATests
{
    [TestClass]
    public class ChallengeAUnitTests
    {

        MenuRepo _pocosAndRepos = new MenuRepo();

        [TestMethod]
        public void TestMethod1()
        {
            //arrange //act

            List<MenuContent> listOfContent = new List<MenuContent>();
            int count = listOfContent.Count;
            List<MenuContent> newList = _pocosAndRepos.ViewItems();
            int checkCount = newList.Count;

            //assert
            Assert.AreEqual(count, checkCount);
        }
    }
}
