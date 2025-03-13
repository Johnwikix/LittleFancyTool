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
            { "串口工具", new List<MenuItems>
                {
                    new MenuItems { Text = "串口调试", Tag = "串口调试"},
                    new MenuItems { Text = "modbus poll", Tag = "modbus poll"},
                }
            },
            { "TCP工具", new List<MenuItems>
                {
                    new MenuItems { Text = "Sockets", Tag = "Sockets"},
                }
            },
            { "文件", new List<MenuItems>
                {
                    new MenuItems { Text = "文件加密", Tag = "文件加密"},
                }
            },
            { "非对称加密", new List<MenuItems>
                {
                    new MenuItems { Text = "RSA" , Tag = "RSA"},
                    new MenuItems { Text = "SM2", Tag = "SM2"}
                }
            },
            { "对称加密", new List<MenuItems>
                {
                    new MenuItems { Text = "AES", Tag = "AES"},
                    new MenuItems { Text = "DES", Tag = "DES"},
                    new MenuItems { Text = "SM4", Tag = "SM4"}
                }
            },
            { "摘要", new List<MenuItems>
                {                  
                    new MenuItems { Text = "MD5", Tag = "MD5"},
                    new MenuItems { Text = "SHA", Tag = "SHA"},
                    new MenuItems { Text = "SM3", Tag = "SM3"}
                }
            },
            { "编码", new List<MenuItems>
                {
                    new MenuItems { Text = "Base64", Tag = "Base64"},
                    new MenuItems { Text = "图片转Base64", Tag = "图片转Base64"},
                }
            },

        };
        public static readonly Dictionary<string, string> MenuIcons_zhcn = new Dictionary<string, string>
        {
            { "串口工具", "MessageOutlined" },
            { "TCP工具", "SettingOutlined" },
            { "非对称加密", "AppstoreAddOutlined" },
            { "对称加密", "AppstoreOutlined" },
            { "摘要", "ApartmentOutlined" },
            { "编码", "BlockOutlined" },
            { "二维码", "QrcodeOutlined" },
            { "文件", "FileOutlined" },            
        };

        public static readonly Dictionary<string, List<MenuItems>> MenuItems_enus = new Dictionary<string, List<MenuItems>>()
        {
            { "General", new List<MenuItems>
                {
                    new MenuItems { Text = "RSA" , Tag = "RSA"},
                    new MenuItems { Text = "AES", Tag = "AES"},
                    new MenuItems { Text = "DES", Tag = "DES"},
                    new MenuItems { Text = "Base64", Tag = "Base64"},
                    new MenuItems { Text = "MD5", Tag = "MD5"},
                    new MenuItems { Text = "SHA", Tag = "SHA"},
                    new MenuItems { Text = "SM4", Tag = "SM4"},
                    new MenuItems { Text = "SM3", Tag = "SM3"},
                    new MenuItems { Text = "SM2", Tag = "SM2"}
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
