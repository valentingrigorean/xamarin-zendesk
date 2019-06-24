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

namespace Xamarin.Zendesk.iOS.ChatApi
{
	[Native]
    public enum ZDCChatRating : ulong
    {
        Unrated = 0,
        None = 1,
        Good = 2,
        Bad = 3
    }

    [Native]
	public enum ZDCChatSessionStatus : ulong
    {
        Inactive = 0,
        Connected = 1,
        Chatting = 2,
        TimedOut = 3
    }

    [Native]
	public enum ZDCEmailTranscriptAction : ulong
    {
        Prompt = 0,
        NeverSend = 1
    }

    [Native]
	public enum ZDCConnectionStatus : ulong
    {
        Uninitialized = 0,
        Connecting = 1,
        Connected = 2,
        Closed = 3,
        Disconnected = 4,
        NoConnection = 5
    }

    [Native]
	public enum ZDCLogLevel : ulong
    {
        Error = 0,
        Warn = 1,
        Info = 2,
        Debug = 3,
        Verbose = 4
    }

    [Native]
	public enum ZDCFileTransferStatus : ulong
    {
        Pending = 0,
        Transfering = 1,
        Complete = 2,
        Error = 3
    }

    [Native]
	public enum ZDCTransferError : ulong
    {
        ErrorNone = 0,
        ErrorType = 1,
        ErrorSize = 2,
        ErrorAccess = 3,
        ErrorInvalid = 4,
        ErrorFailed = 5,
        FileSendingDisabled = 6,
        ErrorUnknown = 1000
    }

    [Native]
	public enum ZDCChatEventType : ulong
    {
        Unknown = 0,
        MemberJoin = 1,
        MemberLeave = 2,
        SystemMessage = 3,
        TriggerMessage = 4,
        AgentMessage = 5,
        VisitorMessage = 6,
        VisitorUpload = 7,
        AgentUpload = 8,
        Rating = 9,
        RatingComment = 10
    }

}
