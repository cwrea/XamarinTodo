using UIKit;

namespace Todo
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
			SQLitePCL.Batteries_V2.Init(); // required for iOS after moving to EF Core v2

			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main(args, null, "AppDelegate");
		}
	}
}
