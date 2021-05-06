using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeniyIdiotCommon
{
    public class Game
    {
        private List<Questions> questions;
        private Questions currentQuestion;
        private User user;
        private int currentQuestionNumber = 0;
        private int initialNumberOfQuestions;

        public Game(User user)
        {
            questions = QuestionsStorage.GetQuestions();
            initialNumberOfQuestions = questions.Count;
            this.user = user;
        }

        public Questions GetRandomQuestions()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];
            questions.Remove(currentQuestion);
            return currentQuestion;
        }

        public void SaveUserResult()
        {
            UserResultsStorage.AddNewUser(user);
        }

        public List<User> GetUsersResults()
        {
            return UserResultsStorage.GetAll();
        }

        public List<Questions> GetQuestionsAll()
        {
            return QuestionsStorage.GetQuestions();
        }

        public string GetQuestionNumberInfo()
        {
            currentQuestionNumber++;
            return "Вопрос №" + currentQuestionNumber;
        }

        public void CountTheUserAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.CountAnswer++;
            }
        }

        public string CalculateDiagnose()
        {
            return CalculationOfTheDiagnoses.Calculate(initialNumberOfQuestions, user);
        }

        public bool IsEnd()
        {
            return GetCountQuestions() == 0;
        }

        public void AddQuestion(Questions newQuestion)
        {
            questions.Add(newQuestion);

            QuestionsStorage.AddNewQuestion(newQuestion);
        }

        private int GetCountQuestions()
        {
            return questions.Count;
        }
    }
}
