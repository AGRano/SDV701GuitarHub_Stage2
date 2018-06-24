using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuitarHub
{
    public sealed partial class frmOrders : Form
    {
        private static readonly frmOrders _Instance = new frmOrders();
        private clsOrders _Order;

        private static Dictionary<string, frmProducts> _ProductFormList =
            new Dictionary<string, frmProducts>();

        private frmOrders()
        {
            InitializeComponent();
        }

        public static frmOrders Instance
        {
            get { return frmOrders._Instance; }
        }

        private void updateTitle(string prProductName)
        {
            if (!string.IsNullOrEmpty(prProductName))
                Text = "Guitar Details - " + prProductName;
        }

        public async void UpdateDisplay()
        {
            lstOrderItems.DataSource = await ServiceClient.GetOrderAsync(_Order.order_id);
        }

        private void populateFields()
        {
            txtOrderID.Text = _Order.order_id.ToString();
            txtCustomerName.Text = _Order.customer_name;
            txtCustomerAddress.Text = _Order.customer_address;
            txtCustomerPhone.Text = _Order.customer_phone;
            txtCustomerEmail.Text = _Order.customer_email;
            lblTotalPriceNumber.Text = _Order.total_price.ToString();
            lblOrderDate.Text = _Order.order_date.ToString();
        }

        public void SetDetails(clsOrders prOrder)
        {
            _Order = prOrder;
            populateFields();
            UpdateDisplay();
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
