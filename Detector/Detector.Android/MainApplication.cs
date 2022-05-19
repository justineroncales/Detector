#if DEBUG
using System;
using Android.App;
using Android.Runtime;
using Detector.Services;
using Plugin.CurrentActivity;

[Application(Debuggable = true)]
#else
	[Application(Debuggable = false)]
#endif
[MetaData("com.google.android.geo.API_KEY",
			  Value = AppConstants.GoogleMapsApiKey)]
public class MainApplication : Application
{
	public MainApplication(IntPtr handle, JniHandleOwnership transer)
	  : base(handle, transer)
	{
	}

	public override void OnCreate()
	{
		base.OnCreate();
		CrossCurrentActivity.Current.Init(this);
	}
}