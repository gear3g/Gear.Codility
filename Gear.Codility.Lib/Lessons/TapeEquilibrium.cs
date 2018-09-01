using System;

namespace Gear.Codility.Lib.Lessons {

    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
    /// </summary>
    /// <typeparam name="int"></typeparam>
    /// <typeparam name="int[]"></typeparam>
    public class TapeEquilibrium : ILesson<int, int[]> {

        public int Solution(int[] input) {
            var A = input;

            var N = A.Length;
            int min = 0;

            var sumA = A[0];
            var sumP = 0;

            for (int i = 1; i < N; i++) {
                sumP += A[i];
            }

            min = Math.Abs(sumA - sumP);

            if (N > 2) {
                for (int i = 1; i < (N - 1) ; i++) {
                    sumA += A[i];
                    sumP -= A[i];

                    var difference = Math.Abs(sumA - sumP);

                    if (difference < min)
                        min = difference;
                }
            }

            return min;
        }
    }
}