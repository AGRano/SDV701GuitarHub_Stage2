using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuitarHub
{
    public partial class frmGuitar : Form
    {
        protected clsGuitar _Guitar;

        public delegate void LoadWorkFormDelegate(clsGuitar prGuitar);

        public static Dictionary<string, Delegate> _GuitarForm = new Dictionary<string, Delegate>
        {
            {"Acoustic", new LoadWorkFormDelegate(frmGuitarAcoustic.Run)},
            {"Electric", new LoadWorkFormDelegate(frmGuitarElectric.Run)},
        };

        public static void DispatchGuitarForm(clsGuitar prGuitar)
        {
            _GuitarForm[prGuitar.guitar_type].DynamicInvoke(prGuitar);
        }

        public frmGuitar()
        {
            InitializeComponent();
        }

        public void SetDetails(clsGuitar prGuitar)
        {
            _Guitar = prGuitar;
            updateForm();
            ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void updateForm()
        {
            txtSerialNo.Text = _Guitar.serial_no.ToString();
            //locks the field
            txtSerialNo.Enabled = false;
            if (_Guitar.serial_no == 0)
                txtSerialNo.Enabled = true;

            txtStyle.Text = _Guitar.style;
            //locks the field
            //txtStyle.Enabled = false;
            //if (_Guitar.style == "")
            //    txtStyle.Enabled = true;

            txtPrice.Text = _Guitar.price.ToString();
            txtQuantity.Text = _Guitar.quantity.ToString();
        }

        protected virtual void pushData()
        {
            _Guitar.serial_no = Convert.ToInt16(txtSerialNo.Text);
            _Guitar.style = txtStyle.Text;
            _Guitar.price = Convert.ToDecimal(txtPrice.Text);
            _Guitar.quantity = Convert.ToInt16(txtQuantity.Text);
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            pushData();
            if (txtSerialNo.Enabled)
                MessageBox.Show(await ServiceClient.InsertGuitarAsync(_Guitar));
            else
                MessageBox.Show(await ServiceClient.UpdateGuitarAsync(_Guitar));
            Close();
        }
    }
}
