namespace LeetCode
{
    internal class Minimum_Window_Substring
    {
        public static void Main(string[] args)
        {
            //string s = "ADOBECODEBANC";
            //string t = "ABC";
            string s = "abc";
            string t = "cba";
            Console.WriteLine(MinWindow(s,t));
            Console.ReadLine();
        }
        public static string MinWindow(string s, string t)
        {
            if(s.Length < t.Length)
            {
                return string.Empty;
            }

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 0; i < t.Length; i++)
            {
                if (keyValuePairs.ContainsKey(t[i]))
                {
                    keyValuePairs[t[i]]++;
                }
                else
                {
                    keyValuePairs.Add(t[i], 1);
                }
            }

            int count = keyValuePairs.Count;
            int start = 0, end = 0;
            string answer = "";

            while (start < s.Length && end < s.Length)
            {                
                if (keyValuePairs.ContainsKey(s[end]))
                {
                    keyValuePairs[s[end]]--;
                    if (keyValuePairs[s[end]] == 0)
                    {
                        count--;
                    }
                }
                

                if (count == 0)
                {
                    while (start < end)
                    {
                        if (keyValuePairs.ContainsKey(s[start]))
                        {
                            if(keyValuePairs[s[start]] < 0)
                            {
                                keyValuePairs[s[start]]++;
                                start++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            start++;
                        }                        
                    }                    
                    if ((end - start) < answer.Length || string.IsNullOrWhiteSpace(answer))
                    {
                        answer = s.Substring(start, (end-start)+1);
                    }                    
                }
                end++;

            }
            if(count > 0)
            {
                return string.Empty;
            }            
            return answer;
        }
    }
}
