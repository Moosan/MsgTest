using MessagePack;
namespace Assets.Scripts.Quiz
{
    [Union(0,typeof(DefaultQuiz))]
    [Union(1,typeof(ChoiceQuiz))]
    [Union(2,typeof(ImageChoiceQuiz))]
    public interface IQuizBody {}

    [MessagePackObject]
    public class DefaultQuiz : IQuizBody
    {
        [Key(0)]
        public string Question { get; set; }
        [Key(1)]
        public string Answer { get; set; }
    }
    [MessagePackObject]
    public class ChoiceQuiz : IQuizBody
    {
        [Key(0)]
        public string Question { get; set; }
        [Key(1)]
        public string[] Choices { get; set; }
        [Key(2)]
        public int AnswerID { get; set; }
    }
    [MessagePackObject]
    public class ImageChoiceQuiz : IQuizBody
    {
        [Key(0)]
        public string Question { get; set; }
        [Key(1)]
        public string ImagePath { get; set; }
        [Key(2)]
        public string[] Choices { get; set; }
        [Key(3)]
        public int AnswerID { get; set; }
    }
}