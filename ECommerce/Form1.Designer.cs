namespace ECommerce
{
    partial class Form1
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
            panel1=new Panel();
            prod_btn=new Button();
            adm_acc=new Button();
            cart_btn=new Button();
            wh_btn=new Button();
            reg_btn=new Button();
            add_btn=new Button();
            log_btn=new Button();
            Side_panel2=new Panel();
            glob_label=new Label();
            lout_btn=new Button();
            reg_FN=new TextBox();
            reg_LN=new TextBox();
            reg_add=new TextBox();
            reg_fnlb=new Label();
            reg_lnlb=new Label();
            reg_addlb=new Label();
            reg_submit=new Button();
            reg_cn=new TextBox();
            reg_cnlb=new Label();
            log_user=new TextBox();
            log_pass=new TextBox();
            log_userlb=new Label();
            log_passlb=new Label();
            log_insub=new Button();
            adm_fn=new TextBox();
            adm_ln=new TextBox();
            adm_cn=new TextBox();
            adm_fnlb=new Label();
            adm_lnlb=new Label();
            adm_cnlb=new Label();
            adm_dbtn=new Button();
            adm_ver=new TextBox();
            adm_verlb=new Label();
            adm_vbtn=new Button();
            prod_list=new DataGridView();
            panel1.SuspendLayout();
            Side_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prod_list).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor=Color.Teal;
            panel1.Controls.Add(prod_btn);
            panel1.Controls.Add(adm_acc);
            panel1.Controls.Add(cart_btn);
            panel1.Controls.Add(wh_btn);
            panel1.Controls.Add(reg_btn);
            panel1.Controls.Add(add_btn);
            panel1.Controls.Add(log_btn);
            panel1.Dock=DockStyle.Left;
            panel1.Location=new Point(0, 0);
            panel1.Name="panel1";
            panel1.Size=new Size(164, 591);
            panel1.TabIndex=0;
            // 
            // prod_btn
            // 
            prod_btn.FlatAppearance.BorderSize=0;
            prod_btn.FlatStyle=FlatStyle.Flat;
            prod_btn.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prod_btn.ForeColor=SystemColors.ButtonFace;
            prod_btn.Image=Properties.Resources.login1;
            prod_btn.Location=new Point(0, 80);
            prod_btn.Name="prod_btn";
            prod_btn.Size=new Size(164, 56);
            prod_btn.TabIndex=4;
            prod_btn.Text="   Products";
            prod_btn.TextAlign=ContentAlignment.MiddleLeft;
            prod_btn.TextImageRelation=TextImageRelation.ImageBeforeText;
            prod_btn.UseVisualStyleBackColor=true;
            prod_btn.Click+=prod_btn_Click;
            // 
            // adm_acc
            // 
            adm_acc.BackColor=Color.Teal;
            adm_acc.FlatAppearance.BorderSize=0;
            adm_acc.FlatStyle=FlatStyle.Flat;
            adm_acc.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adm_acc.ForeColor=SystemColors.ButtonFace;
            adm_acc.Image=Properties.Resources.add_product;
            adm_acc.Location=new Point(0, 12);
            adm_acc.Name="adm_acc";
            adm_acc.Padding=new Padding(12, 0, 0, 0);
            adm_acc.Size=new Size(164, 56);
            adm_acc.TabIndex=3;
            adm_acc.Text=" Delete Acc";
            adm_acc.TextAlign=ContentAlignment.MiddleLeft;
            adm_acc.TextImageRelation=TextImageRelation.ImageBeforeText;
            adm_acc.UseVisualStyleBackColor=false;
            adm_acc.Click+=adm_acc_Click;
            // 
            // cart_btn
            // 
            cart_btn.FlatAppearance.BorderSize=0;
            cart_btn.FlatStyle=FlatStyle.Flat;
            cart_btn.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cart_btn.ForeColor=SystemColors.ButtonFace;
            cart_btn.Image=Properties.Resources.shopping_cart1;
            cart_btn.Location=new Point(0, 535);
            cart_btn.Name="cart_btn";
            cart_btn.Size=new Size(164, 56);
            cart_btn.TabIndex=2;
            cart_btn.Text="   Cart";
            cart_btn.TextAlign=ContentAlignment.MiddleLeft;
            cart_btn.TextImageRelation=TextImageRelation.ImageBeforeText;
            cart_btn.UseVisualStyleBackColor=true;
            cart_btn.Click+=cart_btn_Click;
            // 
            // wh_btn
            // 
            wh_btn.BackColor=Color.Teal;
            wh_btn.FlatAppearance.BorderSize=0;
            wh_btn.FlatStyle=FlatStyle.Flat;
            wh_btn.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            wh_btn.ForeColor=SystemColors.ButtonFace;
            wh_btn.Image=Properties.Resources.add_product;
            wh_btn.Location=new Point(0, 257);
            wh_btn.Name="wh_btn";
            wh_btn.Padding=new Padding(12, 0, 0, 0);
            wh_btn.Size=new Size(164, 56);
            wh_btn.TabIndex=2;
            wh_btn.Text=" Warehouse";
            wh_btn.TextAlign=ContentAlignment.MiddleLeft;
            wh_btn.TextImageRelation=TextImageRelation.ImageBeforeText;
            wh_btn.UseVisualStyleBackColor=false;
            wh_btn.Click+=wh_btn_Click;
            // 
            // reg_btn
            // 
            reg_btn.FlatAppearance.BorderSize=0;
            reg_btn.FlatStyle=FlatStyle.Flat;
            reg_btn.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reg_btn.ForeColor=SystemColors.ButtonFace;
            reg_btn.Image=Properties.Resources.register;
            reg_btn.Location=new Point(0, 135);
            reg_btn.Name="reg_btn";
            reg_btn.Size=new Size(164, 56);
            reg_btn.TabIndex=1;
            reg_btn.Text="   Register";
            reg_btn.TextAlign=ContentAlignment.MiddleLeft;
            reg_btn.TextImageRelation=TextImageRelation.ImageBeforeText;
            reg_btn.UseVisualStyleBackColor=true;
            reg_btn.Click+=reg_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor=Color.Teal;
            add_btn.FlatAppearance.BorderSize=0;
            add_btn.FlatStyle=FlatStyle.Flat;
            add_btn.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            add_btn.ForeColor=SystemColors.ButtonFace;
            add_btn.Image=Properties.Resources.add_product;
            add_btn.Location=new Point(0, 195);
            add_btn.Name="add_btn";
            add_btn.Padding=new Padding(8, 0, 0, 0);
            add_btn.Size=new Size(164, 56);
            add_btn.TabIndex=1;
            add_btn.Text=" Product+";
            add_btn.TextAlign=ContentAlignment.MiddleLeft;
            add_btn.TextImageRelation=TextImageRelation.ImageBeforeText;
            add_btn.UseVisualStyleBackColor=false;
            add_btn.Click+=add_btn_Click;
            // 
            // log_btn
            // 
            log_btn.FlatAppearance.BorderSize=0;
            log_btn.FlatStyle=FlatStyle.Flat;
            log_btn.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            log_btn.ForeColor=SystemColors.ButtonFace;
            log_btn.Image=Properties.Resources.login1;
            log_btn.Location=new Point(0, 80);
            log_btn.Name="log_btn";
            log_btn.Size=new Size(164, 56);
            log_btn.TabIndex=0;
            log_btn.Text="   Login";
            log_btn.TextAlign=ContentAlignment.MiddleLeft;
            log_btn.TextImageRelation=TextImageRelation.ImageBeforeText;
            log_btn.UseVisualStyleBackColor=true;
            log_btn.Click+=log_btn_Click;
            log_btn.MouseEnter+=log_btn_MouseEnter;
            log_btn.MouseLeave+=log_btn_MouseLeave;
            // 
            // Side_panel2
            // 
            Side_panel2.BackColor=Color.Teal;
            Side_panel2.Controls.Add(glob_label);
            Side_panel2.Controls.Add(lout_btn);
            Side_panel2.Dock=DockStyle.Top;
            Side_panel2.Location=new Point(164, 0);
            Side_panel2.Name="Side_panel2";
            Side_panel2.Size=new Size(844, 74);
            Side_panel2.TabIndex=1;
            // 
            // glob_label
            // 
            glob_label.AutoSize=true;
            glob_label.Font=new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            glob_label.ForeColor=SystemColors.ButtonFace;
            glob_label.Location=new Point(46, 24);
            glob_label.Name="glob_label";
            glob_label.Size=new Size(190, 28);
            glob_label.TabIndex=5;
            glob_label.Text="Welcome to Login!";
            // 
            // lout_btn
            // 
            lout_btn.BackColor=Color.Teal;
            lout_btn.FlatAppearance.BorderSize=0;
            lout_btn.FlatStyle=FlatStyle.Flat;
            lout_btn.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lout_btn.ForeColor=SystemColors.ButtonFace;
            lout_btn.Image=Properties.Resources.add_product;
            lout_btn.Location=new Point(684, 0);
            lout_btn.Name="lout_btn";
            lout_btn.Padding=new Padding(12, 0, 0, 0);
            lout_btn.Size=new Size(160, 74);
            lout_btn.TabIndex=4;
            lout_btn.Text="  Log Out";
            lout_btn.TextAlign=ContentAlignment.MiddleLeft;
            lout_btn.TextImageRelation=TextImageRelation.ImageBeforeText;
            lout_btn.UseVisualStyleBackColor=false;
            lout_btn.Click+=lo_btn_Click;
            // 
            // reg_FN
            // 
            reg_FN.Location=new Point(210, 142);
            reg_FN.Name="reg_FN";
            reg_FN.Size=new Size(160, 23);
            reg_FN.TabIndex=2;
            // 
            // reg_LN
            // 
            reg_LN.Location=new Point(210, 194);
            reg_LN.Name="reg_LN";
            reg_LN.Size=new Size(160, 23);
            reg_LN.TabIndex=3;
            // 
            // reg_add
            // 
            reg_add.Location=new Point(210, 247);
            reg_add.Name="reg_add";
            reg_add.Size=new Size(160, 23);
            reg_add.TabIndex=4;
            // 
            // reg_fnlb
            // 
            reg_fnlb.AutoSize=true;
            reg_fnlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            reg_fnlb.Location=new Point(210, 120);
            reg_fnlb.Name="reg_fnlb";
            reg_fnlb.Size=new Size(81, 19);
            reg_fnlb.TabIndex=5;
            reg_fnlb.Text="First Name";
            // 
            // reg_lnlb
            // 
            reg_lnlb.AutoSize=true;
            reg_lnlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            reg_lnlb.Location=new Point(210, 172);
            reg_lnlb.Name="reg_lnlb";
            reg_lnlb.Size=new Size(79, 19);
            reg_lnlb.TabIndex=6;
            reg_lnlb.Text="Last Name";
            // 
            // reg_addlb
            // 
            reg_addlb.AutoSize=true;
            reg_addlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            reg_addlb.Location=new Point(210, 225);
            reg_addlb.Name="reg_addlb";
            reg_addlb.Size=new Size(63, 19);
            reg_addlb.TabIndex=7;
            reg_addlb.Text="Address";
            // 
            // reg_submit
            // 
            reg_submit.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            reg_submit.Location=new Point(210, 329);
            reg_submit.Name="reg_submit";
            reg_submit.Size=new Size(81, 30);
            reg_submit.TabIndex=8;
            reg_submit.Text="Submit";
            reg_submit.UseVisualStyleBackColor=true;
            reg_submit.Click+=reg_submit_Click;
            // 
            // reg_cn
            // 
            reg_cn.Location=new Point(210, 300);
            reg_cn.Name="reg_cn";
            reg_cn.Size=new Size(160, 23);
            reg_cn.TabIndex=9;
            // 
            // reg_cnlb
            // 
            reg_cnlb.AutoSize=true;
            reg_cnlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            reg_cnlb.Location=new Point(210, 278);
            reg_cnlb.Name="reg_cnlb";
            reg_cnlb.Size=new Size(119, 19);
            reg_cnlb.TabIndex=10;
            reg_cnlb.Text="Contact Number";
            // 
            // log_user
            // 
            log_user.Location=new Point(210, 142);
            log_user.Name="log_user";
            log_user.Size=new Size(160, 23);
            log_user.TabIndex=11;
            // 
            // log_pass
            // 
            log_pass.Location=new Point(210, 194);
            log_pass.Name="log_pass";
            log_pass.Size=new Size(160, 23);
            log_pass.TabIndex=12;
            log_pass.UseSystemPasswordChar=true;
            // 
            // log_userlb
            // 
            log_userlb.AutoSize=true;
            log_userlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            log_userlb.Location=new Point(210, 120);
            log_userlb.Name="log_userlb";
            log_userlb.Size=new Size(76, 19);
            log_userlb.TabIndex=13;
            log_userlb.Text="Username";
            // 
            // log_passlb
            // 
            log_passlb.AutoSize=true;
            log_passlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            log_passlb.Location=new Point(210, 172);
            log_passlb.Name="log_passlb";
            log_passlb.Size=new Size(73, 19);
            log_passlb.TabIndex=14;
            log_passlb.Text="Password";
            // 
            // log_insub
            // 
            log_insub.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            log_insub.Location=new Point(210, 223);
            log_insub.Name="log_insub";
            log_insub.Size=new Size(81, 30);
            log_insub.TabIndex=15;
            log_insub.Text="Login";
            log_insub.UseVisualStyleBackColor=true;
            log_insub.Click+=log_insub_Click;
            // 
            // adm_fn
            // 
            adm_fn.Location=new Point(804, 142);
            adm_fn.Name="adm_fn";
            adm_fn.Size=new Size(160, 23);
            adm_fn.TabIndex=16;
            // 
            // adm_ln
            // 
            adm_ln.Location=new Point(804, 195);
            adm_ln.Name="adm_ln";
            adm_ln.Size=new Size(160, 23);
            adm_ln.TabIndex=17;
            // 
            // adm_cn
            // 
            adm_cn.Location=new Point(804, 247);
            adm_cn.Name="adm_cn";
            adm_cn.Size=new Size(160, 23);
            adm_cn.TabIndex=18;
            // 
            // adm_fnlb
            // 
            adm_fnlb.AutoSize=true;
            adm_fnlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            adm_fnlb.Location=new Point(804, 120);
            adm_fnlb.Name="adm_fnlb";
            adm_fnlb.Size=new Size(78, 19);
            adm_fnlb.TabIndex=19;
            adm_fnlb.Text="First name";
            // 
            // adm_lnlb
            // 
            adm_lnlb.AutoSize=true;
            adm_lnlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            adm_lnlb.Location=new Point(804, 173);
            adm_lnlb.Name="adm_lnlb";
            adm_lnlb.Size=new Size(79, 19);
            adm_lnlb.TabIndex=20;
            adm_lnlb.Text="Last Name";
            // 
            // adm_cnlb
            // 
            adm_cnlb.AutoSize=true;
            adm_cnlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            adm_cnlb.Location=new Point(804, 225);
            adm_cnlb.Name="adm_cnlb";
            adm_cnlb.Size=new Size(119, 19);
            adm_cnlb.TabIndex=21;
            adm_cnlb.Text="Contact Number";
            // 
            // adm_dbtn
            // 
            adm_dbtn.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            adm_dbtn.Location=new Point(883, 283);
            adm_dbtn.Name="adm_dbtn";
            adm_dbtn.Size=new Size(81, 30);
            adm_dbtn.TabIndex=22;
            adm_dbtn.Text="Delete";
            adm_dbtn.UseVisualStyleBackColor=true;
            adm_dbtn.Click+=adm_dbtn_Click;
            // 
            // adm_ver
            // 
            adm_ver.Location=new Point(868, 388);
            adm_ver.Name="adm_ver";
            adm_ver.Size=new Size(96, 23);
            adm_ver.TabIndex=23;
            // 
            // adm_verlb
            // 
            adm_verlb.AutoSize=true;
            adm_verlb.Font=new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            adm_verlb.Location=new Point(868, 366);
            adm_verlb.Name="adm_verlb";
            adm_verlb.Size=new Size(33, 19);
            adm_verlb.TabIndex=24;
            adm_verlb.Text="----";
            // 
            // adm_vbtn
            // 
            adm_vbtn.Font=new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            adm_vbtn.Location=new Point(931, 417);
            adm_vbtn.Name="adm_vbtn";
            adm_vbtn.Size=new Size(33, 30);
            adm_vbtn.TabIndex=25;
            adm_vbtn.Text="V";
            adm_vbtn.UseVisualStyleBackColor=true;
            adm_vbtn.Click+=adm_vbtn_Click;
            // 
            // prod_list
            // 
            prod_list.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prod_list.Location=new Point(210, 120);
            prod_list.Name="prod_list";
            prod_list.RowTemplate.Height=25;
            prod_list.Size=new Size(521, 433);
            prod_list.TabIndex=26;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1008, 591);
            Controls.Add(prod_list);
            Controls.Add(adm_vbtn);
            Controls.Add(adm_verlb);
            Controls.Add(adm_ver);
            Controls.Add(adm_dbtn);
            Controls.Add(adm_cnlb);
            Controls.Add(adm_lnlb);
            Controls.Add(adm_fnlb);
            Controls.Add(adm_cn);
            Controls.Add(adm_ln);
            Controls.Add(adm_fn);
            Controls.Add(log_insub);
            Controls.Add(log_passlb);
            Controls.Add(log_userlb);
            Controls.Add(log_pass);
            Controls.Add(log_user);
            Controls.Add(reg_cnlb);
            Controls.Add(reg_cn);
            Controls.Add(reg_submit);
            Controls.Add(reg_addlb);
            Controls.Add(reg_lnlb);
            Controls.Add(reg_fnlb);
            Controls.Add(reg_add);
            Controls.Add(reg_LN);
            Controls.Add(reg_FN);
            Controls.Add(Side_panel2);
            Controls.Add(panel1);
            Name="Form1";
            Text="E-Commerce";
            Load+=Form1_Load;
            panel1.ResumeLayout(false);
            Side_panel2.ResumeLayout(false);
            Side_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prod_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel Side_panel2;
        private Button log_btn;
        private Button cart_btn;
        private Button reg_btn;
        private Button wh_btn;
        private Button add_btn;
        private TextBox reg_FN;
        private TextBox reg_LN;
        private TextBox reg_add;
        private Label reg_fnlb;
        private Label reg_lnlb;
        private Label reg_addlb;
        private Button reg_submit;
        private TextBox reg_cn;
        private Label reg_cnlb;
        private TextBox log_user;
        private TextBox log_pass;
        private Label log_userlb;
        private Label log_passlb;
        private Button log_insub;
        private Button adm_acc;
        private TextBox adm_fn;
        private TextBox adm_ln;
        private TextBox adm_cn;
        private Label adm_fnlb;
        private Label adm_lnlb;
        private Label adm_cnlb;
        private Button adm_dbtn;
        private TextBox adm_ver;
        private Label adm_verlb;
        private Button adm_vbtn;
        private Button lout_btn;
        private Label glob_label;
        private Button prod_btn;
        private DataGridView prod_list;
    }
}