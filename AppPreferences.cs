using System.IO;
using System.Text.Json;

namespace DnDApp
{
	public class AppPreferences
	{
		public string[]? CharacterPaths { get; set; }
		public string Theme { get; set; }
		public string AccentColor { get; set; }
		public string Font { get; set; }

		public AppPreferences()
		{
			CharacterPaths = null;
			Theme = "System";
			AccentColor = "#7328c9";
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
					AccentColor = tempSetting.AccentColor;
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