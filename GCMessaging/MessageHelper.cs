using System;
using System.IO;

namespace GCMessaging
{
    public static class MessageHelper
    {
        public static byte[] EOM = { 0xDE, 0xAD, 0xBE, 0xEF };

        public static int FindEOM(byte[] data)
        {
            int found = -1;

            for (int i = 3; i < data.Length; ++i )
            {
                if( (data[i-3] == EOM[0]) &&
                    (data[i-2] == EOM[1]) &&
                    (data[i-1] == EOM[2]) &&
                    (data[i]   == EOM[3]) )
                {
                    found = i;
                    break;
                }
            }

            return found;
        }

        public static void AppendEOM(byte[] inData, out byte[] outData)
        {
            MemoryStream stream = new MemoryStream();
            stream.Position = 0;
            stream.Write(inData, 0, inData.Length);
            stream.Write(EOM, 0, EOM.Length);
            outData = stream.ToArray();
        }

        public static void RemoveEOM(byte[] inData, out byte[] outData)
        {
            int newLength = inData.Length - EOM.Length;
            outData = new byte[newLength];
            Array.Copy(inData, 0, outData, 0, newLength);
        }

        public static void ClearMessageFromStream(int eomEndIdx, byte[] inData, out byte[] message, out byte[] outData)
        {
            int msgLength = eomEndIdx + 1 - EOM.Length;
            int newLength = inData.Length - 1 - eomEndIdx;

            message = new byte[msgLength];
            outData = null;

            Array.Copy(inData, 0, message, 0, msgLength);

            if (newLength > 0)
            {
                outData = new byte[newLength];
                Array.Copy(inData, eomEndIdx + 1, outData, 0, newLength);
            }
        }

        /// <summary>
        /// Pass in an ending index of a message and the buffer it is from,
        /// this function will remove that message from the buffer and serve it out
        /// as well as return the new size of any unread bytes in buffer
        /// </summary>
        /// <param name="eomEndIdx">The index of the end of the message found</param>
        /// <param name="buffer">The buffer the message is in</param>
        /// <param name="bufferSize">The current buffer size</param>
        /// <param name="message">The message bytes</param>
        /// <returns>int - The NEW buffer size after removing message</returns>
        public static int PullMessageFromBuffer(int eomEndIdx, byte[] buffer, int bufferSize, out byte[] message)
        {
            int msgLength = (eomEndIdx + 1) - EOM.Length;
            int newBufferSize = bufferSize - (eomEndIdx + 1);

            message = new byte[msgLength];

            Array.Copy(buffer, 0, message, 0, msgLength);

            if (newBufferSize > 0)
            {
                Array.Copy(buffer, bufferSize, buffer, 0, newBufferSize);
            }
            return newBufferSize;
        }
    }
}
