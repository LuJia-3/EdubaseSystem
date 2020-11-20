using System;
using SmartLinli.DatabaseDevelopement;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            string commandText =
                $"SELECT * FROM tb_Student WHERE No='{ this.txb_StudentNo }';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txb_StudentNo.Text = sqlHelper["No"].ToString();
                this.txb_Name.Text = sqlHelper["Name"].ToString();
                this.txb_Gender.Text = sqlHelper["Gender"].ToString();
                this.txb_Class.Text = sqlHelper["Class"].ToString();

            }

        }
    }
}
