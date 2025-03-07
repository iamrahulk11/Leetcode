using System.Collections.Generic;
using System.Reflection;

namespace LeetCode
{
    internal class Find_the_Number_of_Distinct_Colors_Among_the_Balls
    {
        private static void Main(string[] args)
        {
            // Get the directory of the currently executing assembly (exe)
            string exeDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Navigate up two levels to get the directory just before 'bin'
            string projectRootDirectory = Directory.GetParent(Directory.GetParent(exeDirectory).Parent.FullName).FullName;

            Console.WriteLine(projectRootDirectory);

            int[][] queries = { [1, 4], [2, 5], [1, 3], [3, 4] };
            int limit = 4;
            int[] answer = QueryResults(limit, queries);

            foreach (int row in answer)
            {
                Console.WriteLine(row);
            }

            Console.ReadLine();
        }

        public static int[] QueryResults(int limit, int[][] queries)
        {
            var colorsUsed = 0;
            var result = new int[queries.Length];
            var resultPointer = 0;
            //used two dictionary to handle the balls and colours seperately, avoiding the distinct count for tle.
            var ballsColor = new Dictionary<int, int>();
            var usedColors = new Dictionary<int, HashSet<int>>();
            foreach (var query in queries)
            {
                //add the balls if not present in ballsColour dictionary and check the colour is already in use dont add else add it
                //and find the colour if its new increase the colorsUsed count.
                //if ball already exists remove the used colurs and decrease the colorused count.
                //add the new colour and process the same; 
                //if colour already exists dont update the colour used count

                if (!ballsColor.ContainsKey(query[0]))
                {
                    ballsColor.Add(query[0], 0);
                }

                var ballColor = ballsColor[query[0]];

                //removing the existing colour
                if (ballColor != 0)
                {
                    usedColors[ballColor].Remove(query[0]);
                    if (!usedColors[ballColor].Any())
                    {
                        colorsUsed--;
                    }
                }

                ballsColor[query[0]] = query[1];
                if (!usedColors.ContainsKey(query[1]))
                {
                    usedColors.Add(query[1], new HashSet<int>());
                }

                if (!usedColors[query[1]].Any())
                {
                    colorsUsed++;
                }

                usedColors[query[1]].Add(query[0]);
                result[resultPointer++] = colorsUsed;
            }

            return result;
        }
        //public static int[] QueryResults(int limit, int[][] queries)
        //{
        //    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        //    List<int> results = new List<int>();

        //    for (int i = 0; i < queries.Length; i++)
        //    {
        //        if (keyValuePairs.ContainsKey(queries[i][0]))
        //        {
        //            keyValuePairs[queries[i][0]] = queries[i][1];
        //        }
        //        else
        //        {
        //            keyValuePairs.Add(queries[i][0], queries[i][1]);
        //        }
        //        results.Add(keyValuePairs.Values.Distinct().Count());
        //    }
        //    return results.ToArray();
        //}
    }
}
