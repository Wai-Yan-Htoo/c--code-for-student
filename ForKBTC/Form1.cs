using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ForKBTC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader reader;
        string connstring = string.Format("server=localhost;uid=root;pwd=;database=db_kbtc");//  server information

        void insertfunc()
        {   //insert function to database  (database=db_kbtc,table=stu_registration)
            try
            {
                string name = txtname.Text;
                string email = txtemail.Text;
                string pwd = txtpassword.Text;
                conn = new MySqlConnection(connstring);
                conn.Open();
                string query = "insert into stu_registration(name,email,password) values('" + name + "','" + email + "','" + pwd + "')";
                command = new MySqlCommand(query, conn);
                adapter.InsertCommand = new MySqlCommand(query, conn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                conn.Close();
                MessageBox.Show("successes your data.");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void clear()
        {
            txtname.Clear();
            txtemail.Clear();
            txtpassword.Clear();
        }

        //code clean
        private void btnregister_Click(object sender, EventArgs e)
        {
            insertfunc();
            clear();

            login form_login = new login();
            form_login.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login form_login = new login();
            form_login.Show();
            this.Hide();
        }
    }
}
