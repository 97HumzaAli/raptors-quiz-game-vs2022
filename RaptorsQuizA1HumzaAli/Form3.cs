using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaptorsQuizA1HumzaAli
{
    public partial class Form3 : Form
    {
        public Form3(string name, string points)
        {
            InitializeComponent();
            txtBoxPlayer.Text = name;
            txtBoxPoints.Text = points;
        }

        private void txtBoxPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
