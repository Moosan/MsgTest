using UnityEngine;
using Assets.Scripts.Quiz;
public class MsgTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var quizArray = QuizDataDB.DB;
        foreach (var quizBody in quizArray)
        {
            switch (quizBody)
            {
                case DefaultQuiz quiz:
                    Debug.Log(quiz.Question);
                    Debug.Log(quiz.Answer);
                    break;
                case ChoiceQuiz quiz:
                    Debug.Log(quiz.Question);
                    Debug.Log(string.Join(",",quiz.Choices));
                    Debug.Log(quiz.Choices[quiz.AnswerID]);
                    break;
                case ImageChoiceQuiz quiz:
                    Debug.Log(quiz.Question);
                    Debug.Log(quiz.ImagePath);
                    Debug.Log(string.Join(",", quiz.Choices));
                    Debug.Log(quiz.Choices[quiz.AnswerID]);
                    break;
            }
        }
    }
}
