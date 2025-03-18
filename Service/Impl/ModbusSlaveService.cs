using AntdUI;
using LittleFancyTool.Models;
using LittleFancyTool.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Service.Impl
{
    public class ModbusSlaveService : IModbusSlaveService
    {
        public byte[] ProcessReadCoils(byte slaveAddress, ushort startAddress, ushort quantity, List<SlaveTable> dataList)
        {
            List<byte> response = new List<byte>();
            response.Add(slaveAddress);
            response.Add(0x01);
            int byteCount = (quantity + 7) / 8;
            response.Add((byte)byteCount);
            byte currentByte = 0;
            int bitIndex = 0;
            for (int i = startAddress; i < quantity; i++)
            {
                if (ushort.Parse(dataList[i].valueDec) != 0)
                {
                    currentByte |= (byte)(1 << (bitIndex % 8));
                }
                bitIndex++;
                if (bitIndex % 8 == 0)
                {
                    response.Add(currentByte);
                    currentByte = 0;
                }
            }
            if (bitIndex % 8 != 0)
            {
                response.Add(currentByte);
            }
            byte[] data = response.ToArray();
            ushort crc = ToolMethod.CalculateCRC(data);
            response.Add((byte)(crc & 0xFF));
            response.Add((byte)(crc >> 8));
            return response.ToArray();
        }

        public byte[] ProcessReadDiscreteInputs(byte slaveAddress, ushort startAddress, ushort quantity, List<SlaveTable> dataList)
        {
            List<byte> response = new List<byte>();
            response.Add(slaveAddress);
            response.Add(0x02);
            int inputByteCount = (quantity + 7) / 8;
            response.Add((byte)inputByteCount);
            byte inputCurrentByte = 0;
            int inputBitIndex = 0;
            for (int i = startAddress; i < quantity; i++) {
                if (ushort.Parse(dataList[i].valueDec) != 0)
                {
                    inputCurrentByte |= (byte)(1 << (inputBitIndex % 8));
                }
                inputBitIndex++;
                if (inputBitIndex % 8 == 0)
                {
                    response.Add(inputCurrentByte);
                    inputCurrentByte = 0;
                }
            }
            if (inputBitIndex % 8 != 0)
            {
                response.Add(inputCurrentByte);
            }
            byte[] data = response.ToArray();
            ushort crc = ToolMethod.CalculateCRC(data);
            response.Add((byte)(crc & 0xFF));
            response.Add((byte)(crc >> 8));
            return response.ToArray();
        }

        public byte[] ProcessReadHoldingRegisters(byte slaveAddress, ushort startAddress, ushort quantity, List<SlaveTable> dataList)
        {
            int byteCount = quantity* 2;
            List<byte> response = new List<byte>();
            response.Add(slaveAddress); // 从站 ID
            response.Add(0x03);    // 功能码 0x03
            response.Add((byte)byteCount); // 字节数

            // 添加寄存器值
            for (int i = startAddress; i < quantity; i++) {
                response.Add((byte)(ushort.Parse(dataList[i].valueDec) >> 8)); // 高字节
                response.Add((byte)(ushort.Parse(dataList[i].valueDec) & 0xFF)); // 低字节
            }
            // 计算 CRC 校验值
            byte[] data = response.ToArray();
            ushort crc = ToolMethod.CalculateCRC(data);
            response.Add((byte)(crc & 0xFF));
            response.Add((byte)(crc >> 8));
            return response.ToArray();
        }

        public byte[] ProcessReadInputRegisters(byte slaveAddress, ushort startAddress, ushort quantity, List<SlaveTable> dataList)
        {
            List<byte> response = new List<byte>();
            response.Add(slaveAddress);
            response.Add(0x04);
            int inputRegisterByteCount = quantity * 2;
            response.Add((byte)inputRegisterByteCount);
            for (int i = startAddress; i < quantity; i++)
            {
                response.Add((byte)(ushort.Parse(dataList[i].valueDec) >> 8)); // 高字节
                response.Add((byte)(ushort.Parse(dataList[i].valueDec) & 0xFF)); // 低字节
            }
            byte[] data = response.ToArray();
            ushort crc = ToolMethod.CalculateCRC(data);
            response.Add((byte)(crc & 0xFF));
            response.Add((byte)(crc >> 8));
            return response.ToArray();
        }
    }
}
