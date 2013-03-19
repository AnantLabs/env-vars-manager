using System;
using System.IO;
using System.Text;

namespace EnvVarsManager
{
  // Defines the data protocol for reading and writing strings on our stream
  public class StreamString
  {
    private Stream mStream;
    private UnicodeEncoding mStreamEncoding;

    public StreamString(Stream stream)
    {
      mStream = stream;
      mStreamEncoding = new UnicodeEncoding();
    }

    public string ReadString()
    {
      int len;
      len = mStream.ReadByte() * 256;
      if (len < 0)
        return null;
      len += mStream.ReadByte();
      byte[] inBuffer = new byte[len];
      mStream.Read(inBuffer, 0, len);

      return mStreamEncoding.GetString(inBuffer);
    }

    public int WriteString(string outString)
    {
      byte[] outBuffer = mStreamEncoding.GetBytes(outString);
      int len = outBuffer.Length;
      if (len > UInt16.MaxValue)
      {
        len = (int)UInt16.MaxValue;
      }
      mStream.WriteByte((byte)(len / 256));
      mStream.WriteByte((byte)(len & 255));
      mStream.Write(outBuffer, 0, len);
      mStream.Flush();

      return outBuffer.Length + 2;
    }
  }
}
