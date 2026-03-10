using DnDApp.CharacterClasses;
using DnDApp.Helpers;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DnDApp.AppWindows
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class SelectCharacterWindow : Window
	{
		public SelectCharacterWindow()
		{
			InitializeComponent();

			Frame rootFrame = new Frame();

			rootFrame.NavigationFailed += OnNavigationFailed;

			this.MainGrid.Children.Add(rootFrame);

			rootFrame.Navigate(typeof(SelectCharacterPage));
		}

		private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
