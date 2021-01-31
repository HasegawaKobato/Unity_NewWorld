using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KBAttribute : MonoBehaviour {

	public KBSet kbSet;

	Text kbAttribute;

	// Use this for initialization
	void Start () {
		kbAttribute = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		kbAttribute.text = kbSet.KBOutput;
	}
}
