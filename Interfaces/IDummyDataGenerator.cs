namespace Songs_Application.Interfaces
{
    using Songs_Application.Models;

    public interface IDummyDataGenerator
    {
        List<AlbumModel> GenerateAlbums();

    }
}
