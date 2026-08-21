using DnDApp.AppWindows;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;

namespace DnDApp.CharacterClasses
{
	public class Character
	{
		public string _filePath;
		public int _id;
		public string _name;
		public Uri _imageUri;

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

		public Character(string path, int id)
		{
            DirectoryInfo dir = new DirectoryInfo(path);

            if (dir.Exists)
			{
				string name = dir.Name;
				DirectoryInfo[] folders = dir.GetDirectories();
				FileInfo[] files = dir.GetFiles();

                _filePath = path;
                _id = id;
                _name = name;

				foreach (FileInfo file in files)
				{
					string ext = file.Extension;
					if (file.Exists && file.Name == "CharPic.png")
					{
                        _imageUri = new Uri(file.FullName);
                    }
				}
                
            }
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
