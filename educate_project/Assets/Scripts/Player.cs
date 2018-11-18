using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject go_Player;

	private Rigidbody2D player_rigid;
	private tk2dSpriteAnimator player_anim;

	public float moveSpeed = 1.0f;
	public float jumpSpeed = 1.0f;

	void Awake()
	{
		Init ();
	}

	public void Init()
	{
		player_rigid = go_Player.GetComponent<Rigidbody2D> ();
		player_anim = go_Player.GetComponentInChildren<tk2dSpriteAnimator> ();
	}

	public void MoveLeft()
	{
		player_rigid.AddForce (new Vector2 (-moveSpeed, 0) , ForceMode2D.Force);
		player_anim.Play ("left");
	}

	public void MoveRight()
	{
		player_rigid.AddForce (new Vector2 (moveSpeed, 0) , ForceMode2D.Force);
		player_anim.Play ("right");
	}

	public void Release()
	{
		player_anim.Play ("front");
	}

	public void Jump()
	{
		player_rigid.AddForce (new Vector2 (0, jumpSpeed), ForceMode2D.Impulse);
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.LeftArrow))
			MoveLeft ();
		else if (Input.GetKeyUp (KeyCode.LeftArrow))
			Release ();
		
		if (Input.GetKey (KeyCode.RightArrow))
			MoveRight ();
		else if (Input.GetKeyUp (KeyCode.RightArrow))
			Release ();

		if (Input.GetKeyDown (KeyCode.UpArrow))
			Jump ();


		if (Input.GetKeyDown (KeyCode.KeypadEnter))
			go_Player.transform.position = Vector3.zero;
	}

}
