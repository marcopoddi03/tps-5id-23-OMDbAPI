using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.BackgroundImage = Image.FromFile("background.jpg");
            this.BackgroundImageLayout= ImageLayout.Stretch;
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {            
            Movie movie = null;
            bool imdbId=false;
            bool correctYear = true;
            if (comboBoxTitle.SelectedIndex != 0)
                imdbId = true;
            if (!checkBoxAnno.Checked)
                txtYear.Text = "";
            if (checkBoxAnno.Checked && !int.TryParse(txtYear.Text, out int n))
                correctYear = false;
            if (!string.IsNullOrWhiteSpace(txtTitle.Text)&&correctYear)
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
            else
                MessageBox.Show("Inserisci dati validi!");
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
    }
}
