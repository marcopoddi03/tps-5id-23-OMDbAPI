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
            richTextBox1.Text = "Titolo: "+movie.Title+"\nimdbID: "+movie.imdbID+"\nData di uscita: "+movie.Released;
            richTextBox2.Text = movie.Awards + movie.Metascore + movie.imdbRating;
        }
    }
}
