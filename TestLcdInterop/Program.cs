using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Drawing;
using Mikroe.MMB.LCD;
using System.Diagnostics;

namespace TestLcdInterop
{
    class Program
    {
        //Mikroe_MMB_LCD p_myLcd;
        static void Main()
        {
            Mikroe_MMB_LCD myLcd = new Mikroe_MMB_LCD();

            myLcd.Init();
            Debug.WriteLine("Testing...");
            //myLcd.ClearScreen(Color.White);
            //Thread.Sleep(500);
            myLcd.ClearScreen(Color.Black);
            myLcd.DrawRect(1, 1, 479, 271, Color.Green);
            myLcd.DrawLine(2, 150, 479, 150, Color.White);
            var s = "Hello World!";
            myLcd.DrawText(s, (ushort) s.Length, 80, 42, Color.Red);
            s = "From TinyCLR V0.10.0 !";
            myLcd.DrawText(s, (ushort) s.Length, 80, 52, Color.Red);
            myLcd.DrawRect(75, 38, 190, 32, Color.Blue);
            //DrawGauge(myLcd, 25, 25, 100, Color.Red, 50.0F, 0.0F, 100.0F);
        }

        static void DrawGauge(Mikroe_MMB_LCD lcd, int x, int y, int length, Color color, float value, float vmin, float vmax)
        {
            float delta = value - vmin;
            if (delta < 0) delta = 0;
            float angle = (delta * 180.0F) / vmax;
            float tmp_f = ((float)Math.Sin((int)angle));// / 1000;
            int y_delta = (int)(tmp_f * length);
            tmp_f = ((float)Math.Cos((int)angle));// / 1000;
            int x_delta = (int)(tmp_f * length);

            lcd.DrawLine((ushort)x, (ushort) y, (ushort)(x - x_delta), (ushort)( y - y_delta), color);
        }


    }
}
