using static System.Formats.Asn1.AsnWriter;

namespace Test01 {
    public class ScoreCounter {
        private readonly IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(String filePath) {
            var scores = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                //Saleオブジェクトを生成
                var score = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(score);
            }
            return scores;
        }

        //メソッドの概要： 
        public IDictionary<String, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (Student score in _score) {
                if (dict.ContainsKey(score.Subject))
                    dict[score.Name] += score.Score;
                else
                    dict[score.Name] = score.Score;
            }
            return dict;
        }

    }
}
