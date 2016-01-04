using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    found = i - 3;
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
    }
}
