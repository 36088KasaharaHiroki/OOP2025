using System.Globalization;

namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Bron=1886";
            string[] array = line.Split(';');
            foreach (var pair in line.Split(';')) {
                var word = pair.Split('=');
                Console.WriteLine($"{ToJapnese(word[0])}:{word[1]}");
            }

            //for (int i = 0; i < array.Length; i++) {
            //    string[] word = array[i].Split('=');
            //    Console.WriteLine($"{ToJapnese(word[0])}:{word[1]}");
            //}
        }

        static string ToJapnese(string key) {
            return key switch {
                "Novelist" => "作家　",
                "BestWork" => "代表作",
                "Bron" => "誕生年",
                _ => "引数keyは、正しい値ではありません"
            };
        }
    }
}
