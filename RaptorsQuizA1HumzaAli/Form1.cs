using System.Security.Cryptography.Xml;
using System.Text.RegularExpressions;

namespace RaptorsQuizA1HumzaAli
{
    public partial class Form1 : Form
    {
        Regex nameException = new Regex(@"[0-9]");
        
        public Form1()
        {
            InitializeComponent();
            txtBoxName.MaxLength = 20;
            txtBoxName.PlaceholderText = "ENTER YOUR NAME";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (nameException.IsMatch(txtBoxName.Text) || txtBoxName.Text == "")
            {
                MessageBox.Show("Do not include digits in your name or leave name blank");
                txtBoxName.Text = "";
                return;
            }
            else
            {
                Form2 f2 = new Form2(txtBoxName.Text);
                this.Hide();
                f2.Show();
            }
        }
    }
}