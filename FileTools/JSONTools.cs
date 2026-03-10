using System;
using System.IO;
using System.Text.Json;

namespace DnDApp.FileTools
{
	internal class JSONTools
	{
		public static void CheckDir(string[] args)
		{
			foreach (string path in args)
			{
				if (File.Exists(path))
				{
					// This path is a file
					ProcessFile(path);
				}
				else if (Directory.Exists(path))
				{
					// This path is a directory
					ProcessDirectory(path);
				}
				else
				{
					Console.WriteLine("{0} is not a valid file or directory.", path);
				}
			}
		}

		public class WeatherForecast
		{
			public DateTimeOffset Date { get; set; }
			public int TemperatureCelsius { get; set; }
			public string? Summary { get; set; }
		}

		public static void LoadAppSettings(string path)
		{
			if (!File.Exists(path))
			{
				var weatherForecast = new WeatherForecast
				{
					Date = DateTime.Parse("2019-08-01"),
					TemperatureCelsius = 25,
					Summary = "Hot"
				};

				string fileName = "WeatherForecast.json";
				string jsonString = JsonSerializer.Serialize(weatherForecast);
				File.WriteAllText(fileName, jsonString);
			}
			else
			{

			}
		}

		// Process all files in the directory passed in, recurse on any directories
		// that are found, and process the files they contain.
		public static void ProcessDirectory(string targetDirectory)
		{
			// Process the list of files found in the directory.
			string[] fileEntries = Directory.GetFiles(targetDirectory);
			foreach (string fileName in fileEntries)
				ProcessFile(fileName);

			// Recurse into subdirectories of this directory.
			string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
			foreach (string subdirectory in subdirectoryEntries)
				ProcessDirectory(subdirectory);
		}

		// Insert logic for processing found files here.
		public static void ProcessFile(string path)
		{
			Console.WriteLine("Processed file '{0}'.", path);
		}
	}
}