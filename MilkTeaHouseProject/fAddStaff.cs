﻿using System;
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

            this.txtID.Text = (StaffDAL.Instance.GetMAXStaffID() + 1).ToString();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string imgLocation = "";
        byte[] img = null;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = this.txtUser.Text;
            string password = this.txtPass.Text;
            string name = this.txtName.Text;
            DateTime birthdate = this.dateTimePicker1.Value;
            string position = this.cbbPos.Text;
            string phoneNumber = this.txtPhoneNumber.Text;

            if (imgLocation == "")
            {
                LoadImage();
            }
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader bnr = new BinaryReader(stream);
            img = bnr.ReadBytes((int)stream.Length);

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập Họ Tên", "Error");
            }
            else if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Chọn Công việc", "Error");
            }
            else if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Nhập SĐT", "Error");
            }
            else if (position == "Thu Ngân")
            {
                if (string.IsNullOrEmpty(this.txtUser.Text))
                {
                    MessageBox.Show("Nhập User", "Error");
                }
                else if (string.IsNullOrEmpty(this.txtPass.Text))
                {
                    MessageBox.Show("Nhập PassWord", "Error");
                }
                else
                {
                    if (AccountDAL.Instance.SignUp(username, password))
                    {
                        StaffDAL.Instance.AddStaff(name, img, birthdate, position, username, phoneNumber);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Trùng username", "Error");
                    }    
                }
            }
            else
            {
                StaffDAL.Instance.AddStaff(name, img, birthdate, position, phoneNumber);
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

        private void LoadImage()
        {
            imgLocation = "./images/blank-profile.png";
        }

        private void txtSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cbbPos.Text != "Thu Ngân") e.Handled = true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cbbPos.Text != "Thu Ngân") e.Handled = true;
        }
    }
}
