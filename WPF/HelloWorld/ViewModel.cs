using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class ViewModel {

        public ViewModel() {
            ChangeMessageCommand = new DelegateCommand(
                () => GreetingMessage = "Bye-bye world");
        }
        private string _gretingMessage = "Hello World!";
        public string GreetingMessage {
            get => _gretingMessage;
            set {
                if (_gretingMessage != value) {
                    _gretingMessage = value;
                    PropertyChenged?.Invoke(
                        this, new PropertyChengedEventArgs(nameof, nameof(GerrtingMessage)));
                }
            }
        }
        public DelegateCommand ChangeMessageCommand { get; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
