using System.Collections.Generic;

namespace Gear.Codility.Lib.Lessons {

    /// <summary>
    /// https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
    /// </summary>
    /// <typeparam name="int"></typeparam>
    /// <typeparam name="OddOccurrencesInArrayArgument"></typeparam>
    public class OddOccurrencesInArray : ILesson<int, OddOccurrencesInArrayArgument>
    {
        public int Solution(OddOccurrencesInArrayArgument input)
        {
            var A = input.A;
            var N = input.N;

            var baseList = new Dictionary<int, int>();
            int even = 0;

            foreach (var item in A)
            {
                if (!baseList.ContainsKey(item))
                    baseList[item] = 0;

                baseList[item]++;
            }

            foreach (var item in baseList)
            {
                if(item.Value % 2 == 1) {
                    even = item.Key;
                    break;
                }
            }

            return even;
        }
    }

    public class OddOccurrencesInArrayArgument {
        public int[] A { get; set; }

        public int N { get; set; }
    }
}