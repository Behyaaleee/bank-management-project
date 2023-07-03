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
    public partial class start : Form
    {
        public login f3 = new login();
        public start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_up f2 = new sign_up();
            f2.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            f3.Show();
        }
    }
}
