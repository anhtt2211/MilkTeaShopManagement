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
using System.Runtime.InteropServices;

namespace MilkTeaHouseProject
{
    public partial class fInvoice : Form
    {
        private string username;
        private int billID;
        private long totalPrice;
        private int staffID;

        public string Username { get => username; set => username = value; }
        public int BillID { get => billID; set => billID = value; }
        public long TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int StaffID { get => staffID; set => staffID = value; }

        int TableID;

        public fInvoice(string username, int billID, long totalPrice, int staffID, int tableID)
        {
            InitializeComponent();

            DropShadow shadow = new DropShadow();
            shadow.ApplyShadows(this);

            this.Username = username;
            this.BillID = billID;
            this.TotalPrice = totalPrice;
            this.StaffID = staffID;
            this.TableID = tableID;

            this.txtTotalPrice.Text = string.Format("{0:n0}", this.TotalPrice).ToString();

            LoadInvoice();
            LoadInfo();
        }

        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public long ConvertToNumber(string str)
        {
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return long.Parse(tmp);
        }

        public void SeparateThousands(Guna.UI.WinForms.GunaLineTextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                ulong valueBefore = ulong.Parse(ConvertToNumber(txt.Text).ToString(), System.Globalization.NumberStyles.AllowThousands);
                txt.Text = String.Format(culture, "{0:N0}", valueBefore);
                txt.Select(txt.Text.Length, 0);
            }
        }

        void LoadInvoice()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListInvoicebyBillID @billID ", new object[] { this.BillID });

            this.DataGridViewInvoices.DataSource = data;
        }

        private void LoadInfo()
        {
            string staffName = StaffDAL.Instance.GetNamebyUsername(this.Username);
            DateTime checkout = DateTime.Now;
            string tableName = TableFoodDAL.Instance.GetNamebyIdTable(this.TableID);
            string groupName = TableFoodDAL.Instance.GetNameGroupbyIdTable(this.TableID);
            string numberPhone = StaffDAL.Instance.GetPhoneofAdmin();

            lbHotline.Text = string.Format("HOTLINE: {0}", numberPhone);
            lbCheckout.Text = string.Format("Thời gian thanh toán: {0}", checkout.ToString());
            lbInfoTable.Text = string.Format("{0} {1}", tableName, groupName);
            lbStaffName.Text = string.Format("Tên nhân viên: {0}", staffName);
            lbIdbill.Text = string.Format("Mã hóa đơn: #{0}", this.BillID);
        }
        #endregion

        #region Event
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                TableFoodDAL.Instance.SetStatusEmpty(TableID);
                BillDAL.Instance.PayBill(BillID, TableID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.btnPrintInvoice_Click(sender, e);
                this.Close();
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            string staffName = StaffDAL.Instance.GetNamebyUsername(this.Username);
            DateTime checkout = DateTime.Now;
            string tableName = TableFoodDAL.Instance.GetNamebyIdTable(this.TableID);
            string groupName = TableFoodDAL.Instance.GetNameGroupbyIdTable(this.TableID);
            string numberPhone = StaffDAL.Instance.GetPhoneofAdmin();

            this.easyHTMLReports.Clear();
            this.easyHTMLReports.AddString("<h1>MILKTEA HOUSE</h1>");
            this.easyHTMLReports.AddString("<p>Địa chỉ: blabla</p>");
            this.easyHTMLReports.AddString("<p>Số điện thoại: #{0}</p>", numberPhone);
            this.easyHTMLReports.AddString("<h3>Hóa đơn thanh toán</h3>");
            this.easyHTMLReports.AddString(string.Format("<p>Số hóa đơn: #{0}</p>", this.BillID));
            this.easyHTMLReports.AddString("<br>");
            this.easyHTMLReports.AddString(string.Format("<p>Nhân viên bán hàng: {0}</p>", staffName));
            this.easyHTMLReports.AddString(string.Format("<p>Ngày: {0}</p>", checkout));
            this.easyHTMLReports.AddString(string.Format("<p>{0}</p>", tableName + " " + groupName));
            this.easyHTMLReports.AddString("<br>");
            this.easyHTMLReports.AddLineBreak();
            this.easyHTMLReports.AddDatagridView(this.DataGridViewInvoices);
            this.easyHTMLReports.AddString("<br>");
            this.easyHTMLReports.AddString(string.Format("<h4>Tổng cộng: {0} VNĐ</h4>", string.Format("{0:n0}", this.TotalPrice)));
            this.easyHTMLReports.AddString("<br>");
            this.easyHTMLReports.AddString("<p>Chúc quý khách ngon miệng</p>");
            this.easyHTMLReports.AddString("<p>Cảm ơn và hẹn gặp lại</p>");

            this.easyHTMLReports.ShowPrintPreviewDialog();
            this.Close();
        }

        private void txtCustomerPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SeparateThousands(this.txtCustomerPay);

                long customerPay = ConvertToNumber(this.txtCustomerPay.Text);
                long change = customerPay - this.TotalPrice;

                //this.txtChange.Text = change.ToString();
                this.txtChange.Text = string.Format("{0:n0}", change).ToString();
            }
            catch
            {
                this.txtCustomerPay.Text = "";
            }
            if (string.IsNullOrEmpty(this.txtCustomerPay.Text))
            {
                this.txtChange.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCustomerPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnPay_Click(sender, e);
            }
        }
        #endregion

    }
}
