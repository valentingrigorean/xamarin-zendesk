using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using ZendeskProviderSDK;
using ZendeskSDK;

// @protocol ZDKCreateRequestUIDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDKCreateRequestUIDelegate
{
	// @required -(ZDKNavBarCreateRequestUIType)navBarCreateRequestUIType;
	[Abstract]
	[Export ("navBarCreateRequestUIType")]
	[Verify (MethodToProperty)]
	ZDKNavBarCreateRequestUIType NavBarCreateRequestUIType { get; }

	// @required -(UIImage *)createRequestBarButtonImage;
	[Abstract]
	[Export ("createRequestBarButtonImage")]
	[Verify (MethodToProperty)]
	UIImage CreateRequestBarButtonImage { get; }

	// @required -(NSString *)createRequestBarButtonLocalizedLabel;
	[Abstract]
	[Export ("createRequestBarButtonLocalizedLabel")]
	[Verify (MethodToProperty)]
	string CreateRequestBarButtonLocalizedLabel { get; }
}

// @protocol ZDKHelpCenterArticleRatingStateProtocol <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDKHelpCenterArticleRatingStateProtocol
{
	// @required -(void)updateButtonStatesForButtonAtIndexSelected:(NSUInteger)index;
	[Abstract]
	[Export ("updateButtonStatesForButtonAtIndexSelected:")]
	void UpdateButtonStatesForButtonAtIndexSelected (nuint index);
}

// @protocol ZDKHelpCenterArticleRatingHandlerProtocol <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDKHelpCenterArticleRatingHandlerProtocol
{
	// @required -(NSInteger)currentArticleVote;
	[Abstract]
	[Export ("currentArticleVote")]
	[Verify (MethodToProperty)]
	nint CurrentArticleVote { get; }

	// @required -(void)articleRatingVoteSelected:(id<ZDKHelpCenterArticleRatingStateProtocol>)ratingState atIndex:(NSInteger)index;
	[Abstract]
	[Export ("articleRatingVoteSelected:atIndex:")]
	void AtIndex (ZDKHelpCenterArticleRatingStateProtocol ratingState, nint index);
}

// typedef void (^ZDKHelpCenterCellConfigureBlock)(id, id);
delegate void ZDKHelpCenterCellConfigureBlock (NSObject arg0, NSObject arg1);

// @interface ZDKHelpCenterDataSource : NSObject <UITableViewDataSource>
[BaseType (typeof(NSObject))]
interface ZDKHelpCenterDataSource : IUITableViewDataSource
{
	// @property (readonly, assign, nonatomic) BOOL hasItems;
	[Export ("hasItems")]
	bool HasItems { get; }

	// @property (readonly, copy, nonatomic) NSArray * items;
	[Export ("items", ArgumentSemantic.Copy)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] Items { get; }

	// @property (readonly, nonatomic, strong) ZDKHelpCenterProvider * provider;
	[Export ("provider", ArgumentSemantic.Strong)]
	ZDKHelpCenterProvider Provider { get; }

	// -(void)reloadData;
	[Export ("reloadData")]
	void ReloadData ();

	// -(id)itemAtIndexPath:(NSIndexPath *)indexPath;
	[Export ("itemAtIndexPath:")]
	NSObject ItemAtIndexPath (NSIndexPath indexPath);

	// +(NSString *)cellIdentifierForDataSource;
	[Static]
	[Export ("cellIdentifierForDataSource")]
	[Verify (MethodToProperty)]
	string CellIdentifierForDataSource { get; }
}

// @interface ZDKHelpCenterAttachmentsDataSource : ZDKHelpCenterDataSource
[BaseType (typeof(ZDKHelpCenterDataSource))]
interface ZDKHelpCenterAttachmentsDataSource
{
	// -(instancetype)initWithArticleId:(NSNumber *)articleId;
	[Export ("initWithArticleId:")]
	IntPtr Constructor (NSNumber articleId);
}

// @protocol ZDKHelpCenterConversationsUIDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDKHelpCenterConversationsUIDelegate
{
	// @required -(ZDKNavBarConversationsUIType)navBarConversationsUIType;
	[Abstract]
	[Export ("navBarConversationsUIType")]
	[Verify (MethodToProperty)]
	ZDKNavBarConversationsUIType NavBarConversationsUIType { get; }

	// @required -(UIImage *)conversationsBarButtonImage;
	[Abstract]
	[Export ("conversationsBarButtonImage")]
	[Verify (MethodToProperty)]
	UIImage ConversationsBarButtonImage { get; }

	// @required -(ZDKContactUsVisibility)active;
	[Abstract]
	[Export ("active")]
	[Verify (MethodToProperty)]
	ZDKContactUsVisibility Active { get; }

	// @optional -(NSString *)conversationsBarButtonLocalizedLabel;
	[Export ("conversationsBarButtonLocalizedLabel")]
	[Verify (MethodToProperty)]
	string ConversationsBarButtonLocalizedLabel { get; }
}

// @protocol ZDKHelpCenterDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDKHelpCenterDelegate
{
	[Wrap ("WeakUiDelegate"), Abstract]
	ZDKHelpCenterConversationsUIDelegate UiDelegate { get; set; }

	// @required @property (nonatomic, weak) id<ZDKHelpCenterConversationsUIDelegate> uiDelegate;
	[Abstract]
	[NullAllowed, Export ("uiDelegate", ArgumentSemantic.Weak)]
	NSObject WeakUiDelegate { get; set; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString *const ZDKHelpCenterErrorDomain;
	[Field ("ZDKHelpCenterErrorDomain", "__Internal")]
	NSString ZDKHelpCenterErrorDomain { get; }

	// extern NSString *const ZDKHelpCenterNoCategoriesLocalisedDescription;
	[Field ("ZDKHelpCenterNoCategoriesLocalisedDescription", "__Internal")]
	NSString ZDKHelpCenterNoCategoriesLocalisedDescription { get; }

	// extern NSString *const ZDKHelpCenterNoSectionsLocalisedDescription;
	[Field ("ZDKHelpCenterNoSectionsLocalisedDescription", "__Internal")]
	NSString ZDKHelpCenterNoSectionsLocalisedDescription { get; }

	// extern NSString *const ZDKHelpCenterNoArticlesForLabelsDescription;
	[Field ("ZDKHelpCenterNoArticlesForLabelsDescription", "__Internal")]
	NSString ZDKHelpCenterNoArticlesForLabelsDescription { get; }

	// extern NSString *const ZDKHelpCenterEmptyHelpCenterDescription;
	[Field ("ZDKHelpCenterEmptyHelpCenterDescription", "__Internal")]
	NSString ZDKHelpCenterEmptyHelpCenterDescription { get; }
}

// @interface ZDKHelpCenterUi : NSObject
[BaseType (typeof(NSObject))]
interface ZDKHelpCenterUi
{
	// +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterOverview;
	[Static]
	[Export ("buildHelpCenterOverview")]
	[Verify (MethodToProperty)]
	ZDKHelpCenterDelegate BuildHelpCenterOverview { get; }

	// +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterOverviewWithConfigs:(NSArray<ZDKUiConfiguration> * _Nonnull)configs;
	[Static]
	[Export ("buildHelpCenterOverviewWithConfigs:")]
	[Verify (StronglyTypedNSArray)]
	ZDKHelpCenterDelegate BuildHelpCenterOverviewWithConfigs (NSObject[] configs);

	// +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterArticle:(ZDKHelpCenterArticle * _Nonnull)article;
	[Static]
	[Export ("buildHelpCenterArticle:")]
	ZDKHelpCenterDelegate BuildHelpCenterArticle (ZDKHelpCenterArticle article);

	// +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterArticle:(ZDKHelpCenterArticle * _Nonnull)article andConfigs:(NSArray<ZDKUiConfiguration> * _Nonnull)configs;
	[Static]
	[Export ("buildHelpCenterArticle:andConfigs:")]
	[Verify (StronglyTypedNSArray)]
	ZDKHelpCenterDelegate BuildHelpCenterArticle (ZDKHelpCenterArticle article, NSObject[] configs);

	// +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterArticleWithArticleId:(NSString * _Nonnull)articleId;
	[Static]
	[Export ("buildHelpCenterArticleWithArticleId:")]
	ZDKHelpCenterDelegate BuildHelpCenterArticleWithArticleId (string articleId);

	// +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterArticleWithArticleId:(NSString * _Nonnull)articleId andConfigs:(NSArray<ZDKUiConfiguration> * _Nonnull)configs;
	[Static]
	[Export ("buildHelpCenterArticleWithArticleId:andConfigs:")]
	[Verify (StronglyTypedNSArray)]
	ZDKHelpCenterDelegate BuildHelpCenterArticleWithArticleId (string articleId, NSObject[] configs);
}

// @interface ZDKLayoutGuideApplicator : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface ZDKLayoutGuideApplicator
{
	// -(instancetype _Nonnull)initWithViewController:(UIViewController * _Nonnull)viewController topLevelView:(UIView * _Nonnull)topLevelView layoutPosition:(ZDKLayoutGuideApplicatorPosition)position __attribute__((objc_designated_initializer));
	[Export ("initWithViewController:topLevelView:layoutPosition:")]
	[DesignatedInitializer]
	IntPtr Constructor (UIViewController viewController, UIView topLevelView, ZDKLayoutGuideApplicatorPosition position);
}

// @protocol ZDKSpinnerDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDKSpinnerDelegate
{
	// @required @property (assign, nonatomic) CGRect frame;
	[Abstract]
	[Export ("frame", ArgumentSemantic.Assign)]
	CGRect Frame { get; set; }

	// @required @property (getter = isHidden, assign, nonatomic) BOOL hidden;
	[Abstract]
	[Export ("hidden")]
	bool Hidden { [Bind ("isHidden")] get; set; }

	// @required @property (assign, nonatomic) CGPoint center;
	[Abstract]
	[Export ("center", ArgumentSemantic.Assign)]
	CGPoint Center { get; set; }

	// @required -(void)startAnimating;
	[Abstract]
	[Export ("startAnimating")]
	void StartAnimating ();

	// @required -(void)stopAnimating;
	[Abstract]
	[Export ("stopAnimating")]
	void StopAnimating ();
}

// typedef id<ZDKSpinnerDelegate> (^ZDUISpinner)(CGRect);
delegate ZDKSpinnerDelegate ZDUISpinner (CGRect arg0);

// @interface ZDKSupportAttachmentCell : UITableViewCell <UIAppearanceContainer>
[BaseType (typeof(UITableViewCell))]
interface ZDKSupportAttachmentCell : IUIAppearanceContainer
{
	// @property (readonly, nonatomic, strong) UILabel * fileSize;
	[Export ("fileSize", ArgumentSemantic.Strong)]
	UILabel FileSize { get; }

	// @property (readonly, nonatomic, strong) UILabel * title;
	[Export ("title", ArgumentSemantic.Strong)]
	UILabel Title { get; }

	// +(NSString *)cellIdentifier;
	[Static]
	[Export ("cellIdentifier")]
	[Verify (MethodToProperty)]
	string CellIdentifier { get; }
}

// @interface ZDKToastViewWrapper : UIView
[BaseType (typeof(UIView))]
interface ZDKToastViewWrapper
{
	// @property (readonly, nonatomic) BOOL isVisible;
	[Export ("isVisible")]
	bool IsVisible { get; }

	// -(void)showErrorInViewController:(UIViewController *)viewController withMessage:(NSString *)message;
	[Export ("showErrorInViewController:withMessage:")]
	void ShowErrorInViewController (UIViewController viewController, string message);

	// -(void)showErrorInViewController:(UIViewController *)viewController withMessage:(NSString *)message duration:(CGFloat)duration;
	[Export ("showErrorInViewController:withMessage:duration:")]
	void ShowErrorInViewController (UIViewController viewController, string message, nfloat duration);

	// -(void)showErrorInViewController:(UIViewController *)viewController withMessage:(NSString *)message buttonTitle:(NSString *)buttonTitle action:(void (^)(void))action;
	[Export ("showErrorInViewController:withMessage:buttonTitle:action:")]
	void ShowErrorInViewController (UIViewController viewController, string message, string buttonTitle, Action action);

	// -(void)dismiss;
	[Export ("dismiss")]
	void Dismiss ();

	// -(void)hideToastView:(BOOL)hide;
	[Export ("hideToastView:")]
	void HideToastView (bool hide);
}

// @interface ZDKUIUtil : NSObject
[BaseType (typeof(NSObject))]
interface ZDKUIUtil
{
	// +(id)appearanceValueForClass:(Class)viewClass selector:(SEL)selector;
	[Static]
	[Export ("appearanceValueForClass:selector:")]
	NSObject AppearanceValueForClass (Class viewClass, Selector selector);

	// +(id)appearanceValueForClass:(Class)viewClass whenContainedIn:(Class<UIAppearanceContainer>)containerClass selector:(SEL)selector;
	[Static]
	[Export ("appearanceValueForClass:whenContainedIn:selector:")]
	NSObject AppearanceValueForClass (Class viewClass, UIAppearanceContainer containerClass, Selector selector);

	// +(id)appearanceValueForView:(UIView *)view selector:(SEL)selector;
	[Static]
	[Export ("appearanceValueForView:selector:")]
	NSObject AppearanceValueForView (UIView view, Selector selector);

	// +(BOOL)isOlderVersion:(NSString *)majorVersionNumber;
	[Static]
	[Export ("isOlderVersion:")]
	bool IsOlderVersion (string majorVersionNumber);

	// +(BOOL)isNewerVersion:(NSString *)majorVersionNumber;
	[Static]
	[Export ("isNewerVersion:")]
	bool IsNewerVersion (string majorVersionNumber);

	// +(BOOL)isSameVersion:(NSNumber *)majorVersionNumber;
	[Static]
	[Export ("isSameVersion:")]
	bool IsSameVersion (NSNumber majorVersionNumber);

	// +(CGFloat)separatorHeightForScreenScale;
	[Static]
	[Export ("separatorHeightForScreenScale")]
	[Verify (MethodToProperty)]
	nfloat SeparatorHeightForScreenScale { get; }

	// +(UIButton *)buildButtonWithFrame:(CGRect)frame andTitle:(NSString *)title;
	[Static]
	[Export ("buildButtonWithFrame:andTitle:")]
	UIButton BuildButtonWithFrame (CGRect frame, string title);

	// +(UIInterfaceOrientation)currentInterfaceOrientation;
	[Static]
	[Export ("currentInterfaceOrientation")]
	[Verify (MethodToProperty)]
	UIInterfaceOrientation CurrentInterfaceOrientation { get; }

	// +(CGFloat)scaledHeightForSize:(CGSize)size constrainedByWidth:(CGFloat)width;
	[Static]
	[Export ("scaledHeightForSize:constrainedByWidth:")]
	nfloat ScaledHeightForSize (CGSize size, nfloat width);

	// +(BOOL)isPad;
	[Static]
	[Export ("isPad")]
	[Verify (MethodToProperty)]
	bool IsPad { get; }

	// +(BOOL)isLandscape;
	[Static]
	[Export ("isLandscape")]
	[Verify (MethodToProperty)]
	bool IsLandscape { get; }

	// +(UIImage *)fixOrientationOfImage:(UIImage *)image;
	[Static]
	[Export ("fixOrientationOfImage:")]
	UIImage FixOrientationOfImage (UIImage image);

	// +(BOOL)shouldEnableAttachments:(UIViewController *)viewController;
	[Static]
	[Export ("shouldEnableAttachments:")]
	bool ShouldEnableAttachments (UIViewController viewController);
}

// @interface ZendeskFabric : NSObject
[BaseType (typeof(NSObject))]
interface ZendeskFabric
{
}

// @interface HelpCenterArticleVotingHandler : NSObject <ZDKHelpCenterArticleRatingHandlerProtocol>
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface HelpCenterArticleVotingHandler : IZDKHelpCenterArticleRatingHandlerProtocol
{
	// -(instancetype _Nonnull)initWithArticleId:(NSString * _Nonnull)articleId andLocale:(NSString * _Nonnull)locale;
	[Export ("initWithArticleId:andLocale:")]
	IntPtr Constructor (string articleId, string locale);

	// -(void)articleRatingVoteSelected:(id<ZDKHelpCenterArticleRatingStateProtocol> _Nonnull)ratingState atIndex:(NSInteger)index;
	[Export ("articleRatingVoteSelected:atIndex:")]
	void ArticleRatingVoteSelected (ZDKHelpCenterArticleRatingStateProtocol ratingState, nint index);

	// -(NSInteger)currentArticleVote __attribute__((warn_unused_result));
	[Export ("currentArticleVote")]
	[Verify (MethodToProperty)]
	nint CurrentArticleVote { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HelpCenterArticleVotingHandler New ();
}

// @protocol ZDKUiConfiguration <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ZDKUiConfiguration
{
}

// @interface ZDKHelpCenterUiConfiguration : NSObject <ZDKUiConfiguration>
[BaseType (typeof(NSObject))]
interface ZDKHelpCenterUiConfiguration : IZDKUiConfiguration
{
	// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull labels;
	[Export ("labels", ArgumentSemantic.Copy)]
	string[] Labels { get; set; }

	// @property (nonatomic) ZDKHelpCenterOverviewGroupType groupType;
	[Export ("groupType", ArgumentSemantic.Assign)]
	ZDKHelpCenterOverviewGroupType GroupType { get; set; }

	// @property (nonatomic) BOOL hideContactSupport;
	[Export ("hideContactSupport")]
	bool HideContactSupport { get; set; }

	// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull groupIds;
	[Export ("groupIds", ArgumentSemantic.Copy)]
	NSNumber[] GroupIds { get; set; }

	// @property (readonly, nonatomic, strong) ZDKHelpCenterOverviewContentModel * _Nonnull overviewContentModel;
	[Export ("overviewContentModel", ArgumentSemantic.Strong)]
	ZDKHelpCenterOverviewContentModel OverviewContentModel { get; }
}

// @interface ZDKRequestAttachment : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface ZDKRequestAttachment
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull filename;
	[Export ("filename")]
	string Filename { get; }

	// @property (readonly, copy, nonatomic) NSData * _Nonnull data;
	[Export ("data", ArgumentSemantic.Copy)]
	NSData Data { get; }

	// @property (readonly, nonatomic) enum ZDKFileType fileType;
	[Export ("fileType")]
	ZDKFileType FileType { get; }

	// -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename data:(NSData * _Nonnull)data fileType:(enum ZDKFileType)fileType __attribute__((objc_designated_initializer));
	[Export ("initWithFilename:data:fileType:")]
	[DesignatedInitializer]
	IntPtr Constructor (string filename, NSData data, ZDKFileType fileType);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	ZDKRequestAttachment New ();
}

// @interface ZDKRequestUi : NSObject
[BaseType (typeof(NSObject))]
interface ZDKRequestUi
{
	// +(UIViewController * _Nonnull)buildRequestList __attribute__((warn_unused_result));
	[Static]
	[Export ("buildRequestList")]
	[Verify (MethodToProperty)]
	UIViewController BuildRequestList { get; }

	// +(UIViewController * _Nonnull)buildRequestListWith:(NSArray<id<ZDKUiConfiguration>> * _Nonnull)configurations __attribute__((warn_unused_result));
	[Static]
	[Export ("buildRequestListWith:")]
	UIViewController BuildRequestListWith (ZDKUiConfiguration[] configurations);

	// +(UIViewController * _Nonnull)buildRequestUi __attribute__((warn_unused_result));
	[Static]
	[Export ("buildRequestUi")]
	[Verify (MethodToProperty)]
	UIViewController BuildRequestUi { get; }

	// +(UIViewController * _Nonnull)buildRequestUiWith:(NSArray<id<ZDKUiConfiguration>> * _Nonnull)configurations __attribute__((warn_unused_result));
	[Static]
	[Export ("buildRequestUiWith:")]
	UIViewController BuildRequestUiWith (ZDKUiConfiguration[] configurations);

	// +(UIViewController * _Nonnull)buildRequestUiWithRequestId:(NSString * _Nonnull)requestId __attribute__((warn_unused_result));
	[Static]
	[Export ("buildRequestUiWithRequestId:")]
	UIViewController BuildRequestUiWithRequestId (string requestId);

	// +(UIViewController * _Nonnull)buildRequestUiWithRequestId:(NSString * _Nonnull)requestId configurations:(NSArray<id<ZDKUiConfiguration>> * _Nonnull)configurations __attribute__((warn_unused_result));
	[Static]
	[Export ("buildRequestUiWithRequestId:configurations:")]
	UIViewController BuildRequestUiWithRequestId (string requestId, ZDKUiConfiguration[] configurations);
}

// @interface ZDKRequestUiConfiguration : NSObject <ZDKUiConfiguration>
[BaseType (typeof(NSObject))]
interface ZDKRequestUiConfiguration : IZDKUiConfiguration
{
	// @property (copy, nonatomic) NSString * _Nonnull subject;
	[Export ("subject")]
	string Subject { get; set; }

	// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
	[Export ("tags", ArgumentSemantic.Copy)]
	string[] Tags { get; set; }

	// @property (copy, nonatomic) NSArray<ZDKCustomField *> * _Nonnull fields;
	[Export ("fields", ArgumentSemantic.Copy)]
	ZDKCustomField[] Fields { get; set; }

	// @property (nonatomic, strong) NSNumber * _Nullable ticketFormID;
	[NullAllowed, Export ("ticketFormID", ArgumentSemantic.Strong)]
	NSNumber TicketFormID { get; set; }

	// @property (copy, nonatomic) NSArray<ZDKRequestAttachment *> * _Nonnull fileAttachments;
	[Export ("fileAttachments", ArgumentSemantic.Copy)]
	ZDKRequestAttachment[] FileAttachments { get; set; }
}

// @interface ZDKSuasDebugLogger : NSObject
[BaseType (typeof(NSObject))]
interface ZDKSuasDebugLogger
{
	// @property (nonatomic, class) BOOL enabled;
	[Static]
	[Export ("enabled")]
	bool Enabled { get; set; }
}

// @interface ZDKTheme : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface ZDKTheme
{
	// @property (readonly, nonatomic, strong, class) ZDKTheme * _Nonnull currentTheme;
	[Static]
	[Export ("currentTheme", ArgumentSemantic.Strong)]
	ZDKTheme CurrentTheme { get; }

	// @property (nonatomic, strong) UIColor * _Nonnull primaryColor;
	[Export ("primaryColor", ArgumentSemantic.Strong)]
	UIColor PrimaryColor { get; set; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	ZDKTheme New ();
}

// @interface ZDKConstants : NSObject
[BaseType (typeof(NSObject))]
interface ZDKConstants
{
	// +(UIColor * _Nonnull)colorForToast __attribute__((warn_unused_result));
	[Static]
	[Export ("colorForToast")]
	[Verify (MethodToProperty)]
	UIColor ColorForToast { get; }
}

// @interface ZendeskWrapperUIX : NSObject
[BaseType (typeof(NSObject))]
interface ZendeskWrapperUIX
{
	// +(void)setupActionHandlers;
	[Static]
	[Export ("setupActionHandlers")]
	void SetupActionHandlers ();
}
