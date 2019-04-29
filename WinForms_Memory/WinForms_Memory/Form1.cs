using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Memory
{
    public partial class Form1 : Form
    {
        DateTime time2, time = DateTime.MinValue;
        bool isPlaying = false;
        Button first, second;

        public Form1()
        {
            InitializeComponent();
            randomize();
        }

        private void randomize()
        {
            Random rnd = new Random();
            List<string> digits = new List<string>()
            {
                "0", "0", "1", "1", "2", "2", "3", "3",
                "4", "4", "5", "5", "6", "6", "7", "7"
            };

            Button button;
            int random;

            foreach(var elem in tableLayoutPanel2.Controls)
            {
                button = (Button)elem;
                button.Visible = true;
                button.BackColor = Color.AliceBlue;
                random = rnd.Next(0, digits.Count);
                button.Text = digits[random];
                digits.RemoveAt(random);
            }

        }

        private void UpDownLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor != Color.IndianRed)
                button.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor != Color.IndianRed)
                button.BackColor = Color.AliceBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimerLabel.Text = "0 s";

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (time == DateTime.MinValue)
                time = time2 = DateTime.Now;
            if (isPlaying == true)
            {
                isPlaying = false;
                timer1.Stop();
                PlayButton.Text = "Play";
            }
            else
            {
                isPlaying = true;
                timer1.Start();
                PlayButton.Text = "Pause";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time2 = time2.AddSeconds(1);
            var elapsed = time2.Subtract(time);
            TimerLabel.Text = ((int)elapsed.TotalSeconds).ToString() + " s";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlaying == false)
                return;

            if (first != null && second != null)
                return;

            Button clicked = sender as Button;
            if (clicked == null)
                return;

            if (clicked.BackColor == Color.IndianRed)
                return;

            if(first == null)
            {
                first = clicked;
                first.BackColor = Color.IndianRed;
                return;
            }

            second = clicked;
            second.BackColor = Color.IndianRed;

            if(first.Text == second.Text)
            {
                first.Visible = false;
                second.Visible = false;
                first = null;
                second = null;
            }
            else
            {
                first.BackColor = Color.AliceBlue;
                second.BackColor = Color.AliceBlue;
                first = null;
                second = null;
            }
            CheckForWinner();
        }

        private void CheckForWinner()
        {
            Button button;
            foreach(var elem in tableLayoutPanel2.Controls)
            {
                button = elem as Button;
                if (button != null && button.Visible == true)
                    return;
            }
            timer1.Stop();
            DialogResult dialogResult = MessageBox.Show("Your time: " + TimerLabel.Text + ". Do you want to play again?", "The End", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                randomize();
                time = DateTime.MinValue;
                isPlaying = false;
                PlayButton.Text = "Play";
                TimerLabel.Text = "0 s";

            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            randomize();
            timer1.Stop();
            time = DateTime.MinValue;
            isPlaying = false;
            PlayButton.Text = "Play";
            TimerLabel.Text = "0 s";
        }
    }
}
