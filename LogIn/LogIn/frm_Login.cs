using System;
using SmartLinli.DatabaseDevelopement;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.AcceptButton = this.btn_Login;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT 1 
					FROM tb_Student
					WHERE No='{this.txb_StudentNo.Text.Trim()}' AND Password='{this.txb_Password.Text.Trim()}';";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(commandText);
            if (result == 1)
            {
                MessageBox.Show("登录成功。");
                frm_Home homeForm = new frm_Home();
                homeForm .Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");
                this.txb_Password.Focus();
                this.txb_Password.SelectAll();
            }
            frm_Home frm_Home = new frm_Home();
            frm_Home.ShowDialog();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            frm_SignUp signUpForm = new frm_SignUp();
            signUpForm.ShowDialog();
        }

    }
}
