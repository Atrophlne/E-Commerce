namespace ECommerceProj
{
    partial class Account_Settings_Form
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
            side_panel=new Panel();
            acc_delbtn=new FontAwesome.Sharp.IconButton();
            acc_chbtn=new FontAwesome.Sharp.IconButton();
            panel2=new Panel();
            window_panel=new Panel();
            ch_curpwlbl=new Label();
            ch_curpwtb=new TextBox();
            del_codelbl=new Label();
            ch_codelbl=new Label();
            del_pwlbl=new Label();
            ch_pwlbl=new Label();
            del_EMlbl=new Label();
            ch_EMlbl=new Label();
            ch_codebtn=new Button();
            ch_codetb=new TextBox();
            ch_chngbtn=new Button();
            del_delbtn=new Button();
            del_codebtn=new Button();
            del_codetb=new TextBox();
            del_pwtb=new TextBox();
            del_emtb=new TextBox();
            ch_pwtb=new TextBox();
            ch_Emtb=new TextBox();
            side_panel.SuspendLayout();
            window_panel.SuspendLayout();
            SuspendLayout();
            // 
            // side_panel
            // 
            side_panel.BackColor=Color.FromArgb(54, 81, 143);
            side_panel.Controls.Add(acc_delbtn);
            side_panel.Controls.Add(acc_chbtn);
            side_panel.Controls.Add(panel2);
            side_panel.Dock=DockStyle.Left;
            side_panel.Location=new Point(0, 0);
            side_panel.Name="side_panel";
            side_panel.Size=new Size(122, 322);
            side_panel.TabIndex=0;
            // 
            // acc_delbtn
            // 
            acc_delbtn.Dock=DockStyle.Top;
            acc_delbtn.FlatAppearance.BorderSize=0;
            acc_delbtn.FlatStyle=FlatStyle.Flat;
            acc_delbtn.Font=new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            acc_delbtn.ForeColor=Color.White;
            acc_delbtn.IconChar=FontAwesome.Sharp.IconChar.Trash;
            acc_delbtn.IconColor=Color.White;
            acc_delbtn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            acc_delbtn.IconSize=23;
            acc_delbtn.ImageAlign=ContentAlignment.MiddleLeft;
            acc_delbtn.Location=new Point(0, 110);
            acc_delbtn.Name="acc_delbtn";
            acc_delbtn.Padding=new Padding(8, 0, 20, 0);
            acc_delbtn.Size=new Size(122, 36);
            acc_delbtn.TabIndex=1;
            acc_delbtn.Text="Delete";
            acc_delbtn.TextAlign=ContentAlignment.MiddleRight;
            acc_delbtn.UseVisualStyleBackColor=true;
            acc_delbtn.Click+=acc_delbtn_Click;
            // 
            // acc_chbtn
            // 
            acc_chbtn.Dock=DockStyle.Top;
            acc_chbtn.FlatAppearance.BorderSize=0;
            acc_chbtn.FlatStyle=FlatStyle.Flat;
            acc_chbtn.Font=new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            acc_chbtn.ForeColor=Color.White;
            acc_chbtn.IconChar=FontAwesome.Sharp.IconChar.ArrowsRotate;
            acc_chbtn.IconColor=Color.White;
            acc_chbtn.IconFont=FontAwesome.Sharp.IconFont.Auto;
            acc_chbtn.IconSize=25;
            acc_chbtn.ImageAlign=ContentAlignment.MiddleLeft;
            acc_chbtn.Location=new Point(0, 74);
            acc_chbtn.Name="acc_chbtn";
            acc_chbtn.Padding=new Padding(7, 0, 5, 0);
            acc_chbtn.Size=new Size(122, 36);
            acc_chbtn.TabIndex=0;
            acc_chbtn.Text="Password";
            acc_chbtn.TextAlign=ContentAlignment.MiddleRight;
            acc_chbtn.UseVisualStyleBackColor=true;
            acc_chbtn.Click+=acc_chbtn_Click;
            // 
            // panel2
            // 
            panel2.Dock=DockStyle.Top;
            panel2.Location=new Point(0, 0);
            panel2.Name="panel2";
            panel2.Size=new Size(122, 74);
            panel2.TabIndex=0;
            // 
            // window_panel
            // 
            window_panel.Controls.Add(ch_curpwlbl);
            window_panel.Controls.Add(ch_curpwtb);
            window_panel.Controls.Add(del_codelbl);
            window_panel.Controls.Add(ch_codelbl);
            window_panel.Controls.Add(del_pwlbl);
            window_panel.Controls.Add(ch_pwlbl);
            window_panel.Controls.Add(del_EMlbl);
            window_panel.Controls.Add(ch_EMlbl);
            window_panel.Controls.Add(ch_codebtn);
            window_panel.Controls.Add(ch_codetb);
            window_panel.Controls.Add(ch_chngbtn);
            window_panel.Controls.Add(del_delbtn);
            window_panel.Controls.Add(del_codebtn);
            window_panel.Controls.Add(del_codetb);
            window_panel.Controls.Add(del_pwtb);
            window_panel.Controls.Add(del_emtb);
            window_panel.Controls.Add(ch_pwtb);
            window_panel.Controls.Add(ch_Emtb);
            window_panel.Dock=DockStyle.Fill;
            window_panel.Location=new Point(122, 0);
            window_panel.Name="window_panel";
            window_panel.Size=new Size(403, 322);
            window_panel.TabIndex=1;
            // 
            // ch_curpwlbl
            // 
            ch_curpwlbl.AutoSize=true;
            ch_curpwlbl.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ch_curpwlbl.ForeColor=Color.White;
            ch_curpwlbl.Location=new Point(38, 114);
            ch_curpwlbl.Name="ch_curpwlbl";
            ch_curpwlbl.Size=new Size(124, 21);
            ch_curpwlbl.TabIndex=17;
            ch_curpwlbl.Text="Current Cont.N";
            // 
            // ch_curpwtb
            // 
            ch_curpwtb.Location=new Point(38, 138);
            ch_curpwtb.Name="ch_curpwtb";
            ch_curpwtb.Size=new Size(143, 23);
            ch_curpwtb.TabIndex=1;
            // 
            // del_codelbl
            // 
            del_codelbl.AutoSize=true;
            del_codelbl.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            del_codelbl.ForeColor=Color.White;
            del_codelbl.Location=new Point(235, 166);
            del_codelbl.Name="del_codelbl";
            del_codelbl.Size=new Size(34, 21);
            del_codelbl.TabIndex=15;
            del_codelbl.Text="----";
            // 
            // ch_codelbl
            // 
            ch_codelbl.AutoSize=true;
            ch_codelbl.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ch_codelbl.ForeColor=Color.White;
            ch_codelbl.Location=new Point(38, 223);
            ch_codelbl.Name="ch_codelbl";
            ch_codelbl.Size=new Size(34, 21);
            ch_codelbl.TabIndex=14;
            ch_codelbl.Text="----";
            // 
            // del_pwlbl
            // 
            del_pwlbl.AutoSize=true;
            del_pwlbl.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            del_pwlbl.ForeColor=Color.White;
            del_pwlbl.Location=new Point(235, 114);
            del_pwlbl.Name="del_pwlbl";
            del_pwlbl.Size=new Size(63, 21);
            del_pwlbl.TabIndex=13;
            del_pwlbl.Text="Cont.N";
            // 
            // ch_pwlbl
            // 
            ch_pwlbl.AutoSize=true;
            ch_pwlbl.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ch_pwlbl.ForeColor=Color.White;
            ch_pwlbl.Location=new Point(38, 171);
            ch_pwlbl.Name="ch_pwlbl";
            ch_pwlbl.Size=new Size(102, 21);
            ch_pwlbl.TabIndex=12;
            ch_pwlbl.Text="New Cont.N";
            // 
            // del_EMlbl
            // 
            del_EMlbl.AutoSize=true;
            del_EMlbl.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            del_EMlbl.ForeColor=Color.White;
            del_EMlbl.Location=new Point(235, 59);
            del_EMlbl.Name="del_EMlbl";
            del_EMlbl.Size=new Size(53, 21);
            del_EMlbl.TabIndex=11;
            del_EMlbl.Text="Email";
            // 
            // ch_EMlbl
            // 
            ch_EMlbl.AutoSize=true;
            ch_EMlbl.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ch_EMlbl.ForeColor=Color.White;
            ch_EMlbl.Location=new Point(38, 59);
            ch_EMlbl.Name="ch_EMlbl";
            ch_EMlbl.Size=new Size(53, 21);
            ch_EMlbl.TabIndex=10;
            ch_EMlbl.Text="Email";
            // 
            // ch_codebtn
            // 
            ch_codebtn.Location=new Point(102, 246);
            ch_codebtn.Name="ch_codebtn";
            ch_codebtn.Size=new Size(57, 23);
            ch_codebtn.TabIndex=4;
            ch_codebtn.Text="Code";
            ch_codebtn.UseVisualStyleBackColor=true;
            ch_codebtn.Click+=ch_codebtn_Click;
            // 
            // ch_codetb
            // 
            ch_codetb.Location=new Point(38, 247);
            ch_codetb.Name="ch_codetb";
            ch_codetb.Size=new Size(39, 23);
            ch_codetb.TabIndex=3;
            // 
            // ch_chngbtn
            // 
            ch_chngbtn.Location=new Point(38, 287);
            ch_chngbtn.Name="ch_chngbtn";
            ch_chngbtn.Size=new Size(57, 23);
            ch_chngbtn.TabIndex=5;
            ch_chngbtn.Text="Change";
            ch_chngbtn.UseVisualStyleBackColor=true;
            ch_chngbtn.Click+=ch_chngbtn_Click;
            // 
            // del_delbtn
            // 
            del_delbtn.Location=new Point(235, 230);
            del_delbtn.Name="del_delbtn";
            del_delbtn.Size=new Size(57, 23);
            del_delbtn.TabIndex=8;
            del_delbtn.Text="Delete";
            del_delbtn.UseVisualStyleBackColor=true;
            del_delbtn.Click+=del_delbtn_Click;
            // 
            // del_codebtn
            // 
            del_codebtn.Location=new Point(299, 189);
            del_codebtn.Name="del_codebtn";
            del_codebtn.Size=new Size(57, 23);
            del_codebtn.TabIndex=7;
            del_codebtn.Text="Code";
            del_codebtn.UseVisualStyleBackColor=true;
            del_codebtn.Click+=del_codebtn_Click;
            // 
            // del_codetb
            // 
            del_codetb.Location=new Point(235, 190);
            del_codetb.Name="del_codetb";
            del_codetb.Size=new Size(39, 23);
            del_codetb.TabIndex=6;
            // 
            // del_pwtb
            // 
            del_pwtb.Location=new Point(235, 138);
            del_pwtb.Name="del_pwtb";
            del_pwtb.Size=new Size(135, 23);
            del_pwtb.TabIndex=5;
            // 
            // del_emtb
            // 
            del_emtb.Location=new Point(235, 83);
            del_emtb.Name="del_emtb";
            del_emtb.Size=new Size(135, 23);
            del_emtb.TabIndex=4;
            // 
            // ch_pwtb
            // 
            ch_pwtb.Location=new Point(38, 195);
            ch_pwtb.Name="ch_pwtb";
            ch_pwtb.Size=new Size(143, 23);
            ch_pwtb.TabIndex=2;
            // 
            // ch_Emtb
            // 
            ch_Emtb.Location=new Point(38, 83);
            ch_Emtb.Name="ch_Emtb";
            ch_Emtb.Size=new Size(143, 23);
            ch_Emtb.TabIndex=0;
            // 
            // Account_Settings_Form
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(79, 118, 209);
            ClientSize=new Size(525, 322);
            Controls.Add(window_panel);
            Controls.Add(side_panel);
            Name="Account_Settings_Form";
            Text="Account_Settings_Form";
            side_panel.ResumeLayout(false);
            window_panel.ResumeLayout(false);
            window_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel side_panel;
        private FontAwesome.Sharp.IconButton acc_delbtn;
        private FontAwesome.Sharp.IconButton acc_chbtn;
        private Panel panel2;
        private Panel window_panel;
        private Label del_codelbl;
        private Label ch_codelbl;
        private Label del_pwlbl;
        private Label ch_pwlbl;
        private Label del_EMlbl;
        private Label ch_EMlbl;
        private Button ch_codebtn;
        private TextBox ch_codetb;
        private Button ch_chngbtn;
        private Button del_delbtn;
        private Button del_codebtn;
        private TextBox del_codetb;
        private TextBox del_pwtb;
        private TextBox del_emtb;
        private TextBox ch_pwtb;
        private TextBox ch_Emtb;
        private Label ch_curpwlbl;
        private TextBox ch_curpwtb;
    }
}