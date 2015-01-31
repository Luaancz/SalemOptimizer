using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    // Made by Roman Starkov, https://bitbucket.org/rstarkov/demoxorshift
    public sealed class RndXorshift
    {
        const int BufferSize = 2048;

        public RndXorshift(Random rnd)
        {
            _x = (uint)rnd.Next();
            _y = (uint)rnd.Next();
            _z = (uint)rnd.Next();
            _w = (uint)rnd.Next();
        }

        int randomIndex = BufferSize;
        byte[] randomBuffer = new byte[BufferSize];

        public ushort Next()
        {
            if (randomIndex >= BufferSize)
            {
                randomIndex = 0;
                NextBytes(randomBuffer);
            }

            var a = (randomBuffer[randomIndex++] << 8);
            var b = (int)randomBuffer[randomIndex++];

            return (ushort)(a | b);
        }

        public void NextBytes(byte[] buffer)
        {
            int offset = 0;
            while (_bytes.Any() && offset < buffer.Length)
                buffer[offset++] = _bytes.Dequeue();

            int length = ((buffer.Length - offset) / FillBufferMultipleRequired) * FillBufferMultipleRequired;
            if (length > 0)
                FillBuffer(buffer, offset, offset + length);

            offset += length;
            while (offset < buffer.Length)
            {
                if (_bytes.Count == 0)
                {
                    uint t = _x ^ (_x << 11);
                    _x = _y; _y = _z; _z = _w;
                    _w = _w ^ (_w >> 19) ^ (t ^ (t >> 8));
                    _bytes.Enqueue((byte)(_w & 0xFF));
                    _bytes.Enqueue((byte)((_w >> 8) & 0xFF));
                    _bytes.Enqueue((byte)((_w >> 16) & 0xFF));
                    _bytes.Enqueue((byte)((_w >> 24) & 0xFF));
                }
                buffer[offset++] = _bytes.Dequeue();
            }
        }

        private uint _x = 123456789;
        private uint _y = 362436069;
        private uint _z = 521288629;
        private uint _w = 88675123;

        private int FillBufferMultipleRequired { get { return 16; } }

        private Queue<byte> _bytes = new Queue<byte>();

        private unsafe void FillBuffer(byte[] buf, int offset, int offsetEnd)
        {
            fixed (byte* pbytes = buf)
            {
                uint* pbuf = (uint*)(pbytes + offset);
                uint* pend = (uint*)(pbytes + offsetEnd);
                while (pbuf < pend)
                {
                    uint tx = _x ^ (_x << 11);
                    uint ty = _y ^ (_y << 11);
                    uint tz = _z ^ (_z << 11);
                    uint tw = _w ^ (_w << 11);
                    *(pbuf++) = _x = _w ^ (_w >> 19) ^ (tx ^ (tx >> 8));
                    *(pbuf++) = _y = _x ^ (_x >> 19) ^ (ty ^ (ty >> 8));
                    *(pbuf++) = _z = _y ^ (_y >> 19) ^ (tz ^ (tz >> 8));
                    *(pbuf++) = _w = _z ^ (_z >> 19) ^ (tw ^ (tw >> 8));
                }
            }
        }
    }

}