using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMaxMP : MonoBehaviour {
	
	public Slider maxMPSlider;
	public PlayerLevelData maxMp;

	Text maxMP;

	// Use this for initialization
	void Start () {
		maxMP = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		maxMP.text = "/" + maxMp.maxMPOutput;
		maxMPSlider.maxValue = maxMp.maxMPOutput;
	}
}
