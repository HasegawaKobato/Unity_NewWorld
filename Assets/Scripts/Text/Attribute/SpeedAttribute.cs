using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedAttribute : MonoBehaviour {

	public AGISet speedSet;

	Text speedAttribute;

	// Use this for initialization
	void Start () {
		speedAttribute = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		speedAttribute.text = speedSet.SpeedOutput;
	}
}
