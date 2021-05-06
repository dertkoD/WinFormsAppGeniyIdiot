using GeniyIdiotCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class deleteQuestionsForm : Form
    {
        private List<Questions> questionsAll;

        public deleteQuestionsForm(List<Questions> questions)
        {
            InitializeComponent();
            questionsAll = questions;
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgv in this.questionsDataGridView.SelectedRows)
            {
                questionsDataGridView.Rows.RemoveAt(dgv.Index);
            }
        }

        private void deleteQuestionsForm_Load(object sender, EventArgs e)
        {
            foreach (var question in questionsAll)
            {
                questionsDataGridView.Rows.Add(question.Text, question.Answer);
            }
        }

        private void saveQuestionButton_Click(object sender, EventArgs e)
        {
            var questions = new List<Questions>();

            for (int i = 0; i < questionsDataGridView.RowCount - 1; i++)
            {
                var textQuestion = questionsDataGridView[0, i].Value.ToString();
                var answerQuestions = questionsDataGridView[1, i].Value;
                questions.Add(new Questions(textQuestion, Convert.ToInt32(answerQuestions)));
            }

            QuestionsStorage.Save(questions);
            var mainForm = new MainForm();
            mainForm.ShowDialog(this);
            Close();
        }
    }
}
