using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;


namespace Voice_command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Choices cList1 = new Choices();
        SpeechRecognitionEngine sReconize = new SpeechRecognitionEngine();
        Choices cList2 = new Choices();
        Process myProcess;
        List<string> killProcess = new List<string>();
        string[] killProc;
        string[] call;
        string[] path;
        int numberOfRecords;
        int indexOfProcess = 0;
        bool flag = false;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void addCall(int count)
        {
            call = new string[count+2];
            killProc = new string[count];
            path = new string[count];
            call[0] = "Jaliks";
            call[1] = "exit";
            for (int i = 0; i < count; i++)
            {
                call[i+2] = dataGridView1[2, i].Value.ToString();
                path[i] = dataGridView1[3, i].Value.ToString();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_edit.Enabled = false;
            btn_start.Enabled = false;
            btn_delete.Enabled = false;
            startToolS.Enabled = false;
            stopToolS.Enabled = true;
            btn_stop.Enabled = true;
            numberOfRecords = dataGridView1.RowCount-1;
            addCall(numberOfRecords);
            cList2.Add(call);
            Grammar gr = new Grammar(new GrammarBuilder(cList2));
            try
            {
                sReconize.RequestRecognizerUpdate();
                sReconize.LoadGrammar(gr);
                sReconize.SpeechRecognized += sReconize_SpeechRecognized;
                sReconize.SetInputToDefaultAudioDevice();
                sReconize.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                MessageBox.Show("Err1", "Message!");
                return;
            }
        }

        private void sReconize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (flag)
            {
                runCommand(e);
                flag = false;
            }
            if (e.Result.Text.ToString() == "exit")
            {
                Application.Exit();
            }
            else
            {
                if (e.Result.Text.ToString() == "Jaliks")
                {
                    flag = true;
                }
            }            
    }

        private void runCommand(SpeechRecognizedEventArgs e)
        {
            foreach (string temp in call)
            {
                if (e.Result.Text.ToString() == temp)
                {
                    string s = temp;
                    char c = 'C';
                    int index = s.IndexOf(c);
                    if (index == 0)
                    {
                        if (indexOfProcess == 1)
                        {
                            CloseProcess();
                        }                        
                    }
                    else
                    {
                        StartProcess();
                    }
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            sReconize.RecognizeAsyncStop();
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_start.Enabled = true;
            btn_delete.Enabled = true;
            startToolS.Enabled = true;
            stopToolS.Enabled = false;
            btn_stop.Enabled = false;
        }
    }
}
