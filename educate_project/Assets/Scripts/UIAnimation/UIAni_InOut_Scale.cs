using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class UIAni_InOut_Scale : MonoBehaviour {

	public Transform 	myTn;

	public float timeBringIn 	= 0.3f;
	public float timeDissMiss	= 0.3f;
	
	public EaseType easeBringIn 	= EaseType.EaseOutBack;
	public EaseType easeDissMiss	= EaseType.EaseInBack;

	public Vector3 startScale = new Vector3 ( 0.01f , 0.01f , 1 );
    public Vector3 endScale = new Vector3 ( 1.0f , 1.0f , 1.0f );

	private Tweener twn;

	public void BringIn ()
	{
		Util.ClearHotween ( ref twn );

		myTn.localScale = startScale;

        twn = HOTween.To( myTn , timeBringIn , new TweenParms().Prop("localScale", endScale , false ).Ease ( easeBringIn ) );
	}


	public IEnumerator Co_BringIn ()
	{
		BringIn ();
		
		yield return new WaitForSeconds ( timeBringIn );
	}



	public void DissMiss ()
	{
		Util.ClearHotween ( ref twn );
		
		twn = HOTween.To( myTn , timeDissMiss , new TweenParms().Prop("localScale", startScale , false ).Ease ( easeDissMiss ) ) ;
	}


	public IEnumerator Co_DissMiss ()
	{
		DissMiss ();
		
		yield return new WaitForSeconds ( timeDissMiss );
	}
}
