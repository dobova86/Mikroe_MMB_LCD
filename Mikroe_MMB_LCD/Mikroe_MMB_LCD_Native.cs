using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Mikroe.MMB.LCD
{
    class Mikroe_MMB_LCD_Native
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void InitializeDisplay();

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void WriteCommand(ushort cmd);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void WriteData(ushort data);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void DrawRect(ushort x, ushort y, ushort width, ushort height, ushort color, bool fill);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void DrawLine(ushort x0, ushort y0, ushort x1, ushort y1, ushort color, ushort thickness);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void DrawCircle(ushort x, ushort y, ushort radius, ushort color, bool fill);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void DrawImage(byte[] image, ushort xDst, ushort yDst, ushort originalWidth, ushort originalHeight, ushort xSrc, ushort ySrc, ushort width, ushort height);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void DrawText(string text, ushort textlen, ushort xDst, ushort yDst, uint color);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void ClearDisplay(uint color);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void ScrollArea(ushort x, ushort y, ushort width, ushort height, ushort scrollx, ushort scrolly, bool up_down);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern void SetPixel(ushort x, ushort y, ushort color);


    }
}
