namespace Gear.Codility.Lib {

    public interface ILesson<TOutput, TInput> {

        TOutput Solution(TInput input);
    }
}
