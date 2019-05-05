using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class DecoratorPattern
    {
        public static void Main()
        {
            Stream streamObj = new FileStream("", FileMode.Open);
            streamObj = new BufferedStream(streamObj);
        }
    }

    class LowercaseStream : Stream
    {
        Stream _stream;
        public LowercaseStream(Stream stream)
        {
            _stream = stream;
        }

        public override bool CanRead { get { throw new NotImplementedException(); } }

        public override bool CanSeek { get { throw new NotImplementedException(); } }

        public override bool CanWrite { get { throw new NotImplementedException(); } }

        public override long Length { get { throw new NotImplementedException(); } }

        public override long Position { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
            
        }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override int Read(byte[] array, int offset, int count)
        {
            return 0;
        }

        public override int ReadByte()
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] array, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override void WriteByte(byte value)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

    }
}
