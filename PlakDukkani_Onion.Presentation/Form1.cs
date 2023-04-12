using PlakDukkani_Onion.Application.Services.AlbumServices;
using PlakDukkani_Onion.Domain.Entities;
using PlakDukkani_Onion.Infastructure.RepositoryConcrete;

namespace PlakDukkani_Onion.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        Album seciliAlbum = new Album();
        AlbumService _albumService = new AlbumService(new AlbumRepository(new Infastructure.DataAccess.PlakDukkaniDbContext()));
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Album yeniAlbum = new Album();
            if (txtName.Text != " ")
            {
                yeniAlbum.AlbumAdi = txtName.Text;

            }

            else
            {
                throw new Exception("Ad boþ býrakýlamaz");
            }

            if (txtSanatci.Text != " ")
            {
                yeniAlbum.Sanatci = txtSanatci.Text;

            }
            else
            {
                throw new Exception("Sanatçý boþ býrakýlamaz");
            }

            yeniAlbum.CikisTarihi = dateTimePicker1.Value;
            yeniAlbum.CreatedDate = dateTimePicker1.Value;
            yeniAlbum.ModifiedDate = dateTimePicker1.Value;

            if (txtPrice.Text != " ")
            {
                yeniAlbum.Fiyat = Convert.ToDecimal(txtPrice.Text);
            }
            else
            {
                throw new Exception("Fiyat boþ býrakýlamaz");
            }

            if (txtIndirim.Text != " ")
            {
                yeniAlbum.IndirimOrani = Convert.ToDecimal(txtIndirim.Text);
            }
            else
            {
                throw new Exception("Ýndirim oraný boþ býrakýlamaz");
            }

            if (rbBitti.Checked)
            {
                yeniAlbum.SatisDurumu = false;
            }

            else
            {
                yeniAlbum.SatisDurumu = true;
            }

            _albumService.Create(yeniAlbum);
            ListeyiYenile();
            Temizle();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int _seciliID = (int)(dgvAlbum.SelectedRows[0].Cells[0].Value);
            _albumService.Remove(_seciliID);
            ListeyiYenile();

        }

        private void dgvAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _seciliID = (int)(dgvAlbum.SelectedRows[0].Cells[0].Value);
            seciliAlbum = _albumService.GetById(_seciliID);
            txtName.Text = seciliAlbum.AlbumAdi;
            txtSanatci.Text = seciliAlbum.Sanatci;
            txtIndirim.Text = Convert.ToString(seciliAlbum.IndirimOrani);
            txtPrice.Text = Convert.ToString(seciliAlbum.Fiyat);
            if (seciliAlbum.SatisDurumu == true)
            {
                rbDevam.Checked = true;
            }
            else
            {
                rbBitti.Checked = true;
            }
        }



        public void ListeyiYenile()
        {
            dgvAlbum.DataSource = _albumService.GetDefaults(x => x.Status == Domain.Enums.Status.Active);

        }

        public void Temizle()
        {
            txtName.Text = "";
            txtSanatci.Text = "";
            txtIndirim.Text = "";
            txtPrice.Text = "";
            rbDevam.Checked = false;
            rbBitti.Checked = false;
            dateTimePicker1.Value = DateTime.Now;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int _seciliID = (int)(dgvAlbum.SelectedRows[0].Cells[0].Value);
            var guncellenecek = _albumService.GetById(_seciliID);
            guncellenecek.AlbumAdi = txtName.Text;
            guncellenecek.CikisTarihi = dateTimePicker1.Value;
            guncellenecek.Sanatci = txtSanatci.Text;
            guncellenecek.CikisTarihi = dateTimePicker1.Value;
            guncellenecek.CreatedDate = dateTimePicker1.Value;
            guncellenecek.ModifiedDate = dateTimePicker1.Value;
            guncellenecek.Fiyat = Convert.ToDecimal(txtPrice.Text);
            guncellenecek.IndirimOrani = Convert.ToDecimal(txtIndirim.Text);
            if (rbBitti.Checked)
            {
                guncellenecek.SatisDurumu = false;
            }

            else
            {
                guncellenecek.SatisDurumu = true;
            }
            _albumService.Edit(guncellenecek);
            ListeyiYenile();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.ShowDialog();
        }
    }
}