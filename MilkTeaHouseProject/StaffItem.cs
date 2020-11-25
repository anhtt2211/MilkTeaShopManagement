﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;

namespace MilkTeaHouseProject
{
    public partial class StaffItem : UserControl
    {
        public StaffItem()
        {
            InitializeComponent();
        }
        public StaffItem(int id, string name, byte[] image,DateTime birthdate, string position, string userName, int overtime, int fault,int salaryReceived)
        {
            InitializeComponent();
            this.lbID.Text = id.ToString();
            this.lbName.Text = name;
            if (image == null)
            {
                this.picStaff.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(image);
                picStaff.Image = Image.FromStream(mstream);
                picStaff.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            this.lbBirthDate.Text = birthdate.ToString("dd/M/yyyy");
            this.lbPosition.Text = position;
            this.lbUserName.Text = userName;
            this.numericUpDownOverTime.Value = overtime;
            this.numericFault.Value = fault;
            this.lbSalary.Text = string.Format("{0:n0}", salaryReceived).ToString();
        }
        public event EventHandler onEdit = null;
        public event EventHandler onDel = null;
        public event EventHandler onOverTimeValueChanged = null;
        public event EventHandler onFaultChanged = null;


        private void btEdit_Click(object sender, EventArgs e)
        {
            if (onEdit != null)
            {
                onEdit.Invoke(this, new EventArgs());
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (onDel != null)
            {
                onDel.Invoke(this, new EventArgs());
            }
        }

        private void StaffItem_SizeChanged(object sender, EventArgs e)
        {
            int space = this.Width/ 8 ;
            picStaff.Location = new Point(10,6);
            lbID.Location = new Point(120, 18);
            lbName.Location = new Point((int)(space*1.7), 18);
            lbBirthDate.Location = new Point((int)(space * 3), 18);
            lbPosition.Location = new Point(space * 4 , 18);
            numericUpDownOverTime.Location = new Point(space * 5 , 18);
            lbSalary.Location = new Point(space * 6, 18);
            btEdit.Location = new Point(space * 7,18);
            btDel.Location = new Point(space * 7 +50,18);
        }

        private void numericUpDownOverTime_ValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.lbID.Text);
            int overtime = int.Parse(this.numericUpDownOverTime.Value.ToString());

            StaffDAL.Instance.UpdateOverTime(id, overtime);
            
            if (onOverTimeValueChanged != null)
            {
                onOverTimeValueChanged.Invoke(this, new EventArgs());
            }

        }
        private void numericFault_ValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.lbID.Text);
            int fault = (int)this.numericFault.Value;

            StaffDAL.Instance.UpdateFault(id, fault);
            
            if (onFaultChanged != null)
            {
                onFaultChanged.Invoke(this, new EventArgs());
            }
        }
    }
}
