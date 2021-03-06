using MilkTeaHouseProject.DAL;
using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.txtPass.UseSystemPasswordChar = true;
            txtUser.Focus();
        }

        #region Methods
        private bool LoginAdmin(string username, string password)
        {
            return AccountDAL.Instance.LoginAdmin(username, password);
        }

        private bool LoginStaff(string username, string password)
        {
            return AccountDAL.Instance.LoginStaff(username, password);
        }

        private bool Login(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password);
        }

        private void ShowError(Control control, string error)
        {
            errorShow.Visible = true;
            errorShow.Location = new Point(control.Location.X, control.Location.Y + control.Height);
            errorShow.Text = error;
        }
        #endregion

        #region Events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUser.Text;
            string password = this.txtPass.Text;

            try
            {
                if (Login(username, password))
                {
                    if (StaffDAL.Instance.CountbyUsername(username) > 0)
                    {
                        fMain f = new fMain(username);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        this.txtUser.Text = this.txtPass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản này chưa được cấp cho nhân viên");
                    }
                }
                else
                {
                    ShowError(txtPass, "Tên đăng nhập hoặc mật khẩu sai");
                }
                if (string.IsNullOrEmpty(txtUser.Text))
                {
                    txtUser.Focus();
                    ShowError(txtUser, "Vui lòng nhập tên đăng nhập");
                    return;
                }
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    txtPass.Focus();
                    ShowError(txtPass, "Vui lòng nhập mật khẩu");
                    return;
                }
            }
            catch
            {

            }
        }

        private void lbSignup_Click(object sender, EventArgs e)
        {
            fSignUp f = new fSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.btnLogin_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text))
            {
                errorShow.Visible = false;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                errorShow.Visible = false;
            }
        }

        private void btnShowPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnShowPass_Click(sender, e);
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            DropShadow shadow = new DropShadow();
            shadow.ApplyShadows(this);
        }
        #endregion
    }
}
