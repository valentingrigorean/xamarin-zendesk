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
using Xamarin.Zendesk.iOS.ChatApi;

namespace Xamarin.Zendesk.iOS.Chat
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



    // typedef void (^ZDCVisitorConfigBlock)(ZDCVisitorInfo *);
    delegate void ZDCVisitorConfigBlock(ZDCVisitorInfo arg0);

    // typedef void (^ZDCConfigBlock)(ZDCConfig *);
    delegate void ZDCConfigBlock(ZDCConfig arg0);

    // @interface ZDCChat : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCChat
    {
        // @property (nonatomic, strong) ZDCChatAPI * api;
        [Export("api", ArgumentSemantic.Strong)]
        ZDCChatAPI Api { get; set; }

        // @property (nonatomic, strong) id<ZDCChatOverlayDelegate> overlay;
        [Export("overlay", ArgumentSemantic.Strong)]
        IZDCChatOverlayDelegate Overlay { get; set; }

        // @property (nonatomic, strong) ZDCChatViewController * chatViewController;
        //[Export("chatViewController", ArgumentSemantic.Strong)]
        //ZDCChatViewController ChatViewController { get; set; }

        //// @property (nonatomic, strong) ZDCOfflineMessageHandler * offlineMessageHandler;
        //[Export("offlineMessageHandler", ArgumentSemantic.Strong)]
        //ZDCOfflineMessageHandler OfflineMessageHandler { get; set; }

        // @property (assign, nonatomic) BOOL shouldResumeOnLaunch;
        [Export("shouldResumeOnLaunch")]
        bool ShouldResumeOnLaunch { get; set; }

        // @property (assign, nonatomic) BOOL hidesBottomBarWhenPushed;
        [Export("hidesBottomBarWhenPushed")]
        bool HidesBottomBarWhenPushed { get; set; }

        // @property (readonly, assign, nonatomic) NSInteger unreadMessagesCount;
        [Export("unreadMessagesCount")]
        nint UnreadMessagesCount { get; }

        // +(instancetype)instance;
        [Static]
        [Export("instance")]
        ZDCChat Instance();

        // +(void)initializeWithAccountKey:(NSString *)accountKey;
        [Static]
        [Export("initializeWithAccountKey:")]
        void InitializeWithAccountKey(string accountKey);

        // +(void)updateVisitor:(ZDCVisitorConfigBlock)visitorConfig;
        [Static]
        [Export("updateVisitor:")]
        void UpdateVisitor(ZDCVisitorConfigBlock visitorConfig);

        // +(void)startChat:(ZDCConfigBlock)sessionConfig;
        [Static]
        [Export("startChat:")]
        void StartChat(ZDCConfigBlock sessionConfig);

        // +(void)startChatIn:(UINavigationController *)navController withConfig:(ZDCConfigBlock)configOverride;
        [Static]
        [Export("startChatIn:withConfig:")]
        void StartChatIn(UINavigationController navController, [NullAllowed] ZDCConfigBlock configOverride);

        // +(void)endChat;
        [Static]
        [Export("endChat")]
        void EndChat();

        // +(void)minimiseChat;
        [Static]
        [Export("minimiseChat")]
        void MinimiseChat();
    }

    // @interface ZDCConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCConfig
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

        // @property (nonatomic, strong) NSArray<NSString *> * tags;
        [Export("tags", ArgumentSemantic.Strong)]
        string[] Tags { get; set; }

        // @property (nonatomic, strong) ZDCPreChatData * preChatDataRequirements;
        [Export("preChatDataRequirements", ArgumentSemantic.Strong)]
        ZDCPreChatData PreChatDataRequirements { get; set; }

        // @property (assign, nonatomic) BOOL uploadAttachmentsEnabled;
        [Export("uploadAttachmentsEnabled")]
        bool UploadAttachmentsEnabled { get; set; }

        // @property (assign, nonatomic) ZDCEmailTranscriptAction emailTranscriptAction;
        [Export("emailTranscriptAction", ArgumentSemantic.Assign)]
        ZDCEmailTranscriptAction EmailTranscriptAction { get; set; }

        // @property (assign, nonatomic) NSTimeInterval connectionTimeout;
        [Export("connectionTimeout")]
        double ConnectionTimeout { get; set; }

        // @property (assign, nonatomic) NSTimeInterval reconnectionTimeout;
        [Export("reconnectionTimeout")]
        double ReconnectionTimeout { get; set; }
    }

    // @interface ZDCPreChatData : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDCPreChatData
    {
        // @property (assign, nonatomic) ZDCPreChatDataRequirement name;
        [Export("name", ArgumentSemantic.Assign)]
        ZDCPreChatDataRequirement Name { get; set; }

        // @property (assign, nonatomic) ZDCPreChatDataRequirement email;
        [Export("email", ArgumentSemantic.Assign)]
        ZDCPreChatDataRequirement Email { get; set; }

        // @property (assign, nonatomic) ZDCPreChatDataRequirement phone;
        [Export("phone", ArgumentSemantic.Assign)]
        ZDCPreChatDataRequirement Phone { get; set; }

        // @property (assign, nonatomic) ZDCPreChatDataRequirement department;
        [Export("department", ArgumentSemantic.Assign)]
        ZDCPreChatDataRequirement Department { get; set; }

        // @property (assign, nonatomic) ZDCPreChatDataRequirement message;
        [Export("message", ArgumentSemantic.Assign)]
        ZDCPreChatDataRequirement Message { get; set; }
    }

    // @protocol ZDCChatOverlayDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject), Name = "ZDCChatOverlayDelegate")]
    interface IZDCChatOverlayDelegate
    {
        // @required -(void)show;
        [Abstract]
        [Export("show")]
        void Show();

        // @required -(void)hide;
        [Abstract]
        [Export("hide")]
        void Hide();

        // @required -(void)remove;
        [Abstract]
        [Export("remove")]
        void Remove();

        // @required -(BOOL)active;
        [Abstract]
        [Export("active")]
        //[Verify(MethodToProperty)]
        bool Active { get; }

        // @required -(void)activate;
        [Abstract]
        [Export("activate")]
        void Activate();

        // @required -(void)setEnabled:(BOOL)enabled;
        [Abstract]
        [Export("setEnabled:")]
        void SetEnabled(bool enabled);
    }
}
