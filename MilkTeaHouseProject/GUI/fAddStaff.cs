using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;

namespace MilkTeaHouseProject
{
    public partial class fAddStaff : Form
    {
        public fAddStaff()
        {
            InitializeComponent();
            this.CreateItemForComboBox();
        }
        public fAddStaff(int ID, string name, byte[] image, DateTime birthDate, string pos, string phonenumber, string username, string cmnd, bool sex, string address)
        {
            InitializeComponent();
            this.CreateItemForComboBox();
            this.lbIDinrease.Text = ID.ToString();
            this.txtName.Text = name;

            if (image == null)
            {
                ptbImage.Image = null;
            }
            else
            {
                img = image;
                MemoryStream mstream = new MemoryStream(image);
                Bitmap bitmap = new Bitmap(mstream);
                ptbImage.Image = bitmap;
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            this.dptBirthDate.Value = birthDate;
            this.txtPhoneNumber.Text = phonenumber;
            this.cbbPos.Text = pos;
            this.cbbUser.Items.Add(username);
            this.cbbUser.Text = username;
            this.lbUsername.Text = username;
            this.cbbUser.Text = username;
            this.txtCMND.Text = cmnd;

            if (pos.ToLower() == "quản lý".ToLower())
            {
                this.txtPos.Text = pos;
                this.txtPos.Visible = true;
                this.txtPos.Enabled = false;
                this.txtUsername.Text = username;
                this.txtUsername.Visible = true;
                this.txtUsername.Enabled = false;

                this.cbbPos.Visible = false;
                this.cbbUser.Visible = false;
            }
            if (sex)
            {
                this.cbMan.Checked = true;
            }
            else
            {
                this.cbWoman.Checked = true;
            }
            this.txtAddress.Text = address;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string imgLocation = "";
        byte[] img = null;
        private void CreateItemForComboBox()
        {
            List<Position> positions = PositionDAL.Instance.GetListPosistion();
            List<Account> accounts = AccountDAL.Instance.GetListAccount();
            List<Staff> staffs = StaffDAL.Instance.GetListStaff();
            List<string> usernames = new List<string>();
            this.lbIDinrease.Text = (StaffDAL.Instance.GetMAXStaffID() + 1).ToString();
            foreach (Position posistion in positions)
            {
                if (posistion.Name.ToLower() != "Quản Lý".ToLower())
                {
                    this.cbbPos.Items.Add(posistion.Name);
                }
            }
            foreach (Account acc in accounts)
            {
                usernames.Add(acc.Username);
            }
            usernames.Sort();
            foreach (string userName in usernames)
            {
                this.cbbUser.Items.Add(userName);
            }
            foreach (Staff staff in staffs)
            {
                this.cbbUser.Items.Remove(staff.UserName);
            }
        }

        #region Method
        private void ShowError(Control control, string error)
        {
            control.Focus();
            errorShow.Visible = true;
            errorShow.Location = new Point(control.Location.X, control.Location.Y + control.Height);
            errorShow.Text = error;
        }

        private void LoadImage()
        {
            imgLocation = "./images/blank-profile.png";
        }

        public void ActivebtnEdit()
        {
            this.btEdit.Visible = true;
        }

        public void ActivebtnAdd()
        {
            this.btnAdd.Visible = true;
        }

        public void UpdatelbNameForm(string newNameForm)
        {
            this.lbNameForm.Text = newNameForm;
        }
        #endregion

        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = this.cbbUser.Text;
            string name = this.txtName.Text;
            DateTime birthdate = this.dptBirthDate.Value;
            string position = this.cbbPos.Text;
            string phoneNumber = this.txtPhoneNumber.Text;
            string cmnd = this.txtCMND.Text;
            string address = this.txtAddress.Text;
            bool sex = false;
            long salaryReceived = PositionDAL.Instance.GetSalarybyPosition(position);

            if (this.cbMan.Checked == true)
            {
                sex = true;
            }
            if (this.cbWoman.Checked == true)
            {
                sex = false;
            }
            if (string.IsNullOrEmpty(name))
            {
                ShowError(txtName, "Vui lòng nhập họ tên");
                return;
            }
            if ((this.cbMan.Checked == false) && (this.cbWoman.Checked == false))
            {
                errorShow.Visible = true;
                errorShow.Location = new Point(cbMan.Location.X, cbMan.Location.Y + cbMan.Height);
                errorShow.Text = "Vui lòng chọn giới tính";
                return;
            }
            if (cmnd.Length != 9)
            {
                ShowError(txtCMND, "Số CMND không hợp lệ");
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                ShowError(txtAddress, "Vui lòng nhập địa chỉ");
            }
            if (phoneNumber.Length != 10)
            {
                ShowError(txtPhoneNumber, "SĐT không hợp lệ");
                return;
            }
            if (string.IsNullOrEmpty(position))
            {
                ShowError(cbbPos, "Vui lòng chọn vị trí ");
                return;
            }
            if (imgLocation == "")
            {
                LoadImage();
            }

            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader bnr = new BinaryReader(stream);
            img = bnr.ReadBytes((int)stream.Length);

            if (position.ToLower() == "THU NGÂN".ToLower())
            {
                if (string.IsNullOrEmpty(username))
                {
                    ShowError(this.cbbUser, "Vui lòng chọn tài khoản!");
                    return;
                }
                StaffDAL.Instance.AddStaff(name, img, birthdate, position, username, salaryReceived, phoneNumber, cmnd, sex, address);
                this.Close();
            }
            else
            {
                StaffDAL.Instance.AddStaff(name, img, birthdate, position, salaryReceived, phoneNumber, cmnd, sex, address);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ptbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.png)(*.jpg)(*.jepg)(*.ico)|*.png;*.jpg;*.jepg;*.ico";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ptbImage.ImageLocation = imgLocation;
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == true)
            {
                this.btnAdd_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == false)
            {
                this.btEdit_Click(sender, e);
            }

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cbbPos.Text.ToUpper() != "THU NGÂN")
            {
                e.Handled = true;
            }
        }

        private void btAddUserName_Click(object sender, EventArgs e)
        {
            fSignUp frm = new fSignUp();
            frm.ShowDialog();
            List<Account> accounts = AccountDAL.Instance.GetListAccount();
            this.cbbUser.Items.Clear();
            foreach (Account acc in accounts)
            {
                this.cbbUser.Items.Add(acc.Username);
            }
        }

        private void cbbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbPos.Text.ToUpper() == "THU NGÂN")
            {
                this.cbbUser.Visible = true;
                this.btAddUserName.Visible = true;
            }
            else
            {
                this.cbbUser.Visible = false;
                this.btAddUserName.Visible = false;
            }
        }

        private void btAddPosition_Click(object sender, EventArgs e)
        {
            fSetSalary frm = new fSetSalary();
            frm.lbNameForm.Text = "Thêm vị trí";
            frm.ShowDialog();
            List<Position> positions = PositionDAL.Instance.GetListPosistion();
            this.cbbPos.Items.Clear();
            foreach (Position pos in positions)
            {
                if (pos.Name.ToLower() != "Quản lý".ToLower())
                    this.cbbPos.Items.Add(pos.Name);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.lbIDinrease.Text.ToString());
            string username = this.cbbUser.Text;
            string name = this.txtName.Text;
            DateTime birthdate = this.dptBirthDate.Value;
            string position = this.cbbPos.Text;
            string phoneNumber = this.txtPhoneNumber.Text;
            string cmnd = this.txtCMND.Text;
            string address = this.txtAddress.Text;
            bool sex = false;
            long salaryReceived = PositionDAL.Instance.GetSalarybyPosition(position);

            if (this.txtPos.Text.ToLower() == "quản lý".ToLower())
            {
                position = this.txtPos.Text;
                username = this.txtUsername.Text;
            }
            if (this.cbMan.Checked == true)
            {
                sex = true;
            }
            if (this.cbWoman.Checked == true)
            {
                sex = false;
            }
            if (this.cbMan.Checked == false && this.cbWoman.Checked == false)
            {
                errorShow.Visible = true;
                errorShow.Location = new Point(cbMan.Location.X, cbMan.Location.Y + cbMan.Height);
                errorShow.Text = "Vui lòng chọn giới tính";
                return;
            }

            if (this.ptbImage.Image == null)
            {
                if (imgLocation == "")
                {
                    LoadImage();
                }
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader bnr = new BinaryReader(stream);
                img = bnr.ReadBytes((int)stream.Length);
            }
            else
            {
                if (imgLocation != "")
                {
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader bnr = new BinaryReader(stream);
                    img = bnr.ReadBytes((int)stream.Length);
                }
            }

            if (string.IsNullOrEmpty(name))
            {
                ShowError(txtName, "Vui lòng nhập họ tên ");
                return;
            }
            if (string.IsNullOrEmpty(position))
            {
                ShowError(cbbPos, "Vui lòng chọn vị trí ");
                return;
            }
            if (phoneNumber.Length != 10)
            {
                ShowError(txtPhoneNumber, "SĐT không hợp lệ");
                return;
            }
            if (cmnd.Length != 9)
            {
                ShowError(txtCMND, "Số CMND không hợp lệ  ");
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                ShowError(txtAddress, "Vui lòng nhập địa chỉ ");
            }
            if (position.ToUpper() == "THU NGÂN".ToUpper() || position.ToUpper() == "quản lý".ToUpper())
            {
                if (string.IsNullOrEmpty(username) && position.ToUpper() == "THU NGÂN".ToUpper())
                {
                    ShowError(this.cbbUser, "Vui lòng chọn tài khoản!");
                    return;
                }
                StaffDAL.Instance.EditStaff(id, name, img, birthdate, position, salaryReceived, phoneNumber, username, cmnd, sex, address);
                this.Close();
            }
            else
            {
                StaffDAL.Instance.SetUsernameToNULLbyID(id);
                AccountDAL.Instance.DelAccount(this.lbUsername.Text);
                StaffDAL.Instance.EditStaff(id, name, img, birthdate, position, salaryReceived, phoneNumber, cmnd, sex, address);
                this.Close();
            }
        }

        private void fAddStaff_Load(object sender, EventArgs e)
        {
            DropShadow shadow = new DropShadow();
            shadow.ApplyShadows(this);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.errorShow.Visible = false;
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            this.errorShow.Visible = false;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            this.errorShow.Visible = false;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            this.errorShow.Visible = false;
        }

        private void btnAddUserName_Click(object sender, EventArgs e)
        {
            fSignUp frm = new fSignUp();
            frm.ShowDialog();
            List<Account> accounts = AccountDAL.Instance.GetListAccount();
            this.cbbUser.Items.Clear();
            foreach (Account account in accounts)
            {
                if (account.Type != false)
                    this.cbbUser.Items.Add(account.Username);
            }
        }

        private void cbMan_Click(object sender, EventArgs e)
        {
            this.cbWoman.Checked = false;
        }

        private void cbWoman_Click(object sender, EventArgs e)
        {
            this.cbMan.Checked = false;
        }

        
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == true)
            {
                this.btnAdd_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == false)
            {
                this.btEdit_Click(sender, e);
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == true)
            {
                this.btnAdd_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == false)
            {
                this.btEdit_Click(sender, e);
            }
        }

        private void txtPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == true)
            {
                this.btnAdd_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == false)
            {
                this.btEdit_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == true)
            {
                this.btnAdd_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == false)
            {
                this.btEdit_Click(sender, e);
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == true)
            {
                this.btnAdd_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Enter && this.btnAdd.Visible == false)
            {
                this.btEdit_Click(sender, e);
            }
        }
        #endregion

    }
}
