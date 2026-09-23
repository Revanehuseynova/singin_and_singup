namespace MYproject_singin_singup
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
            groupBox1 = new GroupBox();
            btnSignIn = new Button();
            chkLoginShow = new CheckBox();
            txtLoginPass = new TextBox();
            txtLoginUser = new TextBox();
            groupBox2 = new GroupBox();
            btnSignUp = new Button();
            chkRegShow = new CheckBox();
            txtRegPass = new TextBox();
            txtRegUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Plum;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSignIn);
            groupBox1.Controls.Add(chkLoginShow);
            groupBox1.Controls.Add(txtLoginPass);
            groupBox1.Controls.Add(txtLoginUser);
            groupBox1.ForeColor = Color.DarkBlue;
            groupBox1.Location = new Point(51, 35);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(391, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "sing in";
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(91, 321);
            btnSignIn.Margin = new Padding(4, 4, 4, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(199, 44);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "sing in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // chkLoginShow
            // 
            chkLoginShow.AutoSize = true;
            chkLoginShow.Location = new Point(28, 224);
            chkLoginShow.Margin = new Padding(4, 4, 4, 4);
            chkLoginShow.Name = "chkLoginShow";
            chkLoginShow.Size = new Size(181, 29);
            chkLoginShow.TabIndex = 2;
            chkLoginShow.Text = "show me password";
            chkLoginShow.TextAlign = ContentAlignment.BottomCenter;
            chkLoginShow.UseVisualStyleBackColor = true;
            chkLoginShow.CheckedChanged += chkLoginShow_CheckedChanged;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Location = new Point(25, 151);
            txtLoginPass.Margin = new Padding(4, 4, 4, 4);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Size = new Size(264, 31);
            txtLoginPass.TabIndex = 1;
            txtLoginPass.TextChanged += txtLoginPass_TextChanged;
            // 
            // txtLoginUser
            // 
            txtLoginUser.Location = new Point(25, 69);
            txtLoginUser.Margin = new Padding(4, 4, 4, 4);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(264, 31);
            txtLoginUser.TabIndex = 0;
            txtLoginUser.TextChanged += txtLoginUser_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Plum;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnSignUp);
            groupBox2.Controls.Add(chkRegShow);
            groupBox2.Controls.Add(txtRegPass);
            groupBox2.Controls.Add(txtRegUser);
            groupBox2.ForeColor = Color.DarkBlue;
            groupBox2.Location = new Point(515, 35);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(391, 396);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "sing up";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(91, 321);
            btnSignUp.Margin = new Padding(4, 4, 4, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(199, 44);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "sing up";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // chkRegShow
            // 
            chkRegShow.AutoSize = true;
            chkRegShow.Location = new Point(28, 224);
            chkRegShow.Margin = new Padding(4, 4, 4, 4);
            chkRegShow.Name = "chkRegShow";
            chkRegShow.Size = new Size(181, 29);
            chkRegShow.TabIndex = 2;
            chkRegShow.Text = "show me password";
            chkRegShow.UseVisualStyleBackColor = true;
            // 
            // txtRegPass
            // 
            txtRegPass.Location = new Point(25, 151);
            txtRegPass.Margin = new Padding(4, 4, 4, 4);
            txtRegPass.Name = "txtRegPass";
            txtRegPass.Size = new Size(264, 31);
            txtRegPass.TabIndex = 1;
            // 
            // txtRegUser
            // 
            txtRegUser.Location = new Point(26, 69);
            txtRegUser.Margin = new Padding(4, 4, 4, 4);
            txtRegUser.Name = "txtRegUser";
            txtRegUser.Size = new Size(264, 31);
            txtRegUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 122);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 122);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 40);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 7;
            label4.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 824);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSignIn;
        private CheckBox chkLoginShow;
        private TextBox txtLoginPass;
        private TextBox txtLoginUser;
        private GroupBox groupBox2;
        private Button btnSignUp;
        private CheckBox chkRegShow;
        private TextBox txtRegPass;
        private TextBox txtRegUser;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}
