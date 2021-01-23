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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader reader;
        string connstring = string.Format("server=localhost;uid=root;pwd=;database=db_kbtc");//  server information


        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string lemail = txtemail.Text;
                string lpwd = txtpassword.Text;
                conn = new MySqlConnection(connstring);
                conn.Open();
                string query = "select password from stu_registration where email='"+lemail+"'";
                command = new MySqlCommand(query, conn);
                reader = command.ExecuteReader();
                List<string> email = new List<string>();
                List<string> pwd = new List<string>();
                int j = 0;
                while (reader.Read())
                {
                    // email.Add(reader.GetValue(0).ToString());
                    pwd.Add(reader.GetValue(0).ToString());
                    j++;
                }
                for (int i = 0; i < j; i++)
                {
                    if (lpwd == pwd[i])
                    {
                        MessageBox.Show("success");
                        homepage hp = new homepage();
                        hp.Show();
                        this.Hide();
                    }
                }

                /*  for(int i = 0; i < j; i++)
                  {
                      if(lemail==email[i] && lpwd == pwd[i])
                      {
                          MessageBox.Show("login successes");
                      }
                  }*/
            }catch(Exception ex)
            {
                MessageBox.Show("email not found");
            }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {   //             0   1   2   3  4   5   6   7    8   9

            string[] email = { "winmyat@gmail.com", "thihasoe@gmail.com", "lwinlwinsoe@gmail.com", "waiyan@gmail.com" };
            int[] arr = { 50, 30, 40, 20, 10, 60, 70, 80, 90, 100 };
                    //    10  20  30  40  50  60  70  80  90  100
            string data = txtid.Text;
           // MessageBox.Show( arr[4].ToString());



            //linear search;
            for(int i = 0; i <4;i++)
            {
                if (data == email[i])
                {                //
                    MessageBox.Show($"email = {email[i]} , index = {i}");
                }
            }



            //    9  /   2 =       4
        }
    }
}
