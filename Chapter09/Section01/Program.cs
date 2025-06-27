using System.Globalization;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var today = new DateTime(2025, 7, 12);//日付
            var now = DateTime.Now;//日付と時刻
            Console.WriteLine($"Today{today.Month}");
            Console.WriteLine($"Now{now}");

            //①自分の生年月日は何曜日かをプログラムを書いて調べる
            //西暦入力
            Console.Write("西暦：");
            var year = int.Parse(Console.ReadLine());
            //月入力
            Console.Write("月：");
            var month = int.Parse(Console.ReadLine());
            //日入力
            Console.Write("日：");
            var day = int.Parse(Console.ReadLine());
            var todays = new DateTime(year, month, day);
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = todays.ToString("ggyy年M月d日", culture);
            var shortdayOfWeek = culture.DateTimeFormat.GetShortestDayName(todays.DayOfWeek);
            Console.WriteLine(str + shortdayOfWeek + "曜日");
            //Console.WriteLine(str + todays.ToString("ddd曜日", culture));

            //③生まれてから○○○○日
            TimeSpan diff = today - todays;
            Console.WriteLine($"生まれれてから{diff.Days}日");

            //④あなたは○○歳です！
            int age = GetAge(todays, DateTime.Today);
            Console.WriteLine(age);

            //⑤１月１日から何日目か？
            var todaye = DateTime.Today;
            int DayOfYear = todaye.DayOfYear;
            Console.WriteLine(DayOfYear);

            //②うるう年かの判定プログラムを作成する
            var isLeapYear = DateTime.IsLeapYear(year);
            if (isLeapYear) {
                Console.WriteLine($"{year}年はうるう年です");
            } else {
                Console.WriteLine($"{year}年は平年です");
            }

            static int GetAge(DateTime todays, DateTime targetDay) {
                var age = targetDay.Year - todays.Year;
                if (targetDay < todays.AddYears(age)) {
                    age--;
                }
                return age;
            }
        }
    }
}
