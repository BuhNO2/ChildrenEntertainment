using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
        public bool AuthCheck(string login, string password)
        {
            DataTable result = Select("users", "*", "login='" + login + "'AND password'" + password + "'AND enabled = 1");
            if (result.Rows.Count == 1)
            {
                Variables.User.Fill(Convert.ToInt32(result.Rows[0][0]), result.Rows[0][2].ToString() + " " + result.Rows[0][3].ToString() + " " + result.Rows[0][4].ToString(), login, result.Rows[0][1].ToString());
                return true;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
                return false;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(!(tbLogin.Text==""|| tbPassword.Text == ""))
            {
                DataBase DB = new DataBase();
                if (DB.AuthCheck(tbLogin.Text, tbPassword.Text))
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
