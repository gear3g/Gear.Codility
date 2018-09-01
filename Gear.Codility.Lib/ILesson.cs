namespace Gear.Codility.Lib {

    public interface ILesson<TOutput, TInput> {

        TOutput solution(TInput input);
    }
}
