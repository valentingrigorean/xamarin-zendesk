using System;
using ObjCRuntime;

[Native]
public enum ZDCPreChatDataRequirement : nuint
{
	NotRequired = 0,
	Optional = 1,
	Required = 2,
	OptionalEditable = 3,
	RequiredEditable = 4
}

[Native]
public enum ZDCFormCellType : nuint
{
	Name = 0,
	Email = 1,
	Phone = 2,
	Department = 3,
	Message = 4
}

[Native]
public enum ZDCFormDataStatus : nuint
{
	Ok = 0,
	Incomplete = 1,
	Invalid = 2
}

[Native]
public enum ZDCChatUIState : nuint
{
	Loading = 0,
	NoConnection = 1,
	CouldNotConnect = 2,
	NoAgents = 3,
	OfflineForm = 4,
	PreChatForm = 5,
	Chat = 6,
	ChatTimedOut = 7
}

[Native]
public enum ZDCChatBackgroundAnchor : nuint
{
	Center = 0,
	Top = 1
}

[Native]
public enum ZDCOverlayAlignment : nuint
{
	BottomLeft = 0,
	TopLeft = 1,
	TopRight = 2,
	BottomRight = 3
}
