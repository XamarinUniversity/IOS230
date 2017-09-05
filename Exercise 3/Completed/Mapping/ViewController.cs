using System;
using UIKit;
using CoreLocation;
using Foundation;
using MapKit;

namespace Mapping
{
	public partial class ViewController : UIViewController
	{
        CLLocationManager locMan = new CLLocationManager();
        
        CLLocationCoordinate2D locSanFran = new CLLocationCoordinate2D(37.7833, -122.4167);
        CLLocationCoordinate2D locBoston = new CLLocationCoordinate2D(42.3601, -71.0589);
        CLLocationCoordinate2D locLondon = new CLLocationCoordinate2D(51.5072, -0.1275);
        CLLocationCoordinate2D locSingapore = new CLLocationCoordinate2D(1.3, 103.8);

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

        partial void btnSanFran_Activated (UIBarButtonItem sender)
        {
            map.Camera.CenterCoordinate = locSanFran;
            map.Camera.Altitude = 5000;
        }

        partial void btnBoston_Activated (UIBarButtonItem sender)
        {
            map.MapType = MKMapType.Standard;

            map.Camera.CenterCoordinate = locBoston;
            map.Camera.Altitude = 500;
            map.Camera.Pitch = 45;

            map.ShowsBuildings = true;
            map.PitchEnabled = true;
        }

        partial void btnLondon_Activated (UIBarButtonItem sender)
        {
            map.Camera = new MKMapCamera {
                CenterCoordinate = locLondon,
                Altitude = 10000,
                Pitch = 45,
                Heading = 180
            };
        }

        partial void btnSingapore_Activated (UIBarButtonItem sender)
        {
            var camera = new MKMapCamera {
                CenterCoordinate = locSingapore,
                Altitude = 10000,
                Pitch = 45,
                Heading = 180
            };

            map.SetCamera(camera, true);
        }
	}
}
