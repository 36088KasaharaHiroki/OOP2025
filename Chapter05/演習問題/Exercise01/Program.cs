using System.Security.Cryptography.X509Certificates;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var yearmonth = new YearMonth(2000,12);
            Console.WriteLine(yearmonth);
        }
    }
}
