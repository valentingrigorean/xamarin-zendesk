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

namespace Xamarin.Zendesk.iOS.Core
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

    // @interface ZDKIdentityMigrator : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKIdentityMigrator
    {
    }

    // @interface ZDKAuthenticationURLProtocol : NSURLProtocol
    [BaseType(typeof(NSUrlProtocol))]
    interface ZDKAuthenticationURLProtocol
    {
    }

    // @interface ZDKCoreLogger : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKCoreLogger
    {
        // @property (nonatomic, class) enum ZDKLogLevel logLevel;
        [Static]
        [Export("logLevel", ArgumentSemantic.Assign)]
        ZDKLogLevel LogLevel { get; set; }

        // @property (nonatomic, class) BOOL enabled;
        [Static]
        [Export("enabled")]
        bool Enabled { get; set; }

        // +(void)error:(NSString * _Nonnull)message;
        [Static]
        [Export("error:")]
        void Error(string message);

        // +(void)warn:(NSString * _Nonnull)message;
        [Static]
        [Export("warn:")]
        void Warn(string message);

        // +(void)info:(NSString * _Nonnull)message;
        [Static]
        [Export("info:")]
        void Info(string message);

        // +(void)debug:(NSString * _Nonnull)message;
        [Static]
        [Export("debug:")]
        void Debug(string message);

        // +(void)verbose:(NSString * _Nonnull)message;
        [Static]
        [Export("verbose:")]
        void Verbose(string message);
    }

    // @interface ZDKHelpCenterUtil : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKHelpCenterUtil
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nullable zendeskURL;
        [Static]
        [NullAllowed, Export("zendeskURL")]
        string ZendeskURL { get; }

        // @property (readonly, nonatomic, class) BOOL hasAuth;
        [Static]
        [Export("hasAuth")]
        bool HasAuth { get; }

        // +(NSURLRequest * _Nonnull)canonicalRequestFor:(NSURLRequest * _Nonnull)request __attribute__((warn_unused_result));
        [Static]
        [Export("canonicalRequestFor:")]
        NSUrlRequest CanonicalRequestFor(NSUrlRequest request);
    }

    // @interface ZDKUser : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKUser
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull content_url;
        [Export("content_url")]
        string Content_url { get; }

        // @property (readonly, nonatomic) BOOL agent;
        [Export("agent")]
        bool Agent { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
        [Export("tags", ArgumentSemantic.Copy)]
        string[] Tags { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull user_fields;
        [Export("user_fields", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> User_fields { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        ZDKUser New();
    }

    // @interface ZDKUserField : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKUserField : INativeObject
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull url;
        [Export("url")]
        string Url { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull key;
        [Export("key")]
        string Key { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull fieldType;
        [Export("fieldType")]
        string FieldType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull raw_title;
        [Export("raw_title")]
        string Raw_title { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull fieldDescription;
        [Export("fieldDescription")]
        string FieldDescription { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull raw_description;
        [Export("raw_description")]
        string Raw_description { get; }

        // @property (readonly, nonatomic) NSInteger position;
        [Export("position")]
        nint Position { get; }

        // @property (readonly, nonatomic) BOOL active;
        [Export("active")]
        bool Active { get; }

        // @property (readonly, nonatomic) BOOL system;
        [Export("system")]
        bool System { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull regexp_for_validation;
        [Export("regexp_for_validation")]
        string Regexp_for_validation { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull created_at;
        [Export("created_at", ArgumentSemantic.Copy)]
        NSDate Created_at { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull updated_at;
        [Export("updated_at", ArgumentSemantic.Copy)]
        NSDate Updated_at { get; }

        // @property (readonly, copy, nonatomic) NSArray<ZDKUserFieldOption *> * _Nullable custom_field_options;
        [NullAllowed, Export("custom_field_options", ArgumentSemantic.Copy)]
        ZDKUserFieldOption[] Custom_field_options { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        ZDKUserField New();
    }

    // @interface ZDKUserFieldOption : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKUserFieldOption
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic) NSInteger position;
        [Export("position")]
        nint Position { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull raw_name;
        [Export("raw_name")]
        string Raw_name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull url;
        [Export("url")]
        string Url { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull value;
        [Export("value")]
        string Value { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        ZDKUserFieldOption New();
    }

    // @protocol ZDKObjCIdentity
    [Protocol(Name = "_TtP14ZendeskCoreSDK15ZDKObjCIdentity_")]
    interface IZDKObjCIdentity
    {
    }

    [BaseType(typeof(NSObject), Name = "_TtC14ZendeskCoreSDK16ZDKObjCAnonymous")]
    [Protocol]
    [DisableDefaultCtor]
    interface ZDKObjCAnonymous : IZDKObjCIdentity
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable guid;
        [NullAllowed, Export("guid")]
        string Guid { get; }

        // -(instancetype _Nonnull)initWithName:(NSString * _Nullable)name email:(NSString * _Nullable)email __attribute__((objc_designated_initializer));
        [Export("initWithName:email:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string name, [NullAllowed] string email);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        //[Static]
        //[Export("new")]
        //ZDKObjCAnonymous New();
    }

    // @interface ZDKObjCJwt : NSObject <ZDKObjCIdentity>
    [BaseType(typeof(NSObject), Name = "_TtC14ZendeskCoreSDK10ZDKObjCJwt")]
    [Protocol]
    [DisableDefaultCtor]
    interface ZDKObjCJwt : IZDKObjCIdentity
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull token;
        [Export("token")]
        string Token { get; }

        // -(instancetype _Nonnull)initWithToken:(NSString * _Nonnull)token __attribute__((objc_designated_initializer));
        [Export("initWithToken:")]
        [DesignatedInitializer]
        IntPtr Constructor(string token);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        //[Static]
        //[Export("new")]
        //ZDKObjCJwt New();
    }

    // @interface ZDKPushProvider : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC14ZendeskCoreSDK15ZDKPushProvider")]
    [DisableDefaultCtor]
    [Protocol]
    interface ZDKPushProvider
    {
        // -(instancetype _Nonnull)initWithZendesk:(ZDKZendesk * _Nonnull)zendesk __attribute__((objc_designated_initializer));
        [Export("initWithZendesk:")]
        [DesignatedInitializer]
        IntPtr Constructor(ZDKZendesk zendesk);

        // -(void)registerWithDeviceIdentifier:(NSString * _Nonnull)deviceIdentifier locale:(NSString * _Nonnull)locale completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("registerWithDeviceIdentifier:locale:completion:")]
        void RegisterWithDeviceIdentifier(string deviceIdentifier, string locale, Action<NSString, NSError> completion);

        // -(void)registerWithUAIdentifier:(NSString * _Nonnull)UAIdentifier locale:(NSString * _Nonnull)locale completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("registerWithUAIdentifier:locale:completion:")]
        void RegisterWithUAIdentifier(string UAIdentifier, string locale, Action<NSString, NSError> completion);

        // -(void)unregisterForPush;
        [Export("unregisterForPush")]
        void UnregisterForPush();

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        //[Static]
        //[Export("new")]
        //ZDKPushProvider New();
    }

    // @interface ZDKUserProvider : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC14ZendeskCoreSDK15ZDKUserProvider")]
    [DisableDefaultCtor]
    [Protocol]
    interface ZDKUserProvider
    {
        // -(instancetype _Nonnull)initWithZendesk:(ZDKZendesk * _Nonnull)zendesk __attribute__((objc_designated_initializer));
        [Export("initWithZendesk:")]
        [DesignatedInitializer]
        IntPtr Constructor(ZDKZendesk zendesk);

        // -(void)getUserWithCompletion:(void (^ _Nonnull)(ZDKUser * _Nullable, NSError * _Nullable))completion;
        [Export("getUserWithCompletion:")]
        void GetUserWithCompletion(Action<ZDKUser, NSError> completion);

        // -(void)setUserFields:(NSDictionary<NSString *,id> * _Nonnull)userFields completion:(void (^ _Nonnull)(ZDKUser * _Nullable, NSError * _Nullable))completion;
        [Export("setUserFields:completion:")]
        void SetUserFields(NSDictionary<NSString, NSObject> userFields, Action<ZDKUser, NSError> completion);

        // -(void)getUserFieldsWithCompletion:(void (^ _Nonnull)(NSArray<ZDKUserField *> * _Nonnull, NSError * _Nullable))completion;
        [Export("getUserFieldsWithCompletion:")]
        void GetUserFieldsWithCompletion(Action<NSArray<ZDKUserField>, NSError> completion);

        // -(void)addTags:(NSArray<NSString *> * _Nonnull)tags completion:(void (^ _Nonnull)(NSArray<NSString *> * _Nonnull, NSError * _Nullable))completion;
        [Export("addTags:completion:")]
        void AddTags(string[] tags, Action<NSArray<NSString>, NSError> completion);

        // -(void)deleteTags:(NSArray<NSString *> * _Nonnull)tags completion:(void (^ _Nonnull)(NSArray<NSString *> * _Nonnull, NSError * _Nullable))completion;
        [Export("deleteTags:completion:")]
        void DeleteTags(string[] tags, Action<NSArray<NSString>, NSError> completion);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        //[Static]
        //[Export("new")]
        //ZDKUserProvider New();
    }

    // @interface ZDKZendesk : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKZendesk
    {
        // +(void)initializeWithAppId:(NSString * _Nonnull)appId clientId:(NSString * _Nonnull)clientId zendeskUrl:(NSString * _Nonnull)zendeskUrl;
        [Static]
        [Export("initializeWithAppId:clientId:zendeskUrl:")]
        void InitializeWithAppId(string appId, string clientId, string zendeskUrl);


        // @property (readonly, nonatomic, strong, class) ZDKZendesk * _Nullable instance;
        [Static]
        [NullAllowed, Export("instance", ArgumentSemantic.Strong)]
        ZDKZendesk Instance { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        //[Static]
        //[Export("new")]
        //ZDKZendesk New();
    }

    // @interface ZendeskCoreSDK_Swift_475 (ZDKZendesk)
    [Category]
    [BaseType(typeof(ZDKZendesk), Name = "ZDKZendesk_ZendeskCoreSDK_Swift_475")]
    [Internal]
    interface ZDKZendeskExtensions
    {


        // -(void)setIdentity:(id<ZDKObjCIdentity> _Nonnull)newIdentity;
        [Export("setIdentity:")]
        void SetIdentity(NSObject newIdentity);

        // -(id<ZDKObjCIdentity> _Nullable)objCIdentity __attribute__((warn_unused_result));
        [NullAllowed, Export("objCIdentity")]
        //[Verify(MethodToProperty)]
        NSObject GetIdentity();
    }
}
