using CustomerApp.Data;
using Microsoft.Win32;
using SQLite;
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
    private List<Customer> _persons = new List<Customer>();
    public MainWindow() {
        InitializeComponent();
        ReadDatabase();
        PersonListView.ItemsSource = _persons;

        //OpenFileDialog ofd = new OpenFileDialog();
        //var ret = ofd.ShowDialog();
        //if(ret ?? false) {
        //}
    }

    

    private void ReadDatabase() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            _persons = connection.Table<Customer>().ToList();
        }
    }

    private void PictureButton_Click(object sender, RoutedEventArgs e) {
        
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e) {
        ReadDatabase();
        PersonListView.ItemsSource = _persons;

        var person = new Customer() {
            Name = NameTextBox.Text,
            Phone = PhoneTexBox.Text,
        };

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            connection.Insert(person);
        }
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e) {
        var item = PersonListView.SelectedItem as Customer;
        if (item == null) {
            MessageBox.Show("行を選択してください");
            return;
        }

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            connection.Delete(item);    //データベースから選択されているレコードの削除
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
    }
}