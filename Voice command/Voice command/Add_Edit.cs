using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Voice_command
{
    public partial class Add_Edit : Form
    {
        public Add_Edit()
        {
            InitializeComponent();
        }

        DataGridView dr;
        public string[] temp;

        public void Show(string temp, DataGridView param)
        {
            dr = param;
            if (temp == "Add")
            {
                this.Text = "Add command";
                btn_Add.Visible = true;
                btn_Edit.Visible = false;
                tB_CloseProcess.Text = "";
                tB_NameCommand.Text = "";
                tB_PathFile.Text = "";
                tB_PronunciationCommand.Text = "";
            }
            if (temp == "Edit")
            {
                this.Text = "Edit command";
                btn_Add.Visible = false;
                btn_Edit.Visible = true;
                tB_CloseProcess.Text = "";
                tB_NameCommand.Text = "";
                tB_PathFile.Text = "";
                tB_PronunciationCommand.Text = "";
                tB_NameCommand.Text = dr.Rows[dr.CurrentCell.RowIndex].Cells[1].Value.ToString();
                tB_CloseProcess.Text = dr.Rows[dr.CurrentCell.RowIndex].Cells[4].Value.ToString();
                tB_PronunciationCommand.Text = dr.Rows[dr.CurrentCell.RowIndex].Cells[2].Value.ToString();
                tB_PathFile.Text = dr.Rows[dr.CurrentCell.RowIndex].Cells[3].Value.ToString();
            }
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
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void tB_CloseProcess_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void tB_PathFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b' && l != ':' && l != '\\' && l != ' ')
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
            Form1 form = new Form1();
            temp = new string[5];
            temp[0] = dr.RowCount.ToString();
            temp[1] = tB_NameCommand.Text;
            temp[2] = tB_PronunciationCommand.Text;
            temp[3] = tB_PathFile.Text;
            temp[4] = tB_CloseProcess.Text;
            dr.Rows.Add(temp);
            Hide();
            form.Hide("Add", dr);            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            dr.Rows[dr.CurrentCell.RowIndex].Cells[0].Value = (dr.CurrentCell.RowIndex+1).ToString();
            dr.Rows[dr.CurrentCell.RowIndex].Cells[1].Value = tB_NameCommand.Text;
            dr.Rows[dr.CurrentCell.RowIndex].Cells[2].Value = tB_PronunciationCommand.Text;
            dr.Rows[dr.CurrentCell.RowIndex].Cells[3].Value = tB_PathFile.Text;
            dr.Rows[dr.CurrentCell.RowIndex].Cells[4].Value = tB_CloseProcess.Text;
            Hide();
            form.Hide("Edit", dr);
        }
    }
}
