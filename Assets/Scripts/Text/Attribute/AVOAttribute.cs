using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AVOAttribute : MonoBehaviour {

	public AGISet avoSet;

	Text avoAttribute;

	// Use this for initialization
	void Start () {
		avoAttribute = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		avoAttribute.text = avoSet.AVOOutput;
	}
}
