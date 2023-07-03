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
    public partial class add_child : Form
    {
        public add_child()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_child_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/moham/OneDrive/Desktop/Bank Service/bank_acc/Database.txt";
            string line = null;
            if (textBox1.Text.Length == 5 && textBox2.Text.Length == 4 && Convert.ToDouble(textBox3.Text) > 0)
            {
                Form0.array[Form0.j] = new Child_Customer(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text));
                Form0.array[Form0.j].Child = textBox1.Text;
                Form0.j++;
                Form0.array[Form0.i].Child = textBox1.Text;

                //loop to find the index of wanted element
                using (StreamReader sr = new StreamReader(path))
                {
                    for (int k = 0; k <= Form0.i; k++)
                    {
                        line = sr.ReadLine();
                    }

                }
                StreamReader reader = new StreamReader(File.OpenRead(path));

                string fileContent = reader.ReadToEnd();//read file to end

                reader.Close();

                fileContent = fileContent.Replace(Form0.i+"non", Convert.ToString(Form0.array[Form0.i].Child)+"c");

                StreamWriter writer = new StreamWriter(File.OpenWrite(path));

                writer.Write(fileContent);

                writer.Close();
                string line1 = Environment.NewLine + textBox1.Text+"c" + " " + textBox2.Text + "0" + " " + textBox3.Text;
                File.AppendAllText(path, line1);

            }
            else //error case
            {
                MessageBox.Show("Check your inputs:\n\t\tusername should be 6 digits\n\t\tpassword should be 4\n\t\t Positive Balance");
            }
            MessageBox.Show("a child had been born");
            this.Close();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
