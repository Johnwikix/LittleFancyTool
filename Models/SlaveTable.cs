using AntdUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Models
{
    public class SlaveTable : AntdUI.NotifyProperty
    {
        public SlaveTable(string address, string valueDec,bool enable)
        {
            _address = address;
            _valueDec = valueDec;            
            if (valueDec.Length > 0) {
                _enabled = enable;
                _btns = new AntdUI.CellLink[] {
                        new AntdUI.CellButton("edit","编辑",AntdUI.TTypeMini.Primary)
                    };
            }            
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

        private bool _enabled = false;

        public bool Enabled
        {
            get { return _enabled; }
            set
            {
                if (_enabled == value) return;
                _enabled = value;
                OnPropertyChanged(nameof(Enabled));
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
