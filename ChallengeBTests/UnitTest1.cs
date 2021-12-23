using ChallengeBRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeBTests
{
    [TestClass]
    public class UnitTest1
    {
            BadgeRepository _badgeRepository = new BadgeRepository();
            Dictionary<int, List<string>> _contentDirectory = new Dictionary<int, List<string>>();

            [TestMethod]
            public void ADD_CONTENT_TEST()   //ACT, ARRANGE, ASSERT//   //METHODS FROM REPO//
            {
                //ARRANGE//
                List<string> listOfDoors = new List<string>();

                //ACT//
                bool act = _badgeRepository.AddBadgeToDirectory(23, listOfDoors);

                //ASSERT//
                Assert.IsTrue(act);
            }

            [TestMethod]
            public void GET_CONTENTS()
            {
                //ARRANGE//
                List<string> listOfDoors = new List<string>();
                _badgeRepository.AddBadgeToDirectory(23, listOfDoors);

                //ACT//
                Dictionary<int, List<string>> _contentDirectory = _badgeRepository.GetContents();
                bool act = _contentDirectory.ContainsKey(23);
                bool acttwo = _contentDirectory.ContainsValue(listOfDoors);

                //ASSERT//
                Assert.IsTrue(act);
                Assert.IsTrue(acttwo);
            }

            [TestMethod]
            public void DELETE_BADGE_ITEMS()
            {
                //arrange//
                List<string> listOfDoors = new List<string>();

                listOfDoors.Add("A5");
                _badgeRepository.AddBadgeToDirectory(23, listOfDoors);

                //act//
                bool act = _badgeRepository.DeleteBadge(23);

                //assert//
                Assert.IsTrue(act);
            }

            [TestMethod]
            public void MyTestMethod()
            {
                //arrange//
                list<string> listOfDoors = new List<string>();
                listOfDoors.Add("a5");
                _badgeRepository.AddBadgeToDirectory(23, listOfDoors);

                //act//
                List<string> list;
                list = _badgeRepository.GetDoorsByKey(23);
                bool act = list.Contains("a5");

                //assert//
                Assert.IsTrue(act);
            }
        }
    }
}
