namespace MusicLibrary.Common;

public class Album : Entity
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public List<Track> Tracks { get; set; }

    public Album(string name, string artist)
    {
        Name = name;
        Artist = artist;
        Tracks = new List<Track>();
    }

    public void AddTrack(Track track)
    {
        Tracks.Add(track);
    }
}