using Airship.Buffers;
using Buffer = Airship.Buffers.SimpleByteBuffer;

namespace Airship.Packet;

public class Packet : SimpleByteBuffer, IPacket
{
    public short Operation { get; private set; }

    /// <summary>
    /// Create a new instance of a Packet and sets the base buffer to the supplied buffer.
    /// </summary>
    /// <param name="buffer">The supplied buffer.</param>
    public Packet(byte[] buffer) : base(buffer) { }
    
    /// <summary>
    /// Create a new instance of a Packet and writes the given Operation Code to the base buffer.
    /// </summary>
    /// <param name="operation">The Operation Code to write.</param>
    public Packet(short operation)
    {
        Operation = operation;
        WriteShort(operation);
    }

    /// <summary>
    /// Create a new instance of a Packet with an empty base buffer.
    /// </summary>
    /// <returns></returns>
    public static IPacket Empty() => new Packet(Array.Empty<byte>());

    /// <summary>
    /// Sets the Operation Code of the current Packet instance to the supplied Operation Code.
    /// </summary>
    /// <param name="operation">The Supplied Operation Code</param>
    /// <returns>The current instance of type </returns>
    public IPacket WithOperation(short operation)
    {
        Operation = operation;
        return this;
    }
    
    



}