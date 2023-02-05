namespace Airship.Buffers;

public interface IByteBuffer
{
    /// <summary>
    /// The given byte buffer.
    /// </summary>
    byte[] Buffer { get; }
}