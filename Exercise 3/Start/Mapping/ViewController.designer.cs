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
		UIBarButtonItem btnBoston { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem btnLondon { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem btnSanFran { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem btnSingapore { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MapKit.MKMapView map { get; set; }

		[Action ("btnBoston_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnBoston_Activated (UIBarButtonItem sender);

		[Action ("btnLondon_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnLondon_Activated (UIBarButtonItem sender);

		[Action ("btnSanFran_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnSanFran_Activated (UIBarButtonItem sender);

		[Action ("btnSingapore_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnSingapore_Activated (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnBoston != null) {
				btnBoston.Dispose ();
				btnBoston = null;
			}
			if (btnLondon != null) {
				btnLondon.Dispose ();
				btnLondon = null;
			}
			if (btnSanFran != null) {
				btnSanFran.Dispose ();
				btnSanFran = null;
			}
			if (btnSingapore != null) {
				btnSingapore.Dispose ();
				btnSingapore = null;
			}
			if (map != null) {
				map.Dispose ();
				map = null;
			}
		}
	}
}
