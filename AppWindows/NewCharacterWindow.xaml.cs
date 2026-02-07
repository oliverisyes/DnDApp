using DnDApp.Helpers;
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
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DnDApp.AppWindows
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewCharacterWindow : Window
    {
        public NewCharacterWindow()
        {
            InitializeComponent();
            //BaseGrid.ColumnDefinitions.Add(new ColumnDefinition());
            //BaseGrid.RowDefinitions.Add(new RowDefinition());
            //Button button = new Button();
            //Grid.SetColumn(button, 1);
            //Grid.SetRow(button, 1);
            //button.Content = "aaaa";
			//BaseGrid.Children.Add(button);
			//button.Visibility = Visibility.Visible;
			//Grid.SetColumn(newCharStackPanel(["name", "location", "accent colour"]), 0);
			BaseGrid.Children.Add(newCharStackPanel(["name", "location", "accent colour"]));
		}

        private StackPanel newCharStackPanel(String[] settings)
        {
            StackPanel stackPanel = new StackPanel();
            //stackPanel.Children.Add(new Button());
            foreach (String s in settings)
            {
				stackPanel.Children.Add(new Button());
				stackPanel.Children.Add(UIHelper.CreateSettingGrid(s));
            }

            return stackPanel;
        }

		private void CreateButton_Click(object sender, RoutedEventArgs e)
		{

		}

		private void NextButton_Click(object sender, RoutedEventArgs e)
		{

		}

		private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

        }
	}
}
