using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_acc
{
    public class Bank
    {
        public string CustomerID { get; set; }
        public string Pass { get; set; }

        public double balance; 
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }
        
        public string Child { get; set; }
        public virtual void Withdraw(double x)
        {

        }
        public virtual void Deposit(double x)
        {

        }
        public virtual void Transfer(double x, string name, Bank[] B)
        {

        }
        public virtual string Inquiry()
        {
            return null;
        }
        public virtual string inquiry(string name, Bank[] B, int i)
        {
            return null;
        }
        public virtual void Change_Pass(string name, string pass, Bank[] B)
        {

        }
    }
    //creation of parent class
    public class Parent_Customer : Bank
    {
        //constructor to create a parent customer 
        public Parent_Customer(string name, string pass, double balance) : base()
        {
            CustomerID = name;
            Pass = pass;
            Balance = balance;
        }
        //deposit method
        public override void Deposit(double x)
        {
            Balance += x;
        }
        //withdraw method
        public override void Withdraw(double x)
        {
            if (x < Balance && x > 0)
                Balance -= x;
        }
        //transfer between accounts method
        public override void Transfer(double x, string name, Bank[] B)
        {
            int y = 0;
            Withdraw(x);
            for (y = 0;!(Form0.array[y].CustomerID == name); y++)
            {
            }
            B[y].Deposit(x);
        }
        //inquiry method
        public override string Inquiry()
        {
            return ToString();
        }
        public override string inquiry(string name, Bank[] B, int i)
        {
            int z;
            for(z=1; !(B[z].CustomerID==B[i].Child); z++)
            {
                if (z >= 10)
                {
                    return "has no child";
                }
            }
            return ("UserName: " + B[z].CustomerID + "\nPassword: " + B[z].Pass + "\nBalance= " + B[z].Balance);
            /*foreach (var k in B)
            {
                if (k.CustomerID == name && B[i].Child == name)
                    return ("UserName: " + k.CustomerID + "\nPassword: " + k.Pass + "\nBalance= " + k.Balance);
                else
                    return ("Name Not Found!");
            }*/
            //return ("Name Not Found!");
        }
        public override string ToString()
        {
            return ("UserName: " + CustomerID + "\nPassword: " + Pass + "\nBalance= " + Balance + "\nChild: " + Child);
        }
    }
    //creation of the child account 
    public class Child_Customer : Parent_Customer
            {
        //constructor to create a child account
        public Child_Customer(string name, string pass, double balance) : base(name, pass, balance)
                {
                    CustomerID = name;
                    Pass = pass;
                    Balance = balance;
                }
                public override void Deposit(double x)
                {
                    Balance += x;
                }
                public override void Withdraw(double x)
                {
                    if (x < Balance && x > 0)
                        Balance -= x;
                }
                public override string ToString()
                {
                    return ("UserName: " + CustomerID + "\nPassword: " + Pass + "\nBalance= " + Balance + "\nChild: " + Child);
                }
            }
        }
namespace bank_acc
{
    //creation of the admin class
    public class Admin : Bank
    {
        public Admin(string name, string pass)
        {
            CustomerID = name;
            Pass = pass;
        }
        //change password method
        public override void Change_Pass(string name, string pass, Bank[] B)
        {
            int y;
            for (y=0; !(B[y].CustomerID == name);y++)
            { }
                    B[y].Pass = pass;
        }
        public override string inquiry(string name, Bank[] B, int i)
        {

            int z;
            for (z = 1; !(B[z].CustomerID == name); z++)
            {
                if (z >= 10)
                {
                    return "has no child";
                }
            }
            return ("UserName: " + B[z].CustomerID + "\nPassword: " + B[z].Pass + "\nBalance= " + B[z].Balance);


           /* foreach (var k in B)
            {
                if (k.CustomerID == name)
                    return "UserName: " + k.CustomerID + "\nPassword: " + k.Pass + "\nBalance= " + k.Balance;
                else
                    return "Name Not Found!";
            }*/
            return null;
        }
    }
}

