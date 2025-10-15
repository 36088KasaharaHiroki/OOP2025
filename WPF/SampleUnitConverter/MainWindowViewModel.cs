using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.TextFormatting;

namespace SampleUnitConverter {
    internal class MainWindowViewModel: BindableBase {
        //フィールド
        private double metricValue;
        private double imperialValue;

        public DelegateCommand ImperialUnitToMetric { get; set; }

        public DelegateCommand MetricToImperialUnit { get; set; }

        //上のComboBoxで選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }
        //下のComboBoxで選択されている値
        public ImperialUnit CurrentImperialUnit { get; set; }

        //プロパティ
        public double MetricValue {
            get => metricValue;
            set => SetProperty(ref metricValue, value);
        }
        
        public double ImperialValue {
            get => imperialValue; 
            set => SetProperty(ref imperialValue, value);
        }

        public MainWindowViewModel() {
            CurrentMetricUnit = MetricUnit.Units.First();
            CurrentImperialUnit = ImperialUnit.Units.First();

            ImperialUnitToMetric = new DelegateCommand(
                () => MetricValue = CurrentMetricUnit.FromInperialUnit(
                    CurrentImperialUnit,ImperialValue));

            MetricToImperialUnit = new DelegateCommand(
                () => ImperialValue = CurrentImperialUnit.FromMetricUnit(
                    CurrentMetricUnit, MetricValue));
        }
    }
}
