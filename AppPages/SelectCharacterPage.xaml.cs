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

namespace DnDApp.AppPages
{
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
        List<String> charList = new List<string>(); 
        bool charSetup = false;

		public SelectCharacterPage()
        {
			charList.Add(character1);
			charList.Add(character2);
			charList.Add(character3);
			charList.Add(character4);
			charList.Add(character5);

			InitializeComponent();
            LoadCharList();
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

        }

        private Button LoadCharButton(StackPanel charPanel, int charNum)
        {
            Button charButton = new Button();
            charButton.Name = charList[charNum];
            charButton.Content = charList[charNum];
            charButton.HorizontalAlignment = HorizontalAlignment.Stretch;

            return charButton;
        }
    }
}
