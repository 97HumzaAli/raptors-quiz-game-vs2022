using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using Timer = System.Windows.Forms.Timer;

namespace RaptorsQuizA1HumzaAli
{
    public partial class Form2 : Form
    {
        QuestionsAnswers q1 = new QuestionsAnswers("What year did the Toronto Raptors win the NBA Championship?", "2016", "2017", "2018", "2019", "2019", "Seven ate ____.");
        QuestionsAnswers q2 = new QuestionsAnswers("Who was the Finals MVP?", "Kyle Lowry", "Vince Carter", "DeMar DeRozan", "Kawhi Leonard", "Kawhi Leonard", "This guy has big hands.");
        QuestionsAnswers q3 = new QuestionsAnswers("What was the playoff series score: Toronto Raptors Vs Orlando Magic", "4-1", "4-2", "4-3", "4-0", "4-1", "Rhymes with dive");
        QuestionsAnswers q4 = new QuestionsAnswers("What was the playoff series score: Toronto Raptors Vs Philadelphia Sixers", "4-1", "4-2", "4-3", "4-0", "4-3", "Series on the line");
        QuestionsAnswers q5 = new QuestionsAnswers("What was the playoff series score: Toronto Raptors Vs Milwaukee Bucks", "4-1", "4-2", "4-3", "4-0", "4-2", "Rhymes with licks");
        QuestionsAnswers q6 = new QuestionsAnswers("What was the playoff series score: Toronto Raptors Vs Golden State Warriors", "4-1", "4-2", "4-3", "4-0", "4-2", "Rhymes with sticks");
        QuestionsAnswers q7 = new QuestionsAnswers("Who did not play at all in the NBA Finals?", "Kevin Durant", "Klay Thompson", "OG Anunoby", "Kevon Looney", "OG Anunoby", "Original Gangsta");
        GenerateQA generateQA = new GenerateQA();
        QuestionsAnswers[] randomQa = new QuestionsAnswers[7];
        int question = 1;
        int score = 0;
        int timerValue = 60;
        public Form2(string playerName)
        {
            InitializeComponent();
            randomQa = generateQA.GenerateSequence(q1, q2, q3, q4, q5, q6, q7);
            txtBoxQuestion.Text = "";
            txtBoxPoints.Text = score.ToString();
            txtBoxPlayer.Text = playerName;
            ChangeQuestion(question);

        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
        }
        private void ChangeQuestion(int question)
        {
            btnOption1.BackColor = Color.Black;
            btnOption2.BackColor = Color.Black;
            btnOption3.BackColor = Color.Black;
            btnOption4.BackColor = Color.Black;
            btnOption1.Enabled = true;
            btnOption2.Enabled = true;
            btnOption3.Enabled = true;
            btnOption4.Enabled = true;
            switch (question)
            {
                case 1:
                    timerValue = 60;
                    lblQ1.BackColor = Color.Red;
                    txtBoxQuestion.Text = randomQa[0].Q;
                    btnOption1.Text = randomQa[0].O1;
                    btnOption2.Text = randomQa[0].O2;
                    btnOption3.Text = randomQa[0].O3;
                    btnOption4.Text = randomQa[0].O4;
                    timer1.Start();
                    txtBoxTimer.Visible = true;
                    break;
                case 2:
                    timerValue = 60;
                    lblQ2.BackColor = Color.Red;
                    txtBoxQuestion.Text = randomQa[1].Q;
                    btnOption1.Text = randomQa[1].O1;
                    btnOption2.Text = randomQa[1].O2;
                    btnOption3.Text = randomQa[1].O3;
                    btnOption4.Text = randomQa[1].O4;
                    timer1.Start();
                    txtBoxTimer.Visible = true;
                    break;
                case 3:
                    timerValue = 60;
                    lblQ3.BackColor = Color.Red;
                    txtBoxQuestion.Text = randomQa[2].Q;
                    btnOption1.Text = randomQa[2].O1;
                    btnOption2.Text = randomQa[2].O2;
                    btnOption3.Text = randomQa[2].O3;
                    btnOption4.Text = randomQa[2].O4;
                    timer1.Start();
                    txtBoxTimer.Visible = true;
                    break;
                case 4:
                    timerValue = 60;
                    lblQ4.BackColor = Color.Red;
                    txtBoxQuestion.Text = randomQa[3].Q;
                    btnOption1.Text = randomQa[3].O1;
                    btnOption2.Text = randomQa[3].O2;
                    btnOption3.Text = randomQa[3].O3;
                    btnOption4.Text = randomQa[3].O4;
                    timer1.Start();
                    txtBoxTimer.Visible = true;
                    break;
                case 5:
                    timerValue = 60;
                    lblQ5.BackColor = Color.Red;
                    txtBoxQuestion.Text = randomQa[4].Q;
                    btnOption1.Text = randomQa[4].O1;
                    btnOption2.Text = randomQa[4].O2;
                    btnOption3.Text = randomQa[4].O3;
                    btnOption4.Text = randomQa[4].O4;
                    timer1.Start();
                    txtBoxTimer.Visible = true;
                    break;
                case 6:
                    timerValue = 60;
                    lblQ6.BackColor = Color.Red;
                    txtBoxQuestion.Text = randomQa[5].Q;
                    btnOption1.Text = randomQa[5].O1;
                    btnOption2.Text = randomQa[5].O2;
                    btnOption3.Text = randomQa[5].O3;
                    btnOption4.Text = randomQa[5].O4;
                    timer1.Start();
                    txtBoxTimer.Visible = true;
                    break;
                case 7:
                    timerValue = 60;
                    lblQ7.BackColor = Color.Red;
                    txtBoxQuestion.Text = randomQa[6].Q;
                    btnOption1.Text = randomQa[6].O1;
                    btnOption2.Text = randomQa[6].O2;
                    btnOption3.Text = randomQa[6].O3;
                    btnOption4.Text = randomQa[6].O4;
                    timer1.Start();
                    txtBoxTimer.Visible = true;
                    break;
                default:
                    Form3 f3 = new Form3(txtBoxPlayer.Text, txtBoxPoints.Text);
                    this.Hide();
                    f3.Show();
                    break;

            }
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(txtBoxPoints.Text);
            var senderObject = (Button)sender;
            string option = senderObject.Text;
            if (option == randomQa[question - 1].A)
            {
                switch (question)
                {
                    case 1:
                        timer1.Stop();
                        points = points + 50;
                        txtBoxPoints.Text = points.ToString();
                        question++;
                        MessageBox.Show("Congratulations!");
                        ChangeQuestion(question);
                        break;
                    case 2:
                        timer1.Stop();
                        points = points + 100;
                        txtBoxPoints.Text = points.ToString();
                        question++;
                        MessageBox.Show("Congratulations!");
                        ChangeQuestion(question);
                        break;
                    case 3:
                        timer1.Stop();
                        points = points + 125;
                        txtBoxPoints.Text = points.ToString();
                        question++;
                        MessageBox.Show("Congratulations!");
                        ChangeQuestion(question);
                        break;
                    case 4:
                        timer1.Stop();
                        points = points + 250;
                        txtBoxPoints.Text = points.ToString();
                        question++;
                        MessageBox.Show("Congratulations!");
                        ChangeQuestion(question);
                        break;
                    case 5:
                        timer1.Stop();
                        points = points + 500;
                        txtBoxPoints.Text = points.ToString();
                        question++;
                        MessageBox.Show("Congratulations!");
                        ChangeQuestion(question);
                        break;
                    case 6:
                        timer1.Stop();
                        points = points + 750;
                        txtBoxPoints.Text = points.ToString();
                        question++;
                        MessageBox.Show("Congratulations!");
                        ChangeQuestion(question);
                        break;
                    case 7:
                        timer1.Stop();
                        points = points + 1000;
                        txtBoxPoints.Text = points.ToString();
                        question++;
                        MessageBox.Show("Congratulations!");
                        ChangeQuestion(question);
                        break;
                }
            }
            else
            {
                timer1.Stop();
                string option1 = btnOption1.Text;
                string option2 = btnOption2.Text;
                string option3 = btnOption3.Text;
                string option4 = btnOption4.Text;
                string answer = randomQa[question - 1].A;
                if (option1 == answer)
                {
                    btnOption1.BackColor = Color.Red;
                }
                if (option2 == answer)
                {
                    btnOption2.BackColor = Color.Red;
                }
                if (option3 == answer)
                {
                    btnOption3.BackColor = Color.Red;
                }
                if (option4 == answer)
                {
                    btnOption4.BackColor = Color.Red;
                }
                MessageBox.Show("Better Luck Next Time!");
                question++;
                ChangeQuestion(question);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtBoxTimer.Text = (timerValue--).ToString();
            if (timerValue == 0)
            {
                timer1.Stop();
                question++;
                ChangeQuestion(question);
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(randomQa[question - 1].H);
            btnHint.Enabled = false;
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            string option1 = btnOption1.Text;
            string option2 = btnOption2.Text;
            string option3 = btnOption3.Text;
            string option4 = btnOption4.Text;
            string answer = randomQa[question - 1].A;

            if (option1 == answer)
            {
                btnOption2.Enabled = false;
                btnOption3.Enabled = false;
            }
            if (option2 == answer)
            {
                btnOption4.Enabled = false;
                btnOption1.Enabled = false;
            }
            if (option3 == answer)
            {
                btnOption2.Enabled = false;
                btnOption4.Enabled = false;
            }
            if (option4 == answer)
            {
                btnOption2.Enabled = false;
                btnOption1.Enabled = false;
            }
            btn5050.Enabled = false;
        }
    }
}
