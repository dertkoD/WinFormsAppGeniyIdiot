namespace GeniyIdiotWindowsFormsApp
{
    partial class deleteQuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.textQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            this.saveQuestionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textQuestion,
            this.answerQuestion});
            this.questionsDataGridView.Location = new System.Drawing.Point(119, 70);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.RowHeadersWidth = 62;
            this.questionsDataGridView.RowTemplate.Height = 28;
            this.questionsDataGridView.Size = new System.Drawing.Size(509, 213);
            this.questionsDataGridView.TabIndex = 0;
            // 
            // textQuestion
            // 
            this.textQuestion.HeaderText = "Текст вопроса";
            this.textQuestion.MinimumWidth = 8;
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Width = 150;
            // 
            // answerQuestion
            // 
            this.answerQuestion.HeaderText = "Ответ на вопрос";
            this.answerQuestion.MinimumWidth = 8;
            this.answerQuestion.Name = "answerQuestion";
            this.answerQuestion.Width = 150;
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteQuestionButton.Location = new System.Drawing.Point(38, 341);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(161, 51);
            this.deleteQuestionButton.TabIndex = 1;
            this.deleteQuestionButton.Text = "Удалить";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // saveQuestionButton
            // 
            this.saveQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveQuestionButton.Location = new System.Drawing.Point(542, 341);
            this.saveQuestionButton.Name = "saveQuestionButton";
            this.saveQuestionButton.Size = new System.Drawing.Size(162, 51);
            this.saveQuestionButton.TabIndex = 2;
            this.saveQuestionButton.Text = "Сохранить";
            this.saveQuestionButton.UseVisualStyleBackColor = true;
            this.saveQuestionButton.Click += new System.EventHandler(this.saveQuestionButton_Click);
            // 
            // deleteQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveQuestionButton);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.questionsDataGridView);
            this.Name = "deleteQuestionsForm";
            this.Text = "deleteQuestionsForm";
            this.Load += new System.EventHandler(this.deleteQuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn textQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerQuestion;
        private System.Windows.Forms.Button deleteQuestionButton;
        private System.Windows.Forms.Button saveQuestionButton;
    }
}