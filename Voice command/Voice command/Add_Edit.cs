using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voice_command
{
    public partial class Add_Edit : Form
    {
        public Add_Edit()
        {
            InitializeComponent();
        }

        private void Add_Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
}
