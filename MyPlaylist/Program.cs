Track track = new Track();
Track secondTrack = new Track();

track.Name = "B.O.M.J.";
track.Artist = "DJ Ulitka";
track.DurationSeconds = 120;

secondTrack.Name = "Jepa";
secondTrack.Artist = "OPA";
secondTrack.DurationSeconds = 89;

Console.WriteLine($"New track {track.Name} was dropped by {track.Artist}, length of song is {track.DurationSeconds} seconds!");
Console.WriteLine($"Second track {secondTrack.Name} was dropped by {secondTrack.Artist}! length of this song is {secondTrack.DurationSeconds} seconds!");
