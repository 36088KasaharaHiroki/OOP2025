namespace Section03 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("10.15");

            if (File.Exists("./Example/Greeting.txt")){
                Console.WriteLine("既に存在してます");
            }

            Console.WriteLine("10.16");

            var fi = new FileInfo("./Example/Greeting.txt");
            if (fi.Exists) { 
                Console.WriteLine("既に存在してます");
            }

            Console.WriteLine("10.17");

            File.Delete("./Example/Greeting.txt");

            Console.WriteLine("10.18");

            var fi1 = new FileInfo("./Example/Greeting.txt");
            fi1.Delete();

            Console.WriteLine("10.19");

            File.Copy("./Example/src/Greeting.txt", "./Example/dest/Greeting.txt");

            File.Copy("./Example/src/Greeting.txt", "./Example/dest/Greeting.txt",overwrite:true);

            Console.WriteLine("10.20");

            var fi2 = new FileInfo("./Example/src/Greeting.txt");
            FileInfo dup = fi2.CopyTo("./Example/dest/Greeting.txt",overwrite:true);

            Console.WriteLine("10.21");

            File.Move("./Example/src/Greeting.txt", "./Example/dest/Greeting.txt");

            Console.WriteLine("10.22");

            var fi3 = new FileInfo("./Example/src/Greeting.txt");
            fi3.MoveTo("./Example/dest/Greeting.txt");
            
            Console.WriteLine("10.23");

            File.Move("./Example/oldfile.txt", "./Example/newfile.txt");

            Console.WriteLine("10.24");

            var fi4 = new FileInfo("./Example/Example.txt");
            fi4.MoveTo("./Example/newfile.txt");

            Console.WriteLine("10.25");

            var lastWriteTime = File.GetLastWriteTime("./Example/Greeting.txt");

            Console.WriteLine("10.26");

            File.SetLastWriteTime("./Example/Greeting.txt", DateTime.Now);

            Console.WriteLine("10.27");

            var fi5 = new FileInfo("./Example/Greeting.txt");
            DateTime lastWriteTime1 = fi5.LastWriteTime;
        }
    }
}
