using System.Collections.Generic;

namespace LeetCode
{
    internal class Rabbits_in_Forest
    {
        public static void Main(string[] args)
        {
            int[] answers = { 1, 0, 1, 0, 0 };
            Console.WriteLine(NumRabbits(answers));
            Console.ReadLine();
        }
        public static int NumRabbits(int[] answers)
        {
            int count = 0;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < answers.Length; i++)
            {
                if (keyValuePairs.ContainsKey(answers[i]))
                {
                    keyValuePairs[answers[i]]++;
                }
                else
                {
                    keyValuePairs.Add(answers[i], 1);
                }
            }

            foreach (KeyValuePair<int, int> kvp in keyValuePairs)
            {
                if (kvp.Value == 1)
                {
                    count += kvp.Key + 1;
                }
                else
                {
                    int multipleAnswrs = kvp.Value / (kvp.Key + 1);
                    int leftOut = kvp.Value % (kvp.Key + 1);
                    if (leftOut == 0)
                    {
                        count += (multipleAnswrs * (kvp.Key + 1));  
                    }
                    else
                    {
                        count += ((multipleAnswrs * (kvp.Key + 1)) + (kvp.Key + 1));
                    }                    
                }
            }
            return count;

        }
    }
}
