using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui_dialog : MonoBehaviour {

	public static Ui_dialog ins;

	public Transform myTn;

	public TypewriterEffect typewritter;
	public UILabel lb_typer;
	public BoxCollider2D			colTalk;
	public UIAni_InOut_Position 	uiAni;

	public Dictionary < int , docs_sample > dic_sample;
	private string _cons = "sample_";
	public int _idx = 0;

	public UISprite left;
	public UISprite right;
	public UISprite middle;

	void Awake()
	{
		ins = this;

		myTn.gameObject.SetActive (false);
	}

	public void Init()
	{
		lb_typer.text = "";
		typewritter.Finish ();

		spriteClear ();
	}

	public void BringIn ()
	{
		myTn.gameObject.SetActive ( true );

		StartCoroutine ( Co_BringIn () );
	}



	public void DissMiss ()
	{
		StartCoroutine ( Co_DissMiss () );
	}



	private IEnumerator Co_BringIn ()
	{
		Init ();

		setData (0);

		yield return StartCoroutine (  uiAni.Co_BringIn () );

		yield return new WaitForSeconds ( 0.2f );


		colTalk.enabled = true;

		setSprite ();
		Play ();

	}



	private IEnumerator Co_DissMiss ()
	{
		

		yield return StartCoroutine ( uiAni.Co_DissMiss () );

		myTn.gameObject.SetActive ( false );

	}


	public IEnumerator WaitEnd ()
	{
		while ( myTn.gameObject.activeSelf ) {
			yield return null;
		}
	}


	public void setData( int _didx )
	{
		string _key = _cons + _didx.ToString();
		docs_sample _info = null;

		dic_sample = new Dictionary<int, docs_sample> ();

		int _group = DocspinManager.ins.dic_sample [_key].ngroup;

		_idx = 0;

		for (int i = 0; i < DocspinManager.ins.dic_sample.Count; i++) 
		{
			if (DocspinManager.ins.dic_sample [_key].ngroup != _group)
				return;

			_info = DocspinManager.ins.dic_sample [_key];

			dic_sample.Add (i, _info);

			_key = _cons + (_didx + i).ToString();
		}
	}

	private void InvokeHit ()
	{
		Debug.Log ( "???" );
		Play ();
	}

	public void Play()
	{
		Debug.Log ( "talk In" );
		if ( typewritter.isActive ) {
			typewritter.Finish ();
			Debug.Log ( "talk" );
		} else {
			_idx++;

			if ( _idx < dic_sample.Count ) {				
				
				lb_typer.text = dic_sample[ _idx ].arg;
				typewritter.ResetToBeginning ();
				setSprite ();

			} else {
				colTalk.enabled = false;
				spriteClear ();
				DissMiss ();
			}
		}
	}

	public void spriteClear()
	{
		left.gameObject.SetActive (false);
		right.gameObject.SetActive (false);
		middle.gameObject.SetActive (false);
	}

	public void setSprite()
	{
		spriteClear ();

		if (dic_sample [_idx].char0 != "none")
		{
			left.gameObject.SetActive (true);
			left.spriteName = dic_sample [_idx].char0;
		}

		if (dic_sample [_idx].char1 != "none")
		{
			middle.gameObject.SetActive (true);
			middle.spriteName = dic_sample [_idx].char1;
		}

		if (dic_sample [_idx].char2 != "none")
		{
			right.gameObject.SetActive (true);
			right.spriteName = dic_sample [_idx].char2;
		}
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.I)) 
		{
			BringIn ();
		}
	}
}
