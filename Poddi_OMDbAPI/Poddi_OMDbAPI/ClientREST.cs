using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Data;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poddi_OMDbAPI
{
    public class ClientREST
    {
        static HttpClient client;
        static string path_apikey;
        public static void SetClient()
        {
            client = new HttpClient();
            path_apikey = "?apikey=877c8336";
            client.BaseAddress = new Uri("https://www.omdbapi.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Movie> GetMovieAsync(string title, bool imdbId, string year, string type, bool fullPlot)
        {
            Movie product = null;
            string path= path_apikey;
            if (imdbId == true)
                path = path + "&i=";
            else
                path = path + "&t=";
            path = path + title.Replace(' ','+');
            MessageBox.Show(path);
            if (year != "")
                path = path + "&y=" + year;
            if(type!="")
                path=path+"&type="+type;
            if (fullPlot)
                path = path + "&plot=full";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await JsonSerializer.DeserializeAsync<Movie>(await response.Content.ReadAsStreamAsync());
            }
            return product;
        }

        public static async Task<MovieSearch> GetMovieSearchAsync(string title, string year, string type, string page)
        {
            MovieSearch mv = null;
            string path = path_apikey+"&s="+title+"&page="+page;
            if (year != "")
                path += "&y=" + year;
            if (type != "Tutto")
                path += "&type=" + type;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                mv = await JsonSerializer.DeserializeAsync<MovieSearch>(await response.Content.ReadAsStreamAsync());
            }
            return mv;
        }
    }
}
