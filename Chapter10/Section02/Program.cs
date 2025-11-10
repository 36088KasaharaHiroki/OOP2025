namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            var filePath = "./Example/いろは歌.txt";
            Console.WriteLine("10.10");
            using (var writer = new StreamWriter(filePath)) {
                writer.WriteLine("色はにほへど　散りぬるを");
                writer.WriteLine("我が世たれぞ　常ならむ");
                writer.WriteLine("有為の奥山　今日越えて");
                writer.WriteLine("浅き夢見じ　酔ひもせず");
            }
            
            Console.WriteLine("10.11");
            
            var lines = new[] { "===", "京の夢", "大阪の夢", };
            using (var writer1 = new StreamWriter(filePath,append:true)) {
                foreach (var line in lines) {
                    writer1.WriteLine(line);
                }
            }

            Console.WriteLine("10.12");

            var lines1 = new[] { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", };
            File.WriteAllLines(filePath, lines1);
            
            Console.WriteLine("10.13");

            var names = new List<String> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris","Berlin","Canberra","Hong Kong",
            };
            File.WriteAllLines(filePath, names.Where(s => s.Length > 5));

            Console.WriteLine("10.14");

            using var stream = new FileStream(filePath,FileMode.Open
                ,FileAccess.ReadWrite,FileShare.None);
            using var reader = new StreamReader(stream);
            using var writer2 = new StreamWriter(stream);
            string texts = reader.ReadToEnd();
            stream.Position = 0;
            writer2.WriteLine("挿入する新しい行1");
            writer2.WriteLine("挿入する新しい行2");
            writer2.WriteLine(texts);
        }
    }
}
