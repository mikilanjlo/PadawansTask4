using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == null)
                throw new ArgumentNullException();
            if (str == "")
                throw new ArgumentException();
            char[] vowels = new char[] { 'a', 'i', 'e', 'o', 'u' };
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                for (int j = 0; j < vowels.Length; j++)
                    if (str[i] == vowels[j])
                        count++;
            return count;
        }
    }
}
