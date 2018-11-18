using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class UIAniSprite_PingPong_Alpha : MonoBehaviour {

	public UISprite sprite;
	
	public bool resetWhenFirstStart = true;
	
	public float startAlpha = 1;
	public float endALpha	= 0;
	public float currentAlpha = 0;
	
	public float animationTime = 0.5f;
	
	
	private Tweener twn;
	
	public void PlayAnimation ()
	{
		if ( resetWhenFirstStart )
		{
			resetWhenFirstStart = false;
			
			currentAlpha = startAlpha;
			sprite.alpha = startAlpha;
		}
		
		Util.ClearHotween ( ref twn );

		twn = HOTween.To( this , animationTime , new TweenParms().Prop("currentAlpha", endALpha , false ).Ease ( EaseType.EaseInExpo ).OnUpdate ( ChangeAlpha ).Loops ( -1 , LoopType.Yoyo ) );
	}
	
	
	public void StopAnimation ()
	{
		Util.ClearHotween ( ref twn );
		
		currentAlpha = startAlpha;
		
		ChangeAlpha ();
	}
	
	
	
	private void ChangeAlpha ()
	{
		sprite.alpha = currentAlpha;
	}
}
