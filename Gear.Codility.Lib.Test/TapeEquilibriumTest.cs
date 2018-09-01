using System;
using Xunit;

namespace Gear.Codility.Lib.Lessons {


    public class TapeEquilibriumTest {

        private TapeEquilibrium lesson;

        public TapeEquilibriumTest() {
            lesson = new TapeEquilibrium();
        }

        [Fact]
        public void TestSolutionInitial() {
            var input = new int[] {3, 1, 2, 4, 3};
            var result = lesson.Solution(input);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TestSolutionTwoElements() {
            var input = new int[] {1,1};
            var result = lesson.Solution(input);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TestSolutionSmallElements() {
            var input = new int[] {-10, -20, -30, -40, 100};
            var result = lesson.Solution(input);

            Assert.Equal(20, result);
        }

    }
}