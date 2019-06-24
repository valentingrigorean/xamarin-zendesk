using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using ZDCChat;
using ZDCChatAPI;

// @interface ZDCPreChatData : NSObject
[BaseType (typeof(NSObject))]
interface ZDCPreChatData
{
	// @property (assign, nonatomic) ZDCPreChatDataRequirement name;
	[Export ("name", ArgumentSemantic.Assign)]
	ZDCPreChatDataRequirement Name { get; set; }

	// @property (assign, nonatomic) ZDCPreChatDataRequirement email;
	[Export ("email", ArgumentSemantic.Assign)]
	ZDCPreChatDataRequirement Email { get; set; }

	// @property (assign, nonatomic) ZDCPreChatDataRequirement phone;
	[Export ("phone", ArgumentSemantic.Assign)]
	ZDCPreChatDataRequirement Phone { get; set; }

	// @property (assign, nonatomic) ZDCPreChatDataRequirement department;
	[Export ("department", ArgumentSemantic.Assign)]
	ZDCPreChatDataRequirement Department { get; set; }

	// @property (assign, nonatomic) ZDCPreChatDataRequirement message;
	[Export ("message", ArgumentSemantic.Assign)]
	ZDCPreChatDataRequirement Message { get; set; }
}

// @interface ZDCConfig : NSObject
[BaseType (typeof(NSObject))]
interface ZDCConfig
{
	// @property (nonatomic, strong) NSString * visitorPathOne;
	[Export ("visitorPathOne", ArgumentSemantic.Strong)]
	string VisitorPathOne { get; set; }

	// @property (nonatomic, strong) NSString * visitorPathTwo;
	[Export ("visitorPathTwo", ArgumentSemantic.Strong)]
	string VisitorPathTwo { get; set; }

	// @property (nonatomic, strong) NSString * department;
	[Export ("department", ArgumentSemantic.Strong)]
	string Department { get; set; }

	// @property (nonatomic, strong) NSArray<NSString *> * tags;
	[Export ("tags", ArgumentSemantic.Strong)]
	string[] Tags { get; set; }

	// @property (nonatomic, strong) ZDCPreChatData * preChatDataRequirements;
	[Export ("preChatDataRequirements", ArgumentSemantic.Strong)]
	ZDCPreChatData PreChatDataRequirements { get; set; }

	// @property (assign, nonatomic) BOOL uploadAttachmentsEnabled;
	[Export ("uploadAttachmentsEnabled")]
	bool UploadAttachmentsEnabled { get; set; }

	// @property (assign, nonatomic) ZDCEmailTranscriptAction emailTranscriptAction;
	[Export ("emailTranscriptAction", ArgumentSemantic.Assign)]
	ZDCEmailTranscriptAction EmailTranscriptAction { get; set; }

	// @property (assign, nonatomic) NSTimeInterval connectionTimeout;
	[Export ("connectionTimeout")]
	double ConnectionTimeout { get; set; }

	// @property (assign, nonatomic) NSTimeInterval reconnectionTimeout;
	[Export ("reconnectionTimeout")]
	double ReconnectionTimeout { get; set; }
}

// @interface ZDCOfflineMessageHandler : NSObject
[BaseType (typeof(NSObject))]
interface ZDCOfflineMessageHandler
{
	// @property (nonatomic, strong) NSString * noAgentsMessage;
	[Export ("noAgentsMessage", ArgumentSemantic.Strong)]
	string NoAgentsMessage { get; set; }

	// @property (nonatomic, strong) NSString * noAgentsButtonText;
	[Export ("noAgentsButtonText", ArgumentSemantic.Strong)]
	string NoAgentsButtonText { get; set; }

	// +(instancetype)offlineHandlerWithMessage:(NSString *)noAgentsMessage buttonText:(NSString *)noAgentsButtonText;
	[Static]
	[Export ("offlineHandlerWithMessage:buttonText:")]
	ZDCOfflineMessageHandler OfflineHandlerWithMessage (string noAgentsMessage, string noAgentsButtonText);
}

// @interface ZDUViewController : UIViewController
[BaseType (typeof(UIViewController))]
interface ZDUViewController
{
	// @property (assign, nonatomic) CGFloat keyboardHeight;
	[Export ("keyboardHeight")]
	nfloat KeyboardHeight { get; set; }

	// @property (assign, nonatomic) BOOL requiresNavBar;
	[Export ("requiresNavBar")]
	bool RequiresNavBar { get; set; }

	// @property (nonatomic, strong) UIView * contentView;
	[Export ("contentView", ArgumentSemantic.Strong)]
	UIView ContentView { get; set; }

	// @property (assign, nonatomic) CGFloat toastHeight;
	[Export ("toastHeight")]
	nfloat ToastHeight { get; set; }

	// -(void)registerForKeyboardNotifications;
	[Export ("registerForKeyboardNotifications")]
	void RegisterForKeyboardNotifications ();

	// -(void)keyboardDidShow:(NSNotification *)aNotification;
	[Export ("keyboardDidShow:")]
	void KeyboardDidShow (NSNotification aNotification);

	// -(void)keyboardWillHide:(NSNotification *)aNotification;
	[Export ("keyboardWillHide:")]
	void KeyboardWillHide (NSNotification aNotification);

	// -(void)dismissActiveToast:(BOOL)animated;
	[Export ("dismissActiveToast:")]
	void DismissActiveToast (bool animated);

	// -(CGFloat)topViewOffset;
	[Export ("topViewOffset")]
	[Verify (MethodToProperty)]
	nfloat TopViewOffset { get; }

	// -(CGFloat)bottomViewOffset;
	[Export ("bottomViewOffset")]
	[Verify (MethodToProperty)]
	nfloat BottomViewOffset { get; }

	// -(void)viewWillBeDismissed;
	[Export ("viewWillBeDismissed")]
	void ViewWillBeDismissed ();

	// +(UIViewController *)topViewController;
	[Static]
	[Export ("topViewController")]
	[Verify (MethodToProperty)]
	UIViewController TopViewController { get; }

	// +(UIViewController *)topViewControllerWithRootViewController:(UIViewController *)rootViewController;
	[Static]
	[Export ("topViewControllerWithRootViewController:")]
	UIViewController TopViewControllerWithRootViewController (UIViewController rootViewController);

	// +(void)presentViewController:(UIViewController *)viewController requiresNavController:(BOOL)requiresNav;
	[Static]
	[Export ("presentViewController:requiresNavController:")]
	void PresentViewController (UIViewController viewController, bool requiresNav);
}

// @interface ZDCLoadingView : UIView
[BaseType (typeof(UIView))]
interface ZDCLoadingView
{
	// @property (nonatomic, strong) UIActivityIndicatorView * spinner;
	[Export ("spinner", ArgumentSemantic.Strong)]
	UIActivityIndicatorView Spinner { get; set; }

	// @property (nonatomic, strong) UILabel * loadingLabel;
	[Export ("loadingLabel", ArgumentSemantic.Strong)]
	UILabel LoadingLabel { get; set; }

	// @property (nonatomic, strong) UIFont * loadingLabelFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("loadingLabelFont", ArgumentSemantic.Strong)]
	UIFont LoadingLabelFont { get; set; }

	// @property (nonatomic, strong) UIColor * loadingLabelTextColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("loadingLabelTextColor", ArgumentSemantic.Strong)]
	UIColor LoadingLabelTextColor { get; set; }

	// @property (nonatomic, strong) UIColor * loadingBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("loadingBackgroundColor", ArgumentSemantic.Strong)]
	UIColor LoadingBackgroundColor { get; set; }

	// -(void)show;
	[Export ("show")]
	void Show ();

	// -(void)hide;
	[Export ("hide")]
	void Hide ();
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const float ZDC_DEFAULT_FORM_CELL_HEIGHT;
	[Field ("ZDC_DEFAULT_FORM_CELL_HEIGHT", "__Internal")]
	float ZDC_DEFAULT_FORM_CELL_HEIGHT { get; }
}

// @protocol ZDCFormCellDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDCFormCellDelegate
{
	// @required -(void)updatedValue:(NSString *)value forType:(ZDCFormCellType)type;
	[Abstract]
	[Export ("updatedValue:forType:")]
	void UpdatedValue (string value, ZDCFormCellType type);

	// @required -(void)scrollToType:(ZDCFormCellType)type;
	[Abstract]
	[Export ("scrollToType:")]
	void ScrollToType (ZDCFormCellType type);

	// @required -(void)goToNextType:(ZDCFormCellType)currentType;
	[Abstract]
	[Export ("goToNextType:")]
	void GoToNextType (ZDCFormCellType currentType);
}

// @interface ZDCFormCell : UITableViewCell
[BaseType (typeof(UITableViewCell))]
interface ZDCFormCell
{
	// @property (assign, nonatomic) ZDCFormCellType type;
	[Export ("type", ArgumentSemantic.Assign)]
	ZDCFormCellType Type { get; set; }

	[Wrap ("WeakDelegate")]
	ZDCFormCellDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<ZDCFormCellDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic, strong) UIView * textFrame;
	[Export ("textFrame", ArgumentSemantic.Strong)]
	UIView TextFrame { get; set; }

	// @property (nonatomic, strong) NSValue * textFrameInsets __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFrameInsets", ArgumentSemantic.Strong)]
	NSValue TextFrameInsets { get; set; }

	// @property (nonatomic, strong) NSValue * textInsets __attribute__((annotate("ui_appearance_selector")));
	[Export ("textInsets", ArgumentSemantic.Strong)]
	NSValue TextInsets { get; set; }

	// @property (nonatomic, strong) UIColor * textFrameBorderColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFrameBorderColor", ArgumentSemantic.Strong)]
	UIColor TextFrameBorderColor { get; set; }

	// @property (nonatomic, strong) UIColor * textFrameErrorBorderColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFrameErrorBorderColor", ArgumentSemantic.Strong)]
	UIColor TextFrameErrorBorderColor { get; set; }

	// @property (nonatomic, strong) UIColor * textFrameBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFrameBackgroundColor", ArgumentSemantic.Strong)]
	UIColor TextFrameBackgroundColor { get; set; }

	// @property (nonatomic, strong) NSNumber * textFrameCornerRadius __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFrameCornerRadius", ArgumentSemantic.Strong)]
	NSNumber TextFrameCornerRadius { get; set; }

	// @property (nonatomic, strong) UIFont * textFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFont", ArgumentSemantic.Strong)]
	UIFont TextFont { get; set; }

	// @property (nonatomic, strong) UIColor * textColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textColor", ArgumentSemantic.Strong)]
	UIColor TextColor { get; set; }

	// -(void)prepareWithText:(NSString *)text forType:(ZDCFormCellType)type withDelegate:(id<ZDCFormCellDelegate>)delegate highlightError:(BOOL)highlight;
	[Export ("prepareWithText:forType:withDelegate:highlightError:")]
	void PrepareWithText (string text, ZDCFormCellType type, ZDCFormCellDelegate @delegate, bool highlight);

	// -(CGFloat)heightForText:(NSString *)text givenWidth:(CGFloat)width;
	[Export ("heightForText:givenWidth:")]
	nfloat HeightForText (string text, nfloat width);

	// -(id)appearance:(SEL)sel def:(id)defaultVal;
	[Export ("appearance:def:")]
	NSObject Appearance (Selector sel, NSObject defaultVal);

	// -(void)setupAppearance;
	[Export ("setupAppearance")]
	void SetupAppearance ();

	// -(void)setupTextFrame;
	[Export ("setupTextFrame")]
	void SetupTextFrame ();
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString *const ZDC_FORMCELL_SINGLELINE;
	[Field ("ZDC_FORMCELL_SINGLELINE", "__Internal")]
	NSString ZDC_FORMCELL_SINGLELINE { get; }

	// extern NSString *const ZDC_FORMCELL_DEPARTMENT;
	[Field ("ZDC_FORMCELL_DEPARTMENT", "__Internal")]
	NSString ZDC_FORMCELL_DEPARTMENT { get; }

	// extern NSString *const ZDC_FORMCELL_MESSAGE;
	[Field ("ZDC_FORMCELL_MESSAGE", "__Internal")]
	NSString ZDC_FORMCELL_MESSAGE { get; }
}

// @interface ZDCPreChatFormView : UIView <UITextViewDelegate, UITableViewDataSource, UITableViewDelegate, ZDCFormCellDelegate>
[BaseType (typeof(UIView))]
interface ZDCPreChatFormView : IUITextViewDelegate, IUITableViewDataSource, IUITableViewDelegate, IZDCFormCellDelegate
{
	// @property (readonly, nonatomic, weak) id<ZDCVisitorActionDelegate> chatController;
	[Export ("chatController", ArgumentSemantic.Weak)]
	ZDCVisitorActionDelegate ChatController { get; }

	// @property (nonatomic, strong) UITableView * formTable;
	[Export ("formTable", ArgumentSemantic.Strong)]
	UITableView FormTable { get; set; }

	// @property (nonatomic, strong) NSString * nameText;
	[Export ("nameText", ArgumentSemantic.Strong)]
	string NameText { get; set; }

	// @property (nonatomic, strong) NSString * emailText;
	[Export ("emailText", ArgumentSemantic.Strong)]
	string EmailText { get; set; }

	// @property (nonatomic, strong) NSString * phoneText;
	[Export ("phoneText", ArgumentSemantic.Strong)]
	string PhoneText { get; set; }

	// @property (nonatomic, strong) NSString * messageText;
	[Export ("messageText", ArgumentSemantic.Strong)]
	string MessageText { get; set; }

	// @property (nonatomic, strong) NSString * selectedDepartment;
	[Export ("selectedDepartment", ArgumentSemantic.Strong)]
	string SelectedDepartment { get; set; }

	// @property (nonatomic, strong) UIColor * formBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("formBackgroundColor", ArgumentSemantic.Strong)]
	UIColor FormBackgroundColor { get; set; }

	// -(instancetype)initWithFrame:(CGRect)frame withController:(id<ZDCVisitorActionDelegate>)controller;
	[Export ("initWithFrame:withController:")]
	IntPtr Constructor (CGRect frame, ZDCVisitorActionDelegate controller);

	// -(void)prepareForm;
	[Export ("prepareForm")]
	void PrepareForm ();

	// -(BOOL)formComplete;
	[Export ("formComplete")]
	[Verify (MethodToProperty)]
	bool FormComplete { get; }

	// +(ZDCFormDataStatus)fieldValid:(ZDCFormCellType)type value:(NSString *)currentValue formRows:(NSArray *)rows requirement:(ZDCPreChatDataRequirement)requirement;
	[Static]
	[Export ("fieldValid:value:formRows:requirement:")]
	[Verify (StronglyTypedNSArray)]
	ZDCFormDataStatus FieldValid (ZDCFormCellType type, string currentValue, NSObject[] rows, ZDCPreChatDataRequirement requirement);

	// -(void)registerClass:(Class)cellClass forCellReuseIdentifier:(NSString *)identifier;
	[Export ("registerClass:forCellReuseIdentifier:")]
	void RegisterClass (Class cellClass, string identifier);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGFloat ZDC_TEXTENTRY_MINIMUM_HEIGHT;
	[Field ("ZDC_TEXTENTRY_MINIMUM_HEIGHT", "__Internal")]
	nfloat ZDC_TEXTENTRY_MINIMUM_HEIGHT { get; }
}

// @protocol ZDCTextEntryViewDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDCTextEntryViewDelegate
{
	// @required -(void)sendButtonPressed;
	[Abstract]
	[Export ("sendButtonPressed")]
	void SendButtonPressed ();

	// @required -(void)attachButtonPressed;
	[Abstract]
	[Export ("attachButtonPressed")]
	void AttachButtonPressed ();
}

// @interface ZDCTextEntryView : UIView
[BaseType (typeof(UIView))]
interface ZDCTextEntryView
{
	[Wrap ("WeakDelegate")]
	ZDCTextEntryViewDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<ZDCTextEntryViewDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic, strong) UIView * topBorder;
	[Export ("topBorder", ArgumentSemantic.Strong)]
	UIView TopBorder { get; set; }

	// @property (nonatomic, strong) UIView * textViewBackground;
	[Export ("textViewBackground", ArgumentSemantic.Strong)]
	UIView TextViewBackground { get; set; }

	// @property (nonatomic, strong) ZDUTextView * textView;
	[Export ("textView", ArgumentSemantic.Strong)]
	ZDUTextView TextView { get; set; }

	// @property (nonatomic, strong) UIButton * attachButton;
	[Export ("attachButton", ArgumentSemantic.Strong)]
	UIButton AttachButton { get; set; }

	// @property (nonatomic, strong) UIButton * sendButton;
	[Export ("sendButton", ArgumentSemantic.Strong)]
	UIButton SendButton { get; set; }

	// @property (nonatomic, strong) NSString * sendButtonImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("sendButtonImage", ArgumentSemantic.Strong)]
	string SendButtonImage { get; set; }

	// @property (nonatomic, strong) NSString * attachButtonImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("attachButtonImage", ArgumentSemantic.Strong)]
	string AttachButtonImage { get; set; }

	// @property (nonatomic, strong) UIColor * topBorderColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("topBorderColor", ArgumentSemantic.Strong)]
	UIColor TopBorderColor { get; set; }

	// @property (nonatomic, strong) UIFont * textEntryFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("textEntryFont", ArgumentSemantic.Strong)]
	UIFont TextEntryFont { get; set; }

	// @property (nonatomic, strong) UIColor * textEntryColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textEntryColor", ArgumentSemantic.Strong)]
	UIColor TextEntryColor { get; set; }

	// @property (nonatomic, strong) UIColor * textEntryBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textEntryBackgroundColor", ArgumentSemantic.Strong)]
	UIColor TextEntryBackgroundColor { get; set; }

	// @property (nonatomic, strong) UIColor * textEntryBorderColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textEntryBorderColor", ArgumentSemantic.Strong)]
	UIColor TextEntryBorderColor { get; set; }

	// @property (nonatomic, strong) UIColor * areaBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("areaBackgroundColor", ArgumentSemantic.Strong)]
	UIColor AreaBackgroundColor { get; set; }

	// -(instancetype)initWithFrame:(CGRect)frame;
	[Export ("initWithFrame:")]
	IntPtr Constructor (CGRect frame);

	// -(CGFloat)preferredHeight;
	[Export ("preferredHeight")]
	[Verify (MethodToProperty)]
	nfloat PreferredHeight { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString *const ZDC_CHATCELL_AGENT;
	[Field ("ZDC_CHATCELL_AGENT", "__Internal")]
	NSString ZDC_CHATCELL_AGENT { get; }

	// extern NSString *const ZDC_CHATCELL_AGENT_ATTACH;
	[Field ("ZDC_CHATCELL_AGENT_ATTACH", "__Internal")]
	NSString ZDC_CHATCELL_AGENT_ATTACH { get; }

	// extern NSString *const ZDC_CHATCELL_VISITOR;
	[Field ("ZDC_CHATCELL_VISITOR", "__Internal")]
	NSString ZDC_CHATCELL_VISITOR { get; }

	// extern NSString *const ZDC_CHATCELL_VISITOR_ATTACH;
	[Field ("ZDC_CHATCELL_VISITOR_ATTACH", "__Internal")]
	NSString ZDC_CHATCELL_VISITOR_ATTACH { get; }

	// extern NSString *const ZDC_CHATCELL_JOINLEAVE;
	[Field ("ZDC_CHATCELL_JOINLEAVE", "__Internal")]
	NSString ZDC_CHATCELL_JOINLEAVE { get; }

	// extern NSString *const ZDC_CHATCELL_TIMEOUT;
	[Field ("ZDC_CHATCELL_TIMEOUT", "__Internal")]
	NSString ZDC_CHATCELL_TIMEOUT { get; }

	// extern NSString *const ZDC_CHATCELL_TYPING;
	[Field ("ZDC_CHATCELL_TYPING", "__Internal")]
	NSString ZDC_CHATCELL_TYPING { get; }

	// extern NSString *const ZDC_CHATCELL_SYSTEM_TRIGGER;
	[Field ("ZDC_CHATCELL_SYSTEM_TRIGGER", "__Internal")]
	NSString ZDC_CHATCELL_SYSTEM_TRIGGER { get; }

	// extern NSString *const ZDC_CHATCELL_RATING;
	[Field ("ZDC_CHATCELL_RATING", "__Internal")]
	NSString ZDC_CHATCELL_RATING { get; }

	// extern NSString *const ZDC_CHATCELL_OPTIONS;
	[Field ("ZDC_CHATCELL_OPTIONS", "__Internal")]
	NSString ZDC_CHATCELL_OPTIONS { get; }

	// extern NSString *const ZDC_CHATCELL_OFFLINE;
	[Field ("ZDC_CHATCELL_OFFLINE", "__Internal")]
	NSString ZDC_CHATCELL_OFFLINE { get; }
}

// @interface ZDCChatView : UIView <UITableViewDataSource, UITableViewDelegate, UITextViewDelegate, ZDCTextEntryViewDelegate, UINavigationControllerDelegate, UIPopoverControllerDelegate>
[BaseType (typeof(UIView))]
interface ZDCChatView : IUITableViewDataSource, IUITableViewDelegate, IUITextViewDelegate, IZDCTextEntryViewDelegate, IUINavigationControllerDelegate, IUIPopoverControllerDelegate
{
	// @property (readonly, nonatomic, weak) id<ZDCVisitorActionDelegate> chatController;
	[Export ("chatController", ArgumentSemantic.Weak)]
	ZDCVisitorActionDelegate ChatController { get; }

	// @property (readonly, nonatomic, strong) UITableView * table;
	[Export ("table", ArgumentSemantic.Strong)]
	UITableView Table { get; }

	// @property (readonly, nonatomic, strong) ZDCTextEntryView * textEntryView;
	[Export ("textEntryView", ArgumentSemantic.Strong)]
	ZDCTextEntryView TextEntryView { get; }

	// @property (assign, nonatomic) BOOL timedOut;
	[Export ("timedOut")]
	bool TimedOut { get; set; }

	// @property (nonatomic, strong) ZDCMessageMonitor * messageMonitor;
	[Export ("messageMonitor", ArgumentSemantic.Strong)]
	ZDCMessageMonitor MessageMonitor { get; set; }

	// @property (nonatomic, strong) UIColor * chatBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("chatBackgroundColor", ArgumentSemantic.Strong)]
	UIColor ChatBackgroundColor { get; set; }

	// -(instancetype)initWithFrame:(CGRect)frame withController:(id<ZDCVisitorActionDelegate>)controller;
	[Export ("initWithFrame:withController:")]
	IntPtr Constructor (CGRect frame, ZDCVisitorActionDelegate controller);

	// -(void)activate;
	[Export ("activate")]
	void Activate ();

	// -(void)registerClass:(Class)cellClass forCellReuseIdentifier:(NSString *)identifier;
	[Export ("registerClass:forCellReuseIdentifier:")]
	void RegisterClass (Class cellClass, string identifier);

	// -(void)scrollToLast:(BOOL)animated;
	[Export ("scrollToLast:")]
	void ScrollToLast (bool animated);

	// -(void)clearTextEntry;
	[Export ("clearTextEntry")]
	void ClearTextEntry ();

	// -(void)reload;
	[Export ("reload")]
	void Reload ();
}

// @protocol ZDCChatUIController <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDCChatUIController
{
	// @required -(void)presentIn:(UINavigationController *)navController;
	[Abstract]
	[Export ("presentIn:")]
	void PresentIn (UINavigationController navController);

	// @required -(void)dismiss;
	[Abstract]
	[Export ("dismiss")]
	void Dismiss ();

	// @required -(void)enableOfflineMessageSendButton:(BOOL)enabled;
	[Abstract]
	[Export ("enableOfflineMessageSendButton:")]
	void EnableOfflineMessageSendButton (bool enabled);

	// @required -(void)stateTransitionTo:(ZDCChatUIState)state;
	[Abstract]
	[Export ("stateTransitionTo:")]
	void StateTransitionTo (ZDCChatUIState state);

	// @required -(void)showConnectionToast;
	[Abstract]
	[Export ("showConnectionToast")]
	void ShowConnectionToast ();

	// @required -(void)showReconnectingToast;
	[Abstract]
	[Export ("showReconnectingToast")]
	void ShowReconnectingToast ();

	// @required -(void)dismissToast;
	[Abstract]
	[Export ("dismissToast")]
	void DismissToast ();
}

// @interface ZDCLoadingErrorView : UIView
[BaseType (typeof(UIView))]
interface ZDCLoadingErrorView
{
	// @property (nonatomic, strong) UIImageView * icon;
	[Export ("icon", ArgumentSemantic.Strong)]
	UIImageView Icon { get; set; }

	// @property (nonatomic, strong) UILabel * title;
	[Export ("title", ArgumentSemantic.Strong)]
	UILabel Title { get; set; }

	// @property (nonatomic, strong) UILabel * message;
	[Export ("message", ArgumentSemantic.Strong)]
	UILabel Message { get; set; }

	// @property (nonatomic, strong) UIButton * offlineMessageButton;
	[Export ("offlineMessageButton", ArgumentSemantic.Strong)]
	UIButton OfflineMessageButton { get; set; }

	[Wrap ("WeakDelegate")]
	ZDCChatUIController Delegate { get; set; }

	// @property (assign, nonatomic) id<ZDCChatUIController> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic, strong) NSString * iconImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("iconImage", ArgumentSemantic.Strong)]
	string IconImage { get; set; }

	// @property (nonatomic, strong) UIFont * titleFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("titleFont", ArgumentSemantic.Strong)]
	UIFont TitleFont { get; set; }

	// @property (nonatomic, strong) UIColor * titleColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("titleColor", ArgumentSemantic.Strong)]
	UIColor TitleColor { get; set; }

	// @property (nonatomic, strong) UIFont * messageFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("messageFont", ArgumentSemantic.Strong)]
	UIFont MessageFont { get; set; }

	// @property (nonatomic, strong) UIColor * messageColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("messageColor", ArgumentSemantic.Strong)]
	UIColor MessageColor { get; set; }

	// @property (nonatomic, strong) UIFont * buttonFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("buttonFont", ArgumentSemantic.Strong)]
	UIFont ButtonFont { get; set; }

	// @property (nonatomic, strong) UIColor * buttonTitleColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("buttonTitleColor", ArgumentSemantic.Strong)]
	UIColor ButtonTitleColor { get; set; }

	// @property (nonatomic, strong) UIColor * buttonBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("buttonBackgroundColor", ArgumentSemantic.Strong)]
	UIColor ButtonBackgroundColor { get; set; }

	// @property (nonatomic, strong) NSString * buttonImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("buttonImage", ArgumentSemantic.Strong)]
	string ButtonImage { get; set; }

	// @property (nonatomic, strong) UIColor * errorBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("errorBackgroundColor", ArgumentSemantic.Strong)]
	UIColor ErrorBackgroundColor { get; set; }

	// -(instancetype)initNoConnectionWithFrame:(CGRect)frame;
	[Export ("initNoConnectionWithFrame:")]
	IntPtr Constructor (CGRect frame);

	// -(instancetype)initNoAgentsWithFrame:(CGRect)frame andDelegate:(id<ZDCChatUIController>)delegate;
	[Export ("initNoAgentsWithFrame:andDelegate:")]
	IntPtr Constructor (CGRect frame, ZDCChatUIController @delegate);

	// -(instancetype)initCantConnectWithFrame:(CGRect)frame andDelegate:(id<ZDCChatUIController>)delegate;
	[Export ("initCantConnectWithFrame:andDelegate:")]
	IntPtr Constructor (CGRect frame, ZDCChatUIController @delegate);
}

// @interface ZDCOfflineMessageView : UIView <UITableViewDelegate, UITableViewDataSource, ZDCFormCellDelegate, UITextViewDelegate>
[BaseType (typeof(UIView))]
interface ZDCOfflineMessageView : IUITableViewDelegate, IUITableViewDataSource, IZDCFormCellDelegate, IUITextViewDelegate
{
	// @property (nonatomic, strong) UITableView * formTable;
	[Export ("formTable", ArgumentSemantic.Strong)]
	UITableView FormTable { get; set; }

	// @property (nonatomic, strong) UIView * submittingOverlay;
	[Export ("submittingOverlay", ArgumentSemantic.Strong)]
	UIView SubmittingOverlay { get; set; }

	// @property (nonatomic, strong) UIActivityIndicatorView * submittingSpinner;
	[Export ("submittingSpinner", ArgumentSemantic.Strong)]
	UIActivityIndicatorView SubmittingSpinner { get; set; }

	// @property (nonatomic, strong) NSString * nameText;
	[Export ("nameText", ArgumentSemantic.Strong)]
	string NameText { get; set; }

	// @property (nonatomic, strong) NSString * emailText;
	[Export ("emailText", ArgumentSemantic.Strong)]
	string EmailText { get; set; }

	// @property (nonatomic, strong) NSString * phoneText;
	[Export ("phoneText", ArgumentSemantic.Strong)]
	string PhoneText { get; set; }

	// @property (nonatomic, strong) NSString * messageText;
	[Export ("messageText", ArgumentSemantic.Strong)]
	string MessageText { get; set; }

	// @property (nonatomic, strong) NSString * selectedDepartment;
	[Export ("selectedDepartment", ArgumentSemantic.Strong)]
	string SelectedDepartment { get; set; }

	// @property (nonatomic, strong) UIColor * formBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("formBackgroundColor", ArgumentSemantic.Strong)]
	UIColor FormBackgroundColor { get; set; }

	// -(instancetype)initWithFrame:(CGRect)frame withController:(id<ZDCVisitorActionDelegate>)controller andMessage:(NSString *)message;
	[Export ("initWithFrame:withController:andMessage:")]
	IntPtr Constructor (CGRect frame, ZDCVisitorActionDelegate controller, string message);

	// -(BOOL)formComplete;
	[Export ("formComplete")]
	[Verify (MethodToProperty)]
	bool FormComplete { get; }

	// -(void)animateToSubmitting;
	[Export ("animateToSubmitting")]
	void AnimateToSubmitting ();

	// -(void)animateFromSubmitting;
	[Export ("animateFromSubmitting")]
	void AnimateFromSubmitting ();
}

// @protocol ZDCInsetProvider <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDCInsetProvider
{
	// @required -(id<UILayoutSupport>)topLayoutGuide;
	[Abstract]
	[Export ("topLayoutGuide")]
	[Verify (MethodToProperty)]
	UILayoutSupport TopLayoutGuide { get; }

	// @required -(id<UILayoutSupport>)bottomLayoutGuide;
	[Abstract]
	[Export ("bottomLayoutGuide")]
	[Verify (MethodToProperty)]
	UILayoutSupport BottomLayoutGuide { get; }
}

// @interface ZDCChatUI : UIView
[BaseType (typeof(UIView))]
interface ZDCChatUI
{
	// @property (nonatomic, strong) UIImageView * backgroundImageView;
	[Export ("backgroundImageView", ArgumentSemantic.Strong)]
	UIImageView BackgroundImageView { get; set; }

	// @property (nonatomic, strong) ZDCLoadingView * loadingView;
	[Export ("loadingView", ArgumentSemantic.Strong)]
	ZDCLoadingView LoadingView { get; set; }

	// @property (nonatomic, strong) ZDCLoadingErrorView * loadingErrorView;
	[Export ("loadingErrorView", ArgumentSemantic.Strong)]
	ZDCLoadingErrorView LoadingErrorView { get; set; }

	// @property (nonatomic, strong) ZDCPreChatFormView * formView;
	[Export ("formView", ArgumentSemantic.Strong)]
	ZDCPreChatFormView FormView { get; set; }

	// @property (nonatomic, strong) ZDCChatView * chatView;
	[Export ("chatView", ArgumentSemantic.Strong)]
	ZDCChatView ChatView { get; set; }

	// @property (nonatomic, strong) ZDCOfflineMessageView * offlineForm;
	[Export ("offlineForm", ArgumentSemantic.Strong)]
	ZDCOfflineMessageView OfflineForm { get; set; }

	[Wrap ("WeakDelegate")]
	ZDCChatUIController Delegate { get; set; }

	// @property (nonatomic, weak) id<ZDCChatUIController> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (assign, nonatomic) ZDCChatUIState state;
	[Export ("state", ArgumentSemantic.Assign)]
	ZDCChatUIState State { get; set; }

	// @property (nonatomic, weak) id<ZDCInsetProvider> insetProvider;
	[Export ("insetProvider", ArgumentSemantic.Weak)]
	ZDCInsetProvider InsetProvider { get; set; }

	// @property (nonatomic, strong) NSString * endChatButtonImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("endChatButtonImage", ArgumentSemantic.Strong)]
	string EndChatButtonImage { get; set; }

	// @property (nonatomic, strong) NSString * cancelChatButtonImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("cancelChatButtonImage", ArgumentSemantic.Strong)]
	string CancelChatButtonImage { get; set; }

	// @property (nonatomic, strong) NSString * backChatButtonImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("backChatButtonImage", ArgumentSemantic.Strong)]
	string BackChatButtonImage { get; set; }

	// @property (nonatomic, strong) UIColor * chatBackgroundColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("chatBackgroundColor", ArgumentSemantic.Strong)]
	UIColor ChatBackgroundColor { get; set; }

	// @property (nonatomic, strong) NSString * chatBackgroundImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("chatBackgroundImage", ArgumentSemantic.Strong)]
	string ChatBackgroundImage { get; set; }

	// @property (nonatomic, strong) NSNumber * chatBackgroundAnchor __attribute__((annotate("ui_appearance_selector")));
	[Export ("chatBackgroundAnchor", ArgumentSemantic.Strong)]
	NSNumber ChatBackgroundAnchor { get; set; }

	// -(instancetype)initWithFrame:(CGRect)frame andDelegate:(id<ZDCChatUIController>)delegate;
	[Export ("initWithFrame:andDelegate:")]
	IntPtr Constructor (CGRect frame, ZDCChatUIController @delegate);

	// -(void)activate;
	[Export ("activate")]
	void Activate ();

	// -(void)minimise;
	[Export ("minimise")]
	void Minimise ();

	// -(void)end;
	[Export ("end")]
	void End ();

	// -(void)showOfflineForm;
	[Export ("showOfflineForm")]
	void ShowOfflineForm ();

	// -(void)sendOfflineMessage;
	[Export ("sendOfflineMessage")]
	void SendOfflineMessage ();
}

// @interface ZDCChatViewController : ZDUViewController <ZDCChatUIController, ZDCInsetProvider>
[BaseType (typeof(ZDUViewController))]
interface ZDCChatViewController : IZDCChatUIController, IZDCInsetProvider
{
	// @property (nonatomic, strong) ZDCChatUI * chatUI;
	[Export ("chatUI", ArgumentSemantic.Strong)]
	ZDCChatUI ChatUI { get; set; }
}

// @protocol ZDCChatOverlayDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDCChatOverlayDelegate
{
	// @required -(void)show;
	[Abstract]
	[Export ("show")]
	void Show ();

	// @required -(void)hide;
	[Abstract]
	[Export ("hide")]
	void Hide ();

	// @required -(void)remove;
	[Abstract]
	[Export ("remove")]
	void Remove ();

	// @required -(BOOL)active;
	[Abstract]
	[Export ("active")]
	[Verify (MethodToProperty)]
	bool Active { get; }

	// @required -(void)activate;
	[Abstract]
	[Export ("activate")]
	void Activate ();

	// @required -(void)setEnabled:(BOOL)enabled;
	[Abstract]
	[Export ("setEnabled:")]
	void SetEnabled (bool enabled);
}

// @interface ZDCChatOverlay : UIView <UIGestureRecognizerDelegate, ZDCChatOverlayDelegate>
[BaseType (typeof(UIView))]
interface ZDCChatOverlay : IUIGestureRecognizerDelegate, IZDCChatOverlayDelegate
{
	// @property (assign, nonatomic) BOOL enabled;
	[Export ("enabled")]
	bool Enabled { get; set; }

	// @property (nonatomic, strong) NSValue * insets __attribute__((annotate("ui_appearance_selector")));
	[Export ("insets", ArgumentSemantic.Strong)]
	NSValue Insets { get; set; }

	// @property (nonatomic, strong) NSNumber * alignment __attribute__((annotate("ui_appearance_selector")));
	[Export ("alignment", ArgumentSemantic.Strong)]
	NSNumber Alignment { get; set; }

	// @property (nonatomic, strong) UIFont * messageCountFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("messageCountFont", ArgumentSemantic.Strong)]
	UIFont MessageCountFont { get; set; }

	// @property (nonatomic, strong) UIColor * messageCountColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("messageCountColor", ArgumentSemantic.Strong)]
	UIColor MessageCountColor { get; set; }

	// @property (nonatomic, strong) NSNumber * typingIndicatorDiameter __attribute__((annotate("ui_appearance_selector")));
	[Export ("typingIndicatorDiameter", ArgumentSemantic.Strong)]
	NSNumber TypingIndicatorDiameter { get; set; }

	// @property (nonatomic, strong) UIColor * typingIndicatorColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("typingIndicatorColor", ArgumentSemantic.Strong)]
	UIColor TypingIndicatorColor { get; set; }

	// @property (nonatomic, strong) UIColor * typingIndicatorHighlightColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("typingIndicatorHighlightColor", ArgumentSemantic.Strong)]
	UIColor TypingIndicatorHighlightColor { get; set; }

	// @property (nonatomic, strong) UIImage * overlayBackgroundImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("overlayBackgroundImage", ArgumentSemantic.Strong)]
	UIImage OverlayBackgroundImage { get; set; }

	// @property (nonatomic, strong) UIColor * overlayTintColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("overlayTintColor", ArgumentSemantic.Strong)]
	UIColor OverlayTintColor { get; set; }
}

// @protocol ZDUImageRequestDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDUImageRequestDelegate
{
	// @required -(void)imageDownloaded:(UIImage *)img;
	[Abstract]
	[Export ("imageDownloaded:")]
	void ImageDownloaded (UIImage img);
}

// @interface ZDUExternalImage : UIImageView <ZDUImageRequestDelegate>
[BaseType (typeof(UIImageView))]
interface ZDUExternalImage : IZDUImageRequestDelegate
{
	// @property (nonatomic, strong) ZDUImageLoader * loader;
	[Export ("loader", ArgumentSemantic.Strong)]
	ZDUImageLoader Loader { get; set; }

	// @property (nonatomic, strong) NSString * url;
	[Export ("url", ArgumentSemantic.Strong)]
	string Url { get; set; }

	// -(instancetype)initWithLoader:(ZDUImageLoader *)loader;
	[Export ("initWithLoader:")]
	IntPtr Constructor (ZDUImageLoader loader);

	// -(void)maskWithCircle;
	[Export ("maskWithCircle")]
	void MaskWithCircle ();
}

// @interface ZDCChatAvatar : ZDUExternalImage
[BaseType (typeof(ZDUExternalImage))]
interface ZDCChatAvatar
{
	// @property (nonatomic, strong) UIImage * defaultAvatarImage __attribute__((annotate("ui_appearance_selector")));
	[Export ("defaultAvatarImage", ArgumentSemantic.Strong)]
	UIImage DefaultAvatarImage { get; set; }
}

// @protocol ZDCChatCellActionDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDCChatCellActionDelegate
{
	// @required -(BOOL)eventHasTimedOut:(ZDCChatEvent *)event;
	[Abstract]
	[Export ("eventHasTimedOut:")]
	bool EventHasTimedOut (ZDCChatEvent @event);

	// @required -(void)resendMessage:(ZDCChatEvent *)event;
	[Abstract]
	[Export ("resendMessage:")]
	void ResendMessage (ZDCChatEvent @event);

	// @required -(void)fileUpdated:(ZDCChatEvent *)event;
	[Abstract]
	[Export ("fileUpdated:")]
	void FileUpdated (ZDCChatEvent @event);

	// @required -(void)viewAttachmentImage:(UIImage *)image fromView:(UIImageView *)imageView;
	[Abstract]
	[Export ("viewAttachmentImage:fromView:")]
	void ViewAttachmentImage (UIImage image, UIImageView imageView);

	// @required -(void)viewDocumentForEvent:(ZDCChatEvent *)event;
	[Abstract]
	[Export ("viewDocumentForEvent:")]
	void ViewDocumentForEvent (ZDCChatEvent @event);

	// @required -(void)optionSelected:(ZDCChatEvent *)event;
	[Abstract]
	[Export ("optionSelected:")]
	void OptionSelected (ZDCChatEvent @event);

	// @required -(ZDCOptionView *)dequeueOptionView:(NSString *)option atIndex:(NSInteger)index radioRadius:(CGFloat)radioRadius borderColor:(UIColor *)borderColor font:(UIFont *)font textColor:(UIColor *)textColor bubbleCornerRadius:(CGFloat)bubbleCornerRadius backgroundColor:(UIColor *)backgroundColor;
	[Abstract]
	[Export ("dequeueOptionView:atIndex:radioRadius:borderColor:font:textColor:bubbleCornerRadius:backgroundColor:")]
	ZDCOptionView DequeueOptionView (string option, nint index, nfloat radioRadius, UIColor borderColor, UIFont font, UIColor textColor, nfloat bubbleCornerRadius, UIColor backgroundColor);

	// @required -(void)requeueOptionView:(ZDCOptionView *)optionView;
	[Abstract]
	[Export ("requeueOptionView:")]
	void RequeueOptionView (ZDCOptionView optionView);

	// @required -(void)editRatingComment:(ZDCChatEvent *)ratingEvent;
	[Abstract]
	[Export ("editRatingComment:")]
	void EditRatingComment (ZDCChatEvent ratingEvent);

	// @required -(void)setChatRating:(ZDCChatEvent *)ratingEvent to:(ZDCChatRating)newRating;
	[Abstract]
	[Export ("setChatRating:to:")]
	void SetChatRating (ZDCChatEvent ratingEvent, ZDCChatRating newRating);

	// @required -(CGFloat)sizeOfString:(NSString *)string usingFont:(UIFont *)font forWidth:(CGFloat)width;
	[Abstract]
	[Export ("sizeOfString:usingFont:forWidth:")]
	nfloat SizeOfString (string @string, UIFont font, nfloat width);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGFloat ZDC_CHAT_BUBBLE_LEAD_MESSAGE_MARGIN;
	[Field ("ZDC_CHAT_BUBBLE_LEAD_MESSAGE_MARGIN", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_LEAD_MESSAGE_MARGIN { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_TOP_MARGIN;
	[Field ("ZDC_CHAT_BUBBLE_TOP_MARGIN", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_TOP_MARGIN { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_BOTTOM_MARGIN;
	[Field ("ZDC_CHAT_BUBBLE_BOTTOM_MARGIN", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_BOTTOM_MARGIN { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_TOP_PADDING;
	[Field ("ZDC_CHAT_BUBBLE_TOP_PADDING", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_TOP_PADDING { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_BOTTOM_PADDING;
	[Field ("ZDC_CHAT_BUBBLE_BOTTOM_PADDING", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_BOTTOM_PADDING { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_LEFT_MARGIN;
	[Field ("ZDC_CHAT_BUBBLE_LEFT_MARGIN", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_LEFT_MARGIN { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_LEFT_MARGIN_AGENT;
	[Field ("ZDC_CHAT_BUBBLE_LEFT_MARGIN_AGENT", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_LEFT_MARGIN_AGENT { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_RIGHT_MARGIN;
	[Field ("ZDC_CHAT_BUBBLE_RIGHT_MARGIN", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_RIGHT_MARGIN { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_AGENT_RIGHT_MARGIN;
	[Field ("ZDC_CHAT_BUBBLE_AGENT_RIGHT_MARGIN", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_AGENT_RIGHT_MARGIN { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_LEFT_PADDING;
	[Field ("ZDC_CHAT_BUBBLE_LEFT_PADDING", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_LEFT_PADDING { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_RIGHT_PADDING;
	[Field ("ZDC_CHAT_BUBBLE_RIGHT_PADDING", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_RIGHT_PADDING { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_AUTHOR_HEIGHT;
	[Field ("ZDC_CHAT_BUBBLE_AUTHOR_HEIGHT", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_AUTHOR_HEIGHT { get; }

	// extern const CGFloat ZDC_CHAT_BUBBLE_CORNER_RADIUS;
	[Field ("ZDC_CHAT_BUBBLE_CORNER_RADIUS", "__Internal")]
	nfloat ZDC_CHAT_BUBBLE_CORNER_RADIUS { get; }

	// extern const CGFloat ZDC_TYPING_CELL_HEIGHT;
	[Field ("ZDC_TYPING_CELL_HEIGHT", "__Internal")]
	nfloat ZDC_TYPING_CELL_HEIGHT { get; }

	// extern const CGFloat ZDC_TYPING_CELL_HEIGHT_WITH_AVATAR;
	[Field ("ZDC_TYPING_CELL_HEIGHT_WITH_AVATAR", "__Internal")]
	nfloat ZDC_TYPING_CELL_HEIGHT_WITH_AVATAR { get; }

	// extern const CGFloat ZDC_AVATAR_LEFT_INSET;
	[Field ("ZDC_AVATAR_LEFT_INSET", "__Internal")]
	nfloat ZDC_AVATAR_LEFT_INSET { get; }

	// extern const CGFloat ZDC_AVATAR_TOP_INSET;
	[Field ("ZDC_AVATAR_TOP_INSET", "__Internal")]
	nfloat ZDC_AVATAR_TOP_INSET { get; }

	// extern const CGFloat ZDC_AVATAR_HEIGHT;
	[Field ("ZDC_AVATAR_HEIGHT", "__Internal")]
	nfloat ZDC_AVATAR_HEIGHT { get; }

	// extern const CGFloat ZDC_DEFAULT_UNSENT_MSG_TOP_MARGIN;
	[Field ("ZDC_DEFAULT_UNSENT_MSG_TOP_MARGIN", "__Internal")]
	nfloat ZDC_DEFAULT_UNSENT_MSG_TOP_MARGIN { get; }

	// extern const CGFloat ZDC_DEFAULT_UNSENT_ICON_LEFT_MARGIN;
	[Field ("ZDC_DEFAULT_UNSENT_ICON_LEFT_MARGIN", "__Internal")]
	nfloat ZDC_DEFAULT_UNSENT_ICON_LEFT_MARGIN { get; }

	// extern NSString *const ZDC_DEFAULT_UNSENT_ICON_IMAGE;
	[Field ("ZDC_DEFAULT_UNSENT_ICON_IMAGE", "__Internal")]
	NSString ZDC_DEFAULT_UNSENT_ICON_IMAGE { get; }

	// extern NSString *const ZDC_DEFAULT_BROKEN_FILE_ICON_IMAGE;
	[Field ("ZDC_DEFAULT_BROKEN_FILE_ICON_IMAGE", "__Internal")]
	NSString ZDC_DEFAULT_BROKEN_FILE_ICON_IMAGE { get; }
}

// @interface ZDCChatCell : UITableViewCell
[BaseType (typeof(UITableViewCell))]
interface ZDCChatCell
{
	// @property (nonatomic, strong) ZDCChatEvent * event;
	[Export ("event", ArgumentSemantic.Strong)]
	ZDCChatEvent Event { get; set; }

	// @property (assign, nonatomic) BOOL eventError;
	[Export ("eventError")]
	bool EventError { get; set; }

	[Wrap ("WeakActionDelegate")]
	ZDCChatCellActionDelegate ActionDelegate { get; set; }

	// @property (nonatomic, weak) id<ZDCChatCellActionDelegate> actionDelegate;
	[NullAllowed, Export ("actionDelegate", ArgumentSemantic.Weak)]
	NSObject WeakActionDelegate { get; set; }

	// -(void)prepareWithEvent:(ZDCChatEvent *)event;
	[Export ("prepareWithEvent:")]
	void PrepareWithEvent (ZDCChatEvent @event);

	// -(void)agentUpdate:(ZDCChatAgent *)agent;
	[Export ("agentUpdate:")]
	void AgentUpdate (ZDCChatAgent agent);

	// -(void)agentsTyping:(NSArray *)agents lastEvent:(ZDCChatEvent *)lastEvent;
	[Export ("agentsTyping:lastEvent:")]
	[Verify (StronglyTypedNSArray)]
	void AgentsTyping (NSObject[] agents, ZDCChatEvent lastEvent);

	// -(CGFloat)heightForEvent:(ZDCChatEvent *)event givenWidth:(CGFloat)width;
	[Export ("heightForEvent:givenWidth:")]
	nfloat HeightForEvent (ZDCChatEvent @event, nfloat width);

	// -(id)appearance:(SEL)sel def:(id)defaultVal;
	[Export ("appearance:def:")]
	NSObject Appearance (Selector sel, NSObject defaultVal);

	// -(void)setupAppearance;
	[Export ("setupAppearance")]
	void SetupAppearance ();

	// -(void)layout;
	[Export ("layout")]
	void Layout ();

	// -(void)layoutForStatusOk;
	[Export ("layoutForStatusOk")]
	void LayoutForStatusOk ();

	// -(void)layoutForStatusError;
	[Export ("layoutForStatusError")]
	void LayoutForStatusError ();

	// -(void)animateToError;
	[Export ("animateToError")]
	void AnimateToError ();

	// -(void)animateToOk;
	[Export ("animateToOk")]
	void AnimateToOk ();

	// -(void)animateUserAction:(NSDictionary *)info;
	[Export ("animateUserAction:")]
	void AnimateUserAction (NSDictionary info);

	// -(CGSize)attachmentImageSize:(ZDCChatEvent *)event withMaxSize:(float)maxSize;
	[Export ("attachmentImageSize:withMaxSize:")]
	CGSize AttachmentImageSize (ZDCChatEvent @event, float maxSize);
}

// @interface ZDCVisitorChatCell : ZDCChatCell
[BaseType (typeof(ZDCChatCell))]
interface ZDCVisitorChatCell
{
	// @property (nonatomic, strong) ZDUTextView * chatMessage;
	[Export ("chatMessage", ArgumentSemantic.Strong)]
	ZDUTextView ChatMessage { get; set; }

	// @property (nonatomic, strong) UIButton * bubble;
	[Export ("bubble", ArgumentSemantic.Strong)]
	UIButton Bubble { get; set; }

	// @property (nonatomic, strong) UIImageView * unsentMessageIcon;
	[Export ("unsentMessageIcon", ArgumentSemantic.Strong)]
	UIImageView UnsentMessageIcon { get; set; }

	// @property (nonatomic, strong) UILabel * unsentMessageLabel;
	[Export ("unsentMessageLabel", ArgumentSemantic.Strong)]
	UILabel UnsentMessageLabel { get; set; }

	// @property (nonatomic, strong) NSValue * bubbleInsets __attribute__((annotate("ui_appearance_selector")));
	[Export ("bubbleInsets", ArgumentSemantic.Strong)]
	NSValue BubbleInsets { get; set; }

	// @property (nonatomic, strong) NSNumber * unsentIconLeftMargin __attribute__((annotate("ui_appearance_selector")));
	[Export ("unsentIconLeftMargin", ArgumentSemantic.Strong)]
	NSNumber UnsentIconLeftMargin { get; set; }

	// @property (nonatomic, strong) NSNumber * unsentMessageTopMargin __attribute__((annotate("ui_appearance_selector")));
	[Export ("unsentMessageTopMargin", ArgumentSemantic.Strong)]
	NSNumber UnsentMessageTopMargin { get; set; }

	// @property (nonatomic, strong) UIColor * bubbleBorderColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("bubbleBorderColor", ArgumentSemantic.Strong)]
	UIColor BubbleBorderColor { get; set; }

	// @property (nonatomic, strong) UIColor * bubbleColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("bubbleColor", ArgumentSemantic.Strong)]
	UIColor BubbleColor { get; set; }

	// @property (nonatomic, strong) NSNumber * bubbleCornerRadius __attribute__((annotate("ui_appearance_selector")));
	[Export ("bubbleCornerRadius", ArgumentSemantic.Strong)]
	NSNumber BubbleCornerRadius { get; set; }

	// @property (nonatomic, strong) NSValue * textInsets __attribute__((annotate("ui_appearance_selector")));
	[Export ("textInsets", ArgumentSemantic.Strong)]
	NSValue TextInsets { get; set; }

	// @property (nonatomic, strong) NSNumber * textAlignment __attribute__((annotate("ui_appearance_selector")));
	[Export ("textAlignment", ArgumentSemantic.Strong)]
	NSNumber TextAlignment { get; set; }

	// @property (nonatomic, strong) UIColor * textColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textColor", ArgumentSemantic.Strong)]
	UIColor TextColor { get; set; }

	// @property (nonatomic, strong) UIFont * textFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFont", ArgumentSemantic.Strong)]
	UIFont TextFont { get; set; }

	// @property (nonatomic, strong) UIColor * unsentTextColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("unsentTextColor", ArgumentSemantic.Strong)]
	UIColor UnsentTextColor { get; set; }

	// @property (nonatomic, strong) UIFont * unsentTextFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("unsentTextFont", ArgumentSemantic.Strong)]
	UIFont UnsentTextFont { get; set; }
}

// @interface ZDCAgentChatCell : ZDCVisitorChatCell
[BaseType (typeof(ZDCVisitorChatCell))]
interface ZDCAgentChatCell
{
	// @property (nonatomic, strong) UILabel * author;
	[Export ("author", ArgumentSemantic.Strong)]
	UILabel Author { get; set; }

	// @property (nonatomic, strong) ZDCChatAvatar * avatar;
	[Export ("avatar", ArgumentSemantic.Strong)]
	ZDCChatAvatar Avatar { get; set; }

	// @property (nonatomic, strong) NSNumber * avatarHeight __attribute__((annotate("ui_appearance_selector")));
	[Export ("avatarHeight", ArgumentSemantic.Strong)]
	NSNumber AvatarHeight { get; set; }

	// @property (nonatomic, strong) NSNumber * avatarLeftInset __attribute__((annotate("ui_appearance_selector")));
	[Export ("avatarLeftInset", ArgumentSemantic.Strong)]
	NSNumber AvatarLeftInset { get; set; }

	// @property (nonatomic, strong) UIFont * authorFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("authorFont", ArgumentSemantic.Strong)]
	UIFont AuthorFont { get; set; }

	// @property (nonatomic, strong) UIColor * authorColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("authorColor", ArgumentSemantic.Strong)]
	UIColor AuthorColor { get; set; }

	// @property (nonatomic, strong) NSNumber * authorHeight __attribute__((annotate("ui_appearance_selector")));
	[Export ("authorHeight", ArgumentSemantic.Strong)]
	NSNumber AuthorHeight { get; set; }
}

// @interface ZDCFormCellSingleLine : ZDCFormCell <UITextFieldDelegate>
[BaseType (typeof(ZDCFormCell))]
interface ZDCFormCellSingleLine : IUITextFieldDelegate
{
	// @property (nonatomic, strong) UITextField * textField;
	[Export ("textField", ArgumentSemantic.Strong)]
	UITextField TextField { get; set; }
}

// @interface ZDCTriangleView : UIView
[BaseType (typeof(UIView))]
interface ZDCTriangleView
{
	// @property (nonatomic, strong) UIColor * color;
	[Export ("color", ArgumentSemantic.Strong)]
	UIColor Color { get; set; }
}

// @interface ZDCFormCellDepartment : ZDCFormCell <UIActionSheetDelegate>
[BaseType (typeof(ZDCFormCell))]
interface ZDCFormCellDepartment : IUIActionSheetDelegate
{
	// @property (nonatomic, strong) UIButton * departmentButton;
	[Export ("departmentButton", ArgumentSemantic.Strong)]
	UIButton DepartmentButton { get; set; }

	// @property (nonatomic, strong) UILabel * departmentLabel;
	[Export ("departmentLabel", ArgumentSemantic.Strong)]
	UILabel DepartmentLabel { get; set; }

	// @property (nonatomic, strong) ZDCTriangleView * icon;
	[Export ("icon", ArgumentSemantic.Strong)]
	ZDCTriangleView Icon { get; set; }

	// @property (nonatomic, strong) UIActionSheet * actionSheet;
	[Export ("actionSheet", ArgumentSemantic.Strong)]
	UIActionSheet ActionSheet { get; set; }
}

// @interface ZDCFormCellMessage : ZDCFormCell <UITextViewDelegate>
[BaseType (typeof(ZDCFormCell))]
interface ZDCFormCellMessage : IUITextViewDelegate
{
	// @property (nonatomic, strong) ZDUTextView * textView;
	[Export ("textView", ArgumentSemantic.Strong)]
	ZDUTextView TextView { get; set; }
}

// @interface ZDCJoinLeaveCell : ZDCChatCell
[BaseType (typeof(ZDCChatCell))]
interface ZDCJoinLeaveCell
{
	// @property (nonatomic, strong) UILabel * msg;
	[Export ("msg", ArgumentSemantic.Strong)]
	UILabel Msg { get; set; }

	// @property (nonatomic, strong) UIColor * textColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textColor", ArgumentSemantic.Strong)]
	UIColor TextColor { get; set; }

	// @property (nonatomic, strong) UIFont * textFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFont", ArgumentSemantic.Strong)]
	UIFont TextFont { get; set; }

	// @property (nonatomic, strong) NSValue * textInsets __attribute__((annotate("ui_appearance_selector")));
	[Export ("textInsets", ArgumentSemantic.Strong)]
	NSValue TextInsets { get; set; }
}

// @interface ZDCAgentAttachmentCell : ZDCAgentChatCell
[BaseType (typeof(ZDCAgentChatCell))]
interface ZDCAgentAttachmentCell
{
	// @property (nonatomic, strong) UIImageView * attachmentImage;
	[Export ("attachmentImage", ArgumentSemantic.Strong)]
	UIImageView AttachmentImage { get; set; }

	// @property (nonatomic, strong) UIActivityIndicatorView * spinner;
	[Export ("spinner", ArgumentSemantic.Strong)]
	UIActivityIndicatorView Spinner { get; set; }

	// @property (nonatomic, strong) UILabel * filenameLabel;
	[Export ("filenameLabel", ArgumentSemantic.Strong)]
	UILabel FilenameLabel { get; set; }

	// @property (nonatomic, strong) NSNumber * activityIndicatorViewStyle __attribute__((annotate("ui_appearance_selector")));
	[Export ("activityIndicatorViewStyle", ArgumentSemantic.Strong)]
	NSNumber ActivityIndicatorViewStyle { get; set; }
}

// @interface ZDCVisitorAttachmentCell : ZDCVisitorChatCell <ZDCUploadDelegate>
[BaseType (typeof(ZDCVisitorChatCell))]
interface ZDCVisitorAttachmentCell : IZDCUploadDelegate
{
	// @property (nonatomic, strong) UIImageView * attachmentImage;
	[Export ("attachmentImage", ArgumentSemantic.Strong)]
	UIImageView AttachmentImage { get; set; }

	// @property (nonatomic, strong) UIView * progressBar;
	[Export ("progressBar", ArgumentSemantic.Strong)]
	UIView ProgressBar { get; set; }

	// @property (nonatomic, strong) UIActivityIndicatorView * spinner;
	[Export ("spinner", ArgumentSemantic.Strong)]
	UIActivityIndicatorView Spinner { get; set; }

	// @property (nonatomic, strong) NSNumber * activityIndicatorViewStyle __attribute__((annotate("ui_appearance_selector")));
	[Export ("activityIndicatorViewStyle", ArgumentSemantic.Strong)]
	NSNumber ActivityIndicatorViewStyle { get; set; }

	// @property (nonatomic, strong) UIColor * progressBarColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("progressBarColor", ArgumentSemantic.Strong)]
	UIColor ProgressBarColor { get; set; }
}

// @interface ZDCRatingCell : ZDCVisitorChatCell
[BaseType (typeof(ZDCVisitorChatCell))]
interface ZDCRatingCell
{
	// @property (nonatomic, strong) UILabel * titleLabel;
	[Export ("titleLabel", ArgumentSemantic.Strong)]
	UILabel TitleLabel { get; set; }

	// @property (nonatomic, strong) UIButton * badRatingButton;
	[Export ("badRatingButton", ArgumentSemantic.Strong)]
	UIButton BadRatingButton { get; set; }

	// @property (nonatomic, strong) UIButton * goodRatingButton;
	[Export ("goodRatingButton", ArgumentSemantic.Strong)]
	UIButton GoodRatingButton { get; set; }

	// @property (nonatomic, strong) UIButton * commentButton;
	[Export ("commentButton", ArgumentSemantic.Strong)]
	UIButton CommentButton { get; set; }

	// @property (nonatomic, strong) UIColor * titleColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("titleColor", ArgumentSemantic.Strong)]
	UIColor TitleColor { get; set; }

	// @property (nonatomic, strong) UIFont * titleFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("titleFont", ArgumentSemantic.Strong)]
	UIFont TitleFont { get; set; }

	// @property (nonatomic, strong) UIColor * leaveCommentTitleColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("leaveCommentTitleColor", ArgumentSemantic.Strong)]
	UIColor LeaveCommentTitleColor { get; set; }

	// @property (nonatomic, strong) NSNumber * cellToTitleMargin __attribute__((annotate("ui_appearance_selector")));
	[Export ("cellToTitleMargin", ArgumentSemantic.Strong)]
	NSNumber CellToTitleMargin { get; set; }

	// @property (nonatomic, strong) NSNumber * titleToButtonsMargin __attribute__((annotate("ui_appearance_selector")));
	[Export ("titleToButtonsMargin", ArgumentSemantic.Strong)]
	NSNumber TitleToButtonsMargin { get; set; }

	// @property (nonatomic, strong) NSNumber * ratingButtonToCommentMargin __attribute__((annotate("ui_appearance_selector")));
	[Export ("ratingButtonToCommentMargin", ArgumentSemantic.Strong)]
	NSNumber RatingButtonToCommentMargin { get; set; }

	// @property (nonatomic, strong) NSNumber * editCommentButtonHeight __attribute__((annotate("ui_appearance_selector")));
	[Export ("editCommentButtonHeight", ArgumentSemantic.Strong)]
	NSNumber EditCommentButtonHeight { get; set; }

	// @property (nonatomic, strong) NSNumber * ratingButtonSize __attribute__((annotate("ui_appearance_selector")));
	[Export ("ratingButtonSize", ArgumentSemantic.Strong)]
	NSNumber RatingButtonSize { get; set; }
}

// @interface ZDCChatTimedOutCell : ZDCChatCell
[BaseType (typeof(ZDCChatCell))]
interface ZDCChatTimedOutCell
{
	// @property (nonatomic, strong) UILabel * chatMessage;
	[Export ("chatMessage", ArgumentSemantic.Strong)]
	UILabel ChatMessage { get; set; }

	// @property (nonatomic, strong) NSValue * textInsets __attribute__((annotate("ui_appearance_selector")));
	[Export ("textInsets", ArgumentSemantic.Strong)]
	NSValue TextInsets { get; set; }

	// @property (nonatomic, strong) UIColor * textColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textColor", ArgumentSemantic.Strong)]
	UIColor TextColor { get; set; }

	// @property (nonatomic, strong) UIFont * textFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFont", ArgumentSemantic.Strong)]
	UIFont TextFont { get; set; }
}

// @interface ZDCSystemTriggerCell : ZDCChatCell
[BaseType (typeof(ZDCChatCell))]
interface ZDCSystemTriggerCell
{
	// @property (nonatomic, strong) UILabel * chatMessage;
	[Export ("chatMessage", ArgumentSemantic.Strong)]
	UILabel ChatMessage { get; set; }

	// @property (nonatomic, strong) NSValue * textInsets __attribute__((annotate("ui_appearance_selector")));
	[Export ("textInsets", ArgumentSemantic.Strong)]
	NSValue TextInsets { get; set; }

	// @property (nonatomic, strong) UIColor * textColor __attribute__((annotate("ui_appearance_selector")));
	[Export ("textColor", ArgumentSemantic.Strong)]
	UIColor TextColor { get; set; }

	// @property (nonatomic, strong) UIFont * textFont __attribute__((annotate("ui_appearance_selector")));
	[Export ("textFont", ArgumentSemantic.Strong)]
	UIFont TextFont { get; set; }
}

// @interface ZDCAccountOfflineCell : ZDCChatTimedOutCell
[BaseType (typeof(ZDCChatTimedOutCell))]
interface ZDCAccountOfflineCell
{
}

// @interface ZDCTypingDots : UIView
[BaseType (typeof(UIView))]
interface ZDCTypingDots
{
	// @property (nonatomic, strong) UIColor * dotColor;
	[Export ("dotColor", ArgumentSemantic.Strong)]
	UIColor DotColor { get; set; }

	// @property (nonatomic, strong) UIColor * dotHighlightColor;
	[Export ("dotHighlightColor", ArgumentSemantic.Strong)]
	UIColor DotHighlightColor { get; set; }

	// @property (readonly, assign, nonatomic) BOOL animating;
	[Export ("animating")]
	bool Animating { get; }

	// -(instancetype)initWithHeight:(float)height;
	[Export ("initWithHeight:")]
	IntPtr Constructor (float height);

	// -(void)startAnimating;
	[Export ("startAnimating")]
	void StartAnimating ();

	// -(void)stopAnimating;
	[Export ("stopAnimating")]
	void StopAnimating ();
}

// @interface ZDCAgentTypingCell : ZDCChatCell
[BaseType (typeof(ZDCChatCell))]
interface ZDCAgentTypingCell
{
	// @property (nonatomic, strong) ZDCTypingDots * dots;
	[Export ("dots", ArgumentSemantic.Strong)]
	ZDCTypingDots Dots { get; set; }

	// @property (nonatomic, strong) ZDCChatAvatar * avatar;
	[Export ("avatar", ArgumentSemantic.Strong)]
	ZDCChatAvatar Avatar { get; set; }
}

// typedef void (^ZDCVisitorConfigBlock)(ZDCVisitorInfo *);
delegate void ZDCVisitorConfigBlock (ZDCVisitorInfo arg0);

// typedef void (^ZDCConfigBlock)(ZDCConfig *);
delegate void ZDCConfigBlock (ZDCConfig arg0);

// @interface ZDCChat : NSObject
[BaseType (typeof(NSObject))]
interface ZDCChat
{
	// @property (nonatomic, strong) ZDCChatAPI * api;
	[Export ("api", ArgumentSemantic.Strong)]
	ZDCChatAPI Api { get; set; }

	// @property (nonatomic, strong) id<ZDCChatOverlayDelegate> overlay;
	[Export ("overlay", ArgumentSemantic.Strong)]
	ZDCChatOverlayDelegate Overlay { get; set; }

	// @property (nonatomic, strong) ZDCChatViewController * chatViewController;
	[Export ("chatViewController", ArgumentSemantic.Strong)]
	ZDCChatViewController ChatViewController { get; set; }

	// @property (nonatomic, strong) ZDCOfflineMessageHandler * offlineMessageHandler;
	[Export ("offlineMessageHandler", ArgumentSemantic.Strong)]
	ZDCOfflineMessageHandler OfflineMessageHandler { get; set; }

	// @property (assign, nonatomic) BOOL shouldResumeOnLaunch;
	[Export ("shouldResumeOnLaunch")]
	bool ShouldResumeOnLaunch { get; set; }

	// @property (assign, nonatomic) BOOL hidesBottomBarWhenPushed;
	[Export ("hidesBottomBarWhenPushed")]
	bool HidesBottomBarWhenPushed { get; set; }

	// @property (readonly, assign, nonatomic) NSInteger unreadMessagesCount;
	[Export ("unreadMessagesCount")]
	nint UnreadMessagesCount { get; }

	// +(instancetype)instance;
	[Static]
	[Export ("instance")]
	ZDCChat Instance ();

	// +(void)initializeWithAccountKey:(NSString *)accountKey;
	[Static]
	[Export ("initializeWithAccountKey:")]
	void InitializeWithAccountKey (string accountKey);

	// +(void)updateVisitor:(ZDCVisitorConfigBlock)visitorConfig;
	[Static]
	[Export ("updateVisitor:")]
	void UpdateVisitor (ZDCVisitorConfigBlock visitorConfig);

	// +(void)startChat:(ZDCConfigBlock)sessionConfig;
	[Static]
	[Export ("startChat:")]
	void StartChat (ZDCConfigBlock sessionConfig);

	// +(void)startChatIn:(UINavigationController *)navController withConfig:(ZDCConfigBlock)configOverride;
	[Static]
	[Export ("startChatIn:withConfig:")]
	void StartChatIn (UINavigationController navController, ZDCConfigBlock configOverride);

	// +(void)endChat;
	[Static]
	[Export ("endChat")]
	void EndChat ();

	// +(void)minimiseChat;
	[Static]
	[Export ("minimiseChat")]
	void MinimiseChat ();
}
