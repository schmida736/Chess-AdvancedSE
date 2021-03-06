using System.Collections.Generic;
using System.ComponentModel;

namespace Chess_AdvancedSE
{
    public class BoardLayout_ViewModel : INotifyPropertyChanged
    {
        public BoardLayout_ViewModel()
        {
            layout = new();
        }

        private List<List<Square>> _layout;
        public List<List<Square>> layout
        {
            get
            {
                return _layout;
            }
            set
            {
                _layout = value;
                OnPropertyChanged(nameof(layout));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
