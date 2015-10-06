using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.CoreAudioApi;

using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Data.OleDb;



namespace Sound2Play_Winform
{
    
    public partial class Sound2Play : Form
    {
        // =========================
        int soundValue = 0;
        int canvasHeight; // canvas height
        int canvasWidth; // canvas width
        //bool isGo = false;
        bool keepGoingUp = false;
        int ufoOriginalHeight;
        int ufoOriginalWidth;

        int soundDivisor = 15;
        int soundThreshold = 5;
        int gravity = 8;

        int soundForce = 0;

        // Voice Control #########################################################
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer Victor = new SpeechSynthesizer();
        Random random = new Random();
        string QEvent;
        string ProcWindow;
        //double timer = 10;
        int count = 1;

        private OleDbConnection conn;
        private OleDbCommand comm;
        bool isVictorOn = false;

        //bool goingRightByVictor = false;
        //bool goingLeftByVictor = false;
        //bool stopByVictor = false;

        // build connetion to database file(commands)
        private void BuildConnection()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s:\Documents\Visual Studio 2013\Projects\VICTOR.accdb;Persist Security Info=False;";
            conn.Open();
            comm = new OleDbCommand();
            comm.Connection = conn;
        }
        private void btnVoiceControl_Click(object sender, EventArgs e)
        {
            if (!isVictorOn)
            {
                Choices choices = new Choices();  // from dll
                //load commands form VICTOR.accdb
                try
                {
                    BuildConnection();
                    comm.CommandText = "SELECT Command FROM VICTOR";
                    OleDbDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        choices.Add(reader["Command"].ToString());
                    }
                    isVictorOn = true;
                    Victor.Speak("Data ready");
                }
                catch (Exception ex)
                {
                    isVictorOn = false;
                    Victor.Speak("Data missing");
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                GrammarBuilder gBuilder = new GrammarBuilder();
                gBuilder.Append(choices);
                Grammar grammar = new Grammar(gBuilder);
                _recognizer.LoadGrammarAsync(grammar);
                _recognizer.SetInputToDefaultAudioDevice();
                _recognizer.SpeechRecognized += _recognizer_SpeechRecognized;
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
            

        }// end of btnVoiceControl_Click

        void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            int ranNum = random.Next(1, 10);
            string speech = e.Result.Text;

            switch (e.Result.Text)
            {              
                // move right / east
                case "two":
                case "east":
                case "go east":
                case "right":
                case "go right":
                    if (ufo.Left < canvasWidth - ufoOriginalWidth - 30)
                    {
                        ufo.Left += 30;
                    }
                    break;

                // move left / west
                case "four":
                case "west":
                case "left":
                case "go west":
                case "go left":
                    if (ufo.Left > 30)
                    {
                        ufo.Left -= 30;
                    }
                    break;

                // move up / north
                case "one":
                case "up":
                case "go up":
                case "north":
                case "go north":
                    if (ufo.Top < 20)
                    {
                        ufo.Top -= 20;
                    }
                    break;

                // move down / south
                case "down":
                case "go down":
                case "south":
                case "go south":
                case "three":
                    if (ufo.Top > canvasHeight - ufoOriginalHeight - 20)
                    {
                        ufo.Top += 20;
                    }
                    break;

                // rotate ufo
                case "rotate":
                case "rotate victor":
                    Image img = ufo.Image;
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    ufo.Image = img;
                    break;

                case "hello":
                case "hello victor":
                    if (ranNum < 6) { Victor.Speak("Hello sir "); }
                    else if (ranNum > 5) { Victor.Speak("Hi "); }
                    break;

                case "goodbye":
                case "goodbye victor":
                case "close":
                case "close victor":
                    Victor.Speak("Until next time");
                    Close();
                    break;
                case "victor":
                    if (ranNum < 5) { QEvent = ""; Victor.Speak("Yes sir"); }
                    else if (ranNum > 4) { QEvent = ""; Victor.Speak("Yes?"); }
                    break;

                //Shell commands
                case "what time is it":
                    DateTime now = DateTime.Now;
                    string time = now.GetDateTimeFormats('t')[0];
                    Victor.Speak(time);
                    break;
                case "what day is it":
                    Victor.Speak(DateTime.Today.ToString("dddd"));
                    break;
                case "whats the date":
                case "whats todays date":
                    Victor.Speak(DateTime.Today.ToString("dd-MM-yyyy"));
                    break;

                default:
                    Victor.Speak("I can not understand it");
                    break;
                //Other commands
            }
        }// end of _recognizer_SpeechRecognized

        public Sound2Play()
        {
            InitializeComponent();
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            canvasHeight = canvas.Height;
            canvasWidth = canvas.Width;
            ufoOriginalHeight = ufo.Height;
            ufoOriginalWidth = ufo.Width;
            sbSoundDivisor.Minimum = 1;
            sbSoundDivisor.Maximum = 50;
            sbSoundDivisor.Value = 15;
            
            sbSoundThreshold.Minimum = 1;
            sbSoundThreshold.Maximum = 50;
            sbSoundThreshold.Value = 5;

            sbGravity.Minimum = 0;
            sbGravity.Maximum = 50;            
            sbGravity.Value = 8;


            soundDivisor = sbSoundDivisor.Value;
            soundThreshold = sbSoundThreshold.Value;
            gravity = sbGravity.Value;

            lbSoundDivisor.Text = (sbSoundDivisor.Value).ToString();
            lbSoundThreshold.Text = (sbSoundThreshold.Value).ToString();
            lbGravity.Text = (sbGravity.Value).ToString();

            if (rbKeepGoing.Checked)
            {
                lbUfoGravity.Visible = false;
                lbGravity.Visible = false;
                sbGravity.Visible = false;
                sbGravity.Value = 0;
                gravity = 0;
            }
            else
            {
                sbGravity.Visible = true;
            }
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {            
            // reset soundDivisor, soundThreshold
            soundThreshold = sbSoundThreshold.Value;
            //soundDivisor = sbSoundDivisor.Value;

            // Get Sound Value
            if (comboBox1.SelectedItem != null)
            {
                var device = (MMDevice)comboBox1.SelectedItem;
                soundValue = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                progressBar1.Value = soundValue;
                lbSoundValue.Text = soundValue.ToString();            
            }

            // Do with Sound Value
            if (rbManulPlay.Checked)
            {                
                //soundThreshold = sbSoundThreshold.Value;
                if (!hasCollision())
                {
                    if (soundValue >= soundThreshold)
                    {
                        goUpAsSound(true);
                    }
                    else
                    {
                        ufo.Top += gravity;
                    }
                }
            }
            else if(rbKeepGoing.Checked)// keep going
            {                
                if (soundValue >= soundThreshold)
                {
                    if (ufo.Top <= 0)
                    {
                        ufo.Top = 2;
                        ufo.Height = ufo.Height * 3 / 5;
                        keepGoingUp = !keepGoingUp;
                    }
                    else if (ufo.Top >= canvasHeight - ufo.Height)
                    {
                        ufo.Top = canvasHeight - ufo.Height - 2;
                        ufo.Height = ufo.Height * 3 / 5;
                        keepGoingUp = !keepGoingUp;
                    }
                    else
                    {
                        ufo.Height = ufoOriginalHeight;
                    }
                    goUpAsSound(keepGoingUp);
                }
                
                if (lbResult.Visible)
                {
                    lbResult.Visible = false;
                }
            }
            else if (rbKeepGoing2.Checked)
            {
                if (soundValue > soundThreshold)
                {
                    goWithDirectionBySoundValue();
                }
            }
                      
            lbUfoHeight.Text = string.Format("Height: {0} out of {1}", canvasHeight - ufo.Top, canvasHeight);
        }

        public void goWithDirectionBySoundValue()
        {
            soundForce = soundValue / soundDivisor;
            switch (soundValue % 12)
            {
                case 0:
                case 1:
                case 2:
                    if (ufo.Top < canvasHeight - ufoOriginalHeight)
                    {
                        ufo.Top += soundForce; // go down
                    }
                    else
                    {
                        ufo.Top = canvasHeight - ufoOriginalHeight;
                    }
                    break;

                case 3:
                case 4:
                case 5:
                    if (ufo.Top > 0)
                    {
                        ufo.Top -= soundForce;// go up
                    }
                    else
                    {
                        ufo.Top = 0;
                    }
                    break;

                case 6:
                case 7:
                case 8:
                    if (ufo.Left < canvasWidth - ufoOriginalWidth)
                    {
                        ufo.Left += soundForce; // go right
                    }
                    else
                    {
                        ufo.Left = canvasWidth - ufoOriginalWidth;
                    }
                    break;

                case 9:
                case 10:
                case 11:
                    if (ufo.Left > 0)
                    {
                        ufo.Left -= soundForce; // go left
                    }
                    else
                    {
                        ufo.Left = 0;
                    }
                    break;
                default:
                    break;
            }

        }

        public void goUpAsSound(bool up)
        {
            soundForce = soundValue / soundDivisor;

            switch (up)
            {
                case true:
                    ufo.Top -= soundForce;
                    break;
                case false:
                    ufo.Top += soundForce;
                    break;
            }

            if (rbKeepGoing.Checked)
            {
                lbCompositUpForce.Text = "Composite Force: " + (Math.Abs((soundForce - gravity))).ToString();
            }
            else
            {
                lbCompositUpForce.Text = "Composite Up Force: " + ((soundForce - gravity)).ToString();
            }

        }

        // to add +++++++++++++++++++++++++++++++++++


        public bool hasCollision()
        {
            if (ufo.Top >= canvasHeight - ufo.Height || ufo.Top <= 0)
            {
                lbResult.Text = "Sounds like over~~";
                lbResult.Visible = true;
                btnGo.Enabled = true;
                btnGo.ForeColor = Color.Blue;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void btnGo_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
            ufo.Top = canvasHeight / 5;
            lbResult.Visible = false;            
        }

        private void Sound2Play_SizeChanged(object sender, EventArgs e)
        {
            canvasHeight = canvas.Height;
            canvasWidth = canvas.Width;
        }
        private void rbKeepGoing2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKeepGoing2.Checked)
            {
                timer.Stop();
                timer.Start();

                sbGravity.Visible = false;
                lbGravity.Visible = false;
                lbUfoGravity.Visible = false;
                sbGravity.Value = 0;
                gravity = 0;                
            }
            else
            {
                sbGravity.Visible = true;
                lbGravity.Visible = true;
                lbUfoGravity.Visible = true;
            }
        }

        private void rbKeepGoing_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKeepGoing.Checked)
            {
                timer.Stop();
                timer.Start();
                sbGravity.Visible = false;
                lbGravity.Visible = false;
                lbUfoGravity.Visible = false;
                sbGravity.Value = 0;
                gravity = 0;
            }
            else
            {
                sbGravity.Visible = true;
                lbGravity.Visible = true;
                lbUfoGravity.Visible = true;
            }
        }

        private void sbSoundDivisor_Scroll(object sender, ScrollEventArgs e)
        {
            soundDivisor = sbSoundDivisor.Value;
            lbSoundDivisor.Text = (sbSoundDivisor.Value).ToString();
            
        }

        private void sbSoundThreshold_Scroll(object sender, ScrollEventArgs e)
        {
            soundThreshold = sbSoundThreshold.Value;
            lbSoundThreshold.Text = (sbSoundThreshold.Value).ToString();
        }

        private void sbGravity_Scroll(object sender, ScrollEventArgs e)
        {
            gravity = sbGravity.Value;
            lbGravity.Text = (sbGravity.Value).ToString();
        }


    }
}
