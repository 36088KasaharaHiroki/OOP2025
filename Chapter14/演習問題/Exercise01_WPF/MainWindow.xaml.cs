using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise01_WPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private async Task Button_Click(object sender, RoutedEventArgs e) {
            TextArea.Text = await TextReaderSample.ReadTextAsync("走れメロス.txt");
        }
    }
    static class TextReaderSample {
        public static async Task<string> ReadTextAsync(string filePath) {
            var sb = new StringBuilder();
            var sr = new StringReader(filePath);
            //while (!sr.EndOfStream) {
                var line = await sr.ReadLineAsync();
                sb.AppendLine(line);
                await Task.Delay(2);
            //}
            return sb.ToString();
        }
    }
}