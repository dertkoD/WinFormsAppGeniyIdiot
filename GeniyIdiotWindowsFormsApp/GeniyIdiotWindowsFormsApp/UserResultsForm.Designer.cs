namespace GeniyIdiotWindowsFormsApp
{
    partial class UserResultsForm
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
            this.userResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countRightAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDiagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultsDataGridView
            // 
            this.userResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.countRightAnswers,
            this.userDiagnose});
            this.userResultsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.userResultsDataGridView.Name = "userResultsDataGridView";
            this.userResultsDataGridView.RowHeadersWidth = 62;
            this.userResultsDataGridView.RowTemplate.Height = 28;
            this.userResultsDataGridView.Size = new System.Drawing.Size(643, 364);
            this.userResultsDataGridView.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.HeaderText = "Имя пользователя";
            this.userName.MinimumWidth = 8;
            this.userName.Name = "userName";
            this.userName.Width = 150;
            // 
            // countRightAnswers
            // 
            this.countRightAnswers.HeaderText = "Кол-во правильных ответов";
            this.countRightAnswers.MinimumWidth = 8;
            this.countRightAnswers.Name = "countRightAnswers";
            this.countRightAnswers.Width = 150;
            // 
            // userDiagnose
            // 
            this.userDiagnose.HeaderText = "Диагноз";
            this.userDiagnose.MinimumWidth = 8;
            this.userDiagnose.Name = "userDiagnose";
            this.userDiagnose.Width = 150;
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 426);
            this.Controls.Add(this.userResultsDataGridView);
            this.Name = "UserResultsForm";
            this.Text = "UserResultsForm";
            this.Load += new System.EventHandler(this.UserResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn countRightAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDiagnose;
    }
}