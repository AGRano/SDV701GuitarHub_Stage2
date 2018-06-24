

namespace GuitarHub
{
    public sealed partial class frmGuitarElectric : GuitarHub.frmGuitar
    {

        private static readonly frmGuitarElectric Instance = new frmGuitarElectric();

        private frmGuitarElectric()
        {
            InitializeComponent();
        }

        public static void Run(clsGuitar prGuitar)
        {
            Instance.SetDetails(prGuitar);
        }

        protected override void updateForm()
        {
            base.updateForm();
            txtTremolo.Text = _Guitar.tremolo;
            txtPickup.Text = _Guitar.pickup;
        }

        protected override void pushData()
        {
            base.pushData();
            _Guitar.tremolo = txtTremolo.Text;
            _Guitar.pickup = txtPickup.Text;
            _Guitar.electric = "";
            _Guitar.hollow = "";

        }

    }
}
