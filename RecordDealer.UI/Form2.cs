using RecordDealer.BLL;
using RecordDealer.DAL.Entity;
using RecordDealer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordDealer.UI
{
    public partial class Form2 : Form
    {
        RecordDealerEntities context { get; set; }
        public Form2()
        {
            InitializeComponent();
            context = new RecordDealerEntities();
            dgvAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbDiscounted.Items.Add("Yes");
            cmbDiscounted.Items.Add("No");
            cmbDiscounted.SelectedIndex = -1;
            LoadAllControls();
        }
        private void LoadAllControls()
        {
            dgvAlbums.DataSource = context.Albums.ToList();
        }
        private void ClearAllText()
        {
            txtAlbumName.Clear();
            txtArtistName.Clear();
            dtpReleaseDate.Value = DateTime.Today;
            nudPrice.Value = nudPrice.Minimum;
            nudDiscount.Value = nudDiscount.Minimum;
            cmbDiscounted.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDiscounted.SelectedItem != null)
                {
                    string discontinued = cmbDiscounted.SelectedItem.ToString();
                    Album album = new Album()
                    {
                        Name = txtAlbumName.Text.Trim(),
                        ArtistName = txtArtistName.Text.Trim(),
                        ReleaseDate = dtpReleaseDate.Value,
                        Price = (decimal)nudPrice.Value,
                        Discount = (double)(nudDiscount.Value / 100),
                        Discontinued = (discontinued == "Yes" ? true : false)
                    };
                    context.Albums.Add(album);
                    LoadAllControls();
                    ClearAllText();
                }
                else
                {
                    MessageBox.Show("Please select 'Discontinued' status..");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Adding process failured! Please enter correct value..");
            }
        }

        private void btnUpdateAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlbums.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvAlbums.SelectedRows)
                    {
                        context.Albums.Attach((Album)row.DataBoundItem);
                        context.Entry((Album)row.DataBoundItem).State = EntityState.Modified;
                    }
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("No selection for update(s)!");
                }
                dgvAlbums.DataSource = context.Albums.ToList();
                LoadAllControls();
                ClearAllText();
            }
            catch (Exception)
            {
                MessageBox.Show("Updating process failured! Please enter correct value..");
            }
        }

        private void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlbums.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvAlbums.SelectedRows)
                    {
                        context.Albums.Remove((Album)row.DataBoundItem);
                    }
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("No selection for delete(s)!");
                }
                dgvAlbums.DataSource = context.Albums.ToList();
                LoadAllControls();
                ClearAllText();
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting process failured! Please choose the full row..");
            }
        }
        private void ShowAllAlbums()
        {
            dgvAlbums.DataSource = context.Albums.ToList();

        }
        private void ShowDiscontinuedAlbums()
        {
            dgvAlbums.DataSource = context.Albums.Where(x => x.Discontinued == true).Select(x => new { AlbumName = x.Name, Artist = x.ArtistName }).ToList();

        }
        private void ShowContinuedAlbums()
        {
            dgvAlbums.DataSource = context.Albums.Where(x => x.Discontinued == false).Select(x => new { AlbumName = x.Name, Artist = x.ArtistName }).ToList();


        }
        private void ShowLastTenAlbums()
        {
            dgvAlbums.DataSource = context.Albums.OrderByDescending(x => x.ReleaseDate).Take(10).Select(x => new { AlbumName = x.Name, Artist = x.ArtistName }).ToList();

        }
        private void ShowDiscountAlbums()
        {
            dgvAlbums.DataSource = context.Albums.OrderByDescending(x => x.Discount).Select(x => new { AlbumName = x.Name, Artist = x.ArtistName }).ToList();

        }

        private void btnShowAllAlbums_Click(object sender, EventArgs e)
        {
            ShowAllAlbums();
            lblAlbums.Text = "All Albums";
        }

        private void btnDiscontinuedAlbums_Click(object sender, EventArgs e)
        {
            ShowDiscontinuedAlbums();
            lblAlbums.Text = "Discontinued Albums";
        }

        private void btnContiniuedAlbums_Click(object sender, EventArgs e)
        {
            ShowContinuedAlbums();
            lblAlbums.Text = "Continued Albums";
        }

        private void btnLastTenAlbums_Click(object sender, EventArgs e)
        {
            ShowLastTenAlbums();
            lblAlbums.Text = "Last Added 10 Albums";
        }

        private void btnOnSaleAlbums_Click(object sender, EventArgs e)
        {
            ShowDiscountAlbums();
            lblAlbums.Text = "Albums On Sale";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();
            Application.Exit();
        }
    }
}
