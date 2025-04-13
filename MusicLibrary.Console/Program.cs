using MusicLibrary.Common;

var trackService = new CrudService<Track>();
var albumService = new CrudService<Album>();
var user = new User("John Doe", "john@example.com");

user.OnTrackAdded += trackName => Console.WriteLine($"Track added to favorites: {trackName}");

var track1 = new Track("Lost Stars", "Pop", TimeSpan.FromMinutes(4.2));
var track2 = new Track("Bohemian Rhapsody", "Rock", TimeSpan.FromMinutes(6));

var album = new Album("Greatest Hits", "Queen");
album.AddTrack(track1);
album.AddTrack(track2);

trackService.Create(track1);
trackService.Create(track2);
albumService.Create(album);

user.AddToFavorites(track2);

Console.WriteLine("\nAll Tracks:");
foreach (var t in trackService.ReadAll())
{
    Console.WriteLine(t.GetInfo() + (t.IsLongTrack() ? " [Long]" : ""));
}

Console.WriteLine("\nSaving data to file...");
trackService.Save("tracks.json");
albumService.Save("albums.json");