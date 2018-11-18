using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Holoville.HOTween;

public class UiAni_PingPong_Alpha_Ugui : MonoBehaviour {

	public Image target;

	public bool resetWhenFirstStart = true;

	public float startAlpha = 1;
	public float endALpha	= 0;
	public float currentAlpha = 0;

	public float animationTime = 0.5f;

	private bool  direction = true;

	private Tweener twn;

	private Color temp;

	public void PlayAnimation ()
	{
		if ( resetWhenFirstStart )
		{
			resetWhenFirstStart = false;

			currentAlpha = startAlpha;
	
			temp = target.color;

			temp.a = startAlpha;

			target.color = temp;
		}

		Util.ClearHotween ( ref twn );

		if ( direction )
		{
			twn = HOTween.To( this , animationTime , new TweenParms().Prop("currentAlpha", endALpha , false ).Ease ( EaseType.EaseInExpo ).OnUpdate ( ChangeAlpha ).OnComplete ( ChangeDriection ).Loops ( -1 , LoopType.Yoyo ) );
		}	
		else 
		{
			twn = HOTween.To( this , animationTime , new TweenParms().Prop("currentAlpha", startAlpha , false ).Ease ( EaseType.EaseOutExpo ).OnUpdate ( ChangeAlpha ).OnComplete ( ChangeDriection ).Loops ( -1 , LoopType.Yoyo ) );
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
		temp = target.color;

		temp.a = currentAlpha;

		target.color = temp;
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
		else
		{
			PlayAnimation();
		}
	}



	private void OnDisable ()
	{
		if ( twn != null )
		{
			twn.Pause ();
		}
		else
		{
			StopAnimation();
		}
	}


}
