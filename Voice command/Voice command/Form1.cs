﻿using System;
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
        string[] killCall;
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
            dataGridView1.Rows.Add("1","Steam","Start steam", "E:\\stream\\Steam.exe", "Close steam");
            dataGridView1.Rows.Add("2", "Chrome", "Start chrome", "chrome.exe", "Close chrome");
        }
        public void addCall(int count)
        {
            call = new string[(count*3)];
            killProc = new string[count+3];
            killCall = new string[count];
            path = new string[count];
            call[0] = "Home";
            call[1] = "exit";
            int j = 0;
            for (int i = 2; i < count*3; i++)
            {
                call[i] = dataGridView1[2, j].Value.ToString();
                i++;                
                call[i] = dataGridView1[4, j].Value.ToString();
                killCall[j] = dataGridView1[4, j].Value.ToString();
                path[j] = dataGridView1[3, j].Value.ToString();
                j++;
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
                if ((e.Result.Text.ToString() == "Home") || (e.Result.Text.ToString() == "exit"))
                {
                    flag = false;
                    MessageBox.Show("Err!");
                    return;
                }          
                runCommand(e);
                flag = false;
            }
            if (e.Result.Text.ToString() == "exit")
            {
                Application.Exit();
            }
            else
            {
                if (e.Result.Text.ToString() == "Home")
                {
                    flag = true;
                    MessageBox.Show("Voice!");
                }
            }            
    }

        private void runCommand(SpeechRecognizedEventArgs e)
        {
            string s = e.Result.Text.ToString();
            char c = 'C';
            int index = s.IndexOf(c);
            if (index != 0)
            {
                foreach (string temp in call)
                {
                    if (e.Result.Text.ToString() == temp)
                    {
                        StartProcess(temp);
                        indexOfProcess++;
                        return;
                    }
                }
            }
            else
            {
                if (indexOfProcess > 0)
                {
                    foreach (string temp in killCall)
                    {
                        if (e.Result.Text.ToString() == temp)
                        {
                            CloseProcess(temp);
                            indexOfProcess--;
                            return;
                        }
                    }
                }
            }
        }

        private void CloseProcess(string temp)
        {
            Process[] etc = Process.GetProcesses();//получим процессы
            int index = int.Parse(findsPath(4, 0, temp));
            foreach (Process anti in etc)//обойдем каждый процесс
            {
                if (anti.ProcessName == killProc[index]) //найдем нужный и убьем
                {
                    anti.Kill();
                }
            }
            killProc[index] = "";
        }

        private void StartProcess(string temp)
        {
            myProcess = Process.Start(findsPath(2,3,temp));
            killProc[int.Parse(findsPath(2,0,temp))] = myProcess.ProcessName.ToString();
        }

        private string findsPath(int indexIn, int indexOut,string temp)
        {
            int dlinna = dataGridView1.RowCount;
            for (int i = 0; i < dlinna-1; i++)
            {
                if (this.dataGridView1[indexIn, i].Value.ToString() == temp)
                {
                    return dataGridView1[indexOut, i].Value.ToString();
                }
            }
            return "";
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
