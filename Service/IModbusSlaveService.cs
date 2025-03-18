using LittleFancyTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Service
{
    public interface IModbusSlaveService
    {
        public byte[] ProcessReadCoils(byte slaveAddress, ushort startAddress, ushort quantity, List<SlaveTable> dataList);
        public byte[] ProcessReadDiscreteInputs(byte slaveAddress, ushort startAddress, ushort quantity, List<SlaveTable> dataList);
        public byte[] ProcessReadHoldingRegisters(byte slaveAddress, ushort startAddress, ushort quantity, List<SlaveTable> dataList);
        public byte[] ProcessReadInputRegisters(byte slaveAddress, ushort startAddress, ushort quantity, List<SlaveTable> dataList);

    }
}
