using MessagePack;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.Quiz.QuizDataGenerator
{
    public class QuizDataGenerator : MonoBehaviour
    {
        public void DataGenerate()
        {
            var quizArray = new IQuizBody[]
            {
                new ChoiceQuiz(){ Question = "ギリシア神話に登場する、冥府の入り口を守る番犬は？", Choices = new string[]{"カローン","ハデス","ケルベロス" }, AnswerID = 2},
                new ChoiceQuiz(){ Question = "フギンとムニンという2羽のカラスを従えている、北欧神話における最高神は？", Choices = new string[]{"ゼウス","オーディン" }, AnswerID = 1 },
                new DefaultQuiz(){ Question = "1+2は？",Answer = "3"},
                new ImageChoiceQuiz(){Question = "これはだれ？", ImagePath = "Images/1.png", Choices = new string[]{"むーさん", "にーの", "たんの", "けいと", } }
            };

            var bin = MessagePackSerializer.Serialize(quizArray);

            var path = $"{Application.dataPath}/Resources/quizarray.bytes";
            File.WriteAllBytes(path, bin);
        }
    }
}