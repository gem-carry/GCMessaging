using System;
using System.Runtime.Serialization;

namespace GCMessaging
{
    [Serializable]
    public class CreateUserMessage : MessageBase
    {
        public string mUsername;
        public string mPassword;
        public string mPasswordValidate;

        public CreateUserMessage() { this.mType = MessageType.CREATEUSER; }

        // The special constructor is used to deserialize values.
        public CreateUserMessage(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            // Reset the property value using the GetValue method.
            mUsername = (string)info.GetValue("username", typeof(string));
            mPassword = (string)info.GetValue("password", typeof(string));
            mPasswordValidate = (string)info.GetValue("passwordvalidate", typeof(string));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            // Use the AddValue method to specify serialized values.
            info.AddValue("username", mUsername, typeof(string));
            info.AddValue("password", mPassword, typeof(string));
            info.AddValue("passwordvalidate", mPasswordValidate, typeof(string));
        }

    }
}