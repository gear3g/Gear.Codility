namespace Gear.Codility.Lib.Lessons {

    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
    /// </summary>
    /// <typeparam name="int"></typeparam>
    /// <typeparam name="FrogJmpArgument"></typeparam>
    public class FrogJmp : ILesson<int, FrogJmpArgument>
    {
        public int solution(FrogJmpArgument input)
        {
            var X = input.X;
            var Y = input.Y;
            var D = input.D;

            var distance = (Y - X);
            var jumps = distance / D;
            jumps += distance % D != 0 ? 1 : 0;

            return jumps;
        }
    }

    public class FrogJmpArgument {

        public int X { get; set; }

        public int Y { get; set; }

        public int D { get; set; }
    }
}