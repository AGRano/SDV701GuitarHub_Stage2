using System;
using System.Windows.Forms;

namespace GuitarHub
{
    public sealed partial class frmProducts : Form
    {
        //Singleton
        private static readonly frmProducts _Instance = new frmProducts();

        public delegate void Notify(string prGuitarName);

        public event Notify GuitarNameChanged;

        public frmProducts()
        {
            InitializeComponent();
            cbType.Text = "Acoustic";
        }

        public static frmProducts Instance
        {
            get { return frmProducts._Instance; }
        }

        private void updateTitle(string prGuitarName)
        {
            if (!string.IsNullOrEmpty(prGuitarName))
                Text = "GuitarHub - " + prGuitarName;
        }

        //updates the lists
        public async void UpdateDisplay()
        {
            lstProducts.DataSource = null;
            lstProducts.DataSource = await ServiceClient.GetGuitarsAsync();
            lstOrders.DataSource = null;
            lstOrders.DataSource = await ServiceClient.GetOrdersAsync();

        }

        //updates products form on load
        private void frmProducts_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
        
        //closes form
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Deletes the selected product from lstProducts
        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int lcIndex = lstProducts.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteProductAsync(lstProducts.SelectedItem as clsGuitar));
                UpdateDisplay();

            }
        }

        //Deletes the selected order from lstOrders
        private async void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            int lcIndex = lstOrders.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteOrderAsync(lstOrders.SelectedItem as clsOrders));
                UpdateDisplay();

            }
        }


        //Opens the selected Order and shows its details of the order in frmOrders
        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            clsOrders lcOrder = (lstOrders.SelectedItem as clsOrders);
            frmOrders.Instance.SetDetails(lcOrder);
        }

        //Opens either a new Acoustic or Electric guitar form so it can be added into lstProducts
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string lcChoice = cbType.Text;
            clsGuitar lcGuitar = clsGuitar.NewGuitar(lcChoice);
            frmGuitar.DispatchGuitarForm(lcGuitar);
            if (lcGuitar.serial_no != 0) // not cancelled?
            {
                UpdateDisplay();
            }
        }

        //Opens an existing product so its details can be modified.
        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            clsGuitar lcGuitar = (clsGuitar)lstProducts.SelectedItem;
            frmGuitar.DispatchGuitarForm(lcGuitar);
            if (lcGuitar.serial_no != 0) // not cancelled?
            {
                UpdateDisplay();
            }
        }
    }
}
