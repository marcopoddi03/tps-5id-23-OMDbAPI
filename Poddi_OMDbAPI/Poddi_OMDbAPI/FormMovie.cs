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
    public partial class FormMovie : Form
    {
        private Movie movie;
        public FormMovie(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
        }

        private void FormMovie_Load(object sender, EventArgs e)
        {
            pictureBox1.LoadAsync(movie.Poster);
            labelTitle.Text = movie.Title;
            richTextBox1.Text = "imdbID: "+movie.imdbID+"\nTipo: "+movie.Type+"\nData di uscita: "+movie.Released+"\nDurata: "+movie.Runtime+"\nGenere: "+movie.Genre+"\nPaese: "+movie.Country+"\nLingua: "+movie.Language+"\nRated: "+movie.Rated;
            richTextBox2.Text = "Regista: " + movie.Director + "\nSceneggiatore: " + movie.Writer + "\nAttori: " + movie.Actors;
            richTextBox3.Text = "Awards: "+ movie.Awards + "\nMetascore: "+ movie.Metascore +"\nimdb Rating: " +movie.imdbRating;
            richTextBox4.Text = movie.Plot;
        }
    }
}
