using Invisy.SerialCommunicationProtocol.Models;

namespace Invisy.SerialCommunicationProtocol.Exceptions;

public class CommandResponseException : CommandException
{
    public CommandResponse ResponseCode { get; }

    public CommandResponseException(CommandResponse response) : 
        base($"Command was not proceed successfully by device. Response code: {response}")
    {
        ResponseCode = response;
    }
}