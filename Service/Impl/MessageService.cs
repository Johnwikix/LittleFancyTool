using LittleFancyTool.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Service.Impl
{
    public class MessageService: IMessageService
    {
        public void InternationalizationMessage(string notifcation,string? message, string type, AntdUI.Window window)
        {
            string language = AntdUI.Localization.CurrentLanguage;
            if (!language.StartsWith("zh"))
            {
                var provider = new message_localizer();
                notifcation = provider.GetLocalizedString(notifcation);
            }
            switch (type)
            {
                case "error":
                    AntdUI.Message.error(window, $"{notifcation}{message}", autoClose: 3);
                    break;
                case "success":
                    AntdUI.Message.success(window, $"{notifcation}{message}", autoClose: 3);
                    break;
                case "info":
                    AntdUI.Message.info(window, $"{notifcation}{message}", autoClose: 3);
                    break;
                case "warn":
                    AntdUI.Message.warn(window, $"{notifcation}{message}", autoClose: 3);
                    break;
                default:
                    AntdUI.Message.success(window, $"{notifcation}{message}", autoClose: 3);
                    break;
            }
        }
    }
}
