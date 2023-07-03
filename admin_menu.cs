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
    public partial class admin_menu : Form
    {
        public admin_menu()
        {
            InitializeComponent();
        }

        private void admin_menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inquiry iq = new inquiry();
            iq.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change ch = new Change();
            ch.Show();
        }
    }
}
