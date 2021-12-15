using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeARepository
{

    public class MenuContent
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public double MealPrice { get; set; }
        public string Ingredients { get; set; }

        public MenuContent() { }
        public MenuContent(int mealNumber, string mealName, string description, double mealPrice, string ingredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            MealPrice = mealPrice;
            Ingredients = ingredients;
        }
    }
    public class MenuRepo
    {
        /// <summary>
        /// Make your CRUD, don't worry about an UPDATE method.
        /// </summary>

        private readonly List<MenuContent> _menuItems = new List<MenuContent>();

        //C
        public bool AddItemToMenu(MenuContent items)
        {
            int givenItems = _menuItems.Count;
            _menuItems.Add(items);
            bool itemAdded = (_menuItems.Count > givenItems) ? true : false;
            return itemAdded;
        }
        //R
        public List<MenuContent> ViewItems()
        {
            return _menuItems;
        }
        //D
        public bool DeleteItemFromMenu(MenuContent items)
        {
            bool deleteItem = _menuItems.Remove(items);
            return deleteItem;
        }
    }
}

