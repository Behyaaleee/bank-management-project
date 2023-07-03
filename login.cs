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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }

        private void modore_Click(object sender, EventArgs e)
        {
            this.Hide();
            start s = new start();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 1;
            string path = "C:/Users/moham/OneDrive/Desktop/Bank Service/bank_acc/Database.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int x = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string usernames = line.Substring(0, 6);
                    string passwords = line.Substring(7, 4);
                    if (usernames == textBox1.Text && passwords == textBox2.Text)
                    {
                        flag = 0;
                        if (Form0.array[x] is Child_Customer)
                        {
                            child_menu cm = new child_menu();
                            cm.Show();
                            Form0.i = x;

                            this.Close();
                        }
                        
                        else if (Form0.array[x] is Admin)
                        {
                            admin_menu am = new admin_menu();
                            am.Show();
                            Form0.i = x;
                            this.Close();
                        }
                        else if (Form0.array[x] is Parent_Customer)
                        {
                            main_menu mm = new main_menu();
                            mm.Show();
                            Form0.i = x;
                            this.Close();
                        }

                    }
                    x++;
                }
            }
            if (flag == 1)
            {
                MessageBox.Show("wrong username or password");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
