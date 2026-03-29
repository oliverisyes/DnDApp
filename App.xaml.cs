using DnDApp.AppWindows;
using Microsoft.UI.Xaml;
using System;

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
		public String DataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		/// <summary>
		/// Initializes the singleton application object.  This is the first line of authored code
		/// executed, and as such is the logical equivalent of main() or WinMain().
		/// </summary>
		public App()
		{
			Preferences = new AppPreferences();
			Data = new AppData();
			LoadAppData(DataPath);
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

			_window = new SelectCharacterWindow
			{
				ExtendsContentIntoTitleBar = true
			};
			_window.AppWindow.MoveAndResize(new Windows.Graphics.RectInt32(600, 200, 800, 600));
			_window.Activate();
		}

		private void LoadAppData(String path)
		{
			Preferences.LoadAppPreferences(Path.Combine(DataPath, "AppSettings.json"));
			Data.LoadAppData(Path.Combine(DataPath, "AppData.json"));
			//Preferences.LoadAppPreferences(Path.GetFullPath(@"C:\Projects\ProgrammingProjects\DnDApp\bin\Debug\AppSettings.json"));
			//settings.LoadAppPreferences(Path.GetFullPath(@"C:\Projects\DnDApp\bin\Debug\AppSettings.json"));
		}
	}
}
