using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class LeetCode1662
    {
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return string.Join("", word1).Equals(string.Join("", word2));
        }
    }
}
