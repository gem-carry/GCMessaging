using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMessaging
{
    [Serializable]
    public class LoginMessage : MessageBase
    {
        public string mUsername;
        public string mPassword;

        public LoginMessage() { this.mType = MessageType.LOGIN; }

        // The special constructor is used to deserialize values.
        public LoginMessage(SerializationInfo info, StreamingContext context):base(info,context)
        {
            // Reset the property value using the GetValue method.
            mUsername = (string)info.GetValue("username", typeof(string));
            mPassword = (string)info.GetValue("password", typeof(string));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            // Use the AddValue method to specify serialized values.
            info.AddValue("username", mUsername, typeof(string));
            info.AddValue("password", mPassword, typeof(string));
        }
    }    
}
