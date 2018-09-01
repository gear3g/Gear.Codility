using System;

namespace Gear.Codility.Lib.Lessons {

    /// <summary>
    /// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
    /// </summary>
    /// <typeparam name="int[]"></typeparam>
    /// <typeparam name="CyclicRotationArgument"></typeparam>
    public class CyclicRotation : ILesson<int[], CyclicRotationArgument>
    {
        public int[] Solution(CyclicRotationArgument input)
        {
            var A = input.A;
            var K = input.K;

            var n = A.Length;
            var result = new int[n];
            K = n > 0 ? K % n : 0;

            for (int i = 0; i < n; i++) {
                var position = i - K;
                if (position < 0) position += n;

                result[i] = A[position];
            }

            return result;
        }
    }

    public class CyclicRotationArgument {

        public int[] A { get; set; }

        public int K { get; set; }
    }
}