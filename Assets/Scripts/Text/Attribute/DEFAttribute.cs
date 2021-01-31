using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEFAttribute : MonoBehaviour {

	public AGISet defSet;

	Text defAttribute;

	// Use this for initialization
	void Start () {
		defAttribute = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		defAttribute.text = defSet.DEFOutput;
	}
}
