using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBRepository
{
    public class BadgeContent
    {
        public int BadgeID { get; set; }
        public List<string> listOfDoors { get; set; }
        public BadgeContent() { }
        public BadgeContent(int badgeID, List<string> doors)
        {
            BadgeID = badgeID;
            listOfDoors = doors;
        }
    }

    //C//R//U//D

    public class BadgeRepository
    {
        public Dictionary<int, List<string>> _contentDirectory = new Dictionary<int, List<string>>();
        public List<string> GetDoorsByKey(int key)
        {
            foreach (KeyValuePair<int, List<string>> badge in _contentDirectory)
            {
                if (key == badge.Key)
                {
                    return badge.Value;
                }
            }
            return default;
        }
        //Add badge
        public bool AddBadgeToDirectory(int badgeid, List<string> door)
        {
            int initialCount = _contentDirectory.Count;
            _contentDirectory.Add(badgeid, door);
            bool newAdd = (_contentDirectory.Count > initialCount) ? true : false;
            return newAdd;
        }
        //Read badges and doors
        public Dictionary<int, List<string>> GetContents()
        {
            return _contentDirectory;
        }
        //Delete badge
        public bool DeleteBadge(int badgeid)
        {
            bool deleteBadge = _contentDirectory.Remove(badgeid);
            return deleteBadge;
        }
    }
}