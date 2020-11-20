namespace LogIn
{
    partial class frm_Home
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
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_StudentNo = new System.Windows.Forms.Label();
            this.lab_Gender = new System.Windows.Forms.Label();
            this.lab_Class = new System.Windows.Forms.Label();
            this.txb_StudentNo = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Gender = new System.Windows.Forms.TextBox();
            this.txb_Class = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(47, 121);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(37, 15);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Text = "姓名";
            // 
            // lab_StudentNo
            // 
            this.lab_StudentNo.AutoSize = true;
            this.lab_StudentNo.Location = new System.Drawing.Point(47, 70);
            this.lab_StudentNo.Name = "lab_StudentNo";
            this.lab_StudentNo.Size = new System.Drawing.Size(37, 15);
            this.lab_StudentNo.TabIndex = 1;
            this.lab_StudentNo.Text = "学号";
            // 
            // lab_Gender
            // 
            this.lab_Gender.AutoSize = true;
            this.lab_Gender.Location = new System.Drawing.Point(47, 172);
            this.lab_Gender.Name = "lab_Gender";
            this.lab_Gender.Size = new System.Drawing.Size(37, 15);
            this.lab_Gender.TabIndex = 2;
            this.lab_Gender.Text = "性别";
            // 
            // lab_Class
            // 
            this.lab_Class.AutoSize = true;
            this.lab_Class.Location = new System.Drawing.Point(47, 223);
            this.lab_Class.Name = "lab_Class";
            this.lab_Class.Size = new System.Drawing.Size(37, 15);
            this.lab_Class.TabIndex = 3;
            this.lab_Class.Text = "班级";
            // 
            // txb_StudentNo
            // 
            this.txb_StudentNo.Location = new System.Drawing.Point(103, 67);
            this.txb_StudentNo.Name = "txb_StudentNo";
            this.txb_StudentNo.Size = new System.Drawing.Size(112, 25);
            this.txb_StudentNo.TabIndex = 4;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(103, 118);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(112, 25);
            this.txb_Name.TabIndex = 5;
            // 
            // txb_Gender
            // 
            this.txb_Gender.Location = new System.Drawing.Point(103, 169);
            this.txb_Gender.Name = "txb_Gender";
            this.txb_Gender.Size = new System.Drawing.Size(112, 25);
            this.txb_Gender.TabIndex = 6;
            // 
            // txb_Class
            // 
            this.txb_Class.Location = new System.Drawing.Point(103, 220);
            this.txb_Class.Name = "txb_Class";
            this.txb_Class.Size = new System.Drawing.Size(112, 25);
            this.txb_Class.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 106);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(12, 12);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(109, 31);
            this.btn_Check.TabIndex = 9;
            this.btn_Check.Text = "查看个人信息";
            this.btn_Check.UseVisualStyleBackColor = true;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 459);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_Class);
            this.Controls.Add(this.txb_Gender);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.txb_StudentNo);
            this.Controls.Add(this.lab_Class);
            this.Controls.Add(this.lab_Gender);
            this.Controls.Add(this.lab_StudentNo);
            this.Controls.Add(this.lab_Name);
            this.Name = "frm_Home";
            this.Text = "Home页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_StudentNo;
        private System.Windows.Forms.Label lab_Gender;
        private System.Windows.Forms.Label lab_Class;
        private System.Windows.Forms.TextBox txb_StudentNo;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Gender;
        private System.Windows.Forms.TextBox txb_Class;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Check;
    }
}