using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace LeetCode
{
    public static class LeetCode1773
    {
        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int ruleIndex = new Dictionary<string, int>() { { "type", 0 }, { "color", 1 }, { "name", 2 } }[ruleKey];

            int matchCount = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i][ruleIndex].Equals(ruleValue) )
                {
                    matchCount += 1;
                }
            }

            return matchCount;
        }

        public static int Test()
        {
            List<IList<string>> list = new List<IList<string>>()
            {
                new List<string>() { "phone","blue","pixel" },
                new List<string>() { "computer","silver","lenovo" },
                new List<string>() { "phone", "gold", "iphone" }
            };

            string ruleKey = "color", ruleValue = "silver";

            return CountMatches((IList<IList<string>>)list, ruleKey, ruleValue);
        }
    }
}
