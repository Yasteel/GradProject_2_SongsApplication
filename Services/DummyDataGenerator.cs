using System.Diagnostics.Metrics;

namespace Songs_Application.Services
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Songs_Application.Interfaces;
    using Songs_Application.Models;
    

    public class DummyDataGenerator : IDummyDataGenerator
    {
        public List<AlbumModel>? Albums { get; set; }

        public DummyDataGenerator()
        {
            this.Albums = new List<AlbumModel>();
        }

        public List<AlbumModel> GenerateAlbums()
        {
            StreamReader reader = new StreamReader("./Data/DummyData.json");
            var json = reader.ReadToEnd();

            this.Albums = JsonConvert.DeserializeObject<List<AlbumModel>>(json);

            return this.Albums;
        }
    }
}			
