https://github.com/house-of-code/xamarin-android-zendesk-binding

https://github.com/smoy/ZendeskSDK_Xamarin

https://develop.zendesk.com/hc/en-us/articles/360001068347-Develop-for-Zendesk-Chat?flash_digest=d06e26c4521c9e4b724f80ec9155d73cb1592dba#

https://develop.zendesk.com/hc/en-us/articles/360001074028-Develop-for-Zendesk-Support

sharpie bind  -sdk iphoneos11.4 ZendeskSDK.framework/Headers/ZendeskSDK.h  -scope ZendeskSDK.framework.framework/Headers -c -F .

SwiftLibs  version:4.2.1
    AVFoundation.dylib 
    Core.dylib 
    CoreAudio.dylib 
    CoreFoundation.dylib 
    CoreGraphics.dylib 
    CoreImage.dylib 
    CoreLocation.dylib 
    CoreMedia.dylib 
    Darwin.dylib 
    Dispatch.dylib 
    Foundation.dylib 
    Metal.dylib 
    ObjectiveC.dylib 
    Photos.dylib 
    QuartzCore.dylib 
    SwiftOnoneSupport.dylib 
    UIKit.dylib 
    libswiftsimd.dylib 
    
<PackageReference Include="Xamarin.Swift4.AVFoundation" Version="[4.2.0]" />     
    <PackageReference Include="Xamarin.Swift4.Core" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.CoreAudio" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.CoreData" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.CoreFoundation" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.CoreGraphics" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.CoreImage" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.CoreLocation" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.CoreMedia" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.Darwin" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.Dispatch" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.Foundation" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.Metal" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.ObjectiveC" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.OS" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.Photos" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.QuartzCore" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.SIMD" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.SwiftOnoneSupport" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4.UIKit" Version="[4.2.0]" />
    <PackageReference Include="Xamarin.Swift4" Version="[4.0.0.1]"/>   


\--- com.zendesk:support:2.0.0
     +--- com.zendesk:support-providers:2.0.0
     |    +--- com.zendesk:core:1.0.0
     |    |    +--- com.zendesk:java-common:1.13
     |    |    +--- com.google.dagger:dagger:2.12
     |    |    |    \--- javax.inject:javax.inject:1
     |    |    +--- com.squareup.retrofit2:retrofit:2.3.0
     |    |    |    \--- com.squareup.okhttp3:okhttp:3.8.0 -> 3.8.1
     |    |    |         \--- com.squareup.okio:okio:1.13.0
     |    |    +--- com.squareup.retrofit2:converter-gson:2.3.0
     |    |    |    +--- com.squareup.retrofit2:retrofit:2.3.0 (*)
     |    |    |    \--- com.google.code.gson:gson:2.7
     |    |    +--- com.squareup.okhttp3:logging-interceptor:3.8.1
     |    |    |    \--- com.squareup.okhttp3:okhttp:3.8.1 (*)
     |    |    +--- com.squareup.okhttp3:okhttp:3.8.1 (*)
     |    |    +--- com.android.support:support-annotations:27.0.2 -> 27.1.1
     |    |    \--- com.jakewharton:disklrucache:2.0.2
     |    +--- com.google.dagger:dagger:2.12 (*)
     |    \--- com.crashlytics.sdk.android:answers-shim:0.0.6
     +--- com.google.dagger:dagger-android:2.12
     |    +--- com.google.dagger:dagger:2.12 (*)
     |    +--- com.android.support:support-annotations:25.0.0 -> 27.1.1
     |    +--- com.google.code.findbugs:jsr305:3.0.1
     |    \--- javax.inject:javax.inject:1
     +--- com.android.support:support-v4:27.0.2 -> 27.1.0 (*)
     +--- com.android.support:appcompat-v7:27.0.2 -> 27.1.0 (*)
     +--- com.android.support:recyclerview-v7:27.0.2 -> 27.1.0 (*)
     +--- com.android.support:design:27.0.2 -> 27.1.0 (*)
     +--- com.android.support:cardview-v7:27.0.2
     |    \--- com.android.support:support-annotations:27.0.2 -> 27.1.1
     +--- com.jakewharton:disklrucache:2.0.2
     +--- com.squareup.picasso:picasso:2.5.2
     +--- com.jakewharton.picasso:picasso2-okhttp3-downloader:1.1.0
     |    +--- com.squareup.picasso:picasso:2.5.2
     |    \--- com.squareup.okhttp3:okhttp:3.4.1 -> 3.8.1 (*)
     +--- com.zendesk.belvedere2:belvedere:2.1.0
     |    +--- com.zendesk.belvedere2:belvedere-core:2.1.0
     |    |    +--- com.android.support:support-core-utils:27.0.2 -> 27.1.0 (*)
     |    |    \--- com.android.support:support-fragment:27.0.2 -> 27.1.0 (*)
     |    +--- com.android.support:appcompat-v7:27.0.2 -> 27.1.0 (*)
     |    +--- com.android.support:cardview-v7:27.0.2 (*)
     |    +--- com.android.support:design:27.0.2 -> 27.1.0 (*)
     |    \--- com.squareup.picasso:picasso:2.5.2
     \--- com.zendesk.suas:suas:1.2.0
          \--- com.android.support:support-annotations:27.0.2 -> 27.1.1
