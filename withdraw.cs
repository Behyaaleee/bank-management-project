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
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/moham/OneDrive/Desktop/Bank Service/bank_acc/Database.txt";
            string line = null;
            
            if (Form0.array[Form0.i] is Parent_Customer)
            {
                
                if (Convert.ToDouble(textBox1.Text) < 0.0)
                {
                    MessageBox.Show("Error! Need a postive number.");
                }
                else
                {


                    string aaa = Convert.ToString(Form0.array[Form0.i].balance);
                    Form0.array[Form0.i].Withdraw(Convert.ToDouble(textBox1.Text));
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

                    fileContent = fileContent.Replace(aaa , Convert.ToString(Form0.array[Form0.i].Balance));

                    StreamWriter writer = new StreamWriter(File.OpenWrite(path));

                    writer.Write(fileContent);

                    writer.Close();

                    MessageBox.Show("Thank You for your Transaction!");
                }
            }
            else
            {
                if(Convert.ToDouble(textBox1.Text) < 200 & Convert.ToDouble(textBox1.Text) < 0)
                {
                    MessageBox.Show("Check your Inputs: \n\t\tNeed a postive number.\n\t\tCannot withdraw more than 200");
                }
                else
                {
                    string aaa = Convert.ToString(Form0.array[Form0.i].balance);
                    Form0.array[Form0.i].Withdraw(Convert.ToDouble(textBox1.Text));
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

                    MessageBox.Show("Thank You for your Transaction!");
                }

            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            main_menu f1 = new main_menu();
            f1.Show();
        }

        private void withdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
