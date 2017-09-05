using System;

using UIKit;

namespace Mapping
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void btnStandard_Activated (UIBarButtonItem sender)
		{
			map.MapType = MapKit.MKMapType.Standard;
		}

		partial void btnSatellite_Activated (UIBarButtonItem sender)
		{
			map.MapType = MapKit.MKMapType.Satellite;
		}

		partial void btnHybrid_Activated (UIBarButtonItem sender)
		{
			map.MapType = MapKit.MKMapType.Hybrid;
		}
	}
}

