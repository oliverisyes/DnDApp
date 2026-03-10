using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DnDApp.AppWindows
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CharacterWindow : Window
	{
		public CharacterWindow()
		{
			InitializeComponent();

			// Create a Frame to act as the navigation context.
			Frame rootFrame = new Frame();

			rootFrame.NavigationFailed += OnNavigationFailed;

			// Place the frame in the current Window
			this.NavView.Content = rootFrame;

			rootFrame.Navigate(typeof(CharacterPage));
		}

		private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
		{
			throw new NotImplementedException();
		}

		int previousSelectedIndex = 0;
		private void InventoryBar_SelectionChanged(SelectorBar sender, SelectorBarSelectionChangedEventArgs args)
		{
			SelectorBarItem selectedItem = sender.SelectedItem;
			int currentSelectedIndex = sender.Items.IndexOf(selectedItem);

			//ItemsContainer.Children.Clear();
			//  ItemsContainer.Children.Add(ActionsItemScroll);

			//ItemsContainer.Children[previousSelectedIndex].Visibility = Visibility.Collapsed;
			//  ItemsContainer.Children[currentSelectedIndex].Visibility = Visibility.Visible;

			//previousSelectedIndex = currentSelectedIndex;
		}
	}
}
