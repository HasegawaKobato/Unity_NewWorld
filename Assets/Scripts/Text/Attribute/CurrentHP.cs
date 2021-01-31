using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentHP : MonoBehaviour {

	public Slider currentHP;

	Text currentHp;

	// Use this for initialization
	void Start () {
		currentHp = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		currentHp.text = currentHP.value.ToString ();
	}
}
