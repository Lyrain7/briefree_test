using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Holoville.HOTween;
using System.Text;

public class Util : MonoBehaviour {

	private static CultureInfo myCi = new CultureInfo ( "en-us" );


	public static void ClearHotween ( ref  Tweener _twn )
	{
		if ( _twn != null )
		{
			_twn.Kill ();
		}
		
		_twn = null;
	}
	
	public static void ClearSeq ( ref Sequence _seq )
	{
		if ( _seq != null )
		{
			_seq.Kill ();
		}
		
		_seq = null;
	}


	public static void HideForReady ( Transform _tn ) 
	{
		_tn.localPosition = new Vector3 ( 10000, 0 , 0 );
	}
	
	public static void ShowForBringIn ( Transform _tn ) 
	{
		_tn.localPosition = Vector3.zero;
	}
	
	
	public static void MoveParent ( Transform _move , Transform _parent )
	{
		_move.parent = _parent;
	}


	public static string DisplayMoney ( long _money )
	{
		return _money.ToString( "N00", myCi );
	}

	public static string DisplayMoney ( int _money )
	{
		return _money.ToString( "N00", myCi );
	}

	public static string DisplayMoney ( float _money )
	{
		return _money.ToString( "C2", myCi );
	}

	public static void SafeCall ( ref VOID_FUN_VOID _on )
	{
		VOID_FUN_VOID _dumi = _on;

		_on = null;

		if ( _dumi != null )
		{
			_dumi ();
		}
	}


	public static bool IsChance100 ( int _value )
	{
		if ( Random.Range ( 0 , 100 ) < _value )
		{
			return true;
		}
		else 
		{
			return false;
		}
	}



	public static GameObject InstantGameObject ( string _path ) 
	{
		List < Object > _res = new List<Object> ();

		_res.Add ( Resources.Load ( _path ) );

		return Instantiate ( _res[ 0 ] ) as GameObject;
	}



	public static Color MakeColor ( int _r , int _g , int _b , int _a )
	{
		Color _color = new Color ( _r / 255f , _g / 255f , _b / 255f , _a / 255f );

		return _color;
	}
	/*
	public static string MakeVersionFull(int _version, string _after)
	{
		return string.Format( StaticMsg.VERSION , Util.MakeVersion(_version) ) + _after;
	}
	*/
	public static string MakeVersion( int _version )
	{
		string _toString  = _version.ToString();
		
		System.Text.StringBuilder _sb = new System.Text.StringBuilder ();
		
		for( int i = 0 ; i < _toString.Length ; i++ )
		{
			_sb.Append ( _toString[ i ] );
			
			if ( i < _toString.Length - 1 )
			{
				_sb.Append ( '.' );
			}
		}
		
		return _sb.ToString ();
	}

	public static Color ChangeAlpha ( Color _color , float _alpha )
	{
		return new  Color ( _color.r , _color.g , _color.b , _alpha );
	}

	public static void TransformInit ( Transform _tn )
	{
		_tn.localPosition = Vector3.zero;
		_tn.localScale = Vector3.one;
		_tn.localRotation = Quaternion.identity;
	}

	static public void DeleteDumi( Transform tnBody, string target )
	{
		Transform searchTransform = null;

		searchTransform = tnBody.Find( target );

		if ( searchTransform != null ) {
			DestroyImmediate( searchTransform.gameObject );
		}
	}

	static public void DeleteDumi( GameObject _dumi )
	{
		if ( _dumi != null ) {
			DestroyImmediate( _dumi );
		}
	}

	public static float RandomPlusMinusOne ()
	{
		if ( Random.Range(0,2) == 0 )
		{
			return -1;
		}
		else 
		{
			return 1;
		}
	}

	public static string InsertChar (string _str, int _jumpChar, char _char)
	{
		System.Text.StringBuilder _sb = new StringBuilder();

		int _cntJump = 0;
		for (int i = 0; i < _str.Length; i++)
		{
			if (_cntJump == _jumpChar)
			{
				_cntJump = 0;
				_sb.Append(_char);
			}

			_sb.Append(_str[i]);
			_cntJump++;
		}

		return _sb.ToString();
	}

	public static int GetMonth( int _month )
	{
		int _m = _month;

		if ( _m < 1 )
		{
			_m = 1;
		}
		else if ( _m > 12 )
		{
			_m = 12;
		}

		return _m;
	}

	public static int GetDay ( int _month , int _day )
	{
		int _dumi = _day % 2;

		if ( _day < 1 )
			_day = 1;

		if ( _month != 2 && _day >= 31 )
		{
			if ( _month < 8 )
			{
				switch ( _dumi )
				{
				case 0:
					_day = 30;
					break;
				case 1:
					_day = 31;
					break;
				}
			}
			else
			{
				switch ( _dumi )
				{
				case 0:
					_day = 31;
					break;
				case 1:
					_day = 30;
					break;
				}
			}
		}

		if ( _month == 2 && _day > 28 )
			_day = 28;


		return _day;
	}
}





































