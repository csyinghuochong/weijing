using UnityEngine;
using System.Collections;


class WebViewCallbackTest 
{
	public void onLoadStart( string url )
	{
		Debug.Log( "call onLoadStart : " + url );
	}
	public void onLoadFinish( string url )
	{
		Debug.Log( "call onLoadFinish : " + url );
	}
	public void onLoadFail( string url )
	{
		Debug.Log( "call onLoadFail : " + url );
	}
}

public class WebViewTest : MonoBehaviour
{

	WebViewCallbackTest m_callback;

	// Use this for initialization
	public void OpenUrl (string url) {

		m_callback = new WebViewCallbackTest();

		
	}
	
}
