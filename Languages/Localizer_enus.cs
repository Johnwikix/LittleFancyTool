using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Languages
{
     public class Localizer_enus : AntdUI.ILocalization
    {
        public string GetLocalizedString(string key)
        {
            switch (key)
            {
                case "search":
                    return "Search";
                case "welcome":
                    return "Welcome to the AntdUI Demo";
                case "home":
                    return "Home";
                case "closeall":
                    return "Close all tabs";
                #region systemset
                case "systemset":
                    return "System Settings";
                case "baseset":
                    return "Basic Settings";
                case "messageconfig":
                    return "Message configuration";
                case "animationon":
                    return "Turn on animation";
                case "shadowon":
                    return "Enable shadow";
                case "scrollbarhide":
                    return "Hide scrollbar";
                case "showinwindow":
                    return "Show in window";
                case "windowOffsetXY":
                    return "WindowOffsetXY";
                case "tip":
                    return "Tip";
                case "switchsuccess":
                    return "Switch successful.";
                case "LittleFancyTool":
                    return "Little Fancy Tool";
                #endregion

                #region AES
                case "Encrypt":
                    return "Encrypt >>";
                case "Decrypt":
                    return "Decrypt <<";
                case "Input":
                    return "Input";
                case "Output":
                    return "Output";
                case "Key":
                    return "Key";
                case "Iv":
                    return "Iv";
                case "GenKeyIv":
                    return "GenKeyIv";
                #endregion

                #region FileEncryption
                case "targetFile":
                    return "Target File";
                case "outputPath":
                    return "Output Path";
                case "chooseFile":
                    return "Select File";
                case "choosePath":
                    return "Select Path";
                #endregion

                #region Pic2Base64
                case "openImg":
                    return "OpenImg";
                case "img":
                    return "Image";
                case "Encode":
                    return "Encode >>";
                case "Decode":
                    return "Decode <<";
                case "convert":
                    return "Convert >>";
                case "ico":
                    return "Output Ico";
                #endregion

                #region Modbus Poll
                case "serialPort":
                    return "Port";
                case "baudRate":
                    return "Baud Rate";
                case "connectButton":
                    return "Connect";
                case "connectLabel":
                    return "Connect";
                case "parity":
                    return "Parity";
                case "dataBits":
                    return "Data Bits";
                case "StopBits":
                    return "Stop Bits";
                case "scanTime":
                    return "Scan Time";
                case "numRegisters":
                    return "Reg Num";
                case "address":
                    return "Address";
                case "disconnect":
                    return "Disconnect";
                #endregion

                #region Serial Port
                case "FrameBreakInterval":
                    return "FrameBreak(ms)";
                case "ReceivedFormat":
                    return "Received Format";
                case "send":
                    return "Send";
                case "SendFormat":
                    return "Send Format";
                #endregion

                #region Serial Port
                case "GenKey":
                    return "GenKey";
                case "publicKey":
                    return "Public Key";
                case "privateKey":
                    return "Private Key";
                #endregion

                #region TCP
                case "mode":
                    return "Mode";
                case "service":
                    return "Service";
                case "port":
                    return "Port";
                case "startService":
                    return "Start Service";
                case "stopService":
                    return "Stop Service";
                #endregion
                #region TABLE
                case "Table.Column.address":
                    return "reg address";
                case "Table.Column.valueDec":
                    return "value(DEC)";
                case "Table.Column.lastUpdate":
                    return "Last Update";
                #endregion
                default:
                    return null;

            }
        }
    }
}
