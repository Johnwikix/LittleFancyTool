using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Models
{
    class TestClass: AntdUI.NotifyProperty
    {
        public TestClass(string address, string valueDec, DateTime lastUpdate)
        {
            _address = address;
            _valueDec = valueDec;
            _lastUpdate = lastUpdate;
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
    }
}
