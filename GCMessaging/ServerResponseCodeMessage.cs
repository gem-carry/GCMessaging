using System;
using System.Runtime.Serialization;

namespace GCMessaging
{
    [Serializable]
    public class ServerResponseCodeMessage : MessageBase
    {
        public int mResponseCode;

        public ServerResponseCodeMessage() { this.mType = MessageType.SERVERRESPONSECODE; }

        public ServerResponseCodeMessage(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            mResponseCode = (int)info.GetValue("responsecode", typeof(int));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("responsecode", mResponseCode, typeof(int));
        }
    }
}

