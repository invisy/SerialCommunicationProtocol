using System.IO.Ports;

namespace Invisy.SerialCommunicationProtocol.Models;

public class SerialPortSettings
{
    public SerialPortSettings(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
    {
        PortName = portName;
        BaudRate = baudRate;
        Parity = parity;
        DataBits = dataBits;
        StopBits = stopBits;
    }

    public string PortName { get; }
    public int BaudRate { get;  }
    public Parity Parity { get;  }
    public int DataBits { get; }
    public StopBits StopBits { get; }
}