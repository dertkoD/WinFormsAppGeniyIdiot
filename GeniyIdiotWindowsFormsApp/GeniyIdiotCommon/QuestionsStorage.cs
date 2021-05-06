using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeniyIdiotCommon
{
    public class QuestionsStorage
    {
        public static string path = "questions.json";

        public static List<Questions> GetQuestions()
        {
            Init();
            var serializedQuestions = FileProvider.Get(path);
            var questions = JsonConvert.DeserializeObject<List<Questions>>(serializedQuestions);
            return questions;
        }

        public static void AddNewQuestion(Questions newQuestion)
        {
            var allQuestions = GetQuestions();
            allQuestions.Add(newQuestion);
            Save(allQuestions);
        }

        public static void Save(List<Questions> questions)
        {
            var serialized = JsonConvert.SerializeObject(questions, Formatting.Indented);

            FileProvider.Replace(path, serialized);
        }

        private static List<Questions> GetDefaultQuestions()
        {
            var questions = new List<Questions>();
            questions.Add(new Questions("Сколько будет два плюс два  умноженное на два?", 6));
            questions.Add(new Questions("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?", 9));
            questions.Add(new Questions("На двух руках 10 пальцев.Сколько пальцев на 5 руках ?", 25));
            questions.Add(new Questions("Укол делают каждые полчаса, сколько нужно минут для трех  уколов ?", 60));
            questions.Add(new Questions("Пять свечей горело, две  потухли. Сколько свечей  осталось?", 2));
            return questions;
        }

        private static void Init()
        {
            if (!FileProvider.IsExists(path))
            {
                var defaultQuestions = GetDefaultQuestions();
                Save(defaultQuestions);
            }
        }
    }
}
