﻿using System;
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
            txtAnno.Enabled = false;
            this.BackgroundImage = Image.FromFile("background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
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
                    listBox1.Items.Add(m.imdbID + ", " + m.Title + ", " + m.Year + ", " + m.Type);

                }
                labelRis.Text = movieS.totalResults;
            }
            else
            {
                MessageBox.Show("Nessun film trovato");
                labelRis.Text = "0";
                btnCont_Click(new object(), new EventArgs());
            }
                
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool correctYear = true;
            if (checkBoxAnno.Checked && !int.TryParse(txtAnno.Text, out int n))
                correctYear = false;
            if (!string.IsNullOrWhiteSpace(txtTitle.Text) && correctYear)
            {
                btnCont.Enabled = true;
                listBox1.Enabled = true;
                groupBoxP.Enabled = true;
                groupBoxR.Enabled = false;
                Ricerca();
            }
            else
               MessageBox.Show("Inserisci dati validi!");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(groupBoxP.Enabled)
                Ricerca();
        }

        private async void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string id = listBox1.SelectedItem.ToString().Split(',')[0];
            Movie movie  = await ClientREST.GetMovieAsync(id, true, "", "", checkBoxPlot.Checked);
            if (movie.Response == "True")
            {
                FormMovie fM = new FormMovie(movie);
                fM.Show();
            }
            else
                MessageBox.Show("Film non trovato");                
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            labelRis.Text = "0";
            groupBoxP.Enabled = false;
            groupBoxR.Enabled = true;
            listBox1.Enabled = false;
            btnCont.Enabled = false;
            listBox1.Items.Clear();
            numericUpDown1.Value = 1;
        }

        private void checkBoxAnno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnno.Checked)
                txtAnno.Enabled = true;
            else
                txtAnno.Enabled = false;
        }
    }
    
}
