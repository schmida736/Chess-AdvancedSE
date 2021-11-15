using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    public class BoardLayout: INotifyPropertyChanged
    {
        public BoardLayout()
        {
            Layout = new();
        }

        private List<List<Square>> _layout;
        public List<List<Square>> Layout
        {
            get => _layout;
            set
            {
                _layout = value;
                NotifyPropertyChanged(nameof(Layout));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
