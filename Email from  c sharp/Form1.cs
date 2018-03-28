using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Email_from__c_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
        
            SmtpClient client = new SmtpClient(smtp.Text); 

            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(username.Text, password.Text); 

            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail Sent!", "Success", MessageBoxButtons.OK);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
        }
   