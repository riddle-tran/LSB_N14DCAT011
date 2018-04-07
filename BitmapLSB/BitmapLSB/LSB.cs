using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BitmapLSB
{
    class LSB
    {
        public static byte Extract(byte b, int x)
        {
            return (byte)((b & (1 << x)) >> x);
        }

        public static void Replace(ref byte b, int x, byte value)
        {
            b = (byte)(value == 1 ? b | (1 << x) : b & ~(1 << x));
        }

        public static void Encode(FileStream inStream, byte[] message, FileStream outStream)
        {
            int byteRead, i = 0, j = 0;
            byte byteWrite;
            while ((byteRead = inStream.ReadByte()) != -1)
            {
                byteWrite = (byte)byteRead;

                if (i < message.Length)
                {
                    byte bit = Extract(message[i], j++);
                    Replace(ref byteWrite, 0, bit);
                    if (j == 8)
                    {
                        j = 0;
                        i++;
                    }
                }
                outStream.WriteByte(byteWrite);
            }
        }

        public static byte[] Decode(FileStream inStream, int length)
        {
            int byteIndex = 0, bitIndex = 0, byteRead;
            byte[] result = new byte[length];
            while ((byteRead = inStream.ReadByte()) != -1)
            {
                byte bit = Extract((byte)byteRead, 0);
                Replace(ref result[byteIndex], bitIndex++, bit);
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
                if (byteIndex == length)
                    break;
            }
            return result;
        }
    }
}
