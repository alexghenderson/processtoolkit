using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProcessToolkit
{
    internal static class Address
    {
        public static string Make(byte[] buffer)
        {
            string temp = "";
            for (int i = 0; i < buffer.Length; i++)
            {
                if (Convert.ToInt16(buffer[i]) < 10)
                    temp = "0" + ToHex(buffer[i]) + temp;
                else
                    temp = ToHex(buffer[i]) + temp;
            }
            return temp;
        }
        public static string ToHex(int dec)
        {
            return dec.ToString("X");
        }
        public static int ToDecimal(string hex)
        {
            return int.Parse(hex, NumberStyles.HexNumber);
        }
    }
}
