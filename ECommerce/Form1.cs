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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ECommerce
{
    public partial class Form1 : Form
    {

        // this is the sql data source
        string sql_ds = "Data Source=HAYASEYUUKA\\SQLEXPRESS;Initial Catalog=e_com_test;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        /* ----------------------------------------------------------- HIDING BUTTON RETURN FUNCTIONS ONLY -----------------------------------------------------------*/
        void Hide_Admin()
        {
            adm_fnlb.Hide();
            adm_lnlb.Hide();
            adm_cnlb.Hide();
            adm_fn.Hide();
            adm_ln.Hide();
            adm_cn.Hide();
            adm_dbtn.Hide();
            adm_vbtn.Hide();
            adm_verlb.Hide();
            adm_ver.Hide();
            adm_acc.Hide();
            add_btn.Hide();
            wh_btn.Hide();
        }
        void Hide_Register()
        {
            reg_FN.Hide();
            reg_fnlb.Hide();
            reg_LN.Hide();
            reg_lnlb.Hide();
            reg_cn.Hide();
            reg_cnlb.Hide();
            reg_add.Hide();
            reg_addlb.Hide();
            reg_submit.Hide();
        }
        void Hide_NNAdmin()
        {

        }

        void Hide_DelAcc()
        {
            adm_vbtn.Hide();
            adm_verlb.Hide();
            adm_ver.Hide();
            adm_ln.Hide();
            adm_fn.Hide();
            adm_cn.Hide();
            adm_cnlb.Hide();
            adm_lnlb.Hide();
            adm_fnlb.Hide();
            adm_cnlb.Hide();
        }

        void Hide_Login()
        {
            log_pass.Hide();
            log_passlb.Hide();
            log_user.Hide();
            log_userlb.Hide();
            log_insub.Hide();
        }
        /* ----------------------------------------------------------- HIDING BUTTON INPUTS ONLY -----------------------------------------------------------*/
        private void Form1_Load(object sender, EventArgs e)
        {
            // Always show login only
            log_pass.Show();
            log_passlb.Show();
            log_user.Show();
            log_userlb.Show();
            log_insub.Show();

            lout_btn.Hide();

            prod_btn.Hide();
            prod_list.Hide();


            Hide_Admin();
            Hide_NNAdmin();
            Hide_Register();
        }

        // LOGIN BUTTON
        private void log_btn_Click(object sender, EventArgs e)
        {
            glob_label.Text = "Login";
            Hide_Admin();
            Hide_NNAdmin();
            Hide_Register();

            log_pass.Show();
            log_passlb.Show();
            log_user.Show();
            log_userlb.Show();
            log_insub.Show();
        }

        // REGISTER BUTTON
        private void reg_btn_Click(object sender, EventArgs e)
        {
            glob_label.Text = "Register an Account";
            Hide_Admin();
            Hide_Login();
            Hide_NNAdmin();


            reg_FN.Show();
            reg_fnlb.Show();
            reg_LN.Show();
            reg_lnlb.Show();
            reg_cn.Show();
            reg_cnlb.Show();
            reg_add.Show();
            reg_addlb.Show();
            reg_submit.Show();
        }

        // ADD PRODUCT BUTTON
        private void add_btn_Click(object sender, EventArgs e)
        {
            glob_label.Text = "Add Products";
            adm_dbtn.Hide();
            Hide_Login();
            Hide_NNAdmin();
            Hide_Register();
            Hide_DelAcc();
        }


        // WAREHOUSE BUTTON
        private void wh_btn_Click(object sender, EventArgs e)
        {
            adm_dbtn.Hide();
            glob_label.Text = "Warehouse";
            Hide_Login();
            Hide_NNAdmin();
            Hide_Register();
            Hide_DelAcc();
        }


        // CART BUTTON
        private void cart_btn_Click(object sender, EventArgs e)
        {
            glob_label.Text = "Your Cart";
            prod_list.Hide();
            Hide_Admin();
            Hide_Login();
            Hide_NNAdmin();
            Hide_Register();
            Hide_DelAcc();

        }

        // ACCOUNT DELETE BUTTON
        private void adm_acc_Click(object sender, EventArgs e)
        {

            glob_label.Text = "Delete an Account";
            Hide_Login();
            Hide_Register();

            adm_ln.Show();
            adm_fn.Show();
            adm_cn.Show();
            adm_dbtn.Show();
            adm_cnlb.Show();
            adm_lnlb.Show();
            adm_fnlb.Show();
            adm_cnlb.Show();


        }

        // LOG OUT BUTTON

        private void lo_btn_Click(object sender, EventArgs e)
        {
            glob_label.Text = "Logged Out!";
            reg_btn.Show();
            log_btn.Show();
            cart_btn.Show();
            lout_btn.Hide();
            log_pass.Show();
            log_passlb.Show();
            log_user.Show();
            log_userlb.Show();
            log_insub.Show();
            adm_dbtn.Hide();

            prod_btn.Hide();
            prod_list.Hide();

            add_btn.Hide();
            wh_btn.Hide();
            adm_acc.Hide();
            Hide_DelAcc();
        }

        private void prod_btn_Click(object sender, EventArgs e)
        {
            prod_list.Show();

        }

        /* ----------------------------------------------------------- BUTTON WITH HOVER FUNCTIONS ONLY -----------------------------------------------------------*/
        private void log_btn_MouseEnter(object sender, EventArgs e)
        {
            log_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, Color.Yellow);
            log_btn.UseVisualStyleBackColor = true;
        }

        private void log_btn_MouseLeave(object sender, EventArgs e)
        {
            log_btn.BackColor = Color.Teal;
        }


        /* ----------------------------------------------------------- BUTTON WITH FUNCTIONS ONLY -----------------------------------------------------------*/

        // LOGIN BUTTON FUNCTION
        private void log_insub_Click(object sender, EventArgs e)
        {
            string log_userN = log_user.Text.ToString();
            string log_passN = log_pass.Text.ToString();
            SqlConnection sql_con = new SqlConnection(sql_ds);
            sql_con.Open();


            try
            {
                string cmd = "SELECT * FROM TB_USERS WHERE cont_num = '"+log_passN+"' AND f_name = '"+log_userN+"'";
                SqlDataAdapter sql_sda = new SqlDataAdapter(cmd, sql_con);

                DataTable DT = new DataTable();
                sql_sda.Fill(DT);

                if (DT.Rows.Count > 0)
                {
                    // Check if user is admin or not
                    if (log_passN == "1234" || log_userN == " admin")
                    {
                        MessageBox.Show("Logged as an Admin!");
                        add_btn.Show();
                        wh_btn.Show();
                        adm_acc.Show();
                        lout_btn.Show();
                        cart_btn.Hide();
                        log_btn.Hide();
                        reg_btn.Hide();
                        log_user.Text = "";
                        log_pass.Text = "";
                        Hide_Login();
                    }
                    else
                    {
                        MessageBox.Show("Logged in Success!");
                        lout_btn.Show();
                        log_btn.Hide();
                        reg_btn.Hide();
                        prod_btn.Show();
                        log_user.Text = "";
                        log_pass.Text = "";
                        Hide_Login();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login or Password!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                log_user.Text = "";
                log_pass.Text = "";
                MessageBox.Show("Invalid Login or Password!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_con.Close();
            }

        }

        private void reg_submit_Click(object sender, EventArgs e)
        {
            long user_cont = Convert.ToInt64(reg_cn.Text);
            string user_fn = reg_FN.Text.ToString();
            string user_ln = reg_LN.Text.ToString();
            string user_add = reg_add.Text.ToString();

            // this will check if the first name have any numbers in it
            bool check_fn = user_fn.All(char.IsDigit);
            bool check_ln = user_ln.All(char.IsDigit);
            if (check_fn == true)
            {
                MessageBox.Show("First Name Cannot contain any number(s)!");
                reg_FN.Text = "";
            }
            else if (check_ln == true)
            {
                MessageBox.Show("Last Name Cannot contain any number(s)!");
                reg_LN.Text = "";
            }
            else
            {

                SqlConnection sql_con = new SqlConnection(sql_ds);
                sql_con.Open();
                if (sql_con.State==System.Data.ConnectionState.Open)
                {
                    // Register button
                    // reg_fnlb reg_lnlb reg_addlb reg_cmlb is the variable of the register labels
                    // reg_FN reg_LN reg_add reg_cn is the variable of the textbox
                    // reg_submit for the submit button


                    // This will add user input to the database

                    string db_add = "insert into TB_USERS(cont_num,f_name,l_name,cont_address)values('"+user_cont+"','"+user_fn+"','"+user_ln+"','"+user_add+"')";
                    SqlCommand coms = new SqlCommand(db_add, sql_con);
                    coms.ExecuteNonQuery();

                    MessageBox.Show("Successfull Registered Account!\nYour Contact number is your Username\nYour First Name is your password\nYou may now proceed to login!");

                    reg_FN.Text = "";
                    reg_LN.Text = "";
                    reg_cn.Text = "";
                    reg_add.Text = "";


                }
                else
                {


                    MessageBox.Show("SQL is OFFLINE!\nData is not saved!");
                }
            }
        }

        private void adm_dbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Random rand = new Random();
                int x = rand.Next(1000, 9999);
                adm_verlb.Text = ""+x;

                SqlConnection sql_con = new SqlConnection(sql_ds);
                sql_con.Open();

                string f_name = adm_fn.Text.ToString();
                string l_name = adm_ln.Text.ToString();


                bool check_fn = f_name.Any(Char.IsDigit);
                bool check_ln = l_name.Any(Char.IsDigit);

                if (check_fn == true)
                {
                    MessageBox.Show("First name does not contain any number");
                }
                else if (check_ln == true)
                {
                    MessageBox.Show("Last name does not contain any number");
                }
                else
                {

                    // TRY CATCH TO CHECK IF LONG HAS ANY LETTER

                    try
                    {
                        long c_num = Convert.ToInt64(adm_cn.Text);

                        // THIS IS WHEN DELETING IS GOOD TO GO
                        try
                        {
                            string cmd = "SELECT * FROM TB_USERS WHERE cont_num = '"+c_num+"' AND f_name = '"+f_name+"' AND l_name = '"+l_name+"'";
                            SqlDataAdapter sql_sda = new SqlDataAdapter(cmd, sql_con);

                            DataTable DT = new DataTable();
                            sql_sda.Fill(DT);

                            string c_num1 = adm_cn.Text.ToString();


                            if (DT.Rows.Count > 0)
                            {
                                if (c_num1 == "1234" || f_name == " admin")

                                {
                                    MessageBox.Show("This in an Admin!");
                                }
                                else
                                {
                                    adm_vbtn.Show();
                                    adm_verlb.Show();
                                    adm_ver.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid User Information!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Invalid User Information!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            sql_con.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Contact Number Does not contain any Letters");
                    }
                }
            }
            else
            {
                adm_vbtn.Hide();
                adm_verlb.Hide();
                adm_ver.Hide();
            }

        }


        // Provide a range to the Next method

        private void adm_vbtn_Click(object sender, EventArgs e)
        {
            string ver_code = adm_verlb.Text.ToString();
            string ver_inpt = adm_ver.Text.ToString();
            if (ver_code == ver_inpt)
            {
                MessageBox.Show("System now Delete This account!", "System");
                adm_ver.Text = " ";
                adm_fn.Text = " ";
                adm_ln.Text = " ";
                adm_cn.Text = " ";
                adm_vbtn.Hide();
                adm_verlb.Hide();
                adm_ver.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Verification Code!", "Error!");
            }
        }
    }
}
