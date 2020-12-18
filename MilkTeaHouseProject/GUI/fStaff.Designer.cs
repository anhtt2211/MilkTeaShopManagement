﻿namespace MilkTeaHouseProject
{
    partial class fStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaff));
            this.pnStaff = new System.Windows.Forms.Panel();
            this.flowLayoutPanelStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPosition = new Guna.UI.WinForms.GunaLabel();
            this.lbUserName = new Guna.UI.WinForms.GunaLabel();
            this.lbOvertime = new Guna.UI.WinForms.GunaLabel();
            this.lbFaust = new Guna.UI.WinForms.GunaLabel();
            this.lbSalary = new Guna.UI.WinForms.GunaLabel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.lbID = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new Guna.UI.WinForms.GunaButton();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnUpdateSalary = new Guna.UI.WinForms.GunaButton();
            this.btSetSalary = new Guna.UI.WinForms.GunaButton();
            this.btAdd = new Guna.UI.WinForms.GunaButton();
            this.pnStaff.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnStaff
            // 
            this.pnStaff.Controls.Add(this.flowLayoutPanelStaff);
            this.pnStaff.Controls.Add(this.panel1);
            this.pnStaff.Controls.Add(this.panel2);
            this.pnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStaff.Location = new System.Drawing.Point(0, 0);
            this.pnStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnStaff.Name = "pnStaff";
            this.pnStaff.Size = new System.Drawing.Size(1820, 1100);
            this.pnStaff.TabIndex = 0;
            // 
            // flowLayoutPanelStaff
            // 
            this.flowLayoutPanelStaff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelStaff.Location = new System.Drawing.Point(0, 127);
            this.flowLayoutPanelStaff.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelStaff.Name = "flowLayoutPanelStaff";
            this.flowLayoutPanelStaff.Size = new System.Drawing.Size(1820, 973);
            this.flowLayoutPanelStaff.TabIndex = 15;
            this.flowLayoutPanelStaff.SizeChanged += new System.EventHandler(this.flowLayoutPanelStaff_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.lbPosition);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.lbOvertime);
            this.panel1.Controls.Add(this.lbFaust);
            this.panel1.Controls.Add(this.lbSalary);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1820, 49);
            this.panel1.TabIndex = 14;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(540, 9);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(61, 30);
            this.lbPosition.TabIndex = 21;
            this.lbPosition.Text = "Vị trí";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(684, 5);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(160, 30);
            this.lbUserName.TabIndex = 20;
            this.lbUserName.Text = "Tên đăng nhập";
            // 
            // lbOvertime
            // 
            this.lbOvertime.AutoSize = true;
            this.lbOvertime.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOvertime.Location = new System.Drawing.Point(927, 9);
            this.lbOvertime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOvertime.Name = "lbOvertime";
            this.lbOvertime.Size = new System.Drawing.Size(147, 30);
            this.lbOvertime.TabIndex = 19;
            this.lbOvertime.Text = "Giờ làm thêm";
            // 
            // lbFaust
            // 
            this.lbFaust.AutoSize = true;
            this.lbFaust.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFaust.Location = new System.Drawing.Point(1108, 9);
            this.lbFaust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFaust.Name = "lbFaust";
            this.lbFaust.Size = new System.Drawing.Size(69, 30);
            this.lbFaust.TabIndex = 19;
            this.lbFaust.Text = "Số lỗi";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(1254, 9);
            this.lbSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(77, 30);
            this.lbSalary.TabIndex = 18;
            this.lbSalary.Text = "Lương";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(178, 9);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(152, 30);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Tên nhân viên";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(14, 5);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(148, 30);
            this.lbID.TabIndex = 10;
            this.lbID.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.pnSearch);
            this.panel2.Controls.Add(this.btnUpdateSalary);
            this.panel2.Controls.Add(this.btSetSalary);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1820, 78);
            this.panel2.TabIndex = 13;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExport.AnimationHoverSpeed = 0.07F;
            this.btnExport.AnimationSpeed = 0.03F;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnExport.BorderColor = System.Drawing.Color.White;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.FocusedColor = System.Drawing.Color.Empty;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = null;
            this.btnExport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.Location = new System.Drawing.Point(690, 18);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnExport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExport.OnHoverImage = null;
            this.btnExport.OnPressedColor = System.Drawing.Color.Black;
            this.btnExport.Radius = 10;
            this.btnExport.Size = new System.Drawing.Size(212, 42);
            this.btnExport.TabIndex = 26;
            this.btnExport.Text = "Xuất file Excel";
            this.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSearch.Location = new System.Drawing.Point(1456, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(364, 78);
            this.pnSearch.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.CheckedImage")));
            this.btnSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::MilkTeaHouseProject.Properties.Resources.searchlue2;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.Location = new System.Drawing.Point(274, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(36, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AllowDrop = true;
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(44, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(278, 42);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnUpdateSalary
            // 
            this.btnUpdateSalary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUpdateSalary.AnimationHoverSpeed = 0.07F;
            this.btnUpdateSalary.AnimationSpeed = 0.03F;
            this.btnUpdateSalary.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnUpdateSalary.BorderColor = System.Drawing.Color.White;
            this.btnUpdateSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSalary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateSalary.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateSalary.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSalary.Image = null;
            this.btnUpdateSalary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateSalary.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateSalary.Location = new System.Drawing.Point(18, 18);
            this.btnUpdateSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateSalary.Name = "btnUpdateSalary";
            this.btnUpdateSalary.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnUpdateSalary.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateSalary.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateSalary.OnHoverImage = null;
            this.btnUpdateSalary.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateSalary.Radius = 10;
            this.btnUpdateSalary.Size = new System.Drawing.Size(212, 42);
            this.btnUpdateSalary.TabIndex = 24;
            this.btnUpdateSalary.Text = "Kết toán lương";
            this.btnUpdateSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateSalary.Click += new System.EventHandler(this.btnUpdateSalary_Click);
            // 
            // btSetSalary
            // 
            this.btSetSalary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btSetSalary.AnimationHoverSpeed = 0.07F;
            this.btSetSalary.AnimationSpeed = 0.03F;
            this.btSetSalary.BackColor = System.Drawing.Color.Transparent;
            this.btSetSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btSetSalary.BorderColor = System.Drawing.Color.White;
            this.btSetSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSetSalary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btSetSalary.FocusedColor = System.Drawing.Color.Empty;
            this.btSetSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btSetSalary.ForeColor = System.Drawing.Color.White;
            this.btSetSalary.Image = null;
            this.btSetSalary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btSetSalary.ImageSize = new System.Drawing.Size(20, 20);
            this.btSetSalary.Location = new System.Drawing.Point(243, 18);
            this.btSetSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetSalary.Name = "btSetSalary";
            this.btSetSalary.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btSetSalary.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btSetSalary.OnHoverForeColor = System.Drawing.Color.White;
            this.btSetSalary.OnHoverImage = null;
            this.btSetSalary.OnPressedColor = System.Drawing.Color.Black;
            this.btSetSalary.Radius = 10;
            this.btSetSalary.Size = new System.Drawing.Size(212, 42);
            this.btSetSalary.TabIndex = 24;
            this.btSetSalary.Text = "Thiết lập lương";
            this.btSetSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btSetSalary.Click += new System.EventHandler(this.btSetSalary_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAdd.AnimationHoverSpeed = 0.07F;
            this.btAdd.AnimationSpeed = 0.03F;
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btAdd.BorderColor = System.Drawing.Color.White;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Image = null;
            this.btAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btAdd.Location = new System.Drawing.Point(468, 18);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btAdd.OnHoverImage = null;
            this.btAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btAdd.Radius = 10;
            this.btAdd.Size = new System.Drawing.Size(212, 42);
            this.btAdd.TabIndex = 23;
            this.btAdd.Text = "Thêm nhân viên";
            this.btAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1820, 1100);
            this.Controls.Add(this.pnStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fStaff";
            this.Text = "NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnStaff.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaLabel lbID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStaff;
        private Guna.UI.WinForms.GunaLabel lbSalary;
        private Guna.UI.WinForms.GunaLabel lbFaust;
        private Guna.UI.WinForms.GunaLabel lbUserName;
        private Guna.UI.WinForms.GunaLabel lbPosition;
        private Guna.UI.WinForms.GunaButton btAdd;
        private Guna.UI.WinForms.GunaButton btSetSalary;
        private Guna.UI.WinForms.GunaLabel lbOvertime;
        private Guna.UI.WinForms.GunaButton btnUpdateSalary;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnExport;
    }
}