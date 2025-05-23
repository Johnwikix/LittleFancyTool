﻿namespace LittleFancyTool.Languages
{
    class message_localizer
    {
        public string GetLocalizedString(string key)
        {
            switch (key)
            {
                case "数据读取失败:":
                    return "data read failed:";
                case "请选择有效串口:":
                    return "please select a valid serial port:";
                case "连接失败:":
                    return "connection failed:";
                case "请先打开串口连接":
                    return "please open the serial port connection first";
                case "密钥字符串长度必须为16字节或24字节或32字节":
                    return "the length of the key string must be 16 bytes or 24 bytes or 32 bytes";
                case "密钥字符串不能为空":
                    return "the key string cannot be empty";
                case "IV字符串长度必须为16字节":
                    return "the length of the IV string must be 16 bytes";
                case "iv字符串不能为空":
                    return "the IV string cannot be empty";
                case "密钥字符串长度必须为8字节":
                    return "the length of the key string must be 8 bytes";
                case "密钥字符串长度必须为16字节":
                    return "the length of the key string must be 16 bytes";
                case "iv字符串长度必须为8字节":
                    return "the length of the IV string must be 8 bytes";
                case "请选择输入密钥和iv":
                    return "please select input key and IV";
                case "请先选择要加密的文件！":
                    return "please select the file to be encrypted first!";
                case "请先选择要解密的文件！":
                    return "please select the file to be decrypted first!";
                case "所有文件加密完成,耗时: ":
                    return "all files are encrypted, time consumed: ";
                case "加密过程中出现错误:":
                    return "error occurred during encryption:";
                case "请选择输出目录!":
                    return "please select the output directory!";
                case "请选择加密后的文件":
                    return "please select the encrypted file";
                case "所有文件解密完成,耗时: ":
                    return "all files are decrypted, time consumed: ";
                case "解密过程中出现错误:":
                    return "error occurred during decryption:";
                case "打开目录时出现错误:":
                    return "error occurred when opening the directory:";
                case "写入日志文件时出现错误:":
                    return "error occurred when writing to the log file:";
                case "请先选择一张图片":
                    return "please select an image first";
                case "图片保存成功":
                    return "image saved successfully";
                case "没有图片可供保存":
                    return "no image available for saving";
                case "保存图片时出错:":
                    return "error occurred when saving the image:";
                case "请先输入Base64字符串":
                    return "please enter the Base64 string first";
                case "输入的Base64字符串格式不正确:":
                    return "the format of the entered Base64 string is incorrect:";
                case "没有图片可供预览":
                    return "no image available for preview";
                case "请输入要加密的文本":
                    return "please enter the text to be encrypted";
                case "缺少公钥":
                    return "missing public key";
                case "缺少私钥":
                    return "missing private key";
                case "服务器已停止":
                    return "server has stopped";
                case "关闭服务器时出错:":
                    return "error occurred when closing the server:";
                case "连接关闭":
                    return "connection closed";
                case "连接关闭时出错:":
                    return "error occurred when closing the connection:";
                case "已连接到服务器":
                    return "connected to the server";
                case "连接服务器时出错:":
                    return "error occurred when connecting to the server:";
                case "接收消息时出错:":
                    return "error occurred when receiving the message:";
                case "服务器已启动，监听端口:":
                    return "server has started, listening on port:";
                case "启动服务器时出错:":
                    return "error occurred when starting the server:";
                case "新客户端已连接，当前连接数:":
                    return "new client connected, current number of connections:";
                case "接受客户端连接时出错:":
                    return "error occurred when accepting client connection:";
                case "客户端已断开连接，当前连接数:":
                    return "client has disconnected, current number of connections:";
                case "发送消息给客户端时出错:":
                    return "error occurred when sending message to client:";
                case "客户端未连接:":
                    return "client is not connected:";
                case "服务未连接":
                    return "service is not connected";
                case "发送消息时出错:":
                    return "error occurred when sending message:";
                case "请先选择图片！":
                    return "please select an image first!";
                case "转换成功！":
                    return "conversion successful!";
                case "转换失败：":
                    return "conversion failed:";
                case "没有ico可供保存":
                    return "no ico available for saving";
                case "图标已保存至：":
                    return "icon saved to:";
                case "非法功能码":
                    return "Illegal function code";
                case "非法数据地址":
                    return "Illegal data address";
                case "非法数据值":
                    return "Illegal data value";
                case "从站设备故障":
                    return "Slave device failure";
                case "确认":
                    return "confirm";
                case "从站设备忙":
                    return "Slave device busy";
                case "存储奇偶校验错误":
                    return "Storage parity error";
                case "网关路径不可用":
                    return "Gateway path not available";
                case "网关目标设备响应失败":
                    return "Gateway target device response failed";
                case "图片已保存至：":
                    return "image saved to:";
                case "无效的十六进制字符串":
                    return "invalid hexadecimal string";
                case "数据已保存至：":
                    return "data saved to:";
                case "数据保存出错：":
                    return "error occurred when saving data:";
                case "没有数据可供保存":
                    return "no data available for saving";
                case "客户端未连接":
                    return "client is not connected";
                case "加密出错，文件未读取":
                    return "encryption error, file not read";
                case "处理客户端消息时出错:":
                    return "error occurred when processing client message:";
                case "远程主机已关闭连接":
                    return "remote host has closed the connection";
                case "没有选中的客户端连接":
                    return "no clients connection enabled";
                case "输入字符串长度不能超过8388607":
                    return "The length of the output string cannot exceed 8388607. Please reduce the size of the image";
                case "请不要输入像素数量大于2,359,296的图片":
                    return "Please do not input images with a pixel count greater than 2,359,296";
                case "计算文件哈希值时发生错误:":
                    return "error occurred when calculating file hash";
                case "请选择有效文件":
                    return "please select a valid file";
                case "目标文件夹包含原始文件夹的所有文件":
                    return "the target folder contains all files in the source folder";
                case "读取文件夹时发生错误:":
                    return "error occurred when reading the folder";
                case "请选择有效的源文件夹和目标文件夹":
                    return "please select a valid source folder and target folder";
                case "文件摘要":
                    return "file summary";
                case "文本摘要":
                    return "text summary";
                case "读取音乐文件时发生错误:":
                    return "error occurred when reading the music file:";
                default:
                    return key;
            }
        }
    }
}
