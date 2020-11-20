namespace LogIn
{
    partial class frm_SignUp
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
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lab_Password = new System.Windows.Forms.Label();
            this.txb_StudentNo = new System.Windows.Forms.TextBox();
            this.lab_StudentNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(187, 174);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 9;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(163, 114);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(121, 25);
            this.txb_Password.TabIndex = 8;
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.Location = new System.Drawing.Point(106, 117);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(37, 15);
            this.lab_Password.TabIndex = 7;
            this.lab_Password.Text = "密码";
            // 
            // txb_StudentNo
            // 
            this.txb_StudentNo.Location = new System.Drawing.Point(163, 65);
            this.txb_StudentNo.Name = "txb_StudentNo";
            this.txb_StudentNo.Size = new System.Drawing.Size(121, 25);
            this.txb_StudentNo.TabIndex = 6;           // 
            // lab_StudentNo
            // 
            this.lab_StudentNo.AutoSize = true;
            this.lab_StudentNo.Location = new System.Drawing.Point(90, 68);
            this.lab_StudentNo.Name = "lab_StudentNo";
            this.lab_StudentNo.Size = new System.Drawing.Size(67, 15);
            this.lab_StudentNo.TabIndex = 5;
            this.lab_StudentNo.Text = "用户账号";
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 276);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lab_Password);
            this.Controls.Add(this.txb_StudentNo);
            this.Controls.Add(this.lab_StudentNo);
            this.Name = "frm_SignUp";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.TextBox txb_StudentNo;
        private System.Windows.Forms.Label lab_StudentNo;
    }
}