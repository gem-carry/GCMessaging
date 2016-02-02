//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;

// Generated from: generic.proto
namespace GCMessaging
{
    public enum MessageType
    {
        ConnectResponse = 0,
        LoginRequest = 1,
        LoginResponse = 2,
        ChatMessage = 3,
        CreateUserRequest = 4,
        CreateUserResponse = 5,
        MatchmakingRequest = 6,
        MatchmakingResponse = 7,
        Heartbeat = 8,
    }

  [Serializable, ProtoContract(Name=@"BaseMessage"),
    ProtoInclude(200, typeof(ConnectResponse)),
    ProtoInclude(201, typeof(LoginRequest)),
    ProtoInclude(202, typeof(LoginResponse)),
    ProtoInclude(203, typeof(ChatMessage)),
    ProtoInclude(204, typeof(CreateUserRequest)),
    ProtoInclude(205, typeof(CreateUserResponse)),
    ProtoInclude(206, typeof(MatchmakingRequest)),
    ProtoInclude(207, typeof(MatchmakingResponse)),
    ProtoInclude(208, typeof(Heartbeat)),
    ]
  abstract public class BaseMessage
  {
      abstract public ushort messageType { get; }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ConnectResponse")]
  public partial class ConnectResponse : BaseMessage
  {
    public ConnectResponse() {}

    public override ushort messageType
    {
        get { return (ushort)MessageType.ConnectResponse; }
    }
    
    private bool _success;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }
  }

    [Serializable, ProtoContract(Name=@"ChatMessage")]
    public partial class ChatMessage : BaseMessage
    {
        public ChatMessage() { }

        public override ushort messageType
        {
            get { return (ushort)MessageType.ChatMessage; }
        }

        private string _sender;
        [ProtoMember(1, IsRequired = true, Name=@"sender", DataFormat = DataFormat.Default)]
        public string sender
        {
            get { return _sender; }
            set { _sender = value; }
        }

        private string _message;
        [ProtoMember(2, IsRequired = true, Name = @"message", DataFormat = DataFormat.Default)]
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginRequest")]
  public partial class LoginRequest : BaseMessage
  {
    public LoginRequest() {}

    public override ushort messageType
    {
        get { return (ushort)MessageType.LoginRequest; }
    }
    
    private string _username;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginResponse")]
  public partial class LoginResponse : BaseMessage
  {
    public LoginResponse() {}

    public override ushort messageType
    {
        get { return (ushort)MessageType.LoginResponse; }
    }
    
    private bool _success;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateUserRequest")]
  public partial class CreateUserRequest : BaseMessage
  {
    public CreateUserRequest() {}

    public override ushort messageType
    {
        get { return (ushort)MessageType.CreateUserRequest; }
    }
    
    private string _username;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateUserResponse")]
  public partial class CreateUserResponse : BaseMessage
  {
    public CreateUserResponse() {}

    public override ushort messageType
    {
        get { return (ushort)MessageType.CreateUserResponse; }
    }
    
    private bool _success;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MatchmakingRequest")]
  public partial class MatchmakingRequest : BaseMessage
  {
    public MatchmakingRequest() {}

    public override ushort messageType
    {
        get { return (ushort)MessageType.MatchmakingRequest; }
    }
    
    private int _gameType = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"gameType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int gameType
    {
      get { return _gameType; }
      set { _gameType = value; }
    }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MatchmakingResponse")]
  public partial class MatchmakingResponse : BaseMessage
  {
    public MatchmakingResponse() {}

    public override ushort messageType
    {
        get { return (ushort)MessageType.MatchmakingResponse; }
    }
    
    private GCMessaging.MatchmakingResponse.MatchmakingStatus _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public GCMessaging.MatchmakingResponse.MatchmakingStatus status
    {
      get { return _status; }
      set { _status = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"MatchmakingStatus")]
    public enum MatchmakingStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SEARCHING", Value=0)]
      SEARCHING = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"JOINING_GAME", Value=1)]
      JOINING_GAME = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WAITING_FOR_PLAYERS", Value=2)]
      WAITING_FOR_PLAYERS = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GAME_SESSION_ACTIVE", Value=3)]
      GAME_SESSION_ACTIVE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GAME_END", Value=4)]
      GAME_END = 4
    }
  }

  [Serializable, ProtoContract(Name = @"ChatMessage")]
  public partial class Heartbeat : BaseMessage
  {
      public Heartbeat() { }

      public override ushort messageType
      {
          get { return (ushort)MessageType.Heartbeat; }
      }

      private bool _ack;
      [ProtoMember(1, IsRequired = false, Name = @"ack", DataFormat = DataFormat.Default)]
      public bool ack
      {
          get { return _ack; }
          set { _ack = value; }
      }
  }
  
}