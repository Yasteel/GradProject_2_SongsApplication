using Microsoft.AspNetCore.Mvc;
using Songs_Application.Interfaces;
using Songs_Application.Models;

namespace Songs_Application.WebApiController
{
    public class AlbumWebApiController : Controller
    {
        private readonly IDummyDataGenerator dummyDataGenerator;

        public AlbumWebApiController(IDummyDataGenerator dummyDataGenerator)
        {
            this.dummyDataGenerator = dummyDataGenerator;
        }

        [HttpGet]
        public List<AlbumModel> Get()
        {
            return this.dummyDataGenerator.GenerateAlbums();
        }
    }
}
