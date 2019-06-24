using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Sample.Core;
using Android.Support.V7.App;
using Zendesk.Core;
using Zendesk.Providers;
using Zendesk.Support.Requestlist;
using Com.Zopim.Android.Sdk.Api;
using Com.Zopim.Android.Sdk.Model;
using Com.Zopim.Android.Sdk.Prechat;

namespace Sample.Droid
{
    [Activity(Label = "Sample.Droid", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/test")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var theme = Theme;
            theme.ApplyStyle(Resource.Style.ZendeskActivityDefaultTheme, true);
            theme.ApplyStyle(Resource.Style.ZendeskSupportActivityThemeDefaultIcon, false);

            var instance = Zendesk.Core.Zendesk.Instance;
            instance.Init(this, ZendeskConstants.ZendeskUrl, ZendeskConstants.AppId, ZendeskConstants.ClientId);

            instance.Identity = new AnonymousIdentity();

            Support.Instance.Init(instance);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var supportBtn = FindViewById<Button>(Resource.Id.supportBtn);

            supportBtn.Click += SupportBtn_Click;

            var chatBtn = FindViewById<Button>(Resource.Id.chatBtn);

            chatBtn.Click += ChatBtn_Click;
        }


        void SupportBtn_Click(object sender, EventArgs e)
        {
            RequestListActivity.Builder().Show(this);
        }

        void ChatBtn_Click(object sender, EventArgs e)
        {
            ZopimChat.Init(ZendeskConstants.ChatApiKey);

            var visitorData = new VisitorInfo
                .Builder()
                .Name("Visitor name")
                .Email("visitor@mail.com")
                .PhoneNumber("0232123123")
                .Build();

            ZopimChat.SetVisitorInfo(visitorData);

            StartActivity(typeof(ZopimChatActivity));
        }

    }
}