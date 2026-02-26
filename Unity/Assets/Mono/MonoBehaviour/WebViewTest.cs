using UnityEngine;
using System.Collections;
using Kogarasi.WebView;

class WebViewCallbackTest : Kogarasi.WebView.IWebViewCallback
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

		WebViewBehavior webview = GetComponent<WebViewBehavior>();
	
		if( webview != null )
		{
			webview.LoadURL(url);
            
            webview.SetMargins(0, 100, 0, 0); // »´∆¡œ‘ æ

            webview.SetVisibility( true );
			webview.setCallback( m_callback );

			Debug.Log($"loadurl:   {url}");
		}
	}
	
}
