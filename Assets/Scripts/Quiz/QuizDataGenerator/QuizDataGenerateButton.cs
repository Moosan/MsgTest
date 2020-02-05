using UnityEditor;
using UnityEngine;
namespace Assets.Scripts.Quiz.QuizDataGenerator
{
    [CustomEditor(typeof(QuizDataGenerator))]
    public class QuizDataGenerateButton : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var generator = target as QuizDataGenerator;
            if (GUILayout.Button("Generate"))
            {
                generator.DataGenerate();
            }
        }
    }
}