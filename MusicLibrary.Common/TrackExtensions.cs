namespace MusicLibrary.Common;

public static class TrackExtensions
{
    // метод расширения
    public static bool IsLongTrack(this Track track)
    {
        return track.Duration.TotalMinutes > 5;
    }
}