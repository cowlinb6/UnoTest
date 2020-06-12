using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PlumTest.Shared
{
    public class LoginModel : INotifyPropertyChanged
    {
        private string _result = "This is the result";
        public string Result
        {
            get { return _result; }
            set 
            { 
                if (value == _result)
                {
                    return;
                }

                _result = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
            }
        }

        private string _identityToken = "This is the IdentityToken";
        public string IdentityToken
        {
            get { return _identityToken; }
            set
            {
                if (value == _identityToken)
                {
                    return;
                }

                _identityToken = value;
                OnPropertyChanged();
            }
        }

        private string _accessToken = "This is the AccessToken";
        public string AccessToken
        {
            get { return _accessToken; }
            set
            {
                if (value == _accessToken)
                {
                    return;
                }

                _accessToken = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
