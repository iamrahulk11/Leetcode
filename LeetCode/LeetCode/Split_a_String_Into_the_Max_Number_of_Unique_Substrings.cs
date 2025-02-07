using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Split_a_String_Into_the_Max_Number_of_Unique_Substrings
    {
        private static void Main(string[] args)
        {
            string testcase1 = "ababccc";
            //  Output: 5
            //  Explanation: One way to split maximally is ['a', 'b', 'ab', 'c', 'cc']. Splitting like['a', 'b', 'a', 'b', 'c', 'cc'] is not valid as you have 'a' and 'b' multiple times.

            string testcase2 = "aba";
            //  Output: 2
            //  Explanation: One way to split maximally is ['a', 'ba'].

            string testcase3 = "aa";

            string testcase4 = "wwwzfvedwfvhsww";

            string testcase5 = "addbsd";
            int ans = 0;

            List<string> st = new();

            unique(0, testcase5, ans, st);

           // Console.WriteLine(MaxUniqueSplit(testcase5));

            Console.ReadLine();

        }

        private static void unique(int i, string s, int ans, List<string> st)
        {
            if (i == s.Length)
            {
                ans = Math.Max(ans, (int)st.Count);
                return;
            }

            for (int j = s.Length - i; j >= 1; j--)
            {
                string back = s.Substring(i, j);

                if (searchInMadeUp(back, st))
                    continue;

                st.Add(back);
                unique(i + j, s, ans, st);
                st.Remove(back);
            }
        }
        public static int MaxUniqueSplit(string s)
        {
            string madeup = string.Empty;
            List<string> madeupstringist = new List<string>(); 
            for(int i = 0; i < s.Length; i++)
            {
                madeup += s[i];
                if (!searchInMadeUp(madeup, madeupstringist))
                {
                    madeupstringist.Add(madeup);
                    madeup = string.Empty;                    
                }
            }
            if (!string.IsNullOrEmpty(madeup))
            {
                madeupstringist.Add(madeup);
            }

            return madeupstringist.Count;
        }

        private static bool searchInMadeUp(string madeupstring, List<string> madeupstringist)
        {
            for(int i = 0; i < madeupstringist.Count; i++)
            {
                if(madeupstringist[i] == madeupstring)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
