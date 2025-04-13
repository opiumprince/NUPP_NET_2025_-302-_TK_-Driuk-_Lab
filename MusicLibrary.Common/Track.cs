namespace MusicLibrary.Common;

public class Track : Entity
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public TimeSpan Duration { get; set; }

    // статическое поле
    public static int TrackCount;

    // конструктор
    public Track(string title, string genre, TimeSpan duration)
    {
        Title = title;
        Genre = genre;
        Duration = duration;
        TrackCount++;
    }

    // метод
    public string GetInfo() => $"{Title} ({Genre}) — {Duration}";
}