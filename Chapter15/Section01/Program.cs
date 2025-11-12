namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            List<IGreeting> list = [
                new GreetingMorning(),
                new GreetingAfternon(),
                new GreetingEvening(),
            ];

            foreach (var obj in list) {
                string msg = obj.GetMessage();
                Console.WriteLine(msg);
            }
        }
    }

    class GreetingMorning : IGreeting {
        public string GetMessage() => "おはよう";
    }

    class GreetingAfternon : IGreeting {
        public string GetMessage() => "こんにちは";
    }

    class GreetingEvening : IGreeting {
        public string GetMessage() => "こんばんは";
    }

}
