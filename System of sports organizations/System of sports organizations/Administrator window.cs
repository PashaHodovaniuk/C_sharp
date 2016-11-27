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
    public partial class Administrator_window : Form
    {
        public Administrator_window()
        {
            InitializeComponent();
        }

        private void Administrator_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
