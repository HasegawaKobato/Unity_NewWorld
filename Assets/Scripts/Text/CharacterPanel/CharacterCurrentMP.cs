using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCurrentMP : MonoBehaviour {

	public Slider currentMP;

	Text currentMp;

	// Use this for initialization
	void Start () {
		currentMp = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		currentMp.text = currentMP.value.ToString ();
	}
}
