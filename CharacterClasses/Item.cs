using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.CharacterClasses
{
    internal class Item
    {
        private string _name;
        private string _description;
        private string _type;
        private int _quantity;
        private string _rarity;
		private string _source;

		private double _weight;
        private double _cost;

        public Item() 
        { 
        }
    }
}
