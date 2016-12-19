using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Diagnostics;
using System.IO;

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
        public static bool fSave = false;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            SaveOfExit();                        
        }

        private void SaveOfExit()
        {
            if (fSave)
            {
                DialogResult result = MessageBox.Show("Были проведены изменения, не хотели бы вы сохранить их?", "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                    Application.Exit();

                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveOfExit();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            const string fileNameToOpen = "DB\\Data commands.txt";
            var filePathToOpen = Path.Combine(applicationDirectory, fileNameToOpen);
            StreamReader rd = new StreamReader(filePathToOpen);
            string[] str;
            string inpstr;
            char[] delim = new char[] { '|' };//Разделители
            while ((inpstr = rd.ReadLine()) != null)
            {
                str = inpstr.Split(delim);//Разбиваем строку на отдельные строки по разделителям
                dataGridView1.Rows.Add(str);
            }
            rd.Close();
        }

        public void addCall(int count)
        {
            call = new string[(count*2)+2];
            killProc = new string[count+3];
            killCall = new string[count];
            path = new string[count];
            call[0] = "Play";
            call[1] = "Exit";
            int j = 0;
            for (int i = 2; i < (count*2)+2; i++)
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
                if ((e.Result.Text.ToString() == "Play") || (e.Result.Text.ToString() == "Exit"))
                {
                    flag = false;
                    System.Console.Beep(333, 1000);
                    return;
                }
                runCommand(e);
                flag = false;
            }
            if (e.Result.Text.ToString() == "Exit")
            {
                SaveOfExit();
            }
            else
            {
                if (e.Result.Text.ToString() == "Play")
                {
                    flag = true;
                    System.Console.Beep(200, 500);
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            SaveFile();
        }

        private void SaveFile()
        {
            var applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            const string fileNameToOpen = "DB\\Data commands.txt";
            var filePathToOpen = Path.Combine(applicationDirectory, fileNameToOpen);
            TextWriter write = new StreamWriter(filePathToOpen);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    write.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "|");
                }
                write.WriteLine();
            }
            write.Close();
            fSave = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_Edit temp = new Add_Edit();
            temp.Show();
            temp.Show("Add", dataGridView1);         
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Add_Edit temp = new Add_Edit();
            temp.Show();
            temp.Show("Edit", dataGridView1);
        }
        
        public void Hide(string temp, DataGridView param)
        {
            dataGridView1 = param;
            dataGridView1.Refresh();
            fSave = true;                 
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(ind);
            int j = 1;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = j.ToString();
                j++;
            }
            fSave = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutVoiceCommand a = new AboutVoiceCommand();
            a.Show();
        }
    }
}
