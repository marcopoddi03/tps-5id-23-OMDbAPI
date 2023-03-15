using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Poddi_OMDbAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientREST.SetClient();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {            
            Movie movie = null;
            bool imdbId=false;
            if (comboBoxTitle.SelectedIndex != 0)
                imdbId = true;

            if (txtTitle.Text != null)
            {
                movie = await ClientREST.GetMovieAsync(txtTitle.Text, imdbId, txtYear.Text, "movie", checkBoxPlot.Checked);
                FormMovie fM = new FormMovie(movie);
                fM.Show();
            }
        }
    }
}
