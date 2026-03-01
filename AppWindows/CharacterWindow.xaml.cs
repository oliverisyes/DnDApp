using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
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
    public sealed partial class CharacterWindow : Window
    {
        public CharacterWindow()
        {
            InitializeComponent();
        }

		int previousSelectedIndex = 0;
		private void InventoryBar_SelectionChanged(SelectorBar sender, SelectorBarSelectionChangedEventArgs args)
		{
			SelectorBarItem selectedItem = sender.SelectedItem;
			int currentSelectedIndex = sender.Items.IndexOf(selectedItem);

			//ItemsContainer.Children.Clear();
			ItemsContainer.Children.Add(ActionsItemScroll);

			//ItemsContainer.Children[previousSelectedIndex].Visibility = Visibility.Collapsed;
			ItemsContainer.Children[currentSelectedIndex].Visibility = Visibility.Visible;

			//previousSelectedIndex = currentSelectedIndex;
		}
	}
}
