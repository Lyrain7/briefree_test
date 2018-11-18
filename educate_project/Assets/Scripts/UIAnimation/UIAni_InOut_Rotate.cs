using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class UIAni_InOut_Rotate : MonoBehaviour {
	
	public Transform 	myTn;
	
	public float timeBringIn 	= 0.3f;
	public float timeDissMiss	= 0.3f;
	
	public EaseType easeBringIn 	= EaseType.EaseOutBack;
	public EaseType easeDissMiss	= EaseType.EaseInBack;
	
	public Vector3 startRot;
	public Vector3 endRot;
	public Vector3 outRot;
	
	private Tweener twn;	
	
	public void BringIn ()
	{
		Util.ClearHotween ( ref twn );
		
		myTn.localRotation = Quaternion.Euler ( startRot );
		
		twn = HOTween.To( myTn , timeBringIn , new TweenParms().Prop("localRotation", endRot , false ).Ease ( easeBringIn ) );
	}
	
	
	
	public IEnumerator Co_BringIn ()
	{
		BringIn ();
		
		yield return new WaitForSeconds ( timeBringIn );
	}
	
	
	
	public void DissMiss ()
	{
		Util.ClearHotween ( ref twn );
		
		twn = HOTween.To( myTn , timeDissMiss , new TweenParms().Prop("localRotation", outRot , false ).Ease ( easeDissMiss ) ) ;
	}
	
	
	
	
	public IEnumerator Co_DissMiss ()
	{
		DissMiss ();
		
		yield return new WaitForSeconds ( timeDissMiss );
	}
}
