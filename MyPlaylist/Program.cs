Track track = new Track();
Track secondTrack = new Track();
Track userTrack = new Track();

track.Name = "B.O.M.J.";
track.Artist = "DJ Ulitka";
track.DurationSeconds = 120;

secondTrack.Name = "Jepa";
secondTrack.Artist = "OPA";
secondTrack.DurationSeconds = 89;

userTrack.Name = "";
userTrack.Artist = "";
userTrack.DurationSeconds = 0;

List<Track> readyPlaylist = new List<Track>();
readyPlaylist.Add(track);
readyPlaylist.Add(secondTrack);

List<Track> userPlaylist = new List<Track>();
userPlaylist.Add(userTrack);

foreach (Track song in readyPlaylist)
{
    PrintTrack(song);
}

Console.WriteLine("Введите название вашей песни: ");
userTrack.Name = Console.ReadLine() ?? "";
if (userTrack.Name == "")
{
    Console.WriteLine("Название не введено");
}
else
{
    Console.WriteLine($"Название {userTrack.Name}");
}
Console.WriteLine("Введите ваш ник");
userTrack.Artist = Console.ReadLine() ?? "";
if (userTrack.Artist == "")
{
    Console.WriteLine("Артист не введён");
}
else
{
    Console.WriteLine($"Артист {userTrack.Artist}");
}
Console.WriteLine($"Сколько ваш трек будет длиться?");
if (int.TryParse(Console.ReadLine(), out int duration))
{
    userTrack.DurationSeconds = duration;
}
else
{
    Console.WriteLine("Длительность должна быть числом");
}

foreach (Track userSong in userPlaylist)
{
    PrintTrack(userSong);
}

void PrintTrack(Track trackToPrint)
{
    Console.WriteLine($"Track: {trackToPrint.Name}, Artist: {trackToPrint.Artist}, Duration in seconds: {trackToPrint.DurationSeconds} seconds.");
}
