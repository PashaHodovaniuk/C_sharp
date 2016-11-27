using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_of_sports_organizations
{
    public partial class User_window : Form
    {
        public User_window()
        {
            InitializeComponent();
        }

        private void User_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void User_window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kyrsovoyDataSet.CompetitionResults' table. You can move, or remove it, as needed.
            this.competitionResultsTableAdapter.Fill(this.kyrsovoyDataSet.CompetitionResults);

        }
    }
}
