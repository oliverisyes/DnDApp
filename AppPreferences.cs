using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text.Json;
using static DnDApp.JSONTools.JSONTools;

namespace DnDApp
{
	public class AppPreferences
	{
		public string[]? CharacterPaths { get; set; }
		public string Theme { get; set; }
		public string AccentColour { get; set; }
		public string Font { get; set; }

		public AppPreferences() 
		{
			CharacterPaths = null;
			Theme = "Dark";
			AccentColour = "#4e2685";
			Font = "";
		}

		public void LoadAppPreferences(string path)
		{
			string fileName = Path.GetFileName(path);

			if (File.Exists(path))
			{
				string jsonString = File.ReadAllText(path);
				var tempSetting = JsonSerializer.Deserialize<AppPreferences>(jsonString);
				if (tempSetting != null)
				{
					CharacterPaths = tempSetting.CharacterPaths;
					Theme = tempSetting.Theme;
					AccentColour = tempSetting.AccentColour;
				}
			}
			else
			{
				File.Create(path).Close();

				string jsonString = JsonSerializer.Serialize(this);
				File.WriteAllText(path, jsonString);
			}
		}
	}
}