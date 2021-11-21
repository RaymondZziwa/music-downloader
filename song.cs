using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Downloader_for_windows
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    class song
    {
         
        public class Artist
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Link { get; set; }
            public string Picture { get; set; }
            public string PictureSmall { get; set; }
            public string PictureMedium { get; set; }
            public string PictureBig { get; set; }
            public string PictureXl { get; set; }
            public string Tracklist { get; set; }
            public string Type { get; set; }
        }

        public class Album
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Cover { get; set; }
            public string CoverSmall { get; set; }
            public string CoverMedium { get; set; }
            public string CoverBig { get; set; }
            public string CoverXl { get; set; }
            public string Md5Image { get; set; }
            public string Tracklist { get; set; }
            public string Type { get; set; }
        }

        public class Datum
        {
            public int Id { get; set; }
            public bool Readable { get; set; }
            public  string Title { get; set; }
            public string TitleShort { get; set; }
            public string TitleVersion { get; set; }
            public string Link { get; set; }
            public int Duration { get; set; }
            public int Rank { get; set; }
            public bool ExplicitLyrics { get; set; }
            public int ExplicitContentLyrics { get; set; }
            public int ExplicitContentCover { get; set; }
            public string Preview { get; set; }
            public string Md5Image { get; set; }
            public Artist Artist { get; set; }
            public Album Album { get; set; }
            public string Type { get; set; }
        }

        public class Root
        {
            public List<Datum> Data { get; } = new List<Datum>();
        }


    }
}
