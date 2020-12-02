using System;

namespace Songs
{
    using System.Linq;
    using System.Threading.Channels;

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            
            var songs = new Song[size];
            for (int index = 0; index < size; index++)
            {
                string[] songParts = Console.ReadLine()?.Split("_").ToArray();
                songs[index] = new Song
                {
                    TypeList = songParts[0],
                    Name = songParts[1],
                    Time = songParts[2]
                };
            }

            var type = Console.ReadLine();
            if (type == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
                //Console.WriteLine(string.Join(Environment.NewLine, songs.Select(s => s.Name)));
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }

                //Console.WriteLine(string.Join(Environment.NewLine, songs.Where(s => s.TypeList == type).Select(s => s.Name)));
            }
        }
    }
}
