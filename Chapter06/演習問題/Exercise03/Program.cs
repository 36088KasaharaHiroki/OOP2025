
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

        }

        private static void Exercise1(string text) {
            var count = text.Count(c => c == ' ');
            //var spaces = text.Count(char.IsWhiteSpace);
            Console.WriteLine("空白数：" + count);
        }

        private static void Exercise2(string text) {
            var texts = text.Replace("big", "small");
            Console.WriteLine(texts);
        }

        private static void Exercise3(string text) {
            string[] array = text.Split(' ');
            var sb = new StringBuilder(array[0]);
            foreach (var word in array.Skip(1)) {
                sb.Append(" ");
                sb.Append(word);
            }
            Console.WriteLine(sb + ".");


        }

        private static void Exercise4(string text) {
            var count = text.Split(' ').Length;
            Console.WriteLine("単語数：" + count);
        }

        private static void Exercise5(string text) {
            var count = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var counts in count)
                Console.WriteLine(counts);

        }
    }
}
