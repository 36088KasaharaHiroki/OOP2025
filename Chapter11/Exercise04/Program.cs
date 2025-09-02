using System.Text.RegularExpressions;

namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");
            var newline = lines.Select(s=>Regex.Replace(s,"v4.0","v5.0"));
            File.WriteAllLines("sampleChange.txt",newline);
            var text = File.ReadAllText("sampleChange.txt");
            Console.WriteLine(text);
        }
    }
}
