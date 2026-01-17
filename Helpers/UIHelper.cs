using DnDApp.AppWindows;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.Helpers
{
    class UIHelper
    {
        public static Button CreateButton(string type, int num)
        {
            Button button = new Button();

            if (type == "listchar")
            {
                button.Name = SelectCharacterWindow.charList[num];
                button.Content = SelectCharacterWindow.charList[num];
                button.HorizontalAlignment = HorizontalAlignment.Stretch;
            }
            else if (type == "gridchar")
            {

            }
            else if (type == "create" || type == "next" || type == "back")
            {
				if (type == "create")
                {

                }
				else if (type == "next")
				{
					
				}
				else if (type == "back")
				{
					
				}

                button.Name = Capitalise(type);
                button.Content = Capitalise(type);
                button.Width = 70;

				if (num > 0)
				{
					button.Margin = new Thickness(0, 0, 10, 0);
				}
			}
            
            return button;
        }

        public static Grid CreateContinueGrid(string[] buttons)
        {
            Grid grid = new Grid();

            for (int i = 0; i < buttons.Length; i++)
            {
				grid.ColumnDefinitions.Add(new ColumnDefinition());
                grid.Children.Add(CreateButton(buttons[i], i));
			}

			grid.HorizontalAlignment = HorizontalAlignment.Right;
            grid.VerticalAlignment = VerticalAlignment.Bottom;

            return grid;
        }

        public static string Capitalise(string input)
        {
            return input.Substring(0, 1) + input.Substring(1);
		}
    }
}
