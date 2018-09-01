using System;

namespace Gear.Codility.Lib.Lessons
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
    /// </summary>
    /// <typeparam name="int"></typeparam>
    /// <typeparam name="int"></typeparam>
    public class BinaryGroup : ILesson<int, int> {

        public int solution(int input) {
            int max = 0;
            int currentGap = 0;
            var binaryString = Convert.ToString(input, 2).ToString();;

           for (var i = 0; i < binaryString.Length; i++) {
                var current = binaryString[i];

                if (current == '1') {
                    if(currentGap > max) {
                        max = currentGap;
                    }
                    currentGap = 0;
                }

                if (current == '0') {
                    currentGap++;
                }
            }

            return max;
        }
    }
}
