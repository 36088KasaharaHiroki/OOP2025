using static System.Formats.Asn1.AsnWriter;

namespace Test01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);
        }

        //メソッドの概要：学生データの読み込み、オブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            var sales = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                var score = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                sales.Add(score);
            }
            return sales;
        }

        //メソッドの概要：生徒別の点数を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (Student scores in _score) {
                if (dict.ContainsKey(scores.Name))
                    dict[scores.Name] += scores.Score;
                else
                    dict[scores.Name] = scores.Score;
            }
            return dict;
        }
    }
}
