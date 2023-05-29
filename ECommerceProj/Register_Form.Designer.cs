namespace ECommerceProj
{
    partial class Register_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reg_FN=new TextBox();
            reg_LN=new TextBox();
            reg_Add=new TextBox();
            reg_CT=new TextBox();
            reg_EM=new TextBox();
            reg_CNT=new TextBox();
            verify_tb=new TextBox();
            verify_btn=new Button();
            reg_subm=new Button();
            FN_LBL=new Label();
            LN_LBL=new Label();
            ADD_LBL=new Label();
            CT_LBL=new Label();
            EM_LBL=new Label();
            CN_LBL=new Label();
            verify_lbl=new Label();
            reset_btn=new Button();
            SuspendLayout();
            // 
            // reg_FN
            // 
            reg_FN.Location=new Point(12, 53);
            reg_FN.Name="reg_FN";
            reg_FN.Size=new Size(151, 23);
            reg_FN.TabIndex=0;
            // 
            // reg_LN
            // 
            reg_LN.Location=new Point(219, 53);
            reg_LN.Name="reg_LN";
            reg_LN.Size=new Size(151, 23);
            reg_LN.TabIndex=1;
            // 
            // reg_Add
            // 
            reg_Add.Location=new Point(12, 112);
            reg_Add.Name="reg_Add";
            reg_Add.Size=new Size(151, 23);
            reg_Add.TabIndex=2;
            // 
            // reg_CT
            // 
            reg_CT.Location=new Point(219, 112);
            reg_CT.Name="reg_CT";
            reg_CT.Size=new Size(151, 23);
            reg_CT.TabIndex=3;
            // 
            // reg_EM
            // 
            reg_EM.Location=new Point(12, 170);
            reg_EM.Name="reg_EM";
            reg_EM.Size=new Size(151, 23);
            reg_EM.TabIndex=4;
            // 
            // reg_CNT
            // 
            reg_CNT.Location=new Point(219, 170);
            reg_CNT.Name="reg_CNT";
            reg_CNT.Size=new Size(151, 23);
            reg_CNT.TabIndex=5;
            // 
            // verify_tb
            // 
            verify_tb.Location=new Point(219, 241);
            verify_tb.Name="verify_tb";
            verify_tb.Size=new Size(54, 23);
            verify_tb.TabIndex=6;
            // 
            // verify_btn
            // 
            verify_btn.Location=new Point(115, 241);
            verify_btn.Name="verify_btn";
            verify_btn.Size=new Size(48, 23);
            verify_btn.TabIndex=7;
            verify_btn.Text="Code";
            verify_btn.UseVisualStyleBackColor=true;
            verify_btn.Click+=verify_btn_Click;
            // 
            // reg_subm
            // 
            reg_subm.Location=new Point(158, 304);
            reg_subm.Name="reg_subm";
            reg_subm.Size=new Size(66, 23);
            reg_subm.TabIndex=8;
            reg_subm.Text="Submit";
            reg_subm.UseVisualStyleBackColor=true;
            reg_subm.Click+=reg_subm_Click;
            // 
            // FN_LBL
            // 
            FN_LBL.AutoSize=true;
            FN_LBL.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FN_LBL.ForeColor=Color.White;
            FN_LBL.Location=new Point(12, 29);
            FN_LBL.Name="FN_LBL";
            FN_LBL.Size=new Size(92, 21);
            FN_LBL.TabIndex=9;
            FN_LBL.Text="First Name";
            // 
            // LN_LBL
            // 
            LN_LBL.AutoSize=true;
            LN_LBL.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LN_LBL.ForeColor=Color.White;
            LN_LBL.Location=new Point(219, 29);
            LN_LBL.Name="LN_LBL";
            LN_LBL.Size=new Size(90, 21);
            LN_LBL.TabIndex=10;
            LN_LBL.Text="Last Name";
            // 
            // ADD_LBL
            // 
            ADD_LBL.AutoSize=true;
            ADD_LBL.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ADD_LBL.ForeColor=Color.White;
            ADD_LBL.Location=new Point(12, 88);
            ADD_LBL.Name="ADD_LBL";
            ADD_LBL.Size=new Size(70, 21);
            ADD_LBL.TabIndex=11;
            ADD_LBL.Text="Address";
            // 
            // CT_LBL
            // 
            CT_LBL.AutoSize=true;
            CT_LBL.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CT_LBL.ForeColor=Color.White;
            CT_LBL.Location=new Point(219, 88);
            CT_LBL.Name="CT_LBL";
            CT_LBL.Size=new Size(40, 21);
            CT_LBL.TabIndex=12;
            CT_LBL.Text="City";
            // 
            // EM_LBL
            // 
            EM_LBL.AutoSize=true;
            EM_LBL.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EM_LBL.ForeColor=Color.White;
            EM_LBL.Location=new Point(12, 146);
            EM_LBL.Name="EM_LBL";
            EM_LBL.Size=new Size(53, 21);
            EM_LBL.TabIndex=13;
            EM_LBL.Text="Email";
            // 
            // CN_LBL
            // 
            CN_LBL.AutoSize=true;
            CN_LBL.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CN_LBL.ForeColor=Color.White;
            CN_LBL.Location=new Point(219, 146);
            CN_LBL.Name="CN_LBL";
            CN_LBL.Size=new Size(136, 21);
            CN_LBL.TabIndex=14;
            CN_LBL.Text="Contact Number";
            // 
            // verify_lbl
            // 
            verify_lbl.AutoSize=true;
            verify_lbl.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            verify_lbl.ForeColor=Color.White;
            verify_lbl.Location=new Point(219, 217);
            verify_lbl.Name="verify_lbl";
            verify_lbl.Size=new Size(34, 21);
            verify_lbl.TabIndex=15;
            verify_lbl.Text="----";
            // 
            // reset_btn
            // 
            reset_btn.Location=new Point(12, 199);
            reset_btn.Name="reset_btn";
            reset_btn.Size=new Size(53, 23);
            reset_btn.TabIndex=16;
            reset_btn.Text="Reset";
            reset_btn.UseVisualStyleBackColor=true;
            reset_btn.Click+=reset_btn_Click;
            // 
            // Register_Form
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(108, 84, 171);
            ClientSize=new Size(385, 345);
            Controls.Add(reset_btn);
            Controls.Add(verify_lbl);
            Controls.Add(CN_LBL);
            Controls.Add(EM_LBL);
            Controls.Add(CT_LBL);
            Controls.Add(ADD_LBL);
            Controls.Add(LN_LBL);
            Controls.Add(FN_LBL);
            Controls.Add(reg_subm);
            Controls.Add(verify_btn);
            Controls.Add(verify_tb);
            Controls.Add(reg_CNT);
            Controls.Add(reg_EM);
            Controls.Add(reg_CT);
            Controls.Add(reg_Add);
            Controls.Add(reg_LN);
            Controls.Add(reg_FN);
            Name="Register_Form";
            Text=" ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox reg_FN;
        private TextBox reg_LN;
        private TextBox reg_Add;
        private TextBox reg_CT;
        private TextBox reg_EM;
        private TextBox reg_CNT;
        private TextBox verify_tb;
        private Button verify_btn;
        private Button reg_subm;
        private Label FN_LBL;
        private Label LN_LBL;
        private Label ADD_LBL;
        private Label CT_LBL;
        private Label EM_LBL;
        private Label CN_LBL;
        private Label verify_lbl;
        private Button reset_btn;
    }
}