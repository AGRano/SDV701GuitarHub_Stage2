

namespace GuitarHub
{
    public sealed partial class frmGuitarAcoustic : GuitarHub.frmGuitar
    {

        private static readonly frmGuitarAcoustic Instance = new frmGuitarAcoustic();

        private frmGuitarAcoustic()
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
            txtElectric.Text = _Guitar.electric;
            txtHollow.Text = _Guitar.hollow;
        }

        protected override void pushData()
        {
            base.pushData();
            _Guitar.electric = txtElectric.Text;
            _Guitar.hollow = txtHollow.Text;
            _Guitar.tremolo = "";
            _Guitar.pickup = "";

        }

    }
}
