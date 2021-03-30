using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Image.Import
{
    class Profile : INotifyPropertyChanged
    {
        public Profile()
        {
            Name = "New Profile";
            ImageExtensions = "jpg jpeg";
            ImageExpression = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Jpeg\${taken:yyyy}\${taken:MM}\${filename}";
            RawExtensions = "cr2 cr3";
            RawExpression = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Raw\${filedate:yyyy}\${filedate:MM}\${filename}";
            VideoExtensions = "mp4";
            VideoExpression = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + @"\Raw\${filedate:yyyy}\${filedate:MM}\${filename}";
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

        public string ImageExtensions { get; set; }
        public string ImageExpression { get; set; }
        public string RawExtensions { get; set; }
        public string RawExpression { get; set; }
        public string VideoExtensions { get; set; }
        public string VideoExpression { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
