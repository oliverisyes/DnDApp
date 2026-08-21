using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Windows.Storage.Pickers;
using Windows.System;

namespace DnDApp
{
	public class AppData
	{
		public List<string> CharacterPaths { get; set; }

		public AppData() 
		{
			CharacterPaths = new();
			//CharacterPaths.Add("path0");
            //CharacterPaths.Add("path1");
        }

		public void LoadAppData(string path)
		{
			string fileName = Path.GetFileName(path);

			if (File.Exists(path))
			{
                string otherpath = Path.GetFullPath(path);
                string jsonString = File.ReadAllText(path);
				var tempSetting = JsonSerializer.Deserialize<AppData>(jsonString);
				if (tempSetting != null)
				{
					CharacterPaths = tempSetting.CharacterPaths;
				}
			}
			else
			{
                string jsonString = JsonSerializer.Serialize(this);
                File.Create(path).Close();
				File.WriteAllText(path, jsonString);
			}
		}
	}
}
