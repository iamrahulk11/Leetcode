namespace LeetCode
{
    public class MergeSort
    {
        public static void Main()
        {
            int[] arr = { 3, 2, 4, 1, 2 };
            ms(arr, 0, arr.Length - 1);

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void ms(int[] arr, int low, int high)
        {
            if (low >= high) return;
            int mid = (low + high) / 2;

            ms(arr, low, mid);
            ms(arr, mid + 1, high);

            merge(arr, low, mid, high);
        }

        public static void merge(int[] arr, int low, int mid, int high)
        {
            List<int> list = new List<int>();
            int left = low;
            int right = mid + 1;
            while (left <= mid && right <= high) {
                if (arr[left] <= arr[right])
                {
                    list.Add(arr[left]);
                    left++;
                }
                else
                {
                    list.Add(arr[right]);
                    right++;
                }
            }

            while (left <= mid)
            {
                list.Add(arr[left]);
                left++;
            }
            while (right <= high)
            {
                list.Add(arr[right]);
                right++;
            }

            for(int i=low;i<=high;i++)
            {
                arr[i] = list[i-low];
            }
        }

    }
}
