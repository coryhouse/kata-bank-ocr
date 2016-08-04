using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR.Logic
{
    public class EncodedDigit
    {
        public static string Decode(string line1, string line2, string line3)
        {
            if (line1 == "   " &&
                line2 == "  |" &&
                line3 == "  |")
            {
                return "1";
            }

            if (line1 == " _ " &&
                line2 == " _|" &&
                line3 == "|_ ")
            {
                return "2";
            }

            if (line1 == " _ " &&
                line2 == " _|" &&
                line3 == " _|")
            {
                return "3";
            }

            if (line1 == "   " &&
                line2 == "|_|" &&
                line3 == "  |")
            {
                return "4";
            }

            if (line1 == " _ " &&
                line2 == "|_ " &&
                line3 == " _|")
            {
                return "5";
            }

            if (line1 == " _ " &&
                line2 == "|_ " &&
                line3 == "|_|")
            {
                return "6";
            }

            if (line1 == " _ " &&
                line2 == "  |" &&
                line3 == "  |")
            {
                return "7";
            }

            if (line1 == " _ " &&
                line2 == "|_|" &&
                line3 == "|_|")
            {
                return "8";
            }

            if (line1 == " _ " &&
                line2 == "|_|" &&
                line3 == " _|")
            {
                return "9";
            }

            return "0";
        }
    }
}
