using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Songs_Application.Interfaces;
using Songs_Application.Models;

namespace Songs_Application.WebApiController
{
    public class AlbumWebApiController : Controller
    {
        private readonly ISampleDataService dummyDataGenerator;

        public AlbumWebApiController(ISampleDataService dummyDataGenerator)
        {
            this.dummyDataGenerator = dummyDataGenerator;
        }

        [HttpGet]
        public List<AlbumModel> Get()
        {
            return this.dummyDataGenerator.GenerateAlbums();
        }

        public List<Song> GetSongs(int id, DataSourceLoadOptions options)
        {
            var data = this.Get().FirstOrDefault(_ => _.Id == id);

            return  data!.Songs ?? new ();
        }
    }
}
