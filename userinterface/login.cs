using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userinterface
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public string Name1;
        public string Password;
        public login(string name,string password)
        {
            
            InitializeComponent();
            this.Name1=name;
            this.Password = password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login ll = new login();
            shop sh = new shop();
            if (Name1 == txtlogname.Text && Password == txtlogpassword.Text)
            {
                sh.Show();
            }
            this.Hide();

        }
    }
}
