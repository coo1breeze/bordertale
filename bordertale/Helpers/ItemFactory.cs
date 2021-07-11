﻿using bordertale.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Helpers
{
    public static class ItemFactory
    {
        public static Item CreateItem(string itemName)
        {
            switch (itemName.Trim().ToLower())
            {
                case "shield":
                    return new Shield("shield", "Sturdy Shield", 35, 100, 75);
                case "helmet":
                    return new Armour("helmet", "Iron Helmet", 30, 100, 10);
                case "chestplate":
                    return new Armour("chestplate", "Iron Chestplate", 40, 100, 20);
                case "knife":
                    return new Weapon("knife", "Knife", 50, 100, 80);
                case "sword":
                    return new Weapon("sword", "Soldier's Broadsword", 100, 150, 100);
                default:
                    return null;
            }
        }
    }
}
