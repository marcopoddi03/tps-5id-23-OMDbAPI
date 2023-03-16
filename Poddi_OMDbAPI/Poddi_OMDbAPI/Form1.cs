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
            comboBoxTitle.SelectedIndex = 0;
            domainUpDownType.SelectedIndex = 0;
            txtYear.Enabled = false;
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {            
            Movie movie = null;
            bool imdbId=false;
            if (comboBoxTitle.SelectedIndex != 0)
                imdbId = true;
            if (!checkBoxAnno.Checked)
                txtYear.Text = "";
            if (txtTitle.Text != null)
            {
                movie = await ClientREST.GetMovieAsync(txtTitle.Text, imdbId, txtYear.Text, domainUpDownType.SelectedItem.ToString(), checkBoxPlot.Checked);
                if (movie.Response == "True")
                {
                    FormMovie fM = new FormMovie(movie);
                    fM.Show();
                }
                else
                    MessageBox.Show("Film non trovato");
            }
        }

        private void checkBoxAnno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnno.Checked)
                txtYear.Enabled = true;
            else
                txtYear.Enabled = false;
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            FormRicerca fR = new FormRicerca();
            fR.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
