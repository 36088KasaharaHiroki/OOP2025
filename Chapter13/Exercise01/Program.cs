
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var book = Library.Books
                .MaxBy(b => b.Price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var count = Library.Books
                .GroupBy(x => x.PublishedYear)
                .OrderBy(b => b.Key)
                .Select(b => new { PublishedYear = b.Key, Count = b.Count(), });
            foreach (var item in count) {
                Console.WriteLine($"{item.PublishedYear}:{item.Count}");
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenBy(b => b.Price);
            foreach (var item in books) {
                Console.WriteLine($"{item.PublishedYear}年 {item.Price}円 {item.Title}");
            }
        }

        private static void Exercise1_5() {
            var category = Library.Books
                .Where(b => b.PublishedYear == 2022)
                .Join(Library.Categories,
                b => b.CategoryId,
                c => c.Id,
                (b, c) => c.Name)
                .Distinct();
            foreach (var name in category) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Books
                 .Join(Library.Categories,
                 b => b.CategoryId,
                 c => c.Id,
                 (b, c) => new {b.Title, CategoryName = c.Name })
                 .GroupBy(x => x.CategoryName)
                 .OrderBy(x => x.Key);
            foreach (var group in groups) {
                Console.WriteLine($"#{group.Key}");
                foreach (var book in group) {
                    Console.WriteLine($"  {book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var groups = Library.Categories
                .Where(c=>c.Name.Equals("Development"))
                 .Join(Library.Books,
                 c => c.Id,
                 b => b.CategoryId,
                 (b, c) => new { c.Title, c.PublishedYear })
                 .GroupBy(x => x.PublishedYear)
                 .OrderBy(x => x.Key);
            foreach (var group in groups) {
                Console.WriteLine($"#{group.Key}");
                foreach (var book in group) {
                    Console.WriteLine($"  {book.Title}");
                }
            }
        }

        private static void Exercise1_8() {
            var groups = Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                d => d.CategoryId,
                (c, books) => new { Category = c.Name, Count = books.Count() >= 4 });
            foreach (var item in groups) {
                if (item.Count == true) {
                    Console.WriteLine($"{item.Category}");
                }                
            }
        }
    }
}
