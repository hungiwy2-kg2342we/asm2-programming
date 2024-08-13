using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm2juan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string User, Password;
            User = string.Empty;
            Password = string.Empty;
            BillWater BillWater = new BillWater();
            BillWater.Show();
            MessageBox.Show(" Successful login ", "Notice to you ");
            this.Hide();
        }

        private void TbxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
