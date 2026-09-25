Track track = new Track();
Track secondTrack = new Track();

track.Name = "B.O.M.J.";
track.Artist = "DJ Ulitka";
track.DurationSeconds = 120;

secondTrack.Name = "Jepa";
secondTrack.Artist = "OPA";
secondTrack.DurationSeconds = 89;

List<Track> playlist = new List<Track>();
playlist.Add(track);
playlist.Add(secondTrack);

foreach (Track song in playlist)
{
    Console.WriteLine($"Track: {song.Name}, Artist: {song.Artist}, Duration in seconds: {song.DurationSeconds} seconds.");
}
