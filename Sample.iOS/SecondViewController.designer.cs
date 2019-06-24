// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Sample.iOS
{
	[Register ("SecondViewController")]
	partial class SecondViewController
	{
		[Outlet]
		UIKit.UIButton ChatButton { get; set; }

		[Outlet]
		UIKit.UIButton SupportButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SupportButton != null) {
				SupportButton.Dispose ();
				SupportButton = null;
			}

			if (ChatButton != null) {
				ChatButton.Dispose ();
				ChatButton = null;
			}
		}
	}
}
