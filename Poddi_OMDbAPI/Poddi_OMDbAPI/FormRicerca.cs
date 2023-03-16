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
    public partial class FormRicerca : Form
    {
        public FormRicerca()
        {
            InitializeComponent();
            groupBoxP.Enabled = false;
            numericUpDown1.Value = 1;
            domainUpDownType.SelectedIndex = 0;
            listBox1.Enabled = false;
            btnCont.Enabled = false;
        }
        private async void Ricerca()
        {
            MovieSearch movieS = null;
            if (!checkBoxAnno.Checked)
                txtAnno.Text = "";
            movieS = await ClientREST.GetMovieSearchAsync(txtTitle.Text, txtAnno.Text, domainUpDownType.SelectedItem.ToString(), numericUpDown1.Value.ToString());
            if (movieS.Response == "True")
            {
                foreach (Movie m in movieS.Search)
                {
                    listBox1.Items.Add( "- " + m.Title + " (" + m.imdbID + "), " + m.Year + ", " + m.Type);

                }
                groupBoxP.Visible = true;
            }
            else
                MessageBox.Show("Nessun film trovato");
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            btnCont.Enabled = true;
            listBox1.Enabled = true;
            groupBoxP.Enabled = true;
            groupBoxR.Enabled = false;
            Ricerca();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Ricerca();
        }

        private async void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Movie movie  = await ClientREST.GetMovieAsync(txtTitle.Text, true, "", "", false);
                if (movie.Response == "True")
                {
                    FormMovie fM = new FormMovie(movie);
                    fM.Show();
                    this.Close();
                 }
                else
                    MessageBox.Show("Film non trovato");
            }

        private void btnCont_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            groupBoxP.Enabled = false;
            groupBoxR.Enabled = true;
            listBox1.Enabled = false;
        }
    }
    
}
