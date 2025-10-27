using CustomerApp.Data;
using Microsoft.Win32;
using SQLite;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    OpenFileDialog ofd;

    private List<Customer> _persons = new List<Customer>();
    public MainWindow() {
        InitializeComponent();
        ReadDatabase();
        PersonListView.ItemsSource = _persons;
    }

    private void ReadDatabase() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            _persons = connection.Table<Customer>().ToList();
        }
    }

    private void PictureButton_Click(object sender, RoutedEventArgs e) {
        OpenFileDialog ofd = new OpenFileDialog();
        if (ofd.ShowDialog() ?? false) {
            PictureImage.Source = new BitmapImage(new Uri(ofd.FileName, UriKind.Absolute));
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e) {
        //Customer customer = new Customer();        
        //customer.Picture = ImageSourceToByteArray(PictureImage.Source);

        var person = new Customer() {
            Name = NameTextBox.Text,
            Phone = PhoneTexBox.Text,
            Picture = ImageSourceToByteArray(PictureImage.Source),
        };

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            connection.Insert(person);
        }
        ReadDatabase();
        PersonListView.ItemsSource = _persons;
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e) {
        var item = PersonListView.SelectedItem as Customer;
        if (item == null) {
            MessageBox.Show("行を選択してください");
            return;
        }

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            connection.Delete(item);
            ReadDatabase();
            PersonListView.ItemsSource = _persons;
        }
    }

    private void UpdateButton_Click(object sender, RoutedEventArgs e) {
        var selectedPerson = PersonListView.SelectedItem as Customer;
        if (selectedPerson is null) return;
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            var person = new Customer() {
                Id = selectedPerson.Id,
                Name = NameTextBox.Text,
                Phone = PhoneTexBox.Text,
            };
            connection.Update(person);
            ReadDatabase();
            PersonListView.ItemsSource = _persons;
        }
    }

    private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
        var filteList = _persons.Where(p => p.Name.Contains(SearchTextBox.Text));
        PersonListView.ItemsSource = filteList;
    }

    private void PersonListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        var selectedPerson = PersonListView.SelectedItem as Customer;
        if (selectedPerson is null) return;
        NameTextBox.Text = selectedPerson.Name;
        PhoneTexBox.Text = selectedPerson.Phone;
        if (PersonListView.SelectedIndex != -1) {
            if (_persons[PersonListView.SelectedIndex].Picture != null) {
                PictureImage.Source = byteToBitmap(_persons[PersonListView.SelectedIndex].Picture);
            } else {
                PictureImage.Source = null;
            }
        }
    }

    public static byte[] ImageSourceToByteArray(ImageSource imageSource) {
        if (imageSource == null) {
            return null;
        }

        byte[] byteArray = null;
        // MemoryStreamを作成
        using (var stream = new MemoryStream()) {
            // PngEncoderを作成
            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)imageSource));
            // MemoryStreamにエンコードを保存
            encoder.Save(stream);
            // MemoryStreamの内容をbyte配列として取得
            byteArray = stream.ToArray();
        }
        return byteArray;
    }

    public static BitmapImage byteToBitmap(byte[] bytes) {
        var result = new BitmapImage();

        using (var stream = new MemoryStream(bytes)) {
            result.BeginInit();
            result.CacheOption = BitmapCacheOption.OnLoad;
            result.CreateOptions = BitmapCreateOptions.None;
            result.StreamSource = stream;
            result.EndInit();
            result.Freeze();    // 非UIスレッドから作成する場合、Freezeしないとメモリリークするため注意
        }
        return result;
    }
}