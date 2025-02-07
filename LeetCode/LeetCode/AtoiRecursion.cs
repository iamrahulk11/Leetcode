using System.Collections.Generic;

namespace LeetCode
{
    internal class AtoiRecursion
    {
        public static void Main(string[] args)
        {
            string s = "1337c089";
            Console.WriteLine(myAtoi(s));

            Console.ReadLine();
        }
        /// <summary>
        /// LOGIC :
        /// 1. BY DEFAULT TREAT ANSWER AS POSITIVE AND 'FOUND' FLAG TRUE IN REST OF THE FLAG
        /// 2. CHECK INDEX IS OUT OF RANGE AS PER "S" STRING LENGTH
        /// 3. CHECK ANSWER CREATED IS LARGER THAN INT MAX VALUE
        /// 4. IGNORE ALL SPACE AND MOVE INDEX + 1 AND RECALL
        /// 5. CHECKING ONLY FIRST INDEX '-' OR '+' WITH 'FOUND' FLAG AS FALSE AND MARK IT TRUE AND RECALL
        /// 6. CHECK STRING CURRENT INDEX IS WITHIN RANGE '0' TO '9' INTEGER AND RECALL
        /// 6.1 UPDATE ANSWER TO * 10 + currentCharacter[index]-'0' and mark FOUND FLAG TRUE AND MOVE INDEX + 1 AND RECALL
        /// 6.2 CHECK ANSWER IS EXCEEDING INT MAX VALUE IF YES THEN RETURN ANSWER ELSE RECALL
        /// 7. RETURN ANSWER AS PER NEGATIVE FLAG IF NON OF THE CONDITION MATCH
        /// </summary>
        /// <param name="s"></param>
        /// <param name="index"></param>
        /// <param name="answer"></param>
        /// <param name="negative"></param>
        /// <param name="found"></param>
        /// <returns></returns>
        public static long myAtoi(string s, int index = 0, long answer = 0, bool negative = false, bool found = false)
        {
            if (index >= s.Length)
            {
                return negative ? -answer : answer;
            }

            if (answer > int.MaxValue)
            {
                return (negative) ? int.MinValue : int.MaxValue;
            }

            char currentCharacter = s[index];

            if (currentCharacter == ' ' && !found)
            {
                return myAtoi(s, index + 1, answer, negative, found);
            }

            if ((currentCharacter == '-' || currentCharacter == '+') && !found)
            {
                negative = (currentCharacter == '-');
                return myAtoi(s, index + 1, answer, negative, true);
            }
            
            if (currentCharacter >= '0' && currentCharacter <= '9')
            {
                answer = answer * 10 + (currentCharacter - '0');
                if (answer > int.MaxValue) return (negative) ? int.MinValue : int.MaxValue;
                return myAtoi(s, index + 1, answer, negative, true);
            }

            return (negative) ? -answer : answer;
        }
    }
}