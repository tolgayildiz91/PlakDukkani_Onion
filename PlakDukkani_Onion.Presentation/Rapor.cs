using PlakDukkani_Onion.Application.Services.AlbumServices;
using PlakDukkani_Onion.Infastructure.RepositoryConcrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkani_Onion.Presentation
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        AlbumService _albumService = new AlbumService(new AlbumRepository(new Infastructure.DataAccess.PlakDukkaniDbContext()));
        private void btnDiscontinued_Click(object sender, EventArgs e)
        {
            dgvAlbumRapor.DataSource = _albumService.DiscontinuedSale();
        }

        private void btnContinued_Click(object sender, EventArgs e)
        {
            dgvAlbumRapor.DataSource = _albumService.OngoingSale();
        }

        private void btnLast10_Click(object sender, EventArgs e)
        {
            dgvAlbumRapor.DataSource = _albumService.LastTenAdded();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            dgvAlbumRapor.DataSource = _albumService.DiscountedAlbums();
        }
    }
}
