namespace Airship.Packet;

public interface IPacket
{ 
    /// <summary>
    /// The Operation Code (OpCode) used for packet handling and identification.
    /// Occupies the first 2 bytes (short) of a packet.
    /// </summary>
    short Operation { get; }
}