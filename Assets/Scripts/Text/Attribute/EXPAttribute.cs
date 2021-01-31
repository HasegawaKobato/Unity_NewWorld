using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXPAttribute : MonoBehaviour {
	
	public Slider maxEXPSlider;
	public PlayerLevelData maxExp;

	Text maxEXP;

	// Use this for initialization
	void Start () {
		maxEXP = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (maxExp.level < 10) {
			maxEXP.text = maxExp.maxEXPOutput.ToString();
			maxEXPSlider.maxValue = maxExp.maxEXPOutput;
		}else if (maxExp.level == 10) {
			maxEXP.text = "---";
		}
	}
}
