using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class ViewModel : BindableBase {

        public ViewModel() {
            ChangeMessageCommand = new DelegateCommand<string>(
                (par) => GreetingMessage = par,
                (par) => GreetingMessage != par)
                .ObservesProperty(() => GreetingMessage);
        }

        private string _gretingMessage = "Hello World!";
        public string GreetingMessage {
            get => _gretingMessage;
            set => SetProperty(ref _gretingMessage, value);
        }

        public string NewMessage1 { get; } = "Bye-bye world!";
        public string NewMessage2 { get; } = "Long time no see, world!";
        public DelegateCommand<string> ChangeMessageCommand { get; }
    }
}
