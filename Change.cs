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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/moham/OneDrive/Desktop/Bank Service/bank_acc/Database.txt";
            //MessageBox.Show(Form0.array[Form0.i].inquiry(textBox1.Text, Form0.array, Form0.i)); // for inquiry
            int y;
            for (y = 0; !(Form0.array[y].CustomerID == textBox1.Text); y++)
            { }
                string user= Form0.array[y].CustomerID;
                string pass= Form0.array[y].Pass;
            Form0.array[Form0.i].Change_Pass(textBox1.Text,textBox2.Text, Form0.array);

            StreamReader reader = new StreamReader(File.OpenRead(path));

            string fileContent = reader.ReadToEnd();

            reader.Close();

            fileContent = fileContent.Replace(user + " "+ pass, Form0.array[y].CustomerID + " " + Form0.array[y].Pass);

            StreamWriter writer = new StreamWriter(File.OpenWrite(path));

            writer.Write(fileContent);

            writer.Close();

            MessageBox.Show("Password Changed!");
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_menu am = new admin_menu();
            am.Show();
        }

        private void Change_Load(object sender, EventArgs e)
        {

        }
    }
}
