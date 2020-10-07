using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {
            string a = str1.ToLower();
            string b = str2.ToLower();
            if (a == b)
                return true;
            else
                return false;
        }
    }
}
