//
// ApiDefinition.cs
//
// Author:
//       valentingrigorean <valentin.grigorean1@gmail.com>
//
// Copyright (c) 2018 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace Xamarin.Zendesk.iOS.ChatApi
{
    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
    //


    // @interface ZDCAPIConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCAPIConfig
    {
        // @property (nonatomic, strong) NSString * visitorPathOne;
        [Export("visitorPathOne", ArgumentSemantic.Strong)]
        string VisitorPathOne { get; set; }

        // @property (nonatomic, strong) NSString * visitorPathTwo;
        [Export("visitorPathTwo", ArgumentSemantic.Strong)]
        string VisitorPathTwo { get; set; }

        // @property (nonatomic, strong) NSString * department;
        [Export("department", ArgumentSemantic.Strong)]
        string Department { get; set; }

        // @property (nonatomic, strong) NSArray * tags;
        [Export("tags", ArgumentSemantic.Strong)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] Tags { get; set; }
    }

    // @interface ZDCLog : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCLog
    {
        // +(void)e:(NSString *)format, ...;
        [Static, Internal]
        [Export("e:", IsVariadic = true)]
        void E(string format, IntPtr varArgs);

        // +(void)w:(NSString *)format, ...;
        [Static, Internal]
        [Export("w:", IsVariadic = true)]
        void W(string format, IntPtr varArgs);

        // +(void)i:(NSString *)format, ...;
        [Static, Internal]
        [Export("i:", IsVariadic = true)]
        void I(string format, IntPtr varArgs);

        // +(void)d:(NSString *)format, ...;
        [Static, Internal]
        [Export("d:", IsVariadic = true)]
        void D(string format, IntPtr varArgs);

        // +(void)v:(NSString *)format, ...;
        [Static, Internal]
        [Export("v:", IsVariadic = true)]
        void V(string format, IntPtr varArgs);

        // +(void)enable:(BOOL)enabled;
        [Static]
        [Export("enable:")]
        void Enable(bool enabled);

        // +(void)setLogLevel:(ZDCLogLevel)level;
        [Static]
        [Export("setLogLevel:")]
        void SetLogLevel(ZDCLogLevel level);

        // +(void)internal:(NSString *)format, ...;
        [Static, Internal]
        [Export("internal:", IsVariadic = true)]
        void Internal(string format, IntPtr varArgs);
    }

    // @interface ZDCChatFile : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCChatFile
    {
        // @property (nonatomic, strong) NSString * fileName;
        [Export("fileName", ArgumentSemantic.Strong)]
        string FileName { get; set; }

        // @property (nonatomic, strong) NSString * mimeType;
        [Export("mimeType", ArgumentSemantic.Strong)]
        string MimeType { get; set; }

        // @property (nonatomic, strong) NSData * data;
        [Export("data", ArgumentSemantic.Strong)]
        NSData Data { get; set; }

        // @property (nonatomic, strong) NSString * path;
        [Export("path", ArgumentSemantic.Strong)]
        string Path { get; set; }

        // @property (nonatomic, strong) UIImage * image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (assign, nonatomic) ZDCFileTransferStatus status;
        [Export("status", ArgumentSemantic.Assign)]
        ZDCFileTransferStatus Status { get; set; }

        // @property (assign, nonatomic) ZDCTransferError errorType;
        [Export("errorType", ArgumentSemantic.Assign)]
        ZDCTransferError ErrorType { get; set; }

        // +(NSString *)derivefileExtension:(NSString *)fileName;
        [Static]
        [Export("derivefileExtension:")]
        string DerivefileExtension(string fileName);

        // +(NSString *)mimeTypeForData:(NSData *)data andFileExtension:(NSString *)fileExtension;
        [Static]
        [Export("mimeTypeForData:andFileExtension:")]
        string MimeTypeForData(NSData data, string fileExtension);

        // -(BOOL)isPresentableImage;
        [Export("isPresentableImage")]
        // [Verify(MethodToProperty)]
        bool IsPresentableImage { get; }
    }

    // @protocol ZDCProgressMonitor <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject), Name = "ZDCProgressMonitor")]
    interface IZDCProgressMonitor
    {
        // @optional -(void)setProgress:(float)progress;
        [Export("setProgress:")]
        void SetProgress(float progress);
    }

    // @protocol ZDCUploadDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ZDCUploadDelegate
    {
        // @required -(void)progressUpdate:(float)progress;
        [Abstract]
        [Export("progressUpdate:")]
        void ProgressUpdate(float progress);
    }

    // @interface ZDCChatUpload : ZDCChatFile <ZDCProgressMonitor>
    [BaseType(typeof(ZDCChatFile))]
    interface ZDCChatUpload : IZDCProgressMonitor
    {
        // @property (nonatomic, strong) NSString * fileExtension;
        [Export("fileExtension", ArgumentSemantic.Strong)]
        string FileExtension { get; set; }

        // @property (nonatomic, strong) NSNumber * fileSize;
        [Export("fileSize", ArgumentSemantic.Strong)]
        NSNumber FileSize { get; set; }

        // @property (nonatomic, strong) NSString * uploadURL;
        [Export("uploadURL", ArgumentSemantic.Strong)]
        string UploadURL { get; set; }

        // @property (assign, nonatomic) float progress;
        [Export("progress")]
        float Progress { get; }

        // @property (nonatomic, weak) id<ZDCChatIO> chatIO;
        [Export("chatIO", ArgumentSemantic.Weak)]
        ZDCChatIO ChatIO { get; set; }

        // @property (nonatomic, weak) id<ZDCUploadDelegate> progressListener;
        [Export("progressListener", ArgumentSemantic.Weak)]
        ZDCUploadDelegate ProgressListener { get; set; }

        // -(instancetype)initWithIO:(id<ZDCChatIO>)chatIO fileData:(NSData *)data filePath:(NSString *)path image:(UIImage *)image fileName:(NSString *)filename andFileSize:(long long)fileSize;
        [Export("initWithIO:fileData:filePath:image:fileName:andFileSize:")]
        IntPtr Constructor(ZDCChatIO chatIO, NSData data, string path, UIImage image, string filename, long fileSize);

        // -(void)resend;
        [Export("resend")]
        void Resend();

        // +(BOOL)validUpload:(NSData *)data filePath:(NSString *)path image:(UIImage *)image fileName:(NSString *)filename andFileSize:(long long)fileSize;
        [Static]
        [Export("validUpload:filePath:image:fileName:andFileSize:")]
        bool ValidUpload(NSData data, string path, UIImage image, string filename, long fileSize);
    }

    // @interface ZDCChatAttachment : ZDCChatFile
    [BaseType(typeof(ZDCChatFile))]
    interface ZDCChatAttachment
    {
        // @property (nonatomic, strong) NSString * url;
        [Export("url", ArgumentSemantic.Strong)]
        string Url { get; set; }

        // @property (nonatomic, strong) NSString * thumbnailURL;
        [Export("thumbnailURL", ArgumentSemantic.Strong)]
        string ThumbnailURL { get; set; }

        // @property (nonatomic, strong) NSNumber * fileSize;
        [Export("fileSize", ArgumentSemantic.Strong)]
        NSNumber FileSize { get; set; }

        // -(void)download;
        [Export("download")]
        void Download();
    }

    // @interface ZDCChatEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCChatEvent
    {
        // @property (nonatomic, strong) NSString * eventId;
        [Export("eventId", ArgumentSemantic.Strong)]
        string EventId { get; set; }

        // @property (nonatomic, strong) NSNumber * timestamp;
        [Export("timestamp", ArgumentSemantic.Strong)]
        NSNumber Timestamp { get; set; }

        // @property (nonatomic, strong) NSString * nickname;
        [Export("nickname", ArgumentSemantic.Strong)]
        string Nickname { get; set; }

        // @property (nonatomic, strong) NSString * displayName;
        [Export("displayName", ArgumentSemantic.Strong)]
        string DisplayName { get; set; }

        // @property (nonatomic, strong) NSString * message;
        [Export("message", ArgumentSemantic.Strong)]
        string Message { get; set; }

        // @property (assign, nonatomic) ZDCChatEventType type;
        [Export("type", ArgumentSemantic.Assign)]
        ZDCChatEventType Type { get; set; }

        // @property (assign, nonatomic) BOOL verified;
        [Export("verified")]
        bool Verified { get; set; }

        // @property (nonatomic, strong) NSNumber * visitorQueue;
        [Export("visitorQueue", ArgumentSemantic.Strong)]
        NSNumber VisitorQueue { get; set; }

        // @property (assign, nonatomic) BOOL firstMessage;
        [Export("firstMessage")]
        bool FirstMessage { get; set; }

        // @property (assign, nonatomic) BOOL leadMessage;
        [Export("leadMessage")]
        bool LeadMessage { get; set; }

        // @property (nonatomic, strong) NSMutableArray * options;
        [Export("options", ArgumentSemantic.Strong)]
        NSMutableArray Options { get; set; }

        // @property (assign, nonatomic) NSInteger selectedOptionIndex;
        [Export("selectedOptionIndex")]
        nint SelectedOptionIndex { get; set; }

        // @property (nonatomic, strong) ZDCChatUpload * fileUpload;
        [Export("fileUpload", ArgumentSemantic.Strong)]
        ZDCChatUpload FileUpload { get; set; }

        // @property (nonatomic, strong) ZDCChatAttachment * attachment;
        [Export("attachment", ArgumentSemantic.Strong)]
        ZDCChatAttachment Attachment { get; set; }

        // @property (assign, nonatomic) ZDCChatRating rating;
        [Export("rating", ArgumentSemantic.Assign)]
        ZDCChatRating Rating { get; set; }

        // @property (nonatomic, strong) NSString * ratingComment;
        [Export("ratingComment", ArgumentSemantic.Strong)]
        string RatingComment { get; set; }
    }

    // @interface ZDCChatAgent : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCChatAgent : INativeObject
    {
        // @property (nonatomic, strong) NSString * agentId;
        [Export("agentId", ArgumentSemantic.Strong)]
        string AgentId { get; set; }

        // @property (nonatomic, strong) NSString * displayName;
        [Export("displayName", ArgumentSemantic.Strong)]
        string DisplayName { get; set; }

        // @property (nonatomic, strong) NSString * title;
        [Export("title", ArgumentSemantic.Strong)]
        string Title { get; set; }

        // @property (nonatomic, strong) NSString * avatarURL;
        [Export("avatarURL", ArgumentSemantic.Strong)]
        string AvatarURL { get; set; }

        // @property (assign, nonatomic) BOOL typing;
        [Export("typing")]
        bool Typing { get; set; }
    }

    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface ZDCChatIO
    {

    }

    // @interface ZDCVisitorInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCVisitorInfo
    {
        // @property (nonatomic, strong) NSString * name;
        [Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }

        // @property (nonatomic, strong) NSString * email;
        [Export("email", ArgumentSemantic.Strong)]
        string Email { get; set; }

        // @property (nonatomic, strong) NSString * phone;
        [Export("phone", ArgumentSemantic.Strong)]
        string Phone { get; set; }

        // -(void)addNote:(NSString *)note;
        [Export("addNote:")]
        void AddNote(string note);

        // @property (assign, nonatomic) BOOL shouldPersist;
        [Export("shouldPersist")]
        bool ShouldPersist { get; set; }

        // -(instancetype)initWithIO:(id<ZDCChatIO>)chatIO;
        [Export("initWithIO:")]
        IntPtr Constructor(ZDCChatIO chatIO);
    }

    // @interface ZDCChatProfile : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCChatProfile
    {
        // @property (nonatomic, strong) NSString * sessionId;
        [Export("sessionId", ArgumentSemantic.Strong)]
        string SessionId { get; set; }

        // @property (nonatomic, strong) NSString * machineId;
        [Export("machineId", ArgumentSemantic.Strong)]
        string MachineId { get; set; }

        // @property (nonatomic, strong) NSString * nickname;
        [Export("nickname", ArgumentSemantic.Strong)]
        string Nickname { get; set; }

        // @property (nonatomic, strong) NSString * email;
        [Export("email", ArgumentSemantic.Strong)]
        string Email { get; set; }

        // @property (nonatomic, strong) NSString * displayName;
        [Export("displayName", ArgumentSemantic.Strong)]
        string DisplayName { get; set; }
    }

    // @interface ZDCChatAPI : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDCChatAPI
    {
        // @property (nonatomic, strong) ZDCVisitorInfo * visitorInfo;
        [Export("visitorInfo", ArgumentSemantic.Strong)]
        ZDCVisitorInfo VisitorInfo { get; set; }

        // @property (readonly, nonatomic, strong) ZDCChatProfile * profile;
        [Export("profile", ArgumentSemantic.Strong)]
        ZDCChatProfile Profile { get; }

        // @property (readonly, nonatomic, strong) NSArray<ZDCChatEvent *> * livechatLog;
        [Export("livechatLog", ArgumentSemantic.Strong)]
        ZDCChatEvent[] LivechatLog { get; }

        // @property (readonly, nonatomic, strong) NSArray<NSString *> * departments;
        [Export("departments", ArgumentSemantic.Strong)]
        string[] Departments { get; }

        // @property (readonly, nonatomic, strong) NSDictionary<NSString *,ZDCChatAgent *> * agents;
        [Export("agents", ArgumentSemantic.Strong)]
        NSDictionary<NSString, ZDCChatAgent> Agents { get; }

        // @property (readonly, assign, nonatomic) NSInteger agentMessageCount;
        [Export("agentMessageCount")]
        nint AgentMessageCount { get; }

        // @property (readonly, assign, nonatomic) BOOL isAccountOnline;
        [Export("isAccountOnline")]
        bool IsAccountOnline { get; }

        // @property (readonly, assign, nonatomic) BOOL fileSendingEnabled;
        [Export("fileSendingEnabled")]
        bool FileSendingEnabled { get; }

        // @property (readonly, assign, nonatomic) ZDCChatSessionStatus chatStatus;
        [Export("chatStatus", ArgumentSemantic.Assign)]
        ZDCChatSessionStatus ChatStatus { get; }

        // @property (readonly, assign, nonatomic) ZDCConnectionStatus connectionStatus;
        [Export("connectionStatus", ArgumentSemantic.Assign)]
        ZDCConnectionStatus ConnectionStatus { get; }

        // @property (readonly, assign, nonatomic) BOOL offlineMessagePending;
        [Export("offlineMessagePending")]
        bool OfflineMessagePending { get; }

        // @property (readonly, nonatomic, strong) NSString * accountKey;
        [Export("accountKey", ArgumentSemantic.Strong)]
        string AccountKey { get; }

        // +(instancetype)instance;
        [Static]
        [Export("instance")]
        ZDCChatAPI Instance { get; }

        // -(void)startChatWithAccountKey:(NSString *)accountKey;
        [Export("startChatWithAccountKey:")]
        void StartChatWithAccountKey(string accountKey);

        // -(void)startChatWithAccountKey:(NSString *)accountKey config:(ZDCAPIConfig *)config;
        [Export("startChatWithAccountKey:config:")]
        void StartChatWithAccountKey(string accountKey, ZDCAPIConfig config);

        // -(void)endChat;
        [Export("endChat")]
        void EndChat();
    }

    // @interface Messaging (ZDCChatAPI)
    [Category]
    [BaseType(typeof(ZDCChatAPI))]
    interface ZDCChatAPI_Messaging
    {
        // -(void)sendChatMessage:(NSString *)message;
        [Export("sendChatMessage:")]
        void SendChatMessage(string message);

        // -(void)sendOfflineMessage:(NSString *)message;
        [Export("sendOfflineMessage:")]
        void SendOfflineMessage(string message);

        // -(void)resendChatMessage:(ZDCChatEvent *)event;
        [Export("resendChatMessage:")]
        void ResendChatMessage(ZDCChatEvent @event);

        // -(void)emailTranscript:(NSString *)email;
        [Export("emailTranscript:")]
        void EmailTranscript(string email);

        // -(void)sendChatRating:(ZDCChatRating)rating;
        [Export("sendChatRating:")]
        void SendChatRating(ZDCChatRating rating);

        // -(void)sendChatRatingComment:(NSString *)comment;
        [Export("sendChatRatingComment:")]
        void SendChatRatingComment(string comment);

        // -(void)uploadFileWithPath:(NSString *)path name:(NSString *)fileName;
        [Export("uploadFileWithPath:name:")]
        void UploadFileWithPath(string path, string fileName);

        // -(void)uploadFileWithData:(NSData *)data name:(NSString *)fileName;
        [Export("uploadFileWithData:name:")]
        void UploadFileWithData(NSData data, string fileName);

        // -(void)uploadImage:(UIImage *)image name:(NSString *)fileName;
        [Export("uploadImage:name:")]
        void UploadImage(UIImage image, string fileName);

        // -(void)setNote:(NSString *)note;
        [Export("setNote:")]
        void SetNote(string note);

        // -(void)appendNote:(NSString *)note;
        [Export("appendNote:")]
        void AppendNote(string note);
    }

    // @interface Events (ZDCChatAPI)
    //[Category]
    //[BaseType(typeof(ZDCChatAPI))]
    //interface ZDCChatAPI_Events
    //{
    //    // -(void)addObserver:(id)target forTimeoutEvents:(SEL)selector;
    //    [Export("addObserver:forTimeoutEvents:")]
    //    void AddObserver(NSObject target, Selector selector);

    //    // -(void)removeObserverForTimeoutEvents:(id)target;
    //    [Export("removeObserverForTimeoutEvents:")]
    //    void RemoveObserverForTimeoutEvents(NSObject target);

    //    // -(void)addObserver:(id)target forConnectionEvents:(SEL)selector;
    //    [Export("addObserver:forConnectionEvents:")]
    //    void AddObserver(NSObject target, Selector selector);

    //    // -(void)removeObserverForConnectionEvents:(id)target;
    //    [Export("removeObserverForConnectionEvents:")]
    //    void RemoveObserverForConnectionEvents(NSObject target);

    //    // -(void)addObserver:(id)target forChatLogEvents:(SEL)selector;
    //    [Export("addObserver:forChatLogEvents:")]
    //    void AddObserver(NSObject target, Selector selector);

    //    // -(void)removeObserverForChatLogEvents:(id)target;
    //    [Export("removeObserverForChatLogEvents:")]
    //    void RemoveObserverForChatLogEvents(NSObject target);

    //    // -(void)addObserver:(id)target forAgentEvents:(SEL)selector;
    //    [Export("addObserver:forAgentEvents:")]
    //    void AddObserver(NSObject target, Selector selector);

    //    // -(void)removeObserverForAgentEvents:(id)target;
    //    [Export("removeObserverForAgentEvents:")]
    //    void RemoveObserverForAgentEvents(NSObject target);

    //    // -(void)addObserver:(id)target forUploadEvents:(SEL)selector;
    //    [Export("addObserver:forUploadEvents:")]
    //    void AddObserver(NSObject target, Selector selector);

    //    // -(void)removeObserverForUploadEvents:(id)target;
    //    [Export("removeObserverForUploadEvents:")]
    //    void RemoveObserverForUploadEvents(NSObject target);

    //    // -(void)addObserver:(id)target forAccountEvents:(SEL)selector;
    //    [Export("addObserver:forAccountEvents:")]
    //    void AddObserver(NSObject target, Selector selector);

    //    // -(void)removeObserverForAccountEvents:(id)target;
    //    [Export("removeObserverForAccountEvents:")]
    //    void RemoveObserverForAccountEvents(NSObject target);
    //}

    // @interface Tracking (ZDCChatAPI)
    [Category]
    [BaseType(typeof(ZDCChatAPI))]
    interface ZDCChatAPI_Tracking
    {
        // -(void)trackEvent:(NSString *)event;
        [Export("trackEvent:")]
        void TrackEvent(string @event);
    }
}
