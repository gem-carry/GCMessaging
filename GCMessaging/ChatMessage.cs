using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMessaging
{
    [Serializable]
    public class ChatMessage : MessageBase
    {
        public string mSender;
        public string mMessage;

        public ChatMessage() { this.mType = MessageType.CHAT; }

        // The special constructor is used to deserialize values.
        public ChatMessage(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            // Reset the property value using the GetValue method.
            mSender = (string)info.GetValue("sender", typeof(string));
            mMessage = (string)info.GetValue("message", typeof(string));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            // Use the AddValue method to specify serialized values.
            info.AddValue("sender", mSender, typeof(string));
            info.AddValue("message", mMessage, typeof(string));
        }
    }
}
