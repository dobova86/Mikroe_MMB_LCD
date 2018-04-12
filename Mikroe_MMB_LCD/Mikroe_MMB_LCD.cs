using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace Mikroe.MMB.LCD
{
    public class Mikroe_MMB_LCD
    {
        Mikroe_MMB_LCD_Native _native;

        public Mikroe_MMB_LCD()
        {
            var api = Api.Find("Mikroe_MMB_LCD", ApiType.Custom);
            Interop.Add(api.Implementation[0]);
            _native = new Mikroe_MMB_LCD_Native();

        }
        
        public void Init()
        {
            _native.InitializeDisplay();
        }

        public void DrawRect(ushort x, ushort y, ushort width, ushort height, Color color)
        {
            ushort lcd_color = (ushort) Get565RGBColor(color);
            _native.DrawRect(x, y, width, height, lcd_color, false);
        }

        public void ClearScreen(Color color)
        {
            ushort lcd_color = (ushort)Get565RGBColor(color);
            _native.ClearDisplay(lcd_color);

        }

        public void DrawLine(ushort x, ushort y, ushort x1, ushort y1, Color color)
        {
            ushort lcd_color = (ushort)Get565RGBColor(color);
            _native.DrawLine(x, y, x1, y1, lcd_color, 2);
        }

        public void DrawText(string s, ushort len, ushort x, ushort y, Color color)
        {
            ushort lcd_color = (ushort)Get565RGBColor(color);
            _native.DrawText(s, (ushort) s.Length, x, y, lcd_color);
        }
        
        static uint Get565RGBColor(Color color)
        {
            uint rgbcolor = 0;
            int r = color.R >> 2;
            int g = color.G >> 1;
            int b = color.B >> 2;
            rgbcolor = (uint)((r << 11) | (g << 4) | b);
            return rgbcolor;
        }
    }
}
