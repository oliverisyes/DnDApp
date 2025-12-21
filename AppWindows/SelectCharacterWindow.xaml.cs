using DnDApp.AppPages;
using DnDApp.CharacterClasses;
using Microsoft.UI.Windowing;
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
    public sealed partial class SelectCharacterWindow : Window
    {
		String character1 = "Lexi";
		String character2 = "Az";
		String character3 = "Ash";
		String character4 = "Jen";
		String character5 = "Enphi";
		List<String> charList = new List<string>();
		int charSetup = 0;
		int charCols = 4;

		public SelectCharacterWindow()
        {
            InitializeComponent();

			charList.Add(character1);
			charList.Add(character2);
			charList.Add(character3);
			charList.Add(character4);
			charList.Add(character5);

			InitializeComponent();

			if (charSetup == 0)
			{
				LoadCharList();
			}
			else if (charSetup == 1)
			{
				LoadCharGrid();
			}
		}

		private void LoadCharList()
		{
			StackPanel charPanel = this.charPanel;

			for (int i = 0; i < charList.Count; i++)
			{
				charPanel.Children.Add(LoadCharButton(charPanel, i));
			}
		}

		private void LoadCharGrid()
		{
			StackPanel charPanel = this.charPanel;

			for (int i = 0; i < charList.Count / charCols; i++)
			{
				charPanel.Children.Add(CharGridLayer());
			}
		}
		private Grid CharGridLayer()
		{
			Grid layer = new();

			for (int i = 0; i < charCols; i++)
			{
				Button button = LoadCharButton(charPanel, i);

				layer.Children.Add(button);
			}

			return layer;
		}

		private Button LoadCharButton(StackPanel charPanel, int charNum)
		{
			Button charButton = new Button();

			charButton.Name = charList[charNum];
			charButton.Content = charList[charNum];
			charButton.HorizontalAlignment = HorizontalAlignment.Stretch;
			charButton.Click += (s, e) =>
			{
				Window window = new CharacterWindow();
				//Frame rootFrame = new Frame();
				//rootFrame.Navigate(typeof(CharacterPage));
				//window.Content = rootFrame;
				((OverlappedPresenter)window.AppWindow.Presenter).Maximize();
				window.ExtendsContentIntoTitleBar = true;

				window.Activate();

				AppWindow.Destroy();
			};

			return charButton;
		}

        private void NewChar_Click(object sender, RoutedEventArgs e)
        {
			Character.NewCharWindow();
        }
    }
}
