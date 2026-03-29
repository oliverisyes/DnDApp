using System.IO;
using System.Text.Json;

namespace DnDApp
{
	public class AppData
	{
		public string[]? CharacterPaths { get; set; }

		public void LoadAppData(string path)
		{
			string fileName = Path.GetFileName(path);

			if (File.Exists(path))
			{
				string jsonString = File.ReadAllText(path);
				var tempSetting = JsonSerializer.Deserialize<AppData>(jsonString);
				if (tempSetting != null)
				{
					CharacterPaths = tempSetting.CharacterPaths;
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
