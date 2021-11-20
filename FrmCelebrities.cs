using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CelebAppClient
{
    public partial class FrmCelebrities : Form
    {
        public FrmCelebrities()
        {
            InitializeComponent();
        }

        private void FrmCelebrities_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        /// <summary>
        /// fetch celebrities from api
        /// </summary>
        /// <param name="restoreAll"></param>
        /// <returns></returns>
        private Dictionary<int, CelebrityItem> LoadFromApi(bool restoreAll = false)
        {

            try
            {
                return CelebApi.LoadFromApi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error while trying to fetch from api: {ex.Message}", "Error", MessageBoxButtons.OK);
                return new Dictionary<int, CelebrityItem>();
            }
        }

        /// <summary>
        /// loads celebs (from api) and puts them inside dgv
        /// </summary>
        /// <param name="restoreAll">if restore all it means we want all the original db as it was initiated, 
        /// else means take our db (after deletion and so)</param>
        private void LoadDgv(bool restoreAll = false)
        {
            Dictionary<int, CelebrityItem> celebs = LoadFromApi(restoreAll);
            dgvCeleberities.Rows.Clear();
            foreach (CelebrityItem celeb in celebs.Values)
            {
                int index = dgvCeleberities.Rows.Add();
                var row = dgvCeleberities.Rows[index];
                row.Cells[dgvCelebretiesColName.Name].Value = celeb.Name;
                row.Cells[dgvCelebretiesColBirthDate.Name].Value = celeb.BirthDate.ToShortDateString();
                row.Cells[dgvCelebretiesColGender.Name].Value = Enum.GetName(typeof(Gender), celeb.Gender);
                row.Cells[dgvCelebretiesColRole.Name].Value = celeb.Role;
                row.Cells[dgvCelebretiesColImage.Name].Value = celeb.ImageSource != null ? GetImage(celeb.ImageSource) : null;
                row.Cells[dgvCelebretiesColCelebrityItem.Name].Value = celeb;
            }
        }

        /// <summary>
        /// return bitmap from source
        /// </summary>
        /// <param name="imageSource"></param>
        /// <returns></returns>
        private Bitmap GetImage(string imageSource)
        {
            var request = System.Net.WebRequest.Create(imageSource);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();
            Bitmap retval = new Bitmap(responseStream);
            return new Bitmap(retval, new Size(retval.Width / 4, retval.Height / 4));
        }
        
        /// <summary>
        /// deletes celebrity only if there is chosen 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteOne_ClickAsync(object sender, EventArgs e)
        {
            if (dgvCeleberities.SelectedRows.Count == 1)
            {
                int index = dgvCeleberities.SelectedRows[0].Index;
                try
                {
                    if (CelebApi.DeleteCeleb(GetCelebrityItem(index)) > 0)
                    {
                        dgvCeleberities.Rows.RemoveAt(index);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There was an error while trying to delete using api: {ex.Message}", "Error", MessageBoxButtons.OK);
                }

            }
        }

        /// <summary>
        /// gets the item out of the cell in dgv
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private CelebrityItem GetCelebrityItem(int index)
        {
            return dgvCeleberities.Rows[index].Cells[dgvCelebretiesColCelebrityItem.Name].Value as CelebrityItem;
        }

        /// <summary>
        /// enables the button for delete since one row is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCeleberities_SelectionChanged(object sender, EventArgs e)
        {
            btnDeleteOne.Enabled = (dgvCeleberities.SelectedRows.Count > 0);
        }

        /// <summary>
        /// restart database from web
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                CelebApi.RestartDatabaseFromWebApi();
                LoadDgv(restoreAll: true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error while trying to fetch from api: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// restore all original data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadFromLocal_Click(object sender, EventArgs e)
        {
            LoadDgv(restoreAll: true);
        }
    }
}
