using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCurrentEXP : MonoBehaviour {

	public Slider currentEXP;

	Text currentExp;
	PlayerLevelData level ;

	// Use this for initialization
	void Start () {
		currentExp = GetComponent<Text> ();
		level = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLevelData>();
	}

	// Update is called once per frame
	void Update () {
		if (level.level < 10) {
			currentExp.text = currentEXP.value.ToString ();
		}else if (level.level == 10) {
			currentExp.text = "---";
		}
	}
}
