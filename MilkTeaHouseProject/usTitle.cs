﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject
{
    public partial class usTitle : UserControl
    {
        public usTitle()
        {
            InitializeComponent();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            fAddStaff addStaff = new fAddStaff();
            addStaff.ShowDialog();
        }
    }
}