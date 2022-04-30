using System.Media;
using System.Windows.Forms;

namespace W02
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();

        int addend1;
        int addend2;
        int minuend;
        int subtrahend;
        int multiplicand;
        int multiplier;
        int dividend;
        int divisor = 1;

        int timeLeft;
        DateTime today = DateTime.Today;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            todaysDate.Text = today.ToString("dd MMMM yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " seconds";

                if(timeLeft < 10)
                {
                    timeLabel.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotiant.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if(answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
            
            
        }

        private void checkAnswer_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");

            if ((answerBox.Name == "sum" && answerBox.Value == addend1 + addend2)
                || (answerBox.Name == "difference" && minuend - subtrahend == answerBox.Value)
                || (answerBox.Name == "product" && multiplicand * multiplier == answerBox.Value)
                || (answerBox.Name == "quotiant" && dividend / divisor == answerBox.Value))
            {
                simpleSound.Play();
            }
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void StartTheQuiz()
        {
            //Addition
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeft.Text = addend1.ToString();
            plusRight.Text = addend2.ToString();

            sum.Value = 0;

            //Subtraction
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);

            minusLeft.Text = minuend.ToString();
            minusRight.Text = subtrahend.ToString();

            difference.Value = 0;

            //Multiplication
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            multLeft.Text = multiplicand.ToString();
            multRight.Text = multiplier.ToString();

            product.Value = 0;

            //Division
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;

            divLeft.Text = dividend.ToString();
            divRight.Text = divisor.ToString();

            quotiant.Value = 0;

            //Start Timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

        }

        private bool CheckTheAnswer()
        {
            if((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotiant.Value))
                return true;
            else return false;

            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

    }
}