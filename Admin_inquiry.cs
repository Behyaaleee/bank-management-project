using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_acc
{
    public partial class Admin_inquiry : Form
    {
        public Admin_inquiry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inquiry inq = new inquiry();
            inq.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form0.array[Form0.i].inquiry(textBox1.Text, Form0.array, Form0.i));
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
