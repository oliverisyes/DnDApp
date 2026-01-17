using DnDApp.AppWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.CharacterClasses
{
    internal class Character
    {
        private string _filePath;

        private string _name;

        private int _level;
        private int _exp;

        private int _hpMax;
        private int _hpCurrent;

        private int _walkSpeed;
        private int _armourClass;
        private bool _inspiration;

        private int initiative;
        private int _proficiencyBonus;
        private Dictionary<string, int> _abilityScores;

        private Item[] _inventory;

		public Character() 
        { 
            
        }

        public static void NewCharWindow()
        {
            NewCharacterWindow newCharacterWindow = new NewCharacterWindow();
            newCharacterWindow.ExtendsContentIntoTitleBar = true;
			newCharacterWindow.AppWindow.MoveAndResize(new Windows.Graphics.RectInt32(625, 225, 750, 550));
			newCharacterWindow.Activate();
        }
    }
}
