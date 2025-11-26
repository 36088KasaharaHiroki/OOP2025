using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TenkiApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private const string ApiUrl =
            "https://api.open-meteo.com/v1/forecast?latitude={0}&longitude={1}&current_weather=true&timezone=auto";

        private readonly Dictionary<string, (double lat, double lon)> Prefectures = new()
        {
            { "北海道",     (43.06417, 141.34694) },
            { "青森県",     (40.82444, 140.74) },
            { "岩手県",     (39.70361, 141.1525) },
            { "宮城県",     (38.26889, 140.87194) },
            { "秋田県",     (39.71861, 140.1025) },
            { "山形県",     (38.24056, 140.36333) },
            { "福島県",     (37.75,    140.46778) },
            { "茨城県",     (36.34139, 140.44667) },
            { "栃木県",     (36.56583, 139.88361) },
            { "群馬県",     (36.39111, 139.06083) },
            { "埼玉県",     (35.85694, 139.64889) },
            { "千葉県",     (35.60472, 140.12333) },
            { "東京都",     (35.68944, 139.69167) },
            { "神奈川県",   (35.44778, 139.6425) },
            { "新潟県",     (37.90222, 139.02361) },
            { "富山県",     (36.69528, 137.21139) },
            { "石川県",     (36.59444, 136.62556) },
            { "福井県",     (36.06528, 136.22194) },
            { "山梨県",     (35.66389, 138.56833) },
            { "長野県",     (36.65139, 138.18111) },
            { "岐阜県",     (35.39111, 136.72222) },
            { "静岡県",     (34.97694, 138.38306) },
            { "愛知県",     (35.18028, 136.90667) },
            { "三重県",     (34.73028, 136.50861) },
            { "滋賀県",     (35.00444, 135.86833) },
            { "京都府",     (35.02139, 135.75556) },
            { "大阪府",     (34.68639, 135.52)    },
            { "兵庫県",     (34.69139, 135.18306) },
            { "奈良県",     (34.68528, 135.83278) },
            { "和歌山県",   (34.22611, 135.1675)  },
            { "鳥取県",     (35.50361, 134.23833) },
            { "島根県",     (35.47222, 133.05056) },
            { "岡山県",     (34.66167, 133.935)   },
            { "広島県",     (34.39639, 132.45944) },
            { "山口県",     (34.18583, 131.47139) },
            { "徳島県",     (34.06583, 134.55944) },
            { "香川県",     (34.34028, 134.04333) },
            { "愛媛県",     (33.84167, 132.76611) },
            { "高知県",     (33.55972, 133.53111) },
            { "福岡県",     (33.60639, 130.41806) },
            { "佐賀県",     (33.24944, 130.29889) },
            { "長崎県",     (32.74472, 129.87361) },
            { "熊本県",     (32.78972, 130.74167) },
            { "大分県",     (33.23806, 131.61250) },
            { "宮崎県",     (31.91111, 131.42389) },
            { "鹿児島県",   (31.56028, 130.55806) },
            { "沖縄県",     (26.21250, 127.68111) }
        };

        public MainWindow() {
            InitializeComponent();
            InitializeWebView();
            PrefectureComboBox.ItemsSource = Prefectures.Keys;
        }

        private async void InitializeWebView() {
            await WebView.EnsureCoreWebView2Async();
            string htmlPath = System.IO.Path.Combine(AppContext.BaseDirectory, "index.html");
            WebView.Source = new Uri(htmlPath);
            WebView.CoreWebView2.WebMessageReceived += WebView_WebMessageReceived;
        }

        private void WebView_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e) {
            try {
                string json = e.WebMessageAsJson;
                var msg = JsonConvert.DeserializeObject<MapClickMessage>(json);
                if (msg == null) return;

                LatBox.Text = msg.latitude.ToString("F5");
                LonBox.Text = msg.longitude.ToString("F5");
                WeatherInfoText.Text = "地図で地点を選択しました。";
            }
            catch (Exception ex) {
                WeatherInfoText.Text = "地図情報受信エラー: " + ex.Message;
            }
        }


        private void PrefectureComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (PrefectureComboBox.SelectedItem is string pref
              && Prefectures.TryGetValue(pref, out var coord)) {
                LatBox.Text = coord.lat.ToString("F5");
                LonBox.Text = coord.lon.ToString("F5");
                WeatherInfoText.Text = $"選択：{pref}";

                string script = $"moveAndMarker({coord.lat},{coord.lon});";
                WebView.ExecuteScriptAsync(script);
            }
        }

        private async void GetWeatherButton_Click(object sender, RoutedEventArgs e) {
            if (!double.TryParse(LatBox.Text, out double lat) ||
                !double.TryParse(LonBox.Text, out double lon)) {
                MessageBox.Show("有効な緯度／経度を指定してください。");
                return;
            }

            WeatherInfoText.Text = "天気情報取得中…";

            try {
                var weather = await GetWeatherAsync(lat, lon);
                if (weather?.current_weather != null) {
                    var cw = weather.current_weather;
                    WeatherInfoText.Text =
                        $"気温：{cw.temperature} ℃\n" +
                        $"天気：{WeatherCodeToJapanese(cw.weathercode)} {WeatherCodeToEmoji(cw.weathercode)}\n" +
                        $"風速：{cw.windspeed} m/s\n" +
                        $"取得時刻 (UTC)：{cw.time}";
                } else {
                    WeatherInfoText.Text = "天気情報が取得できませんでした。";
                }
            }
            catch (Exception ex) {
                WeatherInfoText.Text = "天気取得エラー: " + ex.Message;
            }
        }

        private async Task<WeatherResponse?> GetWeatherAsync(double lat, double lon) {
            using var client = new HttpClient();
            string url = string.Format(ApiUrl, lat, lon);
            string json = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<WeatherResponse>(json);
        }

        private string WeatherCodeToJapanese(int code) {
            return code switch {
                0 => "晴れ",
                1 => "主に晴れ",
                2 => "曇り",
                3 => "曇り一時雨",
                45 => "霧",
                48 => "凍結霧",
                51 or 53 or 55 => "霧雨",
                56 or 57 => "雪の霧雨",
                61 or 63 or 65 => "雨",
                66 or 67 => "雪混じりの雨",
                71 or 73 or 75 => "雪",
                77 => "霰",
                80 or 81 or 82 => "雷雨",
                85 or 86 => "雪雷雨",
                95 or 96 or 99 => "雷雨・雪",
                _ => "不明"
            };
        }

        private string WeatherCodeToEmoji(int code) {
            return code switch {
                0 => "☀️",
                1 => "🌤️",
                2 => "☁️",
                3 => "⛅",
                45 or 48 => "🌫️",
                51 or 53 or 55 or 61 or 63 or 65 => "🌧️",
                56 or 57 or 66 or 67 or 71 or 73 or 75 => "❄️",
                77 => "🌨️",
                80 or 81 or 82 => "⛈️",
                85 or 86 => "🌨️⚡",
                95 or 96 or 99 => "⚡❄️",
                _ => "❓"
            };
        }
    }

    public class MapClickMessage {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class WeatherResponse {
        public CurrentWeather? current_weather { get; set; }
    }

    public class CurrentWeather {
        public double temperature { get; set; }
        public int weathercode { get; set; }
        public double windspeed { get; set; }
        public double winddirection { get; set; }
        public string time { get; set; } = "";
    }
}