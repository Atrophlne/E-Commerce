using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECommerceProj
{
    public partial class Account_Settings_Form : Form
    {
        string sql_acc = "Data Source=HAYASEYUUKA\\SQLEXPRESS;Initial Catalog=E_Commerce;Integrated Security=True";

        public Account_Settings_Form()
        {
            InitializeComponent();
            ch_Emtb.Hide();
            ch_codebtn.Hide();
            ch_codelbl.Hide();
            ch_codetb.Hide();
            ch_EMlbl.Hide();
            ch_pwlbl.Hide();
            ch_pwtb.Hide();
            ch_chngbtn.Hide();
            ch_curpwlbl.Hide();
            ch_curpwtb.Hide();

            del_codebtn.Hide();
            del_codelbl.Hide();
            del_codetb.Hide();
            del_EMlbl.Hide();
            del_emtb.Hide();
            del_pwlbl.Hide();
            del_pwtb.Hide();
            del_delbtn.Hide();

            Random rand = new Random();
            int rand1 = rand.Next(1000, 9999);
            del_codelbl.Text = "" + rand1;
            ch_codelbl.Text = "" + rand1;
        }

        // DELETE ACCOUNT
        // SIDE BUTTON
        private void acc_delbtn_Click(object sender, EventArgs e)
        {
            ch_Emtb.Hide();
            ch_codebtn.Hide();
            ch_codelbl.Hide();
            ch_codetb.Hide();
            ch_EMlbl.Hide();
            ch_pwlbl.Hide();
            ch_pwtb.Hide();
            ch_chngbtn.Hide();
            ch_curpwlbl.Hide();
            ch_curpwtb.Hide();

            del_codebtn.Show();
            del_codelbl.Show();
            del_codetb.Show();
            del_EMlbl.Show();
            del_emtb.Show();
            del_pwlbl.Show();
            del_pwtb.Show();
        }

        private void del_codebtn_Click(object sender, EventArgs e)
        {
            string EMAIL_USER = del_emtb.Text.ToString();
            string PASSWORD_USER = del_pwtb.Text.ToString();

            SqlConnection sql_con = new SqlConnection(sql_acc);
            sql_con.Open();


            string Code_ID = del_codelbl.Text.ToString();
            string Code_verification = del_codetb.Text.ToString();


            if (Code_ID == Code_verification)
            {
                try
                {
                    string cmd = "SELECT * FROM USERS_TABLE WHERE EMail = '"+EMAIL_USER+"'";
                    SqlDataAdapter sql_sda = new SqlDataAdapter(cmd, sql_con);

                    DataTable DT = new DataTable();
                    sql_sda.Fill(DT);

                    if (DT.Rows.Count > 0)
                    {
                        // Check if user is admin or not
                        if (PASSWORD_USER == "1234" && EMAIL_USER == "Admin")
                        {
                            MessageBox.Show("This is an Admin Account");
                            sql_con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Continue?");
                            del_delbtn.Show();
                            sql_con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql_con.Close();
                }
            }
            else
            {
                Random rand = new Random();
                int rand1 = rand.Next(1000, 9999);
                del_codelbl.Text = "" + rand1;
                MessageBox.Show("Invalid Verification Code!", "Wrong Code!");
            }
        }

        private void del_delbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sql_con = new SqlConnection(sql_acc);
            sql_con.Open();
            string ACCOUNT_TO_DELETE = del_emtb.Text.ToString();
            string Delete_acc = "DELETE USERS_TABLE WHERE EMail = '"+ACCOUNT_TO_DELETE+"'";

            SqlCommand sql_cmd = new SqlCommand(Delete_acc, sql_con);
            sql_cmd.ExecuteNonQuery();
            del_emtb.Text = "";
            del_pwtb.Text = "";
            del_codetb.Text = "";

            MessageBox.Show("Account Deleted Successfully!");
            sql_con.Close();
            Application.Restart();
        }

        // CHANGE PASSWORD
        // SIDE BUTTON
        private void acc_chbtn_Click(object sender, EventArgs e)
        {
            del_codebtn.Hide();
            del_codelbl.Hide();
            del_codetb.Hide();
            del_EMlbl.Hide();
            del_emtb.Hide();
            del_pwlbl.Hide();
            del_pwtb.Hide();
            del_delbtn.Hide();

            ch_Emtb.Show();
            ch_codebtn.Show();
            ch_codelbl.Show();
            ch_codetb.Show();
            ch_EMlbl.Show();
            ch_pwlbl.Show();
            ch_pwtb.Show();
            ch_curpwlbl.Show();
            ch_curpwtb.Show();
        }


        // Change PW 
        private void ch_codebtn_Click(object sender, EventArgs e)
        {

            string EMAIL_USER = ch_Emtb.Text.ToString();
            string NEW_PASSWORD_USER = ch_pwtb.Text.ToString();
            string CURRENT_PASSWORD = ch_curpwtb.Text.ToString();

            SqlConnection sql_con = new SqlConnection(sql_acc);
            sql_con.Open();



            string Code_ID = ch_codelbl.Text.ToString();
            string Code_verification = ch_codetb.Text.ToString();


            if (Code_ID == Code_verification)
            {
                try
                {
                    string cmd = "SELECT * FROM USERS_TABLE WHERE Contact_Number = '"+CURRENT_PASSWORD+"' AND EMail = '"+EMAIL_USER+"'";
                    SqlDataAdapter sql_sda = new SqlDataAdapter(cmd, sql_con);
                    DataTable DT = new DataTable();
                    sql_sda.Fill(DT);


                    if (DT.Rows.Count > 0)
                    {
                        // Check if user is admin or not
                        if (NEW_PASSWORD_USER == "1234" && EMAIL_USER == "Admin")
                        {
                            MessageBox.Show("This is an Admin Account");
                            sql_con.Close();
                        }
                        else
                        {
                            SqlConnection sql_con2 = new SqlConnection(sql_acc);
                            sql_con2.Open();
                            string sql_cnt = "SELECT * FROM USERS_TABLE WHERE Contact_Number LIKE '"+NEW_PASSWORD_USER+"'";
                            SqlCommand sql_ent_cmd = new SqlCommand(sql_cnt, sql_con2);
                            SqlDataReader sql_read_cnt = sql_ent_cmd.ExecuteReader();
                            if (sql_read_cnt.Read())
                            {
                                MessageBox.Show("This is Your Current Password");
                            }
                            else
                            {
                                MessageBox.Show("Continue?");
                                ch_chngbtn.Show();
                                sql_con.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql_con.Close();
                }
            }
            else
            {
                Random rand = new Random();
                int rand1 = rand.Next(1000, 9999);
                ch_codelbl.Text = "" + rand1;
                MessageBox.Show("Invalid Verification Code!", "Wrong Code!");
            }
        }

        private void ch_chngbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sql_con = new SqlConnection(sql_acc);
            sql_con.Open();
            string EMAIL_USER = ch_Emtb.Text.ToString();
            string NEW_PASSWORD_USER = ch_pwtb.Text.ToString();

            string change_pw = "UPDATE USERS_TABLE SET Contact_Number = '"+NEW_PASSWORD_USER+"' WHERE EMail = '"+EMAIL_USER+"'";

            SqlCommand sql_cmd = new SqlCommand(change_pw, sql_con);

            sql_cmd.ExecuteNonQuery();
            ch_Emtb.Text = "";
            ch_pwtb.Text = "";
            ch_curpwtb.Text = "";
            ch_codetb.Text = "";
            MessageBox.Show("Account Changed Successfully!");
            sql_con.Close();
        }
    }
}
