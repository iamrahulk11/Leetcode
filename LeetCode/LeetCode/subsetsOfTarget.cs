namespace LeetCode
{
    public class subsetsOfTarget
    {

        static bool FindSubset(int[] nums, int target, int index, List<int> subset)
        {
            if (target == 0)
            {
                // Found a valid subset
                Console.WriteLine("Subset found: [" + string.Join(", ", subset) + "]");
                return true;
            }

            if (index >= nums.Length || target < 0)
                return false;

            // Include current number
            subset.Add(nums[index]);
            if (FindSubset(nums, target - nums[index], index + 1, subset))
                return true;

            // Exclude current number (backtrack)
            subset.RemoveAt(subset.Count - 1);
            return FindSubset(nums, target, index + 1, subset);
        }

        public static void Main()
        {
            int[] nums = { 4, 1, 3, 6, 3 };
            int target = 6;

            List<int> subset = new List<int>();
            if (!FindSubset(nums, target, 0, subset))
            {
                Console.WriteLine("No subset found.");
            }
        }
    }
}
