using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class UIAni_InOut_Position : MonoBehaviour {

	public Transform 	myTn;
	
	public float timeBringIn 	= 0.3f;
	public float timeDissMiss	= 0.3f;
	
    public EaseType easeBringIn 	= EaseType.EaseOutBack;
	public EaseType easeDissMiss	= EaseType.EaseInBack;
	
	public Vector3 startPos;
	public Vector3 endPos;
	public Vector3 outPos;
	
	private Tweener twn;

	public UiState uiState = UiState.DissMissEnd;
	
	public void BringIn ()
	{
		uiState = UiState.BringIn_Animaiton;

		Util.ClearHotween ( ref twn );
		
		myTn.localPosition = startPos;
		
		twn = HOTween.To( myTn , timeBringIn , new TweenParms().Prop("localPosition", endPos , false ).Ease ( easeBringIn ).OnComplete ( OnComplete_BringIn ) );
	}

    public void BringIn ( AnimationCurve _curve)
    {
        uiState = UiState.BringIn_Animaiton;

        Util.ClearHotween ( ref twn );

        myTn.localPosition = startPos;

        twn = HOTween.To( myTn , timeBringIn , new TweenParms().Prop("localPosition", endPos , false ).Ease ( _curve ).OnComplete ( OnComplete_BringIn ) );
    }



	private void OnComplete_BringIn ()
	{
		uiState = UiState.BringInEnd;
	}
	
	
	
	public IEnumerator Co_BringIn ()
	{
		uiState = UiState.BringIn_Animaiton;

		Util.ClearHotween ( ref twn );
		
		myTn.localPosition = startPos;
		
		twn = HOTween.To( myTn , timeBringIn , new TweenParms().Prop("localPosition", endPos , false ).Ease ( easeBringIn ) );
		
		yield return new WaitForSeconds ( timeBringIn );

		uiState = UiState.BringInEnd;
	}
	
	
	
	public void DissMiss ()
	{
		uiState = UiState.DissMissAnimation;

		Util.ClearHotween ( ref twn );
		
		myTn.localPosition = endPos;
		
		twn = HOTween.To( myTn , timeDissMiss , new TweenParms().Prop("localPosition", outPos , false ).Ease ( easeDissMiss ).OnComplete ( OnComplete_DissMiss ) ) ;
	}


	private void OnComplete_DissMiss ()
	{
		uiState = UiState.DissMissEnd;
	}
	
	
	
	
	public IEnumerator Co_DissMiss ()
	{
		uiState = UiState.DissMissAnimation;

		Util.ClearHotween ( ref twn );
		
		myTn.localPosition = endPos;
		
		twn = HOTween.To( myTn , timeDissMiss , new TweenParms().Prop("localPosition", outPos , false ).Ease ( easeDissMiss ) ) ;
		
		yield return new WaitForSeconds ( timeDissMiss );

		uiState = UiState.DissMissEnd;
	}
}



















