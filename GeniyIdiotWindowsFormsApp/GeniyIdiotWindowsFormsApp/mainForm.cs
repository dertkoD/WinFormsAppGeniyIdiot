using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniyIdiotCommon;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Game game;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userAnswerTextBox.Focus();

            var fullNameUser = new FullNameUserForm();
            var dialogResult = fullNameUser.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var userName = fullNameUser.FullNameTextBox.Text;
                var user = new User(userName);
                game = new Game(user);

                ShowNextQuestion();
            }
            else
            {
                Close();
            }
        }

        private void ShowNextQuestion()
        {
            questionTextLabel.Text = game.GetRandomQuestions().Text;
            questionNumberLabel.Text = game.GetQuestionNumberInfo();

            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int userAnswer;
            var parsed = int.TryParse(userAnswerTextBox.Text, out userAnswer);
            if (!parsed)
            {
                MessageBox.Show("Пожалуйста, введите число!");
            }
            else
            {
                game.CountTheUserAnswer(userAnswer);

                if (game.IsEnd())
                {
                    var diagnose = game.CalculateDiagnose();
                    MessageBox.Show(diagnose);
                    game.SaveUserResult();
                    return;
                }
                ShowNextQuestion();
            }
        }

        private void предыдущиеРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = game.GetUsersResults();
            var userResultsForm = new UserResultsForm(user);
            userResultsForm.ShowDialog(this);
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.ShowDialog(this);
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionsForm = new QuestionsForm(game);
            questionsForm.ShowDialog(this);
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questions = game.GetQuestionsAll();
            var deleteQuestionsForm = new deleteQuestionsForm(questions);
            deleteQuestionsForm.ShowDialog(this);
        }
    }
}
