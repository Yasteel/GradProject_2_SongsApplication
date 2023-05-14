namespace Songs_Application.Services
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Songs_Application.Interfaces;
    using Songs_Application.Models;
    

    public class SampleDataServicw : ISampleDataService
    {
        public List<AlbumModel>? Albums { get; set; }

        public SampleDataServicw()
        {
            this.Albums = new List<AlbumModel>();
        }

        public List<AlbumModel> GenerateAlbums()
        {
            StreamReader reader = new StreamReader("./Data/SampleData.json");
            var json = reader.ReadToEnd();

            this.Albums = JsonConvert.DeserializeObject<List<AlbumModel>>(json);

            return this.Albums;
        }
    }
}
