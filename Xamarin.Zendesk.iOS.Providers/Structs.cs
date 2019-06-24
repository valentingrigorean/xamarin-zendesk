//
// Structs.cs
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
using ObjCRuntime;

namespace Xamarin.Zendesk.iOS.Providers
{

	[Native]
    public enum ZDKAPILoginState : long
    {
        NotLoggedIn,
        LoggingIn,
        LoggedIn
    }

    [Native]
    public enum ZDKNavBarConversationsUIType : ulong
    {
        LocalizedLabel,
        Image,
        None
    }

    [Native]
    public enum ZDKHelpCenterOverviewGroupType : ulong
    {
        Default,
        Section,
        Category
    }

    [Native]
    public enum ZDKNetworkStatus : ulong
    {
        NotReachable,
        ReachableViaWiFi,
        ReachableViaWWAN
    }

    [Native]
    public enum ZDKTicketFieldType : ulong
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
		Unknown = ulong.MaxValue
    }

    [Native]
    public enum ZDKValidation : ulong
    {
        NilError,
        EmptyStringError
    }

    [Native]
    public enum ZDKAuthenticationType : ulong
    {
        Unknown,
        Jwt,
        Anonymous
    }
}
