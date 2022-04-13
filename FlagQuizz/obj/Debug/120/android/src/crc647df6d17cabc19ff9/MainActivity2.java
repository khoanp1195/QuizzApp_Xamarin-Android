package crc647df6d17cabc19ff9;


public class MainActivity2
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("FlagQuizz.MainActivity2, FlagQuizz", MainActivity2.class, __md_methods);
	}


	public MainActivity2 ()
	{
		super ();
		if (getClass () == MainActivity2.class)
			mono.android.TypeManager.Activate ("FlagQuizz.MainActivity2, FlagQuizz", "", this, new java.lang.Object[] {  });
	}


	public MainActivity2 (int p0)
	{
		super (p0);
		if (getClass () == MainActivity2.class)
			mono.android.TypeManager.Activate ("FlagQuizz.MainActivity2, FlagQuizz", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
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
