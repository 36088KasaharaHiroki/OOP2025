using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class ViewModel  : BindableBase{

        public ViewModel() {
            ChangeMessageCommand = new DelegateCommand(
                () => GreetingMessage = "Bye-bye world");
        }
        private string _gretingMessage = "Hello World!";
        public string GreetingMessage {
            get => _gretingMessage;
            set => SetProperty(ref _gretingMessage, value);
        }
        public DelegateCommand ChangeMessageCommand { get; }
    }
}
