using System.IO;
using System.Text;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var filePath = "./Greeting.txt";

            Console.WriteLine("10.1");
            
            if (File.Exists(filePath)) {
                using var reader = new StreamReader(filePath,Encoding.UTF8);
                while (!reader.EndOfStream) { 
                var line = reader.ReadLine();
                    Console.WriteLine(line);
                }

            Console.WriteLine("10.2");

            var lines = File.ReadAllLines(filePath, Encoding.UTF8);
                foreach (var line in lines) {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("10.3");

            var lines1 = File.ReadAllLines(filePath);
            foreach (var line in lines1) {
                Console.WriteLine(line);
            }

            Console.WriteLine("10.4");

            var lines2 = File.ReadLines(filePath)
                .Take(10)
                .ToArray();
            Console.WriteLine(lines2);

            Console.WriteLine("10.5");

            var count = File.ReadLines(filePath)
                .Count(s => s.Contains("C#"));
            Console.WriteLine(count);

            Console.WriteLine("10.6");

            var lines3 = File.ReadLines(filePath);
            Console.WriteLine(lines3);

            Console.WriteLine("10.7");

            var lines4 = File.ReadLines(filePath)
                .Where(s=>!String.IsNullOrWhiteSpace(s))
                .ToArray();
            Console.WriteLine(lines4);

            Console.WriteLine("10.8");

            var exists = File.ReadLines(filePath)
                .Distinct()
                .OrderBy(s => s.Length)
                .ToArray();
            Console.WriteLine(exists);

            Console.WriteLine("10.9");

            var lines5 = File.ReadLines(filePath)
                .Select((s, ix) => $"{ix + 1,4}:{s}");
            foreach (var line in lines5) {
                Console.WriteLine(line);
            }
            
        }
    }
}
