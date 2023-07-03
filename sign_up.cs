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
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void modore_Click(object sender, EventArgs e)
        {
            this.Close();
            start f1 = new start();
            f1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            string path = "C:/Users/moham/OneDrive/Desktop/Bank Service/bank_acc/Database.txt";
            if(textBox1.Text.Length == 6 && textBox2.Text.Length == 4)
            {
                string line1 = Environment.NewLine + textBox1.Text + " " + textBox2.Text +" "+ "0.0" + " " +Form0.j+"non";
                using(StreamReader sr = new StreamReader(path))
                {
                    string line2;
                    int x = 0;
                    while((line2=sr.ReadLine()) != null){
                        if (textBox1.Text == line2.Substring(0,6))
                        {
                            flag1 = false;
                            break;
                        }
                        x++;
                    }
                    Form0.i = x;
                    Form0.j = x + 1;
                }
                if (flag1 == false)
                {
                    MessageBox.Show("username is already used");
                }
                else
                {
                    File.AppendAllText(path, line1);
                    main_menu mm = new main_menu();
                    Form0.array[Form0.i] = new Parent_Customer(textBox1.Text, textBox2.Text,0);
                    mm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("username should be 6 digits\npassword should be 4");
            }
        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }
    }
}
