using System;
using System.Runtime.Serialization;


namespace GCMessaging
{
    public enum MessageType
    {
        HEARTBEAT = 0,
        LOGIN = 1,
        CREATEUSER = 2,
        CHAT = 3,
        JOINSESSION = 4,
    }

    [Serializable]
    public class MessageBase : ISerializable
    {
        public MessageType mType;

        public MessageBase() { this.mType = MessageType.HEARTBEAT; }

        // The special constructor is used to deserialize values.
        public MessageBase(SerializationInfo info, StreamingContext context)
        {
            // Reset the property value using the GetValue method.
            mType = (MessageType)info.GetValue("messageType", typeof(MessageType));
        }

        // Implement this method to serialize data. The method is called 
        // on serialization.
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("messageType", mType, typeof(MessageType));
        }
    }
}
