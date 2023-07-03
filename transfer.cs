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
    public partial class transfer : Form
    {
        public transfer()
        {
            InitializeComponent();
        }

        private void transfer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/moham/OneDrive/Desktop/Bank Service/bank_acc/Database.txt";
            string line = null;
            if (textBox1.Text.Length == 6 && Convert.ToDouble(textBox2.Text) > 0)
            {
                int y;
                for (y = 0; !(Form0.array[y].CustomerID == textBox1.Text); y++)
                {
                }
                string aaa = Convert.ToString(Form0.array[Form0.i].balance);//store main acc balance
                string bbb = Convert.ToString(Form0.array[y].balance);//store rec acc balance

                

                Form0.array[Form0.i].Transfer(Convert.ToDouble(textBox2.Text), textBox1.Text, Form0.array);
                withdraw main_acc = new withdraw();
                
                using (StreamReader sr = new StreamReader(path))
                {
                    for (int k = 0; k <= Form0.i; k++)
                    {
                        line = sr.ReadLine();
                    }

                }
                StreamReader reader = new StreamReader(File.OpenRead(path));

                string fileContent = reader.ReadToEnd();

                reader.Close();

                fileContent = fileContent.Replace(aaa, Convert.ToString(Form0.array[Form0.i].Balance));

                StreamWriter writer = new StreamWriter(File.OpenWrite(path));

                writer.Write(fileContent);

                writer.Close();
                using (StreamReader sr = new StreamReader(path))
                {
                    for (int k = 0; k <= y; k++)
                    {
                        line = sr.ReadLine();
                    }

                }
                reader = new StreamReader(File.OpenRead(path));

                fileContent = reader.ReadToEnd();

                reader.Close();
                MessageBox.Show(Convert.ToString(Form0.array[y].Balance));
                fileContent = fileContent.Replace(bbb, Convert.ToString(Form0.array[y].Balance));

                writer = new StreamWriter(File.OpenWrite(path));

                writer.Write(fileContent);

                writer.Close();
                MessageBox.Show("transfer successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Check your inputs:\n\t\tusername should be 6 digits\n\t\tpassword should be 4\n\t\t Positive Balance");
            }
        }
    }
}
