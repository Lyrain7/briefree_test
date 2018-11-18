using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocspinManager : MonoBehaviour {

	public static DocspinManager ins;

	public Dictionary < string , docs_sample > dic_sample = null;


	void Awake()
	{
		ins = this;

		MakeSample ();
	}

	public void MakeSample()
	{
		if (dic_sample != null)
			return;

		dic_sample = new Dictionary<string, docs_sample> ();

		docs_sample _info = null;

		string _cons = "sample_";
		int _idx = 0;

		string _key = _cons + _idx.ToString ();

		DocsPin.DocsData _data = DocsPin.DocsRoot.findData ("sampel");

		while (_data.get<string> (_key, "char0") != null) 
		{
			_key = _cons + _idx.ToString ();

			_info = new docs_sample ();

			_info.char0 = _data.get < string > (_key, "char0");
			_info.char1 = _data.get < string > (_key, "char1");
			_info.char2 = _data.get < string > (_key, "char2");
			_info.ngroup = _data.get < int > (_key, "group");

			_info.arg = _data.get < string > (_key, "arg");

			dic_sample.Add (_key, _info);

			_idx++;
		}


	}
}
