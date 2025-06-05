namespace LeetCode
{
    public class Finding3_Digit_Even_Numbers
    {        
        public static void Main()
        {
            int[] digits = { 2, 2, 8, 8, 2 };
            var x = 10 + 30 + 'A' + 30 + 10;

            Finding3_Digit_Even_Numbers p = new Finding3_Digit_Even_Numbers();

            Console.WriteLine(x);
            Console.WriteLine("Answer = {0}", p.FindEvenNumbers(digits));
            Console.ReadLine();
        }


        public int[] FindEvenNumbers(int[] digits)
        {
            List<int> result = new();
            for (int i = 0; i < digits.Length; i++)
            {
                int startValue = result.Find(x => x == digits[i]);
                if (digits[i] == 0 || (startValue%100) == digits[i]) continue;
                int digit = digits[i];
                for (int j = 0; j < digits.Length; j++)
                {
                    if (i == j) continue;
                    for (int k = 0; k < digits.Length; k++)
                    {
                        if (k == j || k == i) continue;
                        int value = (digit * 100 + digits[j] * 10 + digits[k]);
                        if (value % 2 == 0 && !result.Contains(value))
                        {
                            result.Add((digit * 100 + digits[j] * 10 + digits[k]));
                        }
                    }
                }
            }

            IEnumerable<int> answer = result.ToArray().OrderBy(value => value);

            return answer.ToArray();
        }
    }
}
