using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text.Json;
using static DnDApp.JSONTools.JSONTools;

namespace DnDApp
{
	public class AppSettings
	{
		public string[]? CharacterPaths { get; set; }
		public string Theme { get; set; }
		public string AccentColour { get; set; }

		public AppSettings() 
		{
			CharacterPaths = null;
			Theme = "Dark";
			AccentColour = "#4e2685";
		}

		public void LoadAppSettings(string path)
		{
			string fileName = Path.GetFileName(path);

			if (File.Exists(path))
			{
				string jsonString = File.ReadAllText(path);
				var tempSetting = JsonSerializer.Deserialize<AppSettings>(jsonString);
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