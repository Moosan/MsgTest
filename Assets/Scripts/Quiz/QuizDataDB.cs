using UnityEngine;
using MessagePack;
namespace Assets.Scripts.Quiz
{
    public class QuizDataDB
    {
        public static IQuizBody[] DB { get; } 
            = MessagePackSerializer.Deserialize<IQuizBody[]>((Resources.Load("quizarray") as TextAsset).bytes);
    }
}