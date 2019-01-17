using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class shareFunction : MonoBehaviour
{

	 int score;
	

   public void startShare()
{
		StartCoroutine(TakeSSAndShare());
		score = GameObject.Find("scoreManager").GetComponent<ScoreManager>().currentScore;
}
	
private IEnumerator TakeSSAndShare()
{
	yield return new WaitForEndOfFrame();

	Texture2D ss = new Texture2D( Screen.width, Screen.height, TextureFormat.RGB24, false );
	ss.ReadPixels( new Rect( 0, 0, Screen.width, Screen.height ), 0, 0 );
	ss.Apply();

	string filePath = System.IO.Path.Combine(Application.temporaryCachePath, "shared img.png" );
	System.IO.File.WriteAllBytes(filePath, ss.EncodeToPNG());
	
	// To avoid memory leaks
	Destroy( ss );

	new NativeShare().AddFile(filePath).SetSubject( "Subject goes here" ).SetText("https://play.google.com/store/apps/details?id=com.games.cartwheelgalaxy.qbix").Share();

	// Share on WhatsApp only, if installed (Android only)
	//if( NativeShare.TargetExists( "com.whatsapp" ) )
	//	new NativeShare().AddFile( filePath ).SetText( "Hello world!" ).SetTarget( "com.whatsapp" ).Share();
}
    }

