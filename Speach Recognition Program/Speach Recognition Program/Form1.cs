using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Classes needed for speech recogntion.
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Speach_Recognition_Program
{
    public partial class frmSpeechrecogntion : Form
    {
        public frmSpeechrecogntion()
        {
            InitializeComponent();
        }

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        PromptBuilder pBuilder = new PromptBuilder(); 

        //Button allows program to read text and output it through a voice.
        private void btnReadTextBox_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent(); //First you need to clear whatever content you had in this PromptBuilder.
            pBuilder.AppendText(txtSpeechInput.Text);

            if (radFemale.Checked == true)
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                radMale.Checked = false;
            }
            else if (radMale.Checked == true)
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            }
            else
            {
                synthesizer.SelectVoiceByHints(VoiceGender.NotSet);
            }
            synthesizer.Speak(pBuilder); //Speaks whatever was read from the textbox.
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false; //Disables use of the button once you've clicked it.
            Choices wordList = new Choices(); //Stores words and phrases for the PC to recognise from user's speech input.
           
            //Adding words and phrases to the list.
            wordList.Add(new string[] { "today", "today's", "a", "speed", "keep", "yo", "no", "yeah", "yes", "yeah yuuh", "only", "the", "names", "name", "will", "change", "play", "never", "lose", "loser", "end", "without", "all",  "that", "glitters", "is", "not", "gold", "you", "lack", "tenacity", "you", "talk", "too", "to", "much", "clear textbox", "fills his victims full of dread", "period", "just", "when", "I", "come", "on", "gooodbye", "sing blue silver","we gone be alright", "nigga", "nigger", "niggas", "keke", "lopi", "liar", "exit", "speak", "hey", "hello", "bianca", "lopi", "good morning", "older", "this", "test", "shit", "fuck", "what", "so", "the", "go", "away", "flashing",  "lights", "what", "what's", "date", "today's", "time"});
            Grammar grProper = new Grammar(new GrammarBuilder(wordList));

            /**
            * Error handling for the speech recognition engine.
            */
            try
            {
                recEngine.RequestRecognizerUpdate();
                recEngine.LoadGrammar(grProper); //Loads the wordlist built into the grProper variable.
                recEngine.SpeechRecognized += recEngine_SpeechRecognized;

                //We set the audio input to be the default device - that being the computer's microphone.
                recEngine.SetInputToDefaultAudioDevice();
                recEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
        }

        //Method for speech recognition.
        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //Audio/Speech command for the shynthesizer to read what is in the textbox. 
            if (e.Result.Text == "speak")
            {
                btnStart.Enabled = true;
                btnReadTextBox_Click(sender, e);
            }
            //Just places a period when the word "period" is inputed throguh speech.
            else if (e.Result.Text == "period")
            {
                txtSpeechInput.Text += ".";
            }

            //Command for the application to stop.
            else if (e.Result.Text == "exit")
            {
                Application.Exit();
            }
            else if (e.Result.Text == "clear textbox")
            {
                txtSpeechInput.Clear();
            }
            else
            {
                txtSpeechInput.Text = txtSpeechInput.Text + " " + e.Result.Text.ToString();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void frmSpeechrecogntion_Load(object sender, EventArgs e)
        {

        }
    }
}
