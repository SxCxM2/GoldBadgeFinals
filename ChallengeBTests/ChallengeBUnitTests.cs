using ChallengeBRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChallengeBTests
{
    [TestClass]
    public class ChallengeBUnitTests
    {
        BadgeRepository _badgeRepository = new BadgeRepository();
        Dictionary<int, List<string>> _badgeDirectory = new Dictionary<int, List<string>>();

        // act, arrange, assert // 

        [TestMethod]
        public void AddBadge_Test()
        {
            //Arrange

            List<string> allDoors = new List<string>();

            //Act

            bool useing = _badgeRepository.AddBadgeToDirectory(0123, allDoors);

            //Assert

            Assert.IsTrue(useing);

        }

        [TestMethod]
        public void Removal_Test()
        {
            //arrange

            List<string> allDoors = new List<string>();

            allDoors.Add("Some Thing");
            _badgeRepository.AddBadgeToDirectory(0123, allDoors);

            //act

            bool useing = _badgeRepository.DeleteBadge(0123);

            //assert

            Assert.IsTrue(useing);

        }

        [TestMethod]
        public void View_Test()
        {

            //arrange

            List<string> allDoors = new List<string>();
            _badgeRepository.AddBadgeToDirectory(0123, allDoors);

            //act
            Dictionary<int, List<string>> _badgeDirectory = _badgeRepository.GetContents();
            bool useing = _badgeDirectory.ContainsKey(0123);
            bool alsoUseing = _badgeDirectory.ContainsValue(allDoors);

            //assert

            Assert.IsTrue(useing);
            Assert.IsTrue(alsoUseing);
        }
    }
}