


namespace Airship.Buffers;

public class SimpleByteBuffer : IByteBuffer
{
    private readonly MemoryStream _stream;
    private readonly BinaryReader _reader;
    private readonly BinaryWriter _writer;
    
    public byte[] Buffer { get; }

    public SimpleByteBuffer(byte[] buffer)
    {
        Buffer = buffer;
        _stream = new MemoryStream(Buffer);
        _reader = new BinaryReader(_stream);
        _writer = new BinaryWriter(_stream);
    }

    public SimpleByteBuffer() : this(Array.Empty<byte>()) {}
    
    public void Skip(long amount) => _stream.Position += amount;

    public IByteBuffer WriteByte(byte value)
    {
        _writer.Write(value);
        return this;
    }

    public IByteBuffer WriteShort(short value)
    {
        _writer.Write(value);
        return this;
    } 







}