using System.Data;
using System.Data.SqlClient;
using FontAwesome.Sharp;

namespace ECommerceProj
{
    public partial class ECommerce : Form
    {

        string sql_acc = "Data Source=HAYASEYUUKA\\SQLEXPRESS;Initial Catalog=E_Commerce;Integrated Security=True";

        private Form cur_form;
        public ECommerce()
        {
            InitializeComponent();
            out_btn.Hide();
            login_sidebtn.Hide();

            // admin
            AddProduct_btn.Hide();
            Warehouse_btn.Hide();
            Account_user_btn.Hide();


            // user
            Products_btn.Hide();
            Cart_btn.Hide();


        }
        private void OpenChildForm(Form childForm)
        {
            if (cur_form != null)
            {
                cur_form.Close();
            }

            cur_form = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_window.Controls.Add(childForm);
            panel_window.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string log_userN = log_emtb.Text.ToString();
            string log_passN = log_pwtb.Text.ToString();
            SqlConnection sql_con = new SqlConnection(sql_acc);
            sql_con.Open();

            try
            {
                string cmd = "SELECT * FROM USERS_TABLE WHERE Contact_Number = '"+log_passN+"' AND EMail = '"+log_userN+"'";
                SqlDataAdapter sql_sda = new SqlDataAdapter(cmd, sql_con);

                DataTable DT = new DataTable();
                sql_sda.Fill(DT);

                if (DT.Rows.Count > 0)
                {
                    // Check if user is admin or not
                    if (log_passN == "1234" && log_userN == "Admin")
                    {
                        MessageBox.Show("Logged as an Admin!");
                        user_lbl.Text = log_userN;
                        log_emtb.Text = "";
                        log_pwtb.Text = "";
                        out_btn.Show();

                        
                        AddProduct_btn.Show();
                        Warehouse_btn.Show();
                        Register_btn.Hide();

                        Account_user_btn.Show();
                        log_emlbl.Hide();
                        log_emtb.Hide();
                        log_pwlbl.Hide();
                        log_pwtb.Hide();
                        btn_login.Hide();
                        sql_con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Logged in Success!");
                        user_lbl.Text = log_userN;
                        log_emtb.Text = "";
                        log_pwtb.Text = "";
                        out_btn.Show();

                        Products_btn.Show();
                        Cart_btn.Show();
                        Register_btn.Hide();

                        Account_user_btn.Show();
                        log_emlbl.Hide();
                        log_emtb.Hide();
                        log_pwlbl.Hide();
                        log_pwtb.Hide();
                        btn_login.Hide();

                        sql_con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login or Password!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Login or Password!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_con.Close();
            }
        }

        private void out_btn_Click(object sender, EventArgs e)
        {
            user_lbl.Text = "----";
            out_btn.Hide();

            // admin
            AddProduct_btn.Hide();
            Warehouse_btn.Hide();
            Account_user_btn.Hide();

            // user
            Products_btn.Hide();
            Cart_btn.Hide();

            // Register
            Register_btn.Show();

            log_emlbl.Show();
            log_emtb.Show();
            log_pwlbl.Show();
            log_pwtb.Show();
            btn_login.Show();
            OpenChildForm(new DummyForm());
        }

        private void Products_btn_Click(object sender, EventArgs e)
        {

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            log_emlbl.Hide();
            log_emtb.Hide();
            log_pwlbl.Hide();
            log_pwtb.Hide();
            btn_login.Hide();
            login_sidebtn.Show();
            OpenChildForm(new Register_Form());
        }

        private void login_sidebtn_Click(object sender, EventArgs e)
        {
            log_emlbl.Show();
            log_emtb.Show();
            log_pwlbl.Show();
            log_pwtb.Show();
            btn_login.Show();
            login_sidebtn.Hide();
            OpenChildForm(new DummyForm());
        }

        private void AddProduct_btn_Click(object sender, EventArgs e)
        {

        }

        private void Warehouse_btn_Click(object sender, EventArgs e)
        {

        }

        private void Admin_user_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Account_Settings_Form());
        }
    }
}