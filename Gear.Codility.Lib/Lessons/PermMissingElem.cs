namespace Gear.Codility.Lib.Lessons {

    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
    /// </summary>
    /// <typeparam name="int"></typeparam>
    /// <typeparam name="int[]"></typeparam>
    public class PermMissingElem : ILesson<int, int[]> {

        public int solution(int[] input) {
            var A = input;

            int sum = 1;
            int arraySum = 0;
            int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum += i + 2;
                arraySum += A[i];
            }

            result = sum - arraySum;

            return result;
        }
    }

}