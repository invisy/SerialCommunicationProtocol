namespace Invisy.SerialCommunicationProtocol.Utils;

public interface ICrc16Calculator
{
    ushort Calculate(ReadOnlySpan<byte> data, int index, int count);
}