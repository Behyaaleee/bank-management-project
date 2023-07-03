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
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }

        private void deposit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/moham/OneDrive/Desktop/Bank Service/bank_acc/Database.txt";
            string line = null;
            if (Form0.array[Form0.i] is Parent_Customer)
            {
                if (Convert.ToInt32(textBox1.Text) < 0)
                {
                    MessageBox.Show("Error! Need a postive number.");
                }
                else
                {
                    string aaa = Convert.ToString(Form0.array[Form0.i].balance);
                    Form0.array[Form0.i].Deposit(Convert.ToInt32(textBox1.Text));
                   
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
            else
            {

                if (Convert.ToInt32(textBox1.Text) < 0 && Form0.array[Form0.i].Balance>=1000 && (Form0.array[Form0.i].Balance + Convert.ToInt32(textBox1.Text)) >1000)
                {
                    MessageBox.Show("Check your Inputs:\n\t\tNeed a postive number.\n\t\tCannot exceed your Balance: "+ Form0.array[Form0.i].Balance);
                }
                else
                {
                    string aaa = Convert.ToString(Form0.array[Form0.i].balance);
                    Form0.array[Form0.i].Deposit(Convert.ToInt32(textBox1.Text));
                    //////////////////////////////////
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

                    ////////////////////////////////
                    // SAAAAMMMBOOOOO/BEEEEAAAAlY ADDD INTO DATABASE
                    MessageBox.Show("Thank You for your Transaction!");
                }
            }

        }
    }
}
