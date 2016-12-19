using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public static char[] mastex = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'є', 'ж', 'з', 'и', 'і', 'ї', 'й', 'к', 'л', 'м', 'н','о', 'п', 'р','с','т','у','ф','х','ц','ч','ш','щ','ь','ю','я',' '};
        public static int col = 33;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox2.Text;
            textBox3.Text = GronsfeldEncipher(textBox1.Text, textBox2.Text);
        }

        public static string GronsfeldEncipher(string text1, string text2)
        {
            string result = "";

            for (int i = 0; i < text1.Length; i++)
            {
                int j;
                for (j = 0; j < col; j++)
                {
                    if (text1[i] == mastex[j])
                    {
                        break;
                    }
                }
                int T = Int32.Parse(text2[((i) % (text2.Length))].ToString());


                result += mastex[indexOfEnc(j,T)];
            }
            return result;
        }

        public static int indexOfEnc(int j, int t)
        {
            int temp = j - t;
            if (temp<0)
            {
                return col + temp;
            }
            return temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = GronsfeldDecipher(textBox3.Text, textBox4.Text);
        }

        public static string GronsfeldDecipher(string text1, string text2)
        {
            string result = "";

            for (int i = 0; i < text1.Length; i++)
            {

                int j;
                for (j = 0; j < col; j++)
                {
                    if (text1[i] == mastex[j])
                    {
                        break;
                    }
                }
                int T = Int32.Parse(text2[((i) % (text2.Length))].ToString());


                result += mastex[indexOfDec(j, T)];
            }
            return result;
        }

        public static int indexOfDec(int j, int t)
        {
            int temp = j + t;
            if (temp >= col)
            {
                return temp - col;
            }
            return temp;
        }
    }
}
