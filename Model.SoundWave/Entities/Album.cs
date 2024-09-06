namespace Model.SoundWave.Entities;

public class Album
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string UrlPreviewImg { get; set; }
    public required List<Song> Songs { get; set; }
    public required List<Group> Groups { get; set; }
}