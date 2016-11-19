using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace Test_Voise_text
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBilder = new PromptBuilder();
        SpeechRecognitionEngine sReconize = new SpeechRecognitionEngine();
        private void btnGo_Click(object sender, EventArgs e)
        {
            pBilder.ClearContent();
            pBilder.AppendText(textBox1.Text);
            sSynth.Speak(pBilder);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            Choices cList = new Choices();
            cList.Add(new string[] {"Hello", "Start steam", "Jaliks","exit","Start chrome", "Сlose chrome", "Close steam" });
            Grammar gr = new Grammar(new GrammarBuilder(cList));            
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
                MessageBox.Show("Err1","Message!");
                return;
            }
        }

        Process myProcess;
        List<string> killProcess = new List<string>();
        string[] killProc = new string[10];
        private void sReconize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
            if (e.Result.Text.ToString() == "exit")
            {
                Application.Exit();
            }
            else
            {
                textBox1.Text += e.Result.Text.ToString() + " ";
                switch (e.Result.Text)
                {
                    case "Start chrome":
                        {
                            myProcess = Process.Start("chrome.exe");
                            // killProcess.Add(myProcess.ProcessName);
                            killProc[0] = myProcess.ProcessName.ToString();
                        }
                        break;
                    case "Сlose chrome":
                        //killProcess.Add(myProcess.ProcessName);
                        Process[] etc = Process.GetProcesses();//получим процессы
                        foreach (Process anti in etc)//обойдем каждый процесс
                        {
                            if (anti.ProcessName == killProc[0]) //найдем нужный и убьем
                            {
                                anti.Kill();
                                killProc[0] = "";
                                goto default;
                            }
                        }
                        break;
                    case "Start steam":
                        {
                            myProcess = Process.Start("E:\\stream\\steam.exe");
                            killProc[1] = myProcess.ProcessName.ToString();
                            //killProcess.Add(myProcess.ProcessName);
                        }
                        break;
                    case "Close steam":
                        //killProcess.Add(myProcess.ProcessName);
                        
                        Process[] etc1 = Process.GetProcesses();//получим процессы
                        foreach (Process anti in etc1)//обойдем каждый процесс
                        {
                            if (anti.ProcessName == killProc[1]) //найдем нужный и убьем
                            {
                                anti.Kill();
                                killProc[1] = "";
                                goto default;
                            }
                        }
                        break;
                    default:
                        break;
                }
                /*foreach (string s in killProcess)
                {
                    if (myProcess.ProcessName.ToLower().Contains(s.ToLower())) //найдем нужный и убьем
                    {
                        myProcess.Kill();
                    }
                }*/
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sReconize.RecognizeAsyncStop();
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
