using Invisy.SerialCommunicationProtocol.Models;

namespace Invisy.SerialCommunicationProtocol.Factories;

public interface ISerialCommunicationClientFactory
{
    ISerialCommunicationClient Create(SerialPortSettings portSettings);
    ISerialCommunicationClient Create(SerialPortSettings portSettings, int responseTimeout);
}