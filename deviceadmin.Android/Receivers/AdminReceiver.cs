﻿using Android.App;
using Android.App.Admin;
using Android.Content;

namespace sample_device_admin.Android.Receivers
{
	[BroadcastReceiver(Permission = "android.permission.BIND_DEVICE_ADMIN",
		Name = "sample_device_admin.Android.Receivers.AdminReceiver")]
	[MetaData("android.app.device_admin", Resource = "@layout/device_admin_sample")]
	[IntentFilter(new[] {"android.app.action.DEVICE_ADMIN_ENABLED", Intent.ActionMain})]
	public class AdminReceiver : DeviceAdminReceiver
	{
	}
}