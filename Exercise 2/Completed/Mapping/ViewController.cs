using System;
using UIKit;
using CoreLocation;
using Foundation;

namespace Mapping
{
	public partial class ViewController : UIViewController
	{
        CLLocationManager locMan = new CLLocationManager();

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			locMan.RequestWhenInUseAuthorization ();

			map.ShowsUserLocation = true;
		}

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            if (CLLocationManager.Status == CLAuthorizationStatus.Denied)
            {
                var yesNoAlertController = UIAlertController.Create(
                    "Unable to determine location", 
                    "This application works best when it can determine your current position.  " +
                    "Would you like to go to Settings to enable location data?", 
                    UIAlertControllerStyle.Alert);

                yesNoAlertController.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Default,
                    alert => {
                        var settingsString = UIApplication.OpenSettingsUrlString;
                        var url = new NSUrl(settingsString);
                        UIApplication.SharedApplication.OpenUrl(url);
                    }));

                yesNoAlertController.AddAction(UIAlertAction.Create("No", UIAlertActionStyle.Cancel, null));
                this.PresentViewController(yesNoAlertController, true, null);
            }
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
