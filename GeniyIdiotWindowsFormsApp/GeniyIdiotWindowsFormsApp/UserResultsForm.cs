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
    public partial class UserResultsForm : Form
    {
        private List<User> userResults;

        public UserResultsForm(List<User> users)
        {
            InitializeComponent();
            userResults = users;
        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            foreach (var userResult in userResults)
            {
                userResultsDataGridView.Rows.Add(userResult.Name, userResult.CountAnswer, userResult.Diagnose);
            }
        }
    }
}
