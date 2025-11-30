using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using Modbus.Device;

namespace GPUN_1
{
    //internal class PLCController
    //{

    //}
    public class PLCController
    {
        private SerialPort serialPort;
        private ModbusSerialMaster master;

        public bool IsConnected => serialPort != null && serialPort.IsOpen;

        public void Connect(string portName, int baudrate, Parity parity,int DataBits, StopBits stopBits)
        {
            serialPort = new SerialPort(portName, baudrate, parity, DataBits, stopBits);
            serialPort.Open();
            master = ModbusSerialMaster.CreateRtu(serialPort);
        }

        public void Disconnect()
        {
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Close();
        }

        public void WriteCoil(byte slaveID, ushort coilAddress, bool value)
        {
             master.WriteSingleCoil(slaveID, coilAddress, value);
        }

        public bool[] ReadCoils(byte slaveID, ushort startAddress, ushort num)
        {
            if (!IsConnected)
                throw new Exception("Chưa kết nối PLC!");
            return master.ReadCoils(slaveID, startAddress, num);
        }

        public ushort[] ReadHoldingRegisters(byte slaveID, ushort startAddress, ushort num)
        {
            if (!IsConnected)
                throw new Exception("Chưa kết nối PLC!");
            return master.ReadHoldingRegisters(slaveID, startAddress, num);
        }
    }
}
