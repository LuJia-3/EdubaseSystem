namespace LogIn
{
    partial class frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_StudentNo = new System.Windows.Forms.Label();
            this.txb_StudentNo = new System.Windows.Forms.TextBox();
            this.lab_Password = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_StudentNo
            // 
            this.lab_StudentNo.AutoSize = true;
            this.lab_StudentNo.Location = new System.Drawing.Point(71, 57);
            this.lab_StudentNo.Name = "lab_StudentNo";
            this.lab_StudentNo.Size = new System.Drawing.Size(67, 15);
            this.lab_StudentNo.TabIndex = 0;
            this.lab_StudentNo.Text = "用户账号";
            // 
            // txb_StudentNo
            // 
            this.txb_StudentNo.Location = new System.Drawing.Point(144, 54);
            this.txb_StudentNo.Name = "txb_StudentNo";
            this.txb_StudentNo.Size = new System.Drawing.Size(121, 25);
            this.txb_StudentNo.TabIndex = 1;
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.Location = new System.Drawing.Point(87, 106);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(37, 15);
            this.lab_Password.TabIndex = 2;
            this.lab_Password.Text = "密码";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(144, 103);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(121, 25);
            this.txb_Password.TabIndex = 3;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(168, 147);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 4;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(168, 187);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 240);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lab_Password);
            this.Controls.Add(this.txb_StudentNo);
            this.Controls.Add(this.lab_StudentNo);
            this.Name = "frm_Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_StudentNo;
        private System.Windows.Forms.TextBox txb_StudentNo;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btn_Login;
    }
}

