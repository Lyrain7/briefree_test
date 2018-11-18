using UnityEngine;
using System.Collections;

public class Rotate_loop : MonoBehaviour {

	public float fSpeed = 0.1f;


	public void Anim_Rotate()
	{
		StartCoroutine ( "Co_Anim_Rotate" );
	}

	public void Destroy_Anim_Rotate()
	{
		StopCoroutine ( "Co_Anim_Rotate" );
	}

	private IEnumerator Co_Anim_Rotate()
	{
		while ( true )
		{
			Quaternion _rot = transform.localRotation;

			_rot.eulerAngles += new Vector3 ( 0 , 0 , Time.deltaTime * fSpeed );

			transform.localRotation = _rot;

			yield return null;
		}
	}

}
