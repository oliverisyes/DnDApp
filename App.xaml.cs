using DnDApp.AppWindows;
using DnDApp.CharacterClasses;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
//using Microsoft.UI.Xaml.Shapes;
using System.IO;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DnDApp
{
	/// <summary>
	/// Provides application-specific behavior to supplement the default Application class.
	/// </summary>
	public partial class App : Application
	{
		private Window? _window;
		public AppData Data { get; set; }
		public AppPreferences Preferences { get; set; }
		public string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static List<Character> CharList = new List<Character>();

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
		{
			Preferences = new AppPreferences();
			Data = new AppData();
			LoadAppData(AppDataPath);
			LoadCharacters();

			switch (Preferences.Theme)
			{
				case "Dark":
					Current.RequestedTheme = ApplicationTheme.Dark;
					break;
				case "Light":
					Current.RequestedTheme = ApplicationTheme.Light;
					break;
			}
			
			InitializeComponent();
		}

		/// <summary>
		/// Invoked when the application is launched.
		/// </summary>
		/// <param name="args">Details about the launch request and process.</param>
		protected override void OnLaunched(LaunchActivatedEventArgs args)
		{
			if (Preferences.AccentColor != "System")
			{
				Current.Resources["AccentColor"] = Preferences.AccentColor;
			}

			new SelectCharacterWindow(800, 600, 900, 700).Activate();
		}

		private void LoadAppData(String path)
		{
			Preferences.LoadAppPreferences(Path.Combine(path, "DnDApp//" + "AppSettings.json"));
			Data.LoadAppData(Path.Combine(path, "DnDApp//" + "AppData.json"));

			//string chara = Data.CharacterPaths[0];
   //         ProcessStartInfo startInfo = new ProcessStartInfo(chara)
   //         {
   //             UseShellExecute = true
   //         };

   //         Process.Start(startInfo);


            //Preferences.LoadAppPreferences(Path.GetFullPath(@"C:\Projects\ProgrammingProjects\DnDApp\bin\Debug\AppSettings.json"));
            //settings.LoadAppPreferences(Path.GetFullPath(@"C:\Projects\DnDApp\bin\Debug\AppSettings.json"));
        }

		private void LoadCharacters()
		{
			List<string> paths = Data.CharacterPaths;

			for (int i = 0; i < paths.Count; i++)
			{
                CharacterClasses.Character character = new CharacterClasses.Character(paths[i], i);
				CharList.Add(character);
			}
		}
	}
}
