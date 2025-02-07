using System.Text;

namespace LeetCode
{
    public class Counting_Words_With_a_Given_Prefix
    {
        private static void Main(string[] args)
        {
            string[] words = { "pay", "attention", "practice", "attend" };
            string pref = "at";
            int answer = prefixCount(words, pref);

            Console.WriteLine(answer);

            Console.ReadLine();
        }
        public static int prefixCount(string[] words, string pref)
        {
            int result = 0;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                stringBuilder.Append(words[i].Substring(0,2));
                if(stringBuilder.ToString() == pref)
                {
                    result++;
                }
                stringBuilder.Clear();
            }
            return result;
        }
    }
}
