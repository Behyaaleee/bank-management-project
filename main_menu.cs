using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bank_acc
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            withdraw wd = new withdraw();
            wd.Show();
            
        }

        private void inquiry_Click(object sender, EventArgs e)
        {
            this.Hide();
            inquiry iq = new inquiry();
            iq.Show();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            deposit dep = new deposit();
            dep.Show();
        }

        private void tranfere_Click(object sender, EventArgs e)
        {
            this.Hide();
            transfer trans = new transfer();
            trans.Show();
        }

        private void create_child_Click(object sender, EventArgs e)
        {

            //if(have child)
            if (Form0.array[Form0.i].Child == Form0.i+"non")
            {
                add_child ac = new add_child();
                this.Hide();
                ac.Show();
            }
            else
                MessageBox.Show("You already have a child.");
        }
    }
}
