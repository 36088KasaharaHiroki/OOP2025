namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var price = Library.Books
                .Where(b => b.CategoryId == 1)
                .Max(b => b.Price);
            Console.WriteLine(price);

            Console.WriteLine();

            var book = Library.Books
                .Where(b => b.PublishedYear >= 2021)
                .MinBy(b => b.Price);
            Console.WriteLine(book);

            Console.WriteLine();

            var average = Library.Books.Average(x => x.Price);
            var aboves = Library.Books.Where(b => b.Price > average);
            foreach (var book1 in aboves) {
                Console.WriteLine(book1);
            }

            Console.WriteLine();

            var Selected = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Select(group=>group.MaxBy(b=>b.Price))
                .OrderBy(b => b!.PublishedYear);
            foreach (var book2 in Selected) {
                Console.WriteLine($"{book2!.PublishedYear}年 {book2!.Title} ({book2.Price})");
                
            }

            Console.WriteLine();

            var books = Library.Books
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    book.Title,
                    Category = category.Name,
                    book.PublishedYear
                }).OrderBy(b => b.PublishedYear)
                .ThenBy(b => b.Category);
            foreach (var book3 in books) {
                Console.WriteLine($"{book3.Title}, {book3.Category}, {book3.PublishedYear}");
            }

            Console.WriteLine();

            var groups = Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new {Category = c.Name,Books = books
                });
            foreach (var group in groups) {
                Console.WriteLine(group.Category);
                foreach (var book4 in group.Books) {
                    Console.WriteLine($"{book4.Title},{book4.PublishedYear}年");
                }
            }
        }
    }
}
