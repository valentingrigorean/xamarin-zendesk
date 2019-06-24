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

namespace Xamarin.Zendesk.iOS.Chat
{
	[Native]
    public enum ZDCPreChatDataRequirement : ulong
    {
        NotRequired = 0,
        Optional = 1,
        Required = 2,
        OptionalEditable = 3,
        RequiredEditable = 4
    }

    [Native]
    public enum ZDCFormCellType : ulong
    {
        Name = 0,
        Email = 1,
        Phone = 2,
        Department = 3,
        Message = 4
    }

    [Native]
    public enum ZDCFormDataStatus : ulong
    {
        Ok = 0,
        Incomplete = 1,
        Invalid = 2
    }

    [Native]
    public enum ZDCChatUIState : ulong
    {
        Loading = 0,
        NoConnection = 1,
        CouldNotConnect = 2,
        NoAgents = 3,
        OfflineForm = 4,
        PreChatForm = 5,
        Chat = 6,
        ChatTimedOut = 7
    }

    [Native]
    public enum ZDCChatBackgroundAnchor : ulong
    {
        Center = 0,
        Top = 1
    }

    [Native]
    public enum ZDCOverlayAlignment : ulong
    {
        BottomLeft = 0,
        TopLeft = 1,
        TopRight = 2,
        BottomRight = 3
    }
}
