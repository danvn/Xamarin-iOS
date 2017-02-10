using System;
using UIKit;

namespace XamariniOSApp
{
	public partial class ViewControllerName : UIViewController
	{
		partial void SubmitName_TouchUpInside(UIButton sender)
		{
			var alert = UIAlertController.Create("Name", firstName.Text, UIAlertControllerStyle.Alert);
			alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, alertAction => { }));
			this.PresentViewController(alert, true, null);
		}

		public ViewControllerName() : base("ViewControllerName", null)
		{
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

