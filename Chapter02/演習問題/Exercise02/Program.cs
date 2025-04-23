namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("***  変換アプリ  ***");
            Console.WriteLine("１：インチからメートル");
            Console.WriteLine("２：メートルからインチ");
            if (args.Length >= 1 && args[0] == "1") {
                PrintInchToMeterList(1,10);
            } else if (args.Length >= 1 && args[0] == "2") {
                PrintMeterToInchList(1,10);
            }
            //インチからメートルへの対応表を出力
            static void PrintInchToMeterList(int start, int end) {
                Console.WriteLine("はじめ：" + start);
                Console.WriteLine("おわり：" + end);
                for (int inch = start; inch <= end; inch++) {
                    double meter = InchConverter.ToMeter(inch);
                    Console.WriteLine($"{inch}inch = {meter:0.0000}m");
                }
            }
            //メートルからインチへの対応表を出力
            static void PrintMeterToInchList(int start, int end) {
                Console.WriteLine("はじめ：" + start);
                Console.WriteLine("おわり：" + end);
                for (int meter = start; meter <= end; meter++) {
                    double inch = InchConverter.FromMeter(meter);
                    Console.WriteLine($"{meter}m = {inch:0.0000}inch");
                }
            }
        }
    }
}
