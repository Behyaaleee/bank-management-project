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
using System.Runtime.Serialization;

namespace bank_acc
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }
        public static Bank[] array = new Bank[10];
        public static int i = 0;
        public static int j = 0;
        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            string bla = null;
            //int x = 0;
            string path = "C:/Users/moham/OneDrive/Desktop/Bank Service/bank_acc/Database.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    
                    bool is_child = true;
                    int x;
                    if (j == 0)
                    {
                        array[j] = new Admin(line.Substring(0, 6), line.Substring(7, 4));
                    }
                    else if (string.Equals(line.Substring(0, 6), array[0].CustomerID))
                    {
                        break;
                    }
                    else
                    {
                        for (x = 12; Convert.ToString(line[x])!= " " && x < (line.Length-1); x++)
                        {
                            bla += line[x];
                        }
                        


                        if (Int32.TryParse(Convert.ToString(line[line.Length-1]), out int y))
                        {
                            bla = bla + '0';
                            array[j] = new Child_Customer(line.Substring(0, 6), line.Substring(7, 4), Convert.ToDouble(bla));
                        }
                        else
                        {
                            array[j] = new Parent_Customer(line.Substring(0, 6), line.Substring(7, 4), Convert.ToDouble(bla));
                            int z;
                            for(z=12; !(Convert.ToString(line[z])==" ") ; z++)
                            {

                            }
                            string child = line.Substring(z+1);
                            //MessageBox.Show(Convert.ToString(child));
                            array[j].Child = child;
                        }

                    }
                    j++;
                    bla = null;
                }
            }
            this.Hide();
            start st = new start();
            st.Show();
        }
    }
}