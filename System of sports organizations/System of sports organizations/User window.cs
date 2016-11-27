using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        // класс SqlConnection используется для создания
        // соединения с источником данных у провайдера Sql Server
        public SqlConnection con;
        // класс SqlCommand содержит команду
        public SqlCommand cmd;
        // класс SqlDataReader для чтения информации из БД
        public SqlDataReader dr;
        private void User_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cB_select.Text != "")
            {
                con = new SqlConnection();
                // задание строки связи
                con.ConnectionString = @"Data Source=DESKTOP-3H9C6CS\SQLEXPRESS; Initial Catalog=Kyrsovoy; Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                switch (cB_select.Text)
                {
                    case "Тренер":
                        {
                            cmd = new SqlCommand("Select * From dbo.Trainer", con);
                        }
                        break;
                    case "Спортсмен":
                        {
                            cmd = new SqlCommand("Select * From dbo.Sportsman", con);
                        }
                        break;
                    case "График соревнований":
                        {
                            string reg = "SELECT Com.id 'ID', Com.Name 'Name', Com.Data 'Data', SC.Name 'Sport complex' FROM dbo.Competition Com, dbo.SportComp SC WHERE Com.id_SportComp = SC.id";
                            cmd = new SqlCommand(reg, con);
                        }
                        break;
                    case "Результаты соревнований":
                        {
                            string reg = "SELECT CompetitionResults.id 'ID', Competition.Name 'Name',Sportsman.FIO 'FIO',SportComp.Name 'Sport complex', CompetitionResults.Result 'Result' FROM CompetitionResults LEFT OUTER join Competition ON CompetitionResults.id_Competition = Competition.id LEFT OUTER join SportComp ON CompetitionResults.id_SportComp = SportComp.id LEFT OUTER join Composition on CompetitionResults.id_Composition = Composition.id LEFT OUTER join Sportsman on Composition.id_Sportsman = Sportsman.id";
                            cmd = new SqlCommand(reg, con);
                        }
                        break;
                }
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dGV_show.DataSource = dt;
                con.Close();
                con.Dispose();
            }
            else
            {
                MessageBox.Show("Выберите вариант просмотра", "Сообщение", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void User_window_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            // задание строки связи
            con.ConnectionString = @"Data Source=DESKTOP-3H9C6CS\SQLEXPRESS; Initial Catalog=Kyrsovoy; Integrated Security=True";
        }

        private void cB_select_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }
    }
}
