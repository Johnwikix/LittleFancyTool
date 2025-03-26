using AntdUI;

namespace LittleFancyTool.Models
{
    public class PollTable : AntdUI.NotifyProperty
    {
        public PollTable(string address, string valueDec, DateTime lastUpdate)
        {
            _address = address;
            _valueDec = valueDec;
            _lastUpdate = lastUpdate;
            _btns = new CellLink[] {
                        new CellButton("edit","Edit",AntdUI.TTypeMini.Primary)
                    };
        }

        string _valueDec;
        public string valueDec
        {
            get => _valueDec;
            set
            {
                if (_valueDec == value) return;
                _valueDec = value;
                OnPropertyChanged();
            }
        }
        DateTime _lastUpdate;
        public DateTime lastUpdate
        {
            get => _lastUpdate;
            set
            {
                if (_lastUpdate == value) return;
                _lastUpdate = value;
                OnPropertyChanged();
            }
        }
        string _address;
        public string address
        {
            get => _address;
            set
            {
                if (_address == value) return;
                _address = value;
                OnPropertyChanged();
            }
        }

        AntdUI.CellLink[] _btns;
        public AntdUI.CellLink[] btns
        {
            get => _btns;
            set
            {
                _btns = value;
                OnPropertyChanged();
            }
        }
    }
}
