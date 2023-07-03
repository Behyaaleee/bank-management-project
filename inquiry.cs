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
    public partial class inquiry : Form
    {
        public inquiry()
        {
            InitializeComponent();
        }

        private void inquiry_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Form0.array[Form0.i] is Parent_Customer || Form0.array[Form0.i] is Child_Customer)
                MessageBox.Show(Form0.array[Form0.i].Inquiry());
            else
                MessageBox.Show("ADMIN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form0.array[Form0.i] is Parent_Customer)
                MessageBox.Show(Form0.array[Form0.i].inquiry(Form0.array[Form0.i].Child, Form0.array, Form0.i));
            else
            {
                if (Form0.array[Form0.i] is Admin)
                {
                    this.Hide();
                    Admin_inquiry aq= new Admin_inquiry();
                    aq.Show();
                }
                else
                {
                    MessageBox.Show("Error! Child Accounts can use Inquiry on self account only.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
