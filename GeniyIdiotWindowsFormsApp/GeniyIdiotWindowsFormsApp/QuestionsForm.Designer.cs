namespace GeniyIdiotWindowsFormsApp
{
    partial class QuestionsForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.newQuestionTextBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(141, 26);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(308, 29);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Введите текст вопроса:";
            // 
            // newQuestionTextBox
            // 
            this.newQuestionTextBox.Location = new System.Drawing.Point(73, 102);
            this.newQuestionTextBox.Name = "newQuestionTextBox";
            this.newQuestionTextBox.Size = new System.Drawing.Size(438, 26);
            this.newQuestionTextBox.TabIndex = 1;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.Location = new System.Drawing.Point(146, 169);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(290, 29);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.Text = "Введите текст ответа:";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(73, 251);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(438, 26);
            this.answerTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(219, 328);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(149, 62);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 430);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.newQuestionTextBox);
            this.Controls.Add(this.questionLabel);
            this.Name = "QuestionsForm";
            this.Text = "QuestionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox newQuestionTextBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button addButton;
    }
}