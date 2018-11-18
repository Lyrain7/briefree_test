using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class UIAni_Label_PingPong_Alpha : MonoBehaviour {

	public UILabel uiLv;

	public bool resetWhenFirstStart = true;

	public float startAlpha = 1;
	public float endALpha	= 0;
	public float currentAlpha = 0;

    public EaseType easeForward     = EaseType.EaseInExpo;
    public EaseType easeReverse     = EaseType.EaseInExpo;

	public float animationTime = 0.5f;

    private bool  direction = true;


	private Tweener twn;

	public void PlayAnimation ()
	{
		if ( resetWhenFirstStart )
		{
			resetWhenFirstStart = false;

			currentAlpha = startAlpha;
			uiLv.alpha = startAlpha;
		}

		Util.ClearHotween ( ref twn );

		if ( direction )
		{
            twn = HOTween.To( this , animationTime , new TweenParms().Prop("currentAlpha", endALpha , false ).Ease ( easeForward ).OnUpdate ( ChangeAlpha ).OnComplete ( ChangeDriection ).Loops ( -1 , LoopType.Yoyo ) );
		}	
		else 
		{
            twn = HOTween.To( this , animationTime , new TweenParms().Prop("currentAlpha", startAlpha , false ).Ease ( easeReverse ).OnUpdate ( ChangeAlpha ).OnComplete ( ChangeDriection ).Loops ( -1 , LoopType.Yoyo ) );
		}
	}


	public void StopAnimation ()
	{
		Util.ClearHotween ( ref twn );

		direction = true;
		currentAlpha = startAlpha;

		ChangeAlpha ();
	}



	private void ChangeAlpha ()
	{
		uiLv.alpha = currentAlpha;
	}



	private void ChangeDriection ()
	{
		direction = !direction;
	}



	private void OnEnable ()
	{
		if ( twn != null )
		{
			twn.Play ();
		}
	}



	private void OnDisable ()
	{
		if ( twn != null )
		{
			twn.Pause ();
		}
	}
}
