using System.ComponentModel;

namespace Finger
{
    public class Model : INotifyPropertyChanged
    {
        private string result;

        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
