namespace Songs_Application.Interfaces
{
    using Songs_Application.Models;

    public interface ISampleDataService
    {
        List<AlbumModel> GenerateAlbums();

    }
}
