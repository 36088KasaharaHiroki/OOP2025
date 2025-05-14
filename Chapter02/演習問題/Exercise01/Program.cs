namespace Exercise01 {
    public class Program {
        static void Main(string[] args) {
            //
            var songs = new List<Song>();
            //"*****曲の登録*****"を出力
            Console.WriteLine("*****曲の登録*****");
            while (true) {
                //"曲名："を出力
                Console.Write("曲名：");
                string? title = Console.ReadLine();
                //endが入力されたら登録終了
                if (title.Equals("end", StringComparison.OrdinalIgnoreCase)) break;
                //"アーティスト名："を出力
                Console.Write("アーティスト名：");
                string? artistname = Console.ReadLine();
                //"演奏時間（秒）："を出力
                Console.Write("演奏時間（秒）：");
                int length = int.Parse(Console.ReadLine());
                //Song song = new Song(title, artistname, length);
                Song song = new Song() {
                    Title = title,
                    ArtistName = artistname,
                    Length = length
                };
                songs.Add(song);
                //改行
                Console.WriteLine();
            }
            printSong(songs);
        }
        //2.1.4
        private static void printSong(IEnumerable<Song> songs) {

#if false
            foreach (var song in songs) {
                var minutes = song.Length / 60;
                var seconds = song.Length % 60;
                Console.WriteLine($"{song.Title},{song.ArtistName}{minutes}{seconds:00}");
            }
#else
            //TimeSpan構造体を使った場合
            foreach (var song in songs) {
                var timespan = TimeSpan.FromSeconds(song.Length);
                Console.WriteLine($"{song.Title},{song.ArtistName}{timespan.Minutes}:{timespan.Seconds}");
            }

            //foreach (var song in songs) {
            //    Console.WriteLine(@"{0},{1} {2:m\ ss}",
            //        song.Title, song.ArtistName, TimeSpan.FromSeconds(songs.Length));
            //}          
#endif
            Console.WriteLine();
        }
    }
}