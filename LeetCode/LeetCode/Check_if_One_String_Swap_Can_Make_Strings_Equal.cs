namespace LeetCode
{
    internal class Check_if_One_String_Swap_Can_Make_Strings_Equal
    {
        private static void Main(string[] args)
        {
            string s1 = "bank";
            string s2 = "kanb";
            bool answer = AreAlmostEqual(s1,s2);

            Console.WriteLine(answer);

            Console.ReadLine();
        }
        public static bool AreAlmostEqual(string s1, string s2)
        {
            int x = -1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (x == -1)
                        x = i;
                    else
                    {
                        char[] s1Array = s1.ToCharArray();
                        char temp = s1Array[i];
                        s1Array[i] = s1Array[x];
                        s1Array[x] = temp;
                        s1 = new string(s1Array);
                        return s1 == s2;
                    }
                }
            }
            return s1 == s2;

        }
    }
}
