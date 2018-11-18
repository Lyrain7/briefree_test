using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class UIAniWidget_Alpha_Multi : MonoBehaviour {

	public delegate void VOID_UIANI_VOID ();

	public UIWidget [] m_sprites;
	
	public bool m_resetWhenFirstStart = true;
	
	public float m_bringInAlpha 	= 1;
	public float m_dissMissAlpha	= 0;
	[HideInInspector] public float m_currentAlpha = 0;
	
	public float animationTime = 0.3f;	
	
	private Tweener m_twn;
	
	public void BringIn ()
	{
		if ( m_resetWhenFirstStart )
		{
			m_resetWhenFirstStart = false;
			
			m_currentAlpha = m_dissMissAlpha;

			ChangeAlpha();
		}
		
		Util.ClearHotween ( ref m_twn );

		m_twn = HOTween.To( this , animationTime , new TweenParms().Prop("m_currentAlpha", m_bringInAlpha , false ).Ease ( EaseType.Linear ).OnUpdate ( ChangeAlpha ) );
	}
	
	private VOID_UIANI_VOID m_onEnd;
	public void DissMiss ( VOID_UIANI_VOID onEnd )
	{
		m_onEnd = onEnd;

		Util.ClearHotween ( ref m_twn );

		m_twn = HOTween.To( this , animationTime , new TweenParms().Prop("m_currentAlpha", m_dissMissAlpha , false ).Ease ( EaseType.Linear ).OnUpdate ( ChangeAlpha ).OnComplete ( OnDissMissEnd ) );
	}


	private void OnDissMissEnd ()
	{
		if ( m_onEnd != null )
		{
			m_onEnd();
		}
	}

	
	private void ChangeAlpha ()
	{
		for ( int i = 0 ; i < m_sprites.Length; i++ ) 
		{
			m_sprites[ i ].alpha = m_currentAlpha;
		}
	}
}
