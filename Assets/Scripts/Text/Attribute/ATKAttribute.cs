using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATKAttribute : MonoBehaviour {

	public ATKSet atkSet;

	Text atkAttribute;

	// Use this for initialization
	void Start () {
		atkAttribute = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		atkAttribute.text = atkSet.ATKOutput;
	}
}
