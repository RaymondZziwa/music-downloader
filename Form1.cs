using Microsoft.Xrm.Sdk.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Music_Downloader_for_windows.song;

namespace Music_Downloader_for_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            apicallsAsync();
        }

        public async Task apicallsAsync()
        {
            var songName = songinput.Text;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://deezerdevs-deezer.p.rapidapi.com/search?q={songName}"),
                Headers =
                {
                    { "x-rapidapi-host", "deezerdevs-deezer.p.rapidapi.com" },
                    { "x-rapidapi-key", "806d039207msh8fa3604093aeac7p1feff8jsn75196b57521b" },
                },
            };
            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var myJsonResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(myJsonResponse);

                  List<song> jsonSong = JsonConvert.DeserializeObject<List<song>>(myJsonResponse);
                    foreach (var item in jsonSong)
                    {
                        Console.WriteLine(item.Datum.Title);
                    }
                }
            }
            catch (Exception error)
            {

                Console.WriteLine(error);
            }
        }


    }
}
