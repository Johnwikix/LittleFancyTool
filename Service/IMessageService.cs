using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Service
{
    public interface IMessageService
    {
        void InternationalizationMessage(string notifcation,string? message, string type, AntdUI.Window window);
    }
}
