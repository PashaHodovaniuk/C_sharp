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
    public partial class F_Authorization : Form
    {
        public F_Authorization()
        {
            InitializeComponent();
        }

        private void F_Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tB_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b' && (l < '0' || l > '9'))
            {
                e.Handled = true;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if ((cB_login.Text == "") || (tB_password.Text == ""))
            {
                if (cB_login.Text == "")
                    MessageBox.Show("Вы не ввели логин!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tB_password.Text == "")
                    MessageBox.Show("Вы не ввели пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                switch (cB_login.Text)
                {
                    case "Администратор":
                        {
                            if(tB_password.Text == "asd123")
                            {
                                Administrator_window A = new Administrator_window();
                                A.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Вы ввели не верный пароль для данного логина","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                break;
                            }
                        }                        
                        break;
                    case "Пользователь":
                        {
                            if (tB_password.Text == "uyt321")
                            {
                                User_window A = new User_window();
                                A.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Вы ввели не верный пароль для данного логина", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
