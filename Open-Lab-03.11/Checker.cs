using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            
            
                char[] chars = str.ToCharArray();
                for (int i = 0, j = str.Length - 1; i < j; i++, j--)
                {
                    char c = chars[i];
                    chars[i] = chars[j];
                    chars[j] = c;
                }
                new string(chars);
                if (str == new string (chars))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        } 
    }
}
