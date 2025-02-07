namespace LeetCode
{
    internal class Maximum_Swap
    {
        public static void Main(string[] agg)
        {
            int testcase1 = 98368;
            Console.WriteLine(MaximumSwap(testcase1));
            Console.ReadLine();
        }
        public static int MaximumSwap(int num)
        {
            List<int> reverselist = new List<int>();
            List<int> list = new List<int>();
            while (num > 0)
            {
                reverselist.Add(num%10);
                num /= 10;
            }

            bool isDisc = true;
            int maxElement = -1, indexOfMaxElement = 0;

            list = reverselist.Select(n => n).Reverse().ToList();

            for (int i = 0; i < list.Count ; i++)
            {
                if ((i+1) == list.Count)
                {
                    indexOfMaxElement = maxElement <= list[i] ? i : indexOfMaxElement;
                    maxElement = maxElement >= list[i] ? maxElement : list[i];
                    break;
                }

                if (list[i] < list[i + 1])
                {
                    isDisc = false;
                }
                if (!isDisc)
                {
                    if(maxElement == -1)
                    {
                        indexOfMaxElement = i + 1;
                        maxElement = list[i+1];
                    }
                    else
                    {
                        indexOfMaxElement = maxElement <= list[i] ? i : indexOfMaxElement;
                        maxElement = maxElement >= list[i] ? maxElement : list[i];
                    }                   
                }
            }
            if (!isDisc)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < maxElement)
                    {
                        int temp = list[i];
                        list[i] = maxElement;
                        list[indexOfMaxElement] = temp;
                        break;
                    }
                }
            }
            string combinedString = string.Join("", list.Select(n => n.ToString()));
            return int.Parse(combinedString);
        }

    }
}
