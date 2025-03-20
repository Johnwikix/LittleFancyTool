namespace CryptoTool.Models
{
    public class DataUtil
    {
        public static readonly Dictionary<string, List<MenuItems>> MenuItems_zhcn = new Dictionary<string, List<MenuItems>>() {
            { "串口工具", new List<MenuItems>
                {
                    new MenuItems { Text = "串口调试", Tag = "Serial Port Debugging"},
                    new MenuItems { Text = "Modbus Poll", Tag = "Modbus Poll"},
                    new MenuItems { Text = "Modbus Slave", Tag = "Modbus Slave"}
                }
            },
            { "TCP工具", new List<MenuItems>
                {
                    new MenuItems { Text = "Sockets", Tag = "Sockets"},
                }
            },
            { "文件加密", new List<MenuItems>
                {
                    new MenuItems { Text = "文件加密", Tag = "File Encryption"},
                }
            },
            { "文本加密", new List<MenuItems>
                {
                    new MenuItems { Text = "RSA" , Tag = "RSA"},
                    new MenuItems { Text = "SM2", Tag = "SM2"},
                    new MenuItems { Text = "AES", Tag = "AES"},
                    new MenuItems { Text = "DES", Tag = "DES"},
                    new MenuItems { Text = "SM4", Tag = "SM4"},
                    new MenuItems { Text = "MD5", Tag = "MD5"},
                    new MenuItems { Text = "SHA", Tag = "SHA"},
                    new MenuItems { Text = "SM3", Tag = "SM3"},
                    new MenuItems { Text = "Base64", Tag = "Base64"}
                }
            },
            { "图片处理", new List<MenuItems>
                {
                    new MenuItems { Text = "图片转Base64", Tag = "Img2Base64"},
                    new MenuItems { Text = "图片转ico", Tag = "Img2ico"},
                    new MenuItems { Text = "图片转换", Tag = "ImgConvert"}
                }
            },

        };
        public static readonly Dictionary<string, string> MenuIcons_zhcn = new Dictionary<string, string>
        {
            { "串口工具", "UsbOutlined" },
            { "TCP工具", "MessageOutlined" },
            { "图片处理", "PictureOutlined" },
            { "文本加密", "FileTextOutlined" },
            { "文件加密", "LockOutlined" },
        };

        public static readonly Dictionary<string, List<MenuItems>> MenuItems_enus = new Dictionary<string, List<MenuItems>>()
        {
            { "Serial Port Tool", new List<MenuItems>
                {
                    new MenuItems { Text = "Serial Port Debugging", Tag = "Serial Port Debugging"},
                    new MenuItems { Text = "Modbus Poll", Tag = "Modbus Poll"},
                    new MenuItems { Text = "Modbus Slave", Tag = "Modbus Slave"}
                }
            },
            { "TCP Tool", new List<MenuItems>
                {
                    new MenuItems { Text = "Sockets", Tag = "Sockets"},
                }
            },
            { "File Encryption", new List<MenuItems>
                {
                    new MenuItems { Text = "File Encryption", Tag = "File Encryption"},
                }
            },
            { "Text Encryption", new List<MenuItems>
                {
                    new MenuItems { Text = "RSA" , Tag = "RSA"},
                    new MenuItems { Text = "SM2", Tag = "SM2"},
                    new MenuItems { Text = "AES", Tag = "AES"},
                    new MenuItems { Text = "DES", Tag = "DES"},
                    new MenuItems { Text = "SM4", Tag = "SM4"},
                    new MenuItems { Text = "MD5", Tag = "MD5"},
                    new MenuItems { Text = "SHA", Tag = "SHA"},
                    new MenuItems { Text = "SM3", Tag = "SM3"},
                    new MenuItems { Text = "Base64", Tag = "Base64"}
                }
            },
            { "Image", new List<MenuItems>
                {
                    new MenuItems { Text = "Img2Base64", Tag = "Img2Base64"},
                    new MenuItems { Text = "Img2ico", Tag = "Img2ico"},
                    new MenuItems { Text = "ImgConvert", Tag = "ImgConvert"}
                }
            },
        };

        public static readonly Dictionary<string, string> MenuIcons_enus = new Dictionary<string, string>
        {
            { "Serial Port Tool", "UsbOutlined" },
            { "TCP Tool", "MessageOutlined" },
            { "Image", "PictureOutlined" },
            { "Text Encryption", "FileTextOutlined" },
            { "File Encryption", "LockOutlined" },
        };
    }
}
