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
    public partial class QuestionsForm : Form
    {
        private Game game;

        public QuestionsForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int answer;
            var parsed = int.TryParse(answerTextBox.Text, out answer);
            if (!parsed)
            {
                MessageBox.Show("Введите число в строке ответов!");
            }
            else
            {
                var newQuestion = new Questions(newQuestionTextBox.Text, answer);
                game.AddQuestion(newQuestion);
                Close();
            }
        }
    }
}
