


namespace Airship.Buffers;

public class Buffer : IBuffer
{
    private readonly MemoryStream _stream;
    private readonly BinaryReader _reader;
    private readonly BinaryWriter _writer;
    
    public byte[] Data { get; }

    public Buffer(byte[] data)
    {
        Data = data;
        _stream = new MemoryStream(Data);
        _reader = new BinaryReader(_stream);
        _writer = new BinaryWriter(_stream);
    }

    public Buffer() : this(Array.Empty<byte>()) {}
    
    public void Skip(long amount) => _stream.Position += amount;

    public IBuffer WriteByte(byte value)
    {
        _writer.Write(value);
        return this;
    }







}