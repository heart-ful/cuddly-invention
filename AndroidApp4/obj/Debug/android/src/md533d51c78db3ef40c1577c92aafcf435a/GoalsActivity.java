package md533d51c78db3ef40c1577c92aafcf435a;


public class GoalsActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AndroidApp4.GoalsActivity, AndroidApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GoalsActivity.class, __md_methods);
	}


	public GoalsActivity ()
	{
		super ();
		if (getClass () == GoalsActivity.class)
			mono.android.TypeManager.Activate ("AndroidApp4.GoalsActivity, AndroidApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
