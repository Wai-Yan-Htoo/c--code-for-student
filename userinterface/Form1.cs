using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userinterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string name, password, email, phno;
            name = txtusername.Text;
            password = txtpassword.Text;
            email = txtemail.Text;
            phno = txtphno.Text;
            login userlogin = new login(this.txtusername.Text,this.txtpassword.Text);
            userlogin.Show();
            this.Hide();
            MessageBox.Show(name + "," + password + "," + email + "," + phno);
            
        }
    }
}
