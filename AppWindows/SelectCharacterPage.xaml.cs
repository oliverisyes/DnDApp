using DnDApp.CharacterClasses;
using DnDApp.Helpers;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DnDApp.AppWindows;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class SelectCharacterPage : Page
{
	String character1 = "Lexi";
	String character2 = "Az";
	String character3 = "Ash";
	String character4 = "Jen";
	String character5 = "Enphi";
	public static List<String> charList = new List<string>();
	int charSetup = 0;
	int charCols = 4;

	public SelectCharacterPage()
	{
		InitializeComponent();

		charList.Add(character1);
		charList.Add(character2);
		charList.Add(character3);
		charList.Add(character4);
		charList.Add(character5);

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
		Button charButton = UIHelper.CreateButton("listchar", charNum);
		charButton.Click += (s, e) =>
		{
			Window window = new CharacterWindow();
			//Frame rootFrame = new Frame();
			//rootFrame.Navigate(typeof(CharacterPage));
			//window.Content = rootFrame;
			((OverlappedPresenter)window.AppWindow.Presenter).Maximize();
			window.ExtendsContentIntoTitleBar = true;

			window.Activate();

			//AppWindow.Destroy();
		};

		return charButton;
	}

	private void NewCharButton_Click(object sender, RoutedEventArgs e)
	{
		Character.NewCharWindow();
	}

	private void SettingsButton_Click(object sender, RoutedEventArgs e)
	{
		if (!StandardPopup.IsOpen) { StandardPopup.IsOpen = true; }
	}
	private void ClosePopupClicked(object sender, RoutedEventArgs e)
	{
		// if the Popup is open, then close it
		if (StandardPopup.IsOpen) { StandardPopup.IsOpen = false; }
	}

	private void AccentColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		switch (AccentColorComboBox.SelectedIndex)
		{
			case 0:
				AccentColorButton.IsEnabled = false;
				break;
			case 1:
				AccentColorButton.IsEnabled = true;
				break;
		}
	}
}
