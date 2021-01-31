using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLevel : MonoBehaviour {

	public PlayerLevelData levelText;

	Text lv;

	// Use this for initialization
	void Start () {
		lv = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		lv.text = "Lv." + levelText.level.ToString ();
	}
}
