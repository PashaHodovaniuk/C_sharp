using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Voice_command
{
    public partial class Add_Edit : Form
    {
        Form1 form = new Form1();
        public Add_Edit()
        {
            InitializeComponent();
        }

        private void Add_Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void tB_NameCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void tB_PronunciationCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void tB_CloseProcess_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void tB_PathFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b' && l != ':' && l != '\\')
            {
                e.Handled = true;
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Selected file run";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tB_PathFile.Text += openFileDialog1.FileName.ToString();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string[] temp = new string[4];
            temp[0] = form.dataGridView1.RowCount.ToString();
            temp[1] = tB_NameCommand.Text;
            temp[2] = tB_PronunciationCommand.Text;
            temp[3] = tB_PathFile.Text;
            temp[4] = tB_CloseProcess.Text;
            form.dataGridView1.Rows.Add(temp);
        }
    }
}
