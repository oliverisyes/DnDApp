using DnDApp.CharacterClasses;
using DnDApp.Helpers;
using WinUIEx;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using Windows.Graphics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DnDApp.AppWindows
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class SelectCharacterWindow : Window
	{
		public SelectCharacterWindow(int MinWidth, int MinHeight, int MaxWidth, int MaxHeight)
		{
			InitializeComponent();

            ExtendsContentIntoTitleBar = true;

			//this.SetWindowSize(MinWidth, MinHeight);
			this.CenterOnScreen();
			//this.SetIcon();

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
