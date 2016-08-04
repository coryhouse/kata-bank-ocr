using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR.Logic
{
    public class EncodedAccountNumber
    {
        public static string Decode(List<string> encodedAccountNumber)
        {
            const int charsPerCharacter = 3;

            var line1 = encodedAccountNumber[0].SplitByLength(charsPerCharacter);
            var line2 = encodedAccountNumber[1].SplitByLength(charsPerCharacter);
            var line3 = encodedAccountNumber[2].SplitByLength(charsPerCharacter);

            const int encodedCharsPerLine = 9;
            const int maxIndex = encodedCharsPerLine - 1;
            var index = 0;
            string accountNumber = "";

            while (index <= maxIndex)
            {
                accountNumber+= EncodedDigit.Decode(
                                line1.ElementAt(index), 
                                line2.ElementAt(index), 
                                line3.ElementAt(index));
                index++;
            }

            return accountNumber;
        }
    }
}
