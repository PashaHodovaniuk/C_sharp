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
    public partial class Administrator_window : Form
    {
        public Administrator_window()
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
        public SqlDataAdapter da;
        DataTable dt;

        private void Administrator_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
            con.Dispose();
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
                            string reg = "SELECT Com.id, Com.Name, Com.Data, SC.Name FROM dbo.Competition Com, dbo.SportComp SC WHERE Com.id_SportComp = SC.id";
                            cmd = new SqlCommand(reg, con);
                        }
                        break;
                    case "Результаты соревнований":
                        {
                            string reg = "SELECT CompetitionResults.id, Competition.Name,Sportsman.FIO,SportComp.Name, CompetitionResults.Result FROM CompetitionResults LEFT OUTER join Competition ON CompetitionResults.id_Competition = Competition.id LEFT OUTER join SportComp ON CompetitionResults.id_SportComp = SportComp.id LEFT OUTER join Composition on CompetitionResults.id_Composition = Composition.id LEFT OUTER join Sportsman on Composition.id_Sportsman = Sportsman.id";
                            cmd = new SqlCommand(reg, con);
                        }
                        break;
                }
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dGV_show.DataSource = dt;
                con.Close();
                con.Dispose();
                cB_Search.Items.Clear();
                for (int i = 0; i < dGV_show.Columns.Count; i++)
                {
                    cB_Search.Items.Add(dGV_show.Columns[i].Name.ToString());
                }
                cB_Search.Enabled = true;
                tB_Search.Enabled = true;
                btn_Search.Enabled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cB_Search.Text != "" || tB_Search.Text != "")
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
                            cmd = new SqlCommand("Select * From dbo.Trainer WHERE " + cB_Search.Text + "=" + tB_Search.Text + "", con);
                        }
                        break;
                    case "Спортсмен":
                        {
                            cmd = new SqlCommand("Select * From dbo.Sportsman WHERE " + cB_Search.Text + "=" + tB_Search.Text + "", con);
                        }
                        break;
                    case "График соревнований":
                        {
                            string reg = "SELECT Com.id, Com.Name, Com.Data, SC.Name FROM dbo.Competition Com, dbo.SportComp SC WHERE Com.id_SportComp = SC.id " + cB_Search.Text + "=" + tB_Search.Text + "";
                            cmd = new SqlCommand(reg, con);
                        }
                        break;
                    case "Результаты соревнований":
                        {
                            string reg = "SELECT CompetitionResults.id , Competition.Name ,Sportsman.FIO,SportComp.Name , CompetitionResults.Result  FROM CompetitionResults LEFT OUTER join Competition ON CompetitionResults.id_Competition = Competition.id LEFT OUTER join SportComp ON CompetitionResults.id_SportComp = SportComp.id LEFT OUTER join Composition on CompetitionResults.id_Composition = Composition.id LEFT OUTER join Sportsman on Composition.id_Sportsman = Sportsman.id WHERE " + cB_Search.Text + "=" + tB_Search.Text + "";
                            cmd = new SqlCommand(reg, con);
                        }
                        break;
                }
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dGV_show.DataSource = dt;
                
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dGV_show.DataSource;
            da.Update(dt);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }
    }
}
