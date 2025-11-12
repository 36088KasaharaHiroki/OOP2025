namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            List<GreetingBase> list = [
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

    class GreetingMorning : GreetingBase {
        public override string GetMessage() => "おはよう";
    }

    class GreetingAfternon : GreetingBase {
        public override string GetMessage() => "こんにちは";
    }

    class GreetingEvening : GreetingBase {
        public override string GetMessage() => "こんばんは";
    }

}
