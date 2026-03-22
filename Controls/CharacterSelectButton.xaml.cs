using DnDApp.AppWindows;
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

namespace DnDApp.Controls;

public sealed partial class CharacterSelectButton : UserControl
{
    public CharacterSelectButton()
    {
        InitializeComponent();
    }

	private void CharButton_Click(object sender, RoutedEventArgs e)
	{
		Window window = new CharacterWindow();
		//Frame rootFrame = new Frame();
		//rootFrame.Navigate(typeof(CharacterPage));
		//window.Content = rootFrame;
		((OverlappedPresenter)window.AppWindow.Presenter).Maximize();
		window.ExtendsContentIntoTitleBar = true;

		window.Activate();
	}
}
