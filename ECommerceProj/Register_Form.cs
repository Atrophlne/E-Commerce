using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ECommerceProj
{
    public partial class Register_Form : Form
    {

        string sql_acc = "Data Source=HAYASEYUUKA\\SQLEXPRESS;Initial Catalog=E_Commerce;Integrated Security=True";
        public Register_Form()
        {
            InitializeComponent();
            reg_subm.Hide();

            Random rand = new Random();
            int rand1 = rand.Next(1000, 9999);
            verify_lbl.Text = "" + rand1;
        }

        private void verify_btn_Click(object sender, EventArgs e)
        {
            SqlConnection sql_con = new SqlConnection(sql_acc);
            SqlConnection sql_con2 = new SqlConnection(sql_acc);
            sql_con.Open();
            sql_con2.Open();
            try
            {
                // For Verification First
                string user_verification_input = verify_tb.Text.ToString();
                string code = verify_lbl.Text.ToString();

                // USER INPUTS
                string First_Name_input = reg_FN.Text.ToString();
                string Last_Name_input = reg_LN.Text.ToString();
                string Email_input = reg_EM.Text.ToString();

                string Add_input = reg_Add.Text.ToString();
                string CT_input = reg_CT.Text.ToString();



                bool check_FN = First_Name_input.All(char.IsDigit);
                bool check_LN = Last_Name_input.All(char.IsDigit);




                // Booleans are used to check if the First Name and Last name textbox have any Numbers
                if (check_FN == true)
                {
                    MessageBox.Show("First Name cannot contain any Numbers!", "Invalid");
                }
                else if (check_LN == true)
                {
                    MessageBox.Show("Last Name cannot contain any Numbers!", "Invalid");
                }
                else
                {

                    // Another try catch is used to catch if contact number has any input or has letters
                    try
                    {
                        long Cont_input = Convert.ToInt64(reg_CNT.Text);

                        string sql_em = "SELECT * FROM USERS_TABLE WHERE EMail='"+Email_input+"'";
                        SqlCommand sql_cmd_em = new SqlCommand(sql_em, sql_con);
                        SqlDataReader sql_read_em = sql_cmd_em.ExecuteReader();

                        string sql_cnt = "SELECT * FROM USERS_TABLE WHERE Contact_Number='"+reg_CNT.Text+"'";
                        SqlCommand sql_ent_cmd = new SqlCommand(sql_cnt, sql_con2);
                        SqlDataReader sql_read_cnt = sql_ent_cmd.ExecuteReader();


                        if (sql_read_em.Read())
                        {
                            MessageBox.Show("Email already Existed");
                        }
                        else if (sql_read_cnt.Read())
                        {
                            MessageBox.Show(" Contact Number already Existed");
                        }
                        else
                        {
                            if (user_verification_input == code)
                            {
                                MessageBox.Show("Verification Success!", "Confirmed");
                                reg_subm.Show();

                                // Disable editing
                                reg_FN.ReadOnly = true;
                                reg_FN.ReadOnly = true;
                                reg_EM.ReadOnly = true;
                                reg_Add.ReadOnly = true;
                                reg_CT.ReadOnly = true;
                                reg_CNT.ReadOnly = true;
                            }
                            else
                            {
                                // Randomize new Code
                                Random rand = new Random();
                                int rand1 = rand.Next(1000, 9999);
                                verify_lbl.Text = "" + rand1;
                                MessageBox.Show("Invalid Verification Code!", "Wrong Code!");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Contact Number Required!", "Invalid");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Code Error!");
            }
            sql_con.Close();
        }


        private void reg_subm_Click(object sender, EventArgs e)
        {
            string First_Name_input = reg_FN.Text.ToString();
            string Last_Name_input = reg_LN.Text.ToString();
            string Email_input = reg_EM.Text.ToString();
            string Add_input = reg_Add.Text.ToString();
            string CT_input = reg_CT.Text.ToString();
            long Cont_input = Convert.ToInt64(reg_CNT.Text);

            SqlConnection sql_con = new SqlConnection(sql_acc);
            sql_con.Open();
            if (sql_con.State==System.Data.ConnectionState.Open)
            {
                string add_val = "insert into USERS_TABLE(Last_Name,First_Name,EMail,Contact_Number,User_Address,User_City)values('"+Last_Name_input+"','"+First_Name_input+"'," +
                    "'"+Email_input+"','"+Cont_input+"','"+Add_input+"','"+CT_input+"')";
                SqlCommand coms = new SqlCommand(add_val, sql_con);

                coms.ExecuteNonQuery();

                MessageBox.Show("Account Now Registered!\nPlease use the Contact Number as Password!", "Confirmed!");

                reg_FN.Text = "";
                reg_LN.Text = "";
                reg_EM.Text = "";
                reg_Add.Text = "";
                reg_CT.Text = "";
                reg_CNT.Text = "";
                verify_tb.Text = "";

                reg_FN.ReadOnly = false;
                reg_LN.ReadOnly = false;
                reg_EM.ReadOnly = false;
                reg_Add.ReadOnly = false;
                reg_CT.ReadOnly = false;
                reg_CNT.ReadOnly = false;
                reg_subm.Hide();

                Random rand = new Random();
                int rand1 = rand.Next(1000, 9999);
                verify_lbl.Text = "" + rand1;
            }
            else
            {
                MessageBox.Show("SQL is OFFLINE!\nData is not saved!", "Error!");
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            reg_FN.Text = "";
            reg_LN.Text = "";
            reg_EM.Text = "";
            reg_Add.Text = "";
            reg_CT.Text = "";
            reg_CNT.Text = "";

            reg_FN.ReadOnly = false;
            reg_LN.ReadOnly = false;
            reg_EM.ReadOnly = false;
            reg_Add.ReadOnly = false;
            reg_CT.ReadOnly = false;
            reg_CNT.ReadOnly = false;
        }
    }
}
