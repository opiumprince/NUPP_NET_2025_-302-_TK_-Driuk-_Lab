namespace MusicLibrary.Common;

public class User : Entity
{
    public string Name { get; set; }
    public string Email { get; set; }

    // делегат
    public delegate void TrackAddedHandler(string trackName);

    // событие
    public event TrackAddedHandler? OnTrackAdded;

    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void AddToFavorites(Track track)
    {
        OnTrackAdded?.Invoke(track.Title);
    }
}