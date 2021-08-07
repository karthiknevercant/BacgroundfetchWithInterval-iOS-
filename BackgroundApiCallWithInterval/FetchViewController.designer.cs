// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BackgroundApiCallWithInterval
{
	[Register ("FetchViewController")]
	partial class FetchViewController
	{
		[Outlet]
		UIKit.UILabel lblCurrentTime { get; set; }

		[Outlet]
		UIKit.UILabel lblTabOne { get; set; }

		[Outlet]
		UIKit.UILabel lblTabTwo { get; set; }

		[Outlet]
		UIKit.UIView viewIndicator { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblCurrentTime != null) {
				lblCurrentTime.Dispose ();
				lblCurrentTime = null;
			}

			if (viewIndicator != null) {
				viewIndicator.Dispose ();
				viewIndicator = null;
			}

			if (lblTabOne != null) {
				lblTabOne.Dispose ();
				lblTabOne = null;
			}

			if (lblTabTwo != null) {
				lblTabTwo.Dispose ();
				lblTabTwo = null;
			}
		}
	}
}
