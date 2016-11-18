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
            cList.Add(new string[] {"Hello","test", "files", "open","thank you", "Jaliks","exit"});
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

        private void sReconize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.ToString() == "exit")
            {
                Application.Exit();
            }
            else
            {
                textBox1.Text += e.Result.Text.ToString() + " ";
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
