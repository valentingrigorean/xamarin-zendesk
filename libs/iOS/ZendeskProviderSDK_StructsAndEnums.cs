using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

static class CFunctions
{
	// void zdk_on_queue (dispatch_queue_t queue, dispatch_block_t block);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void zdk_on_queue (DispatchQueue queue, dispatch_block_t block);

	// void zdk_on_main_thread (dispatch_block_t block);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void zdk_on_main_thread (dispatch_block_t block);

	// extern NSDictionary * zdk_NilSafeNSDictionaryOfVariableBindings (NSString *commaSeparatedKeysString, id first, ...);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern NSDictionary zdk_NilSafeNSDictionaryOfVariableBindings (NSString commaSeparatedKeysString, NSObject first, IntPtr varArgs);
}

[Native]
public enum ZDKAPILoginState : nint
{
	NotLoggedIn,
	LoggingIn,
	LoggedIn
}

[Native]
public enum ZDKNavBarConversationsUIType : nuint
{
	LocalizedLabel,
	Image,
	None
}

[Native]
public enum ZDKHelpCenterOverviewGroupType : nuint
{
	Default,
	Section,
	Category
}

[Native]
public enum ZDKNetworkStatus : nuint
{
	NotReachable,
	ReachableViaWiFi,
	ReachableViaWWAN
}

[Native]
public enum ZDKTicketFieldType : nuint
{
	Subject,
	Description,
	Regex,
	TextArea,
	Text,
	Checkbox,
	ComboBox,
	Integer,
	Decimal,
	Date,
	CreditCard,
	Priority,
	Status,
	TicketType,
	MultiSelect,
	Unknown = (9223372036854775807L * 2 + 1)
}

[Native]
public enum ZDKValidation : nuint
{
	NilError,
	EmptyStringError
}

[Native]
public enum ZDKAuthenticationType : nuint
{
	Unknown,
	Jwt,
	Anonymous
}
