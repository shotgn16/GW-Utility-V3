using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GW_Utility_V3
{
    internal class colorScheme
    {
        public static MaterialSkinManager globalInstance;
        internal static async Task defautTheme()
        {
            globalInstance = MaterialSkinManager.Instance;
            globalInstance.Theme = MaterialSkinManager.Themes.LIGHT;
            globalInstance.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        internal static async Task setTheme_blue()
        {
            globalInstance = MaterialSkinManager.Instance;
            globalInstance.Theme = MaterialSkinManager.Themes.LIGHT;
            globalInstance.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
        }

        internal static async Task setTheme_darkRed()
        {
            globalInstance = MaterialSkinManager.Instance;
            globalInstance.Theme = MaterialSkinManager.Themes.DARK;
            globalInstance.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        internal static async Task setTheme_highContrast()
        {
            globalInstance = MaterialSkinManager.Instance;
            globalInstance.Theme = MaterialSkinManager.Themes.DARK;
            globalInstance.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.WHITE);
        }

        internal static async Task setColorScheme(string option)
        {
            if (!string.IsNullOrEmpty(option))
            {
                switch (option)
                {
                    case "Red": await defautTheme(); break;
                    case "Blue": await setTheme_blue(); break;
                    case "Dark": await setTheme_darkRed(); break;
                    case "High Contrast": await setTheme_highContrast(); break;
                }
            }
        }
    }
}
