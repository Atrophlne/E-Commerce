namespace ECommerceProj
{
    partial class ECommerce
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_top=new Panel();
            panel1=new Panel();
            Account_user_btn=new FontAwesome.Sharp.IconButton();
            Register_btn=new FontAwesome.Sharp.IconButton();
            Cart_btn=new FontAwesome.Sharp.IconButton();
            Warehouse_btn=new FontAwesome.Sharp.IconButton();
            AddProduct_btn=new FontAwesome.Sharp.IconButton();
            Products_btn=new FontAwesome.Sharp.IconButton();
            panel_TL=new Panel();
            user_lbl=new Label();
            panel_side=new Panel();
            login_sidebtn=new FontAwesome.Sharp.IconButton();
            out_btn=new FontAwesome.Sharp.IconButton();
            btn_login=new Button();
            log_pwlbl=new Label();
            log_emlbl=new Label();
            log_pwtb=new TextBox();
            log_emtb=new TextBox();
            panel_window=new Panel();
            panel_top.SuspendLayout();
            panel1.SuspendLayout();
            panel_TL.SuspendLayout();
            panel_side.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.BackColor=Color.FromArgb(83, 60, 107);
            panel_top.Controls.Add(panel1);
            panel_top.Controls.Add(Cart_btn);
            panel_top.Controls.Add(Warehouse_btn);
            panel_top.Controls.Add(AddProduct_btn);
            panel_top.Controls.Add(Products_btn);
            panel_top.Controls.Add(panel_TL);
            panel_top.Dock=DockStyle.Top;
            panel_top.Location=new Point(0, 0);
            panel_top.Name="panel_top";
            panel_top.Size=new Size(800, 42);
            panel_top.TabIndex=0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Account_user_btn);
            panel1.Controls.Add(Register_btn);
            panel1.Dock=DockStyle.Right;
            panel1.Location=new Point(684, 0);
            panel1.Name="panel1";
            panel1.Size=new Size(116, 42);
            panel1.TabIndex=6;
            // 
            // Account_user_btn
            // 
            Account_user_btn.Dock=DockStyle.Right;
            Account_user_btn.FlatAppearance.BorderSize=0;
            Account_user_btn.FlatStyle=FlatStyle.Flat;
            Account_user_btn.IconChar=FontAwesome.Sharp.IconChar.Gear;
            Account_user_btn.IconColor=Color.White;
            Account_user_btn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            Account_user_btn.IconSize=30;
            Account_user_btn.Location=new Point(3, 0);
            Account_user_btn.Name="Account_user_btn";
            Account_user_btn.Padding=new Padding(0, 3, 0, 0);
            Account_user_btn.Size=new Size(56, 42);
            Account_user_btn.TabIndex=3;
            Account_user_btn.UseVisualStyleBackColor=true;
            Account_user_btn.Click+=Admin_user_btn_Click;
            // 
            // Register_btn
            // 
            Register_btn.Dock=DockStyle.Right;
            Register_btn.FlatAppearance.BorderSize=0;
            Register_btn.FlatStyle=FlatStyle.Flat;
            Register_btn.IconChar=FontAwesome.Sharp.IconChar.User;
            Register_btn.IconColor=Color.White;
            Register_btn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            Register_btn.IconSize=30;
            Register_btn.Location=new Point(59, 0);
            Register_btn.Name="Register_btn";
            Register_btn.Padding=new Padding(0, 3, 0, 0);
            Register_btn.Size=new Size(57, 42);
            Register_btn.TabIndex=2;
            Register_btn.UseVisualStyleBackColor=true;
            Register_btn.Click+=Register_btn_Click;
            // 
            // Cart_btn
            // 
            Cart_btn.Dock=DockStyle.Left;
            Cart_btn.FlatAppearance.BorderSize=0;
            Cart_btn.FlatStyle=FlatStyle.Flat;
            Cart_btn.IconChar=FontAwesome.Sharp.IconChar.CartPlus;
            Cart_btn.IconColor=Color.White;
            Cart_btn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            Cart_btn.IconSize=35;
            Cart_btn.Location=new Point(300, 0);
            Cart_btn.Name="Cart_btn";
            Cart_btn.Padding=new Padding(0, 3, 0, 0);
            Cart_btn.Size=new Size(51, 42);
            Cart_btn.TabIndex=5;
            Cart_btn.UseVisualStyleBackColor=true;
            // 
            // Warehouse_btn
            // 
            Warehouse_btn.Dock=DockStyle.Left;
            Warehouse_btn.FlatAppearance.BorderSize=0;
            Warehouse_btn.FlatStyle=FlatStyle.Flat;
            Warehouse_btn.IconChar=FontAwesome.Sharp.IconChar.Warehouse;
            Warehouse_btn.IconColor=Color.White;
            Warehouse_btn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            Warehouse_btn.IconSize=35;
            Warehouse_btn.Location=new Point(249, 0);
            Warehouse_btn.Name="Warehouse_btn";
            Warehouse_btn.Padding=new Padding(0, 3, 0, 0);
            Warehouse_btn.Size=new Size(51, 42);
            Warehouse_btn.TabIndex=4;
            Warehouse_btn.UseVisualStyleBackColor=true;
            Warehouse_btn.Click+=Warehouse_btn_Click;
            // 
            // AddProduct_btn
            // 
            AddProduct_btn.Dock=DockStyle.Left;
            AddProduct_btn.FlatAppearance.BorderSize=0;
            AddProduct_btn.FlatStyle=FlatStyle.Flat;
            AddProduct_btn.IconChar=FontAwesome.Sharp.IconChar.Box;
            AddProduct_btn.IconColor=Color.White;
            AddProduct_btn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            AddProduct_btn.IconSize=35;
            AddProduct_btn.Location=new Point(198, 0);
            AddProduct_btn.Name="AddProduct_btn";
            AddProduct_btn.Padding=new Padding(0, 3, 0, 0);
            AddProduct_btn.Size=new Size(51, 42);
            AddProduct_btn.TabIndex=3;
            AddProduct_btn.UseVisualStyleBackColor=true;
            AddProduct_btn.Click+=AddProduct_btn_Click;
            // 
            // Products_btn
            // 
            Products_btn.Dock=DockStyle.Left;
            Products_btn.FlatAppearance.BorderSize=0;
            Products_btn.FlatStyle=FlatStyle.Flat;
            Products_btn.IconChar=FontAwesome.Sharp.IconChar.Shop;
            Products_btn.IconColor=Color.White;
            Products_btn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            Products_btn.IconSize=35;
            Products_btn.Location=new Point(147, 0);
            Products_btn.Name="Products_btn";
            Products_btn.Padding=new Padding(0, 3, 0, 0);
            Products_btn.Size=new Size(51, 42);
            Products_btn.TabIndex=1;
            Products_btn.UseVisualStyleBackColor=true;
            Products_btn.Click+=Products_btn_Click;
            // 
            // panel_TL
            // 
            panel_TL.Controls.Add(user_lbl);
            panel_TL.Dock=DockStyle.Left;
            panel_TL.Location=new Point(0, 0);
            panel_TL.Name="panel_TL";
            panel_TL.Size=new Size(147, 42);
            panel_TL.TabIndex=0;
            // 
            // user_lbl
            // 
            user_lbl.AutoSize=true;
            user_lbl.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            user_lbl.ForeColor=Color.White;
            user_lbl.Location=new Point(3, 9);
            user_lbl.Name="user_lbl";
            user_lbl.Size=new Size(34, 21);
            user_lbl.TabIndex=0;
            user_lbl.Text="----";
            // 
            // panel_side
            // 
            panel_side.BackColor=Color.FromArgb(106, 80, 135);
            panel_side.Controls.Add(login_sidebtn);
            panel_side.Controls.Add(out_btn);
            panel_side.Controls.Add(btn_login);
            panel_side.Controls.Add(log_pwlbl);
            panel_side.Controls.Add(log_emlbl);
            panel_side.Controls.Add(log_pwtb);
            panel_side.Controls.Add(log_emtb);
            panel_side.Dock=DockStyle.Left;
            panel_side.Location=new Point(0, 42);
            panel_side.Name="panel_side";
            panel_side.Size=new Size(147, 408);
            panel_side.TabIndex=1;
            // 
            // login_sidebtn
            // 
            login_sidebtn.Dock=DockStyle.Top;
            login_sidebtn.FlatAppearance.BorderSize=0;
            login_sidebtn.FlatStyle=FlatStyle.Flat;
            login_sidebtn.Font=new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            login_sidebtn.ForeColor=Color.White;
            login_sidebtn.IconChar=FontAwesome.Sharp.IconChar.RightToBracket;
            login_sidebtn.IconColor=Color.White;
            login_sidebtn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            login_sidebtn.IconSize=30;
            login_sidebtn.ImageAlign=ContentAlignment.MiddleLeft;
            login_sidebtn.Location=new Point(0, 0);
            login_sidebtn.Name="login_sidebtn";
            login_sidebtn.Padding=new Padding(10, 0, 35, 0);
            login_sidebtn.Size=new Size(147, 34);
            login_sidebtn.TabIndex=6;
            login_sidebtn.Text="Login";
            login_sidebtn.TextAlign=ContentAlignment.MiddleRight;
            login_sidebtn.UseVisualStyleBackColor=true;
            login_sidebtn.Click+=login_sidebtn_Click;
            // 
            // out_btn
            // 
            out_btn.Dock=DockStyle.Bottom;
            out_btn.FlatAppearance.BorderSize=0;
            out_btn.FlatStyle=FlatStyle.Flat;
            out_btn.Font=new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            out_btn.ForeColor=Color.White;
            out_btn.IconChar=FontAwesome.Sharp.IconChar.PowerOff;
            out_btn.IconColor=Color.White;
            out_btn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            out_btn.IconSize=30;
            out_btn.ImageAlign=ContentAlignment.MiddleLeft;
            out_btn.Location=new Point(0, 374);
            out_btn.Name="out_btn";
            out_btn.Padding=new Padding(10, 0, 25, 0);
            out_btn.Size=new Size(147, 34);
            out_btn.TabIndex=5;
            out_btn.Text="Log Out";
            out_btn.TextAlign=ContentAlignment.MiddleRight;
            out_btn.UseVisualStyleBackColor=true;
            out_btn.Click+=out_btn_Click;
            // 
            // btn_login
            // 
            btn_login.Location=new Point(12, 143);
            btn_login.Name="btn_login";
            btn_login.Size=new Size(55, 23);
            btn_login.TabIndex=4;
            btn_login.Text="Login";
            btn_login.UseVisualStyleBackColor=true;
            btn_login.Click+=btn_login_Click;
            // 
            // log_pwlbl
            // 
            log_pwlbl.AutoSize=true;
            log_pwlbl.Font=new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            log_pwlbl.ForeColor=SystemColors.ButtonFace;
            log_pwlbl.Location=new Point(12, 91);
            log_pwlbl.Name="log_pwlbl";
            log_pwlbl.Size=new Size(76, 20);
            log_pwlbl.TabIndex=3;
            log_pwlbl.Text="Password";
            // 
            // log_emlbl
            // 
            log_emlbl.AutoSize=true;
            log_emlbl.Font=new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            log_emlbl.ForeColor=SystemColors.ButtonFace;
            log_emlbl.Location=new Point(12, 39);
            log_emlbl.Name="log_emlbl";
            log_emlbl.Size=new Size(47, 20);
            log_emlbl.TabIndex=2;
            log_emlbl.Text="Email";
            // 
            // log_pwtb
            // 
            log_pwtb.Location=new Point(12, 114);
            log_pwtb.Name="log_pwtb";
            log_pwtb.Size=new Size(129, 23);
            log_pwtb.TabIndex=1;
            // 
            // log_emtb
            // 
            log_emtb.Location=new Point(12, 62);
            log_emtb.Name="log_emtb";
            log_emtb.Size=new Size(129, 23);
            log_emtb.TabIndex=0;
            // 
            // panel_window
            // 
            panel_window.BackColor=Color.FromArgb(73, 44, 105);
            panel_window.Dock=DockStyle.Fill;
            panel_window.Location=new Point(147, 42);
            panel_window.Name="panel_window";
            panel_window.Size=new Size(653, 408);
            panel_window.TabIndex=2;
            // 
            // ECommerce
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(panel_window);
            Controls.Add(panel_side);
            Controls.Add(panel_top);
            Name="ECommerce";
            Text="Form1";
            panel_top.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel_TL.ResumeLayout(false);
            panel_TL.PerformLayout();
            panel_side.ResumeLayout(false);
            panel_side.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private Panel panel_TL;
        private Panel panel_side;
        private TextBox log_pwtb;
        private TextBox log_emtb;
        private Panel panel_window;
        private Button btn_login;
        private Label log_pwlbl;
        private Label log_emlbl;
        private FontAwesome.Sharp.IconButton out_btn;
        private Label user_lbl;
        private FontAwesome.Sharp.IconButton Products_btn;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton Cart_btn;
        private FontAwesome.Sharp.IconButton Warehouse_btn;
        private FontAwesome.Sharp.IconButton AddProduct_btn;
        private FontAwesome.Sharp.IconButton Register_btn;
        private FontAwesome.Sharp.IconButton login_sidebtn;
        private FontAwesome.Sharp.IconButton Account_user_btn;
    }
}