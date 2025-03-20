namespace LittleFancyTool.Service
{
    public interface IMessageService
    {
        void InternationalizationMessage(string notifcation, string? message, string type, AntdUI.Window window);
    }
}
