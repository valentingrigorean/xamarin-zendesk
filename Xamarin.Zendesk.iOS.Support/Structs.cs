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

namespace Xamarin.Zendesk.iOS.Support
{

	[Native]
    public enum ZDKNavBarCreateRequestUIType : ulong
    {
        LocalizedLabel,
        Image
    }

    [Native]
	public enum ZDKContactUsVisibility : ulong
    {
        ArticleListAndArticle,
        ArticleListOnly,
        Off
    }

    [Native]
	public enum ZDKHelpCenterError : ulong
    {
        InvalidCategoryIds = 100,
        InvalidSectionIds,
        NoArticlesForLabels,
        EmptyHelpCenter
    }

    [Native]
	public enum ZDKLayoutGuideApplicatorPosition : ulong
    {
        Top,
        Bottom
    }

    [Native]
    public enum ZDKFileType : long
    {
        Png = 0,
        Jpg = 1,
        Pdf = 2,
        Plain = 3,
        Word = 4,
        Excel = 5,
        Powerpoint = 6,
        PowerpointX = 7,
        Keynote = 8,
        Pages = 9,
        Numbers = 10,
        Binary = 11,
        Heic = 12
    }
}
