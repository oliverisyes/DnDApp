using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DnDApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			// Enable custom bar
			ExtendsContentIntoTitleBar = true;
			// Set the content of bar
			SetTitleBar(customTitleBarPanel);
		}

        private void basicButton_Click(object sender, RoutedEventArgs e)
        {
            // Ensure title bar is boring and uncustomised
            customTitleBarPanel.Visibility = Visibility.Collapsed;

            // Disable custom title bar content
            ExtendsContentIntoTitleBar = false;
            
		}

        private void customButton_Click(object sender, RoutedEventArgs e)
        {
            customTitleBarPanel.Visibility= Visibility.Visible;

            // Enable custom bar
            ExtendsContentIntoTitleBar = true;
            // Set the content of bar
            SetTitleBar(customTitleBarPanel);
		}
	}
}
