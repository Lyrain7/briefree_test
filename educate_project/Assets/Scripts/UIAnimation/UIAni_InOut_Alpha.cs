using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class UIAni_InOut_Alpha : MonoBehaviour {

	public UIPanel 	 	myPanel;

	public bool resetWhenFirstStart = true;
	public bool resetWhenBringIn	= false;
	public bool resetWhenDissMiss	= false;

	public float timeBringIn 	= 0.5f;
	public float timeDissMiss	= 0.5f;

	public EaseType easeBringIn;
	public EaseType easeDissMiss;

	public float startAlpha = 0;
	public float endAlpha 	= 1;
	public float curAlpha 	= 0;

	private Tweener twn;


	public void BringIn ()
	{
		Util.ClearHotween ( ref twn );
		
		if ( resetWhenFirstStart || resetWhenBringIn )
		{
			resetWhenFirstStart = false;
			
			myPanel.alpha 	= startAlpha;
			curAlpha		= startAlpha;
			
			ChangeAlpha ();
		}
		
		twn = HOTween.To( this , timeBringIn , new TweenParms().Prop("curAlpha", endAlpha , false ).OnUpdate ( ChangeAlpha ).Ease ( easeBringIn ) );
	}
	
	
	
	public void BringIn_Fast ()
	{
		Util.ClearHotween ( ref twn );
		
		myPanel.alpha 	= endAlpha;
		curAlpha		= endAlpha;
		
		ChangeAlpha ();
	}



	public IEnumerator Co_BringIn ()
	{
		BringIn ();

		yield return new WaitForSeconds ( timeBringIn );
	}



	public void DissMiss ()
	{
		Util.ClearHotween ( ref twn );
		
		if ( resetWhenDissMiss )
		{
			myPanel.alpha 	= endAlpha;
			curAlpha		= endAlpha;
			
			ChangeAlpha ();
		}
		
		twn = HOTween.To( this , timeDissMiss , new TweenParms().Prop("curAlpha", startAlpha , false ).OnUpdate ( ChangeAlpha ).Ease ( easeDissMiss ) ) ;
	}


	public IEnumerator Co_DissMiss ()
	{
		DissMiss ();

		yield return new WaitForSeconds ( timeDissMiss );
	}



	private void ChangeAlpha ()
	{
		myPanel.alpha = curAlpha; 
	}



	public void Stop ()
	{
		StopAllCoroutines ();
		Util.ClearHotween ( ref twn );
	}

}















