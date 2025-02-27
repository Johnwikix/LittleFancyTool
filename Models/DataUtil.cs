using AntdUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTool.Models
{
    public class DataUtil
    {
        public static readonly Dictionary<string, List<MenuItems>> MenuItems_zhcn = new Dictionary<string, List<MenuItems>>() {
            { "加密", new List<MenuItems>
                {
                    new MenuItems { Text = "RSA" , Tag = "RSA"},
                    new MenuItems { Text = "AES", Tag = "AES"},
                    new MenuItems { Text = "Base64", Tag = "Base64"},
                }
            },
        };
        public static readonly Dictionary<string, string> MenuIcons_zhcn = new Dictionary<string, string>
        {
            { "通用", "AppstoreOutlined" },
            { "布局", "LayoutOutlined" },
            { "导航", "CompressOutlined" },
            { "数据录入", "EditOutlined" },
            { "数据展示", "BarChartOutlined" },
            { "反馈", "NotificationOutlined" },
            { "聊天", "MessageOutlined" },
            { "其它", "SettingOutlined" }
        };

        public static readonly Dictionary<string, List<MenuItems>> MenuItems_enus = new Dictionary<string, List<MenuItems>>()
    {
        { "General", new List<MenuItems>
            {
                new MenuItems { Text = "Button" , Tag = "Button"},
                new MenuItems { Text = "FloatButton", Tag = "FloatButton"},
                new MenuItems { Text = "Icon", Tag = "Icon"},
            }
        },
        { "Layout", new List<MenuItems>
            {
                new MenuItems { Text = "Divider", Tag = "Divider" },
                new MenuItems { Text = "FlowPanel", Tag = "FlowPanel"},
                new MenuItems { Text = "GridPanel", Tag = "GridPanel"},
                new MenuItems { Text = "Panel", Tag = "Panel"},
                new MenuItems { Text = "Splitter ", Tag = "Splitter"},
                new MenuItems { Text = "StackPanel", Tag = "StackPanel"}
            }
        },
        { "Navigation", new List<MenuItems>
            {
                new MenuItems { Text = "Breadcrumb", Tag = "Breadcrumb"},
                new MenuItems { Text = "Dropdown", Tag = "Dropdown"},
                new MenuItems { Text = "Menu", Tag = "Menu"},
                new MenuItems { Text = "Pagination", Tag = "Pagination"},
                new MenuItems { Text = "Steps", Tag = "Steps"}
            }
        },
        { "Data Entry", new List<MenuItems>
            {
                new MenuItems { Text = "Checkbox", Tag = "Checkbox"},
                new MenuItems { Text = "ColorPicker", Tag = "ColorPicker"},
                new MenuItems { Text = "DatePicker", Tag = "DatePicker"},
                new MenuItems { Text = "DatePickerRange", Tag = "DatePickerRange"},
                new MenuItems { Text = "Input", Tag = "Input"},
                new MenuItems { Text = "InputNumber", Tag = "InputNumber"},
                new MenuItems { Text = "Radio", Tag = "Radio"},
                new MenuItems { Text = "Rate", Tag = "Rate"},
                new MenuItems { Text = "Select", Tag = "Select"},
                new MenuItems { Text = "SelectMultiple", Tag = "SelectMultiple"},
                new MenuItems { Text = "Slider", Tag = "Slider"},
                new MenuItems { Text = "SliderRange", Tag = "SliderRange"},
                new MenuItems { Text = "Switch", Tag = "Switch"},
                new MenuItems { Text = "TimePicker", Tag = "TimePicker"},
                new MenuItems { Text = "UploadDragger", Tag = "UploadDragger"}
            }
        },
        { "Data Display", new List<MenuItems>
            {
                new MenuItems { Text = "Avatar", Tag = "Avatar"},
                new MenuItems { Text = "Badge", Tag = "Badge"},
                new MenuItems { Text = "Calendar", Tag = "Calendar"},
                new MenuItems { Text = "Carousel", Tag = "Carousel"},
                new MenuItems { Text = "Collapse", Tag = "Collapse"},
                new MenuItems { Text = "Label", Tag = "Label"},
                new MenuItems { Text = "LabelTime", Tag = "LabelTime"},
                new MenuItems { Text = "Popover", Tag = "Popover"},
                new MenuItems { Text = "Preview", Tag = "Preview"},
                new MenuItems { Text = "Segmented", Tag = "Segmented"},
                new MenuItems { Text = "Table", Tag = "Table"},
                new MenuItems { Text = "Tabs", Tag = "Tabs"},
                new MenuItems { Text = "Tag", Tag = "Tag"},
                new MenuItems { Text = "Timeline", Tag = "Timeline"},
                new MenuItems { Text = "Tooltip", Tag = "Tooltip"},
                new MenuItems { Text = "Tour" , Tag = "Tour"},
                new MenuItems { Text = "Tree", Tag = "Tree"}
            }
        },
        { "Feedback", new List<MenuItems>
            {
                new MenuItems { Text = "Alert", Tag = "Alert"},
                new MenuItems { Text = "Drawer", Tag = "Drawer"},
                new MenuItems { Text = "Message", Tag = "Message"},
                new MenuItems { Text = "Modal", Tag = "Modal"},
                new MenuItems { Text = "Notification", Tag = "Notification"},
                new MenuItems { Text = "Progress", Tag = "Progress"},
                new MenuItems { Text = "Spin", Tag = "Spin"}
            }
        },
        { "Chat", new List<MenuItems>
            {
                new MenuItems { Text = "ChatList", Tag = "ChatList"},
                new MenuItems { Text = "MsgList", Tag = "MsgList"}
            }
        },
        { "Other", new List<MenuItems>
            {
                new MenuItems { Text = "Battery", Tag = "Battery" },
                new MenuItems { Text = "ContextMenuStrip", Tag = "ContextMenuStrip" },
                new MenuItems { Text = "Image3D", Tag = "Image3D" },
                new MenuItems { Text = "PageHeader", Tag= "PageHeader"},
                new MenuItems { Text = "Signal", Tag = "Signal" }
            }
        }
    };

        public static readonly Dictionary<string, string> MenuIcons_enus = new Dictionary<string, string>
        {
            { "General", "AppstoreOutlined" },
            { "Layout", "LayoutOutlined" },
            { "Navigation", "CompressOutlined" },
            { "Data Entry", "EditOutlined" },
            { "Data Display", "BarChartOutlined" },
            { "Feedback", "NotificationOutlined" },
            { "Chat", "MessageOutlined" },
            { "Other", "SettingOutlined" }
        };
    }
}
