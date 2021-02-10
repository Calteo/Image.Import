using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Image.Import
{
    class Profile : INotifyPropertyChanged
    {
        public Profile()
        {
            Name = "";
        }

        #region Name
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public string TargetPictures { get; set; }
        public string TargetVideos { get; set; }
        public bool Overwrite { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
