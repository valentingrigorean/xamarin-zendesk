using System;
using ObjCRuntime;

[Native]
public enum ZDCChatRating : nuint
{
	Unrated = 0,
	None = 1,
	Good = 2,
	Bad = 3
}

[Native]
public enum ZDCChatSessionStatus : nuint
{
	Inactive = 0,
	Connected = 1,
	Chatting = 2,
	TimedOut = 3
}

[Native]
public enum ZDCEmailTranscriptAction : nuint
{
	Prompt = 0,
	NeverSend = 1
}

[Native]
public enum ZDCConnectionStatus : nuint
{
	Uninitialized = 0,
	Connecting = 1,
	Connected = 2,
	Closed = 3,
	Disconnected = 4,
	NoConnection = 5
}

[Native]
public enum ZDCLogLevel : nuint
{
	Error = 0,
	Warn = 1,
	Info = 2,
	Debug = 3,
	Verbose = 4
}

[Native]
public enum ZDCFileTransferStatus : nuint
{
	Pending = 0,
	Transfering = 1,
	Complete = 2,
	Error = 3
}

[Native]
public enum ZDCTransferError : nuint
{
	ErrorNone = 0,
	ErrorType = 1,
	ErrorSize = 2,
	ErrorAccess = 3,
	ErrorInvalid = 4,
	ErrorFailed = 5,
	FileSendingDisabled = 6,
	ErrorUnknown = 1000
}

[Native]
public enum ZDCChatEventType : nuint
{
	Unknown = 0,
	MemberJoin = 1,
	MemberLeave = 2,
	SystemMessage = 3,
	TriggerMessage = 4,
	AgentMessage = 5,
	VisitorMessage = 6,
	VisitorUpload = 7,
	AgentUpload = 8,
	Rating = 9,
	RatingComment = 10
}
