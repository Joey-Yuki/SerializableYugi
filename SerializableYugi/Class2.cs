﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace SerializableYugi
{
    public class Fuente
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr fuente, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        static FontFamily ff;
        static FontFamily ff2;
        static FontFamily ff3;
        public static void CargarFuente()
        {
            byte[] arrayfuente = Properties.Resources.StoneSerifSemibold;
            int datalenght = Properties.Resources.StoneSerifSemibold.Length;
            IntPtr pointer = Marshal.AllocCoTaskMem(datalenght);
            Marshal.Copy(arrayfuente, 0, pointer, datalenght);
            uint cFonts = 0;
            AddFontMemResourceEx(pointer, (uint)arrayfuente.Length, IntPtr.Zero, ref cFonts);
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddMemoryFont(pointer, datalenght);
            Marshal.FreeCoTaskMem(pointer);
            ff = privateFontCollection.Families[0];
        }//CARGAR FUENTE 1
        public static void LocalizarFuente(System.Windows.Forms.Control c, float tamanho)
        {
            c.Font = new Font(ff, tamanho, FontStyle.Regular);
        }
    }//CLASS
}
