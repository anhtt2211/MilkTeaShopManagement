﻿namespace MilkTeaHouseProject
{
    partial class DrinksReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbbCount_or_Revenue = new Guna.UI.WinForms.GunaComboBox();
            this.cbbPeriod = new Guna.UI.WinForms.GunaComboBox();
            this.cbbTime = new Guna.UI.WinForms.GunaComboBox();
            this.CartesianChartReport = new LiveCharts.WinForms.CartesianChart();
            this.pnSales = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.pnSales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gunaLabel1);
            this.panel4.Controls.Add(this.cbbCount_or_Revenue);
            this.panel4.Controls.Add(this.cbbPeriod);
            this.panel4.Controls.Add(this.cbbTime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1132, 116);
            this.panel4.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(14, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(291, 32);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "TOP MÓN ĂN BÁN CHẠY";
            // 
            // cbbCount_or_Revenue
            // 
            this.cbbCount_or_Revenue.BackColor = System.Drawing.Color.Transparent;
            this.cbbCount_or_Revenue.BaseColor = System.Drawing.Color.White;
            this.cbbCount_or_Revenue.BorderColor = System.Drawing.Color.Silver;
            this.cbbCount_or_Revenue.BorderSize = 1;
            this.cbbCount_or_Revenue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCount_or_Revenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCount_or_Revenue.FocusedColor = System.Drawing.Color.Empty;
            this.cbbCount_or_Revenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCount_or_Revenue.ForeColor = System.Drawing.Color.Black;
            this.cbbCount_or_Revenue.FormattingEnabled = true;
            this.cbbCount_or_Revenue.Items.AddRange(new object[] {
            "Theo doanh số",
            "Theo số lượng"});
            this.cbbCount_or_Revenue.Location = new System.Drawing.Point(440, 22);
            this.cbbCount_or_Revenue.Name = "cbbCount_or_Revenue";
            this.cbbCount_or_Revenue.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbCount_or_Revenue.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbCount_or_Revenue.Size = new System.Drawing.Size(282, 35);
            this.cbbCount_or_Revenue.TabIndex = 5;
            this.cbbCount_or_Revenue.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // cbbPeriod
            // 
            this.cbbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPeriod.BackColor = System.Drawing.Color.Transparent;
            this.cbbPeriod.BaseColor = System.Drawing.Color.White;
            this.cbbPeriod.BorderColor = System.Drawing.Color.Silver;
            this.cbbPeriod.BorderSize = 1;
            this.cbbPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPeriod.FocusedColor = System.Drawing.Color.Empty;
            this.cbbPeriod.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPeriod.ForeColor = System.Drawing.Color.Black;
            this.cbbPeriod.FormattingEnabled = true;
            this.cbbPeriod.Items.AddRange(new object[] {
            "Theo tháng",
            "Theo năm"});
            this.cbbPeriod.Location = new System.Drawing.Point(702, 70);
            this.cbbPeriod.Name = "cbbPeriod";
            this.cbbPeriod.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbPeriod.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbPeriod.Size = new System.Drawing.Size(178, 32);
            this.cbbPeriod.TabIndex = 5;
            this.cbbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbbPeriod_SelectedIndexChanged);
            // 
            // cbbTime
            // 
            this.cbbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTime.BackColor = System.Drawing.Color.Transparent;
            this.cbbTime.BaseColor = System.Drawing.Color.White;
            this.cbbTime.BorderColor = System.Drawing.Color.Silver;
            this.cbbTime.BorderSize = 1;
            this.cbbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTime.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTime.ForeColor = System.Drawing.Color.Black;
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Location = new System.Drawing.Point(911, 70);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTime.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTime.Size = new System.Drawing.Size(178, 31);
            this.cbbTime.TabIndex = 5;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // CartesianChartReport
            // 
            this.CartesianChartReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianChartReport.Location = new System.Drawing.Point(0, 0);
            this.CartesianChartReport.Name = "CartesianChartReport";
            this.CartesianChartReport.Size = new System.Drawing.Size(1132, 578);
            this.CartesianChartReport.TabIndex = 6;
            this.CartesianChartReport.Text = "cartesianChart1";
            // 
            // pnSales
            // 
            this.pnSales.BackColor = System.Drawing.Color.Transparent;
            this.pnSales.BaseColor = System.Drawing.Color.White;
            this.pnSales.Controls.Add(this.panel1);
            this.pnSales.Controls.Add(this.panel4);
            this.pnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSales.Location = new System.Drawing.Point(0, 0);
            this.pnSales.Margin = new System.Windows.Forms.Padding(0);
            this.pnSales.Name = "pnSales";
            this.pnSales.Radius = 5;
            this.pnSales.ShadowColor = System.Drawing.Color.Black;
            this.pnSales.ShadowShift = 3;
            this.pnSales.Size = new System.Drawing.Size(1132, 694);
            this.pnSales.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CartesianChartReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 578);
            this.panel1.TabIndex = 7;
            // 
            // DrinksReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnSales);
            this.Name = "DrinksReport";
            this.Size = new System.Drawing.Size(1132, 694);
            this.Load += new System.EventHandler(this.DrinksReport_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnSales.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbbCount_or_Revenue;
        private Guna.UI.WinForms.GunaComboBox cbbPeriod;
        private Guna.UI.WinForms.GunaComboBox cbbTime;
        private LiveCharts.WinForms.CartesianChart CartesianChartReport;
        private Guna.UI.WinForms.GunaShadowPanel pnSales;
        private System.Windows.Forms.Panel panel1;
    }
}