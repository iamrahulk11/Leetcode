using System.Collections.Immutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    internal class Sort_the_Jumbled_Numbers
    {
        private static void Main(string[] args)
        {
            //Test case : 1
            //int[] mapping = { 8, 9, 4, 0, 2, 1, 3, 5, 7, 6 };
            //int[] nums = { 991, 338, 38 };

            //Test case : 2
            //int[] mapping = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] nums = { 0, 999999999 };

            //Test case : 3
            //int[] mapping = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Test case : 4
            //int[] mapping = { 8, 2, 9, 5, 3, 7, 1, 0, 6, 4 };
            //int[] nums = { 418, 4191, 916, 948, 629641556, 574, 111171937, 28250, 42775632, 6086, 85796326, 696292542, 186, 67559,
            //                2167, 366, 854, 2441, 78176, 621, 4257, 2250097, 509847, 7506, 77, 50, 4135258, 4036, 59934, 59474, 3646243,
            //                9049356, 85852, 90298188, 2448206, 30401413, 33190382, 968234660, 7973, 668786, 992777977, 77, 355766, 221, 246409664,
            //                216290476, 45, 87, 836414, 40952 };

            //Test case : 5
            int[] mapping = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] nums = { 999999999, 999999999, 999999999, 999999999, 999999999 };

            int[] answer = SortJumbled(mapping, nums);

            foreach (int i in answer)
            {
                Console.WriteLine($"values : "+i);
            }
            Console.ReadLine();
        }
        public static int[] SortJumbled(int[] mapping, int[] nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            Dictionary<int, int> dictionaryValue = new Dictionary<int, int>();
            List<int> dublicate = new(); 

            foreach (int num in nums)
            {
                List<int> list = new List<int>();
                int val = num;
                while (val > 0)
                {
                    int ones = (val % 10);         
                    if (!dictionary.ContainsKey(ones))
                    {
                        dictionary.Add(ones, mapping[ones]);
                    }                    
                    list.Add(ones);
                    val /= 10;                    
                }
                if(num == 0)
                {
                    if (!dictionary.ContainsKey(num))
                    {
                        dictionary.Add(num, mapping[num]);
                    }
                    list.Add(num);
                }
                int combine = dictionary[list[list.Count()-1]];
                for(int i = list.Count()-2; i >= 0; i--)
                {
                    combine = combine * 10 + dictionary[list[i]];
                }
                if (!dictionaryValue.ContainsKey(num))
                {
                    dictionaryValue.Add(num, combine);
                }
                else
                {
                    dublicate.Add(num);
                }
            }
            var dic = dictionaryValue.OrderBy(kv => kv.Value).ToDictionary();            

            int[] result = new int[(dic.Count()+dublicate.Count())];

            int index = 0;
            int index2 = 0;
            foreach(KeyValuePair<int,int> x in dic)
            {
                if (dublicate.Count() > index2)
                {
                    if (dublicate[index2] == x.Key)
                    {
                        result[index] = x.Key;
                        result[index + 1] = dublicate[index2];
                        index2++;
                        index+=2;                        
                        continue;
                    }
                }
                result[index] = x.Key;
                index++;
            }
            if (dublicate.Count() > index2)
            {
                for(int i= index2; i<dublicate.Count();i++)
                {
                    result[index] = dublicate[i];
                    index++;                    
                }
            }
            return result;
        }        
    }
}
