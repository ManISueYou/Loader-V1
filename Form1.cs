using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using TrinitySeal;
using System.IO;
using System.Threading;

//Welcome to TheSmarOne1's TrinitySeal Loader Source 
//Uses CreateRemoteThread injection.
//If you need any help dm me on discord at TheSmartOne1#2409


namespace Loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SealCheck.HashChecks();

           if (SealCheck.isValidDLL)
           {
            TrinitySeal.Seal.Secret = "Your Application Secret"; //Sets your application secret thing for the program 
             TrinitySeal.Seal.Initialize("Program version i.e 1.0"); //Carries out auto-update and grabs program variables  
           }

            

        }



        private void button1_Click(object sender, EventArgs e)
        {

            SealCheck.HashChecks();

            if (SealCheck.isValidDLL)
            {
                bool response = TrinitySeal.Seal.Login(txtUser.Text, txtPass.Text); //What your text boxes for login are
                if (response)
                {
                    new Form2().Show();
                    this.Hide();
                }
                else
                {

                }
            }

                
                

              

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SealCheck.HashChecks(); 

            if (SealCheck.isValidDLL)
            {

                bool response = TrinitySeal.Seal.Register(txtUser.Text, txtPass.Text, txtEmail.Text, txtToken.Text); //What Your Text Boxes for Register are.
                if (response)
                {
                    
                }
                else
                {
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.labelemail.Visible = true;
            this.labeltoken.Visible = true;
            this.txtToken.Visible = true;
            this.txtEmail.Visible = true;
            this.regbutton.Visible = true;
            this.logbutton.Visible = false;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.labelemail.Visible = false;
            this.labeltoken.Visible = false;
            this.txtToken.Visible = false;
            this.txtEmail.Visible = false;
            this.regbutton.Visible = false;
            this.logbutton.Visible = true;
            this.BackColor = System.Drawing.Color.Black;
        }

        private void txtToken_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
