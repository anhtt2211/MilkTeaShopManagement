namespace MilkTeaHouseProject
{
    partial class fInvoice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbNameForm = new System.Windows.Forms.Label();
            this.easyHTMLReports = new KimToo.EasyHTMLReports(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPrintInvoice = new Guna.UI.WinForms.GunaButton();
            this.btnPay = new Guna.UI.WinForms.GunaButton();
            this.txtTotalPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtChange = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtCustomerPay = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lbTotalPrice = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbInfoTable = new Guna.UI.WinForms.GunaLabel();
            this.lbCheckout = new Guna.UI.WinForms.GunaLabel();
            this.lbIdbill = new Guna.UI.WinForms.GunaLabel();
            this.lbStaffName = new Guna.UI.WinForms.GunaLabel();
            this.lbHotline = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.DataGridViewInvoices = new Guna.UI.WinForms.GunaDataGridView();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.lbNameForm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1195, 35);
            this.panel4.TabIndex = 25;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnExit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExit.CheckedForeColor = System.Drawing.Color.White;
            this.btnExit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnExit.CheckedImage")));
            this.btnExit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::MilkTeaHouseProject.Properties.Resources.Delete_32;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.Location = new System.Drawing.Point(1154, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(41, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameForm.Location = new System.Drawing.Point(9, 5);
            this.lbNameForm.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(143, 23);
            this.lbNameForm.TabIndex = 1;
            this.lbNameForm.Text = "Phiếu thanh toán";
            // 
            // easyHTMLReports
            // 
            this.easyHTMLReports.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.easyHTMLReports.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.easyHTMLReports.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.easyHTMLReports.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnPrintInvoice);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.txtChange);
            this.panel2.Controls.Add(this.txtCustomerPay);
            this.panel2.Controls.Add(this.gunaLabel4);
            this.panel2.Controls.Add(this.gunaLabel3);
            this.panel2.Controls.Add(this.lbTotalPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(835, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 689);
            this.panel2.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 689);
            this.panel5.TabIndex = 3;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.AnimationHoverSpeed = 0.07F;
            this.btnPrintInvoice.AnimationSpeed = 0.03F;
            this.btnPrintInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintInvoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.btnPrintInvoice.BorderColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintInvoice.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintInvoice.Image")));
            this.btnPrintInvoice.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrintInvoice.Location = new System.Drawing.Point(121, 484);
            this.btnPrintInvoice.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPrintInvoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.OnHoverImage = null;
            this.btnPrintInvoice.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.Radius = 10;
            this.btnPrintInvoice.Size = new System.Drawing.Size(150, 44);
            this.btnPrintInvoice.TabIndex = 4;
            this.btnPrintInvoice.Text = "In hóa đơn";
            this.btnPrintInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintInvoice.Visible = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnPay
            // 
            this.btnPay.AnimationHoverSpeed = 0.07F;
            this.btnPay.AnimationSpeed = 0.03F;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.btnPay.BorderColor = System.Drawing.Color.Black;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.FocusedColor = System.Drawing.Color.Empty;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::MilkTeaHouseProject.Properties.Resources.Cash_In_Hand_32;
            this.btnPay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPay.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPay.Location = new System.Drawing.Point(121, 405);
            this.btnPay.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(151)))), ((int)(((byte)(71)))));
            this.btnPay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPay.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPay.OnHoverImage = null;
            this.btnPay.OnPressedColor = System.Drawing.Color.Black;
            this.btnPay.Radius = 10;
            this.btnPay.Size = new System.Drawing.Size(150, 44);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTotalPrice.LineSize = 2;
            this.txtTotalPrice.Location = new System.Drawing.Point(201, 104);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(134, 52);
            this.txtTotalPrice.TabIndex = 0;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.Enabled = false;
            this.txtChange.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.LineColor = System.Drawing.Color.Gainsboro;
            this.txtChange.LineSize = 2;
            this.txtChange.Location = new System.Drawing.Point(201, 265);
            this.txtChange.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.ReadOnly = true;
            this.txtChange.SelectedText = "";
            this.txtChange.Size = new System.Drawing.Size(134, 52);
            this.txtChange.TabIndex = 2;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCustomerPay
            // 
            this.txtCustomerPay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCustomerPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerPay.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCustomerPay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPay.LineColor = System.Drawing.Color.Gainsboro;
            this.txtCustomerPay.LineSize = 2;
            this.txtCustomerPay.Location = new System.Drawing.Point(201, 181);
            this.txtCustomerPay.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.txtCustomerPay.MaxLength = 13;
            this.txtCustomerPay.Name = "txtCustomerPay";
            this.txtCustomerPay.PasswordChar = '\0';
            this.txtCustomerPay.SelectedText = "";
            this.txtCustomerPay.Size = new System.Drawing.Size(134, 52);
            this.txtCustomerPay.TabIndex = 1;
            this.txtCustomerPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomerPay.TextChanged += new System.EventHandler(this.txtCustomerPay_TextChanged);
            this.txtCustomerPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerPay_KeyPress);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(21, 280);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(102, 25);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Tiền trả lại";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(21, 196);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(164, 25);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Khách thanh toán";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(21, 119);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(102, 25);
            this.lbTotalPrice.TabIndex = 0;
            this.lbTotalPrice.Text = "Tổng cộng";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 689);
            this.panel1.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbInfoTable);
            this.panel3.Controls.Add(this.lbCheckout);
            this.panel3.Controls.Add(this.lbIdbill);
            this.panel3.Controls.Add(this.lbStaffName);
            this.panel3.Controls.Add(this.lbHotline);
            this.panel3.Controls.Add(this.gunaLabel1);
            this.panel3.Controls.Add(this.DataGridViewInvoices);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(45, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 689);
            this.panel3.TabIndex = 30;
            // 
            // lbInfoTable
            // 
            this.lbInfoTable.AutoSize = true;
            this.lbInfoTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInfoTable.Location = new System.Drawing.Point(-1, 214);
            this.lbInfoTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoTable.Name = "lbInfoTable";
            this.lbInfoTable.Size = new System.Drawing.Size(132, 23);
            this.lbInfoTable.TabIndex = 2;
            this.lbInfoTable.Text = "MILKTEAHOUSE";
            // 
            // lbCheckout
            // 
            this.lbCheckout.AutoSize = true;
            this.lbCheckout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbCheckout.Location = new System.Drawing.Point(-4, 174);
            this.lbCheckout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(132, 23);
            this.lbCheckout.TabIndex = 2;
            this.lbCheckout.Text = "MILKTEAHOUSE";
            // 
            // lbIdbill
            // 
            this.lbIdbill.AutoSize = true;
            this.lbIdbill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbIdbill.Location = new System.Drawing.Point(-1, 134);
            this.lbIdbill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdbill.Name = "lbIdbill";
            this.lbIdbill.Size = new System.Drawing.Size(132, 23);
            this.lbIdbill.TabIndex = 2;
            this.lbIdbill.Text = "MILKTEAHOUSE";
            // 
            // lbStaffName
            // 
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbStaffName.Location = new System.Drawing.Point(-1, 94);
            this.lbStaffName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(132, 23);
            this.lbStaffName.TabIndex = 2;
            this.lbStaffName.Text = "MILKTEAHOUSE";
            // 
            // lbHotline
            // 
            this.lbHotline.AutoSize = true;
            this.lbHotline.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbHotline.Location = new System.Drawing.Point(-1, 56);
            this.lbHotline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHotline.Name = "lbHotline";
            this.lbHotline.Size = new System.Drawing.Size(132, 23);
            this.lbHotline.TabIndex = 2;
            this.lbHotline.Text = "MILKTEAHOUSE";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(-1, 15);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(163, 28);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "MILKTEAHOUSE";
            // 
            // DataGridViewInvoices
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewInvoices.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewInvoices.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewInvoices.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewInvoices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewInvoices.Enabled = false;
            this.DataGridViewInvoices.EnableHeadersVisualStyles = false;
            this.DataGridViewInvoices.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewInvoices.Location = new System.Drawing.Point(0, 265);
            this.DataGridViewInvoices.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.DataGridViewInvoices.Name = "DataGridViewInvoices";
            this.DataGridViewInvoices.RowHeadersVisible = false;
            this.DataGridViewInvoices.RowHeadersWidth = 100;
            this.DataGridViewInvoices.RowTemplate.Height = 24;
            this.DataGridViewInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInvoices.Size = new System.Drawing.Size(790, 424);
            this.DataGridViewInvoices.TabIndex = 1;
            this.DataGridViewInvoices.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewInvoices.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewInvoices.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridViewInvoices.ThemeStyle.ReadOnly = false;
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // fInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1195, 724);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.MinimumSize = new System.Drawing.Size(834, 584);
            this.Name = "fInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbNameForm;
        private KimToo.EasyHTMLReports easyHTMLReports;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnPrintInvoice;
        private Guna.UI.WinForms.GunaButton btnPay;
        private Guna.UI.WinForms.GunaLineTextBox txtTotalPrice;
        private Guna.UI.WinForms.GunaLineTextBox txtChange;
        private Guna.UI.WinForms.GunaLineTextBox txtCustomerPay;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lbTotalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaDataGridView DataGridViewInvoices;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private Guna.UI.WinForms.GunaLabel lbHotline;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbInfoTable;
        private Guna.UI.WinForms.GunaLabel lbCheckout;
        private Guna.UI.WinForms.GunaLabel lbStaffName;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaLabel lbIdbill;
    }
}