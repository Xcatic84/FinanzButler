using FinanzButler.Application.Services;
using FinanzButler.Infrastructure.Repositories;

namespace FinanzButler.WinForms
{
    public partial class HauptFenster : Form
    {
        private readonly BuchungService _buchungService;

        public HauptFenster()
        {
            InitializeComponent();

            var buchungRepository = new SqliteBuchungRepository();
            _buchungService = new BuchungService(buchungRepository);

            Load += HauptFenster_Load;
        }

        private void HauptFenster_Load(object? sender, EventArgs e)
        {
            BuchungenLaden();
        }

        private void BuchungenLaden()
        {
            var buchungen = _buchungService.AlleBuchungenAbrufen();
            dgvBuchungen.DataSource = buchungen;
        }
    }
}