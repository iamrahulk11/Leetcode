
namespace LeetCode
{
    internal class Largest_Number_2
    {
        private static void Main(string[] args)
        {
            //int[] nums = { 3, 30, 34, 5, 9 };
            //int[] nums = { 10, 2 };
            //int[] nums = { 432, 43243 };
            int[] nums = { 111311, 1113 };

            Console.WriteLine(LargestNumber(nums));
            Console.ReadLine();
        }
        public static string LargestNumber(int[] nums)
        {
            string result = string.Empty;
            int length = nums.Length;

            while (length > 1) { 
                int maxNumberIndex = getIndex(nums, length);                

                int temp = nums[length - 1];
                nums[length-1] = nums[maxNumberIndex];
                nums[maxNumberIndex] = temp;               

                length--;
            }
            for(int i = nums.Length-1; i >= 0; i--)
            {
                result = $"{result}{nums[i].ToString()}";
            }
            return result;
        }

        public static int getIndex(int[] nums, int length)
        {
            int maxNumber = nums[0];
            int number = 0;
            int index = 0;
            
            for (int j = 0; j < length; j++)
            {
                number = nums[j];
                
                string Convertednum = nums[j].ToString();

                if (nums[j] >= 10 && maxNumber < 10)
                {                    
                    for(int i=0;i<Convertednum.Length;i++)
                    {                        
                        number = Convert.ToInt32(Convertednum[i] - '0');
                        if(number > maxNumber)
                        {
                            index = j;
                            maxNumber = nums[j];
                            break;
                        }
                    }                    
                }
                else 
                {
                    string Convertednum2 = maxNumber.ToString();
                    if(Convertednum.Length != Convertednum2.Length)
                    {
                        int count = 0;
                        bool updated = false;
                        for (int i=0; i < (Convertednum.Length > Convertednum2.Length ? Convertednum.Length : Convertednum2.Length); i++)
                        {
                            if(count >= (Convertednum.Length > Convertednum2.Length ? Convertednum2.Length : Convertednum.Length))
                            {
                                count = 0;
                            }
                            if (Convertednum2[Convertednum2.Length>Convertednum.Length ? i:count ] > Convertednum[Convertednum.Length > Convertednum2.Length ? i : count])
                            {
                                index = j;
                                maxNumber = Convertednum2[i] - '0';
                                updated = true;
                                break;
                            }
                            if(Convertednum2[Convertednum2.Length > Convertednum.Length ? i : count] < Convertednum[Convertednum.Length > Convertednum2.Length ? i : count])
                            {
                                index = j;
                                maxNumber = Convertednum[i] - '0';
                                updated = true;
                                break;
                            }
                            count++;
                        }
                        if(updated == false)
                        {
                            index = maxNumber < nums[j] ? j : index;
                            maxNumber = Math.Max(maxNumber, number);
                        }
                    }
                    else
                    {
                        index = maxNumber < number ? j : index;
                        maxNumber = Math.Max(maxNumber, number);
                    }                    
                }   
                
            }
            
            return index;
        }
    }
}