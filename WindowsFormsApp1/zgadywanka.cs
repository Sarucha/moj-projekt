using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// define used variables
        private int generatedNumber;
        private bool paused = false;
        private int time;
        private int triesCounter;
        List<play> plays = new List<play>();

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            /// reset game settings
            generatedNumber = 0;
            paused = false;
            time = 0;
            triesCounter = 0;
            CheckButton.Enabled = false;
            CheckButton.Visible = true;
            PauseButton.Enabled = false;
            PauseButton.Visible = true;
            NumbersFromTextBox.Text = "Number From";
            NumbersFromTextBox.Visible = true;
            NumbersToTextBox.Text = "Number To";
            NumbersToTextBox.Visible = true;
            GuessTextBox.Text = "Guess";
            GuessTextBox.Visible = true;
            HistoryButton.Visible = true;
            GenerateNumberButton.Visible = true;
            InformationsButton.Visible = true;
            labelTime.Visible = false;
            labelTries.Visible = false;
            labelGeneratedNumber.Visible = false;
            labelTime.Text = "Time: 0";
            Summarylabel.Text = "Insert Numbers from - to and press generate";
            Summarylabel.ForeColor = Color.Black;
            timerGame.Stop();

        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            /// pause game and resume when game is paused
            if(!paused)
            {
                timerGame.Stop();
                PauseButton.Text = "Resume";
                GenerateNumberButton.Enabled = false;
                paused = true;
                CheckButton.Enabled = false;
            }
            else
            {
                timerGame.Start();
                PauseButton.Text = "Pause";
                GenerateNumberButton.Enabled = true;
                paused = false;
                CheckButton.Enabled = true;
            }

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            /// check if number was inputed
            if(string.IsNullOrWhiteSpace(GuessTextBox.Text))
            {
                Summarylabel.Text = "Guess text is empty";
                Summarylabel.ForeColor = Color.Black;
                Summarylabel.Visible = true;
            }

            int trynumber = 0;
            try
            {
                trynumber = Convert.ToInt32(GuessTextBox.Text);
            }
            catch(Exception notNumber)
            {
                Summarylabel.Text = "Insert number";
                Summarylabel.ForeColor = Color.Black;
                Summarylabel.Visible = true;
            }
            /// compell numbers
            if(trynumber>generatedNumber)
            {
                triesCounter++;
                Summarylabel.Text = "To big";
                Summarylabel.ForeColor = Color.Red;
                Summarylabel.Visible = true;
                return;
            }
            else if(trynumber<generatedNumber)
            {
                triesCounter++;
                Summarylabel.Text = "To small";
                Summarylabel.ForeColor = Color.Red;
                Summarylabel.Visible = true;
            }
            else
            {
                triesCounter++;
                Summarylabel.Text = "Correct";
                Summarylabel.ForeColor = Color.Green;
                Summarylabel.Visible = true;
                /// showing results
                timerGame.Stop();
                labelTries.Text = "Number of tries: " + triesCounter;
                labelGeneratedNumber.Text = "Generated number: " + Convert.ToString(generatedNumber);
                labelTries.Visible = true;
                labelGeneratedNumber.Visible = true;
                CheckButton.Enabled = false;
                PauseButton.Enabled = false;
                /// add play object to list

                play Play = new play();
                Play.GeneratedNumber = generatedNumber;
                Play.NumberofTries = triesCounter;
                Play.Time = time;

                plays.Add(Play);
                
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            /// generates game history from objects in list plays
            History history = new History();

            ListView lview = new ListView();
            lview.Bounds = new Rectangle(new Point(12, 12), new Size(255, 215));
            lview.View = View.Details;
            lview.GridLines = true;
            lview.Scrollable = true;
            lview.Columns.Add("Generated Number", -2, HorizontalAlignment.Left);
            lview.Columns.Add("Number of Tries", -2, HorizontalAlignment.Left);
            lview.Columns.Add("Time", -2, HorizontalAlignment.Left);

            /// adding item
            foreach(play playitem in plays)
            {
                ListViewItem newItem = new ListViewItem(Convert.ToString(playitem.GeneratedNumber));
                newItem.SubItems.Add(Convert.ToString(playitem.NumberofTries));
                newItem.SubItems.Add(Convert.ToString(playitem.Time));
                lview.Items.Add(newItem);
            }

            history.Controls.Add(lview);
            history.Show();
        }

        private void GenerateNumberButton_Click(object sender, EventArgs e)
        {
            int from = 0;
            int to = 0;
            /// check if number is inserted correctly
            if (string.IsNullOrWhiteSpace(NumbersFromTextBox.Text))
            {
                Summarylabel.Text = "Insert Number From";
                Summarylabel.ForeColor = Color.Black;
                return;
            }

            if (string.IsNullOrWhiteSpace(NumbersToTextBox.Text))
            {
                Summarylabel.Text = "Insert Number To";
                Summarylabel.ForeColor = Color.Black;
                return;
            }
            /// generating number
            from = Convert.ToInt32(NumbersFromTextBox.Text);
            to = Convert.ToInt32(NumbersToTextBox.Text);

            if(from>to)
            {
                Summarylabel.Text = "From must be bigger than To";
                Summarylabel.ForeColor = Color.Black;
                Summarylabel.Visible = true;
                return;
            }

            Random generator = new Random();

            generatedNumber = generator.Next(from, to);


            timerGame.Start();
            time = 0;
            Summarylabel.Text = "Number Generated, go!";
            Summarylabel.ForeColor = Color.Black;
            PauseButton.Enabled = true;
            CheckButton.Enabled = true;
            labelTime.Visible = true;
            labelTries.Visible = false;
            labelGeneratedNumber.Visible = false;
        }

        private void InformationsButton_Click(object sender, EventArgs e)
        {
            /// showing author
            information info = new information();
            info.Show();
        }

        private void NumbersFromTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            NumbersFromTextBox.Text = " ";
        }

        private void NumbersToTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            NumbersToTextBox.Text = " ";
        }

        private void GuessTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            GuessTextBox.Text = " ";
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            time++;
            labelTime.Text = "Time: " + Convert.ToString(time);
        }

        /// handler for blocking character input
        private void NumbersfromTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void NumbersToTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void GuessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
