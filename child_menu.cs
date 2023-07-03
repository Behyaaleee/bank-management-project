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
    public partial class child_menu : Form
    {
        public child_menu()
        {
            InitializeComponent();
        }

        private void child_menu_Load(object sender, EventArgs e)
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
    }
}
