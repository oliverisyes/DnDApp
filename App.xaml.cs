using DnDApp.AppPages;
using DnDApp.AppWindows;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;

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

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            _window = new SelectCharacterWindow();

            // Create a Frame to act as the navigation context and navigate to the first page
             //Frame rootFrame = new Frame();
			// Navigate to the first page, configuring the new page
			// by passing required information as a navigation parameter
			 //rootFrame.Navigate(typeof(SelectCharacterPage), args.Arguments);
            // Place the frame in the current Window
             //_window.Content = rootFrame;
			 _window.ExtendsContentIntoTitleBar = true;
			_window.AppWindow.MoveAndResize(new Windows.Graphics.RectInt32(600, 200, 800, 600));
			// Ensure the MainWindow is active
			_window.Activate();
			//_window.Title = "DndYay";
			//_window.ExtendsContentIntoTitleBar = true;
			//_window.SetTitleBar(CreateTitlebar());
			
		}

        
    }
}
