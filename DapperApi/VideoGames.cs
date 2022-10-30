namespace DapperApi
{
    public class VideoGames
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;

        public int size { get; set; }

        public string Developer { get; set; } = string.Empty;

        public int Released { get; set; }
    }
}
