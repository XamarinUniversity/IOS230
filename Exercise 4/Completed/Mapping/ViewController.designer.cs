// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Mapping
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem btnAddPoints { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem btnRemovePoints { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MapKit.MKMapView map { get; set; }

		[Action ("btnPoints_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnPoints_Activated (UIBarButtonItem sender);

		[Action ("btnRemove_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnRemove_Activated (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnAddPoints != null) {
				btnAddPoints.Dispose ();
				btnAddPoints = null;
			}
			if (btnRemovePoints != null) {
				btnRemovePoints.Dispose ();
				btnRemovePoints = null;
			}
			if (map != null) {
				map.Dispose ();
				map = null;
			}
		}
	}
}
