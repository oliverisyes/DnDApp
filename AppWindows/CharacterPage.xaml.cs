using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DnDApp.AppWindows;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class CharacterPage : Page
{
	public CharacterPage()
	{
		InitializeComponent();

		//((OverlappedPresenter)AppWindow.Presenter).Maximize();
	}
}