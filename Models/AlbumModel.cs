namespace Songs_Application.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Artist { get; set; }

        public int ReleaseYear { get; set; }

        public string? Genre { get; set; }

        public string? CoverArt { get; set; }

        public string? Sales { get; set; }
    }
}
