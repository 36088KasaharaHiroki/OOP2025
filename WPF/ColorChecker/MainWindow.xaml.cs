using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        Color loadColor = Color.FromRgb(0, 0, 0); 
        MyColor currentColor;

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        //すべてのスライダーから呼ばれるイベントハンドラ
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            //colorAreaの色（背景色）は、スライダーで指定したRGBの色を表示する
            //colorArea.Background = new SolidColorBrush(Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value));
            currentColor = new MyColor {Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value),
                Name = ((MyColor[])DataContext).Where(c=>
                       c.Color.R == (byte)rSlider.Value 
                    && c.Color.G == (byte)gSlider.Value 
                    && c.Color.B == (byte)bSlider.Value).Select(x=>x.Name).FirstOrDefault()
            };
            colorArea.Background = new SolidColorBrush(currentColor.Color);
            colorSelectComboBox.SelectedIndex = GetColorToIndex(currentColor.Color);       
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            if (!stockList.Items.Contains(currentColor)) {
                //stockList.Items.Add("R：" + rSlider.Value + "  G：" + gSlider.Value + "  B：" + bSlider.Value);
                stockList.Items.Insert(0, currentColor);
            } else {
                MessageBox.Show("既に登録済みです！","ColorCherker", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
        }

        //コンボボックスから色を選択
        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var cb = (ComboBox)sender;
            if (cb.SelectedIndex == -1) return;
            setSliderValue(((MyColor)(cb).SelectedItem).Color);
            currentColor = (MyColor)(cb).SelectedItem;
        }

        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            colorSelectComboBox.SelectedIndex = GetColorToIndex(loadColor);
        }

        private int GetColorToIndex(Color color) {
            return ((MyColor[])DataContext).ToList().FindIndex(c => c.Color.Equals(color));
        }
    }
}
