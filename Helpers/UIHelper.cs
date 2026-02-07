using DnDApp.AppWindows;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
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

                button.Name = type;
                button.Content = Capitalise(type);
                button.Width = 70;

				if (num > 0)
				{
					button.Margin = new Thickness(0, 0, 10, 0);
				}
			}
            else if (type == "browse")
            {
                button.Name = type;
                button.Content = Capitalise(type);
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

        public static Grid CreateSettingGrid(string setting)
        {
            Grid grid = new Grid();

            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            Grid.SetColumn(CreateSettingName(setting), 0);
            Grid.SetColumn(CreateSettingInput(setting), 1);

            return grid;
        }

        private static TextBlock CreateSettingName(string setting)
        {
            TextBlock textBlock = new TextBlock();

            textBlock.Text = Capitalise(setting);
            
            return textBlock;
        }

        private static FrameworkElement CreateSettingInput(string setting)
        {
			if (setting == "name" || setting == "accent colour")
            {
                TextBox input = new TextBox();

                if (setting == "name")
                {
                    input.PlaceholderText = "Character Name";
                }
                else if (setting == "accent colour")
                {
                    input.PlaceholderText = "colour hex code";
                }

                return input;
            }
            else if (setting == "location")
            {
                Button input = new Button();

                if (setting == "location")
                {
                    input = CreateButton("browse", 0);
				}

                return input;
            }
            else
            {
				TextBlock input = new TextBlock();
				input.Text = "Element Failed";
                return input;
			}
        }

        public static string Capitalise(string input)
        {
			TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            ti.ToTitleCase(input);
			return input;
        }
    }
}
