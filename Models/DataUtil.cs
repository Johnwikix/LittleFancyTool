﻿using AntdUI;
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
                }
            },
            { "文件", new List<MenuItems>
                {
                    new MenuItems { Text = "文件加密", Tag = "fileEncrypt"},
                }
            },
            //{ "二维码", new List<MenuItems>
            //    {
            //        new MenuItems { Text = "识别", Tag = "QRCodeDetector"},
            //    }
            //},

        };
        public static readonly Dictionary<string, string> MenuIcons_zhcn = new Dictionary<string, string>
        {
            { "非对称加密", "AppstoreOutlined" },
            { "对称加密", "LayoutOutlined" },
            { "摘要", "CompressOutlined" },
            { "编码", "EditOutlined" },
            { "二维码", "QrcodeOutlined" },
            { "文件", "NotificationOutlined" },
            { "聊天", "MessageOutlined" },
            { "其它", "SettingOutlined" }
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
